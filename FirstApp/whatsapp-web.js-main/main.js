const express = require('express'), app = express(), server = require('http').createServer(app), port = process.env.PORT || 3966
const WebSocket = require('ws'), wsServer = new WebSocket.Server({server: server})
const { json } = require('express')
const { Client, MessageMedia } = require('./index'), fs = require('fs'), IsOnlineEmitter = require('is-online-emitter')
const emitter = new IsOnlineEmitter({}) // npm Module to detect change in internet connection
let x = 1, testing = false, state = 'STANDBY'

let ServerSideKnowledge = {
	state: '',
	battery: 0,
	plugged: false,
	name: '',
	phoneno: '',
	qrData: ''
}

current_Web = {
    webInternal: undefined,
    webListener: function(val) {},
    set web(val) {
      this.webInternal = val
      this.webListener(val)
    },
    get web() {
      return this.webInternal
    },
    registerListener: function(listener) {
      this.webListener = listener
    }
}
current_wsClient = {
    clientInternal: undefined,
    clientListener: function(val) {},
    set wsClient(val) {
        this.clientInternal = val
        this.clientListener(val)
    },
    get wsClient() {
        return this.clientInternal
    },
    registerListener: function(listener) {
        this.clientListener = listener
    }
}

current_Web.registerListener(() => {
	if (current_Web.web != undefined) {
	   console.log('A new web created: ' + current_Web.web)
	    initializeWebEvents()
   }
})
current_wsClient.registerListener(() => {
   if (current_wsClient.wsClient != undefined) {
	   console.log('A new client connection')		
	    initializeWebEvents()
   }
})

app.post('*',async (req, res) => {
	console.log(req.query)
	let serverResponse = {
		servermsg: "",
		msg: "not provided",
		img: "not provided"
	}
	if (req.query.purpose == "wts_msg"){
		let serverResponse = {
			result: "fail",
			servermsg: "",
			msg: "not provided",
			img: "not provided"
		}
		try {
			let statePromise = current_Web.web.getState().then((state) => {
				return state
			})
			const getPromisedState = async () => {
				let state = await statePromise
				return state
			}
			const globalValue = await getPromisedState()
			if (globalValue != 'CONNECTED'){
				serverResponse.servermsg = "Server Not Connected To Whatsapp"
				return res.end(JSON.stringify(serverResponse))
			}
		} catch (error) {
			serverResponse.servermsg = "Server Not Connected To Whatsapp"
			return res.end(JSON.stringify(serverResponse))
		}
		let chatId = req.query.phno + "@c.us"
		current_Web.web.isRegisteredUser(chatId).then(async (isRegistered) => {
			if (isRegistered) {
				let msg = req.query.msg
				if(req.query.hands == "true"){msg += "🙏"}

				if (req.query.img.length > 0){
					let media = new MessageMedia("image/jpg", fs.readFileSync(req.query.img, 'base64') , req.query.img)
					await current_Web.web.sendMessage(chatId, media).then((msgDetails) => {
						if (msgDetails.ack >= 0){
							serverResponse.img = "image_sent"
						}else{
							serverResponse.servermsg = "Image Not Sent, Reason: ack < 0 Try connecting to internet"
						}
					})
				}

				if (msg.length > 0 ) {
					await current_Web.web.sendMessage(chatId, msg).then((msgDetails) => {
						if (msgDetails.ack >= 0){
							serverResponse.msg = "message_sent"
						}else{
							serverResponse.servermsg = "Message Not Sent, Reason: ack < 0 Try connecting to internet"
						}
					})
				}

				if (serverResponse.msg == "message_sent" & serverResponse.img == "image_sent"){serverResponse.result = "pass"}
				res.end(JSON.stringify(serverResponse))
			}else{
				serverResponse.servermsg = `Invalid phoneno (${req.query.phno}): This Phno Is Not Registered With Whatsapp`
				return res.end(JSON.stringify(serverResponse))
			}
		})
	}

	if (req.query.purpose == "state"){
		try {
			let statePromise = current_Web.web.getState().then((state) => {return state})
			const getPromisedState = async () => {
				let state = await statePromise
				return state
			}
			let globalValue = await getPromisedState()
			return res.send(globalValue)
		} catch (error) {
			return res.send("NOTCONNECTED")
		}
	}

	if (req.query.purpose == "is_registered"){
		try {
			let chatId = req.query.phno + "@c.us"
			current_Web.web.isRegisteredUser(chatId).then(async (isRegistered) => {
				return res.send(isRegistered)
			})
		} catch (error) {
			return res.send(false)
		}
	}

	if (req.query.purpose == "search_request"){
		let response = {
			servermsg: "",
			result: "",
		}
		try {
			// let x = ["this_key", "this_value", "this_key1", "this_value1", "this_key2", "this_value2"]
			// response.result = x
			// return res.send(JSON.stringify(response))
			current_Web.web.searchMessages(req.query.search_request, {limit: req.query.limit}).then((results) => {
				if (results[0] == undefined) {
					response.servermsg = "No Match found, Reason: Unknown"
					return res.send(JSON.stringify(response))
				}else{
					response.result = results[0].body;
					return res.send(JSON.stringify(response))
				}
			})
		} catch (error) {
			response.servermsg = "Server Side Error: " + error.message
			return res.send(JSON.stringify(response))
		}
	}

	if (req.query.purpose == "get_profile") {
		let response = {
			servermsg: "",
			imgdata: "",
			imgfound: false
		}
		let chatId = req.query.phno + "@c.us"
		try {
			current_Web.web.getProfilePicUrl(chatId).then((profile) => {
				if (profile != undefined){
					response.imgdata = profile
					response.imgfound = true
					return res.send(JSON.stringify(response))
				}else{
					current_Web.web.isRegisteredUser(chatId).then(async (isRegistered) => {
						if (isRegistered){
							response.servermsg = "Profile Image Not Found, Reason: Maybe " + req.query.phno + " Has Made Their Profile Private Or No Profile Picture Is Applied"
							return res.send(JSON.stringify(response))
						}else{
							response.servermsg = "Profile Image Not Found, Reason: " + req.query.phno + " Is Not Registered On Watsapp"
							return res.send(JSON.stringify(response))
						}
					})
				}
		})
		} catch (error) {
			response.servermsg = "Server Side Error: " + error.message
			return res.send(JSON.stringify(response))
		}
	}
	
})

let initializeWebEvents = async () => {
	if (ServerSideKnowledge.state.length > 0 && current_wsClient.wsClient != undefined) {

		await current_Web.web.removeAllListeners('authenticated')
		await current_Web.web.removeAllListeners('auth_failure')
		await current_Web.web.removeAllListeners('qr')
		await current_Web.web.removeAllListeners('ready')
		await current_Web.web.removeAllListeners('change_battery')
		await current_Web.web.removeAllListeners('disconnected')
		await current_Web.web.removeAllListeners('change_state')

		current_Web.web.on('qr',async (qr) => {
			// qrcode.generate(qr, {small: true})
			ServerSideKnowledge.state = 'qr'
			ServerSideKnowledge.qrData = qr
			let data = Object.assign({purpose: 'qr scan'}, ServerSideKnowledge)
			console.log(data)
			current_wsClient.wsClient.send(JSON.stringify(data))
		})			

		current_Web.web.on('ready',async () => {
			current_Web.web.info.getBatteryStatus().then(async (batteryInfo) => {
				ServerSideKnowledge.state = 'CONNECTED'
				let { battery, plugged } = batteryInfo
				ServerSideKnowledge.battery = await battery
				ServerSideKnowledge.plugged = await plugged
				ServerSideKnowledge.name = current_Web.web.info['pushname']
				ServerSideKnowledge.phoneno = current_Web.web.info['wid']['user']
				ServerSideKnowledge.qrData = ''
				let data = Object.assign({purpose: 'web ready'}, ServerSideKnowledge)
				current_Web.web.removeAllListeners('qr')
				console.log("Done")
				current_wsClient.wsClient.send(JSON.stringify(data))
				return
			})
			return
		})

		current_Web.web.on('change_battery',async () => {
			try {
				console.log("battery percentage changed")
				current_Web.web.info.getBatteryStatus().then(async (batteryInfo) => {
					let { battery, plugged } = batteryInfo
					ServerSideKnowledge.battery = await battery
					ServerSideKnowledge.plugged = await plugged
					current_wsClient.wsClient.send(JSON.stringify(ServerSideKnowledge))
				})
			} catch (error) {console.log(error)}
		})

		current_Web.web.on('disconnected',async () => {
			ServerSideKnowledge.state = 'DISCONNECTED'
			current_wsClient.wsClient.send(JSON.stringify(data))
		})
		
		current_Web.web.on('change_state', (state) => {
			console.log('CHANGE STATE', state )
			if (state == CONNECTED){
				ServerSideKnowledge.state = CONNECTED
			}else if (state == CONFLICT){
				ServerSideKnowledge.state = CONFLICT
			}else{
				ServerSideKnowledge.state = STANDBY
			}
			let data = Object.assign({purpose: 'webstatus update'}, ServerSideKnowledge)
			current_wsClient.wsClient.send(JSON.stringify(data))
		})
}}

let NewWeb = () => {
	if (testing) {
		web = new Client({puppeteer: { headless: false }})
		web.initialize()
		console.log("Creating new web...")
		return web
	}
	try {
		x += 1
		// console.log(x)
		const SESSION_FILE_PATH = './session.json'
		let sessionCfg
		if (fs.existsSync(SESSION_FILE_PATH)) {
			sessionCfg = require(SESSION_FILE_PATH)
		}
		let tempWeb;
		if (JSON.stringify(sessionCfg) == JSON.stringify({})){
			console.log(`Failed To Use Saved Session`)
			let web = new Client({ puppeteer: { headless: true }})
			web.initialize()
			console.log("Creating new web...")
			current_Web.web = web
			current_Web.web.on('qr', (qr) =>{
				ServerSideKnowledge.state = 'qr'
				ServerSideKnowledge.qrData = qr
			})
			current_Web.web.on('ready', () => {
				current_Web.web.info.getBatteryStatus().then(async (batteryInfo) => {
					ServerSideKnowledge.state = 'CONNECTED'
					let { battery, plugged } = batteryInfo
					ServerSideKnowledge.battery = await battery
					ServerSideKnowledge.plugged = await plugged
					ServerSideKnowledge.name = current_Web.web.info['pushname']
					ServerSideKnowledge.phoneno = current_Web.web.info['wid']['user']
					ServerSideKnowledge.qrData = ''
					})
				})
			return web
		}else{
			tempWeb = new Client({ puppeteer: { headless: true }, session: sessionCfg })
			tempWeb.initialize()
			tempWeb.on('authenticated', (session) => {
				console.log('AUTHENTICATED: Previous session Used')
				sessionCfg=session
				fs.writeFile(SESSION_FILE_PATH, JSON.stringify(session), function (err) {
					if (err) {
						console.error(`(Session Usable) But Error while writing session on File: ${err}`)
					}
				})
				current_Web.web = tempWeb
				current_Web.web.on('ready', () => {
					current_Web.web.info.getBatteryStatus().then(async (batteryInfo) => {
						ServerSideKnowledge.state = 'CONNECTED'
						let { battery, plugged } = batteryInfo
						ServerSideKnowledge.battery = await battery
						ServerSideKnowledge.plugged = await plugged
						ServerSideKnowledge.name = current_Web.web.info['pushname']
						ServerSideKnowledge.phoneno = current_Web.web.info['wid']['user']
						ServerSideKnowledge.qrData = ''
						current_Web.web.removeAllListeners('authenticated')
						current_Web.web.removeAllListeners('auth_failure')
						current_Web.web.removeAllListeners('qr')
						current_Web.web.removeAllListeners('ready')
						})
					})
				return tempWeb
			})
			tempWeb.on('auth_failure', (msg) => {
				console.log(`Failed To Use Saved Session: ${msg}`)
				tempWeb.destroy()
				let web = new Client
				web.initialize()
				console.log("Creating new web...")
				current_Web.web = web
				current_Web.web.on('qr', (qr) =>{
					ServerSideKnowledge.state = 'qr'
					ServerSideKnowledge.qrData = qr
					console.log(ServerSideKnowledge)
				})
				current_Web.web.on('ready', () => {
					current_Web.web.info.getBatteryStatus().then(async (batteryInfo) => {
						ServerSideKnowledge.state = 'CONNECTED'
						let { battery, plugged } = batteryInfo
						ServerSideKnowledge.battery = await battery
						ServerSideKnowledge.plugged = await plugged
						ServerSideKnowledge.name = current_Web.web.info['pushname']
						ServerSideKnowledge.phoneno = current_Web.web.info['wid']['user']
						ServerSideKnowledge.qrData = ''
						current_Web.web.removeAllListeners('authenticated')
						current_Web.web.removeAllListeners('auth_failure')
						current_Web.web.removeAllListeners('qr')
						current_Web.web.removeAllListeners('ready')
						})
					})
				return web
			})
		}

	} catch (error) {
		console.log(`Error while creating new web: ${error}`)
		return null
	}
}

let startServer = new Promise( (resolve, reject) => {	
	try {
		server.listen(port)

		emitter.on('connectivity.change', async (connection) => {
			if(current_Web.web != undefined){
				current_Web.web.destroy()
			}
			if (connection['status'] == true){
				current_Web.web = await NewWeb()
				if (current_Web.web == undefined){return reject("ERROR: Unable create a new web")}
			}else{
				reject("ERROR: Not connected to internet")
			}
			})
		emitter.start()

		wsServer.on('connection', (wsClient) => {
			current_wsClient.wsClient =  wsClient
			current_wsClient.wsClient.send(JSON.stringify(ServerSideKnowledge))

			if (current_Web.web == undefined){
				try {
					ServerSideKnowledge.state = 'STANDBY'
					let data = Object.assign({purpose: 'webstatus update'}, ServerSideKnowledge)
					current_wsClient.wsClient.send(JSON.stringify(data))
					return
				} catch (error) {console.log(error)}
			}
			
			wsClient.on('message',(message) => {
				console.log(message)
				message = JSON.parse(message)
				if (current_Web.web == undefined){
					try {
						ServerSideKnowledge.state = 'STANDBY'
						let data = Object.assign({purpose: 'webstatus update'}, ServerSideKnowledge)
						current_wsClient.wsClient.send(JSON.stringify(data))
						return						
					} catch (error) {console.log(error)}
				}

				if (message.command == "battery status") {
					try {
						current_Web.web.info.getBatteryStatus().then(async (batteryInfo) => {
							let { battery, plugged } = batteryInfo
							ServerSideKnowledge.battery = await battery
							ServerSideKnowledge.plugged = await plugged
							let data = Object.assign({purpose: 'battery status-res'}, ServerSideKnowledge)
							current_wsClient.wsClient.send(JSON.stringify(data))
						})
					} catch (error) {console.log(error)}
				}

				if (message.command == "send_message") {
					try {
						let chatId = message.phoneno + "@c.us"
						current_Web.web.isRegisteredUser(chatId).then(async (isRegistered) => {
						if (isRegistered) {
							if (message.imagepath.length > 0) {
								let media = new MessageMedia("image/jpg", fs.readFileSync(message.imagepath, 'base64') , message.imagepath)
								await current_Web.web.sendMessage(chatId, media).then(reply => {
									console.log(reply)
								})
							}
							if (message.msg.length > 0) {
								if(message.msg.toLowerCase() == "thanks" || message.msg.toLowerCase() == "thankyou"|| message.msg.toLowerCase() == "thank you"){
									await current_Web.web.sendMessage(chatId, message.msg+"🙏")
								}else{
								await current_Web.web.sendMessage(chatId, message.msg)
								}
							}
						}
					})
					} catch (error) {console.log(error)}
				}

				if (message.command == "is registered"){
					try {
						let chatId = message.phoneno + "@c.us"
						current_Web.web.isRegisteredUser(chatId +"@c.us").then(async (isRegistered) =>{
						if (isRegistered) {
							let data = {
								purpose: "request callback",
								responseId: message.requestId,
								Registered: isRegistered
							}
							current_wsClient.wsClient.send(JSON.stringify(data))
						}
						})
					}catch (error) {}
				}

				if (message.command == "get profile") {
					try {
						let chatId = message.phoneno + "@c.us"
						current_Web.web.getProfilePicUrl(chatId).then((profile) =>{
						let data = {
							purpose: "request callback",
							responseId: message.requestId,
							imageUrl: profile
						}
						current_wsClient.wsClient.send(JSON.stringify(data))
						})
					}catch (error) {}
				}
			})

			wsClient.on('close', () => {
				console.log('Client Left')
			})
		})
		return resolve()		
	} catch (error) {
		return reject(error)
	}
})

startServer.then(() => {
	console.log('Server Started')
}).catch((error) => {
	console.log(`ERROR STARTING SERVER: ${error}`)
})


function sleep(ms) {
	return new Promise((resolve) => {
	setTimeout(resolve, ms)
	})
}

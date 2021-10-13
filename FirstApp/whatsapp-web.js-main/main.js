const express = require('express'),
    app = express(),
    server = require('http').createServer(app),
    port = process.env.PORT || 3966
const WebSocket = require('ws'),
    wsServer = new WebSocket.Server({ server: server })
const { json } = require('express')
const { Client, MessageMedia } = require('./index'), fs = require('fs'), IsOnlineEmitter = require('is-online-emitter')
const emitter = new IsOnlineEmitter({}) // npm Module to detect change in internet connection
let x = 1,
    testing = true

let ServerSideKnowledge = {
    msgInfo: { sender: '', purpose: '', msg: '' },
    serverState: '',
    clientInfo: { battery: '', plugged: false, name: '', phoneno: '' }
}

function clearKnowledge() {
    ServerSideKnowledge.serverState = ""
    ServerSideKnowledge.clientInfo.battery = ''
    ServerSideKnowledge.clientInfo.plugged = false
    ServerSideKnowledge.clientInfo.name = ''
    ServerSideKnowledge.clientInfo.phoneno = ''
    ServerSideKnowledge.msgInfo.sender = ''
    ServerSideKnowledge.msgInfo.purpose = ''
    ServerSideKnowledge.msgInfo.msg = ''
}

current_Web = {
    webInternal: undefined,
    webListener: function (val) { },
    set web(val) {
        this.webInternal = val
        this.webListener(val)
    },
    get web() {
        return this.webInternal
    },
    registerListener: function (listener) {
        this.webListener = listener
    }
}
current_wsClient = {
    clientInternal: undefined,
    clientListener: function (val) { },
    set wsClient(val) {
        this.clientInternal = val
        this.clientListener(val)
    },
    get wsClient() {
        return this.clientInternal
    },
    registerListener: function (listener) {
        this.clientListener = listener
    }
}

current_Web.registerListener(() => {
    if (current_Web.web != undefined) {
        serverlog('A new web created: ' + current_Web.web)
        initializeWebEvents()
    }
})
current_wsClient.registerListener(() => {
    if (current_wsClient.wsClient != undefined) {
        serverlog('A new client connection')
        initializeWebEvents()
    }
})

app.post('*', async (req, res) => {
    serverlog(req.query)

    if (req.query.purpose == "wts_msg") {
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
            if (globalValue != 'CONNECTED') {
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
                if (req.query.hands == "true") { msg += "🙏" }

                if (req.query.img.length > 0) {
                    let media = new MessageMedia("image/jpg", fs.readFileSync(req.query.img, 'base64'), req.query.img)
                    await current_Web.web.sendMessage(chatId, media).then((msgDetails) => {
                        if (msgDetails.ack >= 0) {
                            serverResponse.img = "image_sent"
                        } else {
                            serverResponse.servermsg = "Image Not Sent, Reason: ack < 0 Try connecting to internet"
                        }
                    })
                }

                if (msg.length > 0) {
                    await current_Web.web.sendMessage(chatId, msg).then((msgDetails) => {
                        if (msgDetails.ack >= 0) {
                            serverResponse.msg = "message_sent"
                        } else {
                            serverResponse.servermsg = "Message Not Sent, Reason: ack < 0 Try connecting to internet"
                        }
                    })
                }

                if (serverResponse.msg == "message_sent" & serverResponse.img == "image_sent") { serverResponse.result = "pass" }
                res.end(JSON.stringify(serverResponse))
            } else {
                serverResponse.servermsg = `Invalid phoneno (${req.query.phno}): This Phno Is Not Registered With Whatsapp`
                return res.end(JSON.stringify(serverResponse))
            }
        })
    }

    if (req.query.purpose == "state") {
        try {
            let statePromise = current_Web.web.getState().then((state) => { return state })
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

    if (req.query.purpose == "is_registered") {
        try {
            let chatId = req.query.phno + "@c.us"
            current_Web.web.isRegisteredUser(chatId).then(async (isRegistered) => {
                return res.send(isRegistered)
            })
        } catch (error) {
            return res.send(false)
        }
    }

    if (req.query.purpose == "search_request") {
        let response = {
            servermsg: "",
            result: "",
        }
        try {
            // let x = ["this_key", "this_value", "this_key1", "this_value1", "this_key2", "this_value2"]
            // response.result = x
            // return res.send(JSON.stringify(response))
            current_Web.web.searchMessages(req.query.search_request, { limit: req.query.limit }).then((results) => {
                if (results[0] == undefined) {
                    response.servermsg = "No Match found, Reason: Unknown"
                    return res.send(JSON.stringify(response))
                } else {
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
                if (profile != undefined) {
                    response.imgdata = profile
                    response.imgfound = true
                    return res.send(JSON.stringify(response))
                } else {
                    current_Web.web.isRegisteredUser(chatId).then(async (isRegistered) => {
                        if (isRegistered) {
                            response.servermsg = "Profile Image Not Found, Reason: Maybe " + req.query.phno + " Has Made Their Profile Private Or No Profile Picture Is Applied"
                            return res.send(JSON.stringify(response))
                        } else {
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
    if (ServerSideKnowledge.serverState != "" && current_wsClient.wsClient != undefined && current_Web.web != undefined) {

        await current_Web.web.removeAllListeners('qr')
        await current_Web.web.removeAllListeners('message')
        await current_Web.web.removeAllListeners('ready')
        await current_Web.web.removeAllListeners('change_battery')
        await current_Web.web.removeAllListeners('disconnected')
        await current_Web.web.removeAllListeners('change_state')

        current_Web.web.on('qr', async (qr) => {
            // qrcode.generate(qr, {small: true})
            try {
                clearKnowledge();
                ServerSideKnowledge.msgInfo.sender = 'initializeWebEvents/qr'
                ServerSideKnowledge.msgInfo.purpose = 'qr'
                ServerSideKnowledge.msgInfo.msg = qr
                ServerSideKnowledge.serverState = 'qr'
                current_wsClient.wsClient.send(JSON.stringify(ServerSideKnowledge))
            } catch (error) { serverlog(`initializeWebEvents/qr error: ${error}`) }
        })

        current_Web.web.on('message', async msg => {
            try {
                ServerSideKnowledge.msgInfo.sender = "initializeWebEvents/message"
                ServerSideKnowledge.msgInfo.purpose = "new_msg"
                ServerSideKnowledge.msgInfo.msg = msg.body
                current_wsClient.wsClient.send(JSON.stringify(ServerSideKnowledge))
            } catch (error) { serverlog(`initializeWebEvents/message error: ${error}`) }
        })

        current_Web.web.on('ready', async () => {
            try {
                clearKnowledge();
                ServerSideKnowledge.msgInfo.sender = 'initializeWebEvents/ready'
                ServerSideKnowledge.msgInfo.purpose = 'state changed'
                current_Web.web.info.getBatteryStatus().then(async (batteryInfo) => {
                    let { battery, plugged } = batteryInfo
                    ServerSideKnowledge.serverState = 'CONNECTED'
                    ServerSideKnowledge.clientInfo.battery = await battery
                    ServerSideKnowledge.clientInfo.plugged = await plugged
                    ServerSideKnowledge.clientInfo.name = current_Web.web.info['pushname']
                    ServerSideKnowledge.clientInfo.phoneno = current_Web.web.info['wid']['user']
                    current_Web.web.removeAllListeners('qr')
                    serverlog("Done")
                    current_wsClient.wsClient.send(JSON.stringify(ServerSideKnowledge))
                    return
                })
                return
            } catch (error) { serverlog(`initializeWebEvents/ready error: ${error}`) }
        })

        current_Web.web.on('change_battery', async () => {
            try {
                ServerSideKnowledge.msgInfo.sender = 'initializeWebEvents/change_battery'
                ServerSideKnowledge.msgInfo.purpose = 'battery update'
                serverlog("battery percentage changed")
                current_Web.web.info.getBatteryStatus().then(async (batteryInfo) => {
                    let { battery, plugged } = batteryInfo
                    ServerSideKnowledge.clientInfo.battery = await battery
                    ServerSideKnowledge.clientInfo.plugged = await plugged
                    current_wsClient.wsClient.send(JSON.stringify(ServerSideKnowledge))
                })
            } catch (error) { serverlog(`initializeWebEvents/change_battery error: ${error}`) }
        })

        current_Web.web.on('disconnected', async () => {
            try {
                clearKnowledge();
                ServerSideKnowledge.msgInfo.sender = 'initializeWebEvents/disconnected'
                ServerSideKnowledge.msgInfo.purpose = 'state changed'
                ServerSideKnowledge.serverState = 'DISCONNECTED'
                current_wsClient.wsClient.send(JSON.stringify(ServerSideKnowledge))
            } catch (error) { serverlog(`initializeWebEvents/disconnected error: ${error}`) }
        })

        current_Web.web.on('change_state', (state) => {
            try {
                ServerSideKnowledge.msgInfo.sender = 'initializeWebEvents/change_state'
                ServerSideKnowledge.msgInfo.purpose = 'state changed'
                serverlog('CHANGE STATE', state)
                if (state != CONNECTED && state != CONFLICT) {
                    ServerSideKnowledge.serverState = STANDBY
                } else {
                    ServerSideKnowledge.serverState = state
                }
                current_wsClient.wsClient.send(JSON.stringify(ServerSideKnowledge))
            } catch (error) { serverlog(`initializeWebEvents/change_state error: ${error}`) }
        })

        try {
            ServerSideKnowledge.msgInfo.sender = 'initializeWebEvents/Last'
            ServerSideKnowledge.msgInfo.purpose = 'connection_welcome_msg'
            let globalValue = ''
            try {
                let statePromise = current_Web.web.getState().then((state) => { return state })
                const getPromisedState = async () => {
                    let state = await statePromise
                    return state
                }
                globalValue = await getPromisedState()
            } catch (error) {
                globalValue = 'NOTCONNECTED'
            }

            try {
                current_Web.web.info.getBatteryStatus().then(async (batteryInfo) => {
                    let { battery, plugged } = batteryInfo
                    if (ServerSideKnowledge.serverState != 'qr') { ServerSideKnowledge.serverState = globalValue }
                    ServerSideKnowledge.clientInfo.battery = await battery
                    ServerSideKnowledge.clientInfo.plugged = await plugged
                    ServerSideKnowledge.clientInfo.name = current_Web.web.info['pushname']
                    ServerSideKnowledge.clientInfo.phoneno = current_Web.web.info['wid']['user']
                })
            } catch (error) {
                serverlog(`Error: initializeWebEvents/Last/getBatteryStatus: ${error}`)
            }

            current_wsClient.wsClient.send(JSON.stringify(ServerSideKnowledge))
        } catch (error) {
            serverlog(`Error: initializeWebEvents/Last: ${error}`)
        }

    }
}

let NewWeb = (HeadlessOption = true, ignorePrevious = true) => {
    try {
        x += 1
        // serverlog(x)
        const SESSION_FILE_PATH = './session.json'
        let sessionCfg
        if (fs.existsSync(SESSION_FILE_PATH)) {
            sessionCfg = require(SESSION_FILE_PATH)
        }
        if (ignorePrevious) { fs.writeFile(SESSION_FILE_PATH, JSON.stringify({}), () => { }) }
        let tempWeb;
        if (JSON.stringify(sessionCfg) == JSON.stringify({})) { //No Session Available For Checking->{}

            // serverlog(`Failed To Use Saved Session`)
            let web = new Client({ puppeteer: { headless: HeadlessOption } })
            web.initialize()
            serverlog("Creating new web (New)...")

            web.on('qr', (qr) => {
                // qrcode.generate(qr, {small: true})
                clearKnowledge();
                ServerSideKnowledge.msgInfo.sender = 'NewWeb/qr(Empty Session)'
                ServerSideKnowledge.msgInfo.purpose = 'qr'
                ServerSideKnowledge.msgInfo.msg = qr
                ServerSideKnowledge.serverState = 'qr'
            })

            web.on('ready', () => {
                clearKnowledge();
                ServerSideKnowledge.msgInfo.sender = 'NewWeb/ready(Empty Session))'
                ServerSideKnowledge.msgInfo.purpose = 'state changed'
                web.info.getBatteryStatus().then(async (batteryInfo) => {
                    let { battery, plugged } = batteryInfo
                    ServerSideKnowledge.serverState = 'CONNECTED'
                    ServerSideKnowledge.clientInfo.battery = await battery
                    ServerSideKnowledge.clientInfo.plugged = await plugged
                    ServerSideKnowledge.clientInfo.name = web.info['pushname']
                    ServerSideKnowledge.clientInfo.phoneno = web.info['wid']['user']
                    serverlog("Done")
                })
            })

            web.on('authenticated', (session) => {
                //No Knowledge Update Required
                serverlog('Authenticated')
                sessionCfg = session
                fs.writeFile(SESSION_FILE_PATH, JSON.stringify(session), function (err) {
                    if (err) {
                        serverlog.error(`(Session Created) But Error while writing session on File: ${err}`)
                    }
                })
                initializeWebEvents()
            })

            return web
        } else {

            tempWeb = new Client({ puppeteer: { headless: HeadlessOption }, session: sessionCfg })
            tempWeb.initialize()

            tempWeb.on('authenticated', (session) => {
                sessionCfg = session
                fs.writeFile(SESSION_FILE_PATH, JSON.stringify(session), function (err) {
                    if (err) {
                        serverlog.error(`(Session Usable) But Error while writing session on File: ${err}`)
                    }
                })
                current_Web.web = tempWeb
                serverlog('AUTHENTICATED: Previous session Used' + tempWeb)
                try {
                    ServerSideKnowledge.msgInfo.sender = 'NewWeb/authenticated(else->side)'
                    ServerSideKnowledge.msgInfo.purpose = 'reconnect'
                    ServerSideKnowledge.msgInfo.msg = 'Restart The Connection'
                    if (current_wsClient.wsClient != undefined) {
                        current_wsClient.wsClient.send(JSON.stringify(ServerSideKnowledge))
                    }
                } catch (error) {
                    serverlog(`Error: NewWeb/authenticated(else->side)[FIRST TRY BLOCK]: ${error}`)
                }
            })

            tempWeb.on('auth_failure', (msg) => {
                serverlog(`Failed To Use Saved Session: ${msg}`)
                tempWeb.destroy()
                let web = new Client({ puppeteer: { headless: HeadlessOption } })
                web.initialize()
                serverlog("Creating new web...")

                try {
                    ServerSideKnowledge.msgInfo.sender = 'NewWeb/auth_failure'
                    ServerSideKnowledge.msgInfo.purpose = 'reconnect'
                    ServerSideKnowledge.msgInfo.msg = 'Restart The Connection'
                    if (current_wsClient.wsClient != undefined) {
                        current_wsClient.wsClient.send(JSON.stringify(ServerSideKnowledge))
                        serverlog("sent")
                    }
                } catch (error) {
                    serverlog(`Error: NewWeb/auth_failure ${error}`)
                }

                web.on('qr', (qr) => {
                    // qrcode.generate(qr, {small: true})
                    clearKnowledge();
                    ServerSideKnowledge.msgInfo.sender = 'NewWeb/qr(Empty Session)'
                    ServerSideKnowledge.msgInfo.purpose = 'qr'
                    ServerSideKnowledge.msgInfo.msg = qr
                    ServerSideKnowledge.serverState = 'qr'
                })

                web.on('ready', () => {
                    clearKnowledge();
                    ServerSideKnowledge.msgInfo.sender = 'NewWeb/ready(Empty Session))'
                    ServerSideKnowledge.msgInfo.purpose = 'state changed'
                    current_Web.web.info.getBatteryStatus().then(async (batteryInfo) => {
                        let { battery, plugged } = batteryInfo
                        ServerSideKnowledge.serverState = 'CONNECTED'
                        ServerSideKnowledge.clientInfo.battery = await battery
                        ServerSideKnowledge.clientInfo.plugged = await plugged
                        ServerSideKnowledge.clientInfo.name = current_Web.web.info['pushname']
                        ServerSideKnowledge.clientInfo.phoneno = current_Web.web.info['wid']['user']
                        serverlog("Done")
                    })
                })

                web.on('authenticated', (session) => {
                    //No Knowledge Update Required
                    sessionCfg = session
                    fs.writeFile(SESSION_FILE_PATH, JSON.stringify(session), function (err) {
                        if (err) {
                            serverlog.error(`(Session Created) But Error while writing session on File: ${err}`)
                        }
                    })
                    initializeWebEvents()
                })

                current_Web.web = web
            })
        }
    } catch (error) {
        serverlog(`Error while creating new web: ${error}`)
        return null
    }
}

let startServer = new Promise((resolve, reject) => {
    try {
        server.listen(port)

        emitter.on('connectivity.change', async (connection) => {
            if (current_Web.web != undefined) {
                try { current_Web.web.destroy() } catch (error) { }
            }
            if (connection['status'] == true) {
                current_Web.web = NewWeb()
                if (current_Web.web == undefined) { return reject("ERROR: Unable create a new web") }
            } else {
                serverlog("Internet Turned Off")
                clearKnowledge()
                ServerSideKnowledge.msgInfo.sender = 'startServer(Promise)/connectivity.change->else'
                ServerSideKnowledge.msgInfo.purpose = 'state changed'
                ServerSideKnowledge.msgInfo.msg = 'Device Offline'
                ServerSideKnowledge.serverState = 'STANDBY'
                try {
                    current_wsClient.wsClient.send(JSON.stringify(ServerSideKnowledge))
                } catch (error) {
                    serverlog(`startServer(Promise)/connectivity.change->error ${error}`)
                }
            }
        })
        emitter.start()

        wsServer.on('connection', async (wsClient) => {
            if (current_Web.web == undefined) {
                try {
                    clearKnowledge()
                    ServerSideKnowledge.msgInfo.sender = 'startServer(Promise)/on_connection->Conditional(current_Web.web == undefined)'
                    ServerSideKnowledge.msgInfo.purpose = 'connection_welcome_msg'
                    ServerSideKnowledge.msgInfo.msg = 'Web has not initialised yet'
                    ServerSideKnowledge.serverState = 'STANDBY'
                    wsClient.send(JSON.stringify(ServerSideKnowledge))
                    current_wsClient.wsClient = wsClient
                } catch (error) { serverlog(error) }
            } else {
                ServerSideKnowledge.msgInfo.sender = 'startServer(Promise)/on_connection->Conditional(current_Web.web != undefined)'
                ServerSideKnowledge.msgInfo.purpose = 'connection_welcome_msg'
                if (ServerSideKnowledge.serverState != 'qr') {
                    ServerSideKnowledge.serverState = 'STANDBY'
                }
                let globalValue = ''
                try {
                    let statePromise = current_Web.web.getState().then((state) => { return state })
                    const getPromisedState = async () => {
                        let state = await statePromise
                        return state
                    }
                    globalValue = await getPromisedState()
                } catch (error) {
                    globalValue = 'NOTCONNECTED'
                }

                try {
                    current_Web.web.info.getBatteryStatus().then(async (batteryInfo) => {
                        let { battery, plugged } = batteryInfo
                        ServerSideKnowledge.serverState = globalValue
                        ServerSideKnowledge.clientInfo.battery = await battery
                        ServerSideKnowledge.clientInfo.plugged = await plugged
                        ServerSideKnowledge.clientInfo.name = current_Web.web.info['pushname']
                        ServerSideKnowledge.clientInfo.phoneno = current_Web.web.info['wid']['user']
                    })
                } catch (error) { }

                wsClient.send(JSON.stringify(ServerSideKnowledge))
                current_wsClient.wsClient = wsClient
            }

            wsClient.on('message', (message) => {
                serverlog(message)
                message = JSON.parse(message)

                if (current_Web.web == undefined) {
                    try {
                        ServerSideKnowledge.serverState = 'STANDBY'
                        let data = Object.assign({ purpose: 'webstatus update' }, ServerSideKnowledge)
                        current_wsClient.wsClient.send(JSON.stringify(data))
                        return
                    } catch (error) { serverlog(error) }
                }

                if (message.command == "battery status") {
                    try {
                        current_Web.web.info.getBatteryStatus().then(async (batteryInfo) => {
                            let { battery, plugged } = batteryInfo
                            ServerSideKnowledge.clientInfo.battery = await battery
                            ServerSideKnowledge.clientInfo.plugged = await plugged
                            let data = Object.assign({ purpose: 'battery status-res' }, ServerSideKnowledge)
                            current_wsClient.wsClient.send(JSON.stringify(data))
                        })
                    } catch (error) { serverlog(error) }
                }

                if (message.command == "send_message") {
                    try {
                        let chatId = message.phoneno + "@c.us"
                        current_Web.web.isRegisteredUser(chatId).then(async (isRegistered) => {
                            if (isRegistered) {
                                if (message.imagepath.length > 0) {
                                    let media = new MessageMedia("image/jpg", fs.readFileSync(message.imagepath, 'base64'), message.imagepath)
                                    await current_Web.web.sendMessage(chatId, media).then(reply => {
                                        serverlog(reply)
                                    })
                                }
                                if (message.msg.length > 0) {
                                    if (message.msg.toLowerCase() == "thanks" || message.msg.toLowerCase() == "thankyou" || message.msg.toLowerCase() == "thank you") {
                                        await current_Web.web.sendMessage(chatId, message.msg + "🙏")
                                    } else {
                                        await current_Web.web.sendMessage(chatId, message.msg)
                                    }
                                }
                            }
                        })
                    } catch (error) { serverlog(error) }
                }

                if (message.command == "is registered") {
                    try {
                        let chatId = message.phoneno + "@c.us"
                        current_Web.web.isRegisteredUser(chatId + "@c.us").then(async (isRegistered) => {
                            if (isRegistered) {
                                let data = {
                                    purpose: "request callback",
                                    responseId: message.requestId,
                                    Registered: isRegistered
                                }
                                current_wsClient.wsClient.send(JSON.stringify(data))
                            }
                        })
                    } catch (error) { }
                }

                if (message.command == "get profile") {
                    try {
                        let chatId = message.phoneno + "@c.us"
                        current_Web.web.getProfilePicUrl(chatId).then((profile) => {
                            let data = {
                                purpose: "request callback",
                                responseId: message.requestId,
                                imageUrl: profile
                            }
                            current_wsClient.wsClient.send(JSON.stringify(data))
                        })
                    } catch (error) { }
                }
            })

            wsClient.on('close', () => {
                serverlog('Client Left')
            })
        })
        return resolve()
    } catch (error) {
        return reject(error)
    }
})

startServer.then(() => {
    serverlog('Server Started')
}).catch((error) => {
    serverlog(`ERROR While starting server: ${error}`)
})


function sleep(ms) {
    return new Promise((resolve) => {
        setTimeout(resolve, ms)
    })
}

function serverlog(msg) {
    if (testing == false) {
        let stream = fs.createWriteStream("log.txt", { flags: 'a' });

        Date.prototype.today = function () {
            return ((this.getDate() < 10) ? "0" : "") + this.getDate() + "/" + (((this.getMonth() + 1) < 10) ? "0" : "") + (this.getMonth() + 1) + "/" + this.getFullYear();
        }

        Date.prototype.timeNow = function () {
            return ((this.getHours() < 10) ? "0" : "") + this.getHours() + ":" + ((this.getMinutes() < 10) ? "0" : "") + this.getMinutes() + ":" + ((this.getSeconds() < 10) ? "0" : "") + this.getSeconds();
        }
        var newDate = new Date();
        var datetime = "LastSync: " + newDate.today() + " @ " + newDate.timeNow();
        stream.write(`${msg} ${datetime} \n`);
        stream.end();
    } else {
        console.log(msg);
    }
}
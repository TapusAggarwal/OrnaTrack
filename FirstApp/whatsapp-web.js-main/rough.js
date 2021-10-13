// const express = require('express')
// const app = express();
// const port = 3000;

// app.listen(port, () => { console.log(`Listening on port ${port}`) });
// app.use(express.json());

// app.post('*', (req, res) => {
//     // console.log(req.query.hands);
//     // res.send(req.query);
//     console.log(req.query)
//     if (req.query.msg != undefined) {
//         if (req.query.msg == "hi") {
//             res.send("you sent a hi message")
//         }
//     }
// })

// console.log("Starting server")
// app.get('/name/:Cname', (req, res) => {
//     res.send('hi WORLD' + req.params.Cname);
// })



// // app.get("/:no", (req, res) => {
// // 	res.send(req.params.no)
// // })

// // var fs = require('fs'),
// // request = require('request');

// // function download(uri, filename, callback){
// //   request.head(uri, function(err, res, body){
// //     console.log('content-type:', res.headers['content-type']);
// //     console.log('content-length:', res.headers['content-length']);

// //     request(uri).pipe(fs.createWriteStream(filename)).on('close', callback);
// //   });
// // };

// // download('https://www.google.com/images/srpr/logo3w.png', 'google.png', function(){
// //   console.log('done');
// // });

// const express = require('express');
// // const puppeteer = require('puppeteer-core');

// const app = express();

// app.get('/say_my-name', async (req, res) => {
//     // puppeteer.launch()
//     // const browser = await puppeteer.connect({ browserWSEndpoint: 'ws://localhost:3000' });
//     // const page = await browser.newPage();

//     // await page.goto('http://www.google.com/');
//     // const data = await page.screenshot();
//     // browser.close();

//     res.end(data, 'Chirag tapus');
// });

// app.listen(8080);


// '*⚖ CHD SARAFA ASSO.®⚖*\n' +
//       '7/08/2021,09:40\n' +
//       '*💵 1760.19 💰74.15*\n' +
//       'GOLD LIVE~ *CLOSED*\n' +
//       'PLATE-99.50~48400 WITH GST BILL\n' +
//       '23 KT ~ 47200\n' +
//       '22 KT SELL~*45700*\n' +
//       '20 KT SELL~41900\n' +
//       '18 KT~38000\n' +
//       '14 KT~29700\n' +
//       'GINNI~37900\n' +
//       'SILVER LIVE *CLOSED*\n' +
//       'SILVER ~68000 WITH GST BILL\n' +
//       'SURAJ CHAUHAN\n' +
//       '09815699311'

// const fs = require('fs')
// var stream = fs.createWriteStream("log.txt", {flags:'a'});
// console.log(new Date().toISOString());
// stream.write("hi" + "\n");

// console.log(new Date().toISOString());
// stream.end();

// function serverlog(msg) {
// 	let stream = fs.createWriteStream("log.txt", {flags:'a'});

// 	Date.prototype.today = function () { 
// 		return ((this.getDate() < 10)?"0":"") + this.getDate() +"/"+(((this.getMonth()+1) < 10)?"0":"") + (this.getMonth()+1) +"/"+ this.getFullYear();
// 	}

// 	// For the time now
// 	Date.prototype.timeNow = function () {
// 		return ((this.getHours() < 10)?"0":"") + this.getHours() +":"+ ((this.getMinutes() < 10)?"0":"") + this.getMinutes() +":"+ ((this.getSeconds() < 10)?"0":"") + this.getSeconds();
// 	}
// 	var newDate = new Date();
// 	var datetime = "LastSync: " + newDate.today() + " @ " + newDate.timeNow();

// 	stream.write(`${msg} ${datetime} \n`);

// 	stream.end();
// }

// serverlog("hello log file this is what it is")

// function name1(params = "hi") {
//     console.log(params);
// }
// name1("hello");
//purpose:
//qr
//state changed
//connection_welcome_msg

// const EventEmitter = require('events');
// const myEmitter = new EventEmitter();

// let x = async() => {
//     myEmitter.on("done", ()=>{

//     });
// }

// x()

// let y = new Promise(async(resolve, reject) => {
//     console.log("1")
//     let s = await x();
//     console.log(s);
//     await sleep(3000);
//     myEmitter.emit("done")
//     console.log("1")
// })

// function sleep(ms) {
//     return new Promise((resolve) => {
//         setTimeout(resolve, ms)
//     })
// }
// const fs = require('fs')
// const SESSION_FILE_PATH = './session.json'
// let session = { "WABrowserId": "\"/N4mUQ2+EFDwKugdqBKpOQ==\"", "WASecretBundle": "{\"key\":\"G/+xBxA3y94TJfj3VUZHLTJy1CFv5Cjv0FART99Lxmo=\",\"encKey\":\"2/25AK5ON3YvwTpazTEeZxOFR/SyBnaUuTSPGkiztvE=\",\"macKey\":\"G/+xBxA3y94TJfj3VUZHLTJy1CFv5Cjv0FART99Lxmo=\"}", "WAToken1": "\"PiV2CX7hTWOcXF7Ry5nzmTjauvW50PcT/1TKXq8BXLU=\"", "WAToken2": "\"1@/YpbB0YXayFicE6KFTBnLf3Fcr3XhEpubj8GJOCW1tu4KVAcH+0VCqqHHXXQTKDk065wo64+Q7C/Lg==\"" }
// fs.writeFile(SESSION_FILE_PATH, JSON.stringify(session), function (err) {
//     if (err) {
//         serverlog(`(Session Created) But Error while writing session on File: ${err}`)
//     }
// })
const emitter = new IsOnlineEmitter({})

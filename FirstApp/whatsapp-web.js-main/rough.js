// const express = require('express')
// const app = express();
// const port = 3000;

// app.listen(port, () => {console.log(`Listening on port ${port}`)});
// app.use(express.json());

// app.post('*', (req, res) => {
// 	console.log(req.query.hands);
// 	res.send(req.query);
// })

// // app.get('/', (req, res) => {
// // 	res.send('hi WORLD');
// // })

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
// const puppeteer = require('puppeteer-core');

// const app = express();

// app.get('/image', async (req, res) => {
//     console.log("hi")
//     puppeteer.launch()
//     const browser = await puppeteer.connect({ browserWSEndpoint: 'ws://localhost:3000' });
//     const page = await browser.newPage();

//     await page.goto('http://www.google.com/');
//     const data = await page.screenshot();
//     browser.close();

//     return res.end(data, 'binary');
// });

// app.listen(8080);
// let asd = []
// console.log(asd[0])


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

const express = require('express');
const app = express();
const multer = require('multer');
const path = require('path');

const storage = multer.diskStorage({
    destination: './images',
    filename: (req, file, cb) => {
        return cb(null, `${Date.now()}_${file.originalname}`);
    }
})

const upload = multer({
    storage: storage
})

// app.post('*', async (req, res) => {

//     console.log(req.query)
//     res.send("recieved")
// }
// )

app.post("/upload", upload.single('tapus'), (req, res) => {
    console.log(req.body)
    console.log(req.file)
    // console.log(req)
    res.send("hello")
})

app.listen(4000, () => {
    console.log("server listening on port 4000")
})

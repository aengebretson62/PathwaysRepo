/*
const EventEmitter = require('events');

const Logger = require('./logger');
const logger = new Logger();

logger.on('messageLogged', function(e) {
    console.log('Message heard!' + e.id + ' ' + e.url)
})

logger.log('This is my message.');
*/

const http = require('http');

const server = http.createServer((req,res) => {
    if (req.url === '/'){
        res.write('Hello world!');
        res.end();
    }

    if (req.url === '/api/courses') {
        res.write(JSON.stringify([1, 2, 3]));
        res.end();
    }
});

server.listen(3000);

console.log('Listening on 3000...');
/*
 * GET home page.
 */
import express = require('express');
const router = express.Router();

var getData = function () {
    var data = {
        'item1': 'https://theplaidhorse.s3.amazonaws.com/media/uploads/2020/08/AdobeStock_326500445-1-scaled.jpeg',
        'item2': 'https://equusmagazine.com/.image/t_share/MTc4NjI5NjMwMDkyMTI1OTg0/horse-galloping-on-sand.jpg',
        'item3': 'https://horsej-intellectsolutio.netdna-ssl.com/cdn/farfuture/SVD1oaF2ITMncqEBjp-F4wIPN3Iqw8M25m7mvjCT1-Q/mtime:1543626961/files/styles/article_large/public/pictures-videos/blogs/shutterstock_250751620_-_grigorita_ko_-_web.jpg?itok=dr2UJXfv'
    }
    return data;
}

router.get('/', function (req, res) {
    res.render('index', { title: 'Express', "data" : getData() });
});

export default router;
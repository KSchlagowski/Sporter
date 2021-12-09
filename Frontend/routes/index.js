const router = require('express').Router(),
    axios = require('axios'),
    CircularJSON = require('circular-json');

router.get('/', async (req, res, next) => {
    axios.get('http://localhost:5000/Client/AddClient')
        .then(data => {
            res.render('index', {
                data: CircularJSON.stringify(data.data),
            });
        })
        .catch(error => {
            console.log(error.message);
            return;
        })
});
router.get('/contact', (req, res, next) => {
    res.render('contact')
})
router.get('/item', (req, res, next) => {
    res.render('item')
})
module.exports = router;
const router = require('express').Router();

router.get('/', (req, res, next) => {
    res.render('index');
});
router.get('/contact', (req, res, next) => {
    res.render('contact')
})
router.get('/item', (req, res, next) => {
    res.render('item')
})
module.exports = router;
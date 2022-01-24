const router = require('express').Router(),
    axios = require('axios'),
    CircularJSON = require('circular-json');

/* INDEX */

router.get('/', async (req, res, next) => {
    await axios.get('http://localhost:5000/Client/AddClient')
        .then(data => {
            res.render('index', {
                data: JSON.parse(CircularJSON.stringify(data.data)),
            });
        })
        .catch(error => {
            console.log(error.message);
            return;
        })
});

/* CATEGORIES */

router.get('/categories/:category', async (req, res, next) => {
    await axios.get('http://localhost:5000/Item/GetItemsByCategory')
        .then(data => {
            res.render('index', {
                data: JSON.parse(CircularJSON.stringify(data.data)),
            });
        })
        .catch(error => {
            console.log(error.message);
            return;
        })
});

/* ITEM */

router.get('/item/:id', async (req, res, next) => {
    await axios.get('http://localhost:5000/Item/GetItemsByCategory')
        .then(data => {
            res.render('index', {
                data: JSON.parse(CircularJSON.stringify(data.data)),
            });
        })
        .catch(error => {
            console.log(error.message);
            return;
        })
});
router.get('/item/below/:price', async (req, res, next) => {
    await axios.get('http://localhost:5000/Item/GetItemsBelowPrice')
        .then(data => {
            res.render('index', {
                data: JSON.parse(CircularJSON.stringify(data.data)),
            });
        })
        .catch(error => {
            console.log(error.message);
            return;
        })
});
router.get('/item/above/:price', async (req, res, next) => {
    await axios.get('http://localhost:5000/Item/GetItemsAbovePrice')
        .then(data => {
            res.render('index', {
                data: JSON.parse(CircularJSON.stringify(data.data)),
            });
        })
        .catch(error => {
            console.log(error.message);
            return;
        })
});


/* PROFILE EDIT */

router.get('/profile/contact', async (req, res, next) => {
    await axios.get('http://localhost:5000/Client/AddClientContactInformation')
        .then(data => {
            res.render('index', {
                data: JSON.parse(CircularJSON.stringify(data.data)),
            });
        })
        .catch(error => {
            console.log(error.message);
            return;
        })
});
router.post('/profile/contact', async (req, res, next) => {
    await axios.post('http://localhost:5000/Client/EditClientContactInformation')
        .then(data => {
            res.render('index', {
                data: JSON.parse(CircularJSON.stringify(data.data)),
            });
        })
        .catch(error => {
            console.log(error.message);
            return;
        })
});
router.get('/profile/address', async (req, res, next) => {
    await axios.get('http://localhost:5000/Client/EditAddress')
        .then(data => {
            res.render('index', {
                data: JSON.parse(CircularJSON.stringify(data.data)),
            });
        })
        .catch(error => {
            console.log(error.message);
            return;
        })
});
router.post('/profile/address', async (req, res, next) => {
    await axios.post('http://localhost:5000/Client/EditAddress')
        .then(data => {
            res.render('index', {
                data: JSON.parse(CircularJSON.stringify(data.data)),
            });
        })
        .catch(error => {
            console.log(error.message);
            return;
        })
});
router.delete('/profile/address', async (req, res, next) => {
    await axios.delete('http://localhost:5000/Client/DeleteAddress')
        .then(data => {
            res.render('index', {
                data: JSON.parse(CircularJSON.stringify(data.data)),
            });
        })
        .catch(error => {
            console.log(error.message);
            return;
        })
});
// router.get('/profile/details', async (req, res, next) => {
//     await axios.get('http://localhost:5000/Client/AddClient')
//         .then(data => {
//             res.render('index', {
//                 data: JSON.parse(CircularJSON.stringify(data.data)),
//             });
//         })
//         .catch(error => {
//             console.log(error.message);
//             return;
//         })
// });
// router.post('/profile/details', async (req, res, next) => {
//     await axios.post('http://localhost:5000/Client/AddClient')
//         .then(data => {
//             res.render('index', {
//                 data: JSON.parse(CircularJSON.stringify(data.data)),
//             });
//         })
//         .catch(error => {
//             console.log(error.message);
//             return;
//         })
// });
router.get('/profile', async (req, res, next) => {
    await axios.get('http://localhost:5000/Client/GetClient')
        .then(data => {
            res.render('profile', {
                data: JSON.parse(CircularJSON.stringify(data.data)),
            });
        })
        .catch(error => {
            console.log(error.message);
            return;
        })
});


module.exports = router;
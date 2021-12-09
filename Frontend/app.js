const express = require('express'),
    PORT = process.env.PORT || 3000,
    app = express(),
    ejsMate = require('ejs-mate'),
    dotenv = require('dotenv'),
    path = require('path'),
    cors = require('cors'),
    index = require('./routes/index');

dotenv.config({ path: './config/config.env' });
app.engine('ejs', ejsMate);
app.set('view engine', 'ejs');
app.set('views', path.join(__dirname, 'views'));
app.use(express.static(__dirname + '/public'));
app.use(express.urlencoded({ extended: false }));
app.use(express.json());
app.use(cors());
app.use((req, res, next) => { next() });
app.use('/', index)
app.listen(PORT, console.log(`Server is running in ${process.env.NODE_ENV} on port ${PORT}`));
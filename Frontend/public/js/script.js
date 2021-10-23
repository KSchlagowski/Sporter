function openSearch() {
    if (document.getElementById('input-search').style.display === 'flex') {
        document.getElementById('input-search').style.display = 'none';
        document.getElementById('cart').style.display = 'flex';
        document.getElementById('profile').style.display = 'flex';
    } else {
        document.getElementById('input-search').style.display = 'flex';
        document.getElementById('cart').style.display = 'none';
        document.getElementById('profile').style.display = 'none';
    }
}
function openCart() {
    if (document.getElementById('cart-open').style.display === 'flex') {
        document.getElementById('cart-open').style.display = 'none';
    } else {
        document.getElementById('cart-open').style.display = 'flex';
    }
}
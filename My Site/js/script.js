// script.js
function addToCart(name) {
    let cart = JSON.parse(sessionStorage.getItem('cart')) || [];
    cart.push(name);
    sessionStorage.setItem('cart', JSON.stringify(cart));
}

//checkout.js
function loadCart() {
    let cart = JSON.parse(sessionStorage.getItem('cart')) || [];
    let cartElement = document.getElementById('cart');

    // Clear existing content
    cartElement.innerHTML = '';

    // Loop through each product in the cart and display it
    cart.forEach((product) => {
        cartElement.innerHTML += `<div>${product}</div>`;
    });
}

function removeFromCart(index) {
    let cart = JSON.parse(sessionStorage.getItem('cart'));
    cart.splice(index, 1);
    sessionStorage.setItem('cart', JSON.stringify(cart));
    loadCart(); // Refresh the cart display
}

function placeOrder() {
    sessionStorage.removeItem('cart'); // Clear the cart
    window.location = 'thank-you.html'; // Redirect to the thank-you page
}
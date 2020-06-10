$(document).ready(function () {
    $('#register-btn').on('click', function () {
        window.dispatchEvent(new CustomEvent('REGISTER_CLICK'));
    });
});
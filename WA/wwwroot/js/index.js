$(document).ready(function () {

    var x = 0;
    var s = " ";

    console.log("Hello");



    var theForm = $("#theForm");
    //theForm.hide();

    var button = $("#BuyButton");
    button.on("click", function () {
        console.log("Buying Item");
    });

    var productInfo = $(".door-attributes li");
    productInfo.on("click", function () {
        console.log("You clicked on " + $(this).text());
    });

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        $popupForm.fadeToggle(1000);
    });
});

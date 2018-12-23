jQuery(document).ready(function ($) {

    var categories = $("#fixedbut");
    var searchbox = $(".fixedright");
    var footer = $(".footer").offset().top;
    $(window).scroll(function () {
        var scroll = $(window).scrollTop();
        var posY = footer - scroll;
        if ((scroll >= posY) && (posY > 0)) {
            categories.hide(500);
            searchbox.hide(500);
        } else{
            categories.show(500);
            searchbox.show(500);
        }
    });


});
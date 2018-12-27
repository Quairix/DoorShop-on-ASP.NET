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

$(document).ready(function () {
    $('#BuyButton').click(function (event) {
        event.stopPropagation();
        var data = {
            'message': $(this).attr("name"),
        }

        $.ajax({
            url: 'MessageHandler',
            type: 'POST',
            data: JSON.stringify(data),
            cache: false,
            dataType: 'json',
            processData: false,
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                if (data == true) {
                    alert("Сообщение доставлено");
                    location.reload();
                }
                else {
                    alert("Внимание! Сообщение не доставлено!");
                }
            },
            error: function () {
                alert("Произошел сбой бла бла бла");
            }
        });
    });
});
jQuery(document).ready(function ($) {

    $('.responsive').slick({
        dots: false,
        infinite: false,
        speed: 300,
        slidesToShow: 5,
        slidesToScroll: 5,
        nextArrow: '<img src="arrow-right.png" class="slide-arrow arrow-right" alt="arrow-right"/>',
        prevArrow: '<img src="arrow-left.png" class="slide-arrow arrow-left" alt="arrow-left"/>',
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    slidesToShow: 4,
                    slidesToScroll: 4,
                }
            },
            {
                breakpoint: 600,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 3
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 2
                }
            }
        ]
    });

    var header = $("#main-nav");
    var OuterHeaderHeight = $("#main-nav").outerHeight();
    $(window).scroll(function () {
        var scroll = $(window).scrollTop();

        if (scroll >= OuterHeaderHeight) {
            header.removeClass("header").addClass("fixed");
            HeaderHeight = $("#main-nav.fixed").outerHeight();
        } else {
            header.removeClass("fixed").addClass("header");
        }
    });

    $(".scroll-down").click(function () {
        if ($(window).width() > 767) {
            $('html, body').animate({
                scrollTop: $(".aboutus-section").offset().top - 83
            }, 1500);
        }
        else {
            $('html, body').animate({
                scrollTop: $(".aboutus-section").offset().top - 63
            }, 1500);
        }
    });

});
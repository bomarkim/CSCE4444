// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
angular.module('record', []).controller('SiteCtrl', ['$scope', function ($scope) {

    $('.autoplay').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        autoplay: true,
        autoplaySpeed: 2000,
    });

    $('.record-car').slick({
        slidesToShow: 5,
        slidesToScroll: 5,
    });
}]);


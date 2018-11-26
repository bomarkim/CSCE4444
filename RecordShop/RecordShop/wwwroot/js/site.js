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

    $scope.listOfAlbums = [
        {
            name: "Album1",
            img: "Not a link yet, because I don't know how to just yet."
        },
        {
            name: "Album2",
            img: "Not a link yet, because I don't know how to just yet."
        },
        {
            name: "Album3",
            img: "Not a link yet, because I don't know how to just yet."
        },
        {
            name: "Album4",
            img: "Not a link yet, because I don't know how to just yet."
        },
        {
            name: "Album5",
            img: "Not a link yet, because I don't know how to just yet."
        },
        {
            name: "Album6",
            img: "Not a link yet, because I don't know how to just yet."
        },
        {
            name: "Album7",
            img: "Not a link yet, because I don't know how to just yet."
        },
        {
            name: "Album8",
            img: "Not a link yet, because I don't know how to just yet."
        },
        {
            name: "Album9",
            img: "Not a link yet, because I don't know how to just yet."
        },
        {
            name: "Album10",
            img: "Not a link yet, because I don't know how to just yet."
        }
<<<<<<< HEAD
    ];
=======
        ];
>>>>>>> master

    $scope.album = {
        name: "Abbey Road",
        imgSrc: "~/images/AbbeyRoad.jpg",
        distributer: "That place down the road",
        description: "This is an album that is good and has an iconic album cover. Get it before it runs out!",
        price: 29.99
    };
}]);


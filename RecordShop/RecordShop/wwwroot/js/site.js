// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var app = angular.module("record", ["ngRoute"]);
app.config(function ($routeProvider) {
    $routeProvider
        .when("/Album", {
            controller: "AlbumCtrl"
        })
        .when("/", {
            controller: "IndexCtrl"
        })
        .when("/RecordList", {
            controller: "RecordListCtrl"
        })
        .when("/AddRecord", {
            controller: "AddRecordCtrl"
        });
})

app.controller('SiteCtrl', ['$scope', function ($scope) {

   

    


    
}]);

app.controller("IndexCtrl", function ($scope) {
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

    ];

    $scope.name = "";
    
});

app.controller("LayoutCtrl", function ($scope) {
    $scope.user = {
        email: "",
        password: ""
    };

    $scope.clearUserInfo = function () {
        user.email = "";
        user.password = "";
    };

    $scope.submitUserInfo = function (form) {
        //Do the thing that puts it into the database
        //$http.post (........)
        //will go to the HomeController unless we want another controller to do all this stuff with (probs not)
    };
   
});

app.controller("AlbumCtrl", function ($scope) {
    $scope.album = {
        name: "Abbey Road",
        imgSrc: "~/images/AbbeyRoad.jpg",
        distributer: "That place down the road",
        description: "This is an album that is good and has an iconic album cover. Get it before it runs out!",
        price: 29.99
    };
});

app.controller("RecordListCtrl", function ($scope) {
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

    ];
});

app.controller("AddRecordCtrl", function ($scope) {
    $scope.album = {
        name: "",
            artist: "",
            genre: "",
            price: "",
            picture: ""
            
    };
    $scope.submitForm() = function () {
        //do the thing that puts it in the database
    };
});


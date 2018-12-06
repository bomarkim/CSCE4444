﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
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

app.controller('CartCtrl', function ($scope) {
        $scope.albums = [{
            name: "Album 1",
            description: "This is an album.",
            price: 12.99
        }, {
            name: "Album 2",
            description: "This is an album.",
            price: 12.99
        }, {
            name: "Album 3",
            description: "This is an album.",
            price: 12.99
        }, {
            name: "Album 4",
            description: "This is an album.",
            price: 12.99
        }, {
            name: "Album 5",
            description: "This is an album.",
            price: 12.99
        }, {
            name: "Album 6",
            description: "This is an album.",
            price: 12.99
        }, {
            name: "Album 7",
            description: "This is an album.",
            price: 12.99
        }, {
            name: "Album 8",
            description: "This is an album.",
            price: 12.99
        }, {
            name: "Album 9",
            description: "This is an album.",
            price: 12.99
        }, {
            name: "Album 10",
            description: "This is an album.",
            price: 12.99
        }, {
            name: "Album 11",
            description: "This is an album.",
            price: 12.99
        },
        ];
    
    $scope.cart = {
        totalPrice: 0
    };
    $scope.getTotalPrice = function () {
        $scope.cart.totalPrice = 0;
        angular.forEach($scope.albums, function (item) {
            $scope.cart.totalPrice += item.price;
        });
    }();
   
    
    $scope.removeAlbum = function (album) {
        var index = $scope.albums.indexOf(album);
        $scope.albums.splice(index, 1);
    }

    
});

app.controller("IndexCtrl", function ($scope, $http) {
    $('.autoplay').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        autoplay: true,
        autoplaySpeed: 2000,
    });
    $(".slider").slick({
        slidesToShow: 3,
        infinite: true,
        slidesToScroll: 2
        
    });
    $scope.init = function () {
        $scope.loading = true;
        
        

    }();
    $http.get("/Records/getAllRecords")
        .then(function (response) {
            $scope.listOfRecords = response.data;
            $scope.loading = false;
        }, function (response) {
            console.log(response);
        });

        
    
    

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

app.controller("AlbumCtrl", function ($scope, $http) {
    $scope.init = function (ID) {
        $http.get("/Records/getAlbum?recordId=" + ID)
            .then(function (response) {
                $scope.album = response.data;
            });
    }
    console.log($scope.album);
});

app.controller("RecordListCtrl", function ($scope, $http) {
    $http.get("/Records/getAllRecords")
        .then(function (response) {
            $scope.listOfRecords = response.data;
        })
    
});

app.controller("AddRecordCtrl", function ($scope, $http) {
    $scope.album = {
        name: "",
            artist: "",
            genre: "",
            price: "",
            picture: ""     
    };
    $scope.submitForm() = function () {
        //do the thing that puts it in the database
        //$http.post("Records/addRecord/{record})
    };
});


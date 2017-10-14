angular.module("IlogicApp", [])
       .controller("productosController", function ($scope, Productos) {

           $scope.productosx = Productos.get();
           $scope.IsVisible = false;
           $scope.Getprod = function (event, item) {
               $scope.IsVisible = true;
               $scope.itemX = item;
               $scope.caracteristicas = item.caracteristicas ? item.caracteristicas.split(".") : [];

               event.preventDefault();

               var full_url = '#portfolio-single-wrap',
               parts = full_url.split("#"),
               trgt = parts[1],
               target_top = $("#" + trgt).offset().top;

               $('html, body').animate({ scrollTop: target_top }, 600);
               $('#portfolio-single').slideUp(500, function () {

                   $(this).slideDown(500);

               });
           }




       });
      
angular.module('IlogicServices', [])
.factory("Productos", ['$window', function ($window) {

    var get = function () {
       
        return productos;
    }
    var getProdContent = function (index, property) {
        var content = productos.find(function (producto) {
            return producto.id === index;

        });
        return content[property];
    }
    return {
        getProdContent: getProdContent,
        get:get
    }


}]);
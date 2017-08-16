$(document).ready(function () {
    $("#btnjsn").click(function () {
        GetAllProducts();
    });
});


$ajax({
    type: 'Get',
    url: 'http://localhost:63618/api/product',
    contentType: "aplication/json;chatset=utf-8",
    dataType: "json",
    succes: function (data) {

    },
    error: function (a, b, c) { }
});


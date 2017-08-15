
$(document).ready(function () {

    $("#catal").append(buildMyProduct(catalogJS));

});


function buildMyProduct(catalogJS) {

    var html = "";

    $.each(catalogJS, function (element, object) {

        html += "<div class='Catalog ProducItem'>";

        html += "<div><a href='details.html?id=" + object.id + "'>" + object.title + "</a></div>";

        html += "<div><img class='Catalog' src='" + object.imgUrl + "' /></div>";

        html += "<div>" + object.description + "</div></div>";

    });

    return html;

}
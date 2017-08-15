$(document).ready(function () {

    $("#GranDanes").append(buildMyProduct(detailsJS));
    $("#keywordimages").append(PlaceKeywordImages(detailsJS))
});


function buildMyProduct(detailsJS) {

    var html = "";
    var currentURL = window.location.href;
    var urlsplit = currentURL.split("=");
    id = urlsplit[1];
    $.each(detailsJS, function (element, object) {
        if (object.id == id) {
            html += "<div class='Catalog ProducItem'>";

            html += "<div>"+ object.id  +":"+ object.title + "</div>";

            html += "<div><img class='Catalog' src='" + object.imgUrl + "' /></div>";

            html += "<div>" + object.description + "</div></div>";
        }
    });

    return html;

}
function PlaceKeywordImages(detailsJS) {
    var html = "";
    var currentURL = window.location.href;
    var urlsplit = currentURL.split("=");
    id = urlsplit[1];
    $.each(detailsJS, function (element, object) {
        if (object.id != id) {
            html += "<div position ='relative' float 'right'><img width='80' src='" + object.imgUrl + "' /></div>";
        }
    });

    return html;
}
$(document).ready(function () {
    $(".purchase-checkbox").change(function () {
        var productId = $(this).data("product-id");
        var row = $(this).closest("tr");

        if (this.checked) {
            row.css("background-color", "blue");
            // Checkbox işaretlendiğinde satır rengini maviye döndür
        } else {
            row.css("background-color", "");
            // Checkbox kaldırıldığında satır rengini sıfırla
        }
    });
});

//$(document).ready(function () {
//    $(".add-to-cart-button").click(function (e) {
//        e.preventDefault();

//        var addToCartForm = $(this).closest("form");
//        var productName = addToCartForm.find(".card-title a").text();
//        var alertDiv = $(".add-to-cart-alert");

//        alertDiv.find(".product-name").text(productName);
//        alertDiv.addClass("show");

//        setTimeout(function () {
//            alertDiv.removeClass("show");
//        }, 2000); // Bildirimin 5 saniye sonra kaybolmasını sağlar
//    });
//});



$(document).ready(function () {
    
    $("#content-box").fadeIn("slow");

    $(".city-button").on("click", function () {
        var activeCity = $(this).parent().attr("Id");
        GetCompanyAjax(activeCity);
        $(".company-button").fadeIn("slow");
    });

    $(this).on("click", function () {
        $(".company-div").remove();
    });

    //$(".company-button").on("click", function () {
    //    console.log("this button is working");
    //    //$(".city-div").fadeOut("slow");
    //});

});
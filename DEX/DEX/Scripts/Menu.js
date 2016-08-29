$(document).ready(function () {
    
    $("#content-box").fadeIn("slow");

    $(".city-button").on("click", function () {
        var activeCity = $(this).parent().attr("Id");
        GetCompanyAjax(activeCity);
        $(".company-div").fadeIn("slow");
    });

    $(this).on("click", function () {
        $(".company-div").fadeOut("slow")
        $(".company-div").remove();
    });

    //$(".company-button").on("click", function () {
    //    alert("this button is working");
    //    //$(".city-div").fadeOut("slow");
    //});

});
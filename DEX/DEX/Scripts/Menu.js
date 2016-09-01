$(document).ready(function () {
    
    $("#content-box").fadeIn("slow");

    $(".city-div").off("click", ".city-button", function () {
        //$(this).removeClass("active");
        //$(".company-div").fadeOut("slow");
        //$(".company-div").remove();
        console.log("Off has been clicked");
    });

    $(".city-div").on("click", ".city-button", function () {
        //$(this).addClass("active");
        //if ($(this).hasClass("active") == true) {
        //    var activeCity = $(this).parent().attr("Id");
        //    GetCompanyAjax(activeCity);
        //    $(".company-button").fadeIn("slow");
        //}
        console.log("On has been clicked");
    });

    

    //$(".company-button").on("click", function () {
    //    console.log("this button is working");
    //    //$(".city-div").fadeOut("slow");
    //});

});
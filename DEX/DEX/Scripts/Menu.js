$(document).ready(function () {
    
    $("#content-box").fadeIn("slow");

    $(".city-button").on('click', function () {
        var activeCity = $(this).parent().attr("Id");
        GetCityCompanies(activeCity);
        $(".company-div").fadeIn("slow");
    });

    $(".city-button").click(function () {
        $(".company-div").remove();
    });                                                                      

    $("#content-box").on("click", ".company-button", function () {
        var id = $(this).parent().attr("Id");
        $(".city-div").fadeOut("slow");
        var html = GetCompanyDetails(id);
    });

    //$(".dropdown-toggle").click(function () {
    //    console.log("this button is working");
    //    //$(".dropdown-menu").toggleClass("open");
    //});

});
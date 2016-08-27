$(document).ready(function () {
    
    $("#content-box").fadeIn("slow");

    $(".city-button").on("click", function () {
        $(".company-div").remove();
        //$(".add-company").remove();
    });

    $(".city-button").on("click", function () {
        var activeCity = $(this).parent().attr("Id");
        var companies = GetCompanyAjax(activeCity);
        $(this).append(companies);
    });

    

    $(".city-button").bind()

    $(".company-button").on("click", function () {
        alert("this button is working");
        //$(".city-div").fadeOut("slow");
    });

});
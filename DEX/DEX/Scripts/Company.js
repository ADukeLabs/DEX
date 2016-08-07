$(document).ready(function () {

    var menuButtons = $("button.GetCompanies")

    menuButtons.each(function () {
        //menuButtons.addClass("accordian");
        var cityId = $(this).parent().attr("Id");
        GetCompanyAjax(cityId);
    });

    //$(function () {
    //    $(".city-div").accordian({
    //        collapsible: true
    //    });
    //});
    



    //$(".GetCompanies").on("click", function() {
    //    var activeCity = $(this).parent().attr("Id");
    //    GetCompanyAjax(activeCity);
    //});

    //$(".GetCompanies").on("click", function () {
    //    $("div .company-div").remove();
    //});    
});
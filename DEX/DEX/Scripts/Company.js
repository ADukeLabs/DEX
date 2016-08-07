$(document).ready(function () {

    var menuButtons = $("button.GetCompanies")

    menuButtons.each(function () {
        var cityId = $(this).parent().attr("Id");
        GetCompanyAjax(cityId);
    });

    //$(".GetCompanies").on("click", function() {
    //    var activeCity = $(this).parent().attr("Id");
    //    GetCompanyAjax(activeCity);
    //});
    
});
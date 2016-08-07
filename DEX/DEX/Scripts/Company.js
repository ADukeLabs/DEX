$(document).ready(function () {

    

    $(".GetCompanies").on("click", function() {
        var activeCity = $(this).parent().attr("Id");
        GetCompanyAjax(activeCity);
    });

    $(".GetCompanies").on("click", function () {
        $("div .company-div").remove();
    });

    
    
});
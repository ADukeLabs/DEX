$(document).ready(function () {
        
    $("button").on("click", function () {
        var activeCity = $(this).parent().attr("Id");
        GetCompanyAjax(activeCity);
    });

    $(this).on("click", function () {
        $(".company-div").remove();
        $("add-company").remove();
    });

});
$(document).ready(function () {
        
    $("button").on("click", function () {
        var activeCity = $(this).parent().attr("Id");
        GetCompanyAjax(activeCity);
        //$("#city-div").append('<button class="btn btn-primary add-company">Add New Company</button>');
    });

    $(this).on("click", function () {
        $(".company-div").remove();
        $("add-company").remove();
    });

});
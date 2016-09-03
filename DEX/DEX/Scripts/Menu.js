$(document).ready(function () {
    
    $("#content-box").fadeIn("slow");



    $(".city-button").on('click', function () {
        var activeCity = $(this).parent().attr("Id");
        GetCompanyAjax(activeCity);
        $(".company-div").fadeIn("slow");
    });

    $(".city-button").click(function () {
        $(".company-div").remove();
    });                                                                      

    $("body").on("click", ".company-button", function () {
        var id = $(this).parent().attr("Id");
        $("body").fadeOut("slow");
    });

});
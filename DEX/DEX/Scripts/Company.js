$(document).ready(function () {


    function CompanyList(companies, cityId) {
        var html = '<button type="button" id="' + companies.id + '" class="company btn btn-primary>"' + companies.name + '"</button>';
        $("#"+ cityId).append(html);
    }


    function companyAjax(city) {
        var url = "../Company/GetCompanies/";

        $.ajax({
            type: "GET",
            url: url,
            data: { 'id': city },
            dataType: "json",
            success: function (companies) {
                for (var i = 0; i < companies.length; i++) {
                    CompanyList(companies, city);
                }
            },
            error: function () {
                alert: ("Error: There was a problem listing the companies in this city.");
            }
        });
    };



    $(".GetCompanies").on("click",function () {
        var activeCity = $(this).parent().attr("Id");
        companyAjax(activeCity);
    });

});
$(document).ready(function () {


    function CompanyList(company, cityId) {
        var html = '<div id="' + JSON.parse(company.Id) + '"class="company-div col-xs-8 col-xs-offset-4">"' +
                        '<button type="button" class="company-button btn btn-primary btn-block>'+company.Name+'</button>' +
                    '"</div>';

        $("#" + cityId).append(html);
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
                    CompanyList(companies[i], city);
                }
            },
            error: function () {
                alert: ("Error: There was a problem listing the companies in this city.");
            }
        });
    };



    $(".GetCompanies").on("click", function () {
        var activeCity = $(this).parent().attr("Id");
        $(this).fadeIn(companyAjax(activeCity));
    });

});
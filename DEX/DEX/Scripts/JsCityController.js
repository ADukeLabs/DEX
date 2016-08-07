function CompanyList(company, cityId) {
    $("#" + cityId).append('<div id="' + JSON.parse(company.Id) + '"class="company-div col-xs-10 col-sm-6 col-sm-offset-4">' +
                                '<button type="button" class="company-button btn btn-primary">' + company.Name + '</button>' +
                            '</div>');
};


function GetCompanyAjax(city) {
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
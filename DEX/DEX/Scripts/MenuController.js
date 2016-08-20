//function Company(data) {
//    this.id = JSON.parse(data.id);
//    this.name = JSON.parse(data.name);
//    this.address = JSON.parse(data.address);
//    this.industry = JSON.parse(data.industry);
//    this.city = JSON.parse(data.city);
//    this.contacts = JSON.parse(data.contacts);
//}

function CompanyList(company, cityId) {
    $("#" + cityId).append('<div id="' + JSON.parse(company.Id) + '"class="company-div col-xs-10 col-sm-6 col-sm-offset-4">' +
                                '<button type="button" class="company-button btn btn-primary">' + JSON.parse(company.Name) + '</button>' +
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
}
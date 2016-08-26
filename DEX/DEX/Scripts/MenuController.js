function Company(company) {
    this.Id = JSON.parse(company.Id);
    this.Name = company.Name;
    //this.Address = JSON.parse(company.Address);
    //this.Industry = JSON.parse(company.Industry);
    //this.City = JSON.parse(data.City);
    //this.contacts = JSON.parse(data.contacts);
}

function CompanyList(company, cityId) {
    var data = new Company(company);
    console.log(data.Name);
    $("#" + cityId).append('<div id="' + data.Id + '"class="company-div col-xs-10 col-sm-6 col-sm-offset-4">' +
                                '<button type="button" class="company-button btn btn-primary">' + data.Name + '</button>' +
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
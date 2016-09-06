function CompanyList(companyData, cityId) {
    var company = new Company(companyData);
    $("#" + cityId).append('<div id="' + company.Id + '"class="company-div col-xs-10 col-sm-6 col-sm-offset-4">' +
                                '<button type="button" class="company-button btn btn-primary">' + company.Name + '</button>' +
                            '</div>');
};

function companyView(data, companyId)
{
    var company = new Company(data);
    var html = '<div id="' + company.Id + '" class="well col-xs-12 col-sm-10 col-sm-offset-2">' +
                    '<h2 class="company-heading col-sm-10 col-md-offset-2">' + company.Name + '</h2>' +
                    '<p class="col-xs-10 col-sm-10 col-md-offset-2">' + company.Industry + '</p>' +
                    '<p class="col-xs-10 col-sm-10 col-md-offset-2">' + company.Address + '</p>' +
                    '<button class="btn btn-primary">View Contacts</button>' +
               '</div>';
    $("#content-box").append(html);
}
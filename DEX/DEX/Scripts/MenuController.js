function CompanyList(companyData, cityId) {
    var company = new Company(companyData);
    $("#" + cityId).append('<div id="' + company.Id + '"class="company-div col-xs-10 col-sm-6 col-sm-offset-4">' +
                                '<button type="button" class="company-button btn btn-primary col-xs-6">' + company.Name + '</button>' +
                            '</div>');
};

function companyView(data, companyId)
{
    var company = new Company(data);
    var html = '<div id="' + company.Id + '" class="well col-xs-12 col-sm-12">' +
                    '<h2 class="company-heading col-sm-10 col-sm-offset-2">' + company.Name + '</h2>' +
                    '<p class="col-xs-10 col-sm-10 col-sm-offset-2">' + company.Address + '</p>' +
                    '<div id="map" class="col-xs-10 col-sm-10 col-sm-offset-2"></div>' +
                    '<button class="btn btn-primary col-xs-6 col-sm-2 col-sm-offset-2">View Contacts</button>' +
                    //'<button class="btn btn-primary col-xs-2 col-sm-offset-2">Edit Company</button>' +
                    //'<button class="btn btn-danger col-xs-2 col-sm-offset-2">Delete Company</button>' +
               '</div>';
    $("#content-box").append(html);
}
function CompanyList(companyData, cityId) {
    var company = new Company(companyData);
    $("#" + cityId).append('<div id="' + company.Id + '"class="company-div col-xs-10 col-sm-6 col-sm-offset-4">' +
                                '<button type="button" class="company-button btn btn-primary">' + company.Name + '</button>' +
                            '</div>');
};

function companyView(data, companyId)
{
    var company = new Company(data);
    var html = '<div id="' + company.Id + '">' +
                    '<p class="col-xs-10 col-sm-6 co-sm-offset-4">' + company.Name + '</p>' +
                    '<p class="col-xs-10 col-sm-6 co-sm-offset-4">' + company.Address + '</p>' +
                    '<p class="col-xs-10 col-sm-6 co-sm-offset-4">' + company.Industry + '</p>' +
               '</div>';
    $("#content-box").append(html);
}
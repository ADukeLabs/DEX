function CompanyList(companyData, cityId) {
    var company = new Company(companyData);
    $("#" + cityId).append('<div id="' + company.Id + '"class="company-div col-xs-10 col-xs-offset-2 col-sm-6 col-sm-offset-4">' +
                                '<button type="button" class="company-button btn btn-primary">' + company.Name + '</button>' +
                            '</div>');
};

function companyView(data, companyId)
{
    var company = new Company(data);
    var html = '<div id="' + company.Id + '" class="company-container well col-xs-12 col-sm-12">' +
                    '<h2 class="company-heading col-sm-10 col-sm-offset-2">' + company.Name + '</h2>' +
                    '<p class="col-xs-10 col-sm-10 col-sm-offset-2">' + company.Address + '</p>' +
                    
               '</div>';
    $("#content-box").append(html);
    $.each(company.Contacts, function (i) { contactList(company.Contacts[i]) });
}

function contactList(data) {
    var contact = new Contact(data);
    var html = '<div class="contact-container">' +
                    '<h4 class="col-xs-12 col-sm-10 col-sm-offset-2">' + contact.Name + ": " + contact.Title + '</h4>' +
                    //'<p class="col-xs-12 col-sm-10 col-sm-offset-2"></p>' +
                    '<p class="col-xs-6 col-sm-4 col-sm-offset-2">' + contact.Email + '</p>' +
                    '<p class="col-xs-6 col-sm-4 col-sm-offset-2">'+ contact.PhoneNumber +'</p>'+
                '</div>';
    $(".company-container").append(html);
}
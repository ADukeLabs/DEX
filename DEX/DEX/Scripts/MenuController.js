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
    $.each(company.Contacts, function (i) { contactList(company.Contacts[i])});
    $("#content-box").append(html);
}

function contactList(data) {
    var contact = new Contact(data);
    console.log(contact.Id, contact.Name, contact.Email);
    //var html = '<div class="contact-container">' +
    //                '<h3 class="col-xs-12 col-sm-10 col-sm-offset-2">' + contact.Name + '</h3>' +
    //                '<p class="col-xs-12 col-sm-10 col-sm-offset-2">' + contact.Title + '</p>' +
    //                //'<p class="col-xs-6">' + contact.Email + '</p>' +
    //            '</div>';
    $(".company-container").append('<div>This Is Working</div>');
}
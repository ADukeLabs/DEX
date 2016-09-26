function CompanyList(companyData, cityId) {
    var company = new Company(companyData);
    $("#" + cityId).append('<div id="' + company.Id + '"class="company-div col-xs-10 col-sm-6 col-sm-offset-4">' +
                                '<button type="button" class="company-button btn btn-primary">' + company.Name + '</button>' +
                            '</div>');
};

function companyView(data, companyId)
{
    var company = new Company(data);
    var html = '<div id="' + company.Id + '" class="well col-xs-12 col-sm-12">' +
                    '<h2 class="company-heading col-sm-10 col-sm-offset-2">' + company.Name + '</h2>' +
                    '<p class="col-xs-10 col-sm-10 col-sm-offset-2">' + company.Address + '</p>' +
                    //$.each(company.Contacts, function (i) { $(this).append(contactList(i)) });
                    $.each(company.contacts, contactList(contact));
               '</div>';
    $("#content-box").append(html);
}

function contactList(data) {
    var contact = new Contact(data);
    var html = '<div id="'+contact.Id+'" class="contact-container">' +
                    '<h3 class="col-xs-12 col-sm-10 col-sm-offset-2">' + contact.Name + '</h3>' +
                    '<p class="col-xs-12 col-sm-10 col-sm-offset-2">' + contact.Title + '</p>' +
                    //'<p class="col-xs-6">' + contact.Email + '</p>' +
                '</div>';
    $(this).append(html);
    //console.log(contact.Name, contact.Title);
}
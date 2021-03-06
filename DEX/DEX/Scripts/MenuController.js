﻿function CompanyList(companyData, cityId) {
    var company = new Company(companyData);

    $("#" + cityId).append('<div id="' + company.Id + '"class="company-div col-xs-10 col-xs-offset-2 col-sm-6 col-sm-offset-4">' +
                                '<button type="button" class="company-button btn btn-primary">' + company.Name + '</button>' +
                            '</div>');
};

function companyView(data, companyId)
{
    var company = new Company(data);
    var html = '<div id="' + company.Id + '"class="company-container well col-xs-12 col-sm-12">' +
                    '<div class="btn-group pull-right">' +
                        '<button type="button" class="btn btn-primary dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"><span class="glyphicon glyphicon-info-sign"></span></button>' +
                        '<ul class="dropdown-menu dropdown-menu-right" aria-labelledby="dLabel">' +
                            '<li><a href="/Company/Edit/' + company.Id + '">Edit Company</a></li>' +
                            '<li><a href="/Contact/Create/' + company.Id + '">Add Contact</a></li>' +
                            '<li><a href="/Company/Delete/' + company.Id + '">Delete Company</a></li>' +
                        '</ul>' +
                    '</div>' +

                    '<div class="row">' +
                        '<div class="content">' +
                            '<h2 class="company-heading col-sm-10 col-sm-offset-2">' + company.Name + '</h2>' +
                            '<p class="col-xs-10 col-sm-10 col-sm-offset-2">' + company.Address + '</p>' +
                        '</div>' +
                    '</div>' +

                    '<div class="row">' +
                        '<div class="content">' +
                            '<div id="map"></div>' +
                        '</div>' +
                    '</div>' +
       
               '</div>' +
               '<hr />';
    $("#content-box").append(html);
    $.each(company.Contacts, function (i) { contactList(company.Contacts[i]) });
}

function contactList(data) {
    var contact = new Contact(data);
    var html = '<div class="contact-container">' +
                    '<h4 class="col-xs-12 col-sm-10 col-sm-offset-2">' + contact.Name + ": " + contact.Title + '</h4>' +
                    '<p class="col-xs-8 col-sm-3 col-sm-offset-2">' + contact.Email + '</p>' +
                    '<p class="col-xs-8 col-sm-3 col-sm-offset-2">' + contact.PhoneNumber + '</p>' +
                        '<div class="col-xs-12 col-sm-6 col-sm-offset-2" aria-label="Contact Control Buttons">' +
                            '<button type="button" class="btn btn-primary btn-circle btn-lg"><i class="glyphicon glyphicon-envelope"></i></button>' +
                            '<button type="button" class="btn btn-primary btn-circle btn-lg"><i class="glyphicon glyphicon-phone-alt"></i> </button>' +
                            '<button type="button" class="btn btn-primary btn-circle btn-lg"><i class="glyphicon glyphicon-facetime-video"></i> </button>' +
                            '<button type="button" class="btn btn-primary btn-circle btn-lg"><i class="glyphicon glyphicon-pencil"></i> </button>' +
                            '<button type="button" class="btn btn-danger btn-circle btn-lg"><i class="glyphicon glyphicon-remove"></i> </button>' +
                        '</div>' +
                '</div>';
    $(".company-container").append(html);
}
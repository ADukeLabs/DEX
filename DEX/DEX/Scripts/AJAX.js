//function GetCityCompanies(city) {
//    var url = "../Company/GetCompanies/";

//    $.ajax({
//        type: "GET",
//        url: url,
//        data: { 'id': city },
//        dataType: "json",
//        success: function (companies) {
//            for (var i = 0; i < companies.length; i++) {
//                CompanyList(companies[i], city);
//            }
//        },
//        error: function () {
//            alert: ("Error: There was a problem listing the companies in this city.");
//        }
//    });
//}

//function GetCompanyDetails(companyId) {
//    $.ajax({
//        type: "GET",
//        url: "../Company/Details/",
//        data: { 'id': companyId },
//        dataType: "json",
//        success: function (data) {
//            companyView(data, companyId);
//        },
//        error: function () {
//            alert: ("Error: There was a problem acquiring the details for this company");
//        }
//    });
//}

//function GetCompanyContacts(companyId) {
//    $.ajax({
//        type: "GET",
//        url: "../Contact/GetContacts/",
//        data: { 'id': companyId },
//        dataType: "json",
//        success: function (data) {
//            for (var i = 0; i < data.length; i++) {
//                contactList(data[i]);
//            }
//        },
//        error: function () {
//            alert: ("Error: Could not acquire contacts for this company.");
//        }
//    });
//}
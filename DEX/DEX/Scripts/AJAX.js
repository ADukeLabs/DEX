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
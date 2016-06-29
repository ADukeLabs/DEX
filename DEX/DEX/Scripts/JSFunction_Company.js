$(document).ready(function () {
    
    function makeCompanies(companies, Id) {

        var html = '<li>' +
                        '<button id="' + companies.Id + '" class="companyDetails btn btn-primary>"' + companies.Name + '"</button>' +
                   '</li>';
        $('#' + Id).append(html);
    }




    $(".GetCompanies").click(function () {

        var activeCity = this.id;
        var url = "http://localhost:58905/Company/GetCompanies/";

        $.ajax({
            type: "GET",
            url: url,
            data: { 'id': activeCity },
            dataType: "json",
            success: function (companies) {
                for (var i = 0; i < companies.length; i++) {
                    makeCompanies(companies, activeCity);
                }
            },
            error: function () {
                alert: ("Error: There was a problem listing the companies in this city.");
            }
        });
    });

});
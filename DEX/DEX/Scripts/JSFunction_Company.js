$(document).ready(function () {
    
    function makeCompanies(company) {

        var html = '<li>' +
            '<button id="' + company.Id + '"class="companyDetails btn btn-primary>"' + company.Name + '"</button>' +
            '</li>' +
            '<button type="button" class="addCompany">Add Company</button>';

        $("#companies").append(html);
    }




    $(".GetCompanies").on("click", function () {

        var activeCity = this.id;
        var url = "http://localhost:58905/Company/GetCompanies/";

        $.ajax({
            type: 'GET',
            url: url,
            data: {'id': activeCity},
            success: function (companies) {
                var len = companies.length;
                for (var i = 0; i < len; i++)
                    makeCompanies(companies[i]);
            },
            error: function(){
                alert: ("Error: There was a problem listing the companies in this city.");
            }

        })

    });
});
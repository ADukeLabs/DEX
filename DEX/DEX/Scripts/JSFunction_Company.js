$(document).ready(function () {
    
    function makeCompanies(companies, Id) {

        var html = '<li id="' + companies.Id + '">' +
            '<button class="companyDetails btn btn-primary>"' + companies.Name + '"</button>' +
            '</li>' +
            '<button type="button" class="addCompany">Add Company</button>';

        $('#' + Id).append(html);
    }




    $(".GetCompanies").on("click", function () {

        var activeCity = this.id;
        var url = "http://localhost:58905/Company/GetCompanies/";

        $.ajax({
            type: 'GET',
            url: url,
            data: {'id': activeCity},
            success: function (companies, activeCity) {
                for (var i = 0; i < companies.length; i++)
                    makeCompanies(companies[i]);
            },
            error: function(){
                alert: ("Error: There was a problem listing the companies in this city.");
            }

        })

    });
});
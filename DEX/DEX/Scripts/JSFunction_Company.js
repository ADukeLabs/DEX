$(document).ready(function () {
    
    function makeCompanies(company) {
        $("#companies").append(
            '<li>' +
            '<button id="' + company.Id + '"class="companyDetails btn btn-primary>"' + company.Name + '"</button>' +
            '</li>' +
            '<button type="button" class="addCompany">Add Company</button>'
        );
    }

    $(".GetCompanies").on("click", function () {

        var activeCity = this.id;

        $.ajax({
            type: 'GET',
            url: '@Url.Action("GetCompanies", "Company")',
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
$(document).ready(function () {
    
    function makeCompanies(companies) {

        var html = '<li>' +
            '<button id="' + companies.Id + '"class="companyDetails btn btn-primary>"' + companies.Name + '"</button>' +
            '</li>' +
            '<button type="button" class="addCompany">Add Company</button>';

        $("#companies").prepend(html);
    }




    $(".GetCompanies").on("click", function () {

        $(this).parent().id;
        var activeCity = this.id;
        var url = "http://localhost:58905/Company/GetCompanies/";

        $.ajax({
            type: 'GET',
            url: url,
            data: {'id': activeCity},
            success: function (companies) {
                makeCompanies(companies);
            },
            error: function(){
                alert: ("Error: There was a problem listing the companies in this city.");
            }

        })

    });
});
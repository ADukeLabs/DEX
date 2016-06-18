$(document).ready(function () {
    
    function MakeCompanies(company) {
        $("#companies").append(
            '<li id="'+ company.Id + '">' +
            '<button id="'+ company.Id + '"class="companyDetails btn btn-primary>"'+ company.Name + '"</button>'
        );
    }

    $(".GetCompanies").on("click", function () {
        
    });
});
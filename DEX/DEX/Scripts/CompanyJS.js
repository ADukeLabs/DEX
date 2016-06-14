$(document).ready(function () {

    //list company function

    function ListCompanies(company) {
        $("#Company").append(
            '<li id="' + company.Id + '">' +
            '<button id="' + company.Id + '"type="button" class="companyDetails">' + company.Name +'</button>' +
            '<button ></button>'


        );
    }

});
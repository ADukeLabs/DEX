$(document).ready(function () {

    function makeCompanies(companies, id) {
        var html = '<button id="' + companies.Id + '"class="company btn btn-primary">"' + companies.Name + '"</button>';

        $(this).append(html);
    };




    $(".GetCompanies").click(function(){
            var activeCity = $(this).parent().attr("Id");
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
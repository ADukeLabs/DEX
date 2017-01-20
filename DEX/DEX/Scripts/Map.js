function initialize() {
    var mapOptions = {
        center: new google.maps.LatLng(0, 0),
        zoom: 4,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("map"), mapOptions);

    google.maps.event.addDomListener(window, 'load', initialize);
}



//function initMap() {
//    var wellington = { lat: -41.290622, lng: 174.776566 };
//    var map = new google.maps.Map(document.getElementById('map'), {
//        zoom: 4,
//        center: wellington
//    });
//    var marker = new google.maps.Marker({
//        position: wellington,
//        map: map
//    });
//}
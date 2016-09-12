function initialize() {
    var mapOptions = {
        center: new google.maps.LatLng(0, 0),
        zoom: 4,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("#map"), mapOptions);
}

google.maps.event.addDomListener(window, "load", initialize);
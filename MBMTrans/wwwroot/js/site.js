// Write your JavaScript code.
var btn = document.getElementById("rasschet");
var result = document.getElementById("summary");
var apikey = "AIzaSyCFlPNTYIJ9dSvkPjGfdGScQaEsioAx6kQ"

function GetDistance(origin, destination) {
    var url = 'https://maps.googleapis.com/maps/api/distancematrix/json?origins=' + origin + '&destinations=' + destination + '&key=' + apikey;
    $.getJSON(url, function (data) {
        $.each(data, function (response, status) {
            if (status == 'OK') {
                +
            }
        })
    });
}

btn.addEventListener("click"){

}


//var service = new google.maps.DistanceMatrixService();
//service.getDistanceMatrix(
//    {
//        origins: [origin1, origin2],
//        destinations: [destinationA, destinationB],
//        travelMode: 'DRIVING',
//        transitOptions: TransitOptions,
//        drivingOptions: DrivingOptions,
//        unitSystem: UnitSystem,
//        avoidHighways: Boolean,
//        avoidTolls: Boolean,
//    }, callback);

//function callback(response, status) {
//    // See Parsing the Results for
//    // the basics of a callback function.
}
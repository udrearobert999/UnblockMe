var info = L.control();
function getColor(d) {
    return d > 650000 ? '#800026' :
        d > 500001 ? '#BD0026' :
            d > 350001 ? '#E31A1C' :
                d > 250001 ? '#FC4E2A' :
                    d > 100001 ? '#FD8D3C' :
                        d > 50001 ? '#FEB24C' :
                            '#FFEDA0';
}
function style(feature) {
    return {
        fillColor: getColor(feature.properties.pop2011),
        weight: 2,
        opacity: 1,
        color: 'white',
        dashArray: '3',
        fillOpacity: 0.7
    };
}
function highlightFeature(e) {
    var layer = e.target;
    //console.log(e.target);
    layer.setStyle({
        weight: 5,
        color: '#666',
        dashArray: '',
        fillOpacity: 0.7
    });

    if (!L.Browser.ie && !L.Browser.opera && !L.Browser.edge) {
        layer.bringToFront();
    }
    info.update(layer.feature.properties);
}
function resetHighlight(e) {
    geojson.resetStyle(e.target);

    info.update();
}
function onEachFeature(feature, layer) {
    layer.on({
        mouseover: highlightFeature,
        mouseout: resetHighlight,
        click: clickEventFeature
    });
}
function clickEventFeature(e) {

    let countyName = e.target.feature.properties.name;
    let infoReturner = document.getElementById('returnInfo');
    infoReturner.href += "/" + String(countyName);
    infoReturner.click();

}

var mymap = L.map('mapid').setView([44.3126, 23.8005], 9);
L.tileLayer('https://api.mapbox.com/styles/v1/{id}/tiles/{z}/{x}/{y}?access_token={accessToken}', {
    attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors, Imagery © <a href="https://www.mapbox.com/">Mapbox</a>',
    maxZoom: 18,
    id: 'mapbox/streets-v11',
    tileSize: 512,
    cursor: true,
    zoomOffset: -1,
    accessToken: 'pk.eyJ1IjoidWRyZWFyb2JlcnQ5OTkiLCJhIjoiY2t0OGxsYjdyMHd5YTJwcGN4Y3VsbWw0eCJ9.bBI6D7tU_b7lwG9agavG4g'
}).addTo(mymap);



info.onAdd = function (map) {
    this._div = L.DomUtil.create('div', 'info'); // create a div with a class "info"
    this.update();
    return this._div;
};
info.update = function (props) {
    this._div.innerHTML = '<h4>Romania county info</h4>' + (props ?
        '<b>' + props.name + '</b><br />' + 'Click to see more details'
        : 'Hover over a state');
};

info.addTo(mymap);

var markers = [];
var carsArr = []
var carMarkers;
var interactions;
document.addEventListener("DOMContentLoaded", function (event) {
    if (document.querySelector('#showBlockings')) {
        $.ajax({
            url: "GetBlockingInteraction",
            success: function (data) {
                document.querySelector(".info").hidden = true;
                for (const interaction of data) {

                    let lat = interaction.blockedCarLat;
                    let lng = interaction.blockedCarLng;
                    let popUp = `<b>${interaction.blockedCarLicensePlate} is blocked by ${interaction.blockingCarLicensePlate}</b>`;
                    let markerLocation = new L.LatLng(lat, lng);
                    let marker = new L.Marker(markerLocation);
                    marker.bindPopup(popUp);
                    markers.push(marker);
                    interactions = L.layerGroup(markers);

                }


            },
            error: function (error) {

            }
        });
    }

    $.ajax({
        url: "GetCarJson",
        success: function (data) {
            document.querySelector(".info").hidden = true;
            for (const car of data) {
                let lat = car.lat;
                let lng = car.lng;
                let popUp = `<b>${car.licensePlate}</b>`;
                let markerLocation = new L.LatLng(lat, lng);
                let marker = new L.Marker(markerLocation);
                marker.bindPopup(popUp);
                carsArr.push(marker);
                carMarkers = L.layerGroup(carsArr);
                carMarkers.addTo(mymap);
            }
        },
        error: function (error) {

        }
    });
});

var geojson = L.geoJson(statesData, {
    onEachFeature: onEachFeature,
    style: style
});

document.querySelector("#showInfo")?.addEventListener('click', () => {
    document.querySelector(".info").hidden = false;
    interactions?.remove();
    geojson.addTo(mymap);
    carMarkers.remove();
});
document.querySelector("#showBlockings")?.addEventListener('click', () => {
    document.querySelector(".info").hidden = true;
    interactions?.addTo(mymap);
    geojson?.remove();
    carMarkers?.remove();

});
document.querySelector("#showCars")?.addEventListener('click', () => {
    document.querySelector(".info").hidden = true;
    interactions?.remove(mymap);
    geojson?.remove();
    carMarkers?.addTo(mymap);
});




﻿var info = L.control();
function highlightFeature(e) {
    var layer = e.target;
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
    console.log(e.target);
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
var interactions;
document.addEventListener("DOMContentLoaded", function (event) {
    $.ajax({
        url: "GetBlockingInteraction",
        success: function (data) {
            document.querySelector(".info").hidden = true;
            for (const interaction of data) {

                let lat = interaction.blockedCarLat;
                let lng = interaction.blockedCarLng;
                let popUp = `<b>${interaction.blockedCarLicensePlate} is blocked by ${interaction.blockingCarLicensePlate}</b>`;
                var markerLocation = new L.LatLng(lat, lng);
                var marker = new L.Marker(markerLocation);
                marker.bindPopup(popUp);
                markers.push(marker);
                interactions = L.layerGroup(markers);
                interactions.addTo(mymap);
            }


        },
        error: function (error) {

        }
    });
});

var geojson = L.geoJson(statesData, {
    onEachFeature: onEachFeature
});

document.querySelector("#showInfo").addEventListener('click', () => {
    document.querySelector("#showInfo").hidden = true;
    document.querySelector("#showBlockings").hidden = false;
    document.querySelector(".info").hidden = false;
    interactions.remove();
    geojson.addTo(mymap);
});
document.querySelector("#showBlockings").addEventListener('click', () => {
    document.querySelector("#showInfo").hidden = false;
    document.querySelector("#showBlockings").hidden = true;
    document.querySelector(".info").hidden = true;
;
    interactions.addTo(mymap);
    geojson.remove();

});






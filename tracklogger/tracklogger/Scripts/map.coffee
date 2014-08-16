initializeMap = ->
    mapOptions =
        center: new google.maps.LatLng(51.5702629, -1.1495688)
        zoom: 14
    
    @map = new google.maps.Map(document.getElementById("map-canvas"), mapOptions)

getTrackData = ->
    $.getJSON "/api/track/", (trackData) ->
        createMapPoint(t) for t in trackData

createMapPoint = (point) ->
    lat = point.Lat
    lng = point.Lng
    name = point.Time
    
    marker = new google.maps.Marker
        position: new google.maps.LatLng(lat, lng)
        title: name

    marker.setMap(map)

$(document).ready ->
    initializeMap()
    getTrackData()
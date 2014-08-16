initializeMap = ->
    mapOptions =
        zoom: 16
    @map = new google.maps.Map(document.getElementById('map-canvas'), mapOptions)

getTrackData = ->
    url = location.href + '/api/track'
    $.getJSON url, (trackData) ->
        createPolyLine(trackData)
        lat = trackData[0].Lat
        lng = trackData[0].Lng
        centerPoint = new google.maps.LatLng(lat, lng)
        map.setCenter(centerPoint)

createPolyLine = (trackData) ->
    @polyLineCoords = []
    addPolyLinePoint(t) for t in trackData
    polyLine = new google.maps.Polyline
        path: polyLineCoords
        geodesic: true
        strokeColor: '#0000FF'
        strokeOpacity: 1.0
        strokeWeight: 2
    polyLine.setMap(map)

addPolyLinePoint = (point) ->
    lat = point.Lat
    lng = point.Lng
    coordinates =  new google.maps.LatLng(lat, lng)
    polyLineCoords.push(coordinates)

$(document).ready ->
    initializeMap()
    getTrackData()
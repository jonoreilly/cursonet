
function inicio()
{
  var btnMiUbicacion = document.getElementById("btn_mi_ubicacion");
  var miUbicacion = document.getElementById("mi_ubicacion");

  btnMiUbicacion.addEventListener("click", DarUbicacion, "false");


  function DarUbicacion()
  {
    navigator.geolocation.getCurrentPosition(MiPosicion);
  }


  function MiPosicion(posicion)
  {
    var miUbicacion = document.getElementById("mi_ubicacion");
    var longitud = "Mi Longitud: " + posicion.coords.longitude ;
    var latitud = "Mi latitud: " +  posicion.coords.latitude;

    miUbicacion.innerHTML = longitud + latitud;

    var miMapa = "http://maps.google.com/maps/api/staticmap?center" + posicion.coords.latitude + "," + posicion.coords.longitude + "," + "&zoom=12&si<e=580x400&sensor=false"
  }


}








window.addEventListener("load", inicio, "false");

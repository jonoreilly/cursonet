var btnMiUbicacion;
var btnMiUbicacionGoogleMaps;

function inicio(){
	
	btnMiUbicacion = document.getElementById("btn_mi_ubicacion");
	btnMiUbicacionGoogleMaps = document.getElementById("btn_mi_ubicacion_google_maps");
	
	btnMiUbicacion.addEventListener("click", DaUbicacion, false);	
	btnMiUbicacionGoogleMaps.addEventListener("click", DaUbicacion, false);
	
}


function DaUbicacion(){
	
	//getCurrentPosition al llamar a la clousure MiPosicion le pasa "mágicamente" el argumemnto "posicion".
	navigator.geolocation.getCurrentPosition(MiPosicion);
	
	//En el caso de introducir un segundo parámetro (la función CallBack GestionErrores) ésta se llamará solo en caso de error. 
	//Si no hay error se llamará a MiPosicion
	//navigator.geolocation.getCurrentPosition(MiPosicion, GestionErrores);
	
}

//MiPosicion, como clousure, al ser llamada desde getCurrentPosition recibe el argumento posicion.
//En este caso lo hemos llamado "posicion" pero podemos llamarlo como queramos...
function MiPosicion(posicion){
	
	var miUbicacion = document.getElementById("mi_ubicacion");
	var miGoogleMaps = document.getElementById("mi_google_maps");
	
	var longitud = "Mi longitud: " + posicion.coords.longitude + "<br><br>";
	var latitud = "Mi latitud: " + posicion.coords.latitude + "<br><br>";
	var comentario = "<p>Si vamos a Google Earth e introducimos estas coordenadas comprobaremos que ha funcionado a la perfección.</p>";
	miUbicacion.innerHTML = longitud + latitud + comentario ;
	
	//Esta expresión la sacamos de GoogleMaps
	var miMapa = "http://maps.google.com/maps/api/staticmap?center=" + posicion.coords.latitude + "," + posicion.coords.longitude + "," + "&zoom=12&size=580x400&sensor=false&markers=" + posicion.coords.latitude + "," + posicion.coords.longitude;
	miGoogleMaps.innerHTML = "<img src='" + miMapa + "'/>";
}
//El objeto error se recibe magicamente...
//Tiene dos propiedades: code y message.
/*function GestionErrores(error){
	
	alert ("Se ha producido un error " + error.code + " " +  error.message);
	
	//También podemos recoger el error de esta forma
	if(error.code == 1){
		
		alert("Debes permitir el uso del Geolocalizador en tu navegador");
	}
	
}*/



window.addEventListener("load", inicio, false);
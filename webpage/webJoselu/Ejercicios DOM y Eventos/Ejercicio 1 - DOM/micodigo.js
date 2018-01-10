function inicio(){
	
	var mip = document.getElementById("resultados");
	var enlaces = document.getElementsByTagName("a");
	var parrafos = document.getElementsByTagName("p");
	var nEnlacesCoincidentes=0;

	
	var enlacesDelTercerParrafo = parrafos[2].getElementsByTagName("a");
	
	
	
	
	
	
	
	for (i=0 ; i< enlaces.length ; i++){
		
		
		
		if(enlaces[i].href == 'http://prueba/'){
			
			nEnlacesCoincidentes++;
		}
			
		
	}
	
	

	
	mip.innerHTML = "El numero de de enlaces de esta página es " + enlaces.length + "<br>";
	
	mip.innerHTML += "El penultimo enlace apunta a " + enlaces[enlaces.length-3].href+ "<br>";
	
	mip.innerHTML += "El número de enlaces que apuntan a 'http://prueba' es " +  nEnlacesCoincidentes+ "<br>";
	
	mip.innerHTML += "el número de enlaces del tercer párrafo es "  + enlacesDelTercerParrafo.length;
	
	
	
	
}




window.addEventListener("load", inicio , false);
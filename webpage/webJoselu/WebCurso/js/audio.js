var miAudio;
var botonPlayPause;
var barraProgresoAudio;
var valorMaximoBarra = 234;


function inicio(){
miAudio = document.getElementById("mi_audio");
botonPlayPause = document.getElementById("boton_play_pause");
barraProgresoAudio = document.getElementById("barra_progreso_audio");

botonPlayPause.innerHTML="Play";

botonPlayPause.addEventListener("click", playPause, false);


}

function playPause() { 
    if (miAudio.paused){ 
		
        miAudio.play(); 
		botonPlayPause.innerHTML="Pause";
		bucleAudio = setInterval(estadoBarraProgreso,500);
    
	}else {
        miAudio.pause();
		botonPlayPause.innerHTML="Play";
	}
} 


function estadoBarraProgreso(){
	if (miAudio.ended == false){
		
		var total = parseInt(miAudio.currentTime*valorMaximoBarra/miAudio.duration);
		//alert(total);
		barraProgresoAudio.style.width = total + "px";
		
	}
	
}


window.addEventListener("load",inicio,false);
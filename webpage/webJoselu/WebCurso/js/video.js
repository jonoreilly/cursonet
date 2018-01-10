var miVideo;
var botonPlayPause;
var botonHaceGrande;
var botonHacePequeno;
var botonHaceNormal;


function inicio(){
miVideo = document.getElementById("mi_video");
botonPlayPause = document.getElementById("boton_play_pause");
botonHaceGrande = document.getElementById("boton_grande");
botonHacePequeno = document.getElementById("boton_pequeno");
botonHaceNormal = document.getElementById("boton_normal");

botonPlayPause.addEventListener("click", playPause, false);
botonHaceGrande.addEventListener("click", haceGrande, false);
botonHacePequeno.addEventListener("click", hacePequeno, false);
botonHaceNormal.addEventListener("click", haceNormal, false);

}

function playPause() { 
    if (miVideo.paused) 
        miVideo.play(); 
    else 
        miVideo.pause(); 
} 

function haceGrande() { 
    miVideo.width = 900; 
} 

function hacePequeno() { 
    miVideo.width = 600; 
} 

function haceNormal() { 
    miVideo.width = 720; 
} 


window.addEventListener("load",inicio,false);
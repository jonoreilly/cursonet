var imagenPiloto;
var escuderiaDestino;
var todosLosPilotos;
var estamosDentroEscuderia=false;

function inicio(){
	
	imagenPiloto = document.getElementById("imagen_piloto");
	escuderiaDestino = document.getElementById("caja_imagen_escuderia");
	
	//querySelector nos devuelve un array. Cada elemento será por tanto: todosLosPilotos[0]...etc.
	todosLosPilotos = document.querySelectorAll("#caja_imagen_piloto img");
	
	for (var i=0 ; i<todosLosPilotos.length ; i++){
		
		todosLosPilotos[i].addEventListener("dragstart", comenzamosAArrastrar, false);
		todosLosPilotos[i].addEventListener("drag", estamosArrastrando, false);
		todosLosPilotos[i].addEventListener("dragend", terminamosDeArrastrar, false );
		
	}
	
	//Esta linea de codigo sirve para ilustrar el primer ejemplo. Ahora sustituimos la función anónima por una función "normal" 
	//para no sobrecargar el código.
	//imagenPiloto.addEventListener("dragstart", function(){ alert ("comenzó el movimiento");}, false);
	
	//imagenPiloto.addEventListener("dragstart", comenzamosAArrastrar, false);
	
	//imagenPiloto.addEventListener("dragend", terminamosDeArrastrar, false);
	
	/*escuderiaDestino.addEventListener("dragenter", function(e){
		
		//De esta forma decimos al navegador que cuando se dispare el evento "dragenter" no se comporte como
		//tiene definido por defecto. Es decir que "borre" ese comportamiento por defecto y haga lo que lef
		//indiquemos nosotros.
		e.preventDefault();
		
	} , false);*/
	
	escuderiaDestino.addEventListener("dragenter", entramosEnEscuderia , false);
	
	escuderiaDestino.addEventListener("dragleave", salimosDeEscuderia , false);
	
	//Con el evento "dragover" hacemos lo mismo
	escuderiaDestino.addEventListener("dragover", function(e){
		
		e.preventDefault();
		
	} , false);
	
	//Ahora el evento "drop"
	escuderiaDestino.addEventListener("drop", pilotoSoltado , false);
	
	
}
//e es el objeto que representa al evento. Tiene sus propiedades.

function entramosEnEscuderia(e){
	
	estamosDentroEscuderia=true;
	/*e.preventDefault();
	elemento = e.target;
	
	if (elemento != todosLosPilotos[2]){
		escuderiaDestino.style.border="5px solid #3dd719";
	}else{
		escuderiaDestino.style.border="5px solid #fb05b3";
	}*/
}

function estamosArrastrando(e){
	
	e.preventDefault();
	elemento = e.target;
	
	if (elemento != todosLosPilotos[2]){
		escuderiaDestino.style.border="5px solid #3dd719";
	}else{
		escuderiaDestino.style.border="5px solid #fb05b3";
	}
	
}


function salimosDeEscuderia(e){
	
	estamosDentroEscuderia=false;
	e.preventDefault();
	escuderiaDestino.style.border="none";
	
}

function comenzamosAArrastrar(e){
	
	var elemento = e.target;
	
	//var codigo = "<img src='" + e.getAttribute("src") + "'/>"
	e.dataTransfer.setData("Text", elemento.getAttribute("id"));
	
	//e.dataTransfer.setData("Text", codigo);
	
	/*var imagen = new image();
	imagen.src = "../img/sebastian-vettel.jpg";
	e.dataTransfer.setDragImage(imagen);*/
}

function terminamosDeArrastrar(e){
	//Así dejamos en "elemento" el objeto que desencadenó el evento "e".
	var elemento = e.target;
	
	e.preventDefault();
	
	if(estamosDentroEscuderia==false){
		
		e.dataTransfer.clearData();
		escuderiaDestino.style.border="none";
		
	}else{
	
		if(elemento != todosLosPilotos[2]){
			elemento.style.visibility = "hidden";
		}
	}
	
}

function pilotoSoltado(e){
	
	e.preventDefault();
	
	var id = e.dataTransfer.getData("Text");
	
	escuderiaDestino.style.border="none";
	
	if (id!="imagen_piloto3"){
		
		var src = document.getElementById(id).src;
		escuderiaDestino.innerHTML += "<img src='"+ src + "'/>"
	}else{
		escuderiaDestino.innerHTML += "<p style ='color: #ffffff; font-size: 24px; margin:20px;'>el piloto no es admitido</p>";
	}
	
	
	
}

window.addEventListener("load", inicio, false);
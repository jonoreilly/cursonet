

function inicio ()
{
  var enlaces = document.getElementsById("enlace_");

  for (i = 0; i < enlaces.length; i++)
  {
    enlaces[i].onclick = muestraOculta;
  }
  alert("cucu");
}


function muestraOculta ()
{
  var idEnlace = this.id;
  var trozos = idEnlace.split('_');
  var numero = trozos[1];
  var parrafo = document.getElementById('contenidos_' + numero);

  if (parrafo.style.display == "none")
  {
      parrafo.style.display = "block";
      this.innerHTML = "Ocultar contenidos"
  }

  else
  {
    parrafo.style.display = "none";
    this.innerHTML = "Mostrar contenidos";
  }
}


window.addEventListener("load", inicio, "false");

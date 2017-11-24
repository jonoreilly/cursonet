//definiciones
var aTexto = prompt("Dime algo bonito");

//main code
document.write(fVuelta(aTexto));


//funciones
function fVuelta (aTextoAux)
{
  var aVueltaAux = "";
  for (var i = (aTextoAux.length -1); i >= 0; i--)
  {
    aVueltaAux = aVueltaAux.concat(aTextoAux.charAt(i));
  }
  return aVueltaAux;
}

//window.alert();window.prompt();document.write()


//definiciones
var aNumeros = new Array();
var iLargo = 3;

//main code
fRecibir(aNumeros, iLargo);
document.write(fMayor(aNumeros));



//funciones
function fRecibir(aNumerosAux, iLargoAux) //recibe en aNumerosAux variables dependiendo deiLargoAux
{
  for (var i = 0; i < iLargoAux; i++)
  {
  	aNumerosAux.push(Number(window.prompt("Numeritos plis")));
  }
}

function fMayor(aNumerosAux) //devuelve el mayor
{
  var iNumeroAux = aNumerosAux[0];
  for (var i = 1; i < aNumerosAux.length; i++)
  {
    if (iNumeroAux < aNumerosAux[i]) {iNumeroAux = aNumerosAux[i];}
  }
  return iNumeroAux;
}

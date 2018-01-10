//definiciones
var aNumeros = new Array();
var aSumas = new Array();

//main code
fRecibir(aNumeros);
aSumas = fSumaParesImpares(aNumeros);
document.write("Pares :  " + aSumas[0] + "<br>Impares :  " + aSumas[1]);

//funciones
function fRecibir(aNumerosAux, iLargoAux) //recibe en aNumerosAux variables dependiendo deiLargoAux
{
  for (var i = 0; i < iLargoAux; i++)
  {
  	aNumerosAux.push(Number(window.prompt("Numeritos plis")));
  }
}

function fSumaParesImpares(aNumerosAux)
{
  var iParesAux = 0;
  var iImparesAux = 0;
  for (var i = 0; i < aNumerosAux.length; i++)
  {
    if (aNumerosAux[i]%2)
    {
      iImparesAux = iImparesAux + aNumerosAux[i];
    }
    else
    {
      iParesAux = iParesAux + aNumerosAux[i];
    }
  }
  return [iParesAux, iImparesAux]
}

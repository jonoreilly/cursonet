
//definiciones
var aNumeros = new Array();

//main code;
fRecibir(aNumeros);
document.write(aNumeros);
fMenu(aNumeros);


//funciones
function fRecibir (aNumerosAux)
{
  var bExit = false;
  var iContador = 0;
  while (bExit != true)
  {
    aNumerosAux[iContador] = prompt(("Dame el "+(iContador+1)+"º numero"));
    if ((aNumerosAux[iContador] != "") && (aNumerosAux[iContador] != null))
    {
      if (!isNaN(aNumerosAux[iContador]))
      {
        aNumerosAux[iContador] = Number(aNumerosAux[iContador]);
        if (iContador >= 5)
        {
          bExit = true;
        }
        else
        {
        iContador++;
        }
      }
    }
  }
}

function fMenu (aNumerosAux)
{
  var bExitAux = false;
  while (!bExitAux)
  {
    var iSeleccion = Number(prompt("Que quieres hacer? \n\n"+
                            "  1. Mostrar el Mayor \n"+
                            "  2. Mostrar la suma de todos los numeros \n"+
                            "  3. Mostrar la media \n"+
                            "  4. Mostrar la suma de los pares y la de los impares \n"+
                            "  5. Mostrar el numero de pares y el de impares \n"+
                            "  6. Salir"))
    var aAux = new Array();
    switch (iSeleccion)
    {
      case 1:
        alert("El mayor es :  "+fMayor(aNumerosAux));
        break;
      case 2:
        alert("La suma total es :  "+fSuma(aNumerosAux));
        break;
      case 3:
        alert("La media es :  "+fMedia(aNumerosAux));
        break;
      case 4:
        aAux = fSumaParesImpares(aNumerosAux);
        alert("Suma de los pares :  "+aAux[0]+"\nSuma de los impares :  "+aAux[1]);
        break;
      case 5:
        aAux = fContarParesImpares(aNumerosAux)
        alert("Numero de pares :  "+aAux[0]+"\nNumero de impares :  "+aAux[1]);
        break;
      case 6:
        alert("aio");
        bExitAux = true;
        break;
      default:
        break;
    }
  }
}

function fMayor (aNumerosAuxAux)
{
  var iMayorAux = 0;
  for (var i = 0; i < aNumerosAuxAux.length; i++)
  {
    if (aNumerosAuxAux[i] > iMayorAux)
    {
      iMayorAux = aNumerosAuxAux[i];
    }
  }
  return iMayorAux;
}

function fSuma (aNumerosAuxAux)
{
  var iSumaAux = 0;
  for (var i = 0; i < aNumerosAuxAux.length; i++)
  {
    iSumaAux = iSumaAux + aNumerosAuxAux[i];
  }
  return iSumaAux;
}

function fMedia (aNumerosAuxAux)
{
  return (fSuma(aNumerosAuxAux)/aNumerosAuxAux.length);
}

function fSumaParesImpares (aNumerosAuxAux)
{
  var iSumaPares = 0;
  var iSumaImpares = 0;
  for (var i = 0; i < aNumerosAuxAux.length; i++)
  {
    if (aNumerosAuxAux[i]%2)
    {
      iSumaImpares = iSumaImpares + aNumerosAuxAux[i];
    }
    else
    {
      iSumaPares = iSumaPares + aNumerosAuxAux[i];
    }
  }
  return [iSumaPares,iSumaImpares];
}

function fContarParesImpares (aNumerosAuxAux)
{
  var iNumeroPares = 0;
  var iNumeroImpares = 0;
  for (var i = 0; i < aNumerosAuxAux.length; i++)
  {
    if (aNumerosAuxAux[i]%2)
    {
      iNumeroPares++;
    }
    else
    {
      iNumeroImpares++;
    }
  }
  return [iNumeroPares,iNumeroImpares];
}

//Nombre, ciudad, precio, piscina(T/F)
//media precios, precio mas barato, lista de los hoteles con los datos
//definiciones
var aHoteles = new Array();

//main code
fMenu(aHoteles);

//funciones
function fMenu (aHotelesAux)
{
  var bExit = false;
  var iSelect;
  while (!bExit)
  {
    iSelect = prompt ("Que quieres hacer? \n\n"+
                      "  1. Insertar un nuevo hotel \n"+
                      "  2. Mostrar la media de los precios \n"+
                      "  3. Mostrar el precio mas barato \n"+
                      "  4. Mostrar la lista de los hoteles \n"+
                      "  5. Salir");
    switch (iSelect)
    {
      case "1":
        aHotelesAux.push(fRecibir())
        break;
      case "2":
        alert("La media es :  "+fMedia(aHotelesAux));
        break;
      case "3":
        alert("El mas barato es:\n"+fMostrarHotel(aHotelesAux[fMenor(aHotelesAux)]));
        break;
      case "4":
        fLista(aHotelesAux);
        break;
      case "5":
        alert("Aio");
        bExit = true;
        break;
      default:
        break;
    }
  }
}


function fRecibir ()
{
  var aHotelAux = new Array();
  aHotelAux[0] = prompt("Nombre :");
  aHotelAux[1] = prompt("Ciudad :");
  aHotelAux[2] = fRecibirNumero("Precio :");
  aHotelAux[3] = fRecibirBool("Tiene piscina?");
  return aHotelAux;
}


function fRecibirNumero (sTexto)
{
  var iPrecio;
  var bExit= false;
  while (!bExit)
  {
    iPrecio = prompt(sTexto);
    if ((iPrecio != "")&&(iPrecio != null)&&(!isNaN(iPrecio)))
    {
      bExit = true;
      iPrecio = Number(iPrecio);
    }
  }
  return iPrecio;
}


function fRecibirBool(sTexto)
{
  var bPiscina;
  var sTextoAux;
  var bExit= false;
  while (!bExit)
  {
    bPiscina = prompt(sTexto);
    if (bPiscina.toLowerCase() == "si")
    {
      return true;
    }
    else if (bPiscina.toLowerCase() == "no")
    {
      return false;
    }
    else
    {
      sTexto = sTextoAux+"\nResponde si o no";
    }
  }
}


function fMedia (aHotelesAuxAux)
{
  var iSumaAux = 0;
  for (var i = 0; i < aHotelesAuxAux.length; i++)
  {
    iSumaAux += aHotelesAuxAux[i][2];
  }
  return iSumaAux/aHotelesAuxAux.length;
}


function fMenor (aHotelesAuxAux)
{
  var iMenor = 0;
  for (var i = 1; i < aHotelesAuxAux.length; i++)
  {
    if (aHotelesAuxAux[i][2] < aHotelesAuxAux[iMenor][2])
    {
      iMenor = i;
    }
  }
  return iMenor;
}


function fLista (aHotelesAuxAux)
{
  var sTexto = "";
  var iContador = 0;
  while(true)
  {
    sTexto += fMostrarHotel(aHotelesAuxAux[iContador]);
    iContador ++;
    if (iContador >= aHotelesAuxAux.length)
    {
      break;
    }
    sTexto += "\n-----------------------------------------\n";
  }
  alert(sTexto);
}


function fMostrarHotel (aHotelAuxAux)
{
  var sTextoAux = "";
  sTextoAux += "Nombre  :   "+aHotelAuxAux[0]+"\n";
  sTextoAux += "Ciudad   :   "+aHotelAuxAux[1]+"\n";
  sTextoAux += "Precio     :   "+aHotelAuxAux[2]+" €\n";
  sTextoAux += "Piscina   :    ";
  if (aHotelAuxAux[3])
  {
    sTextoAux += "Si";
  }
  else
  {
    sTextoAux += "No";
  }
  return sTextoAux;
}

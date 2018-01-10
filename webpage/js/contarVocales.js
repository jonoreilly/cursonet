//definiciones
var sTexto = prompt("Cuentame un cuento").toLowerCase();
var iContador = 0;

//main code
for (var i = 0; i < sTexto.length; i++)
{
  switch (sTexto.charAt(i))
  {
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
      iContador ++;
  }
}
document.write("Hay " + iContador + "vocales");

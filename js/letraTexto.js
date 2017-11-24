//definiciones
var sTexto = prompt("Cuentame un cuento");
var sLetra = prompt("Cual busco");
var iContador = 0;

//main code
for (var i = 0; i < sTexto.length; i++)
{
  if (sTexto[i] == sLetra)
  {
    iContador ++;
  }
}
document.write(sLetra+" sale "+iContador+"veces");

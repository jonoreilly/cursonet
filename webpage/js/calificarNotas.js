//definiciones
var iNota = Number(prompt("Dime tu nota"));

//main code
switch (true)
{
  case 0 == iNota:
    document.write(iNota+", (-_-)");
    break;
  case 0 <= iNota && iNota < 5:
    document.write(iNota+", penco");
    break;
  case 5 <= iNota && iNota < 6:
   document.write(iNota+", aprobao justico");
   break;
  case 6 <= iNota && iNota < 8:
   document.write(iNota+", no esta mal");
   break;
  case 8 <= iNota && iNota < 9:
    document.write(iNota+", toma ya");
    break;
  case 9 <= iNota && iNota < 10:
    document.write(iNota+", si senior");
    break;
  case iNota == 10:
    document.write(iNota+", PUTO AMO!!");
    break;
  default:
    document.write("ERROR");
}

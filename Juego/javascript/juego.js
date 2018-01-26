
var background = "../media/sprites/background.png"

 sprites = [];

var modelo_jugador = new modelo()

function inicio ()
{
  var canvas = document.getElementById("canvas");
  var ctx = canvas.getContext("2d");

  game(ctx);
}


function game(ctx)
{

  setInterval(refresh, 100, ctx);
}


function refresh(ctx, objetos)
{


}




class objeto
{
  constructor(x, y, w, h, s, i, l)
  {
    this.posx = x;
    this.posy = y;
    this.ancho = w/2;
    this.alto = h/2;
    this.bspd = s; //velocidad absoluta
    this.spdx = 0; //modulo vector x
    this.spdy = 0; //modulo vector y
    this.spriteSelected = 0;
    this.sprites = l;
    this.weapon = 0;
  }

  shoot()
  {

  }

  move()
  {
    this.posx += this.spdx*this.bspd;
    this.posy += this.spdy*this.bspd;
  }
}

class modelo
{
  constructor()
  {

  }
}
















window.addEventListener("load", inicio, "false");

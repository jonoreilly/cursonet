//import "juegoClases";

class objeto
{
  constructor(x, y, w, h, s, l)
  {
    this.posx = x;
    this.posy = y;
    this.ancho = w;
    this.alto = h;
    this.bspd = s; //velocidad absoluta
    this.spdx = 0; //modulo vector x
    this.spdy = 0; //modulo vector y
    this.spriteSelected = 0;
    this.steps = 7;
    this.stepCounter = 0;
    this.spriteDirection = 1;  //0=izquierda
    this.sprites = l;
    this.weapon = 0;
    this.falltopspd = 5;
    this.colisionIzquierda = false;
    this.colisionDerecha = false;
    this.colisionAbajo = false;
    this.colisionEscalera = false;
    this.colisionDano = false;
    this.colisionTirolina = false;
    this.tirolinaFin = [];
  }

  move()
  {
    this.posx += this.spdx*this.bspd;
    this.posy += this.spdy*this.bspd;

    this.stepCounter += 1;
    if (this.stepCounter > this.steps);
    {
      this.stepCounter = 0;
      this.spriteSelected += 1;
      if (this.spriteSelected > 3)
      {
        this.spriteSelected = 0;
      }
    }
  }

  point()
  {
    if (this.colisionTirolina)
    {
      this.spdy = Math.sqrt((this.pos))
    }
    else if (aPressed[0])
    {
      this.spriteDirection = 0;
      if (!this.colisionIzquierda)
      {
      this.spdx = -1;
      }
    }
    else if (dPressed[0])
    {
      this.spriteDirection = 1;
      if (!this.colisionDerecha)
      {
      this.spdx = 1;
      }
    }
    else if (this.colisionAbajo)
    {
      this.spdx = 0;
      this.steps = 0;
      this.spriteSelected = 0;
    }

    if (wPressed[0] && this.colisionEscalera)
    {
      this.spdy = -1;
    }
    else if (sPressed[0] && this.colisionEscalera)
    {
      this.spdy = 1;
    }
    else
    {
      this.spdy = 0;
    }

    if (!this.colisionAbajo && !this.colisionEscalera && !this.colisionTirolina && this.spdy < 1)
    {
      this.spdy += 0.2;
    }
  }

  paint(ctx)
  {
    ctx.drawImage(this.sprites[this.spriteDirection][this.spriteSelected], this.posx, this.posy);
  }


  checkfloor (map)
  {
    var colision = false;
    var item;
    for (item of map.blocks)
    {
      if ((this.posx < item[2]) && (this.posx+this.ancho > item[0]))
      {
        if ((this.posy+this.alto-this.falltopspd < item[1] < this.posy+this.alto+this.falltopspd))
        {
          if (item[4] == 0 || item[4] == 1)
          {
            this.posy = item[1]-this.alto;
            colision = true;
          }
        }
      }
    }
    this.colisionAbajo = colision;
  }

  checksides (map)
  {
    var colisionD = false;
    var colisionI = false;
    var item;
    for (item of map.blocks)
    {
      if ((this.posy < item[3]) && (this.posy+this.alto > item[1]))
      {
        if (this.posx+(this.ancho/2) < item[1] < this.posx+this.ancho+this.bspd)
        {
          if (item[4] == 0)
          {
            colisionD = true;
          }
        }
        else if (this.posx-this.bspd < item[3] < this.posx+(this.ancho/2))
        {
          if (item[4] == 0)
          {
            colisionI = true;
          }
        }
      }
    }
    this.colisionDerecha = colisionD;
    this.colisionIzquierda = colisionI;
  }

  touching (map)
  {
    var touchingE = false;
    var touchingD = false;
    var touchingT = false;
    var item;
    for (item of map.blocks)
    {
      if ((this.posy < item[3]) && (this.posy+this.alto > item[1]))
      {
        if ((this.posx < item[2]) && (this.posx+this.ancho > item[0]))
        {
          if (item[4] == 2)
          {
            touchingE = true;
          }
          else if (item[4] == 3)
          {
            touchingD = true;
          }
          else if (item[4] == 4)
          {
            touchingT = true;
            this.tirolinaFin = item[5];
          }
        }
      }
    }
    this.colisionEscalera = touchingE;
    this.colisionDano = touchingD;
    this.colisionTirolina = touchingT;
  }
}


class mapa
{
  constructor()
  {
    this.blocks = [];
  }

  add (sx,sy,ex,ey,tipo, extra) //tipo ->  0 = duro, 1 = plataforma, 2 = escalera, 3 = dano
  {
    this.blocks.push([sx,sy,ex,ey,tipo, extra]);
  }
}


//var background = "../media/sprites/background.png";


 var sprites_jugador = [[],[]];
 for (i = 0; i < 4; i++)
 {
   sprites_jugador[0][i] = new Image(32,64);
   sprites_jugador[0][i].src = "../media/sprites/soldado_izquierda"+i+".png";

   sprites_jugador[1][i] = new Image(32,64);
   sprites_jugador[1][i].src = "../media/sprites/soldado_derecha"+i+".png";
 }

var backgrounds = [];
for (i = 0; i < 2; i++)
{
  backgrounds[i] = new Image(1200, 600);
  backgrounds[i].src = "../media/backgrounds/map"+i+".png";
}

var map0 = new mapa();
map0.add(0,510, 424, 100, 0, false);
map0.add(486, 510, 700, 600, 0, false);
map0.add(582, 468, 800, 1000, 0, false);
map0.add(1040, 85, 1300, 700, 0, false);
map0.add(685, 368, 950, 688, 1, false);
map0.add(790, 365, 809, 470, 2, false);
map0.add(690, 258, 950, 278, 1, false);
map0.add(906, 258, 927, 371, 2, false);
map0.add(790, 365, 809, 470, 2, false);
map0.add(248, 220, 634, 242, 0, false);
map0.add(70, 192, 217, 208, 1, false);
map0.add(78, 53, 99, 190, 2, false);
map0.add(93, 57, 311, 72, 1, false);
map0.add(314, 1, 360, 25, 4, [1050, 1080]);


function inicio ()
{
  var canvas = document.getElementById("canvas");
  var ctx = canvas.getContext("2d");

  game(ctx);
}


function game(ctx)
{
  var jugador = new objeto(20, 440, 32, 64, 5, sprites_jugador);
  var listaobjetos = [jugador];


  setInterval(refresh, 500, ctx, listaobjetos);
}


function refresh(ctx, objetos)
{
  redraw(ctx);
  var item;
  for (item of objetos)
  {
    item.checkfloor(map0);
    item.checksides(map0);
    item.touching(map0);
    item.point();
    item.move();
    item.paint(ctx);
  }
}


function redraw (ctx)
{
  ctx.drawImage(backgrounds[1], 0, 0);
}



dPressed = [false];
aPressed = [false];
wPressed = [false];
sPressed = [false];


document.addEventListener('keydown', keyPressed.bind(document.event), "false");

function keyPressed(handle)
{
  if(handle.key == "a"){aPressed.pop();aPressed.push(true);}
  else{
    if(handle.key == "d"){dPressed.pop();dPressed.push(true);}
  }

  if(handle.key == "w"){wPressed.pop();wPressed.push(true);}
  else{
    if(handle.key == "s"){sPressed.pop();sPressed.push(true);}
  }
}

document.addEventListener('keyup', keyReleased.bind(document.event), "false");

function keyReleased(handle)
{
  if(handle.key == "a"){aPressed.pop();aPressed.push(false);}
  else{
    if(handle.key == "d"){dPressed.pop();dPressed.push(false);}
  }

  if(handle.key == "w"){wPressed.pop();wPressed.push(false);}
  else{
    if(handle.key == "s"){sPressed.pop();sPressed.push(false);}
  }
}



window.addEventListener("load", inicio, "false");


function inicio ()
{
  var canvas = document.getElementById("canvas");

  var ctx = canvas.getContext("2d");

  game(ctx);
/*
  ctx.beginPath();
  ctx.moveTo(75,50);
  ctx.lineTo(100,75);
  ctx.lineTo(100,25);
  ctx.fill();

  ctx.beginPath();
  ctx.moveTo(125,125);
  ctx.lineTo(125,75);
  ctx.lineTo(75,125);
  ctx.closePath();
  ctx.stroke();
*/
}



function game(pantalla)
{
  var jugador = new objeto(50,canvas.height/2,50,200, 5);
  var enemigo = new objeto(canvas.width-50,canvas.height/2,50,200, 2);
  var bola = new objeto(canvas.width/2,canvas.height/2,50,50, 5);
  var border = new objeto(canvas.width/2,canvas.height/2,canvas.width,canvas.height, 0);

  bola.spdy = Math.random() * (0.5 - (-0.5)) + (-0.5);
  bola.spdx = Math.sqrt(1-Math.abs(bola.spdy));
  if (Math.random()<0.5) {bola.spdx = -bola.spdx;}

  setInterval(refresh, 10, pantalla);

  function refresh(pantalla)
  {
    colObj(bola, jugador);
    colObj(bola, enemigo);

    colWall(bola, border);
    colWall(jugador, border);
    colWall(enemigo, border);

    if (gol[0] == true)
    {reset();
    gol.pop();
    gol.push(false);}

    bola.move();
    jugador.move();
    enemigo.move();

    if (upPressed[0] == true) {jugador.spdy = -1;}
    else {
      if (downPressed[0] == true) { jugador.spdy = 1;}
      else {jugador.spdy = 0;}
    }

    if (bola.posy > enemigo.posy)
    {enemigo.spdy = 1;}
    if (bola.posy < enemigo.posy)
    {enemigo.spdy = -1;}

    paint(border, "lightblue", pantalla);
    paint(bola, "indigo", pantalla);
    paint(jugador, "green", pantalla);
    paint(enemigo, "red", pantalla);
  }

  function reset()
  {
    jugador.posx = 50;
    jugador.posy = canvas.height/2;
    enemigo.posx = canvas.width-50;
    enemigo.posy = canvas.height/2;
    bola.posx = canvas.width/2;
    bola.posy = canvas.height/2;

    bola.spdy = Math.random() * (0.5 - (-0.5)) + (-0.5);
    bola.spdx = Math.sqrt(1-Math.abs(bola.spdy));
    if (Math.random()<0.5) {bola.spdx = -bola.spdx;}
  }
}

function colObj(obj1, obj2)
{
  if ((obj1.posx-obj1.ancho+(obj1.spdx*obj1.bspd))<=(obj2.posx+obj2.ancho+(obj2.spdx*obj2.bspd)))
  {
    if((obj1.posx+obj1.ancho+(obj1.spdx*obj1.bspd))>=(obj2.posx-obj2.ancho+(obj2.spdx*obj2.bspd)))
    {
      if((obj1.posy-obj1.alto+(obj1.spdy*obj1.bspd))<=(obj2.posy+obj2.alto+(obj2.spdy*obj2.bspd)))
      {
        if((obj1.posy+obj1.alto+(obj1.spdy*obj1.bspd))>=(obj2.posy-obj2.alto+(obj2.spdy*obj2.bspd)))
        {
          if(((obj1.alto+obj2.alto)<(obj1.posy-obj2.posy)>(0))||((obj1.alto+obj2.alto)<(-(obj1.posy-obj2.posy))>(0)))
          {
            obj1.bounce("y");
          }
          else{
            obj1.spdy = (obj1.spdy+((obj1.posy-obj2.posy)/obj2.alto))/2;
            obj1.spdx = Math.sqrt(1-Math.abs(obj1.spdy));
            if (obj1.posx>canvas.width/2) {obj1.spdx = -obj1.spdx;}
          }
        }
      }
    }
  }
}

function colWall(obj, borde)
{
  if (((obj.posx-obj.ancho)<=(borde.posx-borde.ancho)) || ((obj.posx+obj.ancho)>=(borde.posx+borde.ancho)))
  {
    alert("Gooooool");
    gol.pop();
    gol.push(true);
  }

  if (((obj.posy-obj.alto+(obj.spdy*obj.bspd))<=(borde.posy-borde.alto))&&(obj.spdy<0))
  {obj.bounce("y");}
  if (((obj.posy+obj.alto+(obj.spdy*obj.bspd))>=(borde.posy+borde.alto))&&(obj.spdy>0))
  {obj.bounce("y");}
}

function paint (obj, color, ctx)
{
  ctx.fillStyle=color;
  ctx.fillRect(obj.posx-obj.ancho,obj.posy-obj.alto,obj.ancho*2,obj.alto*2);
}


class objeto
{
  constructor(x, y, w, h, s)
  {
    this.posx = x;
    this.posy = y;
    this.spdx = 0;
    this.spdy = 0;
    this.ancho = w/2;
    this.alto = h/2;
    this.bspd = s;
  }

  bounce(axis)
  {
    if (axis == "x")
    {
      this.spdx = -this.spdx;
    }
    else
    {
      this.spdy = -this.spdy
    }
  }

  move()
  {
    this.posx += this.spdx*this.bspd;
    this.posy += this.spdy*this.bspd;
  }
}

var upPressed = [false];
var downPressed = [false];
var gol = [false];


function keyPressed(handle)
{
  if(handle.key == "w"){upPressed.pop();upPressed.push(true);}
  else{
    if(handle.key == "s"){downPressed.pop();downPressed.push(true);}
  }
}

function keyReleased(handle)
{
  if(handle.key == "w"){upPressed.pop();upPressed.push(false);}
  else{
    if(handle.key == "s"){downPressed.pop();downPressed.push(false);}
  }
}

document.addEventListener('keydown', keyPressed.bind(event), "false");

document.addEventListener('keyup', keyReleased.bind(event), "false");

window.addEventListener("load", inicio, "false");

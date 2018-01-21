
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
  var jugador = new objeto(50,300,50,200);
  var enemigo = new objeto(550,300,50,200);
  var bola = new objeto(300,300,50,50);
  var objetos = [jugador, enemigo, bola];

  bola.spdx = Math.random() * (1 - (-1)) + (-1);
  bola.spdy = Math.random() * (1 - (-1)) + (-1);

<<<<<<< HEAD
  document.setInterval()

  function refresh()
  {
=======
  var intervalID = window.setInterval(refresh, 500);

  function refresh()
  {

  }

  function redraw()
  {
    pantalla.clearRect(0,0,1200,1000);

    for (var i = 0; i < objetos.length; i++)
    {
      
    }
  }
}
>>>>>>> 6898c84e5b7907f38c3d54e42c68733e5f733612

  }
}


class objeto
{
  constructor(x, y, w, h)
  {
    posx = x;
    posy = y;
    spdx = 0;
    spdy = 0;
    ancho = w;
    alto = h;
  }
}









window.addEventListener("load", inicio, "false");

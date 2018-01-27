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


  checkfloor ()
  {
    var colision = false;
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

  checksides ()
  {
    var colisionD = false;
    var colisionI = false;
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

  add (sx,sy,ex,ey,tipo, extra=[]) //tipo ->  0 = duro, 1 = plataforma, 2 = escalera, 3 = dano
  {
    this.blocks.push([sx,sy,ex,ey,tipo, extra]);
  }
}

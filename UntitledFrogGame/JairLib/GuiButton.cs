using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DualityGame.JairLib
{
    public abstract class GuiButton : IJairObject, ICustomButton
    {
        public string identifier { get; set; }
        public Rectangle rectangle { get; set; }
        public Texture2D texture { get;} 
        public Color color { get; set; }
        public abstract void ButtonClicked();

        public GuiButton(Texture2D _texture)
        {
            texture = _texture;//Globals.GlobalContent.Load<Texture2D>($"./Sprites/blank-button");
            color = Color.White;
            rectangle = new Rectangle(0,0,128,128);
        }

        public void Update()
        {
            this.Hover();
            this.ButtonClicked();
        }
        public void Hover()
        {
            if (Globals.mouseRect.Intersects(rectangle))
                this.color = Color.LightGray;
            else
                this.color = Color.White;
        }
    }
}

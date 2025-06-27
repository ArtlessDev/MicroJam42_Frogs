using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualityGame.JairLib
{
    public class CustomButton : IJairObject
    {
        public CustomButton()
        {
            texture = Globals.GlobalContent.Load<Texture2D>("./Sprites/blank-button");
            rectangle = new Rectangle(64, 64, 128, 196);
            color = Color.White;
        }

        public string identifier { get; set; }
        public Rectangle rectangle { get; set; }
        public Texture2D texture { get; set; }
        public Color color { get; set; }

        Callback ChangeScreens = () =>
        {

        };
    }

    public delegate void Callback();
}

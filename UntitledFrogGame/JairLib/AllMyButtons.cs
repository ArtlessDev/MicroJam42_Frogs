using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualityGame.JairLib
{
    public class ButtonOne : GuiButton
    {
        public ButtonOne() : base(Globals.GlobalContent.Load<Texture2D>($"./Sprites/blank-button"))
        {

        }

        public override void ButtonClicked()
        {
            Debug.WriteLine("1");
        }
    }

    public class ButtonTwo : GuiButton
    {
        public ButtonTwo() : base(Globals.GlobalContent.Load<Texture2D>($"./Sprites/blank-button"))
        {

        }

        public override void ButtonClicked()
        {
            Debug.WriteLine("2");
        }
    }
}

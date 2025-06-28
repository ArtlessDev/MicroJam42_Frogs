using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Input;
using System.Diagnostics;

namespace DualityGame.JairLib
{
    public class TitleScreenButton : GuiButton
    {
        public TitleScreenButton() : base(Globals.GlobalContent.Load<Texture2D>($"./Sprites/blank-button"))
        {

        }
        public override void ButtonClicked() 
        {
            //Globals.screenManager.LoadScreen(new InGameScreen(game1), new FadeTransition(game.GraphicsDevice, Color.Black));

        }

        public bool WasButtonClicked()
        {
            //Globals.screenManager.LoadScreen(new InGameScreen(game1), new FadeTransition(game.GraphicsDevice, Color.Black));
            if (Globals.mouseRect.Intersects(rectangle) && Globals.mouseState.WasButtonPressed(MouseButton.Left))
                return true;
            else
                return false;
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

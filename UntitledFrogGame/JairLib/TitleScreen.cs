using DualityGame.JairLib;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Screens;
using System;

namespace UntitledFrogGame.JairLib
{
    public class TitleScreen : GameScreen
    {
        private Game1 Game => (Game1)base.Game;
        public TitleScreen(Game1 game) : base(game) { }
        private TitleScreenButton tsButton;

        public override void LoadContent()
        {
            base.LoadContent();

            tsButton = new TitleScreenButton();

        }

        public override void Update(GameTime gameTime)
        {

            tsButton.Hover();
            // TODO: Add your update logic here
            if (tsButton.WasButtonClicked())
                Game.LoadMidGameScreen();
        }

        public override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Blue);
            //var transformMatrix = Game.camera.GetViewMatrix();

            Game._spriteBatch.Begin();

            Game._spriteBatch.Draw(tsButton.texture, tsButton.rectangle, tsButton.color);

            Game._spriteBatch.End();

        }
    }
}

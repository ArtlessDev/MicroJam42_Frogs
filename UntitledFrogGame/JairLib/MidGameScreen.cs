using Microsoft.Xna.Framework;
using MonoGame.Extended.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UntitledFrogGame.JairLib
{
    public class MidGameScreen : GameScreen
    {
        private Game1 Game => (Game1)base.Game;
        public MidGameScreen(Game game) : base(game){}

        public override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkSeaGreen);

            Game._spriteBatch.Begin();

            Game._spriteBatch.End();
        }

        public override void Update(GameTime gameTime)
        {


        }
    }
}

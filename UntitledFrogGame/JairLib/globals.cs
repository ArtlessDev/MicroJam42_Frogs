using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.Input;
using MonoGame.Extended.Screens;

public static class Globals
{
    public static ContentManager GlobalContent;
    //controls
    public static Rectangle mouseRect;
    public static MouseStateExtended mouseState;
    public static SpriteFont gameFont;
    public static ScreenManager screenManager;

    public static void Update(GameTime gameTime)
    {
        MouseExtended.Update();
        mouseState = MouseExtended.GetState();
        mouseRect = new Rectangle(mouseState.X, mouseState.Y, 8, 8);
    }
}


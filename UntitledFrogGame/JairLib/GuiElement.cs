using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualityGame.JairLib
{
    public class GuiElement(string _texture, Rectangle _rectangle, Color _color) : IJairObject
    {
        public string identifier { get; set; } 
        public Rectangle rectangle { get; set; } = _rectangle;
        public Texture2D texture { get; set; } = Globals.GlobalContent.Load<Texture2D>(_texture);
        public Color color { get; set; } = _color;

        public void DrawGui(SpriteBatch spriteBatch, string _identifier)
        {
            spriteBatch.Draw(texture, new Rectangle(rectangle.X, rectangle.Y, 64, 64), Color.White);
            spriteBatch.DrawString(Globals.gameFont, $"{_identifier}", new Vector2(rectangle.X+32, rectangle.Y + 64), color);
        }

        public void DrawGuiFollow(SpriteBatch spriteBatch, string _identifier, decimal spot)
        {
            spriteBatch.Draw(texture, new Rectangle((int)spot, rectangle.Y, 64, 64), Color.White);
            spriteBatch.DrawString(Globals.gameFont, $"{_identifier}", new Vector2((float)spot + 32, rectangle.Y + 64), color);
        }
    }
}

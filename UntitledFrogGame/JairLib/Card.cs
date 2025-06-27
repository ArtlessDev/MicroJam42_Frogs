using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.Graphics;

public class Card : IJairObject 
{
    public Value CardValue { get; set; }
    public Suit CardSuit { get; set; }
    public int CardIntValue { get; set; }

    public Card(Value cardValue, int handCount, Suit suit)
    {
        CardIntValue = (int)cardValue;
        CardValue = cardValue;

        if (CardIntValue >= 11)
        {
            CardIntValue = 10;
        }

        CardSuit = suit;
        texture = Globals.GlobalContent.Load<Texture2D>($"./Sprites/{CardValue}");
        separateTexture = new Texture2DRegion(texture, GetCardSuitForTextureRegion(), 0, 850, 1200);

        //texture = Globals.GlobalContent.Load<Texture2D>("./Sprites/blokkit");
        rectangle = new Rectangle(handCount, 250, 200, 300);
        color = Color.White;
        identifier = CardValue.ToString();
    }

    public Card(int x, int y)
    {
        CardIntValue = Random.Shared.Next(1, 14);
        CardValue = (Value)CardIntValue;

        if (CardIntValue >= 11)
        {
            CardIntValue = 10;
        }
        
        CardSuit = (Suit)Random.Shared.Next(0, 4);
        texture = Globals.GlobalContent.Load<Texture2D>($"./Sprites/{CardValue}");
        separateTexture = new Texture2DRegion(texture, GetCardSuitForTextureRegion(), 0, 850, 1200);

        //card width 850
        rectangle = new Rectangle(x, y, 100, 150);
        color = Color.White;
        identifier = CardValue.ToString();
    }

    public Card()
    {
    }

    public string GetCardValue()
    {
        switch (CardValue)
        {
            case Value.One:
            case Value.Two:
            case Value.Three:
            case Value.Four:
            case Value.Five:
            case Value.Six:
            case Value.Seven:
            case Value.Eight:
            case Value.Nine:
            case Value.Ten:
            case Value.Eleven:
            case Value.Twelve:
            case Value.Thirteen:
                return "";
        }
        return "";
    }

    public int GetCardSuitForTextureRegion()
    {
        switch (this.CardSuit)
        {
            case Suit.Heart:
                return 0;
            case Suit.Diamond:
                return 1000;
            case Suit.Spade:
                return 2000;
            case Suit.Clover:
                return 3000;
            default:
                return 0;
        }
    }

    public string identifier { get; set; }
    public Rectangle rectangle { get; set; }
    public Texture2D texture { get; set; }
    public Texture2DRegion separateTexture { get; set; }
    public Color color { get ; set; }
}

public enum Value
{
    Zero,
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Eleven,
    Twelve,
    Thirteen
}

public enum Suit
{
    Heart,
    Clover,
    Spade,
    Diamond,
    Wild
}
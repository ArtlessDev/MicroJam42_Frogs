using System.Collections.Generic;
using DualityGame.JairLib;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Input;
using static DualityGame.JairLib.GameManager;

public static class Globals
{
    public static ContentManager GlobalContent;
    public static List<Card> PlayerHand;
    public static List<Card> PlayerDeck;
    public static int HandTotal = 0;
    public static bool NewCardAdded = false;
    public static string currentText = "";
    public static int CurrentRound = 1;
    public static int BaseBlackjack = 21;
    public static int StandingBlackjack = BaseBlackjack;
    public static int DealerToBeatSmall = 16;
    public static int DealerToBeatLarge = 18;
    public static int CurrentDealerToBeat = DealerToBeatSmall;
    public static GameState gameState = GameState.Gambling;
    public static int PlayerMoney = 0;
    public static bool NeedNewCards = true;
    public static List<Card> ShopCards;

    //controls
    public static Rectangle mouseRect;
    public static MouseStateExtended mouseState;
    //GUI ELEMENTS
    public static GuiElement guiDeck,
        guiDealerToBeat,
        guiMoney,
        guiBlackjack,
        guiPlayerHand;


    //GUI STUFF
    public static int blackjackSpotWidth = (int)(700 * .8f);
    public static decimal playerSpotWidth = (decimal)(blackjackSpotWidth * (HandTotal / StandingBlackjack));
    public static decimal dealertobeatSpotWidth = Globals.blackjackSpotWidth * ((decimal)Globals.CurrentDealerToBeat / (decimal)Globals.StandingBlackjack);  
    public static SpriteFont gameFont;

    public static void LoadContent()
    {
        gameFont = GlobalContent.Load<SpriteFont>("./PrettyPixelBIG");
    }

    public static void LoadDeckFirstTime()
    {
        //PlayerDeck = new List<Card>();
        //Heart
        PlayerDeck.Add(new Card(Value.One, PlayerHand.Count, Suit.Heart));
        PlayerDeck.Add(new Card(Value.Two, PlayerHand.Count, Suit.Heart));
        PlayerDeck.Add(new Card(Value.Three, PlayerHand.Count, Suit.Heart));
        PlayerDeck.Add(new Card(Value.Four, PlayerHand.Count, Suit.Heart));
        PlayerDeck.Add(new Card(Value.Five, PlayerHand.Count, Suit.Heart));
        PlayerDeck.Add(new Card(Value.Six, PlayerHand.Count, Suit.Heart));
        PlayerDeck.Add(new Card(Value.Seven, PlayerHand.Count, Suit.Heart));
        PlayerDeck.Add(new Card(Value.Eight, PlayerHand.Count, Suit.Heart));
        PlayerDeck.Add(new Card(Value.Nine, PlayerHand.Count, Suit.Heart));
        PlayerDeck.Add(new Card(Value.Ten, PlayerHand.Count, Suit.Heart));
        PlayerDeck.Add(new Card(Value.Eleven, PlayerHand.Count, Suit.Heart));
        PlayerDeck.Add(new Card(Value.Twelve, PlayerHand.Count, Suit.Heart));
        PlayerDeck.Add(new Card(Value.Thirteen, PlayerHand.Count, Suit.Heart));
        //Clover
        PlayerDeck.Add(new Card(Value.One, PlayerHand.Count, Suit.Clover));
        PlayerDeck.Add(new Card(Value.Two, PlayerHand.Count, Suit.Clover));
        PlayerDeck.Add(new Card(Value.Three, PlayerHand.Count, Suit.Clover));
        PlayerDeck.Add(new Card(Value.Four, PlayerHand.Count, Suit.Clover));
        PlayerDeck.Add(new Card(Value.Five, PlayerHand.Count, Suit.Clover));
        PlayerDeck.Add(new Card(Value.Six, PlayerHand.Count, Suit.Clover));
        PlayerDeck.Add(new Card(Value.Seven, PlayerHand.Count, Suit.Clover));
        PlayerDeck.Add(new Card(Value.Eight, PlayerHand.Count, Suit.Clover));
        PlayerDeck.Add(new Card(Value.Nine, PlayerHand.Count, Suit.Clover));
        PlayerDeck.Add(new Card(Value.Ten, PlayerHand.Count, Suit.Clover));
        PlayerDeck.Add(new Card(Value.Eleven, PlayerHand.Count, Suit.Clover));
        PlayerDeck.Add(new Card(Value.Twelve, PlayerHand.Count, Suit.Clover));
        PlayerDeck.Add(new Card(Value.Thirteen, PlayerHand.Count, Suit.Clover));
        //Diamond
        PlayerDeck.Add(new Card(Value.One, PlayerHand.Count, Suit.Diamond));
        PlayerDeck.Add(new Card(Value.Two, PlayerHand.Count, Suit.Diamond));
        PlayerDeck.Add(new Card(Value.Three, PlayerHand.Count, Suit.Diamond));
        PlayerDeck.Add(new Card(Value.Four, PlayerHand.Count, Suit.Diamond));
        PlayerDeck.Add(new Card(Value.Five, PlayerHand.Count, Suit.Diamond));
        PlayerDeck.Add(new Card(Value.Six, PlayerHand.Count, Suit.Diamond));
        PlayerDeck.Add(new Card(Value.Seven, PlayerHand.Count, Suit.Diamond));
        PlayerDeck.Add(new Card(Value.Eight, PlayerHand.Count, Suit.Diamond));
        PlayerDeck.Add(new Card(Value.Nine, PlayerHand.Count, Suit.Diamond));
        PlayerDeck.Add(new Card(Value.Ten, PlayerHand.Count, Suit.Diamond));
        PlayerDeck.Add(new Card(Value.Eleven, PlayerHand.Count, Suit.Diamond));
        PlayerDeck.Add(new Card(Value.Twelve, PlayerHand.Count, Suit.Diamond));
        PlayerDeck.Add(new Card(Value.Thirteen, PlayerHand.Count, Suit.Diamond));
        //Spade
        PlayerDeck.Add(new Card(Value.One, PlayerHand.Count, Suit.Spade));
        PlayerDeck.Add(new Card(Value.Two, PlayerHand.Count, Suit.Spade));
        PlayerDeck.Add(new Card(Value.Three, PlayerHand.Count, Suit.Spade));
        PlayerDeck.Add(new Card(Value.Four, PlayerHand.Count, Suit.Spade));
        PlayerDeck.Add(new Card(Value.Five, PlayerHand.Count, Suit.Spade));
        PlayerDeck.Add(new Card(Value.Six, PlayerHand.Count, Suit.Spade));
        PlayerDeck.Add(new Card(Value.Seven, PlayerHand.Count, Suit.Spade));
        PlayerDeck.Add(new Card(Value.Eight, PlayerHand.Count, Suit.Spade));
        PlayerDeck.Add(new Card(Value.Nine, PlayerHand.Count, Suit.Spade));
        PlayerDeck.Add(new Card(Value.Ten, PlayerHand.Count, Suit.Spade));
        PlayerDeck.Add(new Card(Value.Eleven, PlayerHand.Count, Suit.Spade));
        PlayerDeck.Add(new Card(Value.Twelve, PlayerHand.Count, Suit.Spade));
        PlayerDeck.Add(new Card(Value.Thirteen, PlayerHand.Count, Suit.Spade));

    }

}


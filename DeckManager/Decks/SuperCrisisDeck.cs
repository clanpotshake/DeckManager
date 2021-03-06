﻿using System.Collections.Generic;
using DeckManager.Cards;
using log4net;

namespace DeckManager.Decks
{
    public class SuperCrisisDeck : BaseDeck<SuperCrisisCard>
    {
        public SuperCrisisDeck(ILog logger) : base(logger)
        {
            InitDeck();
        }

        public void InitDeck()
        {
            var cardsFromBox = new List<SuperCrisisCard>();
            //TODO: Import the cards via JSON/XML reader - the goddamn NuGet packages aren't working right now.  Fill up the cardsFromBox object.

            Deck = cardsFromBox;
            Deck = Shuffle(Deck);
        }
    }
}

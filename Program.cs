using System;
using System.Collections.Generic;

namespace deck_shuffler
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to C#");
      //deck needs 52 unique cards
      //all cards should be represented as a string/name ex "ace of hearts"
      //there are four suits: clubs, diamonds, hearts, spades
      //there are 13 rank: ace, 2. 3. 4. 5. 6. 7. 8. 9. 10. jack. queen. king

      //create new deck
      var deck = new List<string>();


      //maybe do a list of the types of faces ex hearts spades diamonds clubs
      var cardsSuitValue = new List<string>() { "clubs", "diamonds", "hearts", "spades" };

      //list of card values
      var cardFaceValue = new List<string>() {"ace", "2", "3", "4", "5", "6", "7",
      "8", "9", "10", "jack", "queen", "king"};

      //have it list out each face for each suit
      for (var i = 0; i < cardsSuitValue.Count; i++)
      {
        var suitname = cardsSuitValue[i];

        for (var c = 0; c < cardFaceValue.Count; c++)
        {
          var facename = cardFaceValue[c];
          deck.Add(facename + " of " + suitname);
        }
      }



      //then have it pick a random card value?


      //have deck be shuffled 
      //once shuffled display top card
      //give user option to see the next card or quit

    }
  }
}

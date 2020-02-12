using System;
using System.Collections.Generic;

namespace deck_shuffler
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Let's pick a random card!");

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

      //have deck be shuffled 
      Random rnd = new Random();
      // for i from n - 1 down to 1 do:
      for (int i = deck.Count - 1; i >= 1; i--)
      {
        //   j = random integer up to i
        int j = rnd.Next(i);
        //   swap deck[i] with deck[j]
        var cardAtI = deck[i];
        var cardAtJ = deck[j];

        deck[i] = cardAtJ;
        deck[j] = cardAtI;
      }
      //this rights out the cards that have been assigned 
      for (int deckIndex = 0; deckIndex < deck.Count; deckIndex++)
      {
        var card = deck[deckIndex];

      }

      //display top card
      var topOfDeck = deck[0];
      Console.WriteLine(topOfDeck);


      //while loop
      var z = 1;

      while (true)
      {



        //give user option to see the next card or quit
        Console.WriteLine("Want to see the next card? Y or N");
        var choice = Console.ReadLine();
        if (choice == "y")
        {
          Console.WriteLine(deck[z]);
          z++;
        }
        else
        {
          break;
        }
      }



    }
  }
}

using System;
using System.Linq;
using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int Takedown) => string.Join("\n\n", Enumerable.Range((startBottles - (Takedown - 1)), Takedown).Reverse().Select(x => Verse(x)));
    public static string Verse(int bottles) => bottles switch
    {
        2 => "2 bottles of beer on the wall, 2 bottles of beer.\nTake one down and pass it around, 1 bottle of beer on the wall.",
        1 => "1 bottle of beer on the wall, 1 bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.",
        0 => "No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.",
        _ => $"{bottles} bottles of beer on the wall, {bottles} bottles of beer.\nTake one down and pass it around, {bottles - 1} bottles of beer on the wall."
    };
    /*public static string Recite(int startBottles, int takeDown)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < takeDown ; i++)
        {
            int currentBottle = startBottles - i;
            switch (currentBottle)
            {
                case (0) :
                    result.Append("No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.");
                    break;
                case (1):
                    result.Append($"1 bottle of beer on the wall, 1 bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.");
                    break;
                case (2):
                    result.Append($"2 bottles of beer on the wall, 2 bottles of beer.\nTake one down and pass it around, 1 bottle of beer on the wall.");
                    break;
                default:
                    result.Append($"{currentBottle} bottles of beer on the wall, {currentBottle} bottles of beer.\nTake one down and pass it around, {currentBottle - 1} bottles of beer on the wall.");
                    break;
            }

            if (i < takeDown - 1)
            {
                result.Append("\n\n");
            }
        }
        return result.ToString().Replace("\r\n", "\n");
    }*/

    /*public static string Recite(int startBottles, int takeDown)
    {
        StringBuilder result = new StringBuilder();

        for (int i = startBottles; i > startBottles - takeDown; i--)
        {
            switch (i)
            {
                 case (0) :result.Append("No more bottles of beer on the wall, no more bottles of beer.\n" +
                                          "Go to the store and buy some more, 99 bottles of beer on the wall.");
                     break;
                 case (1):
                     result.Append($"1 bottle of beer on the wall, 1 bottle of beer.\n" + 
                                   "Take it down and pass it around, no more bottles of beer on the wall.");
                     break;

                 case (2):
                     result.Append($"2 bottles of beer on the wall, 2 bottles of beer.\n" +
                                   "Take one down and pass it around, 1 bottle of beer on the wall.");
                     break;

                 default:
                     result.Append($"{i} bottles of beer on the wall, {i} bottles of beer.\n" + 
                                   $"Take one down and pass it around, {i - 1} bottles of beer on the wall.");
                     break;
            }
            if (i > startBottles - takeDown + 1)
            {
                result.Append("\n\n");
            }
        }
        return result.ToString();
    }*/
}



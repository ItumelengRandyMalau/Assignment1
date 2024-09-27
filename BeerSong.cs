using System;

public class BeerSong
{
    // Method to print the song
    public void SingSong()
    {
        // Loop from 99 down to 1
        for (int i = 99; i >= 1; i--)
        {
            if (i > 1)
            {
                // When there are multiple bottles
                Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer.");
                Console.WriteLine($"Take one down and pass it around, {i - 1} bottles of beer on the wall.\n");
            }
            else
            {
                // When there's only one bottle left
                Console.WriteLine($"{i} bottle of beer on the wall, {i} bottle of beer.");
                Console.WriteLine("Take one down and pass it around, no more bottles of beer on the wall.\n");
            }
        }

        // End of song
        Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
        Console.WriteLine("Go to the store and buy some more, 99 bottles of beer on the wall.\n");
    }
}
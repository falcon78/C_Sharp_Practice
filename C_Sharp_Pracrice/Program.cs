using System;

namespace Program
{
    class Genre
    {
        private string genre { get; set; }
        private static void Main ()
        {
            Genre a = new Genre();
            a.genre = "Hip-Hop";
            Console.WriteLine(a.genre);
        }
    }
}

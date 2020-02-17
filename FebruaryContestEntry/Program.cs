using System;

namespace FebruaryContestEntry
{
    class Shape
    {
        public int Longeur { get; set; }
        public int Largeur { get; set; }

        public ConsoleColor Color { get; set; }

        public ConsoleColor BordCorlor { get; set; }

        public Shape(int longueur, int largeur, ConsoleColor color = ConsoleColor.DarkYellow, ConsoleColor bordColor = ConsoleColor.DarkBlue)
        {
            this.Longeur = longueur;
            this.Largeur = largeur;
            this.Color = color;
            this.BordCorlor = bordColor;
        }
        private void DrawBlock(char representation, ConsoleColor c)
        {
            Console.BackgroundColor = c;
            Console.Write(representation);
            Console.ResetColor();
        }
        public void DisplayShape(char representation)
        {
            var nbXBlock = this.Largeur;
            var nbYBlock = this.Longeur;
            var blockColor = this.Color;
            for (int i = 0; i < nbXBlock; i++)
            {
                for (int j = 0; j < nbYBlock; j++)
                {
                    if (i == 0 || j == 0 || i == nbXBlock - 1 || j == nbYBlock - 1)
                        blockColor = this.BordCorlor;

                    DrawBlock(representation, blockColor);
                    blockColor = this.Color;
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
    class Program
    {
        const char block = '▓';
        static void Main(string[] args)
        {
            var sp = new Shape(30, 15, ConsoleColor.Yellow, ConsoleColor.Green);
            sp.DisplayShape(block);
            Console.ReadLine();
        }
    }
}

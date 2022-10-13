using System;

namespace piano
{
    class Program
    {
        static int[] ChangeOctave(int[] octava)
        {

            int[] firstOcatave = new int[] { 131, 139, 147, 156,
                                             165, 175, 185, 196,
                                             208, 220, 233, 246 };

            int[] secondOctave = new int[] { 261, 277, 294, 311,
                                             330, 349, 370, 392,
                                             415, 440, 466, 494 };
            if (octava[0] == firstOcatave[0])
            {
                octava = secondOctave;
            }
            else
            {
                octava = firstOcatave;
            }

            return octava;
        }
        static void PlayPiano(int[] octava, ConsoleKeyInfo key)
        {
            
            if (key.Key == ConsoleKey.Q)
            {
                Console.Beep(octava[0], 300); //C
            }
            if (key.Key == ConsoleKey.D2)
            {
                Console.Beep(octava[1], 300); //C#
            }
            if (key.Key == ConsoleKey.W)
            {
                Console.Beep(octava[2], 300); //D
            }
            if (key.Key == ConsoleKey.D3)
            {
                Console.Beep(octava[3], 300); //Eb
            }
            if (key.Key == ConsoleKey.E)
            {
                Console.Beep(octava[4], 300);  //E
            }
            if (key.Key == ConsoleKey.R)
            {
                Console.Beep(octava[5], 300);  //F
            }
            if (key.Key == ConsoleKey.D4)
            {
                Console.Beep(octava[6], 300);  //F#
            }
            if (key.Key == ConsoleKey.T)
            {
                Console.Beep(octava[7], 300); //G
            }
            if (key.Key == ConsoleKey.D5)
            {
                Console.Beep(octava[8], 300); //G#
            }
            if (key.Key == ConsoleKey.Y)
            {
                Console.Beep(octava[9], 300); //A
            }
            if (key.Key == ConsoleKey.D6)
            {
                Console.Beep(octava[10], 300); //Bb
            }
            if (key.Key == ConsoleKey.U)
            {
                Console.Beep(octava[11], 300); //B
            }

            Console.Clear();
        }
        static void Main(string[] args)
        {
            int[] octava = new int[] { 131, 139, 147, 156,
                                       165, 175, 185, 196,
                                       208, 220, 233, 246 };

            ConsoleKeyInfo key;
            while (true)
            {
                Console.WriteLine("перекдючение между октавами: Z ");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Z)
                {
                    octava = ChangeOctave(octava);
                }
                if (key.Key == ConsoleKey.Escape) break;

                PlayPiano(octava, key);
            }
        }
    }
}

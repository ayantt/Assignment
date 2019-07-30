using System;
using System.ComponentModel;

namespace Assignment_1
{
    class Program : NeededValue
    {       
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Intro();
        }
        public void Intro()
        {
            Program program = new Program();
            string temp;            
            do
            {
                Console.WriteLine("Welcome, Type the option number");
                Console.WriteLine(String.Format("{0}:  {1}", 1, "Score counter"));
                Console.WriteLine(String.Format("{0}:  {1}", 2, "Sqaud list"));

                int sLimit = int.Parse(Console.ReadLine());
                switch (sLimit)
                {
                    case 1:
                        program.OverStat();
                        break;
                    case 2:
                        Console.WriteLine("Squad List:");
                        for (int i = 0; i < 11; i++)
                            Console.WriteLine(Enum.GetName(typeof(PlayerName), i));
                        break;
                    default:
                        Console.WriteLine($"An unexpected value");
                        break;
                }
                Console.WriteLine("\nWanna try again? Hit 'Y' if yes otherwise Hit any key");
                temp = Console.ReadLine()[0].ToString();
                Console.WriteLine("\n");
            }
            while (temp == "y" || temp =="Y");
        }
        public void OverStat()
        {
            Console.WriteLine("Type score for every ball");
            Score score = new Score();
            for (ball = 0; ball < over.Length; ball++)
            {
                string input = Console.ReadLine();
                
                if (input == "W" || input == "w")
                {
                    over[ball] = 0;
                    wicket++;
                }
                else if (0 <= int.Parse(input) && int.Parse(input) <= 6)
                {
                    over[ball] = int.Parse(input);
                    score.Run = over[ball];
                }
                else
                {
                    Console.WriteLine("Invalid input, please type again");
                    ball--;
                }
            }
            foreach (int items in over)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("Score: " + score.Run + "/" + wicket);
        }
    }

    public class Score
    {
        private int run;
        public int Run
        {
            get
            {
                return run;
            }
            set
            {
                run += value;
            }
        }
    }

    public class NeededValue
    {
        protected int ball;
        protected int[] over = new int[6];
        protected int run = 0;
        protected int wicket = 0;                
    }
    public enum PlayerName
    {
        TAMIM_IQBAL,
        SOUMYA_SARKAR,
        Shakib_Al_Hasan,
        MUSHFIQUR_RAHIM,
        MAHMUDULLAH,
        MOSADDEK_HOSSAIN,
        SABBIR_RAHMAN,
        SHAFIUL_ISLAM,
        MASHRAFE_MORTAZA,
        RUBELHOSSAIN,
        MUSTAFIZUR_RAHMAN,       
    }

}

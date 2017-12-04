using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace UsingInheritanceDemo
{
    // TODO: Add Television class.
    class Television
    {

        //private string[] noticias = { "\n    ###\n   #O#O#\n   #####\n   #---#\n    ###\n   /   \\\n  |     |\n  |     |\n" ,
        //                              "\n    ###\n   #O#O#\n   #####\n   #< >#\n    ###\n   /   \\\n  |     |\n  |     |\n"};

        //private string[][] canal = {{ "\n    ###\n   #O#O#\n   #####\n   #---#\n    ###\n   /   \\\n  |     |\n  |     |\n" ,
        //                              "\n    ###\n   #O#O#\n   #####\n   #< >#\n    ###\n   /   \\\n  |     |\n  |     |\n"} };

        //{{"         \n   ___   \n  /   \\ \n |     |  \n |     |\n  \\___/  \n\n",
        //"         \n    /|   \n   / |   \n     |   \n  ___|__ \n\n"} };
        ////"\n    ###\n   #O#O#\n   #####\n   #---#\n    ###\n   /   \\\n  |     |\n  |     |\n" };


        private string[,] canal = new string [2,2];
        private int canalActual = 0;
        private int contador = 0;


        public Television()
        {
            InitChannels();
        }

        private void InitChannels()
        {
            canal[0,0] =  "\n   ___   \n  /   \\  \n |     |  \n |     | \n  \\___/  \n\n";
            canal[0,1] = "  _____    \n /     \\ \n|       | \n|       | \n|       | \n|       |\n \\_____/ \n\n";

            canal[1, 0] = "\n    ###\n   #O#O#\n   #####\n   #---#\n    ###\n   /   \\\n  |     |\n  |     |\n";
            canal[1, 1] = "\n    ###\n   #O#O#\n   #####\n   #< >#\n    ###\n   /   \\\n  |     |\n  |     |\n";
        }

        protected void SetChannel(int number)
        {
            canalActual = number;
        }

        protected void TurnOn()
        {
            Console.WriteLine("tele encendida");
        }

        public void Refresh()
        {
            Console.Clear();
            Console.WriteLine("Wide Tv channel Set " + canalActual);
            Console.Write(canal[canalActual,contador]);
            if (this.contador < 1)
            {
                contador++;
            }
            else
            {
                contador = 0;
            }
        }

        public void Mando()
        {
            SetChannel(Int32.Parse(Console.ReadLine()));
        }
    }
    


    // TODO: Add WidescreenTV class.

    class Program
    {
        static Television tv = new Television();

        public static void Refresher(Object source, ElapsedEventArgs e)
        {
            tv.Refresh();
        }

        static void Main(string[] args)
        {
            // TODO: Uncomment the following line of code.

            Timer aTimer = new Timer();

            aTimer.Interval = 2000;
            aTimer.Elapsed += Refresher;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;

            while (true)
            {
                tv.Mando();
            }
        }
    }
}

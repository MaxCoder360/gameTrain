using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTrain
{
    public class Constant
    {
        private static Constant _c;
        public Point WORLD_COORDS;

        public static Constant c
        {
            get => _c;
        }
        private Constant() { }
        public static void initialize(Form1 form1)
        {
            if (_c != null)
            {
                Console.WriteLine("Constant object recreate");
                return;
            }

            _c = new Constant();
            _c.WORLD_COORDS = new Point(form1.ClientSize);
        }
    }


    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 inception = new Form1();
            Constant.initialize(inception);
            Application.Run(inception);
        }
    }
}

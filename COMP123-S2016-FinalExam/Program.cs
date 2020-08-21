using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


//  COMP 123_Programming 2_M2020_Final Exam
//  Param Vir Singh Sandhu 
//  ID: 301118847
//
//
namespace COMP123_M2020_FinalExam
{
    public static class Program
    {
        public static Character Character = new Character();
        public static AbilityGeneratorForm Abilitygeneratorform;
        private static AboutBox m_aboutbox;
        public static FinalForm Finalform;
        public static GenerateNameForm Generatenameform;
        public static RaceAndClassForm Raceandclassform;
        public static SplashForm Splashform;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Splashform = new SplashForm();
            Abilitygeneratorform = new AbilityGeneratorForm();
            m_aboutbox = new AboutBox();
            Finalform = new FinalForm();
            Generatenameform = new GenerateNameForm();
            Raceandclassform = new RaceAndClassForm();

            Application.Run(Splashform);
        }
    }
}

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
        public static Character character = new Character();
        public static AbilityGeneratorForm abilitygeneratorform;
        private static AboutBox aboutbox;
        public static FinalForm finalform;
        public static GenerateNameForm generatenameform;
        public static RaceAndClassForm raceandclassform;
        public static SplashForm splashform;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashform = new SplashForm();
            abilitygeneratorform = new AbilityGeneratorForm();
            aboutbox = new AboutBox();
            finalform = new FinalForm();
            generatenameform = new GenerateNameForm();
            raceandclassform = new RaceAndClassForm();

            Application.Run(splashform);
        }
    }
}

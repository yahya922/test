using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UpdateDistance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            string sNew = @"yahya";
            string sOld = @"zahraa";


            try
            {
                Levenshtein l = new Levenshtein();


                while (true)
                {
                    /// Original version
                    /// 
                    ///
                    /* Read the initial time. */
                    DateTime startTime = DateTime.Now;

                   int firstOutpt= l.LD(sNew, sOld);

                    /* Read the end time. */
                    DateTime stopTime = DateTime.Now;

                    /* Compute the duration between the initial and the end time. */
                    TimeSpan duration = stopTime - startTime;
                    Console.WriteLine("Original:" + duration);


                    /// New version
                    /// 
                    ///
                    /* Read the initial time. */
                    startTime = DateTime.Now;

                  int secondOutput=  l.iLD(sNew, sOld);

                    /* Read the end time. */
                    stopTime = DateTime.Now;

                    /* Compute the duration between the initial and the end time. */
                    duration = stopTime - startTime;
                    Console.WriteLine("Nessw     :" + duration);

                    Console.WriteLine("----------------");
                }
            }
            catch (Exception exp)
            {
                System.Console.WriteLine(exp.ToString());
            }

        
    }
    }
}

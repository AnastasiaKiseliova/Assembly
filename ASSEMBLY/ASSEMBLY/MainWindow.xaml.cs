using System;
using System.Threading.Tasks;
using System.Windows;
using System.Threading;

namespace ASSEMBLY
{
    /// Interaction logic for MainWindow.xaml ////////////////////////////////////////////////////////////////////////////

    public partial class MainWindow : Window
    {
        // GLOBAL DATA //////////////////////////////////////////////////////////////////////////////////////////////////

        public string current_button;

        public bool isDone = false;

        public bool MB_is_placed = false;
        public bool CPU_is_placed = false;

        // ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public MainWindow()
        {
            InitializeComponent();
        }

        // NEW GAME //////////////////////////////////////////////////////////////////////////////////////////////////////

        private void NewGame()
        {
            
        }

        // END GAME //////////////////////////////////////////////////////////////////////////////////////////////////////

        private void EndGame()
        {
            MessageBox.Show("-/// NOPE ///-");
            NewGame();
        }

        // TIMER /////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Count()
        {
            Task.Run(()=>
            {
                for (int i = 0; i < 101; i++)
                {
                    this.Dispatcher.Invoke(new Action(()=>
                    {
                        if(isDone == false)
                        {
                            Timer.Value = i;
                        }
                    }
                    ));
                    
                    Thread.Sleep(1);
                }

                if (isDone == false)
                {
                    EndGame();
                }
            }
            );
        }

        // MOTHERBOARD ///////////////////////////////////////////////////////////////////////////////////////////////////

        private void MB_I_Click(object sender, RoutedEventArgs e)
        {
            if(current_button == "Motherboard")
            {
                isDone = true;
                Motherboard.Visibility = Visibility.Visible;
                MB_I.Visibility = Visibility.Collapsed;
                MB_B.Visibility = Visibility.Collapsed;

                CPU_B.Visibility = Visibility.Visible;
                RAM_B.Visibility = Visibility.Visible;
                EC_B.Visibility = Visibility.Visible;

                Timer.Value = 0;
            }
            else
            {
                isDone = false;
                EndGame();
            }

            current_button = "";
        }

        private void MB_B_Click(object sender, RoutedEventArgs e)
        {

            current_button = "Motherboard";
            isDone = false;
            Count();
        }

        // HDD //////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void HDD_I_Click(object sender, RoutedEventArgs e)
        {
            if (current_button == "HDD")
            {
                isDone = true;
                HDD.Visibility = Visibility.Visible;
                HDD_I.Visibility = Visibility.Collapsed;
                HDD_B.Visibility = Visibility.Collapsed;
            }
            else
            {
                EndGame();
            }

            current_button = "";
        }

        private void HDD_B_Click(object sender, RoutedEventArgs e)
        {
            current_button = "HDD";
            isDone = false;
            Count();
        }

        // FAN //////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FAN_I_Click(object sender, RoutedEventArgs e)
        {
            if (current_button == "FAN")
            {
                isDone = true;
                Fan.Visibility = Visibility.Visible;
                FAN_I.Visibility = Visibility.Collapsed;
                FAN_B.Visibility = Visibility.Collapsed;
            }
            else
            {
                EndGame();
            }

            current_button = "";
        }

        private void FAN_B_Click(object sender, RoutedEventArgs e)
        {
            current_button = "FAN";
            isDone = false;
            Count();
        }

        // POWER SUPPLY /////////////////////////////////////////////////////////////////////////////////////////////////

        private void PS_I_Click(object sender, RoutedEventArgs e)
        {
            if (current_button == "POWERSUPPLY")
            {
                isDone = true;
                PowerSupply.Visibility = Visibility.Visible;
                PS_I.Visibility = Visibility.Collapsed;
                PS_B.Visibility = Visibility.Collapsed;
            }
            else
            {
                EndGame();
            }

            current_button = "";
        }

        private void PS_B_Click(object sender, RoutedEventArgs e)
        {
            current_button = "POWERSUPPLY";
            isDone = false;
            Count();
        }
        
        // CPU /////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void CPU_I_Click(object sender, RoutedEventArgs e)
        {
            if (current_button == "CPU")
            {
                isDone = true;
                CPU.Visibility = Visibility.Visible;
                CPU_I.Visibility = Visibility.Collapsed;
                CPU_B.Visibility = Visibility.Collapsed;

                HS_B.Visibility = Visibility.Visible;
            }
            else
            {
                EndGame();
            }

            current_button = "";
        }

        private void CPU_B_Click(object sender, RoutedEventArgs e)
        {
            current_button = "CPU";
            isDone = false;
            Count();
        }

        // HEAT SINK ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void HS_I_Click(object sender, RoutedEventArgs e)
        {
            if (current_button == "HEATSINK")
            {
                isDone = true;
                CPU.Visibility = Visibility.Collapsed;
                HEATSINK.Visibility = Visibility.Visible;
                HS_I.Visibility = Visibility.Collapsed;
                HS_B.Visibility = Visibility.Collapsed;
            }
            else
            {
                EndGame();
            }

            current_button = "";
        }

        private void HS_B_Click(object sender, RoutedEventArgs e)
        {
            current_button = "HEATSINK";
            isDone = false;
            Count();
        }

        // EXPANSION CARD ///////////////////////////////////////////////////////////////////////////////////////////////

        private void EC_I_Click(object sender, RoutedEventArgs e)
        {
            if (current_button == "EXPANSIONCARD")
            {
                isDone = true;
                ExpansionCard.Visibility = Visibility.Visible;
                EC_I.Visibility = Visibility.Collapsed;
                EC_B.Visibility = Visibility.Collapsed;
            }
            else
            {
                EndGame();
            }

            current_button = "";
        }

        private void EC_B_Click(object sender, RoutedEventArgs e)
        {
            current_button = "EXPANSIONCARD";
            isDone = false;
            Count();
        }

        // RAM //////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void RAM_I_Click(object sender, RoutedEventArgs e)
        {
            if (current_button == "RAM")
            {
                isDone = true;
                RAM.Visibility = Visibility.Visible;
                RAM_I.Visibility = Visibility.Collapsed;
                RAM_B.Visibility = Visibility.Collapsed;
            }
            else
            {
                EndGame();
            }

            current_button = "";
        }

        private void RAM_B_Click(object sender, RoutedEventArgs e)
        {
            current_button = "RAM";
            isDone = false;
            Count();
        }

        // ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if(LOGO.Visibility == Visibility.Collapsed)
            {
                TUTORIAL.Visibility = Visibility.Collapsed;
                ENTER.Visibility = Visibility.Collapsed;
            }

            LOGO.Visibility = Visibility.Collapsed;
        }

        // ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDevW4L1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private string totalSentence = "";
        private string currentCode = "";
        private Keys lastTapped = Keys.None;
        enum Keys
        {
            None = 0,
            Dot = 1,
            Dash = 2,
            Space = 3
        }
        public MainPage()
        {
            InitializeComponent();
        }

        private void DotBtn_Pressed(object sender, EventArgs e)
        {
            currentCode += ".";
            lastTapped = Keys.Dot;
            LblMorse.Text += ".";
        }

        private void DashBtn_Pressed(object sender, EventArgs e)
        {
            currentCode += "-";
            lastTapped = Keys.Dash;
            LblMorse.Text += "-";
        }

        private void SpaceBtn_Pressed(object sender, EventArgs e)
        {
            if (lastTapped == Keys.Space)
            {
                totalSentence += " ";
                return;
            }
            totalSentence += Morse.MorseCoder(currentCode);
            currentCode = "";
            lastTapped = Keys.Space;
            LblMorse.Text = "";
            LblText.Text = totalSentence;
        }
    }
}

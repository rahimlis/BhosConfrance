using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BhosConfrance
{
    public partial class SplashScreen : Form
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        bool fadeIn = true;
        bool fadeOut = false; 
            
        public SplashScreen()
        {
            InitializeComponent();
            ExtraFormSettings();            
            SetAndStartTimer(); 
        }

        private void SetAndStartTimer()
        {
            t.Interval = 40;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }

        private void ExtraFormSettings()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Opacity = 0.3;        
        }


        void t_Tick(object sender, EventArgs e)
        {
            // Fade in by increasing the opacity of the splash to 1.0 
            if (fadeIn)
            {
                if (this.Opacity < 1.0)
                {
                    this.Opacity += 0.01;
                }
                // After fadeIn complete, begin fadeOut 
                else
                {
                    fadeIn = false;
                    fadeOut = true;
                }
            }
            else if (fadeOut) // Fade out by increasing the opacity of the splash to 1.0 
            {
                if (this.Opacity > 0)
                {
                    this.Opacity -= 0.03;
                }
                else
                {
                    fadeOut = false;
                }
            }

            // After fadeIn and fadeOut complete, stop the timer and close this splash. 
            if (!(fadeIn || fadeOut))
            {
                t.Stop();
                this.Close();
            }
        } 
    }
}

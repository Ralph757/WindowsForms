using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketballMoving
{
    public partial class Basketball : Form
    {
        //Defining the right and left of the 'X' axis
        int boundary_RX = 725;
        int boundary_LX =  244;        

        int vel_X = 5;   

        public Basketball()
        {
            InitializeComponent();
        }

        private void Move_Button(object sender, EventArgs e)
        {
            
            Start.Start();
            Start.Enabled = true;
        }

        private void Stop_Button(object sender, EventArgs e)
        {
            Start.Stop();
            stpbttn.Enabled = true;
        }

      

        private void Basketball_(object sender, EventArgs e)
        {

        }

        private void Timer(object sender, EventArgs e)
        {
            
            ball.Left += vel_X;


            if (ball.Left > boundary_RX)
            {
                vel_X *= -1;
            }

            if (ball.Right <= boundary_LX)
            {
                vel_X *= -1;
            }

            
        }

        private void Basketball_Load(object sender, EventArgs e)
        {

        }

        
    }
}



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










//        public Form1()
//        {
//            InitializeComponent();

//        }

//        public void Form1_Load(object sender, EventArgs e)
//        {

//        }

//        //private void Timer1_Tick(object sender, EventArgs e)
//        //{

//        //}

//        //private void Button1_Click(object sender, EventArgs e)
//        //{
//        //    Timer.Enabled = true;
//        //}



//        public void Basketball_LocationChanged(object sender, EventArgs e)
//        {

//        }

//        public void BasketBall(object sender, EventArgs e)
//        {

//        }

//        public void Timer_for_Move(object sender, EventArgs e)
//        {
//            //Timer.Enabled=true;           
//        }

//        private void Stop_Button(object sender, EventArgs e)
//        {
//            //Timer.Stop();
//        }

//        public void MoveBall(object sender, EventArgs e)
//        {
//            //Timer.Enabled = true;

//            basketball.Left += basketball.Left + vel_X;

//            //AFTER COLLISION WITH THE BOUNDARIES
//            if (basketball.Left > boundary_RX)
//            {
//                vel_X *= -1;
//            }

//            if (basketball.Right <= boundary_LX)
//            {
//                vel_X *= -1;
//            }

//            Timer.Enabled = true;




//        }



//    }

//}

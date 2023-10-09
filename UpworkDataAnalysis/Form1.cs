using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpworkDataAnalysis.UserControls;

namespace UpworkDataAnalysis
{
    public partial class Form1 : Form
    {
        NavigationControl navigationControl;
        NavigationButton navigationButton;
        Color defaultColor = Color.Transparent;
        Color selectColor = Color.MediumPurple;
        public Form1()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButton();
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControlList = new List<UserControl>() 
            {new UpworkAnalysis(),new FacebookAnalysis(),new Feedback() };
            navigationControl = new NavigationControl(userControlList, panel2);
            navigationControl.Display(0);
        }
        private void InitializeNavigationButton()
        {
            List<Button> buttonList = new List<Button>() { Facebook, Upwork, Feedback };

            navigationButton = new NavigationButton(buttonList,defaultColor,selectColor);

            navigationButton.HighLight(Upwork);
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Upwork_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButton.HighLight(Upwork);
        }

        private void Facebook_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButton.HighLight(Facebook);

        }

        private void Feedback_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButton.HighLight(Feedback);

        }
    }
}

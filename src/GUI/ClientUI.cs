using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demonical.src.GUI.Functions;

namespace Demonical.src.GUI
{
    public partial class Menu : Form
    {

        bool ACL = false;
        bool ACR = false;

        public Menu()
        {
            InitializeComponent();

            LDelay.Visible = false;
            LDelayLabel.Visible = false;
            LDelay.Minimum = 0;
            LDelay.Value = 10;
            LDelay.Maximum = 20;

            RDelay.Visible = false;
            RDelayLabel.Visible = false;
            RDelay.Minimum = 0;
            RDelay.Value = 10;
            RDelay.Maximum = 20;

            button1.Text = "AutoClicker [Left]";

            button1.MouseDown += RightClickL;

            button1.MouseDown += AutoClickerLStart;

            button2.Text = "AutoClicker [Right]";

            button2.MouseDown += RightClickR;

            button2.MouseDown += AutoClickerRStart;

            LDelay.Scroll += LDelayScroll;
            RDelay.Scroll += RDelayScroll;

            LDelayLabel.Text = $"Delay: {LDelay.Value}";
            RDelayLabel.Text = $"Delay: {RDelay.Value}";
        }

        private void LDelayScroll(object sender, EventArgs e)
        {
            LDelayLabel.Text = $"Delay: {LDelay.Value}";
        }

        private void RDelayScroll(object sender, EventArgs e)
        {
            RDelayLabel.Text = $"Delay: {RDelay.Value}";
        }

        public void RightClickL(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                LDelay.Visible = !LDelay.Visible;
                LDelayLabel.Visible = !LDelayLabel.Visible;
            }
        }

        public void RightClickR(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RDelay.Visible = !RDelay.Visible;
                RDelayLabel.Visible = !RDelayLabel.Visible;
            }
        }

        public void AutoClickerLStart(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ACR = !ACR;
            }

            if (ACR)
            {
                AutoClicker.AutoClick(LDelay.Value, 0x02, 0x04);
            }
        }

        public void AutoClickerRStart(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ACL = !ACL;
            }

            if (ACL) {
                AutoClicker.AutoClick(RDelay.Value, 0x08, 0x10);
            }
        }

        private void Demonical_Load(object sender, EventArgs e)
        {
        }
    }
}
            
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Saper
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            StreamReader fsetup = new StreamReader("setup.ini");
            string SetStr = fsetup.ReadLine();
            string[] Set = SetStr.Split(' ');
            if (Set[3] == "1")
                Level1.Checked = true;
            if (Set[3] == "2")
                Level2.Checked = true;
            if (Set[3] == "3")
                Level3.Checked = true;
            if (Set[3] == "4")
            {
                Level4.Checked = true;
                PrXVal.Text = Set[0];
                PrYVal.Text = Set[1];
                PrNVal.Text = Set[2];
            }
            fsetup.Close();
        }

        private void Level1_CheckedChanged(object sender, EventArgs e)
        {
            if (Level1.Checked)
            {
                PrXLabel.Visible = false;
                PrXVal.Visible = false;
                PrYLabel.Visible = false;
                PrYVal.Visible = false;
                PrNLabel.Visible = false;
                PrNVal.Visible = false;
            }
        }

        private void Level2_CheckedChanged(object sender, EventArgs e)
        {
            if (Level2.Checked)
            {
                PrXLabel.Visible = false;
                PrXVal.Visible = false;
                PrYLabel.Visible = false;
                PrYVal.Visible = false;
                PrNLabel.Visible = false;
                PrNVal.Visible = false;
            }
        }

        private void Level3_CheckedChanged(object sender, EventArgs e)
        {
            if (Level3.Checked)
            {
                PrXLabel.Visible = false;
                PrXVal.Visible = false;
                PrYLabel.Visible = false;
                PrYVal.Visible = false;
                PrNLabel.Visible = false;
                PrNVal.Visible = false;
            }
        }

        private void Level4_CheckedChanged(object sender, EventArgs e)
        {
            if (Level4.Checked)
            {
                PrXLabel.Visible = true;
                PrXVal.Visible = true;
                PrYLabel.Visible = true;
                PrYVal.Visible = true;
                PrNLabel.Visible = true;
                PrNVal.Visible = true;
            }
        }

        private void SetBtnOK_Click(object sender, EventArgs e)
        {
            if (Level1.Checked)
            {
                File.Delete("setup.ini");
                File.AppendAllText("setup.ini", "9 9 10 1");
            }

            if (Level2.Checked)
            {
                File.Delete("setup.ini");
                File.AppendAllText("setup.ini", "16 16 40 2");
            }

            if (Level3.Checked)
            {
                File.Delete("setup.ini");
                File.AppendAllText("setup.ini", "30 16 99 3");
            }

            if (Level4.Checked)
            {
                File.Delete("setup.ini");
                if (Int32.Parse(PrXVal.Text) > 30)
                    PrXVal.Text = "30";
                if (Int32.Parse(PrYVal.Text) > 30)
                    PrYVal.Text = "30";
                if (Int32.Parse(PrXVal.Text) < 5)
                    PrXVal.Text = "5";
                if (Int32.Parse(PrYVal.Text) < 1)
                    PrYVal.Text = "1";
                if (Int32.Parse(PrNVal.Text) >= Int32.Parse(PrXVal.Text) * Int32.Parse(PrYVal.Text))
                    PrNVal.Text = ((Int32.Parse(PrXVal.Text) * Int32.Parse(PrYVal.Text)) - 1).ToString();
                File.AppendAllText("setup.ini", Int32.Parse(PrXVal.Text).ToString() + " " + Int32.Parse(PrYVal.Text).ToString() + " " + Int32.Parse(PrNVal.Text).ToString() + " 4");
            }
        }

    }
}

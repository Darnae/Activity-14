using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttons_and_Boxes
{
    public partial class ButtonForm : Form
    {
        public ButtonForm()
        {
            InitializeComponent();
        }
        private void Option1_CheckedChanged(object sender, EventArgs e)
        {
            Random random = new Random();

            MessageBox.Show("You have chosen low range");

            ResultLabel.Text = random.Next(50).ToString() + " mana points and ";
        }

        private void Option2_CheckedChanged(object sender, EventArgs e)
        {
            Random rand = new Random();

            MessageBox.Show("You have chosen Mid Range");

            ResultLabel.Text = rand.Next(50,100).ToString() + " mana points and ";
        }
        private void HighRange_CheckedChanged(object sender, EventArgs e)
        {
            Random ran = new Random();

            MessageBox.Show("You have chosen High Range");

            ResultLabel.Text = ran.Next(100, 150).ToString() + " mana points and ";

        }
        private void ResultLabel_Click(object sender, EventArgs e)
        {
            
        }
        private void ButtonForm_Load(object sender, EventArgs e)
        {
            if (WizardCheck.Checked)
            {
                MessageBox.Show("You have chosen Wizard");

                CharacterLabel.Text = "You are a Wizard with ";
            }

            else if (KnightCheck.Checked)
            {
                MessageBox.Show("You have chosen Knight");
            }

            else if (PaladinCheck.Checked)
            {
                MessageBox.Show("You have chosen Paladin");
            }

        }

        private void WizardCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (WizardCheck.Checked)
            {
                MessageBox.Show("You have chosen Wizard");

                CharacterLabel.Text = "You are a Wizard with ";
            }

            if (KnightCheck.Checked && PaladinCheck.Checked)
            {
                MessageBox.Show("You have selected too many options. Pick Again.");
            }

            if (KnightCheck.Checked && WizardCheck.Checked && PaladinCheck.Checked)
            {
                MessageBox.Show("You have selected too many options. Pick Again.");
            }
        }

        private void KnightCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (KnightCheck.Checked)
            {
                MessageBox.Show("You have chosen Knight");

                CharacterLabel.Text = "You are a Knight with ";
            }

            if (KnightCheck.Checked && WizardCheck.Checked)
            {
                MessageBox.Show("You have selected too many options. Pick Again.");
            }

            if (KnightCheck.Checked && PaladinCheck.Checked)
            {
                MessageBox.Show("You have selected too many options. Pick Again.");
            }

            if (KnightCheck.Checked && PaladinCheck.Checked && WizardCheck.Checked)
            {
                MessageBox.Show("You have selected too many options. Pick Again.");
            }

        }

        private void PaladinCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (PaladinCheck.Checked)
            {
                MessageBox.Show("You have selected Paladin");

                CharacterLabel.Text = "You are a Paladin with ";
            }

            if (PaladinCheck.Checked && WizardCheck.Checked)
            {
                MessageBox.Show("You have selected too many options. Pick Again.");
            }

            if (PaladinCheck.Checked && KnightCheck.Checked)
            {
                MessageBox.Show("You have selected too many options. Pick Again.");
            }

            if (PaladinCheck.Checked && WizardCheck.Checked && KnightCheck.Checked)
            {
                MessageBox.Show("You have selected too many options. Pick Again.");
            }
        }

        private void Skills_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundRobinScheduler_2000006890
{
    public partial class ProgramStartForm : Form
    {
        public ProgramStartForm()
        {
            InitializeComponent();
        }

       


        private void start_stop_button_Click(object sender, EventArgs e)
        {
            //Form1 form1_algorithm = (Form1)Application.OpenForms["Form1"]; // simulation form forms

           // form1_algorithm.timer_tick = 0;

            if (simulation_mode_radio_button.Checked == true)
            {
                Form1 simulation_form = new Form1();
                simulation_form.Show();
            }
            else
            if (interactive_mode_radio_button.Checked == true)
            {
                interactive_form interactive_mode_form = new interactive_form();
                interactive_mode_form.Show();
            }

        }

        private void ProgramStartForm_Load(object sender, EventArgs e)
        {

        }
    }
}

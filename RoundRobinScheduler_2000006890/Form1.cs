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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int n = 3;

        public int[] processes_id_arr= new int[n];
        public string[] processes_name_arr = new string[n];
        public int[] processes_burst_time_arr= new int[n];

        public int quantum = 0;
        public int negative_quantum = 0;

        public int start_stop = 0;
        public  int step = 0;

        public int timer_tick = 0;

        public bool continue_step = false;

        roundrobinschedule rrs = new roundrobinschedule("Simulation Mode");






        private void Form1_Load(object sender, EventArgs e)
        {

            //quantum
            quantum = Convert.ToInt32(time_quantum_label.Text);

            // process id's
            processes_id_arr[0] = Convert.ToInt32(proc_id_1.Text);
            processes_id_arr[1] = Convert.ToInt32(proc_id_2.Text);
            processes_id_arr[2] = Convert.ToInt32(proc_id_3.Text);



            //process name
            processes_name_arr[0] = proc_name_1.Text;
            processes_name_arr[1] = proc_name_2.Text;
            processes_name_arr[2] = proc_name_3.Text;


            //progressbars
            proc_prog_1.Value = Convert.ToInt32(proc_prog_value_1.Text);
            proc_prog_2.Value = Convert.ToInt32(proc_prog_value_2.Text);
            proc_prog_3.Value = Convert.ToInt32(proc_prog_value_3.Text);

    
      


            n = processes_id_arr.Length;

            // Burst time of all processes
            processes_burst_time_arr[0] = Convert.ToInt32(proc_prog_value_1.Text);
            processes_burst_time_arr[1] = Convert.ToInt32(proc_prog_value_2.Text);
            processes_burst_time_arr[2] = Convert.ToInt32(proc_prog_value_3.Text);

            //
            start_stop = 0;// not yet start

            //current process
            current_process_id_value_label.Text = "N/A";
            current_process_name_value_label.Text = "N/A";

            //proc_prog_indicated value
            negative_quantum = quantum - (quantum*2);
            proc_prog_indicated_value_1.Text = Convert.ToString(negative_quantum);
            proc_prog_indicated_value_2.Text = Convert.ToString(negative_quantum);
            proc_prog_indicated_value_3.Text = Convert.ToString(negative_quantum);


            /***********************************************************////////////////////////////////





        }


        

        public void startProgram()
        {
           
            ready_label.Text = "Running";
            ready_label.ForeColor = Color.RoyalBlue;
            ready_label.BackColor = Color.LawnGreen;
            current_time_label.Visible = true;
            current_time_value_label.Visible = true;
            info_label.Visible = true;
            info2_label.Visible = true;
            current_process_label.Visible = true;
            current_process_id_label.Visible = true;
            current_process_name_value_label.Visible = true;
            current_process_name_label.Visible = true;
            current_process_id_value_label.Visible = true;
            current_process_name_value_label.Visible = true;
            step_label.Visible = true;
            step_value_label.Visible = true;
            proc_prog_indicated_value_1.Visible = false;
            proc_prog_indicated_value_2.Visible = false;
            proc_prog_indicated_value_3.Visible = false;

 
        }

        
        private void program_runing_timer_Tick(object sender, EventArgs e)
        {
            
          

            timer_tick++;
            Console.WriteLine("Program Çıkış Mesaj kutusu için bekliyor. Bekleme süresi: " + timer_tick + " saniye");
            if (timer_tick >= 60) // 3000 saniye 5 dakika
            {
                timer_tick = 0;
                //program_runing_timer.Enabled = false;
                //program_runing_timer.Stop();
                DialogResult dialogResult = MessageBox.Show("Do you want to continue where you left off?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes) { continue_step = true;} else if (dialogResult == DialogResult.No) { continue_step = false;Application.Exit(); } else if (dialogResult == DialogResult.Cancel) { continue_step = true; program_runing_timer.Enabled = true; program_runing_timer.Start(); }

                
            }

        }
        /*


        */

        public void stepIncrement()
        {
            step = step + 1;
            step_value_label.Text = Convert.ToString(step);
        }

        private void execute_button_Click(object sender, EventArgs e)
        {
           
            timer_tick = 0;
            if (execute_button.Text == "START")
            {

                start_stop = 1; 
                execute_button.Text = "STOP"; 
                execute_button.Image = Image.FromFile("C:\\Users\\Enes KILIÇ\\Desktop\\icons\\stop_34x34.png");


            }


            else if (execute_button.Text == "STOP") 
                    { 
                    start_stop = 0; 
                    execute_button.Text = "START"; 
                    execute_button.Image = Image.FromFile("C:\\Users\\Enes KILIÇ\\Desktop\\icons\\start_32x32.png"); 
                    }



            if (start_stop == 1)  // Program is start running
            {
                //MessageBox.Show("start");
                startProgram();
                //MessageBox.Show("start içinde");
                //rrs = "Simulation Mode";
              
                rrs.roundRobinSchedule(processes_id_arr, n, processes_burst_time_arr, quantum); // findingAvgTime



            }
            else
            if (start_stop == 0)// Program is stop running
            {
                this.Close();
                Form1 form1 = new Form1();
                form1.Show();
                //stopProgram
            }
        }
    }

}

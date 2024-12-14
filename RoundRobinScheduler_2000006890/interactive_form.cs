using System;
using System.Collections;
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
    public partial class interactive_form : Form
    {
        public interactive_form()
        {
            InitializeComponent();
        }


        //public static int n = 3;

        public ArrayList processes_id_arr = new ArrayList();
        public ArrayList processes_name_arr = new ArrayList();
        public ArrayList processes_burst_time_arr = new ArrayList();

        public int quantum = 0;
        public int negative_quantum = 0;

        public int start_stop = 0;
        public int step = 0;

        public int timer_tick = 0;

        public bool continue_step = false;


        roundrobinschedule rrs = new roundrobinschedule("Interactive Mode");




        private void interactive_form_Load(object sender, EventArgs e)
        {
            if (currents_Row_ID < 3)
            {
                DisableStartProgram();
            }
            else
            {
                ActivetStartProgram();
            }

            // form processesleri boş yüklencek  




        }

        //proc
        public int proc_id = 0;
        public int add_Row_ID = 0;
        public int currents_Row_ID = 0;


        //proc Labeles
        public int label_Y = 19; // 55




        //proc ProgressBar
        public int ProgressBar_Y = 19; // 55




        //proc Buttons
        public int button_Y = 4; // 55  -38


        private void process_add_button_Click(object sender, EventArgs e)
        {
            timer_tick = 0;
            interactive_form_giris interactive_Form_Giris = new interactive_form_giris();
            interactive_Form_Giris.Task = "add process";
            interactive_Form_Giris.ShowDialog();
        }


        public void renewProcessPanel()
        {
            timer_tick = 0;
            //MessageBox.Show(Convert.ToString(currents_Row_ID));
            if (currents_Row_ID < 3) 
            {
               
                DisableStartProgram();
            } else
            {
                ActivetStartProgram();
            }

            

            processes_id_arr.Clear();
            processes_name_arr.Clear();
            processes_burst_time_arr.Clear();

            //quantum
            quantum = Convert.ToInt32(time_quantum_label.Text);

            int proc_id_renewid = 0;
            int proc_name_renewid = 0;
            int proc_prog_renewid = 0;
            int proc_prog_value_renewid = 0;
            int proc_prog_indicated_value_renewid = 0;
            int proc_wt_value_renewid = 0;
            int proc_tat_value_renewid = 0;
            int proc_update_button_renewid = 0;
            int proc_delete_button_renewid = 0;
            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is Label)
                {
                    for (int i = 1; i <= add_Row_ID; i++)
                    {
                        /// MessageBox.Show( "Name:  " + ((Label)c).Name + "        ID:     " + ("proc_id_" + Convert.ToString(i)));
                        if (((Label)c).Name == ("proc_id_" + Convert.ToString(i))) // ex: proc_id_1
                        {

                            proc_id_renewid++;

                            ((Label)c).Name = "proc_id_" + Convert.ToString(proc_id_renewid); // re new id

                            //MessageBox.Show("proc_id_" + Convert.ToString(i) + "  >> " + "proc_id_" + Convert.ToString(proc_id_renewid));

                            processes_id_arr.Add(Convert.ToString(((Label)c).Text));

                        }
                    }
                }
            }
            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is Label)
                {
                    for (int i = 1; i <= add_Row_ID; i++)
                    {
                        if (((Label)c).Name == ("proc_name_" + Convert.ToString(i))) // ex: proc_name_1
                        {
                            proc_name_renewid++;
                            ((Label)c).Name = "proc_name_" + Convert.ToString(proc_name_renewid); // re new id

                            //MessageBox.Show("proc_id_" + Convert.ToString(i) + "  >> " + "proc_id_" + Convert.ToString(proc_id_renewid));

                            processes_name_arr.Add(Convert.ToString(((Label)c).Text));
                        }
                    }
                }
            }

            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is ProgressBar)
                {
                    for (int i = 1; i <= add_Row_ID; i++)
                    {
                        if (((ProgressBar)c).Name == ("proc_prog_" + Convert.ToString(i))) // ex: proc_name_1
                        {
                            proc_prog_renewid++;
                            ((ProgressBar)c).Name = "proc_prog_" + Convert.ToString(proc_prog_renewid); // re new id


                            processes_burst_time_arr.Add(Convert.ToString(((ProgressBar)c).Value));

                            // MessageBox.Show("proc_prog_" + Convert.ToString(i) + "  >> " + "proc_prog_" + Convert.ToString(proc_prog_renewid));

                            // diziye ekle yok
                        }
                    }
                }
            }

            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is Label)
                {
                    for (int i = 1; i <= add_Row_ID; i++)
                    {
                        if (((Label)c).Name == ("proc_prog_value_" + Convert.ToString(i))) // ex: proc_name_1
                        {
                            proc_prog_value_renewid++;
                            ((Label)c).Name = "proc_prog_value_" + Convert.ToString(proc_prog_value_renewid); // re new id

                            //MessageBox.Show("proc_prog_value_" + Convert.ToString(i) + "  >> " + "proc_prog_value_" + Convert.ToString(proc_prog_value_renewid));

                            // diziye ekle yok
                        }
                    }
                }
            }

            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is Label)
                {
                    for (int i = 1; i <= add_Row_ID; i++)
                    {
                        if (((Label)c).Name == ("proc_prog_indicated_value_" + Convert.ToString(i))) // ex: proc_name_1
                        {
                            proc_prog_indicated_value_renewid++;
                            ((Label)c).Name = "proc_prog_indicated_value_" + Convert.ToString(proc_prog_indicated_value_renewid); // re new id

                           // MessageBox.Show("proc_prog_indicated_value_" + Convert.ToString(i) + "  >> " + "proc_prog_indicated_value_" + Convert.ToString(proc_prog_indicated_value_renewid));

                            // diziye ekle yok
                        }
                    }
                }
            }

            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is Label)
                {
                    for (int i = 1; i <= add_Row_ID; i++)
                    {
                        if (((Label)c).Name == ("proc_wt_value_" + Convert.ToString(i))) // ex: proc_name_1
                        {
                            proc_wt_value_renewid++;
                            ((Label)c).Name = "proc_wt_value_" + Convert.ToString(proc_wt_value_renewid); // re new id

                            //MessageBox.Show("proc_wt_value_" + Convert.ToString(i) + "  >> " + "proc_wt_value_" + Convert.ToString(proc_wt_value_renewid));

                            // diziye ekle yok
                        }
                    }
                }
            }

            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is Label)
                {
                    for (int i = 1; i <= add_Row_ID; i++)
                    {
                        if (((Label)c).Name == ("proc_tat_value_" + Convert.ToString(i))) // ex: proc_name_1
                        {
                            proc_tat_value_renewid++;
                            ((Label)c).Name = "proc_tat_value_" + Convert.ToString(proc_tat_value_renewid); // re new id

                            //MessageBox.Show("proc_tat_value_" + Convert.ToString(i) + "  >> " + "proc_tat_value_" + Convert.ToString(proc_tat_value_renewid));

                            // diziye ekle yok
                        }
                    }
                }
            }

            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is Button)
                {
                    for (int i = 1; i <= add_Row_ID; i++)
                    {
                        if (((Button)c).Name == ("proc_update_button_" + Convert.ToString(i))) // ex: proc_name_1
                        {
                            proc_update_button_renewid++;
                            ((Button)c).Name = "proc_update_button_" + Convert.ToString(proc_update_button_renewid); // re new id

                            //MessageBox.Show("proc_update_button_" + Convert.ToString(i) + "  >> " + "proc_update_button_" + Convert.ToString(proc_update_button_renewid));

                            // diziye ekle yok
                        }
                    }
                }
            }

            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is Button)
                {
                    for (int i = 1; i <= add_Row_ID; i++)
                    {
                        if (((Button)c).Name == ("proc_delete_button_" + Convert.ToString(i))) // ex: proc_name_1
                        {
                            proc_delete_button_renewid++;
                            ((Button)c).Name = "proc_delete_button_" + Convert.ToString(proc_delete_button_renewid); // re new id

                            //MessageBox.Show("proc_delete_button_" + Convert.ToString(i) + "  >> " + "proc_delete_button_" + Convert.ToString(proc_delete_button_renewid));

                            // diziye ekle yok
                        }
                    }
                }
            }
        }


        

       // int proc_arr_id = 0;
        /*
        public void processRemoveArr(int _proc_rem_id)
        {
            interactive_form interactive_Form = (interactive_form)Application.OpenForms["interactive_form"];



            //processes herşeyiyle sil
            proc_arr_id = _proc_rem_id - 1;
            processes_id_arr.RemoveAt(proc_arr_id);
            processes_name_arr.RemoveAt(proc_arr_id);
            processes_burst_time_arr.RemoveAt(proc_arr_id);


        }
        */

        public void processRemoveInterface(int _proc_rem_id)
        {
            //add_Row_ID--;
            // proc_id = 0;
            // add_Row_ID = 0;


            //proc Labeles

            // silinen y kordinatı
            // MessageBox.Show("Add Row ID:" + add_Row_ID) ;
            label_Y = 19; // 5
            label_Y = label_Y + (36 * (add_Row_ID)); // new y koor 




            //proc ProgressBar
            ProgressBar_Y = ProgressBar_Y + (36 * add_Row_ID); ; //36

            //proc Buttons
            button_Y = button_Y + (38 * add_Row_ID); ;

            currents_Row_ID--;
            //MessageBox.Show("azaltıldı");
            renewProcessPanel();

            //Yeniden Sırala
            /**/
            reSortProcessLabel("proc_id_", _proc_rem_id);
            reSortProcessLabel("proc_name_", _proc_rem_id);
            reSortProcessProgressBar("proc_prog_", _proc_rem_id);
            reSortProcessLabel("proc_prog_value_", _proc_rem_id);
            reSortProcessLabel("proc_prog_indicated_value_", _proc_rem_id);
            reSortProcessLabel("proc_wt_value_", _proc_rem_id);
            reSortProcessLabel("proc_tat_value_", _proc_rem_id);
            reSortProcessButton("proc_update_button_", _proc_rem_id);
            reSortProcessButton("proc_delete_button_", _proc_rem_id);

            /*Componenetleri silme*/


            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is Label)
                {

                    if (((Label)c).Name == ("proc_id_" + Convert.ToString(_proc_rem_id)))
                    {
                        this.processes_panel.Controls.Remove(((Label)c));
                    }
                }
            }
            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is Label)
                {
                    if (((Label)c).Name == ("proc_name_" + Convert.ToString(_proc_rem_id)))
                    {
                        this.processes_panel.Controls.Remove(((Label)c));
                    }
                }
            }
            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is Label)
                {
                    if (((Label)c).Name == ("proc_prog_value_" + Convert.ToString(_proc_rem_id)))
                    {
                        this.processes_panel.Controls.Remove(((Label)c));
                    }
                }
            }
            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is Label)
                {
                    if (((Label)c).Name == ("proc_prog_indicated_value_" + Convert.ToString(_proc_rem_id)))
                    {
                        this.processes_panel.Controls.Remove(((Label)c));
                    }
                }
            }
            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is Label)
                {
                    if (((Label)c).Name == ("proc_prog_indicated_value_" + Convert.ToString(_proc_rem_id)))
                    {
                        this.processes_panel.Controls.Remove(((Label)c));
                    }
                }
            }
            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is Label)
                {
                    if (((Label)c).Name == ("proc_wt_value_" + Convert.ToString(_proc_rem_id)))
                    {
                        this.processes_panel.Controls.Remove(((Label)c));
                    }
                }
            }
            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is Label)
                {
                    if (((Label)c).Name == ("proc_tat_value_" + Convert.ToString(_proc_rem_id)))
                    {
                        this.processes_panel.Controls.Remove(((Label)c));
                    }
                }
            }
            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is ProgressBar)
                {
                    if (((ProgressBar)c).Name == ("proc_prog_" + Convert.ToString(_proc_rem_id)))
                    {
                        this.processes_panel.Controls.Remove(((ProgressBar)c));
                    }
                }
            }
            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is ProgressBar)
                {
                    if (((ProgressBar)c).Name == ("proc_prog_" + Convert.ToString(_proc_rem_id)))
                    {
                        this.processes_panel.Controls.Remove(((ProgressBar)c));
                    }
                }
            }
            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is Button)
                {
                    if (((Button)c).Name == ("proc_update_button_" + Convert.ToString(_proc_rem_id)))
                    {
                        this.processes_panel.Controls.Remove(((Button)c));
                    }
                }
            }
            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is Button)
                {
                    if (((Button)c).Name == ("proc_delete_button_" + Convert.ToString(_proc_rem_id)))
                    {
                        this.processes_panel.Controls.Remove(((Button)c));
                    }
                }
            }

            /*Componentleri silme*/

           
            // add_Row_ID--;




            /*
            if (((Label)c).Name == ("proc_prog_value_" + Convert.ToString(_proc_rem_id)))
            {
                this.processes_panel.Controls.Remove(((Label)c));
            }
            if (((Label)c).Name == ("proc_prog_indicated_value_" + Convert.ToString(_proc_rem_id)))
            {
                this.processes_panel.Controls.Remove(((Label)c));
            }
            if (((Label)c).Name == ("proc_wt_value_" + Convert.ToString(_proc_rem_id)))
            {
                this.processes_panel.Controls.Remove(((Label)c));
            }
            if (((Label)c).Name == ("proc_tat_value_" + Convert.ToString(_proc_rem_id)))
            {
                this.processes_panel.Controls.Remove(((Label)c));
            }
            */

        }
        bool before_prc_label = false;
        private void reSortProcessLabel(string proc_label_name, int __proc_rem_id)
        {


            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is Label)
                {

                    for (int i = 1; i <= add_Row_ID; i++)
                    {
                        before_prc_label = false;

                        //MessageBox.Show(i + " > " + __proc_rem_id   +  " add row id: "+ add_Row_ID);

                        if (i > __proc_rem_id) // silinenden büyük satırları al
                        {
                            //MessageBox.Show(i+" > "+__proc_rem_id);

                            if (((Label)c).Name == (proc_label_name + Convert.ToString(i)))
                            {

                                for (int j = 1; j <= add_Row_ID; j++)
                                {



                                    foreach (Control c2 in this.processes_panel.Controls)
                                    {
                                        if (c2 is Label)
                                        {
                                            //MessageBox.Show(((Label)c2).Name);
                                            if (((Label)c2).Name.Contains(proc_label_name))
                                            {
                                                //MessageBox.Show(((Label)c2).Name + " == " + (proc_label_name + Convert.ToString(i - j)));
                                                if (((Label)c2).Name == (proc_label_name + Convert.ToString(i - j)))
                                                {
                                                    before_prc_label = true;

                                                    Point konum = new Point();
                                                    //İki boyut olmasından dolayı X ve Y koordinatları için değer veriyorum.
                                                    konum.X = ((Label)c2).Location.X;
                                                    konum.Y = ((Label)c).Location.Y - 36;


                                                    ((Label)c).Location = konum;

                                                    //MessageBox.Show("geçilecek: " + ((Label)c).Name);
                                                    // MessageBox.Show(((Label)c).Name + "  y kor:  " + ((Label)c).Location.Y);

                                                }
                                            }
                                        }
                                    }

                                    if (before_prc_label) break;
                                }


                            }
                        }
                    }
                }
            }
        }



        bool before_prc_progressbar = false;
        private void reSortProcessProgressBar(string proc_prog_name, int __proc_rem_id)
        {


            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is ProgressBar)
                {

                    for (int i = 1; i <= add_Row_ID; i++)
                    {
                        before_prc_progressbar = false;

                        //MessageBox.Show(i + " > " + __proc_rem_id   +  " add row id: "+ add_Row_ID);

                        if (i > __proc_rem_id) // silinenden büyük satırları al
                        {
                            //MessageBox.Show(i+" > "+__proc_rem_id);

                            if (((ProgressBar)c).Name == (proc_prog_name + Convert.ToString(i)))
                            {

                                for (int j = 1; j <= add_Row_ID; j++)
                                {



                                    foreach (Control c2 in this.processes_panel.Controls)
                                    {
                                        if (c2 is ProgressBar)
                                        {
                                            //MessageBox.Show(((Label)c2).Name);
                                            if (((ProgressBar)c2).Name.Contains(proc_prog_name))
                                            {
                                                //MessageBox.Show(((Label)c2).Name + " == " + (proc_label_name + Convert.ToString(i - j)));
                                                if (((ProgressBar)c2).Name == (proc_prog_name + Convert.ToString(i - j)))
                                                {
                                                    before_prc_progressbar = true;

                                                    Point konum = new Point();
                                                    //İki boyut olmasından dolayı X ve Y koordinatları için değer veriyorum.
                                                    konum.X = ((ProgressBar)c2).Location.X;
                                                    konum.Y = ((ProgressBar)c).Location.Y - 36;


                                                    ((ProgressBar)c).Location = konum;

                                                    //MessageBox.Show("geçilecek: " + ((Label)c).Name);
                                                    // MessageBox.Show(((Label)c).Name + "  y kor:  " + ((Label)c).Location.Y);

                                                }
                                            }
                                        }
                                    }

                                    if (before_prc_progressbar) break;
                                }


                            }
                        }
                    }
                }
            }
        }


        bool before_prc_button = false;
        private void reSortProcessButton(string proc_button_name, int __proc_rem_id)
        {


            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is Button)
                {

                    for (int i = 1; i <= add_Row_ID; i++)
                    {
                        before_prc_button = false;

                        //MessageBox.Show(i + " > " + __proc_rem_id   +  " add row id: "+ add_Row_ID);

                        if (i > __proc_rem_id) // silinenden büyük satırları al
                        {
                            //MessageBox.Show(i+" > "+__proc_rem_id);

                            if (((Button)c).Name == (proc_button_name + Convert.ToString(i)))
                            {

                                for (int j = 1; j <= add_Row_ID; j++)
                                {



                                    foreach (Control c2 in this.processes_panel.Controls)
                                    {
                                        if (c2 is Button)
                                        {
                                            //MessageBox.Show(((Label)c2).Name);
                                            if (((Button)c2).Name.Contains(proc_button_name))
                                            {
                                                //MessageBox.Show(((Label)c2).Name + " == " + (proc_label_name + Convert.ToString(i - j)));
                                                if (((Button)c2).Name == (proc_button_name + Convert.ToString(i - j)))
                                                {
                                                    before_prc_button = true;

                                                    Point konum = new Point();
                                                    //İki boyut olmasından dolayı X ve Y koordinatları için değer veriyorum.
                                                    konum.X = ((Button)c2).Location.X;
                                                    konum.Y = ((Button)c).Location.Y - 36;


                                                    ((Button)c).Location = konum;

                                                    //MessageBox.Show("geçilecek: " + ((Label)c).Name);
                                                    // MessageBox.Show(((Label)c).Name + "  y kor:  " + ((Label)c).Location.Y);

                                                }
                                            }
                                        }
                                    }

                                    if (before_prc_button) break;
                                }


                            }
                        }
                    }
                }
            }
        }



        public void processUpdateInterface(int update_process_id) // burdayız
        {

        }

      

        public void startProgram()
        {
            //three_proc_warning_label

            if (processes_id_arr.Count >= 3)
            {
                process_add_button.Enabled = false;
                three_proc_warning_label.Visible = false;
                DisableEnableUpdateDeleteButton(false);

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
                //proc_prog_indicated_value_1.Visible = false;
                //proc_prog_indicated_value_2.Visible = false;
                //proc_prog_indicated_value_3.Visible = false;

                Console.WriteLine("Processes ID" + "\t\t" + "Process Name" + "\t\t" + "Burst time ");
                for (int i = 0; i < processes_id_arr.Count; i++)
                {
                    Console.WriteLine(" " + (processes_id_arr[i]) + "\t\t\t\t" + processes_name_arr[i] + "\t\t\t\t" + processes_burst_time_arr[i]);

                    /*
                    Console.WriteLine(" " + (processes_id_arr[i]) + "\t" + processes_name_arr[i] + "\t\t" + processes_burst_time_arr[i]
                                         + "\t " + wt[i] + "\t\t " + tat[i]);
                    */
                }
            } else
            {
                three_proc_warning_label.Visible = true;
                three_proc_warning_label.Text = "Please add at least three processes..";
            }

          
           
        }



        public void stopProgram()
        {
      
            interactive_form interactive_Form = (interactive_form)Application.OpenForms["interactive_form"];

            for (int i = 0; i <= interactive_Form.add_Row_ID; i++)
            {
                interactive_Form.processRemoveInterface(i);
            }

                process_add_button.Enabled = true;
                three_proc_warning_label.Visible = true;

                ready_label.Text = "Ready";
                ready_label.ForeColor = Color.PeachPuff;
                ready_label.BackColor = Color.RoyalBlue;

                current_time_label.Visible = false;
                current_time_value_label.Visible = false;
                current_time_label.Text = Convert.ToString(0); 

                info_label.Visible = false;
                info_label.Text = "";

                info2_label.Visible = false;
                info2_label.Text = "";

                current_process_label.Visible = false;

                current_process_id_label.Visible = false;

                current_process_name_value_label.Visible = false;
                current_process_name_value_label.Text = "";
                current_process_name_label.Visible = false;

                current_process_id_value_label.Visible = false;
                current_process_id_value_label.Text = "";


                step_label.Visible = false;
                step_value_label.Visible = false;
                step_value_label.Text = Convert.ToString(0);
            //proc_prog_indicated_value_1.Visible = false;
            //proc_prog_indicated_value_2.Visible = false;
            //proc_prog_indicated_value_3.Visible = false;

                average_turn_around_time_value_label.Text = "N/A";
                average_waiting_time_value_label.Text = "N/A";

                ActivetStartProgram();
                DisableEnableUpdateDeleteButton(true);
        }





        private void DisableEnableUpdateDeleteButton(bool on_off)
        {
            foreach (Control c in this.processes_panel.Controls)
            {
                if (c is Button)
                {
                    //MessageBox.Show(((Label)c2).Name);
                    if (((Button)c).Name.Contains("proc_update_button_") || ((Button)c).Name.Contains("proc_delete_button_"))
                    {
                        if (on_off)
                        {
                            ((Button)c).Enabled = true;
                        } else 
                        {
                            ((Button)c).Enabled = false;
                        }
                    }
                }
            }
        }



        public  void DisableStartProgram()
        {
            timer_tick = 0;
            three_proc_warning_label.Visible = true;
            execute_button.Enabled = false;
            execute_button.Cursor = Cursors.No;

        }

        public void ActivetStartProgram()
        {
            timer_tick = 0;
            three_proc_warning_label.Visible = false;
            execute_button.Enabled = true;
            execute_button.Cursor = Cursors.Hand;
        }


        private void execute_button_Click(object sender, EventArgs e)
        {
            timer_tick = 0;
            if (execute_button.Text == "START") { 


                start_stop = 1; execute_button.Text = "STOP"; execute_button.Image = Image.FromFile("C:\\Users\\Enes KILIÇ\\Desktop\\icons\\stop_34x34.png"); 
            
            
            } 
            
            
            else if (execute_button.Text == "STOP") { 
                start_stop = 0; execute_button.Text = "START"; execute_button.Image = Image.FromFile("C:\\Users\\Enes KILIÇ\\Desktop\\icons\\start_32x32.png"); }


            if (start_stop == 1)  // Program is start running
            {

                startProgram();
                //MessageBox.Show("start içinde");


                //rrs.main_program_model = "Interactive Mode";

                rrs.roundRobinSchedule(ArraylistToIntArr(processes_id_arr), processes_id_arr.Count, ArraylistToIntArr(processes_burst_time_arr), quantum); // findingAvgTime



            }
            else
            if (start_stop == 0)// Program is stop running
            {
                //stopProgram();
                this.Close();
                interactive_form interactive_Form = new interactive_form();
                interactive_Form.Show();
            }
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            timer_tick = 0;
            string waitingdialogResult = CustomMessageBox.ShowBox("The app will restart and your data will \n be gone...  Are you sure ?.", "Info", "YesNoCancel");
            if (waitingdialogResult.Equals("3")) //cancel
            {
                timer_tick = 0;
                //devam
            }
            if (waitingdialogResult.Equals("2")) //no
            {
                timer_tick = 0;
                //
            }
            if (waitingdialogResult.Equals("1")) //yes
            {
                Application.Restart();
            }
        }

        private int[] ArraylistToIntArr(ArrayList arrayList)
        {
            int[] array_list_int_Arr =  new int[arrayList.Count];
            for (int i = 0; i < arrayList.Count; i++)
            {
                array_list_int_Arr[i] = Convert.ToInt32(arrayList[i]);
            }

            return array_list_int_Arr;
        }

        private void program_runnig_timer_Tick(object sender, EventArgs e)
        {

            timer_tick++;
            Console.WriteLine("Program Çıkış Mesaj kutusu için bekliyor. Bekleme süresi: " + timer_tick + " saniye");
            if (timer_tick >= 60) // 3000 saniye 5 dakika
            {
                timer_tick = 0;
                //program_runing_timer.Enabled = false;
                //program_runing_timer.Stop();
                DialogResult dialogResult = MessageBox.Show("Do you want to continue where you left off?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes) { continue_step = true; } else if (dialogResult == DialogResult.No) { continue_step = false; Application.Exit(); } else if (dialogResult == DialogResult.Cancel) { continue_step = true; program_runnig_timer.Enabled = true; program_runnig_timer.Start(); }


            }
        }

        public void stepIncrement()
        {
            step = step + 1;
            step_value_label.Text = Convert.ToString(step);
        }
    }
}
    


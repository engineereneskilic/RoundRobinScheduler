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
    public partial class interactive_form_giris : Form
    {
        public interactive_form_giris()
        {
            InitializeComponent();
        }

        public string Task = ""; // "add process"  / "update processs"
        public int update_proc_id = 0;
        public int update_proc_id_arr = 0;

        int time_quantum = 0;
        int negative_quantum = 0;

        private void interactive_form_giris_Load(object sender, EventArgs e)
        {
            interactive_form interactive_Form = (interactive_form)Application.OpenForms["interactive_form"];
            update_proc_id_arr = update_proc_id - 1;


            if (Task == "update process") { title_label.Text = "Update Process"; messagebox_yes_button.Text = "Update"; } else if (Task == "add process") { title_label.Text = "Add a Process"; messagebox_yes_button.Text = "Add"; }

            renewTimeQuantum();

            // MessageBox.Show(Task);

            if (Task == "update process")
            {
                //MessageBox.Show("update");
                foreach (Control c in this.Controls)
                {
                    // MessageBox.Show("process_id_textbox");

                    if (c is TextBox)
                    {
                        // MessageBox.Show("process_id_textbox");

                        if (((TextBox)c).Name == ("process_id_textbox"))
                        {
                            //if (interactive_Form.processes_id_arr[update_proc_id_arr] != null) update_proc_id_arr = update_proc_id_arr - 1;
                            ((TextBox)c).Text = Convert.ToString(interactive_Form.processes_id_arr[update_proc_id_arr]);

                        }
                    }
                }

                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {

                        if (((TextBox)c).Name == ("process_name_textbox"))
                        {
                            //if (interactive_Form.processes_name_arr[update_proc_id_arr] != null) update_proc_id_arr = update_proc_id_arr - 1;
                            ((TextBox)c).Text = Convert.ToString(interactive_Form.processes_name_arr[update_proc_id_arr]);
                        }
                    }
                }

                foreach (Control c in this.Controls)
                {
                    if (c is NumericUpDown)
                    {

                        if (((NumericUpDown)c).Name == ("process_bursttime_numericUpDown"))
                        {
                           // if (interactive_Form.processes_burst_time_arr[update_proc_id_arr] != null) update_proc_id_arr = update_proc_id_arr - 1;
                            ((NumericUpDown)c).Value = Convert.ToInt32(interactive_Form.processes_burst_time_arr[update_proc_id_arr]);

                        }
                    }
                }

            }
        }







        //labels
        Font ProcesslabelsFonts = new Font("Serif", 14, FontStyle.Bold);
        public int label_X = -63; //starting process label 53 - 169
        public int labelcounter = 0;

        //ProgressBsar
        public int ProgressBar_X = 372; //starting process label 53 - 169
        public int progressBarcounter = 0;

        //buttons;
        Font ButtonsFonts = new Font("Serif", 8, FontStyle.Underline);

        public int button_X = 846; //starting process label 958  + 112
        public int buttoncounter = 0;



        private void messagebox_yes_button_Click(object sender, EventArgs e)
        {

            messagebox_yes_Button_Events();
        }

        private void messagebox_yes_Button_Events()
        {
            interactive_form interactive_Form = (interactive_form) Application.OpenForms["interactive_form"];
            interactive_Form.timer_tick = 0;
            // MessageBox.Show("Button Basıldı");


            bool add__update_ok = true;


            if (time_quantum_numericUpDown.Text == "")
            {
                add__update_ok = false;
                MessageBox.Show("Time Quantum cannot be empty!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (process_id_textbox.Text == "")
            {
                add__update_ok = false;
                MessageBox.Show("Process id cannot be empty!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (process_name_textbox.Text == "")
            {
                add__update_ok = false;
                MessageBox.Show("Process Name cannot be empty!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            if (process_bursttime_numericUpDown.Text == "")
            {
                add__update_ok = false;
                MessageBox.Show("Process Burst Time cannot be empty!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (Task == "add process")
            {

                if (add__update_ok)
                {
                    interactive_Form.proc_id++;
                    //MessageBox.Show("Eklenmeye başladı");
                    interactive_Form.add_Row_ID = interactive_Form.add_Row_ID + 1;
                    interactive_Form.currents_Row_ID = interactive_Form.currents_Row_ID + 1;
                    //interactive_Form.label_Y = interactive_Form.label_Y + 36; //36
                    //MessageBox.Show("label Y" + label_Y); ;
                    //interactive_Form.ProgressBar_Y = interactive_Form.ProgressBar_Y + 36; //36
                    // MessageBox.Show("ekleniyor");

                    //  interactive_Form.button_Y = interactive_Form.button_Y + 38;

                    //MessageBox.Show("Yeni row ekleme yei row num:" + interactive_Form.add_Row_ID);

                    interactive_Form.label_Y = 19; // 5
                    interactive_Form.label_Y = interactive_Form.label_Y + (36 * (interactive_Form.currents_Row_ID)); // new y koor 



                    interactive_Form.ProgressBar_Y = 19;
                    //proc ProgressBar
                    interactive_Form.ProgressBar_Y = interactive_Form.ProgressBar_Y + (36 * interactive_Form.currents_Row_ID); ; //36

                    interactive_Form.button_Y = 4;
                    //proc Buttons
                    interactive_Form.button_Y = interactive_Form.button_Y + (38 * interactive_Form.currents_Row_ID);




                    time_quantum = Convert.ToInt32(time_quantum_numericUpDown.Text);
                    interactive_Form.time_quantum_label.Text = Convert.ToString(time_quantum);
                    interactive_Form.quantum = time_quantum;



                    //Process id
                    AddLabel("proc_id_" + Convert.ToString(interactive_Form.proc_id), process_id_textbox.Text);

                    //Process Name
                    AddLabel("proc_name_" + Convert.ToString(interactive_Form.proc_id), process_name_textbox.Text);


                    //Burst Time  - proc_prog
                    AddProgressBar("proc_prog_" + Convert.ToString(interactive_Form.proc_id), Convert.ToInt32(process_bursttime_numericUpDown.Text));


                    //Burst Time  - proc_prog_value_1
                    AddLabel("proc_prog_value_" + Convert.ToString(interactive_Form.proc_id), Convert.ToString(process_bursttime_numericUpDown.Text));

                    negative_quantum = time_quantum - (time_quantum * 2);

                    //Burst Time  - proc_prog_indicated_value_1
                    AddLabel("proc_prog_indicated_value_" + Convert.ToString(interactive_Form.proc_id), Convert.ToString(negative_quantum));


                    //proc_wt_value_1
                    AddLabel("proc_wt_value_" + Convert.ToString(interactive_Form.proc_id), "N/A");

                    //proc_tat_value_1    
                    AddLabel("proc_tat_value_" + Convert.ToString(interactive_Form.proc_id), "N/A");


                    //proc_update_button
                    AddButton("proc_update_button_" + Convert.ToString(interactive_Form.proc_id), "UPDATE");

                    //proc_delete_button
                    AddButton("proc_delete_button_" + Convert.ToString(interactive_Form.proc_id), "DELETE");


                    labelcounter = 0;
                    interactive_Form.renewProcessPanel();
                    renewTimeQuantum();
                    this.Close();
                }
            }

            if (Task == "update process")
            {

                if (add__update_ok)
                {

                    UpdateLabel(update_proc_id);
                    UpdateProgressbar(update_proc_id);


                    labelcounter = 0;
                    interactive_Form.renewProcessPanel();
                    renewTimeQuantum();
                    this.Close();
                }
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }


        private void AddLabel(string _name, string text)
        {
            labelcounter++;
            interactive_form interactive_Form = (interactive_form)Application.OpenForms["interactive_form"];

            // ROW

            if (labelcounter == 1 || labelcounter == 2)
            {
                //Process ID
                label_X = label_X + 116; // first 55
            }
            else
            if (labelcounter == 3)
            {
                label_X = label_X + (203 + 126); // 203 progress + label
            }
            else
            if (labelcounter == 4)
            {
                label_X = label_X + 42; //38 first 55
            }
            else
            if (labelcounter == 5)
            {
                label_X = label_X + 130; // first 55
            }
            else
            if (labelcounter == 6)
            {
                label_X = label_X + 180; // first 55
            }
            else
            if (labelcounter == 7)
            {

            }




            Label label = new Label();
            label.Name = _name;
            label.Location = new Point(label_X, interactive_Form.label_Y);
            label.Text = text;
            label.AccessibleRole = AccessibleRole.Default;
            label.Visible = true;
            // MessageBox.Show(_name);

            label.BackColor = Color.DodgerBlue;
            label.ForeColor = Color.LawnGreen;

            if (_name.Contains("proc_prog_indicated_value_"))
            {
                label.BackColor = Color.LightSteelBlue;
                label.ForeColor = Color.Red;
                label.Visible = false;
            }

            if (_name.Contains("proc_wt_value"))
            {
                label.BackColor = Color.DodgerBlue;
                label.ForeColor = Color.Gold;
            }

            if (_name.Contains("proc_tat_value"))
            {
                label.BackColor = Color.DodgerBlue;
                label.ForeColor = Color.Gold;
            }




            label.Font = ProcesslabelsFonts;


            label.AutoSize = true;

            interactive_Form.processes_panel.Controls.Add(label);
            // MessageBox.Show("label eklendi");
        }



        private void AddProgressBar(string _name, int _value)
        {
            progressBarcounter++;
            interactive_form interactive_Form = (interactive_form)Application.OpenForms["interactive_form"];

            ProgressBar pBar = new ProgressBar();
            pBar.Name = _name;
            pBar.Location = new Point(ProgressBar_X, interactive_Form.ProgressBar_Y);
            pBar.Value = _value;
            pBar.BackColor = Color.DodgerBlue;
            pBar.Enabled = true;
            pBar.MarqueeAnimationSpeed = 100;
            pBar.Maximum = 15;
            pBar.Minimum = 0;
            pBar.Step = 1;
            pBar.Style = ProgressBarStyle.Blocks;
            pBar.Width = 103;
            pBar.Height = 23;
            pBar.Visible = true;


            interactive_Form.processes_panel.Controls.Add(pBar);

        }

        private void AddButton(string _name, string _buttontext)
        {
            buttoncounter++;
            interactive_form interactive_Form = (interactive_form)Application.OpenForms["interactive_form"];

            if (buttoncounter == 1 || buttoncounter == 2) // UPDATE - DELETE
            {
                //Process ID
                button_X = button_X + 112;
            }

            Button button = new Button();
            button.Name = _name;
            button.Font = ButtonsFonts;
            button.Location = new Point(button_X, interactive_Form.button_Y);
            button.Text = _buttontext;
            button.Visible = true;
            button.ForeColor = Color.Snow;

            if (_name.Contains("proc_update_button_"))
            {
                button.Image = Image.FromFile("C:\\Users\\Enes KILIÇ\\Desktop\\icons\\updatex35x34.fw.png");
                button.BackColor = Color.OrangeRed;

            }
            if (_name.Contains("proc_delete_button_"))
            {
                button.Image = Image.FromFile("C:\\Users\\Enes KILIÇ\\Desktop\\icons\\gnome_process_stop - 31x31x.png");
                button.BackColor = Color.Red;

            }
            button.Cursor = Cursors.Hand;

            button.Click += new EventHandler(processButtons);



            button.ImageAlign = ContentAlignment.MiddleRight;
            button.TextAlign = ContentAlignment.MiddleLeft;

            button.UseVisualStyleBackColor = false;
            button.Width = 106;
            button.Height = 37;

            interactive_Form.processes_panel.Controls.Add(button);
        }

        int proc_btn_id_num = 0;
        private void processButtons(object sender, EventArgs e)
        {
            interactive_form interactive_Form = (interactive_form)Application.OpenForms["interactive_form"];


            Button btn = (Button)sender;
            string[] btn_param = btn.Name.Split('_');
            proc_btn_id_num = Convert.ToInt32(btn_param[btn_param.Length - 1]);


            //interactive_Form.processRemoveArr(proc_btn_id_num);

            if (btn.Name.Contains("proc_delete_button_"))
            {
                interactive_Form.processRemoveInterface(proc_btn_id_num);
                interactive_Form.renewProcessPanel();
            }
            else
            if (btn.Name.Contains("proc_update_button_"))
            {

                interactive_form_giris interactive_Form_Giris = new interactive_form_giris();
                interactive_Form_Giris.Task = "update process";
                interactive_Form.renewProcessPanel();
                //MessageBox.Show("Güncellenecek id: " + Convert.ToString(btn.Name));
                interactive_Form_Giris.update_proc_id = proc_btn_id_num;
                interactive_Form_Giris.ShowDialog();


                interactive_Form.processUpdateInterface(proc_btn_id_num);
            }
            // interactive_Form.processes_panel.Controls.Remove(btn);


        }


        private void UpdateLabel(int _update_label_id)
        {
            update_proc_id_arr = 0;
            update_proc_id_arr = _update_label_id - 1;
            interactive_form interactive_Form = (interactive_form)Application.OpenForms["interactive_form"];
            foreach (Control c in interactive_Form.processes_panel.Controls)
            {
                // MessageBox.Show("process_id_textbox");

                if (c is Label)
                {
                

                    if (((Label)c).Name == ("proc_id_" + Convert.ToString(_update_label_id)))
                    {

                        interactive_Form.processes_id_arr[update_proc_id_arr] = Convert.ToInt32(process_id_textbox.Text);
                        ((Label)c).Text = Convert.ToString(interactive_Form.processes_id_arr[update_proc_id_arr]);
                        //MessageBox.Show(((Label)c).Text);
                    }
                }
            }


            foreach (Control c in interactive_Form.processes_panel.Controls)
            {
                // MessageBox.Show("process_id_textbox");

                if (c is Label)
                {
                    // MessageBox.Show("process_id_textbox");

                    if (((Label)c).Name == ("proc_name_" + Convert.ToString(_update_label_id)))
                    {

                        interactive_Form.processes_name_arr[update_proc_id_arr] = Convert.ToString(process_name_textbox.Text);
                        ((Label)c).Text = Convert.ToString(interactive_Form.processes_name_arr[update_proc_id_arr]);


                    }
                }
            }

            foreach (Control c in interactive_Form.processes_panel.Controls)
            {
                // MessageBox.Show("process_id_textbox");

                if (c is Label)
                {
                     //MessageBox.Show(((Label)c).Name);

                    if (((Label)c).Name == ("proc_prog_value_" + Convert.ToString(_update_label_id)))
                    {
                        //MessageBox.Show("Girdi:"+Convert.ToString(process_bursttime_numericUpDown.Value));
                        interactive_Form.processes_burst_time_arr[update_proc_id_arr] = Convert.ToInt32(process_bursttime_numericUpDown.Value);
                        ((Label)c).Text = Convert.ToString(interactive_Form.processes_burst_time_arr[update_proc_id_arr]);
                       // MessageBox.Show("Girdi:" + Convert.ToString(((Label)c).Text));
                    }
                }
            }

            renewTimeQuantum();

        }

        private void UpdateProgressbar(int _update_prog_id)
        {
            update_proc_id_arr = 0;
            update_proc_id_arr = _update_prog_id - 1;
            interactive_form interactive_Form = (interactive_form)Application.OpenForms["interactive_form"];

            foreach (Control c in interactive_Form.processes_panel.Controls)
            {
                // MessageBox.Show("process_id_textbox");

                if (c is ProgressBar)
                {
                    // MessageBox.Show("process_id_textbox");

                    if (((ProgressBar)c).Name == ("proc_prog_" + Convert.ToString(_update_prog_id)))
                    {

                        interactive_Form.processes_burst_time_arr[update_proc_id_arr] = Convert.ToInt32(process_bursttime_numericUpDown.Value);
                        ((ProgressBar)c).Value= Convert.ToInt32(interactive_Form.processes_burst_time_arr[update_proc_id_arr]);
                    }
                }
            }
        }


        private void renewTimeQuantum()
        {
            interactive_form interactive_Form = (interactive_form)Application.OpenForms["interactive_form"];

            if (Convert.ToString(time_quantum_numericUpDown.Value) != "") 
            {
                time_quantum = Convert.ToInt32(time_quantum_numericUpDown.Value);
                time_quantum_numericUpDown.Value = time_quantum;
                interactive_Form.time_quantum_label.Text = Convert.ToString(time_quantum);
                interactive_Form.quantum = time_quantum;
            } else
            {
                MessageBox.Show("Time Quantum değeri boş geçilemez !");
            }
           
        }

        private void messagebox_yes_button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                messagebox_yes_Button_Events();
            }
        }

        private void interactive_form_giris_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("bastın");
            if (e.KeyCode == Keys.Enter)
            {
                messagebox_yes_Button_Events();
            }
        }
    }
}
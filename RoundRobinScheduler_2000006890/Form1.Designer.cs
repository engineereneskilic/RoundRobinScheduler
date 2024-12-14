namespace RoundRobinScheduler_2000006890
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label title_form;
            System.Windows.Forms.Label label24;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.processid_label = new System.Windows.Forms.Label();
            this.proc_id_1 = new System.Windows.Forms.Label();
            this.proc_id_2 = new System.Windows.Forms.Label();
            this.proc_id_3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.proc_name_1 = new System.Windows.Forms.Label();
            this.proc_name_2 = new System.Windows.Forms.Label();
            this.proc_name_3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.proc_prog_value_1 = new System.Windows.Forms.Label();
            this.proc_prog_value_2 = new System.Windows.Forms.Label();
            this.proc_prog_value_3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.proc_wt_value_1 = new System.Windows.Forms.Label();
            this.proc_wt_value_2 = new System.Windows.Forms.Label();
            this.proc_wt_value_3 = new System.Windows.Forms.Label();
            this.proc_tat_value_1 = new System.Windows.Forms.Label();
            this.proc_tat_value_2 = new System.Windows.Forms.Label();
            this.proc_tat_value_3 = new System.Windows.Forms.Label();
            this.average_waiting_time_label = new System.Windows.Forms.Label();
            this.average_waiting_time_value_label = new System.Windows.Forms.Label();
            this.average_turn_around_time_label = new System.Windows.Forms.Label();
            this.average_turn_around_time_value_label = new System.Windows.Forms.Label();
            this.proc_prog_1 = new System.Windows.Forms.ProgressBar();
            this.proc_prog_2 = new System.Windows.Forms.ProgressBar();
            this.proc_prog_3 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.time_quantum_label = new System.Windows.Forms.Label();
            this.calculate_groupBox = new System.Windows.Forms.GroupBox();
            this.ready_label = new System.Windows.Forms.Label();
            this.current_process_id_value_label = new System.Windows.Forms.Label();
            this.current_process_name_label = new System.Windows.Forms.Label();
            this.current_process_id_label = new System.Windows.Forms.Label();
            this.info2_label = new System.Windows.Forms.Label();
            this.current_process_name_value_label = new System.Windows.Forms.Label();
            this.current_process_label = new System.Windows.Forms.Label();
            this.step_value_label = new System.Windows.Forms.Label();
            this.step_label = new System.Windows.Forms.Label();
            this.info_label = new System.Windows.Forms.Label();
            this.current_time_value_label = new System.Windows.Forms.Label();
            this.current_time_label = new System.Windows.Forms.Label();
            this.program_runing_timer = new System.Windows.Forms.Timer(this.components);
            this.proc_prog_indicated_value_1 = new System.Windows.Forms.Label();
            this.proc_prog_indicated_value_3 = new System.Windows.Forms.Label();
            this.proc_prog_indicated_value_2 = new System.Windows.Forms.Label();
            this.execute_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            title_form = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            this.calculate_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_form
            // 
            title_form.AutoSize = true;
            title_form.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            title_form.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title_form.ForeColor = System.Drawing.Color.White;
            title_form.Location = new System.Drawing.Point(296, 18);
            title_form.Name = "title_form";
            title_form.Size = new System.Drawing.Size(429, 41);
            title_form.TabIndex = 0;
            title_form.Text = "ROUND ROBIN SCHEDULER";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label24.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label24.ForeColor = System.Drawing.Color.White;
            label24.Location = new System.Drawing.Point(866, 676);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(188, 41);
            label24.TabIndex = 29;
            label24.Text = "ENES KILIÇ";
            // 
            // processid_label
            // 
            this.processid_label.AutoSize = true;
            this.processid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.processid_label.ForeColor = System.Drawing.Color.Azure;
            this.processid_label.Location = new System.Drawing.Point(47, 144);
            this.processid_label.Name = "processid_label";
            this.processid_label.Size = new System.Drawing.Size(100, 24);
            this.processid_label.TabIndex = 1;
            this.processid_label.Text = "Process ID";
            // 
            // proc_id_1
            // 
            this.proc_id_1.AutoSize = true;
            this.proc_id_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proc_id_1.ForeColor = System.Drawing.Color.LawnGreen;
            this.proc_id_1.Location = new System.Drawing.Point(86, 185);
            this.proc_id_1.Name = "proc_id_1";
            this.proc_id_1.Size = new System.Drawing.Size(21, 24);
            this.proc_id_1.TabIndex = 2;
            this.proc_id_1.Text = "1";
            // 
            // proc_id_2
            // 
            this.proc_id_2.AutoSize = true;
            this.proc_id_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proc_id_2.ForeColor = System.Drawing.Color.LawnGreen;
            this.proc_id_2.Location = new System.Drawing.Point(86, 230);
            this.proc_id_2.Name = "proc_id_2";
            this.proc_id_2.Size = new System.Drawing.Size(21, 24);
            this.proc_id_2.TabIndex = 4;
            this.proc_id_2.Text = "2";
            // 
            // proc_id_3
            // 
            this.proc_id_3.AutoSize = true;
            this.proc_id_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proc_id_3.ForeColor = System.Drawing.Color.LawnGreen;
            this.proc_id_3.Location = new System.Drawing.Point(86, 271);
            this.proc_id_3.Name = "proc_id_3";
            this.proc_id_3.Size = new System.Drawing.Size(21, 24);
            this.proc_id_3.TabIndex = 6;
            this.proc_id_3.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(175, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Process Name";
            // 
            // proc_name_1
            // 
            this.proc_name_1.AutoSize = true;
            this.proc_name_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proc_name_1.ForeColor = System.Drawing.Color.LawnGreen;
            this.proc_name_1.Location = new System.Drawing.Point(202, 185);
            this.proc_name_1.Name = "proc_name_1";
            this.proc_name_1.Size = new System.Drawing.Size(63, 24);
            this.proc_name_1.TabIndex = 8;
            this.proc_name_1.Text = "Excel";
            // 
            // proc_name_2
            // 
            this.proc_name_2.AutoSize = true;
            this.proc_name_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proc_name_2.ForeColor = System.Drawing.Color.LawnGreen;
            this.proc_name_2.Location = new System.Drawing.Point(202, 230);
            this.proc_name_2.Name = "proc_name_2";
            this.proc_name_2.Size = new System.Drawing.Size(115, 24);
            this.proc_name_2.TabIndex = 9;
            this.proc_name_2.Text = "Powerpoint";
            // 
            // proc_name_3
            // 
            this.proc_name_3.AutoSize = true;
            this.proc_name_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proc_name_3.ForeColor = System.Drawing.Color.LawnGreen;
            this.proc_name_3.Location = new System.Drawing.Point(202, 271);
            this.proc_name_3.Name = "proc_name_3";
            this.proc_name_3.Size = new System.Drawing.Size(158, 24);
            this.proc_name_3.TabIndex = 10;
            this.proc_name_3.Text = "Google Chrome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(401, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Burst Time";
            // 
            // proc_prog_value_1
            // 
            this.proc_prog_value_1.AutoSize = true;
            this.proc_prog_value_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proc_prog_value_1.ForeColor = System.Drawing.Color.LawnGreen;
            this.proc_prog_value_1.Location = new System.Drawing.Point(531, 185);
            this.proc_prog_value_1.Name = "proc_prog_value_1";
            this.proc_prog_value_1.Size = new System.Drawing.Size(32, 24);
            this.proc_prog_value_1.TabIndex = 12;
            this.proc_prog_value_1.Text = "10";
            // 
            // proc_prog_value_2
            // 
            this.proc_prog_value_2.AutoSize = true;
            this.proc_prog_value_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proc_prog_value_2.ForeColor = System.Drawing.Color.LawnGreen;
            this.proc_prog_value_2.Location = new System.Drawing.Point(536, 230);
            this.proc_prog_value_2.Name = "proc_prog_value_2";
            this.proc_prog_value_2.Size = new System.Drawing.Size(21, 24);
            this.proc_prog_value_2.TabIndex = 13;
            this.proc_prog_value_2.Text = "5";
            this.proc_prog_value_2.UseMnemonic = false;
            // 
            // proc_prog_value_3
            // 
            this.proc_prog_value_3.AutoSize = true;
            this.proc_prog_value_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proc_prog_value_3.ForeColor = System.Drawing.Color.LawnGreen;
            this.proc_prog_value_3.Location = new System.Drawing.Point(536, 271);
            this.proc_prog_value_3.Name = "proc_prog_value_3";
            this.proc_prog_value_3.Size = new System.Drawing.Size(21, 24);
            this.proc_prog_value_3.TabIndex = 14;
            this.proc_prog_value_3.Text = "8";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Azure;
            this.label12.Location = new System.Drawing.Point(446, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Simulation Mode";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Azure;
            this.label13.Location = new System.Drawing.Point(664, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 24);
            this.label13.TabIndex = 17;
            this.label13.Text = "Waiting Time";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Azure;
            this.label14.Location = new System.Drawing.Point(817, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 24);
            this.label14.TabIndex = 18;
            this.label14.Text = "Turn Around Time";
            // 
            // proc_wt_value_1
            // 
            this.proc_wt_value_1.AutoSize = true;
            this.proc_wt_value_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proc_wt_value_1.ForeColor = System.Drawing.Color.Gold;
            this.proc_wt_value_1.Location = new System.Drawing.Point(699, 184);
            this.proc_wt_value_1.Name = "proc_wt_value_1";
            this.proc_wt_value_1.Size = new System.Drawing.Size(45, 24);
            this.proc_wt_value_1.TabIndex = 19;
            this.proc_wt_value_1.Text = "N/A";
            // 
            // proc_wt_value_2
            // 
            this.proc_wt_value_2.AutoSize = true;
            this.proc_wt_value_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proc_wt_value_2.ForeColor = System.Drawing.Color.Gold;
            this.proc_wt_value_2.Location = new System.Drawing.Point(699, 230);
            this.proc_wt_value_2.Name = "proc_wt_value_2";
            this.proc_wt_value_2.Size = new System.Drawing.Size(45, 24);
            this.proc_wt_value_2.TabIndex = 20;
            this.proc_wt_value_2.Text = "N/A";
            // 
            // proc_wt_value_3
            // 
            this.proc_wt_value_3.AutoSize = true;
            this.proc_wt_value_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proc_wt_value_3.ForeColor = System.Drawing.Color.Gold;
            this.proc_wt_value_3.Location = new System.Drawing.Point(699, 270);
            this.proc_wt_value_3.Name = "proc_wt_value_3";
            this.proc_wt_value_3.Size = new System.Drawing.Size(45, 24);
            this.proc_wt_value_3.TabIndex = 21;
            this.proc_wt_value_3.Text = "N/A";
            // 
            // proc_tat_value_1
            // 
            this.proc_tat_value_1.AutoSize = true;
            this.proc_tat_value_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proc_tat_value_1.ForeColor = System.Drawing.Color.Gold;
            this.proc_tat_value_1.Location = new System.Drawing.Point(879, 185);
            this.proc_tat_value_1.Name = "proc_tat_value_1";
            this.proc_tat_value_1.Size = new System.Drawing.Size(45, 24);
            this.proc_tat_value_1.TabIndex = 22;
            this.proc_tat_value_1.Text = "N/A";
            // 
            // proc_tat_value_2
            // 
            this.proc_tat_value_2.AutoSize = true;
            this.proc_tat_value_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proc_tat_value_2.ForeColor = System.Drawing.Color.Gold;
            this.proc_tat_value_2.Location = new System.Drawing.Point(879, 230);
            this.proc_tat_value_2.Name = "proc_tat_value_2";
            this.proc_tat_value_2.Size = new System.Drawing.Size(45, 24);
            this.proc_tat_value_2.TabIndex = 23;
            this.proc_tat_value_2.Text = "N/A";
            // 
            // proc_tat_value_3
            // 
            this.proc_tat_value_3.AutoSize = true;
            this.proc_tat_value_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proc_tat_value_3.ForeColor = System.Drawing.Color.Gold;
            this.proc_tat_value_3.Location = new System.Drawing.Point(879, 270);
            this.proc_tat_value_3.Name = "proc_tat_value_3";
            this.proc_tat_value_3.Size = new System.Drawing.Size(45, 24);
            this.proc_tat_value_3.TabIndex = 24;
            this.proc_tat_value_3.Text = "N/A";
            // 
            // average_waiting_time_label
            // 
            this.average_waiting_time_label.AutoSize = true;
            this.average_waiting_time_label.BackColor = System.Drawing.Color.LightSeaGreen;
            this.average_waiting_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.average_waiting_time_label.ForeColor = System.Drawing.Color.Black;
            this.average_waiting_time_label.Location = new System.Drawing.Point(2, 666);
            this.average_waiting_time_label.Name = "average_waiting_time_label";
            this.average_waiting_time_label.Size = new System.Drawing.Size(201, 24);
            this.average_waiting_time_label.TabIndex = 26;
            this.average_waiting_time_label.Text = "Average Waiting Time:";
            // 
            // average_waiting_time_value_label
            // 
            this.average_waiting_time_value_label.AutoSize = true;
            this.average_waiting_time_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.average_waiting_time_value_label.ForeColor = System.Drawing.Color.Yellow;
            this.average_waiting_time_value_label.Location = new System.Drawing.Point(209, 665);
            this.average_waiting_time_value_label.Name = "average_waiting_time_value_label";
            this.average_waiting_time_value_label.Size = new System.Drawing.Size(50, 25);
            this.average_waiting_time_value_label.TabIndex = 27;
            this.average_waiting_time_value_label.Text = "N/A";
            this.average_waiting_time_value_label.UseMnemonic = false;
            // 
            // average_turn_around_time_label
            // 
            this.average_turn_around_time_label.AutoSize = true;
            this.average_turn_around_time_label.BackColor = System.Drawing.Color.LightSeaGreen;
            this.average_turn_around_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.average_turn_around_time_label.ForeColor = System.Drawing.Color.Black;
            this.average_turn_around_time_label.Location = new System.Drawing.Point(2, 699);
            this.average_turn_around_time_label.Name = "average_turn_around_time_label";
            this.average_turn_around_time_label.Size = new System.Drawing.Size(247, 24);
            this.average_turn_around_time_label.TabIndex = 28;
            this.average_turn_around_time_label.Text = "Average Turn Around Time:";
            // 
            // average_turn_around_time_value_label
            // 
            this.average_turn_around_time_value_label.AutoSize = true;
            this.average_turn_around_time_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.average_turn_around_time_value_label.ForeColor = System.Drawing.Color.Yellow;
            this.average_turn_around_time_value_label.Location = new System.Drawing.Point(255, 698);
            this.average_turn_around_time_value_label.Name = "average_turn_around_time_value_label";
            this.average_turn_around_time_value_label.Size = new System.Drawing.Size(50, 25);
            this.average_turn_around_time_value_label.TabIndex = 30;
            this.average_turn_around_time_value_label.Text = "N/A";
            this.average_turn_around_time_value_label.UseMnemonic = false;
            // 
            // proc_prog_1
            // 
            this.proc_prog_1.ForeColor = System.Drawing.Color.IndianRed;
            this.proc_prog_1.Location = new System.Drawing.Point(405, 185);
            this.proc_prog_1.Maximum = 15;
            this.proc_prog_1.Name = "proc_prog_1";
            this.proc_prog_1.Size = new System.Drawing.Size(103, 23);
            this.proc_prog_1.Step = 1;
            this.proc_prog_1.TabIndex = 31;
            this.proc_prog_1.Value = 10;
            // 
            // proc_prog_2
            // 
            this.proc_prog_2.Location = new System.Drawing.Point(405, 230);
            this.proc_prog_2.Maximum = 15;
            this.proc_prog_2.Name = "proc_prog_2";
            this.proc_prog_2.Size = new System.Drawing.Size(103, 23);
            this.proc_prog_2.Step = 1;
            this.proc_prog_2.TabIndex = 32;
            this.proc_prog_2.Value = 5;
            // 
            // proc_prog_3
            // 
            this.proc_prog_3.Location = new System.Drawing.Point(405, 271);
            this.proc_prog_3.Maximum = 15;
            this.proc_prog_3.Name = "proc_prog_3";
            this.proc_prog_3.Size = new System.Drawing.Size(103, 23);
            this.proc_prog_3.Step = 1;
            this.proc_prog_3.TabIndex = 33;
            this.proc_prog_3.Value = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(432, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Time Quantum:";
            // 
            // time_quantum_label
            // 
            this.time_quantum_label.AutoSize = true;
            this.time_quantum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.time_quantum_label.ForeColor = System.Drawing.Color.DarkBlue;
            this.time_quantum_label.Location = new System.Drawing.Point(579, 336);
            this.time_quantum_label.Name = "time_quantum_label";
            this.time_quantum_label.Size = new System.Drawing.Size(21, 24);
            this.time_quantum_label.TabIndex = 35;
            this.time_quantum_label.Text = "2";
            // 
            // calculate_groupBox
            // 
            this.calculate_groupBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.calculate_groupBox.Controls.Add(this.ready_label);
            this.calculate_groupBox.Controls.Add(this.current_process_id_value_label);
            this.calculate_groupBox.Controls.Add(this.current_process_name_label);
            this.calculate_groupBox.Controls.Add(this.current_process_id_label);
            this.calculate_groupBox.Controls.Add(this.info2_label);
            this.calculate_groupBox.Controls.Add(this.current_process_name_value_label);
            this.calculate_groupBox.Controls.Add(this.current_process_label);
            this.calculate_groupBox.Controls.Add(this.step_value_label);
            this.calculate_groupBox.Controls.Add(this.step_label);
            this.calculate_groupBox.Controls.Add(this.info_label);
            this.calculate_groupBox.Controls.Add(this.current_time_value_label);
            this.calculate_groupBox.Controls.Add(this.current_time_label);
            this.calculate_groupBox.ForeColor = System.Drawing.Color.Purple;
            this.calculate_groupBox.Location = new System.Drawing.Point(16, 376);
            this.calculate_groupBox.Name = "calculate_groupBox";
            this.calculate_groupBox.Size = new System.Drawing.Size(1038, 287);
            this.calculate_groupBox.TabIndex = 36;
            this.calculate_groupBox.TabStop = false;
            this.calculate_groupBox.Text = "Calculate";
            // 
            // ready_label
            // 
            this.ready_label.AutoSize = true;
            this.ready_label.BackColor = System.Drawing.Color.RoyalBlue;
            this.ready_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ready_label.ForeColor = System.Drawing.Color.PeachPuff;
            this.ready_label.Location = new System.Drawing.Point(430, 19);
            this.ready_label.Name = "ready_label";
            this.ready_label.Size = new System.Drawing.Size(117, 39);
            this.ready_label.TabIndex = 49;
            this.ready_label.Text = "Ready";
            // 
            // current_process_id_value_label
            // 
            this.current_process_id_value_label.AutoSize = true;
            this.current_process_id_value_label.BackColor = System.Drawing.Color.Teal;
            this.current_process_id_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.current_process_id_value_label.ForeColor = System.Drawing.Color.White;
            this.current_process_id_value_label.Location = new System.Drawing.Point(697, 260);
            this.current_process_id_value_label.Name = "current_process_id_value_label";
            this.current_process_id_value_label.Size = new System.Drawing.Size(21, 24);
            this.current_process_id_value_label.TabIndex = 48;
            this.current_process_id_value_label.Text = "1";
            this.current_process_id_value_label.UseMnemonic = false;
            this.current_process_id_value_label.Visible = false;
            // 
            // current_process_name_label
            // 
            this.current_process_name_label.AutoSize = true;
            this.current_process_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.current_process_name_label.ForeColor = System.Drawing.Color.Teal;
            this.current_process_name_label.Location = new System.Drawing.Point(807, 231);
            this.current_process_name_label.Name = "current_process_name_label";
            this.current_process_name_label.Size = new System.Drawing.Size(52, 18);
            this.current_process_name_label.TabIndex = 47;
            this.current_process_name_label.Text = "Name:";
            this.current_process_name_label.Visible = false;
            // 
            // current_process_id_label
            // 
            this.current_process_id_label.AutoSize = true;
            this.current_process_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.current_process_id_label.ForeColor = System.Drawing.Color.Teal;
            this.current_process_id_label.Location = new System.Drawing.Point(695, 231);
            this.current_process_id_label.Name = "current_process_id_label";
            this.current_process_id_label.Size = new System.Drawing.Size(26, 18);
            this.current_process_id_label.TabIndex = 46;
            this.current_process_id_label.Text = "ID:";
            this.current_process_id_label.Visible = false;
            // 
            // info2_label
            // 
            this.info2_label.AutoSize = true;
            this.info2_label.BackColor = System.Drawing.Color.RoyalBlue;
            this.info2_label.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info2_label.ForeColor = System.Drawing.Color.PapayaWhip;
            this.info2_label.Location = new System.Drawing.Point(77, 128);
            this.info2_label.Name = "info2_label";
            this.info2_label.Size = new System.Drawing.Size(54, 25);
            this.info2_label.TabIndex = 45;
            this.info2_label.Text = "İnfo2";
            this.info2_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.info2_label.Visible = false;
            // 
            // current_process_name_value_label
            // 
            this.current_process_name_value_label.AutoSize = true;
            this.current_process_name_value_label.BackColor = System.Drawing.Color.Teal;
            this.current_process_name_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.current_process_name_value_label.ForeColor = System.Drawing.Color.White;
            this.current_process_name_value_label.Location = new System.Drawing.Point(810, 260);
            this.current_process_name_value_label.Name = "current_process_name_value_label";
            this.current_process_name_value_label.Size = new System.Drawing.Size(63, 24);
            this.current_process_name_value_label.TabIndex = 44;
            this.current_process_name_value_label.Text = "Excel";
            this.current_process_name_value_label.UseMnemonic = false;
            this.current_process_name_value_label.Visible = false;
            // 
            // current_process_label
            // 
            this.current_process_label.AutoSize = true;
            this.current_process_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.current_process_label.ForeColor = System.Drawing.Color.Teal;
            this.current_process_label.Location = new System.Drawing.Point(703, 196);
            this.current_process_label.Name = "current_process_label";
            this.current_process_label.Size = new System.Drawing.Size(150, 24);
            this.current_process_label.TabIndex = 43;
            this.current_process_label.Text = "Current Process:";
            this.current_process_label.Visible = false;
            // 
            // step_value_label
            // 
            this.step_value_label.AutoSize = true;
            this.step_value_label.BackColor = System.Drawing.Color.OrangeRed;
            this.step_value_label.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.step_value_label.ForeColor = System.Drawing.Color.White;
            this.step_value_label.Location = new System.Drawing.Point(827, 19);
            this.step_value_label.Name = "step_value_label";
            this.step_value_label.Size = new System.Drawing.Size(32, 36);
            this.step_value_label.TabIndex = 42;
            this.step_value_label.Text = "0";
            this.step_value_label.Visible = false;
            // 
            // step_label
            // 
            this.step_label.AutoSize = true;
            this.step_label.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.step_label.ForeColor = System.Drawing.Color.Brown;
            this.step_label.Location = new System.Drawing.Point(732, 16);
            this.step_label.Name = "step_label";
            this.step_label.Size = new System.Drawing.Size(89, 36);
            this.step_label.TabIndex = 41;
            this.step_label.Text = "STEP:";
            this.step_label.Visible = false;
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.BackColor = System.Drawing.Color.RoyalBlue;
            this.info_label.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_label.ForeColor = System.Drawing.Color.PapayaWhip;
            this.info_label.Location = new System.Drawing.Point(52, 82);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(79, 37);
            this.info_label.TabIndex = 40;
            this.info_label.Text = "İnfo1";
            this.info_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.info_label.Visible = false;
            // 
            // current_time_value_label
            // 
            this.current_time_value_label.AutoSize = true;
            this.current_time_value_label.BackColor = System.Drawing.Color.DodgerBlue;
            this.current_time_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.current_time_value_label.ForeColor = System.Drawing.Color.White;
            this.current_time_value_label.Location = new System.Drawing.Point(137, 29);
            this.current_time_value_label.Name = "current_time_value_label";
            this.current_time_value_label.Size = new System.Drawing.Size(21, 24);
            this.current_time_value_label.TabIndex = 39;
            this.current_time_value_label.Text = "0";
            this.current_time_value_label.UseMnemonic = false;
            this.current_time_value_label.Visible = false;
            // 
            // current_time_label
            // 
            this.current_time_label.AutoSize = true;
            this.current_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.current_time_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.current_time_label.Location = new System.Drawing.Point(6, 29);
            this.current_time_label.Name = "current_time_label";
            this.current_time_label.Size = new System.Drawing.Size(125, 24);
            this.current_time_label.TabIndex = 39;
            this.current_time_label.Text = "Current Time:";
            this.current_time_label.Visible = false;
            // 
            // program_runing_timer
            // 
            this.program_runing_timer.Enabled = true;
            this.program_runing_timer.Interval = 1000;
            this.program_runing_timer.Tick += new System.EventHandler(this.program_runing_timer_Tick);
            // 
            // proc_prog_indicated_value_1
            // 
            this.proc_prog_indicated_value_1.AutoSize = true;
            this.proc_prog_indicated_value_1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.proc_prog_indicated_value_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proc_prog_indicated_value_1.ForeColor = System.Drawing.Color.Red;
            this.proc_prog_indicated_value_1.Location = new System.Drawing.Point(569, 185);
            this.proc_prog_indicated_value_1.Name = "proc_prog_indicated_value_1";
            this.proc_prog_indicated_value_1.Size = new System.Drawing.Size(28, 24);
            this.proc_prog_indicated_value_1.TabIndex = 39;
            this.proc_prog_indicated_value_1.Text = "-2";
            this.proc_prog_indicated_value_1.Visible = false;
            // 
            // proc_prog_indicated_value_3
            // 
            this.proc_prog_indicated_value_3.AutoSize = true;
            this.proc_prog_indicated_value_3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.proc_prog_indicated_value_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proc_prog_indicated_value_3.ForeColor = System.Drawing.Color.Red;
            this.proc_prog_indicated_value_3.Location = new System.Drawing.Point(569, 270);
            this.proc_prog_indicated_value_3.Name = "proc_prog_indicated_value_3";
            this.proc_prog_indicated_value_3.Size = new System.Drawing.Size(28, 24);
            this.proc_prog_indicated_value_3.TabIndex = 40;
            this.proc_prog_indicated_value_3.Text = "-2";
            this.proc_prog_indicated_value_3.Visible = false;
            // 
            // proc_prog_indicated_value_2
            // 
            this.proc_prog_indicated_value_2.AutoSize = true;
            this.proc_prog_indicated_value_2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.proc_prog_indicated_value_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proc_prog_indicated_value_2.ForeColor = System.Drawing.Color.Red;
            this.proc_prog_indicated_value_2.Location = new System.Drawing.Point(569, 229);
            this.proc_prog_indicated_value_2.Name = "proc_prog_indicated_value_2";
            this.proc_prog_indicated_value_2.Size = new System.Drawing.Size(28, 24);
            this.proc_prog_indicated_value_2.TabIndex = 41;
            this.proc_prog_indicated_value_2.Text = "-2";
            this.proc_prog_indicated_value_2.Visible = false;
            // 
            // execute_button
            // 
            this.execute_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.execute_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.execute_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.execute_button.ForeColor = System.Drawing.Color.Ivory;
            this.execute_button.Image = ((System.Drawing.Image)(resources.GetObject("execute_button.Image")));
            this.execute_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.execute_button.Location = new System.Drawing.Point(436, 676);
            this.execute_button.Name = "execute_button";
            this.execute_button.Size = new System.Drawing.Size(137, 47);
            this.execute_button.TabIndex = 73;
            this.execute_button.Text = "START";
            this.execute_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.execute_button.UseVisualStyleBackColor = false;
            this.execute_button.Click += new System.EventHandler(this.execute_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.reset_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reset_button.ForeColor = System.Drawing.Color.Ivory;
            this.reset_button.Image = ((System.Drawing.Image)(resources.GetObject("reset_button.Image")));
            this.reset_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reset_button.Location = new System.Drawing.Point(714, 675);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(137, 47);
            this.reset_button.TabIndex = 74;
            this.reset_button.Text = "RESET";
            this.reset_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset_button.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1066, 732);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.execute_button);
            this.Controls.Add(this.proc_prog_indicated_value_2);
            this.Controls.Add(this.proc_prog_indicated_value_3);
            this.Controls.Add(this.proc_prog_indicated_value_1);
            this.Controls.Add(this.calculate_groupBox);
            this.Controls.Add(this.time_quantum_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proc_prog_3);
            this.Controls.Add(this.proc_prog_2);
            this.Controls.Add(this.proc_prog_1);
            this.Controls.Add(this.average_turn_around_time_value_label);
            this.Controls.Add(label24);
            this.Controls.Add(this.average_turn_around_time_label);
            this.Controls.Add(this.average_waiting_time_value_label);
            this.Controls.Add(this.average_waiting_time_label);
            this.Controls.Add(this.proc_tat_value_3);
            this.Controls.Add(this.proc_tat_value_2);
            this.Controls.Add(this.proc_tat_value_1);
            this.Controls.Add(this.proc_wt_value_3);
            this.Controls.Add(this.proc_wt_value_2);
            this.Controls.Add(this.proc_wt_value_1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.proc_prog_value_3);
            this.Controls.Add(this.proc_prog_value_2);
            this.Controls.Add(this.proc_prog_value_1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.proc_name_3);
            this.Controls.Add(this.proc_name_2);
            this.Controls.Add(this.proc_name_1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.proc_id_3);
            this.Controls.Add(this.proc_id_2);
            this.Controls.Add(this.proc_id_1);
            this.Controls.Add(this.processid_label);
            this.Controls.Add(title_form);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation Mode - Round Robin Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.calculate_groupBox.ResumeLayout(false);
            this.calculate_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label processid_label;
        private System.Windows.Forms.Label proc_id_1;
        private System.Windows.Forms.Label proc_id_2;
        private System.Windows.Forms.Label proc_id_3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label proc_name_1;
        private System.Windows.Forms.Label proc_name_2;
        private System.Windows.Forms.Label proc_name_3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label average_waiting_time_label;
        private System.Windows.Forms.Label average_turn_around_time_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label time_quantum_label;
        private System.Windows.Forms.GroupBox calculate_groupBox;
        private System.Windows.Forms.Label current_time_label;
        public System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Label current_process_label;
        private System.Windows.Forms.Label step_value_label;
        private System.Windows.Forms.Label step_label;
        public System.Windows.Forms.Label info2_label;
        public System.Windows.Forms.Label current_time_value_label;
        public System.Windows.Forms.Label current_process_name_value_label;
        public System.Windows.Forms.Timer program_runing_timer;
        public System.Windows.Forms.Label proc_prog_value_1;
        public System.Windows.Forms.Label proc_prog_value_2;
        public System.Windows.Forms.Label proc_prog_value_3;
        public System.Windows.Forms.ProgressBar proc_prog_1;
        public System.Windows.Forms.ProgressBar proc_prog_2;
        public System.Windows.Forms.ProgressBar proc_prog_3;
        public System.Windows.Forms.Label proc_prog_indicated_value_1;
        public System.Windows.Forms.Label proc_prog_indicated_value_3;
        public System.Windows.Forms.Label proc_prog_indicated_value_2;
        public System.Windows.Forms.Label current_process_id_value_label;
        private System.Windows.Forms.Label current_process_name_label;
        private System.Windows.Forms.Label current_process_id_label;
        public System.Windows.Forms.Label average_waiting_time_value_label;
        public System.Windows.Forms.Label average_turn_around_time_value_label;
        public System.Windows.Forms.Label proc_wt_value_1;
        public System.Windows.Forms.Label proc_wt_value_2;
        public System.Windows.Forms.Label proc_wt_value_3;
        public System.Windows.Forms.Label proc_tat_value_1;
        public System.Windows.Forms.Label proc_tat_value_2;
        public System.Windows.Forms.Label proc_tat_value_3;
        private System.Windows.Forms.Label ready_label;
        public System.Windows.Forms.Button execute_button;
        public System.Windows.Forms.Button reset_button;
    }
}


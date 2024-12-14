namespace RoundRobinScheduler_2000006890
{
    partial class interactive_form_giris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label title_form;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(interactive_form_giris));
            this.label12 = new System.Windows.Forms.Label();
            this.process_id_label = new System.Windows.Forms.Label();
            this.process_id_textbox = new System.Windows.Forms.TextBox();
            this.process_name_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.messagebox_yes_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.process_bursttime_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.time_quantum_label = new System.Windows.Forms.Label();
            this.time_quantum_numericUpDown = new System.Windows.Forms.NumericUpDown();
            title_form = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.process_bursttime_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_quantum_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // title_form
            // 
            title_form.AutoSize = true;
            title_form.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            title_form.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title_form.ForeColor = System.Drawing.Color.White;
            title_form.Location = new System.Drawing.Point(12, 9);
            title_form.Name = "title_form";
            title_form.Size = new System.Drawing.Size(429, 41);
            title_form.TabIndex = 3;
            title_form.Text = "ROUND ROBIN SCHEDULER";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Azure;
            this.label12.Location = new System.Drawing.Point(152, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Interactive Mode";
            // 
            // process_id_label
            // 
            this.process_id_label.AutoSize = true;
            this.process_id_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.process_id_label.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.process_id_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.process_id_label.Location = new System.Drawing.Point(102, 233);
            this.process_id_label.Name = "process_id_label";
            this.process_id_label.Size = new System.Drawing.Size(130, 30);
            this.process_id_label.TabIndex = 18;
            this.process_id_label.Text = "Process ID:";
            // 
            // process_id_textbox
            // 
            this.process_id_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.process_id_textbox.Location = new System.Drawing.Point(269, 233);
            this.process_id_textbox.Name = "process_id_textbox";
            this.process_id_textbox.Size = new System.Drawing.Size(120, 29);
            this.process_id_textbox.TabIndex = 2;
            // 
            // process_name_textbox
            // 
            this.process_name_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.process_name_textbox.Location = new System.Drawing.Point(269, 278);
            this.process_name_textbox.Name = "process_name_textbox";
            this.process_name_textbox.Size = new System.Drawing.Size(120, 29);
            this.process_name_textbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(63, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "Process Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "Process Burst Time:";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.title_label.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.title_label.Location = new System.Drawing.Point(115, 84);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(214, 36);
            this.title_label.TabIndex = 24;
            this.title_label.Text = "Add A Process";
            // 
            // messagebox_yes_button
            // 
            this.messagebox_yes_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.messagebox_yes_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.messagebox_yes_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.messagebox_yes_button.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.messagebox_yes_button.ForeColor = System.Drawing.SystemColors.Menu;
            this.messagebox_yes_button.Image = ((System.Drawing.Image)(resources.GetObject("messagebox_yes_button.Image")));
            this.messagebox_yes_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.messagebox_yes_button.Location = new System.Drawing.Point(331, 388);
            this.messagebox_yes_button.Name = "messagebox_yes_button";
            this.messagebox_yes_button.Size = new System.Drawing.Size(115, 45);
            this.messagebox_yes_button.TabIndex = 5;
            this.messagebox_yes_button.Text = "Add";
            this.messagebox_yes_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.messagebox_yes_button.UseVisualStyleBackColor = false;
            this.messagebox_yes_button.Click += new System.EventHandler(this.messagebox_yes_button_Click);
            this.messagebox_yes_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messagebox_yes_button_KeyDown);
            // 
            // close_button
            // 
            this.close_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.close_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.close_button.ForeColor = System.Drawing.SystemColors.Menu;
            this.close_button.Image = ((System.Drawing.Image)(resources.GetObject("close_button.Image")));
            this.close_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.close_button.Location = new System.Drawing.Point(205, 388);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(115, 45);
            this.close_button.TabIndex = 6;
            this.close_button.Text = "Close";
            this.close_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // process_bursttime_numericUpDown
            // 
            this.process_bursttime_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.process_bursttime_numericUpDown.Location = new System.Drawing.Point(269, 326);
            this.process_bursttime_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.process_bursttime_numericUpDown.Name = "process_bursttime_numericUpDown";
            this.process_bursttime_numericUpDown.Size = new System.Drawing.Size(120, 29);
            this.process_bursttime_numericUpDown.TabIndex = 4;
            this.process_bursttime_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // time_quantum_label
            // 
            this.time_quantum_label.AutoSize = true;
            this.time_quantum_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.time_quantum_label.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.time_quantum_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.time_quantum_label.Location = new System.Drawing.Point(80, 144);
            this.time_quantum_label.Name = "time_quantum_label";
            this.time_quantum_label.Size = new System.Drawing.Size(179, 30);
            this.time_quantum_label.TabIndex = 28;
            this.time_quantum_label.Text = "Time Quantum:";
            // 
            // time_quantum_numericUpDown
            // 
            this.time_quantum_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.time_quantum_numericUpDown.Location = new System.Drawing.Point(265, 145);
            this.time_quantum_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.time_quantum_numericUpDown.Name = "time_quantum_numericUpDown";
            this.time_quantum_numericUpDown.Size = new System.Drawing.Size(55, 29);
            this.time_quantum_numericUpDown.TabIndex = 1;
            this.time_quantum_numericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // interactive_form_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(458, 445);
            this.Controls.Add(this.time_quantum_numericUpDown);
            this.Controls.Add(this.time_quantum_label);
            this.Controls.Add(this.process_bursttime_numericUpDown);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.messagebox_yes_button);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.process_name_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.process_id_textbox);
            this.Controls.Add(this.process_id_label);
            this.Controls.Add(this.label12);
            this.Controls.Add(title_form);
            this.Name = "interactive_form_giris";
            this.Text = "interactive_form_giris";
            this.Load += new System.EventHandler(this.interactive_form_giris_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.interactive_form_giris_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.process_bursttime_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_quantum_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label process_id_label;
        private System.Windows.Forms.TextBox process_id_textbox;
        private System.Windows.Forms.TextBox process_name_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button messagebox_yes_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.NumericUpDown process_bursttime_numericUpDown;
        private System.Windows.Forms.Label time_quantum_label;
        private System.Windows.Forms.NumericUpDown time_quantum_numericUpDown;
        public System.Windows.Forms.Label title_label;
    }
}
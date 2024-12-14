namespace RoundRobinScheduler_2000006890
{
    partial class CustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            System.Windows.Forms.Label title_form;
            this.messagebox_yes_button = new System.Windows.Forms.Button();
            this.messagebox_question_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.messagebox_info_label = new System.Windows.Forms.Label();
            this.messagebox_no_button = new System.Windows.Forms.Button();
            this.messagebox_cancel_button = new System.Windows.Forms.Button();
            title_form = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // messagebox_yes_button
            // 
            this.messagebox_yes_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.messagebox_yes_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.messagebox_yes_button.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.messagebox_yes_button.ForeColor = System.Drawing.SystemColors.Menu;
            this.messagebox_yes_button.Image = ((System.Drawing.Image)(resources.GetObject("messagebox_yes_button.Image")));
            this.messagebox_yes_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.messagebox_yes_button.Location = new System.Drawing.Point(42, 185);
            this.messagebox_yes_button.Name = "messagebox_yes_button";
            this.messagebox_yes_button.Size = new System.Drawing.Size(115, 45);
            this.messagebox_yes_button.TabIndex = 0;
            this.messagebox_yes_button.Text = "Yes";
            this.messagebox_yes_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.messagebox_yes_button.UseVisualStyleBackColor = false;
            this.messagebox_yes_button.Click += new System.EventHandler(this.messagebox_yes_button_Click);
            // 
            // title_form
            // 
            title_form.AutoSize = true;
            title_form.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            title_form.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title_form.ForeColor = System.Drawing.Color.White;
            title_form.Location = new System.Drawing.Point(12, 43);
            title_form.Name = "title_form";
            title_form.Size = new System.Drawing.Size(362, 33);
            title_form.TabIndex = 2;
            title_form.Text = "ROUND ROBIN SCHEDULER";
            // 
            // messagebox_question_label
            // 
            this.messagebox_question_label.AutoSize = true;
            this.messagebox_question_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.messagebox_question_label.ForeColor = System.Drawing.Color.Azure;
            this.messagebox_question_label.Location = new System.Drawing.Point(16, 100);
            this.messagebox_question_label.Name = "messagebox_question_label";
            this.messagebox_question_label.Size = new System.Drawing.Size(209, 24);
            this.messagebox_question_label.TabIndex = 21;
            this.messagebox_question_label.Text = "Please Choose One..";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.messagebox_info_label);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 40);
            this.panel1.TabIndex = 22;
            // 
            // messagebox_info_label
            // 
            this.messagebox_info_label.AutoSize = true;
            this.messagebox_info_label.BackColor = System.Drawing.Color.DodgerBlue;
            this.messagebox_info_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.messagebox_info_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.messagebox_info_label.ForeColor = System.Drawing.Color.Azure;
            this.messagebox_info_label.Location = new System.Drawing.Point(3, 0);
            this.messagebox_info_label.Name = "messagebox_info_label";
            this.messagebox_info_label.Size = new System.Drawing.Size(46, 26);
            this.messagebox_info_label.TabIndex = 23;
            this.messagebox_info_label.Text = "Info";
            // 
            // messagebox_no_button
            // 
            this.messagebox_no_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.messagebox_no_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.messagebox_no_button.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.messagebox_no_button.ForeColor = System.Drawing.SystemColors.Menu;
            this.messagebox_no_button.Image = ((System.Drawing.Image)(resources.GetObject("messagebox_no_button.Image")));
            this.messagebox_no_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.messagebox_no_button.Location = new System.Drawing.Point(163, 185);
            this.messagebox_no_button.Name = "messagebox_no_button";
            this.messagebox_no_button.Size = new System.Drawing.Size(115, 45);
            this.messagebox_no_button.TabIndex = 23;
            this.messagebox_no_button.Text = "No";
            this.messagebox_no_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.messagebox_no_button.UseVisualStyleBackColor = false;
            this.messagebox_no_button.Click += new System.EventHandler(this.messagebox_no_button_Click);
            // 
            // messagebox_cancel_button
            // 
            this.messagebox_cancel_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.messagebox_cancel_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.messagebox_cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.messagebox_cancel_button.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.messagebox_cancel_button.ForeColor = System.Drawing.SystemColors.Menu;
            this.messagebox_cancel_button.Image = ((System.Drawing.Image)(resources.GetObject("messagebox_cancel_button.Image")));
            this.messagebox_cancel_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.messagebox_cancel_button.Location = new System.Drawing.Point(284, 185);
            this.messagebox_cancel_button.Name = "messagebox_cancel_button";
            this.messagebox_cancel_button.Size = new System.Drawing.Size(132, 45);
            this.messagebox_cancel_button.TabIndex = 24;
            this.messagebox_cancel_button.Text = "Cancel";
            this.messagebox_cancel_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.messagebox_cancel_button.UseVisualStyleBackColor = false;
            this.messagebox_cancel_button.Click += new System.EventHandler(this.messagebox_cancel_button_Click);
            // 
            // CustomMessageBox
            // 
            this.AcceptButton = this.messagebox_yes_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.CancelButton = this.messagebox_cancel_button;
            this.ClientSize = new System.Drawing.Size(423, 242);
            this.Controls.Add(title_form);
            this.Controls.Add(this.messagebox_question_label);
            this.Controls.Add(this.messagebox_cancel_button);
            this.Controls.Add(this.messagebox_no_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.messagebox_yes_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1500, 800);
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Info - Round Robin Scheduler";
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button messagebox_yes_button;
        private System.Windows.Forms.Label messagebox_question_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label messagebox_info_label;
        private System.Windows.Forms.Button messagebox_no_button;
        private System.Windows.Forms.Button messagebox_cancel_button;
    }
}
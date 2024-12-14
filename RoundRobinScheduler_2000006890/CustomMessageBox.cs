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
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }


        static CustomMessageBox newcustomMessageBox;
        static string ButtonID;
       


        Form1 form1_algorithm = (Form1)Application.OpenForms["Form1"]; // simulation form forms


        private void CustomMessageBox_Load(object sender, EventArgs e)
        {

        }

        public static string ShowBox(string txtMessage)
        {
            newcustomMessageBox = new CustomMessageBox();
            newcustomMessageBox.messagebox_info_label.Text = "Info";
            newcustomMessageBox.messagebox_question_label.Text = txtMessage;
            newcustomMessageBox.ShowDialog();
            return ButtonID;

        }
        

        public static string ShowBox(string _txtMessage,string _txtTitle="Info",string _messageBoxType="YesNoCancel")
        {
            

            newcustomMessageBox = new CustomMessageBox();
            newcustomMessageBox.messagebox_info_label.Text = _txtTitle;
            newcustomMessageBox.messagebox_question_label.Text = _txtMessage;

            if(_messageBoxType == "YesNoCancel")
            {
                newcustomMessageBox.messagebox_yes_button.Visible = true;
                newcustomMessageBox.messagebox_no_button.Visible = true;
                newcustomMessageBox.messagebox_cancel_button.Visible = true;

            } else 
            if(_messageBoxType == "Ok")
            {
                newcustomMessageBox.messagebox_yes_button.Visible = false;
                newcustomMessageBox.messagebox_no_button.Visible = true;
                newcustomMessageBox.messagebox_no_button.Text = "Exit";
                newcustomMessageBox.messagebox_cancel_button.Visible = true;
                newcustomMessageBox.messagebox_cancel_button.Image = new Bitmap("C:\\Users\\Enes KILIÇ\\Desktop\\icons\\good_or_tick_32x32.png");
                newcustomMessageBox.messagebox_cancel_button.Text = "Ok";
            }

            newcustomMessageBox.ShowDialog();



            return ButtonID;
        }

        private void messagebox_yes_button_Click(object sender, EventArgs e)
        {

            
            //form1_algorithm.timer_tick = 0;
            ButtonID = "1";
            newcustomMessageBox.Dispose();

        }

        private void messagebox_no_button_Click(object sender, EventArgs e)
        {
            //form1_algorithm.timer_tick = 0;
            ButtonID = "2";
            newcustomMessageBox.Dispose();
        }

        private void messagebox_cancel_button_Click(object sender, EventArgs e)
        {
           // form1_algorithm.timer_tick = 0;
            ButtonID = "3";
            newcustomMessageBox.Dispose();
        }
    }
}

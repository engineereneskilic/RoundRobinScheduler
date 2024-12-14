using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RoundRobinScheduler_2000006890
{


    public class roundrobinschedule
    {
        int wait = 0;
       // public static string main_program_model = ""; // Simulation Mode / Interactive Mode

        private string main_program_model;

        public roundrobinschedule(string main_program_model)
        {
            this.main_program_model = main_program_model;
        }


        // Method to find the waiting time (Bekleme süresini bulma yöntemi)
        // for all processes (tüm işlemler için)
        private void findWaitingTime(int[] processes,
                 int n, int[] bt, int[] wt, int quantum)
        {
            Form1 form1_algorithm = (Form1)Application.OpenForms["Form1"];
            interactive_form interactive_Form = (interactive_form)Application.OpenForms["interactive_form"];

           

            //int whilecounter = 0;
            //int whilecounter_temp = 0;
            // Make a copy of burst times bt[] to (patlama zamanlarının bir kopyasını bt[] ile yap)
            // store remaining burst times (kalan patlama sürelerini depola)
            int[] rem_bt = new int[n];

            for (int i = 0; i < n; i++)
                rem_bt[i] = bt[i];

            int t = 0; // Current time (geçerli zaman)
            int t_temp = 0;
            int rem_bt_temp=0;
            int increase_value = 0;
            //int total_burst_time_zero_counter = 0;

            //nextInstraction();

            if (main_program_model == "Simulation Mode")
            {

                form1_algorithm.info_label.Text = "I set the current time to 0 as the start..";
                form1_algorithm.info2_label.Text = "Here we go...";
            }
            else
            if (main_program_model == "Interactive Mode")
            {
                interactive_Form.info_label.Text = "I set the current time to 0 as the start..";
                interactive_Form.info2_label.Text = "Here we go...";
            }

                 do { } while (!ContinueStepMessageBoxShow());

            if (main_program_model == "Simulation Mode")
            {
                form1_algorithm.stepIncrement();
                form1_algorithm.info_label.Text = "I take the defined processes one by one.";
                form1_algorithm.info2_label.Text = "A total of " + n + " processes were defined";
            }
            else
            if (main_program_model == "Interactive Mode")
            {
                interactive_Form.stepIncrement();
                interactive_Form.info_label.Text = "I take the defined processes one by one.";
                interactive_Form.info2_label.Text = "A total of " + n + " processes were defined";
            }
                do { } while (!ContinueStepMessageBoxShow());

         

               
            /*

            do
            {
                MessageBox.Show("içerde");
                // firstone++;
                // nextInstraction();



                form1_algorithm.stepIncrement();
                form1_algorithm.info_label.Text = "fffff";
                form1_algorithm.info2_label.Text = "ccccc";
                //Console.WriteLine("Repeat instructions: "+firstone);


            } while (!ContinueStepMessageBoxShow());
            */
            /*

            do
            {
                form1_algorithm.stepIncrement();
                form1_algorithm.info_label.Text = "IKINCI";
                form1_algorithm.info2_label.Text = "IKINCIIIIIIIIIII";

            } while (!ContinueStepMessageBoxShow(firstone));


            do
            {
                form1_algorithm.stepIncrement();
                form1_algorithm.info_label.Text = "UCUNCU";
                form1_algorithm.info2_label.Text = "UCUNCU";

            } while (!ContinueStepMessageBoxShow(firstone));
            */





            //  nextInstraction();


            // Keep traversing processes in round (çapraz işlemleri burda tut)
            // robin manner until all of them are (hepsi bitene kadar robin şekilde)
            // not done. (bitmiş değil)
            // int first = 0;
            //ContinueStepMessageBoxShow(firstone);

            //do
            //{
                


                while (true)
                {
                    // whilecounter++;


                    bool done = true;

                    // Traverse all processes one by (Tüm süreçleri birer birer geç)
                    // one repeatedly (tekrar tekrar bir)
                    for (int i = 0; i < n; i++)
                    {
                    // first++;
                    if (main_program_model == "Simulation Mode")
                    {

                        form1_algorithm.current_process_id_value_label.Text = Convert.ToString(form1_algorithm.processes_id_arr[i]);
                        form1_algorithm.current_process_name_value_label.Text = Convert.ToString(form1_algorithm.processes_name_arr[i]);

                        //if (first==0) // ilk while girişinde sırası gelen prosses tanıtım ve değer atamaları
                        //{


                        ProcessBurstDecreaseNotVisible();
                        form1_algorithm.stepIncrement();
                        form1_algorithm.info_label.Text = "Procces id: " + form1_algorithm.processes_id_arr[i] + " | " + "Procces Name: " + form1_algorithm.processes_name_arr[i] + " | " + "Procces Burst Time: " + rem_bt[i];
                        form1_algorithm.info2_label.Text = "We continue with our process called " + form1_algorithm.processes_name_arr[i] + " number " + form1_algorithm.processes_id_arr[i] + " id..";
                    }
                    else
                    if (main_program_model == "Interactive Mode")
                    {
                      
                        interactive_Form.current_process_id_value_label.Text = Convert.ToString(interactive_Form.processes_id_arr[i]);
                        interactive_Form.current_process_name_value_label.Text = Convert.ToString(interactive_Form.processes_name_arr[i]);

                        //if (first==0) // ilk while girişinde sırası gelen prosses tanıtım ve değer atamaları
                        //{


                        ProcessBurstDecreaseNotVisible();
                        interactive_Form.stepIncrement();
                        interactive_Form.info_label.Text = "Procces id: " + interactive_Form.processes_id_arr[i] + " | " + "Procces Name: " + interactive_Form.processes_name_arr[i] + " | " + "Procces Burst Time: " + rem_bt[i];
                        interactive_Form.info2_label.Text = "We continue with our process called " + interactive_Form.processes_name_arr[i] + " number " + interactive_Form.processes_id_arr[i] + " id..";
                    }
                        do { } while (!ContinueStepMessageBoxShow());

                        // nextInstraction();

                        //do
                        //{


                            //}


                            // If burst time of a process (bir işlemin patlama zamanı ise)
                            // is greater than 0 then only (sadece 0'dan büyükse)
                            // need to process further (daha fazla işlememiz gerekiyor)
                            if (rem_bt[i] > 0)
                            {

                                if (main_program_model == "Simulation Mode")
                                {
                                    form1_algorithm.stepIncrement();
                                    form1_algorithm.info_label.Text = "Procces Burst Time: " + rem_bt[i] + " > " + "0";
                                    form1_algorithm.info2_label.Text = "Is the burst time value of the process named " + form1_algorithm.processes_name_arr[i] + " greater than zero? Answer is: Yes";
                                }
                                else
                                if (main_program_model == "Interactive Mode")
                                {
                                    interactive_Form.stepIncrement();
                                    interactive_Form.info_label.Text = "Procces Burst Time: " + rem_bt[i] + " > " + "0";
                                    interactive_Form.info2_label.Text = "Is the burst time value of the process named " + interactive_Form.processes_name_arr[i] + " greater than zero? Answer is: Yes";
                                }

                                do { } while (!ContinueStepMessageBoxShow());

                                //MessageBox.Show("Shall I go to the next step?", "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                                //for (int k = 0; k <= 5; k++)
                                //{
                                //    Console.WriteLine(k);
                                //    form1_algorithm.standby_time_value_label.Text = Convert.ToString(k);
                                //    Thread.Sleep(1000);
                                //}
                                //MessageBox.Show("Shall I go to the next step?", "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                                // There is a pending process (bekleyen bir süreç var)
                                done = false;

                               // do
                                //{



                                    if (rem_bt[i] > quantum) // ilgili prossesin burs time'ı sınırdan büyükse
                                    {

                                            if (main_program_model == "Simulation Mode")
                                            {
                                                form1_algorithm.stepIncrement();
                                                form1_algorithm.info_label.Text = "Procces Burst Time: " + rem_bt[i] + " > " + quantum;
                                                form1_algorithm.info2_label.Text = "Is the burst time value of the process named " + form1_algorithm.processes_name_arr[i] + " greater than Quantum(Value: " + Convert.ToString(quantum) + ")? Answer is: Yes";
                                            }
                                            else
                                                if (main_program_model == "Interactive Mode")
                                            {
                                                interactive_Form.stepIncrement();
                                                interactive_Form.info_label.Text = "Procces Burst Time: " + rem_bt[i] + " > " + quantum;
                                                interactive_Form.info2_label.Text = "Is the burst time value of the process named " + interactive_Form.processes_name_arr[i] + " greater than Quantum(Value: " + Convert.ToString(quantum) + ")? Answer is: Yes";
                                            }

                                            if (main_program_model == "Simulation Mode")
                                            {

                                            }
                                            else
                                               if (main_program_model == "Interactive Mode")
                                            {

                                            }



                                       

                                        do { } while (!ContinueStepMessageBoxShow());
                                        /**/


                                        // MessageBox.Show("Shall I go to the next step?", "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                                       // do
                                        //{





                                            // Increase the value of t i.e. (t değerini arttır)
                                            // shows how much time a process (bir işlemin ne kadar zaman aldığını gösterir)
                                            // has been processed (işlendi)
                                            t_temp = t;
                                            t += quantum;


                                            if (main_program_model == "Simulation Mode")
                                            {
                                                form1_algorithm.current_time_value_label.Text = Convert.ToString(t);
                                                form1_algorithm.stepIncrement();
                                                form1_algorithm.info_label.Text = "New Current Time: " + t + " = " + t_temp + " + " + quantum;
                                                form1_algorithm.info2_label.Text = "Increase the current time by the number of quantums.";
                                            }
                                            else
                                               if (main_program_model == "Interactive Mode")
                                            {
                                                interactive_Form.current_time_value_label.Text = Convert.ToString(t);
                                                interactive_Form.stepIncrement();
                                                interactive_Form.info_label.Text = "New Current Time: " + t + " = " + t_temp + " + " + quantum;
                                                interactive_Form.info2_label.Text = "Increase the current time by the number of quantums.";
                                            }


                                            
                                            do { } while (!ContinueStepMessageBoxShow());

                                           // do
                                            //{


                                                // Decrease the burst_time of (patlama zamanı değerini azalt)
                                                // current process by quantum (kuantuma göre geçerli süreç)
                                                rem_bt_temp = rem_bt[i];
                                                rem_bt[i] -= quantum; //buraya temp
                                                increase_value = quantum;
                                                
                                                  
                                                ProcessBurstDecrease(rem_bt[i], i, increase_value);


                                                if (main_program_model == "Simulation Mode")
                                                {
                                                    form1_algorithm.stepIncrement();
                                                    form1_algorithm.info_label.Text = "New Current Process Burst Time: " + rem_bt[i] + " = " + rem_bt_temp + " - " + quantum;
                                                    form1_algorithm.info2_label.Text = "We reduce the current burst time of the transaction by the quantum value.";
                                                }
                                                else
                                               if (main_program_model == "Interactive Mode")
                                                {
                                                    interactive_Form.stepIncrement();
                                                    interactive_Form.info_label.Text = "New Current Process Burst Time: " + rem_bt[i] + " = " + rem_bt_temp + " - " + quantum;
                                                    interactive_Form.info2_label.Text = "We reduce the current burst time of the transaction by the quantum value.";
                                                }    

                                            


                                                

                                                do { } while (!ContinueStepMessageBoxShow());

                                              // do (!ContinueStepMessageBoxShow())



                                                //form1_algorithm.stepIncrement();
                                                //form1_algorithm.info_label.Text = "Current Tİme(t): " + Convert.ToString(t) + " |  Current Burst Time: "+rem_bt[i] +" | "+"Current Process ID: " + form1_algorithm.processes_id_arr[i] + " | " + "Current Process Name: " + form1_algorithm.processes_name_arr[i];
                                                //form1_algorithm.info2_label.Text = "At the " + t + "th time, the burst time of the " + form1_algorithm.processes_name_arr[i] + " process at the current time is " + rem_bt[i];


                                                //form1_algorithm.current_process_name_value_label.Text = Convert.ToString(0);
                                                // MessageBox.Show("Shall I go to the next step?", "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                                           // } while (!ContinueStepMessageBoxShow());
                                       //} while (!ContinueStepMessageBoxShow());
                                    }

                                    // If burst time is smaller than (patlatma süresi şundan küçükse)
                                    // or equal to quantum. Last cycle (veya kuantuma eşittir yani son döngü bu işlem için)
                                    // for this process
                                    else
                                    {

                                        if (main_program_model == "Simulation Mode")
                                        {
                                            form1_algorithm.stepIncrement();
                                            form1_algorithm.info_label.Text = "Procces Burst Time: " + rem_bt[i] + " < " + quantum;
                                            form1_algorithm.info2_label.Text = "Is the burst time value of the process named " + form1_algorithm.processes_name_arr[i] + " greater than Quantum(Value: " + Convert.ToString(quantum) + ")? Answer is: NO";
                                        }
                                        else
                                          if (main_program_model == "Interactive Mode")
                                        {
                                            interactive_Form.stepIncrement();
                                            interactive_Form.info_label.Text = "Procces Burst Time: " + rem_bt[i] + " < " + quantum;
                                            interactive_Form.info2_label.Text = "Is the burst time value of the process named " + interactive_Form.processes_name_arr[i] + " greater than Quantum(Value: " + Convert.ToString(quantum) + ")? Answer is: NO";
                                        }




                                       

                                        do { } while (!ContinueStepMessageBoxShow());

                                        /**/

                                        //do
                                        //{


                                            // Increase the value of t i.e. (t değerini arttır, yani)
                                            // shows how much time a process (bir işlemin ne kadar zaman aldığını gösterir)
                                            // has been processed (işlendiği)
                                            t_temp = t;
                                            t = t + rem_bt[i];

                                            if (main_program_model == "Simulation Mode")
                                            {
                                                form1_algorithm.current_time_value_label.Text = Convert.ToString(t);
                                            }
                                            else if (main_program_model == "Interactive Mode")
                                            {
                                                interactive_Form.current_time_value_label.Text = Convert.ToString(t);
                                            }

                                            increase_value = rem_bt[i];
                                            ProcessBurstDecrease(rem_bt[i], i, increase_value);

                                            if (main_program_model == "Simulation Mode")
                                            {
                                                form1_algorithm.stepIncrement();
                                                form1_algorithm.info_label.Text = t + "=" + t_temp + "+" + rem_bt[i];
                                                form1_algorithm.info2_label.Text = "The time elapses as much as the current burst time value of the process..";
                                            }
                                            else if (main_program_model == "Interactive Mode")
                                            { 
                                                interactive_Form.stepIncrement();
                                                interactive_Form.info_label.Text = t + "=" + t_temp + "+" + rem_bt[i];
                                                interactive_Form.info2_label.Text = "The time elapses as much as the current burst time value of the process..";
                                            }

                                            do { } while (!ContinueStepMessageBoxShow());

                                            //do
                                            //{





                                                // Waiting time is current (güncel bekleme süresi - bekliyor)
                                                // time minus time used by (eksi tarafından kullanılan zaman)
                                                // this process (bu süreç)
                                                wt[i] = t - bt[i];

                                            if (main_program_model == "Simulation Mode")
                                            {
                                                form1_algorithm.stepIncrement();
                                                form1_algorithm.info_label.Text = "Current Process Waiting Time: " + wt[i] + " = " + t + " - " + bt[i];
                                                form1_algorithm.info2_label.Text = "For the instantaneous total dwell time (wt) for the current process, we subtract the initial burst time from \n the current time (end - t)..";
                                            } else
                                            if(main_program_model == "Interactive Mode")
                                            {
                                                interactive_Form.stepIncrement();
                                                interactive_Form.info_label.Text = "Current Process Waiting Time: " + wt[i] + " = " + t + " - " + bt[i];
                                                interactive_Form.info2_label.Text = "For the instantaneous total dwell time (wt) for the current process, we subtract the initial burst time from \n the current time (end - t)..";
                                            }
                                                do { } while (!ContinueStepMessageBoxShow());
                                                /**/

                                               // do
                                                //{



                                                    // As the process gets fully (Süreç tam olarak ilerledikçe)
                                                    // executed make its remaining (yürütüldü kalanını yap)
                                                    // burst time = 0 
                                                    rem_bt[i] = 0;
                                                    increase_value = rem_bt[i];
                                                    ProcessBurstDecrease(rem_bt[i], i, increase_value);
                                            if (main_program_model == "Simulation Mode")
                                            {

                                                form1_algorithm.stepIncrement();
                                                form1_algorithm.info_label.Text = "Process completed" + " | " + " Current process burst time is : " + rem_bt[i];
                                                form1_algorithm.info2_label.Text = form1_algorithm.processes_name_arr[i] + " process is completed";
                                                ProcessBurstDecreaseNotVisible();
                                            }else
                                            if(main_program_model == "Interactive Mode")
                                            {
                                                interactive_Form.stepIncrement();
                                                interactive_Form.info_label.Text = "Process completed" + " | " + " Current process burst time is : " + rem_bt[i];
                                                interactive_Form.info2_label.Text = interactive_Form.processes_name_arr[i] + " process is completed";
                                                ProcessBurstDecreaseNotVisible();
                            }
                                                    do { } while (!ContinueStepMessageBoxShow());
                                               // } while (!ContinueStepMessageBoxShow());

                                            //} while (!ContinueStepMessageBoxShow());

                                        //} while (!ContinueStepMessageBoxShow());


                                    }
                                //} while (!ContinueStepMessageBoxShow());

                            }
                            else
                            {
                                 if (main_program_model == "Simulation Mode")
                                 {
                                    form1_algorithm.stepIncrement();
                                    form1_algorithm.info_label.Text = "The burst time of our " + rem_bt[i] + " process is not greater than zero.";
                                    form1_algorithm.info2_label.Text = "In other words, our process has been successfully run and finished.";
                                    ProcessBurstDecreaseNotVisible();

                                 }
                                 else
                                 if(main_program_model == "Interactive Mode")
                                 {
                                    interactive_Form.stepIncrement();
                                    interactive_Form.info_label.Text = "The burst time of our " + rem_bt[i] + " process is not greater than zero.";
                                    interactive_Form.info2_label.Text = "In other words, our process has been successfully run and finished.";
                                    ProcessBurstDecreaseNotVisible();
                                }

                       


                                do
                                {

                                    /*
                                    for (int k = 0; k < n; k++)
                                    {
                                        
                                        if (rem_bt[k] == 0) total_burst_time_zero_counter++;
                                    }

                                    if (total_burst_time_zero_counter == n) done = true;break;
                                    */
                                } while (!ContinueStepMessageBoxShow());


                            }
                        //} while (!ContinueStepMessageBoxShow());
                    }

                    // If all processes are done (tüm süreçler yani herşey bittiüğünde bırak)
                    if (done == true)
                    {

                        if (main_program_model == "Simulation Mode")
                        {
                            form1_algorithm.current_process_id_value_label.Text = "N/A";
                            form1_algorithm.current_process_name_value_label.Text = "N/A";
                            ProcessBurstDecreaseNotVisible();

                            form1_algorithm.info_label.Text = "All done..";
                            form1_algorithm.info2_label.Text = "All processes have been completed..";

                        }
                        else
                       if (main_program_model == "Interactive Mode")
                        {
                            interactive_Form.current_process_id_value_label.Text = "N/A";
                            interactive_Form.current_process_name_value_label.Text = "N/A";
                            ProcessBurstDecreaseNotVisible();

                            interactive_Form.info_label.Text = "All done..";
                            interactive_Form.info2_label.Text = "All processes have been completed..";
                        }




                        


                        do { } while (!ContinueStepMessageBoxShow());


                        break;
                    }
                }

            //} while (!ContinueStepMessageBoxShow());
        }

        // Method to calculate turn around time (geri dönüş süresini hesapla)
         void findTurnAroundTime(int[] processes,
                   int n, int[] bt, int[] wt, int[] tat)
        {
            
            Form1 form1_algorithm = (Form1)Application.OpenForms["Form1"];
            interactive_form interactive_Form = (interactive_form)Application.OpenForms["interactive_form"];


            if (main_program_model == "Simulation Mode")
            {

                form1_algorithm.current_process_id_value_label.Text = "N/A";
                form1_algorithm.current_process_name_value_label.Text = "N/A";

                form1_algorithm.stepIncrement();
                form1_algorithm.info_label.Text = "Calculating Turnaround Times";
                form1_algorithm.info2_label.Text = "Now we calculate the total turnaround times of all processes one by one..";
            }
            else
             if (main_program_model == "Interactive Mode")
            {
                interactive_Form.current_process_id_value_label.Text = "N/A";
                interactive_Form.current_process_name_value_label.Text = "N/A";

                interactive_Form.stepIncrement();
                interactive_Form.info_label.Text = "Calculating Turnaround Times";
                interactive_Form.info2_label.Text = "Now we calculate the total turnaround times of all processes one by one..";
            }

            if (main_program_model == "Simulation Mode")
            {


            }
            else
             if (main_program_model == "Interactive Mode")
            {

            }




            

            do { } while (!ContinueStepMessageBoxShow());

            //do
            //{


                // calculating turnaround time by adding (ekleyerek geri dönüş süresini hesaplıyoruz)
                // bt[i] + wt[i]
                for (int i = 0; i < n; i++)
                {




                    tat[i] = bt[i] + wt[i];


                    if (main_program_model == "Simulation Mode")
                    {
                        form1_algorithm.current_process_id_value_label.Text = Convert.ToString(form1_algorithm.processes_id_arr[i]);
                        form1_algorithm.current_process_name_value_label.Text = Convert.ToString(form1_algorithm.processes_name_arr[i]);

                        form1_algorithm.stepIncrement();
                        form1_algorithm.info_label.Text = tat[i] + "=" + bt[i] + "+" + wt[i];
                        form1_algorithm.info2_label.Text = "We find the total turnaround time by adding the burst times and waiting times of the processes.";

                    }
                    else
                    if (main_program_model == "Interactive Mode")
                    {
                        interactive_Form.current_process_id_value_label.Text = Convert.ToString(interactive_Form.processes_id_arr[i]);
                        interactive_Form.current_process_name_value_label.Text = Convert.ToString(interactive_Form.processes_name_arr[i]);

                        interactive_Form.stepIncrement();
                        interactive_Form.info_label.Text = tat[i] + "=" + bt[i] + "+" + wt[i];
                        interactive_Form.info2_label.Text = "We find the total turnaround time by adding the burst times and waiting times of the processes.";
                    }




                    


                    do { } while (!ContinueStepMessageBoxShow());



                }
            //} while (!ContinueStepMessageBoxShow());
        }

        // Method to calculate average time () (ortalama süreyi hesaplama yöntemi)
        public void roundRobinSchedule(int[] processes, int n,
                                 int[] bt, int quantum)
        {
           
            Form1 form1_algorithm = (Form1)Application.OpenForms["Form1"];
            interactive_form interactive_Form = (interactive_form)Application.OpenForms["interactive_form"];
            int[] wt = new int[n];
            int[] tat = new int[n];
            int total_wt = 0, total_tat = 0;

            // MessageBox.Show

            // Function to find waiting time of (Bekleme süresini bulan fonksiyon)
            // all processes (tüm işlemler)
            findWaitingTime(processes, n, bt, wt, quantum);

            // Function to find turn around time (geri dönüş süresini bulma işlevi)
            // for all processes (tüm süreçler için)
            findTurnAroundTime(processes, n, bt, wt, tat);

            // Display processes along with (İşlemleri birlikte görüntüle)
            // all details
            Console.WriteLine("Processes ID " + "Process Name" + " Burst time " +
                        " Waiting time " + " Turn around time");


            if (main_program_model == "Simulation Mode")
            {
                form1_algorithm.stepIncrement();
                form1_algorithm.current_process_id_value_label.Text = "N/A";
                form1_algorithm.current_process_name_value_label.Text = "N/A";

                form1_algorithm.info_label.Text = "Total Wait Time and Total Araund Time Average Calculation";
                form1_algorithm.info2_label.Text = "Summing the waiting and average times of the calculated processes..";
            }
            else
            if (main_program_model == "Interactive Mode")
            {
                interactive_Form.stepIncrement();
                interactive_Form.current_process_id_value_label.Text = "N/A";
                interactive_Form.current_process_name_value_label.Text = "N/A";

                interactive_Form.info_label.Text = "Total Wait Time and Total Araund Time Average Calculation";
                interactive_Form.info2_label.Text = "Summing the waiting and average times of the calculated processes..";
            }
                do { } while (!ContinueStepMessageBoxShow());

           // do
            //{



                // Calculate total waiting time and total turn (toplam bekleme süresini ve toplam dönüş)
                // around time
                int total_wt_temp = 0;
                int total_tat_temp = 0;
                for (int i = 0; i < n; i++)
                {


                    total_wt_temp = total_wt;
                    total_wt = total_wt + wt[i];


                    if (main_program_model == "Simulation Mode")
                    {
                        form1_algorithm.current_process_id_value_label.Text = Convert.ToString(form1_algorithm.processes_id_arr[i]);
                        form1_algorithm.current_process_name_value_label.Text = Convert.ToString(form1_algorithm.processes_name_arr[i]);


                        form1_algorithm.info_label.Text = total_wt + "=" + total_wt_temp + "+" + wt[i];
                        form1_algorithm.info2_label.Text = "We collect the waiting times of individual processes to find the total waiting times of the processes..";
                    }
                    else
                    if (main_program_model == "Interactive Mode")
                    {
                        interactive_Form.current_process_id_value_label.Text = Convert.ToString(interactive_Form.processes_id_arr[i]);
                        interactive_Form.current_process_name_value_label.Text = Convert.ToString(interactive_Form.processes_name_arr[i]);


                        interactive_Form.info_label.Text = total_wt + "=" + total_wt_temp + "+" + wt[i];
                        interactive_Form.info2_label.Text = "We collect the waiting times of individual processes to find the total waiting times of the processes..";
                }
                    do { } while (!ContinueStepMessageBoxShow());

                   // do
                    //{


                        total_tat_temp = total_tat;
                        total_tat = total_tat + tat[i];

                if (main_program_model == "Simulation Mode")
                {

                    form1_algorithm.info_label.Text = total_tat + "=" + total_tat_temp + "+" + tat[i];
                    form1_algorithm.info2_label.Text = "We collect the turnaround times of the processes one by one to calculate the total turnaround time of the processes.";
                }
                else
                if (main_program_model == "Interactive Mode")
                {
                    interactive_Form.info_label.Text = total_tat + "=" + total_tat_temp + "+" + tat[i];
                    interactive_Form.info2_label.Text = "We collect the turnaround times of the processes one by one to calculate the total turnaround time of the processes.";
                }

                        do { } while (!ContinueStepMessageBoxShow());

                // do
                // {

                if (main_program_model == "Simulation Mode")
                {
                    switch (i + 1)
                    {
                        case 1:
                            form1_algorithm.proc_wt_value_1.Text = Convert.ToString(wt[i]);
                            form1_algorithm.proc_tat_value_1.Text = Convert.ToString(tat[i]);
                            break;
                        case 2:
                            form1_algorithm.proc_wt_value_2.Text = Convert.ToString(wt[i]);
                            form1_algorithm.proc_tat_value_2.Text = Convert.ToString(tat[i]);
                            break;
                        case 3:
                            form1_algorithm.proc_wt_value_3.Text = Convert.ToString(wt[i]);
                            form1_algorithm.proc_tat_value_3.Text = Convert.ToString(tat[i]);
                            break;

                        default:
                            Console.WriteLine("Hata hiçbir wt ve tat değeri atanmadı !");
                            break;

                    }

                }
                else
                if (main_program_model == "Interactive Mode")
                {

                    foreach (Control c in interactive_Form.processes_panel.Controls)
                    {
                        if (c is Label)
                        {
                            if (((Label)c).Name == ("proc_wt_value_" + Convert.ToString(i + 1)))
                            {
                                ((Label)c).Text = Convert.ToString(wt[i]);
                            }
                        }
                    }
                    foreach (Control c in interactive_Form.processes_panel.Controls)
                    {
                        if (c is Label)
                        {
                            if (((Label)c).Name == ("proc_tat_value_" + Convert.ToString(i + 1)))
                            {
                                ((Label)c).Text = Convert.ToString(tat[i]);
                            }
                        }
                    }

                }
                if (main_program_model == "Simulation Mode")
                {
                    Console.WriteLine(" " + (form1_algorithm.processes_id_arr[i]) + "\t" + form1_algorithm.processes_name_arr[i] + "\t\t" + bt[i]
                                     + "\t " + wt[i] + "\t\t " + tat[i]);
                }
                else
                if (main_program_model == "Interactive Mode")
                {
                    Console.WriteLine(" " + (interactive_Form.processes_id_arr[i]) + "\t" + interactive_Form.processes_name_arr[i] + "\t\t" + bt[i]
                                     + "\t " + wt[i] + "\t\t " + tat[i]);
                }
                    //  } while (!ContinueStepMessageBoxShow());

                    // } while (!ContinueStepMessageBoxShow());


                }

            if (main_program_model == "Simulation Mode")
            {
                form1_algorithm.info_label.Text = "Average waiting time of all processes:" + Convert.ToString(((float)total_wt / (float)n));
                form1_algorithm.info2_label.Text = "We calculated the average waiting time of all processes";

                form1_algorithm.average_waiting_time_value_label.Text = Convert.ToString(((float)total_wt / (float)n));
            }
            else
             if (main_program_model == "Interactive Mode")
            {
                interactive_Form.info_label.Text = "Average waiting time of all processes:" + Convert.ToString(((float)total_wt / (float)n));
                interactive_Form.info2_label.Text = "We calculated the average waiting time of all processes";

                interactive_Form.average_waiting_time_value_label.Text = Convert.ToString(((float)total_wt / (float)n));
            }


                //form1_algorithm.average_waiting_time_value_label.ForeColor = Color.LawnGreen;

                do { } while (!ContinueStepMessageBoxShow());

            //do
            //{
            if (main_program_model == "Simulation Mode")
            {
                form1_algorithm.info_label.Text = "Average turnaround time of all processes:" + Convert.ToString(((float)total_tat / (float)n));
                form1_algorithm.info2_label.Text = "We calculated the turnaround time of all processes";
                form1_algorithm.average_turn_around_time_value_label.Text = Convert.ToString(((float)total_tat / (float)n));
            }
            else
             if (main_program_model == "Interactive Mode")
            {
                interactive_Form.info_label.Text = "Average turnaround time of all processes:" + Convert.ToString(((float)total_tat / (float)n));
                interactive_Form.info2_label.Text = "We calculated the turnaround time of all processes";
                interactive_Form.average_turn_around_time_value_label.Text = Convert.ToString(((float)total_tat / (float)n));
            }

                   
                    //form1_algorithm.average_waiting_time_value_label.ForeColor = Color.LawnGreen;

                    do { } while (!ContinueStepMessageBoxShow());

                   // do
                   // {



                        Console.WriteLine("Average waiting time = " +
                                        (float)total_wt / (float)n);
                        Console.Write("Average turn around time = " +
                                        (float)total_tat / (float)n);
            if (main_program_model == "Simulation Mode")
            {

           
                        form1_algorithm.info_label.Text = "Everything Complete";
                        form1_algorithm.info2_label.Text = "Round Robin algorithm successfully implemented..";

            }
            else
             if (main_program_model == "Interactive Mode")
            {
                interactive_Form.info_label.Text = "Everything Complete";
                interactive_Form.info2_label.Text = "Round Robin algorithm successfully implemented..";
            }

            if (main_program_model == "Simulation Mode")
            {
                string waitingdialogResult = CustomMessageBox.ShowBox("Done..", "Info", "Ok");
                form1_algorithm.timer_tick = 0;
            }
            else
             if (main_program_model == "Interactive Mode")
            {
                string waitingdialogResult = CustomMessageBox.ShowBox("Done..", "Info", "Ok");
                interactive_Form.timer_tick = 0;
            }

                
            

            // do { } while (!ContinueStepMessageBoxShow());
            //} while (!ContinueStepMessageBoxShow());

            //} while (!ContinueStepMessageBoxShow());

            //} while (!ContinueStepMessageBoxShow());


        }

        static bool continue_step = true;
        static bool cancel_button = false;
      

        public  bool ContinueStepMessageBoxShow()
        {

            Form1 form1_algorithm = (Form1)Application.OpenForms["Form1"];
            interactive_form interactive_Form = (interactive_form)Application.OpenForms["interactive_form"];

            if (cancel_button)
            {
                if (main_program_model == "Simulation Mode")
                {
                    string waitingdialogResult = CustomMessageBox.ShowBox("Click the button to continue..", "Info", "Ok");
                    if (waitingdialogResult.Equals("3")) //cancel
                    {
                        form1_algorithm.timer_tick = 0;
                        //devam
                    }
                    if (waitingdialogResult.Equals("2")) //no
                    {
                        Application.Exit();
                    }
                }
                else
                    if (main_program_model == "Interactive Mode")
                {
                    string waitingdialogResult = CustomMessageBox.ShowBox("Click the button to continue..", "Info", "Ok");
                    if (waitingdialogResult.Equals("3")) //cancel
                    {
                        //interactive_Form.timer_tick = 0;
                        //devam
                    }
                    if (waitingdialogResult.Equals("2")) //no
                    {
                        Application.Exit();
                    }
                }
                   

                    if (main_program_model == "Simulation Mode")
                    {

                        //if (form1_algorithm.timer_tick > 10)
                        //{

                            string nextStepdialogResult = CustomMessageBox.ShowBox("Shall I go to the next step?", "Info", "YesNoCancel");
                            if (nextStepdialogResult.Equals("1"))
                            {
                                form1_algorithm.timer_tick = 1;
                                continue_step = true;
                            }
                            else if (nextStepdialogResult.Equals("2"))
                            {
                                form1_algorithm.timer_tick = 1;
                                continue_step = false;

                            }
                            else if (nextStepdialogResult.Equals("3"))
                            {
                                //MessageBox.Show("Burada");
                                form1_algorithm.timer_tick = 1;
                                cancel_button = true;
                                continue_step = false;
                                //  do { } while (!ContinueStepMessageBoxShow());
                            }
                        //}
                    }
                    else
                    if (main_program_model == "Interactive Mode")
                    {
                        //if (interactive_Form.timer_tick > 10)
                        //{

                            string nextStepdialogResult = CustomMessageBox.ShowBox("Shall I go to the next step?", "Info", "YesNoCancel");
                            if (nextStepdialogResult.Equals("1"))
                            {
                                interactive_Form.timer_tick = 1;
                                continue_step = true;
                            }
                            else if (nextStepdialogResult.Equals("2"))
                            {
                                interactive_Form.timer_tick = 1;
                                continue_step = false;

                            }
                            else if (nextStepdialogResult.Equals("3"))
                            {
                                //MessageBox.Show("Burada");
                                interactive_Form.timer_tick = 1;
                                cancel_button = true;
                                continue_step = false;
                                //  do { } while (!ContinueStepMessageBoxShow());
                            }
                        //}
                    }

                }
            else
            {
                if (main_program_model == "Simulation Mode") 
                {
                    string nextStepdialogResult = CustomMessageBox.ShowBox("Shall I go to the next step?", "Info", "YesNoCancel");
                    if (nextStepdialogResult.Equals("1"))
                    {
                        form1_algorithm.timer_tick = 0;
                        continue_step = true;
                    }
                    else if (nextStepdialogResult.Equals("2"))
                    {
                        form1_algorithm.timer_tick = 0;
                        continue_step = false;

                    }
                    else if (nextStepdialogResult.Equals("3"))
                    {
                        if (main_program_model == "Simulation Mode") { form1_algorithm.timer_tick = 1; } else if (main_program_model == "Interactive Mode") { interactive_Form.timer_tick = 1; }
                        cancel_button = true;
                        continue_step = false;
                        do { } while (!ContinueStepMessageBoxShow());
                    }
                }
                else if (main_program_model == "Interactive Mode") 
                {
                    string nextStepdialogResult = CustomMessageBox.ShowBox("Shall I go to the next step?", "Info", "YesNoCancel");
                    if (nextStepdialogResult.Equals("1"))
                    {
                        interactive_Form.timer_tick = 0;
                        continue_step = true;
                    }
                    else if (nextStepdialogResult.Equals("2"))
                    {
                        interactive_Form.timer_tick = 0;
                        continue_step = false;

                    }
                    else if (nextStepdialogResult.Equals("3"))
                    {
                        if (main_program_model == "Simulation Mode") { form1_algorithm.timer_tick = 1; } else if (main_program_model == "Interactive Mode") { interactive_Form.timer_tick = 1; }
                        cancel_button = true;
                        continue_step = false;
                        do { } while (!ContinueStepMessageBoxShow());
                    }
                }

                
            }


            /*
            DialogResult dialogResult = MessageBox.Show("Shall I go to the next step?", "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                continue_step = true;
            }
            else
             if (dialogResult == DialogResult.No)
            {

                continue_step = false;
                //form1_algorithm.pause_play_button.Text = "CONTINUE";
                //DialogResult dialogResult2 = MessageBox.Show("Bekleniyor..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            else
             if (dialogResult == DialogResult.Cancel)
            {
                continue_step = false; 
               // form1_algorithm.pause_play_button.Text = "CONTINUE";
            }

            */


            return continue_step;
        }


        /*

        public static void nextInstraction()
        {

            Form1 form1_algorithm = (Form1)Application.OpenForms["Form1"];
            interactive_form interactive_Form = (interactive_form)Application.OpenForms["interactive_form"];

            for (int k = 0; k <= 5; k++)
            {
                Console.WriteLine(k);
                form1_algorithm.current_process_name_value_label.Text = Convert.ToString(k);
                Thread.Sleep(1000);
            }

            /*
            Form1 form1_algorithm = (Form1)Application.OpenForms["Form1"];

            form1_algorithm.program_runing_timer.Start();

            form1_algorithm.program_runing_timer.Stop();
            form1_algorithm.standby_time_value_label.Text = Convert.ToString(0);
            MessageBox.Show("Shall I go to the next step?", "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            */
        //}

        

       

        public void ProcessBurstDecrease(int rem_bt_value,int i, int increase_value)
        {

            int negative_increase_value = 0;
            negative_increase_value = increase_value - (increase_value * 2);
            Form1 form1_algorithm = (Form1)Application.OpenForms["Form1"];
            interactive_form interactive_Form = (interactive_form)Application.OpenForms["interactive_form"];

            /*
            if (main_program_model == "Simulation Mode")
            {

            }
            else
               if (main_program_model == "Interactive Mode")
            {

            }
            */

            if (main_program_model == "Simulation Mode")
            {


                switch (form1_algorithm.processes_id_arr[i])
                {
                    case 1:
                        form1_algorithm.proc_prog_1.Value = rem_bt_value;
                        form1_algorithm.proc_prog_value_1.Text = Convert.ToString(rem_bt_value);
                        form1_algorithm.proc_prog_indicated_value_2.Visible = false;
                        form1_algorithm.proc_prog_indicated_value_3.Visible = false;

                        if (increase_value != 0)
                        {
                            form1_algorithm.proc_prog_indicated_value_1.Visible = true;
                            form1_algorithm.proc_prog_indicated_value_1.Text = Convert.ToString(negative_increase_value);
                        }
                        

                        break;
                    case 2:
                        form1_algorithm.proc_prog_2.Value = rem_bt_value;
                        form1_algorithm.proc_prog_value_2.Text = Convert.ToString(rem_bt_value);
                        form1_algorithm.proc_prog_indicated_value_1.Visible = false;
                        form1_algorithm.proc_prog_indicated_value_3.Visible = false;

                        if (increase_value != 0)
                        {
                            form1_algorithm.proc_prog_indicated_value_2.Visible = true;
                            form1_algorithm.proc_prog_indicated_value_2.Text = Convert.ToString(negative_increase_value);
                        }

                        break;
                    case 3:
                        form1_algorithm.proc_prog_3.Value = rem_bt_value;
                        form1_algorithm.proc_prog_value_3.Text = Convert.ToString(rem_bt_value);
                        form1_algorithm.proc_prog_indicated_value_1.Visible = false;
                        form1_algorithm.proc_prog_indicated_value_2.Visible = false;

                        if (increase_value != 0)
                        {
                            form1_algorithm.proc_prog_indicated_value_3.Visible = true;
                            form1_algorithm.proc_prog_indicated_value_3.Text = Convert.ToString(negative_increase_value);
                        }
                        break;

                    default:
                        Console.WriteLine("Herhangi bir progressbar değerinde değişiklik olmadı !");
                        break;
                }

            }
            else
               if (main_program_model == "Interactive Mode")
            {
                //MessageBox.Show("Burda");
                foreach (Control c in interactive_Form.processes_panel.Controls)
                {

                    if (c is ProgressBar)
                    {
                        // for (int k = 1; k <= interactive_Form.add_Row_ID; k++)
                        //{
                            //MessageBox.Show("proc_prog_" + Convert.ToString(i));
                            if (((ProgressBar)c).Name == ("proc_prog_" + Convert.ToString(i+1))) // ex: proc_name_1
                            {
                              
                                ((ProgressBar)c).Value = rem_bt_value;

                            }
                      //  }
                    }

                }

                foreach(Control c in interactive_Form.processes_panel.Controls)
                {

                    if (c is Label)
                    {
                        //for (int k = 1; k <= interactive_Form.add_Row_ID; k++)
                        //{
                            if (((Label)c).Name == ("proc_prog_value_" + Convert.ToString(i+1))) // ex: proc_name_1
                            {
                                ((Label)c).Text = Convert.ToString(rem_bt_value);

                               
                            }
                        //}
                    }

                }

                foreach (Control c in interactive_Form.processes_panel.Controls)
                {

                    if (c is Label)
                    {

                        if (((Label)c).Name == ("proc_prog_indicated_value_" + Convert.ToString(i+1))) // ex: proc_name_1
                        {
                            if (increase_value != 0)
                            {
                                //MessageBox.Show(((Label)c).Name +" indicate açık"); // burda
                                ((Label)c).Visible = true;
                                ((Label)c).Text = Convert.ToString(negative_increase_value);
                            }
                        }



                        for (int k = 1; k <= interactive_Form.add_Row_ID; k++)
                        {
                            if (((Label)c).Name == ("proc_prog_indicated_value_" + Convert.ToString(k))) // ex: proc_name_1
                            {
                                if (k != (i+1)) // i visible true so current proc_prog_indicated_value_
                                {
                                    //MessageBox.Show( ((Label)c).Name + " kapatıldı");
                                    ((Label)c).Visible = false;

                                }
                                
                            }
                        }
                    }

                }

            }

        }

        public void ProcessBurstDecreaseNotVisible()
        {
            Form1 form1_algorithm = (Form1)Application.OpenForms["Form1"];
            interactive_form interactive_Form = (interactive_form)Application.OpenForms["interactive_form"];

            if (main_program_model == "Simulation Mode")
            {


                form1_algorithm.proc_prog_indicated_value_1.Visible = false;
                form1_algorithm.proc_prog_indicated_value_2.Visible = false;
                form1_algorithm.proc_prog_indicated_value_3.Visible = false;

            }
            else
            if (main_program_model == "Interactive Mode")
            {

                foreach (Control c in interactive_Form.processes_panel.Controls)
                {

                    if (c is Label)
                    {
                        for (int k = 1; k <= interactive_Form.add_Row_ID; k++)
                        {
                            if (((Label)c).Name == ("proc_prog_indicated_value_" + Convert.ToString(k))) // ex: proc_name_1
                            {
                                ((Label)c).Visible = false;
                            }
                        }
                    }

                }

            }
        }
    }
}

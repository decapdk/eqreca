using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Resistor_Calculator
{
    public partial class Main : Form
    {
        ResistorCalc calculator = new ResistorCalc();
        ArrayList workerResults = new ArrayList();
        
        public Main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbValue.Text = "";
            cbStdRows.Text = "E12";
            cbParallelCount.Text = "2";
            tbResult.Text = "";
            lbResults.Items.Clear();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        MessageBox.Show("Giver mulighed for at beregne en ekvivalent parallel kobling af modstande som tilnærmer sig den ønskede modstandsværdi");
                    }
                    break;
                default:
                    {
                        MessageBox.Show("Ingen beskrivelse");
                    }
                    break;
            }
        }

        private void cbParallelCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbParallelCount.Text) > 3)
                MessageBox.Show("Warning. Using more then 3 resistors result in long calculation times");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ArrayList results = new ArrayList();
            int resistorcount = Convert.ToInt32(cbParallelCount.Text);
            lbResults.Items.Clear();

            WorkerArgs workargs = new WorkerArgs();

            workargs.Count = resistorcount;
            workargs.ResistorValue = Convert.ToInt32(tbValue.Text);

            switch(cbStdRows.Text)
            {
                case "E12":
                    //results = calculator.Single2Parallel(Convert.ToInt32(tbValue.Text), resistorcount, calculator.E12);
                    workargs.E_Row = calculator.E12;
                    break;
                case "E24":
                    //results = calculator.Single2Parallel(Convert.ToInt32(tbValue.Text), resistorcount, calculator.E24);
                    workargs.E_Row = calculator.E24;
                    break;
                case "E48":
                    //results = calculator.Single2Parallel(Convert.ToInt32(tbValue.Text), resistorcount, calculator.E48);
                    workargs.E_Row = calculator.E48;
                    break;
                case "E96":
                    //results = calculator.Single2Parallel(Convert.ToInt32(tbValue.Text), resistorcount, calculator.E96);
                    workargs.E_Row = calculator.E96;
                    break;
            }

            backgroundWorker1.RunWorkerAsync(workargs);

            //foreach (object i in results)
            //    lbResults.Items.Add(i);

            //tbResult.Text = calculator.Parallel(results).ToString();

            //lblPercent.Text = calculator.CalcPercent(Convert.ToDouble(tbResult.Text), Convert.ToDouble(tbValue.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList values = new ArrayList();

            if (tbRes1.Text != "")
                values.Add(Convert.ToInt32(tbRes1.Text));
            if (tbRes2.Text != "")
                values.Add(Convert.ToInt32(tbRes2.Text));
            if (tbRes3.Text != "")
                values.Add(Convert.ToInt32(tbRes3.Text));
            if (tbRes4.Text != "")
                values.Add(Convert.ToInt32(tbRes4.Text));
            if (tbRes5.Text != "")
                values.Add(Convert.ToInt32(tbRes5.Text));
            if (tbRes6.Text != "")
                values.Add(Convert.ToInt32(tbRes6.Text));
            
            tbParResult.Text = calculator.Parallel(values).ToString("0.00");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            WorkerArgs args = e.Argument as WorkerArgs;

            workerResults = calculator.Single2Parallel(args.ResistorValue, args.Count, args.E_Row);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (object i in workerResults)
                lbResults.Items.Add(i);

            tbResult.Text = calculator.Parallel(workerResults).ToString();

            lblPercent.Text = calculator.CalcPercent(Convert.ToDouble(tbResult.Text), Convert.ToDouble(tbValue.Text));
        }

   
    }

    class WorkerArgs
    {
        public int ResistorValue{ get; set; }
        public int Count{ get; set; }
        public int[] E_Row{ get; set; }
    }
}


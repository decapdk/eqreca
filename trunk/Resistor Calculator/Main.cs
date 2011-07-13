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
            
            switch(cbStdRows.Text)
            {
                case "E12":
                    results = calculator.Single2Parallel(Convert.ToInt32(tbValue.Text), resistorcount, calculator.E12);
                    break;
                case "E24":
                    results = calculator.Single2Parallel(Convert.ToInt32(tbValue.Text), resistorcount, calculator.E24);
                    break;
                case "E48":
                    results = calculator.Single2Parallel(Convert.ToInt32(tbValue.Text), resistorcount, calculator.E48);
                    break;
                case "E96":
                    results = calculator.Single2Parallel(Convert.ToInt32(tbValue.Text), resistorcount, calculator.E96);
                    break;
            }

            foreach (object i in results)
                lbResults.Items.Add(i);

            switch (resistorcount)
            {
                case 2:
                    tbResult.Text = calculator.Parallel((int)results[0], (int)results[1]).ToString();
                    break;
                case 3:
                    tbResult.Text = calculator.Parallel((int)results[0], (int)results[1],(int)results[2]).ToString();
                    break;
                case 4:
                    tbResult.Text = calculator.Parallel((int)results[0], (int)results[1], (int)results[2],(int)results[3]).ToString();
                    break;

            }

            lblPercent.Text = calculator.CalcPercent(Convert.ToDouble(tbResult.Text), Convert.ToDouble(tbValue.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList values = new ArrayList();
            double par_val = -1;

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

            switch (values.Count)
            {
                case 1:
                    par_val = Convert.ToDouble(values[0]);
                    break;
                case 2:
                    par_val = calculator.Parallel((int)values[0], (int)values[1]);
                    break;
                case 3:
                    par_val = calculator.Parallel((int)values[0], (int)values[1], (int)values[2]);
                    break;
                case 4:
                    par_val = calculator.Parallel((int)values[0], (int)values[1], (int)values[2], (int)values[3]);
                    break;
                case 5:
                    par_val = calculator.Parallel((int)values[0], (int)values[1], (int)values[2], (int)values[3], (int)values[4]);
                    break;
                case 6:
                    par_val = calculator.Parallel((int)values[0], (int)values[1], (int)values[2], (int)values[3], (int)values[4], (int)values[5]);
                    break;
            }

            tbParResult.Text = par_val.ToString("0.00");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Resistor_Calculator
{
    class ResistorCalc
    {
        int minR;
        public void SetMin(int min)
        { minR = min; }
        public int GetMin()
        { return minR; }

        int maxR;
        public void SetMax(int max)
        { maxR = max; }
        public int GetMax()
        { return maxR; }

        public int[] E12 = { 100, 120, 150, 180, 220, 270, 330, 390, 470, 560, 680, 820 };
        public int[] E24 = { 100, 110, 120, 130, 150, 160, 180, 200, 220, 240, 270, 300,
                             330, 360, 390, 430, 470, 510, 560, 620, 680, 750, 820, 910 };
        public int[] E48 = {100,105,110,115,121,127,133,140,147,154,162,169,178,187,196,
                            205,215,226,237,249,261,274,287,301,316,332,348,365,383,402,
                            422,442,464,487,511,536,562,590,619,649,681,715,750,787,825,
                            866,909,953};
        public int[] E96 = { 100,102,105,107,110,113,115,118,121,124,127,130,133,137,140,
                               143,147,150,154,158,162,165,169,174,178,182,187,191,196,200,
                               205,210,215,221,226,232,237,243,249,255,261,267,274,280,287,
                               294,301,309,316,324,332,340,348,357,365,374,383,392,402,412,
                               422,432,442,453,464,475,487,499,511,523,536,549,562,576,590,
                               604,619,634,649,665,681,698,715,732,750,768,787,806,825,845,
                               866,887,909,931,953,976};

        public string CalcPercent(double current, double reference)
        {
            double div = Math.Abs(current - reference);
            double calc = (double)(div / reference);
            return calc.ToString("0.00%");
             
        }

        private ArrayList CalcErowR(int[] erow)
        {
            ArrayList possibleR = new ArrayList();
            for (int i = 0; i <= 4; i++)
            {
                foreach (int j in erow)
                {
                    possibleR.Add((int)(j * Math.Pow(10, i)));
                }
            }
            return possibleR;
        }

        private double ClosestMatch(int value, ArrayList possibilities)
        {
            double bestDiviance = double.MaxValue;
            double match = -1;

            foreach (double i in possibilities)
            {
                double d = Math.Abs(value - i);
                if (d <= bestDiviance)
                {
                    bestDiviance = d;
                    match = i;
                }
            }
            return match;
        }

        public double Parallel(int value1, int value2)
        {
            double calculation = (double)1 / ((double)1 / value1 + (double)1 / value2);
            return calculation;
        }

        public double Parallel(int value1, int value2, int value3)
        {
            double calculation = (double)1 / ((double)1 / value1 + (double)1 / value2 + (double)1 / value3);
            return calculation;
        }

        public double Parallel(int value1, int value2, int value3, int value4)
        {
            double calculation = (double)1 / ((double)1 / value1 + (double)1 / value2 + (double)1 / value3 + (double)1 / value4);
            return calculation;
        }

        public double Parallel(int value1, int value2, int value3, int value4, int value5)
        {
            double calculation = (double)1 / ((double)1 / value1 + (double)1 / value2 + (double)1 / value3 + (double)1 / value4 + (double)1 / value5);
            return calculation;
        }

        public double Parallel(int value1, int value2, int value3, int value4, int value5, int value6)
        {
            double calculation = (double)1 / ((double)1 / value1 + (double)1 / value2 + (double)1 / value3 + (double)1 / value4 + (double)1 / value5 + (double)1 / value6);
            return calculation;
        }

        public ArrayList Single2Parallel(int value, int res_count, int[] erow)
        {
            ArrayList results = new ArrayList();
            ArrayList erow_values = CalcErowR(erow);
            ArrayList returnVals = new ArrayList();

            int r1 = 0, r2 = 0, r3 = 0, r4 = 0;

            double bestDiviance = double.MaxValue;
            double result,d;
            
            switch (res_count)
            {
                case 2:
                    {
                        foreach (int i in erow_values)
                        {
                            foreach (int j in erow_values)
                            {
                                //results.Add(Parallel(i, j));
                                result = Parallel(i, j);
                                d = Math.Abs(value - result);
                                if (d <= bestDiviance)
                                {
                                    bestDiviance = d;
                                    r1 = i;
                                    r2 = j;
                                    //match = i;
                                }
                            }
                        }
                    }
                    returnVals.Add(r1);
                    returnVals.Add(r2);
                    break;
                case 3:
                    {
                        foreach (int i in erow_values)
                        {
                            foreach (int j in erow_values)
                            {
                                foreach (int h in erow_values)
                                {//results.Add(Parallel(i, j));
                                    result = Parallel(i, j, h);
                                    d = Math.Abs(value - result);
                                    if (d <= bestDiviance)
                                    {
                                        bestDiviance = d;
                                        r1 = i;
                                        r2 = j;
                                        r3 = h;
                                        //match = i;
                                    }
                                }
                            }
                        }
                    }
                    returnVals.Add(r1);
                    returnVals.Add(r2);
                    returnVals.Add(r3);
                    break;
                case 4:
                    {
                        foreach (int i in erow_values)
                        {
                            foreach (int j in erow_values)
                            {
                                foreach (int h in erow_values)
                                {
                                    foreach (int k in erow_values)
                                    {
                                        result = Parallel(i, j, h, k);
                                        d = Math.Abs(value - result);
                                        if (d <= bestDiviance)
                                        {
                                            bestDiviance = d;
                                            r1 = i;
                                            r2 = j;
                                            r3 = h;
                                            r4 = k;
                                            //match = i;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    returnVals.Add(r1);
                    returnVals.Add(r2);
                    returnVals.Add(r3);
                    returnVals.Add(r4);
                    break;
            }

            return returnVals;
        }    

        public int Series(int value1, int value2)
        {
            return value1 + value2;
        }

        public int FindNearest(int value, int[] Erow, int parallel_count)
        {
            // calc for 1-1M ohm

            int bestDiviance = int.MaxValue;

            // Calculate all possible values in selected E row
            ArrayList possibleR = CalcErowR(Erow);

            // Calculate all possible values in parallel setup
            ArrayList combinationalR = new ArrayList();



            combinationalR = possibleR;

            // Find closest match
            int match = -1;

            foreach (int r in combinationalR)
            {
                int d = Math.Abs(value - r);
                if (d <= bestDiviance)
                {
                    bestDiviance = d;
                    match = r;
                }
            }

            CalcPercent(match, value);

            return match;
        }
    }
}

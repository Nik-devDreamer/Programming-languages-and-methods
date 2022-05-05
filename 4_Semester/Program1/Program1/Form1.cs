using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace Program1
{
    public partial class Form1 : Form
    {
        private double[] _result;
        private double nullElement, firstElement, secondElement, thirdElement, fourthElement, fifthElement, result;
        private double start = -10, end = 10, step = 0.1, current = 0, previous = 0;
        private int mouseWheel = 0;
        private bool mouseChart = false;

        public Form1()
        {
            InitializeComponent();
            VisibleFalse();
            this.MouseWheel += Form_MouseWheel;
            PoiskKorneyButton.Enabled = false;
        }

        public double[] OneDegree(double nullElement, double firstElement)
        {
            _result = new double[1];
            _result[0] = ((double)-nullElement / firstElement);
            return _result;
        }

        public double[] TwoDegree(double nullElement, double firstElement, double secondElement)
        {
            if (secondElement == 0)
                throw new DivideByZeroException();

            _result = new double[2];
            double D = firstElement * firstElement - 4 * secondElement * nullElement;

            if (D < 0)
                KorniVivod.Text = "Действительных корней нет" + "\r\n";
            else if (D > 0 || D == 0)
            {
                _result[0] = (double)((-firstElement - Math.Sqrt(firstElement * firstElement - 4 * secondElement * nullElement)) / (2 * secondElement));
                _result[1] = (double)((-firstElement + Math.Sqrt(firstElement * firstElement - 4 * secondElement * nullElement)) / (2 * secondElement));
            }

            return _result;
        }

        private double[] ThirdDegree(double nullElement, double firstElement, double secondElement, double thirdElement)
        {
            if (secondElement == 0)
                throw new DivideByZeroException();

            double a = thirdElement, b = secondElement, c = firstElement, d = nullElement;
            double eps = 1E-14;
            double p = (3 * a * c - b * b) / (3 * a * a);
            double q = (2 * b * b * b - 9 * a * b * c + 27 * a * a * d) / (27 * a * a * a);
            double det = q * q / 4 + p * p * p / 27;

            if (Math.Abs(det) < eps)
                det = 0;

            if (det > 0)
            {
                _result = new double[1];
                // один вещественный, два комплексных корня
                double x = (-q / 2) + Math.Sqrt(det);
                if (x < 0)
                    x = -Math.Pow(Math.Abs(x), 1.0 / 3);
                else
                    x = Math.Pow(x, 1.0 / 3);

                double x1 = ((-q / 2) - Math.Sqrt(det));
                if(x1 < 0)
                    x1 = - Math.Pow(Math.Abs(x1), 1.0 / 3);
                else
                    x1 = Math.Pow(x1, 1.0 / 3);

                _result[0] = x + x1 - (b / (3 * a));
                KorniVivod.Text += "x = " + (-((x + x1) / 2) - (b / (3 * a))) + "+ i*(" + ((Math.Sqrt(3) * (x - x1)) / 2) + ")" + "\r\n";
                KorniVivod.Text += "x = " + (-((x + x1) / 2) - (b / (3 * a))) + "- i*(" + ((Math.Sqrt(3) * (x - x1)) / 2) + ")" + "\r\n";
            }
            else
            {
                _result = new double[3];
                if (det < 0)
                {
                    // три вещественных корня
                    double fi;
                    if (Math.Abs(q) < eps) // q=0
                        fi = Math.PI / 2;
                    else
                    {
                        if (q < 0)
                            fi = Math.Atan(Math.Sqrt(-det) / (-q / 2));
                        else
                            fi = Math.Atan(Math.Sqrt(-det) / (-q / 2)) + Math.PI;
                    }
                    double r = 2 * Math.Sqrt(-p / 3);
                    _result[0] = r * Math.Cos(fi / 3) - b / (3 * a);
                    _result[1] = r * Math.Cos((fi + 2 * Math.PI) / 3) - b / (3 * a);
                    _result[2] = r * Math.Cos((fi + 4 * Math.PI) / 3) - b / (3 * a);
                }
                else // det=0
                {
                    if (Math.Abs(q) < eps)
                    {
                        _result[0] = -b / (3 * a); // 3-х кратный 
                        _result[1] = -b / (3 * a);
                        _result[2] = -b / (3 * a);
                    }
                    else
                    {
                        // один и два кратных
                        double u = Math.Exp(Math.Log(Math.Abs(q) / 2) / 3);
                        if (q < 0)
                            u = -u;
                        _result[0] = -2 * u - b / (3 * a);
                        _result[1] = u - b / (3 * a);
                        _result[2] = u - b / (3 * a);
                    }
                }
            }

            return _result;
        }

        private double[] NumericalDegree(double f, double e, double d, double c, double b, double a)
        {
            int start = -100, end = 100, k = 0;
            double step = 0.01, calc;
            List<double> list = new List<double>();

            for(double i = start; i <= end; i += step)
            {
                i = Math.Round(i, 2);
                calc = Math.Pow(i, 5) * a + Math.Pow(i, 4) * b + Math.Pow(i, 3) * c + Math.Pow(i, 2) * d + i * e + f;
                
                if (calc == 0)
                    list.Add(i);
            }

            _result = new double[list.Count];
            foreach(double x in list)
            {
                _result[k] = x;
                k++;
            }

            return _result;
        }

        private void PoiskKorneyButton_Click(object sender, EventArgs e)
        {
            KorniVivod.Clear();

            try
            {
                switch (int.Parse(comboBox1.Text))
                {
                    case 1:
                        firstElement = int.Parse(textBoxX1.Text);
                        nullElement = int.Parse(textBoxX0.Text);
                        _result = OneDegree(nullElement, firstElement);
                        СleanCoordinates(int.Parse(comboBox1.Text));
                        break;
                    case 2:
                        secondElement = int.Parse(textBoxX2.Text);
                        firstElement = int.Parse(textBoxX1.Text);
                        nullElement = int.Parse(textBoxX0.Text);
                        _result = TwoDegree(nullElement, firstElement, secondElement);
                        СleanCoordinates(int.Parse(comboBox1.Text));
                        break;
                    case 3:
                        thirdElement = int.Parse(textBoxX3.Text);
                        secondElement = int.Parse(textBoxX2.Text);
                        firstElement = int.Parse(textBoxX1.Text);
                        nullElement = int.Parse(textBoxX0.Text);
                        if (ChislenMetod.Checked)
                            _result = NumericalDegree(nullElement, firstElement, secondElement, thirdElement, fourthElement, fifthElement);
                        else if (AnalitMetod.Checked)
                            _result =  ThirdDegree(nullElement, firstElement, secondElement, thirdElement);
                        СleanCoordinates(int.Parse(comboBox1.Text));
                        break;
                    case 4:
                        fourthElement = int.Parse(textBoxX4.Text);
                        thirdElement = int.Parse(textBoxX3.Text);
                        secondElement = int.Parse(textBoxX2.Text);
                        firstElement = int.Parse(textBoxX1.Text);
                        nullElement = int.Parse(textBoxX0.Text);
                        _result = NumericalDegree(nullElement, firstElement, secondElement, thirdElement, fourthElement, fifthElement);
                        СleanCoordinates(int.Parse(comboBox1.Text));
                        break;
                    case 5:
                        fifthElement = int.Parse(textBoxX5.Text);
                        fourthElement = int.Parse(textBoxX4.Text);
                        thirdElement = int.Parse(textBoxX3.Text);
                        secondElement = int.Parse(textBoxX2.Text);
                        firstElement = int.Parse(textBoxX1.Text);
                        nullElement = int.Parse(textBoxX0.Text);
                        _result = NumericalDegree(nullElement, firstElement, secondElement, thirdElement, fourthElement, fifthElement);
                        СleanCoordinates(int.Parse(comboBox1.Text));
                        break;
                }

                foreach (var x in _result)
                {
                    KorniVivod.Text += "x = " + x.ToString() + "\r\n";
                }
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Неверное уравнение");
            }
            
        }

        private void VisibleFalse()
        {
            textBoxX5.Visible = false;
            textBoxX4.Visible = false;
            textBoxX3.Visible = false;
            textBoxX2.Visible = false;
            textBoxX1.Visible = false;
            textBoxX0.Visible = false;
            labelX5.Visible = false;
            labelX4.Visible = false;
            labelX3.Visible = false;
            labelX2.Visible = false;
            labelX1.Visible = false;
            labelEnd0.Visible = false;
        }

        private void XMin(object sender, KeyEventArgs e)
        {
            double.TryParse(textBoxIntervalX1.Text, out result);
            chart1.ChartAreas[0].AxisX.Minimum = result;
        }

        private void XMax(object sender, KeyEventArgs e)
        {
            double.TryParse(textBoxIntervalX2.Text, out result);
            chart1.ChartAreas[0].AxisX.Maximum = result;
        }

        private void YMin(object sender, KeyEventArgs e)
        {
            double.TryParse(textBoxIntervalY1.Text, out result);
            chart1.ChartAreas[0].AxisY.Minimum = result;
        }

        private void YMax(object sender, KeyEventArgs e)
        {
            double.TryParse(textBoxIntervalY2.Text, out result);
            chart1.ChartAreas[0].AxisY.Maximum = result;
        }

        private void chart1_MouseEnter(object sender, EventArgs e)
        {
            Graph();
            mouseChart = true;
        }

        private void chart1_MouseLeave(object sender, EventArgs e)
        {
            mouseChart = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisibleFalse();
            AnalitMetod.Enabled = false;
            ChislenMetod.Enabled = false;
            if (int.Parse(comboBox1.Text) == 1)
            {
                labelX1.Visible = true;
                textBoxX1.Visible = true;
                textBoxX0.Visible = true;
                labelEnd0.Visible = true;
                AnalitMetod.Enabled = true;
            }
            else if (int.Parse(comboBox1.Text) == 2)
            {
                labelX2.Visible = true;
                labelX1.Visible = true;
                textBoxX2.Visible = true;
                textBoxX1.Visible = true;
                textBoxX0.Visible = true;
                labelEnd0.Visible = true;
                AnalitMetod.Enabled = true;
            }
            else if (int.Parse(comboBox1.Text) == 3)
            {
                labelX3.Visible = true;
                labelX2.Visible = true;
                labelX1.Visible = true;
                textBoxX3.Visible = true;
                textBoxX2.Visible = true;
                textBoxX1.Visible = true;
                textBoxX0.Visible = true;
                labelEnd0.Visible = true;
                AnalitMetod.Enabled = true;
                ChislenMetod.Enabled = true;
            }
            else if (int.Parse(comboBox1.Text) == 4)
            {
                labelX4.Visible = true;
                labelX3.Visible = true;
                labelX2.Visible = true;
                labelX1.Visible = true;
                textBoxX4.Visible = true;
                textBoxX3.Visible = true;
                textBoxX2.Visible = true;
                textBoxX1.Visible = true;
                textBoxX0.Visible = true;
                labelEnd0.Visible = true;
                ChislenMetod.Enabled = true;
            }
            else if (int.Parse(comboBox1.Text) == 5)
            {
                labelX5.Visible = true;
                labelX4.Visible = true;
                labelX3.Visible = true;
                labelX2.Visible = true;
                labelX1.Visible = true;
                textBoxX5.Visible = true;
                textBoxX4.Visible = true;
                textBoxX3.Visible = true;
                textBoxX2.Visible = true;
                textBoxX1.Visible = true;
                textBoxX0.Visible = true;
                labelEnd0.Visible = true;
                ChislenMetod.Enabled = true;
            }
        }

        private void СleanCoordinates(int count)
        {
            if (count == 1)
            {
                secondElement = 0;
                thirdElement = 0;
                fourthElement = 0;
                fifthElement = 0;
            }
            else if (count == 2)
            {
                thirdElement = 0;
                fourthElement = 0;
                fifthElement = 0;
            }
            else if (count == 3)
            {
                fourthElement = 0;
                fifthElement = 0;
            }
            else if (count == 4)
            {
                fifthElement = 0;
            }
        }

        private int Calculation(double x)
        {
            return (int)(fifthElement * Math.Pow(x, 5) + fourthElement * Math.Pow(x, 4) + thirdElement * Math.Pow(x, 3) + secondElement * Math.Pow(x, 2) + firstElement * x + nullElement);
        }

        private void ProverkaKorneyButton_Click(object sender, EventArgs e)
        {
            string result = string.Empty;

            foreach (double x in _result)
            {
                result += string.Format("f({0}) = {1}\n", x, Calculation(x));
            }

            MessageBox.Show(result);
        }

        private void Graph()
        {
            this.chart1.Series[0].Points.Clear();

            for (double i = start; i <= end; i += step)
            {
                double y = Calculation(i);
                chart1.Series[0].Points.AddXY(i, y);
            }
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current = (Cursor.Position.X - this.Left);

                if (current > previous)
                {
                    start -= step;
                    end -= step;
                }
                else
                {
                    start += step;
                    end += step;
                }

                previous = (Cursor.Position.X - this.Left);
                Graph();
            }
        }

        private void Form_MouseWheel(object sender, MouseEventArgs e)
        {
            mouseWheel = e.Delta;

            if(mouseChart)
            {
                if(mouseWheel < 0)
                {
                    start -= 1;
                    end += 1;
                }
                else
                {
                    start += 1;
                    end -= 1;
                }
                Graph();
            }
        }

        private void AnalitMetod_CheckedChanged(object sender, EventArgs e)
        {
            if(AnalitMetod.Checked)
                PoiskKorneyButton.Enabled = true;
        }

        private void ChislenMetod_CheckedChanged(object sender, EventArgs e)
        {
            if (ChislenMetod.Checked)
                PoiskKorneyButton.Enabled = true;
        }
    }
}

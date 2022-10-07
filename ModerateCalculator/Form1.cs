using System.Data;

namespace ModerateCalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OperationsLog.Text = "";

        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (Numbers.Text!="0")
            {
                Numbers.Text += '.';
            }
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (Numbers.Text != "0")
            {
                Numbers.Text += '0';
            }
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (Numbers.Text == "0")
            {
                Numbers.Text = "";
            }
            Numbers.Text += '1';
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (Numbers.Text == "0")
            {
                Numbers.Text = "";
            }
            Numbers.Text += '2';
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (Numbers.Text == "0")
            {
                Numbers.Text = "";
            }
            Numbers.Text += '3';
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (Numbers.Text == "0")
            {
                Numbers.Text = "";
            }
            Numbers.Text += '4';
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (Numbers.Text == "0")
            {
                Numbers.Text = "";
            }
            Numbers.Text += '5';
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (Numbers.Text == "0")
            {
                Numbers.Text = "";
            }
            Numbers.Text += '6';
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (Numbers.Text == "0")
            {
                Numbers.Text = "";
            }
            Numbers.Text += '7';
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (Numbers.Text == "0")
            {
                Numbers.Text = "";
            }
            Numbers.Text += '8';
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (Numbers.Text == "0")
            {
                Numbers.Text = "";
            }
            Numbers.Text += '9';
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (OperationsLog.Text != "")
            {
                OperationsLog.Text += Numbers.Text+'*';
                Numbers.Text = "0";
            }
            else
            {
                OperationsLog.Text = Numbers.Text + '*';
                Numbers.Text = "0";
            }
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if (OperationsLog.Text!="")
            {
                double res = 0;
                res =Evaluate(OperationsLog.Text+Numbers.Text);
                OperationsLog.Text = "";
                Numbers.Text=Convert.ToString(res);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Numbers.Text = "0";
        }
        static double Evaluate(string expression)
        {
            var loDataTable = new DataTable();
            var loDataColumn = new DataColumn("Eval", typeof(double), expression);
            loDataTable.Columns.Add(loDataColumn);
            loDataTable.Rows.Add(0);
            return (double)(loDataTable.Rows[0]["Eval"]);
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (Numbers.Text!="0")
            {
                if (OperationsLog.Text != "")
                {
                    OperationsLog.Text += Numbers.Text + '+';
                    Numbers.Text = "0";
                }
                else
                {
                    OperationsLog.Text = Numbers.Text + '+';
                    Numbers.Text = "0";
                }
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (Numbers.Text != "0")
            {
                if (OperationsLog.Text != "")
                {
                    OperationsLog.Text += Numbers.Text + '-';
                    Numbers.Text = "0";
                }
                else
                {
                    OperationsLog.Text = Numbers.Text + '-';
                    Numbers.Text = "0";
                }
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (Numbers.Text != "0")
            {
                if (OperationsLog.Text != "")
                {
                    OperationsLog.Text += Numbers.Text + '/';
                    Numbers.Text = "0";
                }
                else
                {
                    OperationsLog.Text = Numbers.Text + '/';
                    Numbers.Text = "0";
                }
            }
            else
            {
                DialogResult res=MessageBox.Show("Can't Divide by Zero","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
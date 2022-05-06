using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HopField
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection scn = new SqlConnection("server=.;database=Hopfield;uid=sa;pwd=23456");

        public List<List<double[]>> GetFromDataBase(List<List<double[]>> Alphabet, string sql, double p)
        {
            scn.Open();
            SqlCommand cmd = new SqlCommand(sql, scn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<double[]> input = new List<double[]>();
            double[] array = new double[Convert.ToInt32(p)]; //10*12 all save in the array[]
            while (dr.Read())
            {
                for (int i = 1; i <= p; i++)
                {
                    array[i - 1] = (Convert.ToDouble(dr[i]));
                }
                input.Add(array);
                Alphabet.Add(input);
                input = new List<double[]>();
                array = new double[Convert.ToInt32(p)];
            }
            scn.Close();
            return Alphabet;
        }
        public double[,] getW(double[,] w, List<List<double[]>> Alphabet, int p)
        {
            for (int i = 0; i < p; i++)
            {
                for (int i2 = 0; i2 < p; i2++)
                {
                    for (int i3 = 0; i3 < Alphabet.Count; i3++)
                    {
                        w[i, i2] += Alphabet[i3][0][i] * Alphabet[i3][0][i2];
                    }
                }
                w[i, i] = 0;
            }
            return w;
        }
        public double[] Multiply(double[,] w, double[] input, double[] answer, int p)
        {
            for (int i = 0; i < p; i++)
            {
                for (int i2 = 0; i2 < p; i2++)
                {
                    answer[i] += w[i, i2] * input[i2];
                }
            }
            return answer;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public double[] getAllValues(double[] input)
        {
            for (int i = 0; i < 400; i++)
            {
                TextBox Text = this.Controls.Find("textbox" + (i + 1).ToString(), true).FirstOrDefault() as TextBox;
                if (Text.Text != "")
                {
                    input[i] = 1;
                }
                else
                {
                    input[i] = -1;
                }
            }
            return input;
        }
        public void ValuesOfModify(string str)
        {
            for (int i = 1; i <= 400; i++)
            {
                TextBox Text = this.Controls.Find("textbox" + i.ToString(), true).FirstOrDefault() as TextBox;
                Text.Text = str;
            }
        }
        public string WriteDataIntoSQL(string sql)
        {
            scn.Open();
            double[] input = new double[400];
            input = getAllValues(input);
            sql +=
                (System.DateTime.Now.Month).ToString() +
                (System.DateTime.Now.Day).ToString() +
                (System.DateTime.Now.Hour).ToString() +
                (System.DateTime.Now.Minute).ToString() +
                (System.DateTime.Now.Second).ToString() +
                ","; //作為Data的Key
            for (int i = 0; i < 400; i++)
            {
                sql += input[i].ToString();
                if (i != 399)
                {
                    sql += ",";
                }
            }
            sql += ");";
            SqlCommand cmd = new SqlCommand(sql, scn);
            cmd.ExecuteNonQuery();
            scn.Close();
            return sql;
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            List<List<double[]>> Alphabet = new List<List<double[]>>();
            List<List<double[]>> Input = new List<List<double[]>>();
            string sql = "Select * from Alphabet"; //字母的資料表
            int p = 400, display = 20;                 //維度*維度，顯示時每行多少個
            Alphabet = GetFromDataBase(Alphabet, sql, p);
            sql = "Select * from Input";          //新輸入的資料表
            Input = GetFromDataBase(Input, sql, p);
            double n = Alphabet.Count;

            double[,] w = new double[p, p];     //W計算
            w = getW(w, Alphabet, p);

            for (int i = 0; i < Input.Count; i++) //開始回想
            {
                double[] answer = new double[p];
                answer = Multiply(w, Input[i][0], answer, p);
                string printstr = ""; int printLine = display;
                for (int print = 0; print < p; print++)
                {
                    if (answer[print] > 0) //條件判斷
                    {
                        answer[print] = 1;
                    }
                    else if (answer[print] < 0)
                    {
                        answer[print] = -1;
                    }
                    else
                    {
                        answer[print] = Input[i][0][print];
                    }

                    if (printLine > 1) //列印出來的處理
                    {
                        if (answer[print] == -1)
                        {
                            printstr += "- ";
                        }
                        else
                        {
                            printstr += "1 ";
                        }
                        printLine--;
                    }
                    else
                    {
                        if (answer[print] == -1)
                        {
                            printstr += "-\n";
                        }
                        else
                        {
                            printstr += "1\n";
                        }
                        printLine = display;
                    }

                }
                MessageBox.Show(printstr);
            }
        }

        private void ADDbtn_alphabetTable_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Alphabet VALUES(";
            sql = WriteDataIntoSQL(sql);
        }

        private void ADDbtn_InputTable_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Input VALUES(";
            sql = WriteDataIntoSQL(sql);
        }

        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            ValuesOfModify("");
        }

        private void btn_AllBeOne_Click(object sender, EventArgs e)
        {
            ValuesOfModify("1");
        }

        private void text1_MouseMove(object sender, MouseEventArgs e)
        {
            TextBox text = (TextBox)sender;
            if (radioButton1.Checked)
            {
                text.Text = "1";
            }
            else if (radioButton2.Checked)
            {
                text.Text = "";
            }
        }

        private void StartRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 1; i <= 400; i++)
            {
                TextBox Text = this.Controls.Find("Textbox" + i.ToString(), true).FirstOrDefault() as TextBox;
                int percentage = rnd.Next(0, 101);
                if (percentage <= Convert.ToInt32(RandomPercent.Text))
                {
                    Text.Text = Text.Text == "1" ? "" : "1";
                }
            }
        }
    }
}

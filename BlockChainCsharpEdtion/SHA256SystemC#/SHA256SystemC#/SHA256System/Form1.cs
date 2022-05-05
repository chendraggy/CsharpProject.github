using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Xml;
using Microsoft.VisualBasic;
namespace SHA256System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //定義區塊的結構
        public struct Block
        {
            /// No 
            public int Index { get; set; }
            /// time
            public string TimeStamp { get; set; }
            /// imformation
            public string data { get; set; }
            /// this block's SHA-256 
            public string Hash { get; set; }
            /// previous block's SHA-256
            public string PrevHash { get; set; }
            ///  the mining rule
            public string Difficulty { get; set; }
            ///  Nonce
            public int Nonce { get; set; }
        }
        //用來儲存困難度
        string Data_Key="";
        //判斷是否為數字
        public static bool IsNumeric(object Expression)
        {
            // Variable to collect the Return value of the TryParse method.
            bool isNum;
            // Define variable to collect out parameter of the TryParse method. If the conversion fails, the out parameter is zero.
            double retNum;
            // The TryParse method converts a string in a specified style and culture-specific format to its double-precision floating point number equivalent.
            // The TryParse method does not generate an exception if the conversion fails. If the conversion passes, True is returned. If it does not, False is returned.
            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);

            return isNum;
        }
        //計算雜湊值Hash
        public static string CalculateHash(Block block)
        {
            string calculationStr = $"{block.Index}{block.TimeStamp}{block.data}{block.PrevHash}{block.Nonce}";
            SHA256 sha256Generator = SHA256.Create();
            byte[] sha256HashBytes = sha256Generator.ComputeHash(Encoding.UTF8.GetBytes(calculationStr));
            StringBuilder sha256StrBuilder = new StringBuilder();
            foreach (byte @byte in sha256HashBytes)
            {
                sha256StrBuilder.Append(@byte.ToString("x2"));
            }
            return sha256StrBuilder.ToString();
        }
        //審查Hash是否符合困難度
        public static bool IsHashValid(string hashStr,string Data_Key)
        {
            int count = 0;
            for (int i = 0; i < hashStr.Length; i++)
            {
                if (i<Data_Key.Length&&hashStr.Substring(i, 1) == Data_Key.Substring(i,1))
                {
                    count += 1;
                }
                else 
                {
                    if (i == Data_Key.Length && hashStr.Substring(i, 1) == Data_Key.Substring(i - 1))
                        return false;
                    if (count == Data_Key.Length)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
        //生成區塊
        public static Block GenerateBlock(Block oldBlock, string inputdata,string datetime,string Data_Key)
        {
            int count = 0;
            bool key = false;
            while(key==false)
            {
                Block newBlock = new Block()
                {
                    Index = oldBlock.Index + 1,
                    TimeStamp = datetime,
                    data = inputdata,
                    PrevHash = oldBlock.Hash,
                    Nonce = count,
                    Difficulty = Data_Key
                };
                string hashstr = CalculateHash(newBlock);
                if (IsHashValid(hashstr,Data_Key))
                {
                    Block returnBlock = new Block()
                    {
                        Index = oldBlock.Index + 1,
                        TimeStamp = datetime,
                        data = inputdata,
                        PrevHash = oldBlock.Hash,
                        Hash=hashstr,
                        Nonce = count,
                        Difficulty = Data_Key
                    };
                    return returnBlock;
                }
                else
                {
                    count += 1;
                }
            }
            Block nothing = new Block();
            return nothing;
        }
        //連線伺服器
        SqlConnection conn = new SqlConnection("Data Source =.; Database = SHA256HashDataBase; Integrated Security = False; uid = sa; password = 23456;");
        
        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            SearchAndUpdateData();
        }
        string SearchOrUpdate="";
        //更新資料
        private void SearchAndUpdateData()
        {
            string strSQL = "";
            if (SearchOrUpdate == "")
            {
                strSQL = "Select * from MiningData order by No;";
            }
            else
            {
                strSQL = "Select * from MiningData where No=" + SearchOrUpdate +";";
            }
            
            SqlDataAdapter sqlDA = new SqlDataAdapter(strSQL, conn);
            DataSet dataset = new DataSet();
            sqlDA.Fill(dataset);
            ShowDataBase.AutoGenerateColumns = true;
            ShowDataBase.DataSource = dataset.Tables[0];
            for(int i=0;i<ShowDataBase.RowCount-1;i++)//Automatically adjust column width
            {
                ShowDataBase.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                int widthCol = ShowDataBase.Columns[i].Width;
                ShowDataBase.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                ShowDataBase.Columns[i].Width = widthCol;
            }
        }
        //將區塊加入區塊鏈資料庫
        private void InsertData()
        { //2021-11-10 00:00:00
            string times = Data_time.Value.Year.ToString() +"-"+ Data_time.Value.Month.ToString() + "-" + Data_time.Value.Day.ToString() + " "+
                Data_time.Value.Hour.ToString()+":" +Data_time.Value.Minute.ToString() +":00";
            
            String strSQL = string.Format("INSERT INTO MiningData(No, Nonce, Times, Data, PreviousHash, Hash, Difficulty) VALUES ({0}, {1}, '{2}', '{3}', '{4}', '{5}','{6}');", Convert.ToInt32( Data_No.Text),Convert.ToInt32( Data_Nonce.Text),times,Data.Text,Data_PreviousHash.Text,Data_Hash.Text,Data_Key);
            SqlCommand sqlcommand = new SqlCommand(strSQL, conn);
            sqlcommand.ExecuteNonQuery();
            SearchOrUpdate = "";
            SearchAndUpdateData();
        }
        //更改資料庫裡的區塊
        private void ChangeData(Block block)
        {
            string times = Data_time.Value.Year.ToString() + "-" + Data_time.Value.Month.ToString() + "-" + Data_time.Value.Day.ToString() + " " +
                Data_time.Value.Hour.ToString() + ":" + Data_time.Value.Minute.ToString() + ":00";

            String strSQL = string.Format(" UPDATE MiningData SET Nonce={0}, Times='{1}', Data='{2}', PreviousHash='{3}',Hash='{4}',Difficulty='{6}' WHERE No={5}; ", block.Nonce, times, block.data, block.PrevHash,block.Hash,block.Index,Data_Key);
            SqlCommand sqlcommand = new SqlCommand(strSQL, conn);
            sqlcommand.ExecuteNonQuery();
        }
        //儲存區塊到區塊鏈伺服器事件
        private void SaveData_Click(object sender, EventArgs e)
        {
            if (Data_No.Text == "" || Data_Nonce.Text == "" || Data_PreviousHash.Text == "" || Data_Hash.Text == ""||Data_PreviousHash.Text == "" && Data_No.Text != "0")
            {
                MessageBox.Show("輸入錯誤! 請檢查!!");
            }
            else
            {
                bool repeatNO = false;
                for (int i = 0; i < ShowDataBase.RowCount-1; i++)
                {
                    if (ShowDataBase[0, i].Value.ToString() == Data_No.Text)
                    {
                        repeatNO = true;break;
                    }
                }
                if(repeatNO==true)
                {
                    string times = Data_time.Value.Year.ToString() + "-" + Data_time.Value.Month.ToString() + "-" + Data_time.Value.Day.ToString() + " " +
                Data_time.Value.Hour.ToString() + ":" + Data_time.Value.Minute.ToString() + ":00";

                    Block block = new Block()
                    {
                        Index = Convert.ToInt32(Data_No.Text),
                        Nonce = Convert.ToInt32(Data_Nonce.Text),
                        TimeStamp = times,
                        data = Data.Text,
                        Hash = Data_Hash.Text,
                        PrevHash = Data_PreviousHash.Text,
                        Difficulty = Data_Key
                    };
                    ChangeData(block); SearchOrUpdate=""; SearchAndUpdateData();
                    MessageBox.Show("Already changed the data");
                }
                else
                {
                    InsertData(); SearchAndUpdateData();
                    MessageBox.Show("Successfully saved!");
                }
            }
        }
        //開始挖礦事件
        private void Mining_Click(object sender, EventArgs e)
        {
                if(Data_Key=="")
            { MessageBox.Show("You would need to insert the Difficultly first!");return; }
                string times = Data_time.Value.Year.ToString() + "-" + Data_time.Value.Month.ToString() + "-" + Data_time.Value.Day.ToString() + " " +
                Data_time.Value.Hour.ToString() + ":" + Data_time.Value.Minute.ToString() + ":00";
                if (Data_No.Text == "0")
                {
                    Block block = new Block()
                    {
                        Index = -1,
                        Hash = "0000000000000000000000000000000000000000000000000000000000000000",
                    };
                    block = GenerateBlock(block, Data.Text, times, Data_Key);
                    Data_Nonce.Text = block.Nonce.ToString();
                    Data_PreviousHash.Text = block.PrevHash;
                    Data_Hash.Text = block.Hash;
                }
                else
                {

                    Block block = new Block()
                    {
                        Index = Convert.ToInt32(Data_No.Text) - 1,
                        data = Data.Text,
                        TimeStamp = times,
                        Hash = Data_PreviousHash.Text,
                        Difficulty = Data_Key
                    };
                    block = GenerateBlock(block, Data.Text, times, Data_Key);
                    Data_Nonce.Text = block.Nonce.ToString();
                    Data_PreviousHash.Text = block.PrevHash;
                    Data_Hash.Text = block.Hash;
                }
                MessageBox.Show("Mining finished!");
            
            
        }
        //查詢資料事件
        private void SearchData_Click(object sender, EventArgs e)
        {
            if (SearchDataNo.Text == ""|| IsNumeric(SearchDataNo.Text)==false)
            {
                MessageBox.Show("Please insert the number!");
                SearchDataNo.Text = "";
            }
            else
            {
                SearchOrUpdate = SearchDataNo.Text;
                SearchDataNo.Text = "";
                SearchAndUpdateData();
            }
        }
        //刪除資料事件
        private void DeleteData_Click(object sender, EventArgs e)
        {
            if (DeleteNo.Text == "" || IsNumeric(DeleteNo.Text)==false) {
                MessageBox.Show("Please insert the Number");
                DeleteNo.Text = "";
            }
            else
            {
                String strSQL = string.Format(" DELETE FROM MiningData WHERE No={0};", Convert.ToInt32(DeleteNo.Text));
                SqlCommand sqlcommand = new SqlCommand(strSQL, conn);
                sqlcommand.ExecuteNonQuery();
                MessageBox.Show(string.Format("The data of No={0} is Deleted!", DeleteNo.Text));
                DeleteNo.Text = ""; SearchOrUpdate = ""; SearchAndUpdateData();
            }
        }
        //點選資料欄位後將該筆資料內容顯示於對應文字框裡
        private void ShowDataBase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Roww = ShowDataBase.CurrentCell.RowIndex;
            int Columnn = ShowDataBase.CurrentCell.ColumnIndex;
            Data_No.Text = ShowDataBase.Rows[Roww].Cells[0].Value.ToString();
            Data_Nonce.Text = ShowDataBase.Rows[Roww].Cells[1].Value.ToString();
            Data_time.Text = ShowDataBase.Rows[Roww].Cells[2].Value.ToString();
            Data.Text = ShowDataBase.Rows[Roww].Cells[3].Value.ToString();
            Data_PreviousHash.Text = ShowDataBase.Rows[Roww].Cells[4].Value.ToString();
            Data_Hash.Text = ShowDataBase.Rows[Roww].Cells[5].Value.ToString();
        }
        //重新整理事件
        private void button1_Click(object sender, EventArgs e)
        {
            SearchOrUpdate = "";
            SearchAndUpdateData();
        }
        //離開事件
        private void Exit(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        //檢查區塊鏈資料庫的區塊鏈正確性
        private void CheckData_Click(object sender, EventArgs e)
        {
            if (Data_No.Text == "" || IsNumeric(Data_No.Text) == false || IsNumeric(Data_Nonce.Text) == false || Data_Hash.Text==""|| Data_PreviousHash.Text == "" && Data_No.Text != "0")
            {
                MessageBox.Show("輸入錯誤! 請檢查!!");
            }
            else
            {
                string times = Data_time.Value.Year.ToString() + "-" + Data_time.Value.Month.ToString() + "-" + Data_time.Value.Day.ToString() + " " +
                Data_time.Value.Hour.ToString() + ":" + Data_time.Value.Minute.ToString() + ":00";

                Block block = new Block()
                {
                    Index = Convert.ToInt32(Data_No.Text),
                    Nonce =Convert.ToInt32( Data_Nonce.Text),
                    TimeStamp = times,
                    data = Data.Text,
                    Hash = Data_Hash.Text,
                    PrevHash = (Data_No.Text == "0") ? "0" : Data_PreviousHash.Text,
                    Difficulty = Data_Key
                };
                string result = CalculateHash(block);
                if(block.Hash!=result||!IsHashValid(result,Data_Key))
                {
                    MessageBox.Show("The data was changed!");
                }
                else
                {
                    MessageBox.Show("The data is correct");
                }
            }
        }

        private void Data_time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Data_TextChanged(object sender, EventArgs e)
        {

        }

        private void Data_PreviousHash_TextChanged(object sender, EventArgs e)
        {

        }

        private void Data_Nonce_TextChanged(object sender, EventArgs e)
        {

        }

        private void Data_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Data_Hash_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //輸入困難度
        private void KeyBtn_Click(object sender, EventArgs e)
        {
            string getkey = Interaction.InputBox("Please insert the Difficultly");
            Data_Key = getkey;
        }
    }
}

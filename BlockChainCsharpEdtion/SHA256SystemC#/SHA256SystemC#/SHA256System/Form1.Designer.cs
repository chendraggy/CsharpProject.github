namespace SHA256System
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Data_No = new System.Windows.Forms.TextBox();
            this.Data = new System.Windows.Forms.TextBox();
            this.Data_Nonce = new System.Windows.Forms.TextBox();
            this.Data_PreviousHash = new System.Windows.Forms.TextBox();
            this.Data_Hash = new System.Windows.Forms.TextBox();
            this.Data_time = new System.Windows.Forms.DateTimePicker();
            this.SaveData = new System.Windows.Forms.Button();
            this.Mining = new System.Windows.Forms.Button();
            this.ShowDataBase = new System.Windows.Forms.DataGridView();
            this.SearchDataNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteData = new System.Windows.Forms.Button();
            this.DeleteNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.CheckData = new System.Windows.Forms.Button();
            this.KeyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(57, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(52, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nonce :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(45, 406);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "DateTime";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(45, 465);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Previous Hash";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(45, 609);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hash";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(52, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Data:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Data_No
            // 
            this.Data_No.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Data_No.Location = new System.Drawing.Point(231, 105);
            this.Data_No.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Data_No.Multiline = true;
            this.Data_No.Name = "Data_No";
            this.Data_No.Size = new System.Drawing.Size(683, 42);
            this.Data_No.TabIndex = 2;
            this.Data_No.TextChanged += new System.EventHandler(this.Data_No_TextChanged);
            // 
            // Data
            // 
            this.Data.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Data.Location = new System.Drawing.Point(231, 228);
            this.Data.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Data.Multiline = true;
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(683, 154);
            this.Data.TabIndex = 2;
            this.Data.TextChanged += new System.EventHandler(this.Data_TextChanged);
            // 
            // Data_Nonce
            // 
            this.Data_Nonce.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Data_Nonce.Location = new System.Drawing.Point(231, 168);
            this.Data_Nonce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Data_Nonce.Multiline = true;
            this.Data_Nonce.Name = "Data_Nonce";
            this.Data_Nonce.Size = new System.Drawing.Size(683, 42);
            this.Data_Nonce.TabIndex = 2;
            this.Data_Nonce.TextChanged += new System.EventHandler(this.Data_Nonce_TextChanged);
            // 
            // Data_PreviousHash
            // 
            this.Data_PreviousHash.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Data_PreviousHash.Location = new System.Drawing.Point(231, 456);
            this.Data_PreviousHash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Data_PreviousHash.Multiline = true;
            this.Data_PreviousHash.Name = "Data_PreviousHash";
            this.Data_PreviousHash.Size = new System.Drawing.Size(683, 99);
            this.Data_PreviousHash.TabIndex = 2;
            this.Data_PreviousHash.TextChanged += new System.EventHandler(this.Data_PreviousHash_TextChanged);
            // 
            // Data_Hash
            // 
            this.Data_Hash.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Data_Hash.Location = new System.Drawing.Point(231, 600);
            this.Data_Hash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Data_Hash.Multiline = true;
            this.Data_Hash.Name = "Data_Hash";
            this.Data_Hash.Size = new System.Drawing.Size(683, 102);
            this.Data_Hash.TabIndex = 2;
            this.Data_Hash.TextChanged += new System.EventHandler(this.Data_Hash_TextChanged);
            // 
            // Data_time
            // 
            this.Data_time.CustomFormat = "yyyy-MM-dd HH:mm";
            this.Data_time.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Data_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Data_time.Location = new System.Drawing.Point(231, 400);
            this.Data_time.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Data_time.Name = "Data_time";
            this.Data_time.Size = new System.Drawing.Size(285, 43);
            this.Data_time.TabIndex = 3;
            this.Data_time.ValueChanged += new System.EventHandler(this.Data_time_ValueChanged);
            // 
            // SaveData
            // 
            this.SaveData.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SaveData.Location = new System.Drawing.Point(478, 714);
            this.SaveData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(190, 57);
            this.SaveData.TabIndex = 4;
            this.SaveData.Text = "Save";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // Mining
            // 
            this.Mining.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Mining.Location = new System.Drawing.Point(230, 714);
            this.Mining.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Mining.Name = "Mining";
            this.Mining.Size = new System.Drawing.Size(195, 57);
            this.Mining.TabIndex = 5;
            this.Mining.Text = "Mining";
            this.Mining.UseVisualStyleBackColor = true;
            this.Mining.Click += new System.EventHandler(this.Mining_Click);
            // 
            // ShowDataBase
            // 
            this.ShowDataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowDataBase.Location = new System.Drawing.Point(937, 48);
            this.ShowDataBase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowDataBase.Name = "ShowDataBase";
            this.ShowDataBase.RowHeadersWidth = 82;
            this.ShowDataBase.RowTemplate.Height = 38;
            this.ShowDataBase.Size = new System.Drawing.Size(831, 595);
            this.ShowDataBase.TabIndex = 6;
            this.ShowDataBase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowDataBase_CellClick);
            // 
            // SearchDataNo
            // 
            this.SearchDataNo.Font = new System.Drawing.Font("新細明體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SearchDataNo.Location = new System.Drawing.Point(1286, 748);
            this.SearchDataNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchDataNo.Multiline = true;
            this.SearchDataNo.Name = "SearchDataNo";
            this.SearchDataNo.Size = new System.Drawing.Size(171, 36);
            this.SearchDataNo.TabIndex = 7;
            this.SearchDataNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(932, 748);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(329, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "Type No to search the Data";
            // 
            // SearchData
            // 
            this.SearchData.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SearchData.Location = new System.Drawing.Point(1476, 744);
            this.SearchData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchData.Name = "SearchData";
            this.SearchData.Size = new System.Drawing.Size(107, 38);
            this.SearchData.TabIndex = 9;
            this.SearchData.Text = "Find";
            this.SearchData.UseVisualStyleBackColor = true;
            this.SearchData.Click += new System.EventHandler(this.SearchData_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(1619, 669);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 113);
            this.button1.TabIndex = 10;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteData
            // 
            this.DeleteData.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DeleteData.Location = new System.Drawing.Point(1476, 669);
            this.DeleteData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteData.Name = "DeleteData";
            this.DeleteData.Size = new System.Drawing.Size(107, 41);
            this.DeleteData.TabIndex = 11;
            this.DeleteData.Text = "Delete";
            this.DeleteData.UseVisualStyleBackColor = true;
            this.DeleteData.Click += new System.EventHandler(this.DeleteData_Click);
            // 
            // DeleteNo
            // 
            this.DeleteNo.Font = new System.Drawing.Font("新細明體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DeleteNo.Location = new System.Drawing.Point(1286, 674);
            this.DeleteNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteNo.Multiline = true;
            this.DeleteNo.Name = "DeleteNo";
            this.DeleteNo.Size = new System.Drawing.Size(171, 36);
            this.DeleteNo.TabIndex = 12;
            this.DeleteNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(936, 674);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(325, 30);
            this.label8.TabIndex = 13;
            this.label8.Text = "Type No to delete the Data";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(17, 780);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 66);
            this.button2.TabIndex = 14;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Exit);
            // 
            // CheckData
            // 
            this.CheckData.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CheckData.Location = new System.Drawing.Point(718, 714);
            this.CheckData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckData.Name = "CheckData";
            this.CheckData.Size = new System.Drawing.Size(195, 57);
            this.CheckData.TabIndex = 15;
            this.CheckData.Text = "Check";
            this.CheckData.UseVisualStyleBackColor = true;
            this.CheckData.Click += new System.EventHandler(this.CheckData_Click);
            // 
            // KeyBtn
            // 
            this.KeyBtn.Font = new System.Drawing.Font("新細明體", 18F);
            this.KeyBtn.Location = new System.Drawing.Point(718, 793);
            this.KeyBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KeyBtn.Name = "KeyBtn";
            this.KeyBtn.Size = new System.Drawing.Size(195, 53);
            this.KeyBtn.TabIndex = 17;
            this.KeyBtn.Text = "Difficultly";
            this.KeyBtn.UseVisualStyleBackColor = true;
            this.KeyBtn.Click += new System.EventHandler(this.KeyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1794, 894);
            this.Controls.Add(this.KeyBtn);
            this.Controls.Add(this.CheckData);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DeleteNo);
            this.Controls.Add(this.DeleteData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SearchDataNo);
            this.Controls.Add(this.ShowDataBase);
            this.Controls.Add(this.Mining);
            this.Controls.Add(this.SaveData);
            this.Controls.Add(this.Data_time);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Data_Hash);
            this.Controls.Add(this.Data_PreviousHash);
            this.Controls.Add(this.Data_Nonce);
            this.Controls.Add(this.Data_No);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "MiningSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Data_No;
        private System.Windows.Forms.TextBox Data;
        private System.Windows.Forms.TextBox Data_Nonce;
        private System.Windows.Forms.TextBox Data_PreviousHash;
        private System.Windows.Forms.TextBox Data_Hash;
        private System.Windows.Forms.DateTimePicker Data_time;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.Button Mining;
        private System.Windows.Forms.DataGridView ShowDataBase;
        private System.Windows.Forms.TextBox SearchDataNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SearchData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteData;
        private System.Windows.Forms.TextBox DeleteNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CheckData;
        private System.Windows.Forms.Button KeyBtn;
    }
}



namespace pos_wpf
{
    partial class Selling
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
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selpay = new System.Windows.Forms.ComboBox();
            this.amountidr = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.selproddgv = new System.Windows.Forms.DataGridView();
            this.billdgv = new System.Windows.Forms.DataGridView();
            this.orderdgv = new System.Windows.Forms.DataGridView();
            this.selprodcat = new System.Windows.Forms.ComboBox();
            this.billqty = new System.Windows.Forms.TextBox();
            this.billprice = new System.Windows.Forms.TextBox();
            this.billprod = new System.Windows.Forms.TextBox();
            this.billid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selproddgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(118, 338);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(149, 23);
            this.button7.TabIndex = 25;
            this.button7.Text = "ADD PRODUCT";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(576, 642);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 31);
            this.button6.TabIndex = 24;
            this.button6.Text = "ADD";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(225, 381);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.selpay);
            this.panel1.Controls.Add(this.amountidr);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.selproddgv);
            this.panel1.Controls.Add(this.billdgv);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.orderdgv);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.selprodcat);
            this.panel1.Controls.Add(this.billqty);
            this.panel1.Controls.Add(this.billprice);
            this.panel1.Controls.Add(this.billprod);
            this.panel1.Controls.Add(this.billid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(129, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 690);
            this.panel1.TabIndex = 5;
            // 
            // selpay
            // 
            this.selpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selpay.FormattingEnabled = true;
            this.selpay.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.selpay.Location = new System.Drawing.Point(622, 296);
            this.selpay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selpay.Name = "selpay";
            this.selpay.Size = new System.Drawing.Size(202, 23);
            this.selpay.TabIndex = 33;
            this.selpay.Text = "SELECT PAYMENT METHOD";
            // 
            // amountidr
            // 
            this.amountidr.AutoSize = true;
            this.amountidr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amountidr.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.amountidr.Location = new System.Drawing.Point(484, 296);
            this.amountidr.Name = "amountidr";
            this.amountidr.Size = new System.Drawing.Size(41, 20);
            this.amountidr.TabIndex = 32;
            this.amountidr.Text = "IDR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(383, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(556, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Sells List";
            // 
            // selproddgv
            // 
            this.selproddgv.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.selproddgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selproddgv.Location = new System.Drawing.Point(27, 425);
            this.selproddgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selproddgv.Name = "selproddgv";
            this.selproddgv.RowHeadersWidth = 51;
            this.selproddgv.RowTemplate.Height = 25;
            this.selproddgv.Size = new System.Drawing.Size(315, 229);
            this.selproddgv.TabIndex = 29;
            // 
            // billdgv
            // 
            this.billdgv.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.billdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billdgv.Location = new System.Drawing.Point(383, 387);
            this.billdgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.billdgv.Name = "billdgv";
            this.billdgv.RowHeadersWidth = 51;
            this.billdgv.RowTemplate.Height = 25;
            this.billdgv.Size = new System.Drawing.Size(478, 226);
            this.billdgv.TabIndex = 28;
            // 
            // orderdgv
            // 
            this.orderdgv.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.orderdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderdgv.Location = new System.Drawing.Point(375, 78);
            this.orderdgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderdgv.Name = "orderdgv";
            this.orderdgv.RowHeadersWidth = 51;
            this.orderdgv.RowTemplate.Height = 25;
            this.orderdgv.Size = new System.Drawing.Size(486, 201);
            this.orderdgv.TabIndex = 5;
            // 
            // selprodcat
            // 
            this.selprodcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selprodcat.FormattingEnabled = true;
            this.selprodcat.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.selprodcat.Location = new System.Drawing.Point(51, 385);
            this.selprodcat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selprodcat.Name = "selprodcat";
            this.selprodcat.Size = new System.Drawing.Size(149, 23);
            this.selprodcat.TabIndex = 22;
            this.selprodcat.Text = "SELECT CATEGORY";
            // 
            // billqty
            // 
            this.billqty.BackColor = System.Drawing.Color.White;
            this.billqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.billqty.Location = new System.Drawing.Point(118, 223);
            this.billqty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.billqty.Name = "billqty";
            this.billqty.Size = new System.Drawing.Size(199, 21);
            this.billqty.TabIndex = 19;
            // 
            // billprice
            // 
            this.billprice.BackColor = System.Drawing.Color.White;
            this.billprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.billprice.Location = new System.Drawing.Point(118, 177);
            this.billprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.billprice.Name = "billprice";
            this.billprice.Size = new System.Drawing.Size(199, 21);
            this.billprice.TabIndex = 18;
            // 
            // billprod
            // 
            this.billprod.BackColor = System.Drawing.Color.White;
            this.billprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.billprod.Location = new System.Drawing.Point(118, 134);
            this.billprod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.billprod.Name = "billprod";
            this.billprod.Size = new System.Drawing.Size(199, 21);
            this.billprod.TabIndex = 17;
            // 
            // billid
            // 
            this.billid.BackColor = System.Drawing.Color.White;
            this.billid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.billid.Location = new System.Drawing.Point(118, 86);
            this.billid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.billid.Name = "billid";
            this.billid.Size = new System.Drawing.Size(199, 21);
            this.billid.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(35, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "QTY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(35, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "PRICE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(27, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "PR NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(35, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "BILL ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(324, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Selling";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Maroon;
            this.button4.Location = new System.Drawing.Point(12, 417);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 33);
            this.button4.TabIndex = 9;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(12, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "Products";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(12, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Category";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(12, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sellers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.Color.Maroon;
            this.button10.Location = new System.Drawing.Point(12, 216);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(96, 55);
            this.button10.TabIndex = 10;
            this.button10.Text = "Payment Method";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.Maroon;
            this.button9.Location = new System.Drawing.Point(12, 291);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(96, 34);
            this.button9.TabIndex = 11;
            this.button9.Text = "Report";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Selling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 712);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Selling";
            this.Text = "Selling";
            this.Load += new System.EventHandler(this.Selling_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selproddgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView orderdgv;
        private System.Windows.Forms.ComboBox selprodcat;
        private System.Windows.Forms.TextBox billqty;
        private System.Windows.Forms.TextBox billprice;
        private System.Windows.Forms.TextBox billprod;
        private System.Windows.Forms.TextBox billid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label amountidr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView selproddgv;
        private System.Windows.Forms.DataGridView billdgv;
        private System.Windows.Forms.ComboBox selpay;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
    }
}
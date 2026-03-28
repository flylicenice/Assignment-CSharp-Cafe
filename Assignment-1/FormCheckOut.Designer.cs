namespace Assignment_1
{
    partial class FormCheckOut
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.foodTextBox2 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backB = new System.Windows.Forms.Button();
            this.goB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.largeUdangCB = new System.Windows.Forms.CheckBox();
            this.smallUdangCB = new System.Windows.Forms.CheckBox();
            this.paymentBox = new System.Windows.Forms.GroupBox();
            this.bankingRB = new System.Windows.Forms.RadioButton();
            this.walletRB = new System.Windows.Forms.RadioButton();
            this.cashRB = new System.Windows.Forms.RadioButton();
            this.previousB = new System.Windows.Forms.Button();
            this.nextB = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.paymentBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Google Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(441, 300);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.foodTextBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(433, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Orders";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // foodTextBox2
            // 
            this.foodTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foodTextBox2.Location = new System.Drawing.Point(22, 29);
            this.foodTextBox2.Multiline = true;
            this.foodTextBox2.Name = "foodTextBox2";
            this.foodTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.foodTextBox2.Size = new System.Drawing.Size(250, 197);
            this.foodTextBox2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.backB);
            this.tabPage2.Controls.Add(this.goB);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(433, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Side Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(253, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 244);
            this.panel2.TabIndex = 1;
            // 
            // backB
            // 
            this.backB.Font = new System.Drawing.Font("Google Sans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backB.Location = new System.Drawing.Point(212, 137);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(35, 35);
            this.backB.TabIndex = 1;
            this.backB.Text = "<<";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // goB
            // 
            this.goB.Font = new System.Drawing.Font("Google Sans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goB.Location = new System.Drawing.Point(212, 70);
            this.goB.Name = "goB";
            this.goB.Size = new System.Drawing.Size(35, 35);
            this.goB.TabIndex = 0;
            this.goB.Text = ">>";
            this.goB.UseVisualStyleBackColor = true;
            this.goB.Click += new System.EventHandler(this.goB_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.largeUdangCB);
            this.panel1.Controls.Add(this.smallUdangCB);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 244);
            this.panel1.TabIndex = 0;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(12, 173);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(93, 20);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Cucur Manis";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(12, 142);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(89, 20);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Cucur Labu";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(12, 111);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(94, 20);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Cucur Pisang";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(12, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Cucur Bawang and Bilis";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // largeUdangCB
            // 
            this.largeUdangCB.AutoSize = true;
            this.largeUdangCB.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeUdangCB.Location = new System.Drawing.Point(12, 49);
            this.largeUdangCB.Name = "largeUdangCB";
            this.largeUdangCB.Size = new System.Drawing.Size(136, 20);
            this.largeUdangCB.TabIndex = 1;
            this.largeUdangCB.Text = "Cucur Udang (Large)";
            this.largeUdangCB.UseVisualStyleBackColor = true;
            // 
            // smallUdangCB
            // 
            this.smallUdangCB.AutoSize = true;
            this.smallUdangCB.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallUdangCB.Location = new System.Drawing.Point(12, 17);
            this.smallUdangCB.Name = "smallUdangCB";
            this.smallUdangCB.Size = new System.Drawing.Size(137, 20);
            this.smallUdangCB.TabIndex = 0;
            this.smallUdangCB.Text = "Cucur Udang (Small)";
            this.smallUdangCB.UseVisualStyleBackColor = true;
            // 
            // paymentBox
            // 
            this.paymentBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paymentBox.Controls.Add(this.bankingRB);
            this.paymentBox.Controls.Add(this.walletRB);
            this.paymentBox.Controls.Add(this.cashRB);
            this.paymentBox.Font = new System.Drawing.Font("Google Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentBox.Location = new System.Drawing.Point(459, 52);
            this.paymentBox.Name = "paymentBox";
            this.paymentBox.Size = new System.Drawing.Size(200, 172);
            this.paymentBox.TabIndex = 1;
            this.paymentBox.TabStop = false;
            this.paymentBox.Text = "Payment Mode";
            // 
            // bankingRB
            // 
            this.bankingRB.AutoSize = true;
            this.bankingRB.Location = new System.Drawing.Point(15, 122);
            this.bankingRB.Name = "bankingRB";
            this.bankingRB.Size = new System.Drawing.Size(92, 35);
            this.bankingRB.TabIndex = 2;
            this.bankingRB.TabStop = true;
            this.bankingRB.Text = "e-Banking";
            this.bankingRB.UseVisualStyleBackColor = true;
            // 
            // walletRB
            // 
            this.walletRB.AutoSize = true;
            this.walletRB.Location = new System.Drawing.Point(15, 81);
            this.walletRB.Name = "walletRB";
            this.walletRB.Size = new System.Drawing.Size(81, 35);
            this.walletRB.TabIndex = 1;
            this.walletRB.TabStop = true;
            this.walletRB.Text = "e-Wallet";
            this.walletRB.UseVisualStyleBackColor = true;
            // 
            // cashRB
            // 
            this.cashRB.AutoSize = true;
            this.cashRB.Location = new System.Drawing.Point(15, 40);
            this.cashRB.Name = "cashRB";
            this.cashRB.Size = new System.Drawing.Size(62, 35);
            this.cashRB.TabIndex = 0;
            this.cashRB.TabStop = true;
            this.cashRB.Text = "Cash";
            this.cashRB.UseVisualStyleBackColor = true;
            // 
            // previousB
            // 
            this.previousB.Font = new System.Drawing.Font("Google Sans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousB.Location = new System.Drawing.Point(459, 271);
            this.previousB.Name = "previousB";
            this.previousB.Size = new System.Drawing.Size(88, 37);
            this.previousB.TabIndex = 2;
            this.previousB.Text = "Previous";
            this.previousB.UseVisualStyleBackColor = true;
            this.previousB.Click += new System.EventHandler(this.previousB_Click);
            // 
            // nextB
            // 
            this.nextB.Font = new System.Drawing.Font("Google Sans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextB.Location = new System.Drawing.Point(571, 271);
            this.nextB.Name = "nextB";
            this.nextB.Size = new System.Drawing.Size(88, 37);
            this.nextB.TabIndex = 3;
            this.nextB.Text = "Next";
            this.nextB.UseVisualStyleBackColor = true;
            this.nextB.Click += new System.EventHandler(this.nextB_Click);
            // 
            // FormCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 336);
            this.Controls.Add(this.nextB);
            this.Controls.Add(this.previousB);
            this.Controls.Add(this.paymentBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormCheckOut";
            this.Text = "FormCheckOut";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.paymentBox.ResumeLayout(false);
            this.paymentBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox foodTextBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox paymentBox;
        private System.Windows.Forms.RadioButton bankingRB;
        private System.Windows.Forms.RadioButton walletRB;
        private System.Windows.Forms.RadioButton cashRB;
        private System.Windows.Forms.Button previousB;
        private System.Windows.Forms.Button nextB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backB;
        private System.Windows.Forms.Button goB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox smallUdangCB;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox largeUdangCB;
    }
}
namespace Assignment_1
{
    partial class CSharpCafe
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
            this.previousBtn = new System.Windows.Forms.Button();
            this.cafePic = new System.Windows.Forms.PictureBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bgcolorBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.passwdBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.showChkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.cafePic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // previousBtn
            // 
            this.previousBtn.Font = new System.Drawing.Font("Google Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousBtn.ForeColor = System.Drawing.Color.Black;
            this.previousBtn.Location = new System.Drawing.Point(24, 410);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(95, 33);
            this.previousBtn.TabIndex = 0;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // cafePic
            // 
            this.cafePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cafePic.Location = new System.Drawing.Point(24, 94);
            this.cafePic.Name = "cafePic";
            this.cafePic.Size = new System.Drawing.Size(300, 300);
            this.cafePic.TabIndex = 1;
            this.cafePic.TabStop = false;
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Google Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.Color.Black;
            this.nextBtn.Location = new System.Drawing.Point(229, 410);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(95, 33);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to C Sharp Cafe!";
            // 
            // bgcolorBtn
            // 
            this.bgcolorBtn.Font = new System.Drawing.Font("Google Sans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgcolorBtn.Location = new System.Drawing.Point(521, 21);
            this.bgcolorBtn.Name = "bgcolorBtn";
            this.bgcolorBtn.Size = new System.Drawing.Size(124, 31);
            this.bgcolorBtn.TabIndex = 5;
            this.bgcolorBtn.Text = "Change Background";
            this.bgcolorBtn.UseVisualStyleBackColor = true;
            this.bgcolorBtn.Click += new System.EventHandler(this.bgcolorBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Google Sans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(651, 21);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(124, 31);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showChkBox);
            this.panel1.Controls.Add(this.commentBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.passwdBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.usernameBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(374, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 300);
            this.panel1.TabIndex = 8;
            // 
            // commentBox
            // 
            this.commentBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.commentBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.commentBox.Font = new System.Drawing.Font("Google Sans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentBox.Location = new System.Drawing.Point(121, 183);
            this.commentBox.Margin = new System.Windows.Forms.Padding(0);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(262, 93);
            this.commentBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 38);
            this.label4.TabIndex = 11;
            this.label4.Text = "Comments";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Google Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.Black;
            this.loginBtn.Location = new System.Drawing.Point(226, 128);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(95, 33);
            this.loginBtn.TabIndex = 10;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Google Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.Location = new System.Drawing.Point(121, 128);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(95, 33);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // passwdBox
            // 
            this.passwdBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.passwdBox.Font = new System.Drawing.Font("Google Sans", 10F);
            this.passwdBox.Location = new System.Drawing.Point(121, 81);
            this.passwdBox.Margin = new System.Windows.Forms.Padding(0);
            this.passwdBox.Name = "passwdBox";
            this.passwdBox.Size = new System.Drawing.Size(180, 24);
            this.passwdBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.usernameBox.Font = new System.Drawing.Font("Google Sans", 10F);
            this.usernameBox.Location = new System.Drawing.Point(121, 22);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(0);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(262, 24);
            this.usernameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showChkBox
            // 
            this.showChkBox.AutoSize = true;
            this.showChkBox.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showChkBox.Location = new System.Drawing.Point(316, 86);
            this.showChkBox.Name = "showChkBox";
            this.showChkBox.Size = new System.Drawing.Size(55, 17);
            this.showChkBox.TabIndex = 13;
            this.showChkBox.Text = "Show";
            this.showChkBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showChkBox.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.showChkBox.UseVisualStyleBackColor = true;
            this.showChkBox.CheckedChanged += new System.EventHandler(this.showChkBox_CheckedChanged);
            // 
            // CSharpCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.bgcolorBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.cafePic);
            this.Controls.Add(this.previousBtn);
            this.Name = "CSharpCafe";
            this.Text = "C# Cafe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cafePic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.PictureBox cafePic;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bgcolorBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwdBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.CheckBox showChkBox;
    }
}


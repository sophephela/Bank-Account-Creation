
namespace Bank_Account_Creation
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fnameTxb = new System.Windows.Forms.TextBox();
            this.emailTxb = new System.Windows.Forms.TextBox();
            this.phoneTxb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addRtxb = new System.Windows.Forms.RichTextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.openAccpountBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank_Account_Creation.Properties.Resources.image1;
            this.pictureBox1.Location = new System.Drawing.Point(552, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(370, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "FullNames";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(370, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(370, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone";
            // 
            // fnameTxb
            // 
            this.fnameTxb.Location = new System.Drawing.Point(552, 236);
            this.fnameTxb.Name = "fnameTxb";
            this.fnameTxb.Size = new System.Drawing.Size(100, 29);
            this.fnameTxb.TabIndex = 5;
            // 
            // emailTxb
            // 
            this.emailTxb.Location = new System.Drawing.Point(552, 279);
            this.emailTxb.Name = "emailTxb";
            this.emailTxb.Size = new System.Drawing.Size(100, 29);
            this.emailTxb.TabIndex = 6;
            // 
            // phoneTxb
            // 
            this.phoneTxb.Location = new System.Drawing.Point(552, 339);
            this.phoneTxb.Name = "phoneTxb";
            this.phoneTxb.Size = new System.Drawing.Size(100, 29);
            this.phoneTxb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(374, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // addRtxb
            // 
            this.addRtxb.Location = new System.Drawing.Point(539, 391);
            this.addRtxb.Name = "addRtxb";
            this.addRtxb.Size = new System.Drawing.Size(209, 63);
            this.addRtxb.TabIndex = 9;
            this.addRtxb.Text = "";
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Red;
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(459, 586);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(193, 32);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // openAccpountBtn
            // 
            this.openAccpountBtn.BackColor = System.Drawing.Color.Navy;
            this.openAccpountBtn.ForeColor = System.Drawing.Color.White;
            this.openAccpountBtn.Location = new System.Drawing.Point(749, 586);
            this.openAccpountBtn.Name = "openAccpountBtn";
            this.openAccpountBtn.Size = new System.Drawing.Size(216, 32);
            this.openAccpountBtn.TabIndex = 11;
            this.openAccpountBtn.Text = "Open account";
            this.openAccpountBtn.UseVisualStyleBackColor = false;
            this.openAccpountBtn.Click += new System.EventHandler(this.openAccpountBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(372, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "DOB";
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(539, 474);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(200, 29);
            this.dobPicker.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 762);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.openAccpountBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addRtxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneTxb);
            this.Controls.Add(this.emailTxb);
            this.Controls.Add(this.fnameTxb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Create Account";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fnameTxb;
        private System.Windows.Forms.TextBox emailTxb;
        private System.Windows.Forms.TextBox phoneTxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox addRtxb;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button openAccpountBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dobPicker;
    }
}


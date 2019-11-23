namespace CecilioNolenAuditReview
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Username_Txt = new System.Windows.Forms.TextBox();
            this.Password_Txt = new System.Windows.Forms.TextBox();
            this.LoginSubmit_Btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LoginSubmit_Btn);
            this.panel1.Controls.Add(this.Password_Txt);
            this.panel1.Controls.Add(this.Username_Txt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 190);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login";
            // 
            // Username_Txt
            // 
            this.Username_Txt.Location = new System.Drawing.Point(116, 47);
            this.Username_Txt.Name = "Username_Txt";
            this.Username_Txt.Size = new System.Drawing.Size(215, 22);
            this.Username_Txt.TabIndex = 3;
            // 
            // Password_Txt
            // 
            this.Password_Txt.Location = new System.Drawing.Point(116, 92);
            this.Password_Txt.Name = "Password_Txt";
            this.Password_Txt.Size = new System.Drawing.Size(215, 22);
            this.Password_Txt.TabIndex = 4;
            // 
            // LoginSubmit_Btn
            // 
            this.LoginSubmit_Btn.Location = new System.Drawing.Point(256, 137);
            this.LoginSubmit_Btn.Name = "LoginSubmit_Btn";
            this.LoginSubmit_Btn.Size = new System.Drawing.Size(75, 23);
            this.LoginSubmit_Btn.TabIndex = 5;
            this.LoginSubmit_Btn.Text = "Submit";
            this.LoginSubmit_Btn.UseVisualStyleBackColor = true;
            this.LoginSubmit_Btn.Click += new System.EventHandler(this.LoginSubmit_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 745);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LoginSubmit_Btn;
        private System.Windows.Forms.TextBox Password_Txt;
        private System.Windows.Forms.TextBox Username_Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


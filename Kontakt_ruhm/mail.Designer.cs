
namespace Kontakt_ruhm
{
    partial class mail
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
            this.SentBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.AddFileBtn = new System.Windows.Forms.Button();
            this.CBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kellele:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Alef", 14.25F);
            this.label2.Location = new System.Drawing.Point(23, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teema:";
            // 
            // SentBtn
            // 
            this.SentBtn.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentBtn.Location = new System.Drawing.Point(12, 211);
            this.SentBtn.Name = "SentBtn";
            this.SentBtn.Size = new System.Drawing.Size(105, 91);
            this.SentBtn.TabIndex = 2;
            this.SentBtn.Text = "Saada";
            this.SentBtn.UseVisualStyleBackColor = true;
            this.SentBtn.Click += new System.EventHandler(this.SentBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 129);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(529, 33);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 212);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(529, 90);
            this.textBox3.TabIndex = 5;
            // 
            // AddFileBtn
            // 
            this.AddFileBtn.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFileBtn.Location = new System.Drawing.Point(526, 55);
            this.AddFileBtn.Name = "AddFileBtn";
            this.AddFileBtn.Size = new System.Drawing.Size(145, 39);
            this.AddFileBtn.TabIndex = 10;
            this.AddFileBtn.Text = "Pane faili";
            this.AddFileBtn.UseVisualStyleBackColor = true;
            // 
            // CBox2
            // 
            this.CBox2.FormattingEnabled = true;
            this.CBox2.Location = new System.Drawing.Point(142, 55);
            this.CBox2.Name = "CBox2";
            this.CBox2.Size = new System.Drawing.Size(195, 21);
            this.CBox2.TabIndex = 12;
            // 
            // mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 340);
            this.Controls.Add(this.CBox2);
            this.Controls.Add(this.AddFileBtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SentBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mail";
            this.Text = "mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SentBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button AddFileBtn;
        private System.Windows.Forms.ComboBox CBox2;
    }
}
namespace Kontakt_ruhm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kontaktAndmedDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kontaktAndmedDataSet = new Kontakt_ruhm.KontaktAndmedDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lisa_button = new System.Windows.Forms.Button();
            this.muuda_button = new System.Windows.Forms.Button();
            this.kustuta_button = new System.Windows.Forms.Button();
            this.Nimitxt = new System.Windows.Forms.TextBox();
            this.Telefontxt = new System.Windows.Forms.TextBox();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Fototxt = new System.Windows.Forms.TextBox();
            this.lisa_pilt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Telefon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktAndmedDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktAndmedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // kontaktAndmedDataSetBindingSource
            // 
            this.kontaktAndmedDataSetBindingSource.DataSource = this.kontaktAndmedDataSet;
            this.kontaktAndmedDataSetBindingSource.Position = 0;
            // 
            // kontaktAndmedDataSet
            // 
            this.kontaktAndmedDataSet.DataSetName = "KontaktAndmedDataSet";
            this.kontaktAndmedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(415, 254);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lisa_button
            // 
            this.lisa_button.Location = new System.Drawing.Point(12, 248);
            this.lisa_button.Name = "lisa_button";
            this.lisa_button.Size = new System.Drawing.Size(71, 27);
            this.lisa_button.TabIndex = 2;
            this.lisa_button.Text = "Lisa";
            this.lisa_button.UseVisualStyleBackColor = true;
            this.lisa_button.Click += new System.EventHandler(this.lisa_button_Click);
            // 
            // muuda_button
            // 
            this.muuda_button.Location = new System.Drawing.Point(12, 304);
            this.muuda_button.Name = "muuda_button";
            this.muuda_button.Size = new System.Drawing.Size(71, 27);
            this.muuda_button.TabIndex = 3;
            this.muuda_button.Text = "Muuda";
            this.muuda_button.UseVisualStyleBackColor = true;
            this.muuda_button.Click += new System.EventHandler(this.muuda_button_Click);
            // 
            // kustuta_button
            // 
            this.kustuta_button.Location = new System.Drawing.Point(12, 356);
            this.kustuta_button.Name = "kustuta_button";
            this.kustuta_button.Size = new System.Drawing.Size(71, 27);
            this.kustuta_button.TabIndex = 4;
            this.kustuta_button.Text = "Kustuta";
            this.kustuta_button.UseVisualStyleBackColor = true;
            this.kustuta_button.Click += new System.EventHandler(this.kustuta_button_Click);
            // 
            // Nimitxt
            // 
            this.Nimitxt.Location = new System.Drawing.Point(178, 248);
            this.Nimitxt.Name = "Nimitxt";
            this.Nimitxt.Size = new System.Drawing.Size(114, 20);
            this.Nimitxt.TabIndex = 5;
            // 
            // Telefontxt
            // 
            this.Telefontxt.Location = new System.Drawing.Point(178, 311);
            this.Telefontxt.Name = "Telefontxt";
            this.Telefontxt.Size = new System.Drawing.Size(114, 20);
            this.Telefontxt.TabIndex = 6;
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(178, 363);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(114, 20);
            this.Emailtxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vali rühm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(415, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Andmete otsing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(653, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 426);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Fototxt
            // 
            this.Fototxt.Location = new System.Drawing.Point(178, 418);
            this.Fototxt.Name = "Fototxt";
            this.Fototxt.Size = new System.Drawing.Size(114, 20);
            this.Fototxt.TabIndex = 12;
            // 
            // lisa_pilt
            // 
            this.lisa_pilt.Location = new System.Drawing.Point(12, 411);
            this.lisa_pilt.Name = "lisa_pilt";
            this.lisa_pilt.Size = new System.Drawing.Size(71, 27);
            this.lisa_pilt.TabIndex = 13;
            this.lisa_pilt.Text = "Lisa Pilt";
            this.lisa_pilt.UseVisualStyleBackColor = true;
            this.lisa_pilt.Click += new System.EventHandler(this.lisa_pilt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nimi";
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(128, 314);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(43, 13);
            this.Telefon.TabIndex = 15;
            this.Telefon.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Pilti nimi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lisa_pilt);
            this.Controls.Add(this.Fototxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Telefontxt);
            this.Controls.Add(this.Nimitxt);
            this.Controls.Add(this.kustuta_button);
            this.Controls.Add(this.muuda_button);
            this.Controls.Add(this.lisa_button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Kontaktandmed klassijuhataja jaoks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktAndmedDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktAndmedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kontaktAndmedDataSetBindingSource;
        private KontaktAndmedDataSet kontaktAndmedDataSet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button lisa_button;
        private System.Windows.Forms.Button muuda_button;
        private System.Windows.Forms.Button kustuta_button;
        private System.Windows.Forms.TextBox Nimitxt;
        private System.Windows.Forms.TextBox Telefontxt;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Fototxt;
        private System.Windows.Forms.Button lisa_pilt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


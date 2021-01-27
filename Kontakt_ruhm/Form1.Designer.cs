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
            this.otsingTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lisa_pilt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Telefon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.kontaktAndmedDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.naitaVanem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Eesnimitxt = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktAndmedDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktAndmedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktAndmedDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(950, 199);
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
            this.comboBox1.Location = new System.Drawing.Point(391, 240);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lisa_button
            // 
            this.lisa_button.Location = new System.Drawing.Point(3, 453);
            this.lisa_button.Name = "lisa_button";
            this.lisa_button.Size = new System.Drawing.Size(71, 27);
            this.lisa_button.TabIndex = 2;
            this.lisa_button.Text = "Lisa";
            this.lisa_button.UseVisualStyleBackColor = true;
            this.lisa_button.Click += new System.EventHandler(this.lisa_button_Click);
            // 
            // muuda_button
            // 
            this.muuda_button.Location = new System.Drawing.Point(96, 453);
            this.muuda_button.Name = "muuda_button";
            this.muuda_button.Size = new System.Drawing.Size(71, 27);
            this.muuda_button.TabIndex = 3;
            this.muuda_button.Text = "Muuda";
            this.muuda_button.UseVisualStyleBackColor = true;
            this.muuda_button.Click += new System.EventHandler(this.muuda_button_Click);
            // 
            // kustuta_button
            // 
            this.kustuta_button.Location = new System.Drawing.Point(188, 453);
            this.kustuta_button.Name = "kustuta_button";
            this.kustuta_button.Size = new System.Drawing.Size(71, 27);
            this.kustuta_button.TabIndex = 4;
            this.kustuta_button.Text = "Kustuta";
            this.kustuta_button.UseVisualStyleBackColor = true;
            this.kustuta_button.Click += new System.EventHandler(this.kustuta_button_Click);
            // 
            // Nimitxt
            // 
            this.Nimitxt.Location = new System.Drawing.Point(108, 245);
            this.Nimitxt.Name = "Nimitxt";
            this.Nimitxt.Size = new System.Drawing.Size(114, 20);
            this.Nimitxt.TabIndex = 5;
            // 
            // Telefontxt
            // 
            this.Telefontxt.Location = new System.Drawing.Point(108, 318);
            this.Telefontxt.Name = "Telefontxt";
            this.Telefontxt.Size = new System.Drawing.Size(114, 20);
            this.Telefontxt.TabIndex = 6;
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(108, 353);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(114, 20);
            this.Emailtxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vali rühm";
            // 
            // otsingTxt
            // 
            this.otsingTxt.Location = new System.Drawing.Point(739, 217);
            this.otsingTxt.Name = "otsingTxt";
            this.otsingTxt.Size = new System.Drawing.Size(108, 20);
            this.otsingTxt.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Andmete otsing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(642, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lisa_pilt
            // 
            this.lisa_pilt.Location = new System.Drawing.Point(282, 453);
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
            this.label2.Location = new System.Drawing.Point(17, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nimi";
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(12, 325);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(43, 13);
            this.Telefon.TabIndex = 15;
            this.Telefon.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Email";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(442, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 33);
            this.button2.TabIndex = 18;
            this.button2.Text = "Saada Maili";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kontaktAndmedDataSetBindingSource1
            // 
            this.kontaktAndmedDataSetBindingSource1.DataSource = this.kontaktAndmedDataSet;
            this.kontaktAndmedDataSetBindingSource1.Position = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(486, 215);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Näita vanemad";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(391, 280);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Vali sünipäev";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Näita vanemad";
            // 
            // naitaVanem
            // 
            this.naitaVanem.Location = new System.Drawing.Point(388, 322);
            this.naitaVanem.Name = "naitaVanem";
            this.naitaVanem.Size = new System.Drawing.Size(114, 20);
            this.naitaVanem.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Perekonnanimi";
            // 
            // Eesnimitxt
            // 
            this.Eesnimitxt.Location = new System.Drawing.Point(108, 280);
            this.Eesnimitxt.Name = "Eesnimitxt";
            this.Eesnimitxt.Size = new System.Drawing.Size(114, 20);
            this.Eesnimitxt.TabIndex = 27;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(388, 359);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(92, 17);
            this.checkBox2.TabIndex = 28;
            this.checkBox2.Text = "Lisa vanemad";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 584);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.Eesnimitxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.naitaVanem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lisa_pilt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.otsingTxt);
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
            ((System.ComponentModel.ISupportInitialize)(this.kontaktAndmedDataSetBindingSource1)).EndInit();
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
        private System.Windows.Forms.TextBox otsingTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button lisa_pilt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource kontaktAndmedDataSetBindingSource1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox naitaVanem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Eesnimitxt;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}


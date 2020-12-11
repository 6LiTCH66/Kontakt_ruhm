using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontakt_ruhm
{
    public partial class Form1 : Form
    {
        SaveFileDialog save;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AppData\KontaktAndmed.mdf;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter, adapter2;
        int Id;
        public Form1()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            connection.Open();
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM dbo.Kontakt", connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            adapter2 = new SqlDataAdapter("SELECT Ruhm FROM Ruhm", connection);
            DataTable kat_table = new DataTable();
            adapter2.Fill(kat_table);


            foreach (DataRow row in kat_table.Rows)
            {
                comboBox1.Items.Add(row["Ruhm"]);
            }

            connection.Close();
        }
        private void ClearData()
        {
            Id = 0;
            Nimitxt.Text = "";
            Telefontxt.Text = "";
            Emailtxt.Text = "";
            Fototxt.Text = "";
            comboBox1.SelectedItem = null;

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Nimitxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Telefontxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Emailtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            try
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\opilane\source\repos\Kontakt_ruhm\Kontakt_ruhm\Images\" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                Fototxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (FileNotFoundException)
            {

            }
            
            string v = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBox1.SelectedIndex = Int32.Parse(v) - 1;
        }

        private void lisa_pilt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            open.InitialDirectory = Path.GetDirectoryName(@"Desktop");
            if (open.ShowDialog() == DialogResult.OK)
            {

                save = new SaveFileDialog();
                save.FileName = Nimitxt.Text + ".jpg";
                save.Filter = "Image Files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                save.InitialDirectory = Path.GetDirectoryName(@"C:\Users\opilane\source\repos\Kontakt_ruhm\Kontakt_ruhm\Images\");
                if (save.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(open.FileName, save.FileName);
                    save.RestoreDirectory = true;
                    pictureBox1.Image = Image.FromFile(save.FileName);
                }


            }
        }

        private void muuda_button_Click(object sender, EventArgs e)
        {
            if (Nimitxt.Text != "" && Telefontxt.Text != "" && Emailtxt.Text != "")
            {
                command = new SqlCommand("UPDATE Kontakt SET nimi=@nimi, telefon=@telefon, email=@email, foto=@foto, ruhm_id=@ruhm WHERE Id=@id", connection);
                connection.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@nimi", Nimitxt.Text);
                command.Parameters.AddWithValue("@telefon", Telefontxt.Text);
                command.Parameters.AddWithValue("@email", Emailtxt.Text);
                string file_pilt = Nimitxt.Text + ".jpg";
                command.Parameters.AddWithValue("@foto", file_pilt);
                command.Parameters.AddWithValue("@ruhm", (comboBox1.SelectedIndex + 1));
                command.ExecuteNonQuery();
                connection.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed uuendatud");
            }
        }

        private void kustuta_button_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                command = new SqlCommand("DELETE FROM Kontakt WHERE Id=@id", connection);

                connection.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.ExecuteNonQuery();
                connection.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed uuendatud");
            }
            else
            {
                MessageBox.Show("Viga!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lisa_button_Click(object sender, EventArgs e)
        {
            if (Nimitxt.Text != "" && Telefontxt.Text != "" && Emailtxt.Text != "" && comboBox1.SelectedItem != null)
            {
                try
                {
                    command = new SqlCommand("INSERT INTO Kontakt(nimi, telefon, email, foto, ruhm_id) VALUES(@nimi, @telefon, @email, @foto, @ruh)", connection);
                    
                    connection.Open();
                    command.Parameters.AddWithValue("@nimi", Nimitxt.Text);
                    command.Parameters.AddWithValue("@telefon", Telefontxt.Text);
                    command.Parameters.AddWithValue("@email", Emailtxt.Text);
                    string file_pilt = Nimitxt.Text + ".jpg";
                    command.Parameters.AddWithValue("@foto", file_pilt);
                    command.Parameters.AddWithValue("@ruh", (comboBox1.SelectedIndex + 1));
                    command.ExecuteNonQuery();
                    connection.Close();
                    DisplayData();
                    ClearData();
                    MessageBox.Show("Andmed on lisatud");

                }
                catch (Exception)
                {

                }
            }
            else
            {
                MessageBox.Show("Viga!");
            }
        }

    }
}

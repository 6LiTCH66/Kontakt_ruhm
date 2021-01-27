using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontakt_ruhm
{
    public partial class mail : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Game\Source\Repos\Kontakt_ruhm\Kontakt_ruhm\AppData\KontaktAndmed.mdf;Integrated Security=True");
        SqlDataAdapter adapter2;
        public mail(CheckBox check)
        {
            InitializeComponent();


            if (check.Checked)
            {
                connection.Open();

                adapter2 = new SqlDataAdapter("SELECT email FROM Vanemad", connection);

                DataTable kat_table = new DataTable();
                adapter2.Fill(kat_table);

                CBox2.Items.Clear();
                foreach (DataRow row in kat_table.Rows)
                {
                    CBox2.Items.Add(row["email"]);
                }

                connection.Close();
            }
            else
            {
                connection.Open();

                adapter2 = new SqlDataAdapter("SELECT email FROM Kontakt", connection);

                DataTable kat_table = new DataTable();
                adapter2.Fill(kat_table);

                CBox2.Items.Clear();
                foreach (DataRow row in kat_table.Rows)
                {
                    CBox2.Items.Add(row["email"]);
                }

                connection.Close();
            }

        }

        public void Maili_saada()
        {

            string adress = CBox2.SelectedItem.ToString(); ;
            string Salasona = System.IO.File.ReadAllText(@"C:\Users\Game\Desktop\Password.txt");

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new System.Net.NetworkCredential("iljaharbi@gmail.com", Salasona),
                    EnableSsl = true
                };

                mail.From = new MailAddress("iljaharbi@gmail.com");
                mail.To.Add(adress);
                if (textBox2.Text != "")
                {
                    mail.Subject = textBox2.Text;
                }
                else
                {
                    MessageBox.Show("Sissesta teema!!!!");
                }

                if (textBox3.Text != "")
                {
                    mail.Body = textBox3.Text;
                }
                else
                {
                    MessageBox.Show("Sissesta kirja sisu!");
                }

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(@"../../Avaldus.txt");
                mail.Attachments.Add(attachment);

                smtpClient.Send(mail);

                MessageBox.Show("Kiri oli saadetud mailile: " + adress);
            }

            catch(Exception)
            {
                MessageBox.Show("Viga");
            }
        }





        private void SentBtn_Click(object sender, EventArgs e)
        {
            Maili_saada();
        }


    }
}

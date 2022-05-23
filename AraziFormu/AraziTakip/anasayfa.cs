using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using Button = System.Windows.Forms.Button;
using System.Runtime.InteropServices;

namespace AraziTakip
{
    public partial class anasayfa : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public anasayfa()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\AraziDB.mdb";
        }
        DataTable DT = new DataTable();
        DataTable DTfull = new DataTable();
        public int transfer;
        public string aktar;
        //dgvPersonel Verileri Listeleme
        void PersonelListele()
        {
            try
            {
                connection.Open();
                OleDbDataAdapter DA = new OleDbDataAdapter("select *from PersonelDb ORDER BY Id", connection);
                DA.Fill(DT);
                dgvPersonel.DataSource = DT;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Personel Bağlantısı Kurulamadı..." + ex);
            }
        }

        void gorevlistele()
        {
            connection.Open();
            OleDbDataAdapter DA = new OleDbDataAdapter("select *from gorevTanim ORDER BY IdHead", connection);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            dataGridView1.DataSource = DT;
            connection.Close();

        }

        //Araç bilgiler listeleme
        void aracListele()
        {
            try
            {
                connection.Open();
                DataTable DT = new DataTable();
                OleDbDataAdapter DA = new OleDbDataAdapter("select *from arac ORDER BY Id", connection);
                DA.Fill(DT);
                dgvArac.DataSource = DT;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Personel Bağlantısı Kurulamadı..." + ex);
            }
        }

        void aracgonder()
        {
            connection.Open();
            OleDbCommand cmd2 = new OleDbCommand("Select ID, (Arac) as fullname from arac", connection);
            OleDbDataAdapter DA2 = new OleDbDataAdapter(cmd2);
            DataTable dt3 = new DataTable();
            DA2.Fill(dt3);
            aracfull.DataSource = dt3;
            aracfull.DisplayMember = "fullname";
            aracfull.ValueMember = "Id";
            connection.Close();
        }

        //Ad ve Soyad Birleştirip Comboboxa Aktarma İşlemi (Amir için İçin)
        void surucubirlestir()
        {
            connection.Open();
            OleDbCommand cmd3 = new OleDbCommand("Select Id, (Ad + ' ' + Soyad + ' ' + '-' + ' ' + SicilNo + ' ' + '-' + ' ' + Birim) as fullname from PersonelDb", connection);
            OleDbDataAdapter DA2 = new OleDbDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            DA2.Fill(dt3);
            surucufull.DataSource = dt3;
            surucufull.DisplayMember = "fullname";
            surucufull.ValueMember = "Id";
            connection.Close();
        }

        //Ad ve Soyad Birleştirip Comboboxa Aktarma İşlemi (Amir için İçin)
        void birlestirAmir()
        {
            connection.Open();
            OleDbCommand cmd2 = new OleDbCommand("Select Id, (Ad + ' ' + Soyad + ' ' + '-' + ' ' + SicilNo + ' ' + '-' + ' ' + Birim) as fullname from PersonelDb", connection);
            OleDbDataAdapter DA2 = new OleDbDataAdapter(cmd2);
            DataTable dt3 = new DataTable();
            DA2.Fill(dt3);
            amirFull.DataSource = dt3;
            amirFull.DisplayMember = "fullname";
            amirFull.ValueMember = "Id";
            connection.Close();
        }

        void listebirlestir()
        {
            connection.Open();
            OleDbCommand cmd = new OleDbCommand("Select Id, (Ad + ' ' + Soyad + ' ' + '-' + ' ' + SicilNo + ' ' + '-' + ' ' + Birim) as fullname from PersonelDb", connection);
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                listBox1.Items.Add(read[1]);
            }
            connection.Close();
        }

        //dgcKonum verileri listeleme
        void KonumListele()
        {
            try
            {
                DataSet ds = new DataSet();
                connection.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("Select *from Location ORDER BY Id", connection);
                da.Fill(ds, "Location");
                dgvKonum.DataMember = "Location";
                dgvKonum.DataSource = ds;
                da.Dispose();
                connection.Close();

                //Verileri Comboboxa Aktarma
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    konumFull.Items.Add(ds.Tables[0].Rows[i][1] + ", " + ds.Tables[0].Rows[i][2] + ", " + ds.Tables[0].Rows[i][3]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Bağlantı Kurulamadı..." + ex);
            }
        }

        //Kayıt Sayfası Verileri Listeleme
        void fullListe()
        {
            try
            {
                DataTable DTfull = new DataTable();
                connection.Open();
                OleDbDataAdapter DA = new OleDbDataAdapter("select *from fullDb", connection);
                DA.Fill(DTfull);
                dgvFull.DataSource = DTfull;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata fullDb Bağlantısı Kurulamadı..." + ex);
            }
        }

        //dgvArac Verileri Textboxa aktarma
        private void dgvArac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvArac.Rows[e.RowIndex];
                carId.Text = row.Cells[0].Value.ToString();
                txtPlaka.Text = row.Cells[1].Value.ToString();
            }
        }

        //dgvPersonel Verileri Textboxa aktarma
        private void dGVPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvPersonel.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtAd.Text = row.Cells[1].Value.ToString();
                txtSoyad.Text = row.Cells[2].Value.ToString();
                txtsicil.Text = row.Cells[3].Value.ToString();
                txtBirim.Text = row.Cells[4].Value.ToString();
            }
        }

        //dgvKonum Verileri Textboxa aktarma
        private void dgvKonum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvKonum.Rows[e.RowIndex];
                KonumId.Text = row.Cells[0].Value.ToString();
                txtil.Text = row.Cells[1].Value.ToString();
                txtilce.Text = row.Cells[2].Value.ToString();
                txtmah.Text = row.Cells[3].Value.ToString();
            }
        }

        //dgvFull verileri Textboxa aktarma
        private void dgvFull_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvFull.Rows[e.RowIndex];
                string yansit1 = row.Cells[8].Value.ToString() + "- " + row.Cells[9].Value.ToString() + " - " + row.Cells[10].Value.ToString();
                amirFull.Text = yansit1;
                konumFull.Text = row.Cells[4].Value.ToString();
                gorevFull.Text = row.Cells[5].Value.ToString();
                IdFull.Text = row.Cells[0].Value.ToString();
                aracfull.Text = row.Cells[7].Value.ToString();
                surucufull.Text = row.Cells[6].Value.ToString();
            }
        }

        //dgvPersonel Veri Ekleme
        private void btnEkle_Click(object sender, EventArgs e)
        {

            if ((txtAd.Text == "") || (txtSoyad.Text == "") || (txtBirim.Text == "") || (txtsicil.Text == ""))
            {
                MessageBox.Show("Kayıt İşlemi Yapılamadı Lütfen Tüm Alanları Doldurun. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand("insert into PersonelDb (Ad, Soyad, SicilNo, Birim) values ('" + txtAd.Text.ToString().ToUpper() + "','" + txtSoyad.Text.ToString().ToUpper() + "','" + txtsicil.Text.ToString().ToUpper() + "','" + txtBirim.Text.ToString().ToUpper() + "')", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                DT.Clear();
                birlestirAmir();
                listBox1.Items.Clear();
                listebirlestir();
                p_Temizle();
                PersonelListele();
                surucubirlestir();
                MessageBox.Show("Personel Bilgileri Kaydedildi", "Başarılı");
            }
        }

        //dgvPersonel Veri Güncelleme
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Satırı Seçin. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((txtAd.Text == "") || (txtSoyad.Text == "") || (txtBirim.Text == "") || (txtsicil.Text == ""))
            {
                MessageBox.Show("Lütfen Tüm Boş Satırları Doldurun.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand();
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "update PersonelDb set Ad = '" + txtAd.Text.ToUpper() + "', Soyad = '" + txtSoyad.Text.ToUpper() + "', SicilNo = '" + txtsicil.Text.ToUpper() + "', Birim = '" + txtBirim.Text.ToUpper() + "' where Id = " + txtId.Text + "";
                cmd.ExecuteNonQuery();
                connection.Close();
                DT.Clear();
                birlestirAmir();
                listebirlestir();
                PersonelListele();
                surucubirlestir();
                MessageBox.Show("Personel Bilgileri Güncellendi", "Başarılı");
            }
        }

        //dgvPersonel Veri Silme
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Silme İşlemi Yapılamadı. Lütfen Silmek İstediğiniz Satırı Seçin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Secim = new DialogResult();
                Secim = MessageBox.Show("Silmek İstediğinizden Emin misiniz ?", " UYARI! ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Secim == DialogResult.Yes)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "delete from PersonelDb where Id=" + txtId.Text + "";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    DT.Clear();
                    birlestirAmir();
                    listebirlestir();
                    PersonelListele();
                    surucubirlestir();
                    MessageBox.Show("Personel Bilgileri Silindi", "Başarılı");
                    p_Temizle();
                }
            }
        }

        //Textboxları Temizleme Personel İçin
        void p_Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtBirim.Text = "";
            txtsicil.Text = "";
            txtId.Text = "";
        }

        //Textboxları Temizleme Konum İçin
        void k_Temizle()
        {
            KonumId.Text = "";
            txtil.Text = "";
            txtilce.Text = "";
            txtmah.Text = "";

        }

        //Sadece Harf Girişi
        private void key(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        //Tarih Eklerken Şimdiki Zamanı Göstermesi İçin
        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToString();
        }

        //Tüm Klavye Girişlerini engelleme
        private void keyfull(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //dgvPersonel Arama
        private void PersonelAra_TextChanged(object sender, EventArgs e)
        {
            //Textboxa Harfleri Büyük Yazdırma
            PersonelAra.Text = PersonelAra.Text.ToUpper();
            PersonelAra.SelectionStart = PersonelAra.Text.Length;
            //
            connection.Open();
            OleDbDataAdapter DA = new OleDbDataAdapter("select *from PersonelDb where Id like '%" + PersonelAra.Text + "%' or Ad like '%" + PersonelAra.Text + "%' or Soyad like '%" + PersonelAra.Text + "%' or SicilNo like '%" + PersonelAra.Text + "%' or Birim like '%" + PersonelAra.Text + "%'", connection);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            dgvPersonel.DataSource = DT;
            connection.Close();
            txtId.Text = "";

        }

        //konum bilgisi kaydetme
        private void SaveLocation_Click(object sender, EventArgs e)
        {
            if ((txtil.Text == "") && (txtilce.Text == "") && (txtmah.Text == ""))
            {
                MessageBox.Show("Kayıt İşlemi Yapılamadı Lütfen Boş Alanları Doldurun", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                OleDbCommand cmd2 = new OleDbCommand("insert into Location (il, ilce, mahalle) values ('" + txtil.Text.ToString().ToUpper() + "','" + txtilce.Text.ToString().ToUpper() + "','" + txtmah.Text.ToString().ToUpper() + "')", connection);
                cmd2.ExecuteNonQuery();
                connection.Close();
                konumFull.Items.Clear();
                KonumListele();
                MessageBox.Show("Konum Bilgileri Kaydedildi", "Başarılı");
                k_Temizle();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listebirlestir();
            PersonelListele();
            KonumListele();
            birlestirAmir();
            gorevlistele();
            aracListele();
            aracgonder();
            fullListe();
            surucubirlestir();
            comboFull.SelectedIndex = 0;

            for (int i = 2023; i < 2100; i++)
            {
                comboYil.Items.Add(i);
            }
        }
        //konum bilgisi silme
        private void DeleteLocation_Click(object sender, EventArgs e)
        {
            if (((txtil.Text == "") && (txtilce.Text == "") && (txtmah.Text == "")) || (KonumId.Text == ""))
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Satırı Seçin. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Secim = new DialogResult();
                Secim = MessageBox.Show("Silmek İstediğinizden Emin misiniz ?", " UYARI! ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (Secim == DialogResult.Yes)
                {
                    OleDbCommand cmd2 = new OleDbCommand();
                    connection.Open();
                    cmd2.Connection = connection;
                    cmd2.CommandText = "delete from Location where Id=" + KonumId.Text + "";
                    cmd2.ExecuteNonQuery();
                    connection.Close();
                    konumFull.Items.Clear();
                    KonumListele();
                    MessageBox.Show("Konum Bilgileri Silindi", "Başarılı");
                    k_Temizle();
                }
            }
        }
        //Konum bilgisi güncelleme
        private void UpdateLocation_Click(object sender, EventArgs e)
        {
            if ((txtil.Text == "") && (txtilce.Text == "") && (txtmah.Text == ""))
            {
                MessageBox.Show("Güncelleme İşlemi Yapılamadı Tüm Alanları Doldurun. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OleDbCommand cmd2 = new OleDbCommand();
                connection.Open();
                cmd2.Connection = connection;
                cmd2.CommandText = "update Location set il = '" + txtil.Text.ToUpper() + "', ilce = '" + txtilce.Text.ToUpper() + "', mahalle = '" + txtmah.Text.ToUpper() + "' where Id = " + KonumId.Text + "";
                cmd2.ExecuteNonQuery();
                connection.Close();
                konumFull.Items.Clear();
                KonumListele();
                MessageBox.Show("Konum Bilgileri Güncellendi", "Başarılı");
            }
        }

        //Program Kapanınca Emin misiniz diye sormak
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sor = MessageBox.Show("Programdan Çıkmak İstediğinizden Emin Misiniz ?", "Çıkış Mesajı!", MessageBoxButtons.YesNo);
            if (sor == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (sor == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //SelectIndexChange seçim değişince ne yapılacağını seçmek için kullanılır
        private void comboAmir_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id2 = amirFull.SelectedValue.ToString();
            amirId.Text = id2;
        }

        //Kayıt Sayfası Kayıt Etme
        private void fullSave_Click(object sender, EventArgs e)
        {
            if ((listBox1.Text == ""))
            {
                MessageBox.Show("Lütfen Personel Seçimi Yapın.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((konumFull.Text == "") || (gorevFull.Text == "") || (amirFull.Text == "") || (aracfull.Text == "") || (surucufull.Text == ""))
            {
                MessageBox.Show("Kayıt İşlemi Yapılamadı Lütfen Tüm Boş Alanları Doldurun. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int primary;
                connection.Open();
                OleDbCommand cmd2 = new OleDbCommand("insert into gorevTanim (gorev) values (@gorev) ", connection);
                cmd2.Parameters.AddWithValue("@gorev", dateTimePicker1.Text + " Tarihli Görev");
                cmd2.ExecuteNonQuery();
                cmd2.CommandText = "SELECT @@IDENTITY";
                primary = Convert.ToInt32(cmd2.ExecuteScalar());
                connection.Close();
                gorevlistele();
                string surucu = surucufull.Text;
                string amir = amirFull.Text;
                foreach (var li in listBox1.SelectedItems)
                {
                    string[] amr = amir.Split('-');
                    string[] src = surucu.Split('-');

                    string X1 = li.ToString();
                    string[] X2 = X1.Split('-');

                    connection.Open();
                    OleDbCommand cmd3 = new OleDbCommand("insert into fullDb (PersonelAd, PersonelSicil, PersonelBirim,  Konum, GorevTuru, surucu, arac, BirimAmiri, amirSicil, amirBirim, Tarih, idhead) values ('" + X2[0].ToUpper().TrimEnd() + "','" + X2[1].ToUpper().Trim() + "','" + X2[2].ToUpper().Trim() + "','" + konumFull.Text.ToString().ToUpper() + "','" + gorevFull.Text.ToString().ToUpper() + "','" + src[0].ToString().ToUpper().TrimEnd() + "','" + aracfull.Text.ToString().ToUpper() + "','" + amr[0].ToUpper().TrimEnd() + "','" + amr[1].ToUpper().Trim() + "','" + amr[2].ToUpper().Trim() + "','" + this.dateTimePicker2.Text + "','" + primary.ToString() + "')", connection); ;
                    cmd3.ExecuteNonQuery();
                    connection.Close();
                    fullListe();
                    MessageBox.Show("Kaydedildi", "Başarılı");
                }
            }
            comboFull.Text = "Tüm Aylar";
        }

        //Personel Sayfası Kayıt Silme
        private void fullDelete_Click(object sender, EventArgs e)
        {
            if (IdFull.Text == "")
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Satırı Seçin. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Secim = new DialogResult();
                Secim = MessageBox.Show("Silmek İstediğinizden Emin Misiniz ?", " UYARI! ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (Secim == DialogResult.Yes)
                {
                    OleDbCommand cmd3 = new OleDbCommand();
                    connection.Open();
                    cmd3.Connection = connection;
                    cmd3.CommandText = "delete from fullDb where Id=" + IdFull.Text + "";
                    cmd3.ExecuteNonQuery();
                    DTfull.Clear();
                    connection.Close();
                    MessageBox.Show("Silindi", "Başarılı");
                    fullListe();
                    comboFull.SelectedIndex = 0;
                }
            }
        }

        //Kayıt Sayfası Kayıt Güncelleme
        private void fullUpdate_Click(object sender, EventArgs e)
        {   //Listboxdda birden fazla seçim yapıldı mı kontrolu için
            if (listBox1.SelectedIndices.Count > 1)
            {
                MessageBox.Show("Güncelleme İşleminde Birden Fazla Personel Seçimi Yapılamaz.");
            }
            else if (listBox1.SelectedIndices.Count == 1)
            {
                foreach (var don in listBox1.SelectedItems)
                {
                    string surucu = surucufull.Text;
                    string[] src = surucu.Split('-');

                    string amir2 = amirFull.Text;
                    string[] amrson = amir2.Split('-');

                    string guncelle = don.ToString();
                    string[] guncelle2 = guncelle.Split('-');

                    if (IdFull.Text == "")
                    {
                        MessageBox.Show("Lütfen Güncellemek İstediğiniz Satırı Seçin. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if ((listBox1.Text == "") || (konumFull.Text == "") || (gorevFull.Text == "") || (amirFull.Text == ""))
                    {
                        MessageBox.Show("Güncelleme İşlemi Yapılamadı Lütfen Tüm Boş Alanları Doldurun ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        OleDbCommand cmd3 = new OleDbCommand();
                        connection.Open();
                        cmd3.Connection = connection;
                        cmd3.CommandText = "update fullDb set PersonelAd = '" + guncelle2[0].ToUpper().TrimEnd() + "',PersonelSicil = '" + guncelle2[1].ToUpper().Trim() + "', PersonelBirim = '" + guncelle2[2].ToUpper().Trim() + "',Konum = '" + konumFull.Text.ToUpper() + "', GorevTuru = '" + gorevFull.Text.ToUpper() + "',surucu = '" + src[0].ToUpper().TrimEnd() + "' ,arac = '" + aracfull.Text.ToUpper() + "', BirimAmiri = '" + amrson[0].ToUpper() + "' , amirSicil = '" + amrson[1].ToUpper().Trim() + "' , amirBirim = '" + amrson[2].ToUpper().Trim() + "' ,Tarih = '" + this.dateTimePicker2.Text + "' where Id = " + IdFull.Text + "";
                        cmd3.ExecuteNonQuery();
                        connection.Close();
                        fullListe();
                        MessageBox.Show("Güncellendi", "Başarılı");
                        fullAra.Text = "";
                        comboFull.SelectedIndex = 0;
                    }
                }
            }
            else if (listBox1.SelectedIndices.Count < 1)
            {
                string surucu = surucufull.Text;
                string[] src = surucu.Split('-');

                string amir2 = amirFull.Text;
                string[] amrson = amir2.Split('-');

                if (IdFull.Text == "")
                {
                    MessageBox.Show("Lütfen Güncellemek İstediğiniz Satırı Seçin. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((konumFull.Text == "") || (gorevFull.Text == "") || (amirFull.Text == ""))
                {
                    MessageBox.Show("Güncelleme İşlemi Yapılamadı Lütfen Tüm Boş Alanları Doldurun ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    OleDbCommand cmd3 = new OleDbCommand();
                    connection.Open();
                    cmd3.Connection = connection;
                    cmd3.CommandText = "update fullDb set Konum = '" + konumFull.Text.ToUpper() + "', GorevTuru = '" + gorevFull.Text.ToUpper() + "',arac = '" + aracfull.Text.ToUpper() + "',surucu = '" + src[0].ToUpper().TrimEnd() + "', BirimAmiri = '" + amrson[0].ToUpper() + "' , amirSicil = '" + amrson[1].ToUpper().Trim() + "' , amirBirim = '" + amrson[2].ToUpper().Trim() + "' ,Tarih = '" + this.dateTimePicker2.Text + "' where Id = " + IdFull.Text + "";
                    cmd3.ExecuteNonQuery();
                    connection.Close();
                    fullListe();
                    MessageBox.Show("Güncellendi", "Başarılı");
                    fullAra.Text = "";
                    comboFull.SelectedIndex = 0;
                }
            }
        }

        //Kayıt Sayfası Arama
        private void fullAra_TextChanged(object sender, EventArgs e)
        {
            //Textboxa Harfleri Büyük Yazdırma
            fullAra.Text = fullAra.Text.ToUpper();
            fullAra.SelectionStart = fullAra.Text.Length;

            if (comboFull.Text == "Tüm Aylar")
            {
                DTfull.Clear();
                connection.Open();
                OleDbDataAdapter DA = new OleDbDataAdapter("select *from fullDb where Tarih like '%" + fullAra.Text + "%' or Id like '%" + fullAra.Text + "%' or PersonelAd like '%" + fullAra.Text + "%' or Konum like '%" + fullAra.Text + "%' or GorevTuru like '%" + fullAra.Text + "%' or BirimAmiri like '%" + fullAra.Text + "%'", connection);
                DA.Fill(DTfull);
                dgvFull.DataSource = DTfull;
                connection.Close();
            }
            else
            {
                DTfull.Clear();
                connection.Open();
                OleDbDataAdapter DA = new OleDbDataAdapter("select *from fullDb where (Tarih like '___" + comboFull.Text.Substring(0, 2) + "%' ) and (Id like '%" + fullAra.Text + "%' or PersonelAd like '%" + fullAra.Text + "%' or Konum like '%" + fullAra.Text + "%' or GorevTuru like '%" + fullAra.Text + "%' or BirimAmiri like '%" + fullAra.Text + "%')", connection);
                DA.Fill(DTfull);
                dgvFull.DataSource = DTfull;
                connection.Close();
            }

            IdFull.Text = "";
        }

        //Comboboxta index değişince yapılacaklar
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            IdFull.Text = "";
            if (comboFull.Text == "Tüm Aylar")
            {
                DTfull.Clear();
                connection.Open();
                OleDbDataAdapter DA = new OleDbDataAdapter("select *from fullDb", connection);
                DA.Fill(DTfull);
                dgvFull.DataSource = DTfull;
                connection.Close();
                string aktar = comboYil.Text;
            }
            else
            {
                DTfull.Clear();
                connection.Open();
                OleDbDataAdapter DA = new OleDbDataAdapter("select *from fullDb where Tarih like '___" + comboFull.Text.Substring(0, 2) + "%'", connection);
                DA.Fill(DTfull);
                dgvFull.DataSource = DTfull;
                connection.Close();
                string aktar = comboYil.Text;
            }
        }

        //Mouse ile butonun üzerine gelince yapılacaklar
        private void enter(object sender, EventArgs e)
        {
            Button btnE = sender as Button;
            if (btnE.Name == "fullSave" || btnE.Name == "SaveLocation" || btnE.Name == "btnEkle" || btnE.Name == "excell" || btnE.Name == "excel2" || btnE.Name == "saveCar")
            {
                btnE.BackColor = Color.LimeGreen;
            }
            if (btnE.Name == "btnSil" || btnE.Name == "DeleteLocation" || btnE.Name == "fullDelete" || btnE.Name == "deleteCar")
            {
                btnE.BackColor = Color.Red;
            }
            if (btnE.Name == "btnGuncelle" || btnE.Name == "UpdateLocation" || btnE.Name == "fullUpdate" || btnE.Name == "updateCar")
            {
                btnE.BackColor = Color.Yellow;
            }
        }

        //Mouse ile butonun üzerinden ayrılınca yapılacaklar
        private void leave(object sender, EventArgs e)
        {
            Button btnS = sender as Button;
            if (btnS.Name == "fullSave" || btnS.Name == "SaveLocation" || btnS.Name == "btnEkle" || btnS.Name == "excell" || btnS.Name == "excel2" || btnS.Name == "saveCar")
            {
                btnS.BackColor = Color.Transparent;
            }
            if (btnS.Name == "btnSil" || btnS.Name == "DeleteLocation" || btnS.Name == "fullDelete" || btnS.Name == "deleteCar")
            {
                btnS.BackColor = Color.Transparent;
            }
            if (btnS.Name == "btnGuncelle" || btnS.Name == "UpdateLocation" || btnS.Name == "fullUpdate" || btnS.Name == "updateCar")
            {
                btnS.BackColor = Color.Transparent;
            }
        }

        //Verileri Excele aktarma
        private void excell_Click(object sender, EventArgs e)
        {
            Excel.Application excel2 = new Excel.Application();
            excel2.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel2.Workbooks.Add(Missing);
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Worksheet x = excel2.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
            Excel.Range userRange = x.UsedRange;

            worksheet.get_Range("A1", "I1").Merge(false);
            worksheet.get_Range("A2", "I2").Merge(false);
            worksheet.get_Range("A3", "I3").Merge(false);
            worksheet.get_Range("A4", "I4").Merge(false);
            worksheet.get_Range("A5", "B5").Merge(false);
            worksheet.get_Range("A6", "B6").Merge(false);
            worksheet.get_Range("A7", "B7").Merge(false);
            worksheet.get_Range("C5", "E5").Merge(false);
            worksheet.get_Range("C6", "E6").Merge(false);
            worksheet.get_Range("C7", "E7").Merge(false);
            worksheet.get_Range("C5", "E5").Merge(false);
            worksheet.get_Range("C6", "E6").Merge(false);
            worksheet.get_Range("H5", "I5").Merge(false);
            worksheet.get_Range("H6", "I6").Merge(false);
            worksheet.get_Range("F5", "G5").Merge(false);
            worksheet.get_Range("F6", "G6").Merge(false);
            worksheet.get_Range("B9", "C9").Merge(false);
            worksheet.get_Range("G9", "I9").Merge(false);

            x.Range["A1"].Value = "T.C";
            x.Range["A2"].Value = "KIRIKHAN KAYMAKAMLIĞI";
            x.Range["A3"].Value = "İlçe Gıda Tarım ve Hayvan Tarım Müdürlüğü";
            x.Range["A4"].Value = "ARAZİ ÇIKIŞ FORMU";
            x.Range["A5"].Value = "ADI SOYADI";
            x.Range["A6"].Value = "SINIFI ÜNVANI";
            x.Range["A7"].Value = "İMZASI";
            x.Range["F5"].Value = "SİCİL NO";
            x.Range["F6"].Value = "AİT OLDUĞU AY";
            x.Range["A9"].Value = "SN";
            x.Range["B9"].Value = "GİDİLEN KÖY/YER";
            x.Range["D9"].Value = "GİDİŞ SAATİ";
            x.Range["E9"].Value = "DÖNÜŞ SAATİ";
            x.Range["F9"].Value = "ARAÇ PLAKASI";
            x.Range["G9"].Value = "GÖREV KONUSU";

            

            for (int i = 10; i < 41; i++)
            {
                worksheet.get_Range("B" + i, "C"+i).Merge(false);
                worksheet.get_Range("G" + i, "I" + i).Merge(false);
                x.Range["A" + i].Value = i-9;
            }

            worksheet.Columns.AutoFit();
            excel2.Columns.WrapText = true;
            excel2.Columns.AutoFit();

            Excel.Range last = x.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            Excel.Range rangeX = x.get_Range("A1", last); //A1'den Son Satıra Kadar alıp rangeX e aktardık
            rangeX.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; //A1'den Son Satıra Kadar Yazıları Ortalama
            rangeX.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter; //A1'den Son Satıra Kadar Yazıları Ortalama
            Excel.Borders xborder = rangeX.Borders;
            xborder.LineStyle = Excel.XlLineStyle.xlContinuous;
            xborder.Weight = 2d; //Kenarlığın kalınlığı

            x.Range["B9"].ColumnWidth = 18;
            x.Range["C9"].ColumnWidth = 12;

            if (dgvFull.Rows.Count>0)
            {
                for (int i = 0; i < dgvFull.Rows.Count ; i++)
                {
                    x.Range["B" + (i + 10)].Value = dgvFull.Rows[i].Cells[4].Value.ToString(); //5. sütun tüm satıları yazdır rows satırı 4 hücreyi temsil ediyor.
                    x.Range["F" + (i + 10)].Value = dgvFull.Rows[i].Cells[7].Value.ToString(); //
                    x.Range["G" + (i + 10)].Value = dgvFull.Rows[i].Cells[5].Value.ToString();
                }
                x.Range["B10"].Value = dgvFull.Rows[0].Cells[4].Value.ToString();
            }

            if (dgvFull.Rows.Count > 0)
            {
                x.Range["C5"].Value = dgvFull.Rows[1].Cells[1].Value.ToString();
                x.Range["H5"].Value = dgvFull.Rows[1].Cells[2].Value.ToString();
                x.Range["C6"].Value = dgvFull.Rows[1].Cells[3].Value.ToString();
                if (comboFull.Text == "Tüm Aylar")
                {
                    x.Range["H6"].Value = comboYil.Text;
                }
                else
                {
                    x.Range["H6"].Value = comboFull.Text;
                }
            }

            while (System.Runtime.InteropServices.Marshal.ReleaseComObject(excel2) != 0) { }
            worksheet = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Worksheet x = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
            Excel.Range userRange = x.UsedRange;
            //string [] X1 = { "A2", "A3", "A4", "F4", "A5", "C5", "H5" "A6", "C6", "H6", "A7", "F7", "A8", "D8", "A9", "D9"}
            worksheet.get_Range("A2", "I2").Merge(false);
            worksheet.get_Range("A3", "I3").Merge(false);
            worksheet.get_Range("A4", "E4").Merge(false);
            worksheet.get_Range("F4", "I4").Merge(false);
            worksheet.get_Range("A5", "B5").Merge(false);
            worksheet.get_Range("C5", "D5").Merge(false);
            worksheet.get_Range("H5", "I5").Merge(false);
            worksheet.get_Range("A6", "B6").Merge(false);
            worksheet.get_Range("C6", "D6").Merge(false);
            worksheet.get_Range("H6", "I6").Merge(false);
            worksheet.get_Range("A7", "E7").Merge(false);
            worksheet.get_Range("F7", "I7").Merge(false);
            worksheet.get_Range("A8", "C8").Merge(false);
            worksheet.get_Range("D8", "E8").Merge(false);
            worksheet.get_Range("A9", "C9").Merge(false);
            worksheet.get_Range("D9", "E9").Merge(false);
            worksheet.get_Range("A10", "C10").Merge(false);
            worksheet.get_Range("D10", "E10").Merge(false);
            worksheet.get_Range("A11", "C11").Merge(false);
            worksheet.get_Range("D11", "E11").Merge(false);
            worksheet.get_Range("A12", "C12").Merge(false);
            worksheet.get_Range("D12", "E12").Merge(false);
            worksheet.get_Range("A13", "C13").Merge(false);
            worksheet.get_Range("D13", "E13").Merge(false);
            worksheet.get_Range("G8", "I9").Merge(false);
            worksheet.get_Range("F8", "F9").Merge(false);
            worksheet.get_Range("G10", "I10").Merge(false);
            worksheet.get_Range("F11", "F12").Merge(false);
            worksheet.get_Range("G11", "I12").Merge(false);
            worksheet.get_Range("G13", "I13").Merge(false);
            worksheet.get_Range("A14", "B14").Merge(false);
            worksheet.get_Range("A15", "B15").Merge(false);
            worksheet.get_Range("C14", "E14").Merge(false);
            worksheet.get_Range("C15", "E15").Merge(false);
            worksheet.get_Range("G14", "I14").Merge(false);
            worksheet.get_Range("G15", "I15").Merge(false);
            worksheet.get_Range("A16", "B17").Merge(false);
            worksheet.get_Range("G16", "I16").Merge(false);
            worksheet.get_Range("G17", "I17").Merge(false);
            worksheet.get_Range("A18", "I18").Merge(false);
            worksheet.get_Range("A19", "I19").Merge(false);
            worksheet.get_Range("A20", "I20").Merge(false);
            worksheet.get_Range("A21", "I21").Merge(false);
            worksheet.get_Range("A22", "I22").Merge(false);
            worksheet.get_Range("A23", "I23").Merge(false);
            worksheet.get_Range("A25", "I25").Merge(false);
            worksheet.get_Range("A26", "I30").Merge(false);
            worksheet.get_Range("A31", "I31").Merge(false);
            worksheet.get_Range("A32", "I38").Merge(false);
            worksheet.get_Range("A24", "I24").Merge(false);
            worksheet.get_Range("A39", "C39").Merge(false);
            worksheet.get_Range("F39", "I39").Merge(false);
            worksheet.get_Range("A40", "C40").Merge(false);
            worksheet.get_Range("A41", "C41").Merge(false);
            worksheet.get_Range("A42", "C42").Merge(false);
            worksheet.get_Range("A43", "C43").Merge(false);
            worksheet.get_Range("A44", "C44").Merge(false);
            worksheet.get_Range("F40", "I44").Merge(false);

            x.Range["A2"].Value = "TAŞIT GÖREV EMRİ"; //2. Satır 1. Sütuna Veri Yazma
            x.Range["A4"].Value = "GÖREVLENDİREN BİRİM AMİRİ";
            x.Range["F4"].Value = "ARACI SEVK EDEN BİRİM AMİRİ";
            x.Range["A3"].Value = "";
            x.Range["A5"].Value = "ADI-SOYADI";
            x.Range["C5"].Value = "ÜNVANI";
            x.Range["E5"].Value = "   İMZASI   ";
            x.Range["F5"].Value = "    ADI-SOYADI    ";
            x.Range["G5"].Value = "     ÜNVANI     ";
            x.Range["H5"].Value = "İMAZSI";
            x.Range["A7"].Value = "GÖREVLİ PERSONELİN";
            x.Range["F7"].Value = "ARACIN";
            x.Range["A8"].Value = "ADI-SOYADI";
            x.Range["D8"].Value = "ÜNVANI";
            x.Range["F10"].Value = "PLAKASI";
            x.Range["G11"].Value = "T.C KIRIKHAN İLÇE TARIM VE ORMAN MÜDÜRLÜĞÜ";
            x.Range["A14"].Value = "GÖREVİN TÜRÜ";
            x.Range["A15"].Value = "GİDECEĞİ YER";
            x.Range["F14"].Value = "ÇIKIŞ KM'Sİ";
            x.Range["G14"].Value = "DÖNÜŞ KM'Sİ";
            x.Range["F15"].Value = ".........";
            x.Range["G15"].Value = "..............";
            x.Range["C16"].Value = "      ADI SOYADI       ";
            x.Range["D16"].Value = "      Ünvanı     ";
            x.Range["E16"].Value = "      İmzası     ";
            x.Range["F16"].Value = "    ÇIKIŞ SAATİ    ";
            x.Range["G16"].Value = "    DÖNÜŞ SAATİ    ";
            x.Range["A25"].Value = "GÖREV DÖNÜŞ RAPORU";
            x.Range["A31"].Value = "YAPILAN ÇALIŞMANIN ÖZETİ";
            x.Range["A39"].Value = " GÖREVLİ PERSONELİN ADI SOYADI ";
            x.Range["D39"].Value = "İMAZSI";
            x.Range["E39"].Value = "İMAZSI";
            x.Range["F39"].Value = "ONAYLAYAN";
            x.Range["A16"].Value = "ONAYLAYAN";

            x.Range["A14"].RowHeight = 20;  //satır yüksekliği ayarlama
            x.Range["A15"].RowHeight = 28;
            x.Range["A16"].RowHeight = 22;
            x.Range["C17"].RowHeight = 23;
            x.Range["A39"].RowHeight = 34;

            Excel.Range last = x.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            Excel.Range rangeX = x.get_Range("A1", last); //A1'den Son Satıra Kadar alıp rangeX e aktardık
            rangeX.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; //A1'den Son Satıra Kadar Yazıları Ortalama
            rangeX.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter; //A1'den Son Satıra Kadar Yazıları Ortalama
            Excel.Borders xborder = rangeX.Borders;
            xborder.LineStyle = Excel.XlLineStyle.xlContinuous;
            xborder.Weight = 2d; //Kenarlığın kalınlığı

            x.Range["A2", "A3"].Font.Bold = true; //1. sütun 2. ve 3. satırı kalın yazırma

            //Aktarırken yazıları düzenli bir şekilde yazdırma
            excel.Columns.AutoFit();
            x.Range["F8"].Value = "SÜRÜCÜSÜNÜN ADI-SOYADI";
            x.Range["F11"].Value = "AİT OLDUĞU KURULUŞ";

            excel.Columns.WrapText = true;
            string[] cells1 = { "A18", "A19", "A20", "A21", "A22", "A23" };

            foreach (var x1 in cells1)
            {
                worksheet.get_Range(x1).Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                worksheet.get_Range(x1, x1).Cells.Font.Size = 9;
                x.Range[x1].RowHeight = 11;
            }

            string[] amirexcel = { "A6", "F6", "C17", "F40" };
            string[] amirexcel2 = { "C6", "G6", "D17" };

            x.Range["A18"].Value = "1-Taşıt Görev Emri her görevlendirmede iki nüsha doldurulacak, bir nüshası kurumda kalacak, ikinci nüshası araçta bulundurulacaktır.";
            x.Range["A19"].Value = "2-Taşıt Görev Emri yetkililerin istemesi halinde gösterilecektir.";
            x.Range["A20"].Value = "3- Araç sürücüleri ile araçta bulunan görevliler resmi sıfatın gerektirdiği saygınlığa uygun davranışlarda bulunacaktır.";
            x.Range["A21"].Value = "Sürücüler ve görevliler araç içinde sigara içmeyeceklerdir.";
            x.Range["A22"].Value = "4-Aracı kullanan kişi için her gün ayrı zimmet mümkün olmadığından görev kağıdında şoför olarak ismi yazılan kişi aracın herşeyinden";
            x.Range["A23"].Value = "sorumlu olup üzerine zimmetli sayılacaktır.";

            for (int i = 0; i <= dgvFull.Rows.Count - 1; i++)
            {
                x.Range["A" + (i + 9)].Value = dgvFull.Rows[i].Cells[1].Value.ToString(); //Personeller Ad exceldeki yerini belirleme
                x.Range["A" + (i + 40)].Value = dgvFull.Rows[i].Cells[1].Value.ToString(); //Personeller Ad exceldeki yerini belirleme
                x.Range["D" + (i + 9)].Value = dgvFull.Rows[i].Cells[3].Value.ToString(); //Personeller Birim exceldeki yerini belirleme
            }

            if (dgvFull.Rows.Count > 0)
            {
                foreach (var donus in amirexcel)
                {
                    x.Range[donus].Value = dgvFull.Rows[0].Cells[8].Value.ToString(); //Birim Amiri Ad exceldeki yerini belirleme
                }
                foreach (var donus2 in amirexcel2)
                {
                    x.Range[donus2].Value = dgvFull.Rows[0].Cells[10].Value.ToString(); //Birim Amiri Unvan exceldeki yerini belirleme
                }
                x.Range["G10"].Value = dgvFull.Rows[0].Cells[7].Value.ToString(); //Plaka exceldeki yerini belirleme
                x.Range["C14"].Value = dgvFull.Rows[0].Cells[5].Value.ToString(); //Görevin Türü exceldeki yerini belirleme
                x.Range["C15"].Value = dgvFull.Rows[0].Cells[4].Value.ToString(); //Gideceği Yer exceldeki yerini belirleme
                x.Range["G8"].Value = dgvFull.Rows[0].Cells[6].Value.ToString(); //Plaka exceldeki yerini belirleme
            }

            //Garbage Collection. Görev yöneticisinde sürekli açık kalan exceli kapatmak için aşaıdaki kod parçasını kullandık
            while (System.Runtime.InteropServices.Marshal.ReleaseComObject(excel) != 0) { }
            worksheet = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            connection.Open();
            OleDbDataAdapter DA = new OleDbDataAdapter("select *from fullDb where idhead like '" + IdTransfer.Text + "'", connection);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            dgvFull.DataSource = DT;
            connection.Close();
            tabPersonel.SelectedTab = tabPage3;
            tabPage3.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                IdTransfer.Text = row.Cells[0].Value.ToString();
            }
        }

        //Plaka Ekleme
        private void saveCar_Click(object sender, EventArgs e)
        {
            if ((txtPlaka.Text == ""))
            {
                MessageBox.Show("Kayıt İşlemi Yapılamadı Lütfen Boş Alanları Doldurun", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                OleDbCommand cmd2 = new OleDbCommand("insert into arac (Arac) values (@plaka)", connection);
                cmd2.Parameters.AddWithValue("@plaka", txtPlaka.Text.ToUpper());
                cmd2.ExecuteNonQuery();
                connection.Close();
                aracListele();
                MessageBox.Show("Araç Bilgileri Kaydedildi", "Başarılı");
                txtPlaka.Text = "";
                aracgonder();
            }
        }

        private void deleteCar_Click(object sender, EventArgs e)
        {
            if ((txtPlaka.Text == ""))
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Satırı Seçin. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Secim = new DialogResult();
                Secim = MessageBox.Show("Silmek İstediğinizden Emin misiniz ?", " UYARI! ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (Secim == DialogResult.Yes)
                {
                    connection.Open();
                    OleDbCommand sil = new OleDbCommand("Delete From arac where ID=@p1", connection);
                    sil.Parameters.AddWithValue("@p1", carId.Text);
                    sil.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Araç Bilgileri Silindi", "Başarılı", MessageBoxButtons.OK);
                    aracListele();
                    txtPlaka.Text = "";
                    carId.Text = "";
                    aracgonder();
                }
            }
        }

        private void updateCar_Click(object sender, EventArgs e)
        {
            if (carId.Text == "")
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Satırı Seçin. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OleDbCommand cmd2 = new OleDbCommand();
                connection.Open();
                cmd2.Connection = connection;
                cmd2.CommandText = "update arac set Arac = '" + txtPlaka.Text.ToUpper() + "' where ID = " + carId.Text + "";
                cmd2.ExecuteNonQuery();
                connection.Close();
                aracListele();
                aracgonder();
                MessageBox.Show("Araç Bilgileri Güncellendi", "Başarılı");
            }
        }

        private void comboYil_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboFull.Text == "Tüm Aylar")
            {
                fullListe();
                DTfull.Clear();
                connection.Open();
                OleDbDataAdapter DA = new OleDbDataAdapter("select *from fullDb where Tarih like '______" + comboYil.Text.Substring(0, 4) + "%'", connection);
                DA.Fill(DTfull);
                dgvFull.DataSource = DTfull;
                connection.Close();

            }
            else
            {
                DTfull.Clear();
                connection.Open();
                OleDbDataAdapter DA = new OleDbDataAdapter("select *from fullDb where Tarih like '______" + comboYil.Text.Substring(0, 4) + "%' and Tarih like '___" + comboFull.Text.Substring(0, 2) + "%'", connection);
                DA.Fill(DTfull);
                dgvFull.DataSource = DTfull;
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IdTransfer.Text == "")
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Satırı Seçin. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Secim = new DialogResult();
                Secim = MessageBox.Show("Silmek istediğinizden emin misiniz ? Bu id ile bağlantılı tüm veriler silinecektir.", " UYARI! ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (Secim == DialogResult.Yes)
                {
                    sil1();
                    sil2();
                }
            }
        }

        void sil2()
        {
            OleDbCommand cmd3 = new OleDbCommand();
            connection.Open();
            cmd3.Connection = connection;
            cmd3.CommandText = "delete from fullDb where idhead=" + IdTransfer.Text + "";
            cmd3.ExecuteNonQuery();
            DTfull.Clear();
            connection.Close();
            fullListe();
        }
        void sil1()
        {
            OleDbCommand cmd3 = new OleDbCommand();
            connection.Open();
            cmd3.Connection = connection;
            cmd3.CommandText = "delete from gorevTanim where IdHead=" + IdTransfer.Text.ToString() + "";
            cmd3.ExecuteNonQuery();
            DTfull.Clear();
            connection.Close();
            MessageBox.Show("Silindi", "Başarılı");
            gorevlistele();
            comboFull.SelectedIndex = 0;
        }

        private void excel2_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Worksheet x = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
            Excel.Range userRange = x.UsedRange;
            //string [] X1 = { "A2", "A3", "A4", "F4", "A5", "C5", "H5" "A6", "C6", "H6", "A7", "F7", "A8", "D8", "A9", "D9"}

            worksheet.get_Range("A2", "I2").Merge(false);
            worksheet.get_Range("A3", "I3").Merge(false);
            worksheet.get_Range("A4", "E4").Merge(false);
            worksheet.get_Range("F4", "I4").Merge(false);
            worksheet.get_Range("A5", "B5").Merge(false);
            worksheet.get_Range("C5", "D5").Merge(false);
            worksheet.get_Range("H5", "I5").Merge(false);
            worksheet.get_Range("A6", "B6").Merge(false);
            worksheet.get_Range("C6", "D6").Merge(false);
            worksheet.get_Range("H6", "I6").Merge(false);
            worksheet.get_Range("A7", "E7").Merge(false);
            worksheet.get_Range("F7", "I7").Merge(false);
            worksheet.get_Range("A8", "C8").Merge(false);
            worksheet.get_Range("D8", "E8").Merge(false);
            worksheet.get_Range("A9", "C9").Merge(false);
            worksheet.get_Range("D9", "E9").Merge(false);
            worksheet.get_Range("A10", "C10").Merge(false);
            worksheet.get_Range("D10", "E10").Merge(false);
            worksheet.get_Range("A11", "C11").Merge(false);
            worksheet.get_Range("D11", "E11").Merge(false);
            worksheet.get_Range("A12", "C12").Merge(false);
            worksheet.get_Range("D12", "E12").Merge(false);
            worksheet.get_Range("A13", "C13").Merge(false);
            worksheet.get_Range("D13", "E13").Merge(false);
            worksheet.get_Range("G8", "I9").Merge(false);
            worksheet.get_Range("F8", "F9").Merge(false);
            worksheet.get_Range("G10", "I10").Merge(false);
            worksheet.get_Range("F11", "F12").Merge(false);
            worksheet.get_Range("G11", "I12").Merge(false);
            worksheet.get_Range("G13", "I13").Merge(false);
            worksheet.get_Range("A14", "B14").Merge(false);
            worksheet.get_Range("A15", "B15").Merge(false);
            worksheet.get_Range("C14", "E14").Merge(false);
            worksheet.get_Range("C15", "E15").Merge(false);
            worksheet.get_Range("G14", "I14").Merge(false);
            worksheet.get_Range("G15", "I15").Merge(false);
            worksheet.get_Range("A16", "B17").Merge(false);
            worksheet.get_Range("G16", "I16").Merge(false);
            worksheet.get_Range("G17", "I17").Merge(false);
            worksheet.get_Range("A18", "I18").Merge(false);
            worksheet.get_Range("A19", "I19").Merge(false);
            worksheet.get_Range("A20", "I20").Merge(false);
            worksheet.get_Range("A21", "I21").Merge(false);
            worksheet.get_Range("A22", "I22").Merge(false);
            worksheet.get_Range("A23", "I23").Merge(false);
            worksheet.get_Range("A25", "I25").Merge(false);
            worksheet.get_Range("A26", "I30").Merge(false);
            worksheet.get_Range("A31", "I31").Merge(false);
            worksheet.get_Range("A32", "I38").Merge(false);
            worksheet.get_Range("A24", "I24").Merge(false);
            worksheet.get_Range("A39", "C39").Merge(false);
            worksheet.get_Range("F39", "I39").Merge(false);
            worksheet.get_Range("A40", "C40").Merge(false);
            worksheet.get_Range("A41", "C41").Merge(false);
            worksheet.get_Range("A42", "C42").Merge(false);
            worksheet.get_Range("A43", "C43").Merge(false);
            worksheet.get_Range("A44", "C44").Merge(false);
            worksheet.get_Range("F40", "I44").Merge(false);

            x.Range["A2"].Value = "TAŞIT GÖREV EMRİ"; //2. Satır 1. Sütuna Veri Yazma
            x.Range["A4"].Value = "GÖREVLENDİREN BİRİM AMİRİ";
            x.Range["F4"].Value = "ARACI SEVK EDEN BİRİM AMİRİ";
            x.Range["A3"].Value = "";
            x.Range["A5"].Value = "ADI-SOYADI";
            x.Range["C5"].Value = "ÜNVANI";
            x.Range["E5"].Value = "   İMZASI   ";
            x.Range["F5"].Value = "    ADI-SOYADI    ";
            x.Range["G5"].Value = "     ÜNVANI     ";
            x.Range["H5"].Value = "İMAZSI";
            x.Range["A7"].Value = "GÖREVLİ PERSONELİN";
            x.Range["F7"].Value = "ARACIN";
            x.Range["A8"].Value = "ADI-SOYADI";
            x.Range["D8"].Value = "ÜNVANI";
            x.Range["F10"].Value = "PLAKASI";
            x.Range["G11"].Value = "T.C KIRIKHAN İLÇE TARIM VE ORMAN MÜDÜRLÜĞÜ";
            x.Range["A14"].Value = "GÖREVİN TÜRÜ";
            x.Range["A15"].Value = "GİDECEĞİ YER";
            x.Range["F14"].Value = "ÇIKIŞ KM'Sİ";
            x.Range["G14"].Value = "DÖNÜŞ KM'Sİ";
            x.Range["F15"].Value = ".........";
            x.Range["G15"].Value = "..............";
            x.Range["C16"].Value = "      ADI SOYADI       ";
            x.Range["D16"].Value = "      Ünvanı     ";
            x.Range["E16"].Value = "      İmzası     ";
            x.Range["F16"].Value = "    ÇIKIŞ SAATİ    ";
            x.Range["G16"].Value = "    DÖNÜŞ SAATİ    ";
            x.Range["A25"].Value = "GÖREV DÖNÜŞ RAPORU";
            x.Range["A31"].Value = "YAPILAN ÇALIŞMANIN ÖZETİ";
            x.Range["A39"].Value = " GÖREVLİ PERSONELİN ADI SOYADI ";
            x.Range["D39"].Value = "İMAZSI";
            x.Range["E39"].Value = "İMAZSI";
            x.Range["F39"].Value = "ONAYLAYAN";
            x.Range["A16"].Value = "ONAYLAYAN";

            x.Range["A14"].RowHeight = 20;  //satır yüksekliği ayarlama
            x.Range["A15"].RowHeight = 28;
            x.Range["A16"].RowHeight = 22;
            x.Range["C17"].RowHeight = 23;
            x.Range["A39"].RowHeight = 34;

            Excel.Range last = x.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            Excel.Range rangeX = x.get_Range("A1", last); //A1'den Son Satıra Kadar alıp rangeX e aktardık
            rangeX.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; //A1'den Son Satıra Kadar Yazıları Ortalama
            rangeX.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter; //A1'den Son Satıra Kadar Yazıları Ortalama
            Excel.Borders xborder = rangeX.Borders;
            xborder.LineStyle = Excel.XlLineStyle.xlContinuous;
            xborder.Weight = 2d; //Kenarlığın kalınlığı

            x.Range["A2", "A3"].Font.Bold = true; //1. sütun 2. ve 3. satırı kalın yazırma

            //Aktarırken yazıları düzenli bir şekilde yazdırma
            excel.Columns.AutoFit();
            x.Range["F8"].Value = "SÜRÜCÜSÜNÜN ADI-SOYADI";
            x.Range["F11"].Value = "AİT OLDUĞU KURULUŞ";

            excel.Columns.WrapText = true;
            string[] cells1 = { "A18", "A19", "A20", "A21", "A22", "A23" };

            foreach (var x1 in cells1)
            {
                worksheet.get_Range(x1).Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                worksheet.get_Range(x1, x1).Cells.Font.Size = 9;
                x.Range[x1].RowHeight = 11;
            }

            string[] amirexcel = { "A6", "F6", "C17", "F40" };
            string[] amirexcel2 = { "C6", "G6", "D17" };

            x.Range["A18"].Value = "1-Taşıt Görev Emri her görevlendirmede iki nüsha doldurulacak, bir nüshası kurumda kalacak, ikinci nüshası araçta bulundurulacaktır.";
            x.Range["A19"].Value = "2-Taşıt Görev Emri yetkililerin istemesi halinde gösterilecektir.";
            x.Range["A20"].Value = "3- Araç sürücüleri ile araçta bulunan görevliler resmi sıfatın gerektirdiği saygınlığa uygun davranışlarda bulunacaktır.";
            x.Range["A21"].Value = "Sürücüler ve görevliler araç içinde sigara içmeyeceklerdir.";
            x.Range["A22"].Value = "4-Aracı kullanan kişi için her gün ayrı zimmet mümkün olmadığından görev kağıdında şoför olarak ismi yazılan kişi aracın herşeyinden";
            x.Range["A23"].Value = "sorumlu olup üzerine zimmetli sayılacaktır.";

            for (int i = 0; i <= dgvFull.Rows.Count - 1; i++)
            {
                x.Range["A" + (i + 9)].Value = dgvFull.Rows[i].Cells[1].Value.ToString(); //Personeller Ad exceldeki yerini belirleme
                x.Range["A" + (i + 40)].Value = dgvFull.Rows[i].Cells[1].Value.ToString(); //Personeller Ad exceldeki yerini belirleme
                x.Range["D" + (i + 9)].Value = dgvFull.Rows[i].Cells[3].Value.ToString(); //Personeller Birim exceldeki yerini belirleme
            }

            if (dgvFull.Rows.Count > 0)
            {
                foreach (var donus in amirexcel)
                {
                    x.Range[donus].Value = dgvFull.Rows[0].Cells[8].Value.ToString(); //Birim Amiri Ad exceldeki yerini belirleme
                }
                foreach (var donus2 in amirexcel2)
                {
                    x.Range[donus2].Value = dgvFull.Rows[0].Cells[10].Value.ToString(); //Birim Amiri Unvan exceldeki yerini belirleme
                }
                x.Range["G10"].Value = dgvFull.Rows[0].Cells[7].Value.ToString(); //Plaka exceldeki yerini belirleme
                x.Range["C14"].Value = dgvFull.Rows[0].Cells[5].Value.ToString(); //Görevin Türü exceldeki yerini belirleme
                x.Range["C15"].Value = dgvFull.Rows[0].Cells[4].Value.ToString(); //Gideceği Yer exceldeki yerini belirleme
                x.Range["G8"].Value = dgvFull.Rows[0].Cells[6].Value.ToString(); //Plaka exceldeki yerini belirleme
            }

            //Garbage Collection. Görev yöneticisinde sürekli açık kalan exceli kapatmak için aşaıdaki kod parçasını kullandık
            while (System.Runtime.InteropServices.Marshal.ReleaseComObject(excel) != 0) { }
            worksheet = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}


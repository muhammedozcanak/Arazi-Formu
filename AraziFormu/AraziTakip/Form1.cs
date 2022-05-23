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

namespace AraziTakip
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\AraziDB.mdb";
        }
        DataTable DT = new DataTable();
        DataTable DTfull = new DataTable();
        DataSet ds = new DataSet();
        //dgvPersonel Verileri Listeleme ve comboboxa aktarma
        void PersonelListele()
        {
            try
            {
                connection.Open();
                OleDbDataAdapter DA = new OleDbDataAdapter("select *from PersonelDb", connection);
                DA.Fill(DT);
                dgvPersonel.DataSource = DT;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Personel Bağlantısı Kurulamadı..." + ex);
            }
        }

        //Ad ve Soyad Birleştirip Comboboxa Aktarma İşlemi (Personel İçin)
        void birlestirPersonel()
        {
            connection.Open();
            OleDbCommand cmd = new OleDbCommand("Select Id, (Ad + ' ' + Soyad + ' - ' + SicilNo) as fullname from PersonelDb", connection);
            OleDbDataAdapter DA = new OleDbDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            DA.Fill(dt2);
            personelFull.DataSource = dt2;
            personelFull.DisplayMember = "fullname";
            personelFull.ValueMember = "Id";
            connection.Close();
        }

        //Ad ve Soyad Birleştirip Comboboxa Aktarma İşlemi (Amir için İçin)
        void birlestirAmir()
        {
            connection.Open();
            OleDbCommand cmd2 = new OleDbCommand("Select Id, (Ad + ' ' + Soyad + ' - ' + Birim + ' - ' + SicilNo) as fullname from PersonelDb", connection);
            OleDbDataAdapter DA2 = new OleDbDataAdapter(cmd2);
            DataTable dt3 = new DataTable();
            DA2.Fill(dt3);
            amirFull.DataSource = dt3;
            amirFull.DisplayMember = "fullname";
            amirFull.ValueMember = "Id";
            connection.Close();
        }

        //dgcKonum verileri listeleme
        void KonumListele()
        {
            try
            {
                DataSet ds = new DataSet();
                connection.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("Select *from Location", connection);
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

        void fullListe()
        {
            try
            {
                DTfull.Clear();
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
                IdFull.Text = row.Cells[0].Value.ToString();
                personelFull.Text = row.Cells[1].Value.ToString();
                konumFull.Text = row.Cells[2].Value.ToString();
                gorevFull.Text = row.Cells[3].Value.ToString();
                amirFull.Text = row.Cells[4].Value.ToString();
                aciklamaFull.Text = row.Cells[5].Value.ToString();
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
                OleDbCommand cmd = new OleDbCommand("insert into PersonelDb (Ad, Soyad, SicilNo, Birim, Tarih) values ('" + txtAd.Text.ToString().ToUpper() + "','" + txtSoyad.Text.ToString().ToUpper() + "','" + txtsicil.Text.ToString().ToUpper() + "','" + txtBirim.Text.ToString().ToUpper() + "','" + this.dateTimePicker1.Text + "')", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                DT.Clear();
                PersonelListele();
                MessageBox.Show("Kaydedildi", "Başarılı");
            }
        }

        //dgvPersonel Veri Güncelleme
        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if ((txtAd.Text == "") || (txtSoyad.Text == "") || (txtBirim.Text == "") || (txtId.Text == "") || (txtsicil.Text == ""))
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Satırı Seçin. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand();
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "update PersonelDb set Ad = '" + txtAd.Text.ToUpper() + "', Soyad = '" + txtSoyad.Text.ToUpper() + "', SicilNo = '" + txtsicil.Text.ToUpper() + "', Birim = '" + txtBirim.Text.ToUpper() + "', Tarih='" + this.dateTimePicker1.Text + "' where Id = " + txtId.Text + "";
                cmd.ExecuteNonQuery();
                connection.Close();
                DT.Clear();
                PersonelListele();
                MessageBox.Show("Güncellendi", "Başarılı");
            }

        }

        //dgvPersonel Veri Silme
        private void btnSil_Click(object sender, EventArgs e)
        {
            if ((txtAd.Text == "") || (txtSoyad.Text == "") || (txtsicil.Text == "") || (txtBirim.Text == "") || (txtId.Text == ""))
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
                    DT.Clear();
                    connection.Close();
                    PersonelListele();
                    MessageBox.Show("Silindi", "Başarılı");
                }
                else
                {
                    txtId.Text = "";
                }

            }
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
            OleDbDataAdapter DA = new OleDbDataAdapter("select *from PersonelDb where Id like '%" + PersonelAra.Text + "%' or Ad like '%" + PersonelAra.Text + "%' or Soyad like '%" + PersonelAra.Text + "%' or SicilNo like '%" + PersonelAra.Text + "%' or Birim like '%" + PersonelAra.Text + "%' or Tarih like '%" + PersonelAra.Text + "%'", connection);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            dgvPersonel.DataSource = DT;
            connection.Close();
            txtId.Text = "";

        }

        //dgvKonum Arama
        private void KonumAra_TextChanged(object sender, EventArgs e)
        {
            KonumAra.Text = KonumAra.Text.ToUpper();
            KonumAra.SelectionStart = KonumAra.Text.Length;

            connection.Open();
            OleDbCommand cmd2 = new OleDbCommand();
            cmd2.Connection = connection;
            string str = "select *from Location where Id like '%" + KonumAra.Text + "%' or İl like '%" + KonumAra.Text + "%' or İlçe like '%" + KonumAra.Text + "%' or Mahalle like '%" + KonumAra.Text + "%'";
            cmd2.CommandText = str;
            OleDbDataAdapter DA = new OleDbDataAdapter(cmd2);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            dgvKonum.DataSource = DT;
            connection.Close();
            KonumId.Text = "0";
        }

        //konum bilgisi kaydetme
        private void SaveLocation_Click(object sender, EventArgs e)
        {
            if ((txtil.Text == "") && (txtilce.Text == "") && (txtmah.Text == ""))
            {
                MessageBox.Show("Kayıt İşlemi Yapılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                OleDbCommand cmd2 = new OleDbCommand("insert into Location (İl, İlçe, Mahalle) values ('" + txtil.Text.ToString().ToUpper() + "','" + txtilce.Text.ToString().ToUpper() + "','" + txtmah.Text.ToString().ToUpper() + "')", connection);
                cmd2.ExecuteNonQuery();
                connection.Close();
                KonumListele();
                MessageBox.Show("Kaydedildi", "Başarılı");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboFull.SelectedIndex = 0;
            PersonelListele();
            KonumListele();
            birlestirAmir();
            birlestirPersonel();
        }
        //konum bilgisi silme
        private void DeleteLocation_Click(object sender, EventArgs e)
        {
            if (((txtil.Text == "") && (txtilce.Text == "") && (txtmah.Text == "")) || (KonumId.Text == "0"))
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
                    KonumListele();
                    MessageBox.Show("Silindi", "Başarılı");
                }
                else
                {
                    KonumId.Text = "";
                }
            }
        }
        //Konum bilgisi güncelleme
        private void UpdateLocation_Click(object sender, EventArgs e)
        {
            if ((txtil.Text == "") && (txtilce.Text == "") && (txtmah.Text == ""))
            {
                MessageBox.Show("Güncelleme İşlemi Yapılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OleDbCommand cmd2 = new OleDbCommand();
                connection.Open();
                cmd2.Connection = connection;
                cmd2.CommandText = "update Location set İl = '" + txtil.Text.ToUpper() + "', İlçe = '" + txtilce.Text.ToUpper() + "', Mahalle = '" + txtmah.Text.ToUpper() + "' where Id = " + KonumId.Text + "";
                cmd2.ExecuteNonQuery();
                connection.Close();
                KonumListele();
                MessageBox.Show("Güncellendi", "Başarılı");
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
        private void comboPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id1 = personelFull.SelectedValue.ToString();
            personId.Text = id1;
        }

        //electIndexChange seçim değişince ne yapılacağını seçmek için kullanılır
        private void comboAmir_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id2 = amirFull.SelectedValue.ToString();
            amirId.Text = id2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (personId.Text == "System.Data.DataRowView")
            {
                MessageBox.Show("Lütfen seçim yapın");
            }
        }

        private void fullSave_Click(object sender, EventArgs e)
        {
            if ((personelFull.Text == "") || (konumFull.Text == "") || (gorevFull.Text == "") || (amirFull.Text == ""))
            {
                MessageBox.Show("Kayıt İşlemi Yapılamadı Lütfen Tüm Boş Alanları Doldurun. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                OleDbCommand cmd3 = new OleDbCommand("insert into fullDb (Personel, Konum, GörevTürü, BirimAmiri, Açıklama, Tarih) values ('" + personelFull.Text.ToString().ToUpper() + "','" + konumFull.Text.ToString().ToUpper() + "','" + gorevFull.Text.ToString().ToUpper() + "','" + amirFull.Text.ToString().ToUpper() + "','" + aciklamaFull.Text.ToString().ToUpper() + "','" + this.dateTimePicker2.Text + "')", connection);
                cmd3.ExecuteNonQuery();
                connection.Close();
                fullListe();
                MessageBox.Show("Kaydedildi", "Başarılı");
            }
            comboFull.Text = "Tüm Aylar";
        }

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
                }
                else
                {
                    IdFull.Text = "";
                }
            }


            fullListe();
            comboFull.SelectedIndex = 0;
        }

        private void fullUpdate_Click(object sender, EventArgs e)
        {
            if (IdFull.Text == "")
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Satırı Seçin. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((personelFull.Text == "") || (konumFull.Text == "") || (gorevFull.Text == "") || (amirFull.Text == ""))
            {
                MessageBox.Show("Güncelleme İşlemi Yapılamadı Lütfen Tüm Boş Alanları Doldurun ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OleDbCommand cmd3 = new OleDbCommand();
                connection.Open();
                cmd3.Connection = connection;
                cmd3.CommandText = "update fullDb set Personel = '" + personelFull.Text.ToUpper() + "', Konum = '" + konumFull.Text.ToUpper() + "', GörevTürü = '" + gorevFull.Text.ToUpper() + "', BirimAmiri = '" + amirFull.Text.ToUpper() + "', Açıklama = '" + aciklamaFull.Text.ToUpper() + "',Tarih = '" + this.dateTimePicker2.Text + "' where Id = " + IdFull.Text + "";
                cmd3.ExecuteNonQuery();
                connection.Close();
                ds.Clear();
                fullListe();
                MessageBox.Show("Güncellendi", "Başarılı");
                fullAra.Text = "";
                comboFull.SelectedIndex = 0;
            }
        }

        private void fullAra_TextChanged(object sender, EventArgs e)
        {
            //Textboxa Harfleri Büyük Yazdırma
            fullAra.Text = fullAra.Text.ToUpper();
            fullAra.SelectionStart = fullAra.Text.Length;

            if (comboFull.Text == "Tüm Aylar")
            {
                DTfull.Clear();
                connection.Open();
                OleDbDataAdapter DA = new OleDbDataAdapter("select *from fullDb where Tarih like '%" + fullAra.Text + "%' or Id like '%" + fullAra.Text + "%' or Personel like '%" + fullAra.Text + "%' or Konum like '%" + fullAra.Text + "%' or GörevTürü like '%" + fullAra.Text + "%' or BirimAmiri like '%" + fullAra.Text + "%' or Açıklama like '%" + fullAra.Text + "%'", connection);
                DA.Fill(DTfull);
                dgvFull.DataSource = DTfull;
                connection.Close();
            }
            else
            {
                DTfull.Clear();
                connection.Open();
                OleDbDataAdapter DA = new OleDbDataAdapter("select *from fullDb where (Tarih like '___" + comboFull.Text.Substring(0, 2) + "%') and (Id like '%" + fullAra.Text + "%' or Personel like '%" + fullAra.Text + "%' or Konum like '%" + fullAra.Text + "%' or GörevTürü like '%" + fullAra.Text + "%' or BirimAmiri like '%" + fullAra.Text + "%' or Açıklama like '%" + fullAra.Text + "%')", connection);
                DA.Fill(DTfull);
                dgvFull.DataSource = DTfull;
                connection.Close();
            }

            IdFull.Text = "";
        }

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
            }
            else
            {
                DTfull.Clear();
                connection.Open();
                OleDbDataAdapter DA = new OleDbDataAdapter("select *from fullDb where Tarih like '___" + comboFull.Text.Substring(0, 2) + "%'", connection);
                DA.Fill(DTfull);
                dgvFull.DataSource = DTfull;
                connection.Close();
            }
        }

        private void enter(object sender, EventArgs e)
        {
            fullSave.BackColor = Color.Cornsilk;
            fullDelete.BackColor = Color.Cornsilk;
        }

        private void leave(object sender, EventArgs e)
        {

        }

        private void excell_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dgvFull.Columns.Count; j++)
            {
                Range exc = (Range)sheet1.Cells[StartRow, StartCol + j];
                exc.Value2 = dgvFull.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dgvFull.Rows.Count; i++)
            {
                for (int j = 0; j < dgvFull.Columns.Count; j++)
                {
                    Range exc = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    exc.Value2 = dgvFull[j, i].Value == null ? "" : dgvFull[j, i].Value;
                    exc.Select();
                }
            }
            excel.Columns.AutoFit();
        }
    }
}
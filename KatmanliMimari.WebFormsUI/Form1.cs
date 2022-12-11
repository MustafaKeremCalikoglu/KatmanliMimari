using KatmanliMimari.Business.Abstract;
using KatmanliMimari.Business.Concrete;
using KatmanliMimari.DataAccess.Concrete.EntityFramework;
using KatmanliMimari.DataAccess.Concrete.Mysql;
using KatmanliMimari.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatmanliMimari.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
     
            InitializeComponent();
            _catalogServis = new KategoriManager(new MysqlKategoriDal());
            _urunServis = new UrunManager(new MysqlUrunDal());
        }

        private IKatalogServis _catalogServis;
        private IUrunServis _urunServis;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUrunler();
            LoadKategori();
        }

        private void LoadKategori()
        {
            cmbKategori.DataSource = _catalogServis.GetAll();
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember="KategoriId";

            cmbKategori2.DataSource = _catalogServis.GetAll();
            cmbKategori2.DisplayMember = "KategoriAdi";
            cmbKategori2.ValueMember = "KategoriId";

            cmbKategoriGuncelle.DataSource = _catalogServis.GetAll();
            cmbKategoriGuncelle.DisplayMember = "KategoriAdi";
            cmbKategoriGuncelle.ValueMember = "KategoriId";

        }
        private void LoadUrunler()
        {
            dgwListele.DataSource = _urunServis.GetAll();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                dgwListele.DataSource = _urunServis.GetByKategoriId(Convert.ToInt32(cmbKategori.SelectedValue));

            }
            catch (Exception)
            {

            }
        }

        private void txtUrunIsmi_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUrunIsmi.Text))
            {
                dgwListele.DataSource = _urunServis.GetByUrunAdi(txtUrunIsmi.Text);
            }
            else
            {
                LoadUrunler();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _urunServis.Add(new urun
                {
                    UrunIsmi = txtUrunIsmiEkle.Text,
                    KategoriId = Convert.ToInt32(cmbKategori.SelectedValue),
                    Fiyat = Convert.ToInt32(txtFiyat.Text)


                });
                LoadUrunler();
                MessageBox.Show("eklendi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void dgwListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var Row=dgwListele.CurrentRow;
                txtFiyatGuncelle.Text = Row.Cells[3].Value.ToString();
                cmbKategoriGuncelle.SelectedValue=Row.Cells[1].Value;
                txtUrunIsmiGuncelle.Text = Row.Cells[2].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _urunServis.Update(new urun
            {
                UrunId = Convert.ToInt32(dgwListele.CurrentRow.Cells[0].Value),
                UrunIsmi=txtUrunIsmiGuncelle.Text,
                KategoriId = Convert.ToInt32(cmbKategoriGuncelle.SelectedValue),
                Fiyat = Convert.ToInt32(txtFiyatGuncelle.Text)

            });
            LoadUrunler();
            MessageBox.Show("güncellndi");

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgwListele.CurrentRow!=null)
            {
                try
                {
                    _urunServis.Delete(new urun
                    {
                        UrunId = Convert.ToInt32(dgwListele.CurrentRow.Cells[0].Value)

                    });
                    LoadUrunler();
                    MessageBox.Show("silindi");
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
            }


            
        }
    }
}

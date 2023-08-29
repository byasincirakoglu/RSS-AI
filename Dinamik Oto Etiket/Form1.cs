

using Dinamik_Oto_Etiket.DataConnection.MSSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Xml;
using System.Diagnostics;




namespace Dinamik_Oto_Etiket
{
    public partial class Form : System.Windows.Forms.Form
    {
        int rowIndex = -1;
        DataGridViewRow row;
        private string connectionString;
        private DataRow selectedRow = null;
        
        private int selectionColumnIndex;
        
       


        public Form()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
            //dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            //dataGridView1.GridColor = Color.Black; // Çerçeve rengini kırmızı olarak ayarlayın
            // DataGridView'ın özelliklerini ayarlayın
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.Black; // Çerçeve rengini kırmızı olarak ayarlayın
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gray; // Seçili hücre arka plan rengini gri yapın
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White; // Seçili hücre yazı rengini beyaz yapın

            // Çerçeve ve yazı rengini kalınlaştırmak için stil ayarları
            DataGridViewCellStyle boldCellStyle = new DataGridViewCellStyle();
            boldCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold); // Kalın yazı stili
            dataGridView1.ColumnHeadersDefaultCellStyle = boldCellStyle; // Sütun başlığı yazısı kalın
            dataGridView1.RowsDefaultCellStyle = boldCellStyle; // Satır içeriği kalın

            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single; // Satır başlığı çerçeve stilini ayarlayın
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single; // Sütun başlığı çerçeve stilini ayarlayın
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single; // Hücre çerçeve stilini ayarlayın
            dataGridView1.EnableHeadersVisualStyles = false; // Özel başlık stillerini kullanın

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Hücre içeriğini sar
                                                                                 // DataGridView'ın özelliklerini ayarlayın
            dataGridView1.RowTemplate.Height = 40; // Satır yüksekliğini ayarlayın


        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false; // Önemli: Varsayılan başlık stili devre dışı bırakılıyor
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black; // Sütun başlığı arka plan rengini ayarla
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Sütun başlığı yazı rengini ayarla
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold); // Sütun başlığı yazı tipini ve boyutunu ayarla
                                                                                                      // 1. sütundaki hücrelerin arka plan rengini ayarla
            int columnIndex = 1; // 1. sütunun sıfır tabanlı indeksi
            Color cellBackColor = Color.Black; // İstediğiniz arka plan rengi
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.BackColor = Color.Yellow; // İstediğiniz arka plan rengi

            
           











        }

        private void asdsaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dEPOLARToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }






        


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            txtArama.Text = txtArama.Text.ToUpper();
            txtArama.SelectionStart = txtArama.Text.Length; // Cursor'ı metin sonuna taşı

        }
        private void btnArama_Click(object sender, EventArgs e)
        {
            string arananMetin = txtArama.Text; // Aranan metni al
            string filterSql = "";
            if (!string.IsNullOrEmpty(arananMetin))
            {
                filterSql = "AND CARI_ISIM LIKE '%" + arananMetin+"%'";
            }
           
            DataTable filteredTable = DbConnection.RunSql("SELECT  dbo.turkceyok(CARI_KOD) as CARI_KOD ,   dbo.turkceyok(CARI_ISIM) as CARI_ISIM,dbo.turkceyok(CARI_ADRES) as CARI_ADRES, dbo.turkceyok(CARI_IL) as CARI_IL ,dbo.turkceyok(CARI_ILCE) as CARI_ILCE,CARI_TEL  FROM TBLCASABIT WHERE CARI_KOD LIKE 'ZZD%' " + filterSql);

            dataGridView1.DataSource = filteredTable;
            

        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAramaKod_TextChanged(object sender, EventArgs e)
        {
            txtAramaKod.Text = txtAramaKod.Text.ToUpper();
            txtAramaKod.SelectionStart = txtAramaKod.Text.Length; // Cursor'ı metin sonuna taşı
        }

        private void btnAramaKod_Click(object sender, EventArgs e)
        {
            string arananMetin = txtAramaKod.Text;
            string filterSql = "";
            if (!string.IsNullOrEmpty(arananMetin))
            {
                filterSql = "AND CARI_KOD LIKE '%" + arananMetin + "%'";
            }
            DataTable filteredTable = DbConnection.RunSql("SELECT  dbo.turkceyok(CARI_KOD) as CARI_KOD ,   dbo.turkceyok(CARI_ISIM) as CARI_ISIM,dbo.turkceyok(CARI_ADRES) as CARI_ADRES,  dbo.turkceyok(CARI_IL) as CARI_IL ,dbo.turkceyok(CARI_ILCE) as CARI_ILCE,CARI_TEL  FROM TBLCASABIT WHERE CARI_KOD LIKE 'ZZD%'" + filterSql);
            dataGridView1.DataSource = filteredTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        

       
        private void RefreshDataGridView()
        {
           

            dataGridView1.Refresh(); // DataGridView'i güncelle
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.selectedRow = ((DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem).Row;
            dataGridView1.Invalidate();
            dataGridView1.Refresh();
             
   

        }

        private void OnizlemeButton1_Click1(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                string cariTel = selectedRow["CARI_TEL"].ToString();
                string cariIl = selectedRow["CARI_IL"].ToString();
                string cariAdres = selectedRow["CARI_ADRES"].ToString();
                string cariIlce = selectedRow["CARI_ILCE"].ToString();
                string cariİsim = selectedRow["CARI_ISIM"].ToString();
               
                string htmlTemplate = @"
                 <html>
            <head>
            <style>
            @page {
                size: 300mm 200mm landscape; /* çıktı boyutları */
                margin: 0; /* Kenar boşluklarını sıfırlayın */
            }
            body {
                font-family: Arial, sans-serif;
                        background-image: url('arkaplan-resmi.jpg');
                        background-size: cover;
                        margin: 0;
                        padding: 20px;
            }
              
            .row {
                margin-bottom: 10px;
                transform: translateY(10mm); /* bütün içerikleri aşağı veya yukarı kaydırma yukarı kaydırmak için - değer ver */
                transform: translateX(0mm); /* 1 cm sağa kaydırma */
            }
            strong {
                font-weight: bold;
                font-size: 15px;
                color: #000000;
            }
            .row strong {
                white-space: nowrap;
                overflow: hidden;
                text-overflow: ellipsis;
            }
            .clearfix::after {
                content: "";
                display: table;
                clear: both;
            }
            </style>
            </head>
            <body>
                
            
                <div class='row'>
                    <strong>DİNAMİK OTOMOTİV GIDA TEKS.İTH.İHR.SAN.TİC LTD.ŞTİ</strong>
              
                </div>
                <div class='row'>
                 <strong>   FERHATPAŞA MAH ÜSKÜDAR CAD G15 SOK. NO:148</strong>
                </div>
                <div class='row'>
                 <strong>   ATAŞEHİR/İSTANBUL</strong>
                </div>
                <div class='row'>
                    <strong>Telefon: 0(216) 661 04 12</strong>
                </div>
                <div class='row'>
                   <strong>  Faks: 0(216) 661 04 14</strong>
                </div>
                <div class='divider' style='border-top: 3px solid black; width: 80%; margin: 5px 0;'></div> <!-- Çizgi Ekleniyor -->
            </div>
                  

            
                <div class='row'>
                    <strong>ALICI:" + cariİsim + @"</strong>  <strong>   
                </div>
                <div class='row'>
                    <div style=""width: 500px !important; font-size: 18px;font-weight: bold;"">  ADRES:  " + cariAdres + @"</div>
                </div>
                <div class='row'>
                 <strong>   TEL: " + cariTel + @"</strong>
                </div>
                <div class='row'>
                    <div style=""width: 400px !important; font-size: 30px;font-weight: bold;"">   " + cariIl + "/" + cariIlce + @"</div>
                </div>
            </div>

            </body>
            </html>
            ";

                string Filepath = @"C:\ETIKET\" + Guid.NewGuid() + ".html";
                File.WriteAllText(Filepath, htmlTemplate, Encoding.UTF8);

                Process.Start(new ProcessStartInfo("cmd", $"/c start {Filepath}") { CreateNoWindow = true });
            }


        }

        private void txtArama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // Enter tuşunun varsayılan davranışını engelle
                btnArama_Click(sender, e); // Ara butonunun tıklama olayını tetikle
            }

        }

        private void txtArama_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine(txtArama.Text);
        }

        private void txtAramaKod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // Enter tuşunun varsayılan davranışını engelle
                btnAramaKod_Click(sender, e); // Ara butonunun tıklama olayını tetikle
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
          
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }





        
    
   




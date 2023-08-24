

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
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }





        private void Form1_Load(object sender, EventArgs e)
        {






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

        }
        private void btnArama_Click(object sender, EventArgs e)
        {
            string arananMetin = txtArama.Text; // Aranan metni al
            string filterSql = "";
            if (!string.IsNullOrEmpty(arananMetin))
            {
                filterSql = "AND CARI_ISIM LIKE '%" + arananMetin+"%'";
            }
           
            DataTable filteredTable = DbConnection.RunSql("SELECT  dbo.turkceyok(CARI_ILCE) as CARI_ILCE ,   dbo.turkceyok(CARI_ISIM) as CARI_ISIM,CARI_KOD,CARI_TEL,dbo.turkceyok(CARI_IL) as CARI_IL, dbo.turkceyok(CARI_ADRES) as CARI_ADRES ,S_YEDEK2  FROM TBLCASABIT WHERE CARI_KOD LIKE 'ZZD%' " + filterSql);

            dataGridView1.DataSource = filteredTable;

        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAramaKod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAramaKod_Click(object sender, EventArgs e)
        {
            string arananMetin = txtAramaKod.Text;
            string filterSql = "";
            if (!string.IsNullOrEmpty(arananMetin))
            {
                filterSql = "AND CARI_KOD LIKE '%" + arananMetin + "%'";
            }
            DataTable filteredTable = DbConnection.RunSql("SELECT  dbo.turkceyok(CARI_ILCE) as CARI_ILCE ,   dbo.turkceyok(CARI_ISIM) as CARI_ISIM,CARI_KOD,CARI_TEL,dbo.turkceyok(CARI_IL) as CARI_IL, dbo.turkceyok(CARI_ADRES) as CARI_ADRES ,S_YEDEK2  FROM TBLCASABIT WHERE CARI_KOD LIKE 'ZZD%'"+ filterSql);
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
          
        }

        private void OnizlemeButton1_Click1(object sender, EventArgs e)
        { 
            if (selectedRow != null)
            {
                string cariTel = selectedRow["CARI_TEL"].ToString();
                string cariIl = selectedRow["CARI_IL"].ToString();
                string cariAdres = selectedRow["CARI_ADRES"].ToString();
                string cariIlce = selectedRow["CARI_ILCE"].ToString();
                string cariİsim = selectedRow["CARI_ISIM"].ToString() ;
                string htmlTemplate = @"
                 <html>
                 <head>
                 <style>
                 body {
                 font-weight:800; 
                 }                  
                 </style>
                 </head>
                 <body>
                 <p>DİNAMİK OTOMOTİV GIDA TEKS.İTH.İHR.SAN.TİC LTD.ŞTİ</p>
                 <p>FERHATPAŞA MAH ÜSKÜDAR CAD G15 SOK. NO:148</p>
                 <p>ATAŞEHİR/İSTANBUL</p>
                 <p>Telefon: 0(216) 661 04 12</p>
                 <p>Faks: 0(216) 661 04 14</p>
                 <p>ALICI:" + cariİsim + @"</p>
                 <p>ADRES: " + cariAdres + @"</p>
                 <p>TEL: " + cariTel + @"  </p>
                 <p>" + cariIl+"/" +cariIlce+ @"</p>
                 </body>
                 </html>";
                string Filepath = @"C:\ETIKET\" + Guid.NewGuid() + ".html";
                File.WriteAllText(Filepath, htmlTemplate, Encoding.UTF8);


                // Oluşturulan HTML dosyasını varsayılan web tarayıcınızda açın
                Process.Start(new ProcessStartInfo("cmd", $"/c start {Filepath}") { CreateNoWindow = true });
            }
        }
         
    }



}

        
    
   




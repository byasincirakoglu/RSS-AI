using Dinamik_Oto_Etiket.DataConnection.MSSQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamik_Oto_Etiket.Helper
{
    public static class Helper
    {
        public static void InitialData(DataGridView view) 
        {
            view.DataSource = DbConnection.RunSql("SELECT CARI_ISIM,CARI_ILCE,CARI_KOD,CARI_TEL,CARI_IL,CARI_ADRES,S_YEDEK2 FROM TBLCASABIT WHERE CARI_KOD LIKE 'ZZD%'");
        }
    }
}

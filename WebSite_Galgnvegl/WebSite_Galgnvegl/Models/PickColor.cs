using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using WebSite_Galgnvegl.Models;


namespace WebSite_Galgnvegl.Models
{
    public class PickColor
    {

        public string[] Colors = new string[] { "" };
        private AccountDBContent adb = new AccountDBContent();
        public Marketdatabase marketdatabase = new Marketdatabase();
        public MarketDBContent marketdbcontext = new MarketDBContent();

        public bool PickColors(AccountDBContent adb)
        {           
            int length;
            using (var cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename" +
                @"=|DataDirectory|\dbMarkt.mdf;" +
                @"Integrated Security=True"))
            {         
            
                string SELECT_COUNT_IDS = @"SELECT DISTINCT COUNT([AccountID]) FROM [dbo].[AccountDatabase]";
                
                var cmdCOUNT = new SqlCommand(SELECT_COUNT_IDS, cn);
                cn.Open();

                var readerCOUNT = cmdCOUNT.ExecuteReader();
                if (readerCOUNT.HasRows)
                {
                    length = readerCOUNT.GetInt32(0);
                }
                else
                {
                    return false;
                }
               
                string SELECT_COLORS = @"SELECT [AccountColor] FROM [dbo].[AccountDatabase] WHERE [AccountID] = @i";
                var cmdCOLORS = new SqlCommand(SELECT_COLORS, cn);
                for (int i = 0; i <= length; i++)
                {
                    cmdCOLORS.Parameters.Add(new SqlParameter("@i", SqlDbType.Int)).Value = i;
                    var readerCOLOR = cmdCOLORS.ExecuteReader();
                    cn.Open();

                    if (readerCOLOR.HasRows)
                    {
                        Colors[i] = readerCOLOR.GetString(0);
                    }                    
                }
                return true;  
            }

        }
    }
}
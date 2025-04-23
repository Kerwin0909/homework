using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace hw8
{
    class connect
    {
        SqlConnection con1;
        SqlDataReader rd;
        public  bool TestConSQL() { 
            string con = "Data Source=MSI;Initial Catalog=recite_word;Integrated Security=True";
            con1 = new SqlConnection(con);
            con1.Open();
            if (con1.State == ConnectionState.Open)
                return true;
            else
                return false;
            }
        int i = 0;
        string[] result1 = new string[99];
        public string [] Data()
        {
            string con = "Data Source=MSI;Initial Catalog=recite_word;Integrated Security=True";
            string[]result = new string[99];
            con1 = new SqlConnection(con);
            con1.Open();
            string sql = "SELECT Chinese,English FROM recite";
            SqlCommand cmd = new SqlCommand(sql,con1);
            rd= cmd.ExecuteReader();
            while (rd.Read())
            {
                result[i] = rd["Chinese"].ToString();
                result1[i] = rd["English"].ToString();
                i++;
            }
            return result;
        }
        public string[] Data1() {
            return result1;
        }
        public int num()
        {
            return i;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarun_video_rental_store
{
  public  class Sql_Connection
    {

        //instance of the global variable 

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader DReader;

        String connectionString = "Data Source=DESKTOP-HKD1BEO\\SQLEXPRESS;Initial Catalog=VideoStore_Tarun;Integrated Security=True";
        
        //this method is used to execute the sql query like insert delete update in the database tables
        public void Sql_Query(String query)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // this method is used to search the record from the data base and then pass the whole record to the query using where clause of the sql
        public DataTable Sql_Record(String qry)
        {
            DataTable tbl = new DataTable();

            conn = new SqlConnection(connectionString);

            conn.Open();

            cmd = new SqlCommand(qry, conn);

            DReader = cmd.ExecuteReader();

            tbl.Load(DReader);

            conn.Close();

            return tbl;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarun_video_rental_store
{
  public  class Client: Sql_Connection
    {
        /// <summary>
        /// get setter of the global variable to pass the values 
        /// </summary>
      public String Frst_Name { get; set; }
      public String Lst_Name { get; set; }
      public String Mobile { get; set; }
      public String Address { get; set; }
      public int Client_Id { get; set; }

        public Client() {

        }

        // parameterized constructor of the class that is used to insert  the vlue from local to global
        public  Client(String FName,String LName,String Mob,String Addss) {
            if (!FName.Equals("") && !LName.Equals("") && !Mob.Equals("") && !Addss.Equals("") && Convert.ToInt32(Mob)>0)
            {
                Frst_Name = FName;
                Lst_Name = LName;
                Mobile = Mob;
                Address = Addss;
                Frst_Name = Frst_Name +" "+ Lst_Name;
                String insert = "insert into ClientTable values('" + Frst_Name + "','" + Mobile + "','" + Address + "')";
                Sql_Query(insert);
                MessageBox.Show("Client Record is Saved ");
            }
            else {
                MessageBox.Show("Client Record is Not proper saved chek once again ");
            }
        }


        //parameterized constructor with single one parameter to del the client details 
        public Client(int id) {
            if (id > 0)
            {
                Client_Id = id;

                DataTable tbl = new DataTable();
                tbl = Sql_Record("select * from RentalTable where Client_Pk="+ Client_Id + " and ReturnDate='Rent'");
                if (tbl.Rows.Count > 0)
                {
                    String delete = "delete from ClientTable where Client_Pk=" + Client_Id + "";
                    Sql_Query(delete);
                    MessageBox.Show("Client Record is deleted ");
                }
                else {
                    MessageBox.Show("Client already have movie return firt ");
                }
                
            }
            else {
                MessageBox.Show("Must select the Id to delete ");
            }
        }


        // parameterized constructor of the class that is used to update  the value from the database 
        public Client(int id,String FName, String LName, String Mob, String Addss)
        {
            if (id>0 &&  !FName.Equals("") && !LName.Equals("") && !Mob.Equals("") && !Addss.Equals("") && Convert.ToInt32(Mob) > 0)
            {
                Client_Id = id;
                Frst_Name = FName;
                Lst_Name = LName;
                Mobile = Mob;
                Address = Addss;
                Frst_Name = Frst_Name +" "+ Lst_Name;
                String insert = "update  ClientTable set Client_Name='" + Frst_Name + "',Client_Mob='" + Mobile + "',Client_Address='" + Address + "' where Client_Pk="+Client_Id+"";
                Sql_Query(insert);
                MessageBox.Show("Client Record is Modified ");
            }
            else
            {
                MessageBox.Show("Client Record is Not proper saved chek once again ");
            }
        }


    }
}

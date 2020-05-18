using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarun_video_rental_store
{
   public class MovieBooking:Sql_Connection
    {
        //global variable 
        public int Book_Id { get; set; }
        public int Client_Id { get; set; }
        public int Movie_Id { get; set; }
        public String BookingDate { get; set; }
        public String ReturnDate { get; set; }


        public MovieBooking() {
                
        }
        //get the iinformation about  the customer  is that how much video is has aleady booked 
        public int ClientCopies(int C_Id) {
            DataTable tbl = new DataTable();
            tbl =Sql_Record( "select * from RentalTable where Client_Pk="+C_Id+ " and ReturnDate='Rent'");
            return tbl.Rows.Count;

        }

        //get the iinformation about  the videos  is that how much video is has aleady booked 
        public int VideoBookedCopies(int C_Id)
        {
            DataTable tbl = new DataTable();
            tbl = Sql_Record("select * from RentalTable where Movie_Pk=" + C_Id + " and ReturnDate='Rent'");
            return tbl.Rows.Count;

        }

        //get the iinformation about  the Video is that how much sample we have 
        public int VideoCopies(int C_Id)
        {
            DataTable tbl = new DataTable();
            tbl = Sql_Record("select * from MovieTable where Movie_Pk=" + C_Id + "");
            return Convert.ToInt32(tbl.Rows[0]["Movie_Copies"].ToString());

        }


        
        //single parameterized constructor to delete 
        public MovieBooking(int RentId) {
            if (RentId > 0)
            {
                Book_Id = RentId;
                String delete = "delete from RentalTable where Book_Id=" + Book_Id + "";
                Sql_Query(delete);
                MessageBox.Show("Record is deleted ");
            }
            else {
                MessageBox.Show("Select the Rental video to delete ");
            }
        }


        public MovieBooking(int Rent_Id,int C_Id, int M_Id, String Book_Date,String Return_Date)
        {
            if (Rent_Id > 0 && C_Id > 0 && M_Id > 0)
            {
                Book_Id = Rent_Id;
                Client_Id = C_Id;
                Movie_Id = M_Id;
                BookingDate = Book_Date;
                ReturnDate = Return_Date;

                String Booking = "update RentalTable set Client_Pk=" + Client_Id + ",Movie_Pk=" + Movie_Id + ",BookingDate='" + BookingDate + "',ReturnDate='"+ReturnDate+ "' where Book_Id=" + Book_Id + "";
                Sql_Query(Booking);


            }
            else {
                MessageBox.Show("Select the video to return ");
            }

        }

            public MovieBooking(int C_Id,int M_Id,String Book_Date) {
            
            if (C_Id>0 && M_Id>0) {


                Client_Id = C_Id;
                Movie_Id = M_Id;
                BookingDate = Book_Date;

                if (ClientCopies(C_Id) < 2)
                {
                    if (VideoBookedCopies(Movie_Id) < VideoCopies(Movie_Id))
                    {

                        String Booking = "insert into RentalTable values(" + Client_Id + "," + Movie_Id + ",'" + BookingDate + "','Rent')";
                        Sql_Query(Booking);

                    }
                    else {
                        MessageBox.Show("All Sample are already Booked ");
                    }

                }
                else {
                    MessageBox.Show("You already reach the limit to bbok  the video ");
                }
                
            }
            else {
                MessageBox.Show(" Select the movie and Client to Book the movie ");  
            }

        }



    }
}

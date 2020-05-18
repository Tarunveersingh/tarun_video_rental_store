using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarun_video_rental_store
{
    public class Movie : Sql_Connection
    {
        //getter setter of the class that is used to perform  the all task 
        public int Movie_Id { get; set; }
        public String Movie_Title { get; set; }
        public String Movie_Ratting { get; set; }
        public int Year { get; set; }
        public int Copies { get; set; }
        public int Cost { get; set; }
        public String Plot { get; set; }
        public String Genre { get; set; }


        public Movie() {
                
        }

        //parameterized constructor to insert the value 
        public Movie(String Title,String Ratting, int year,int copies,int cost,String plot,String genre) {
            Movie_Title = Title;
            Movie_Ratting = Ratting;
            Year = year;
            Copies = copies;
            Cost = cost;
            Plot = plot;
            Genre = genre;

            String Insert = "insert into MovieTable values('"+Movie_Title+"','"+Movie_Ratting+"',"+Year+","+Copies+","+Cost+",'"+Plot+"','"+Genre+"')";
            Sql_Query(Insert);
            MessageBox.Show("All values are stored ");

        }

        //parameterized constructor to Update the value 
        public Movie(int Id,String Title, String Ratting, int year, int copies, int cost, String plot, String genre)
        {
            Movie_Id = Id;
            Movie_Title = Title;
            Movie_Ratting = Ratting;
            Year = year;
            Copies = copies;
            Cost = cost;
            Plot = plot;
            Genre = genre;

            String Insert = "Update MovieTable set Movie_Title='" + Movie_Title + "',Movie_Ratting='" + Movie_Ratting + "',Movie_Year=" + Year + ",Movie_Copies=" + Copies + ",Movie_Cost=" + Cost + ",Movie_Plot='" + Plot + "',Movie_Genre='" + Genre + "' where Movie_Pk="+Movie_Id+"";
            Sql_Query(Insert);
            MessageBox.Show(" Record is Modified ");

        }

        //costructor to delete the movie details with single one parameter 
        public Movie(int id) {
            Movie_Id = id;
            if (Movie_Id > 0)
            {
                DataTable tbl = new DataTable();
                tbl = Sql_Record("select * from RentalTable where Movie_Pk=" + Movie_Id + " and ReturnDate='Rent'");
                if (tbl.Rows.Count > 0)
                {
                    String delete = "delete from MovieTable where Movie_Pk=" + Movie_Id + "";
                    Sql_Query(delete);
                    MessageBox.Show("Movie Record is deleted ");
                }
                else
                {
                    MessageBox.Show("Movie already booked ");
                }

            }
            else {
                MessageBox.Show("Select the Movie Id to delete ");
            }
        }



        //check the cost of the year 
        public int checkCost(int Year) {

            DateTime dateNow = DateTime.Now;

            int Currentyear = dateNow.Year;

            int Year_Difference = Currentyear - Year;
            int cost = 0;
            if (Year_Difference>=5) {
                cost=2;
            } else {
                if (Year_Difference>=0) {
                    cost = 5;
                }
            }
            return cost;
        }

    }
}

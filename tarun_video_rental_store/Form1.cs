using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarun_video_rental_store
{
    public partial class Form1 : Form
    {
        int rentId = 0;
        String record = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dtp_IssueDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_MovieID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_CustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_DeleteVideo_Click(object sender, EventArgs e)
        {
            // delete the movie to delete
            MovieBooking obj = new MovieBooking(rentId);


            txt_CustomerID.Text = "";
            txt_MovieID.Text = "";
            tarun_CustomerAddress.Text = "";
            tarun_CustomerFName.Text = "";
            tarun_CustomerLName.Text = "";
            tarun_CustomerMobile.Value = 0;
            tarun_VideoTitle.Text = "";
            tarun_VideoRatting.Text = "";
            tarun_movie_year.Text = "";
            tarun_VideoCopies.Value = 0;
            tarun_VideoCost.Value = 0;
            tarun_VideoPlot.Text = "";
            tarun_VideoGenre.Text = "";
            rentId = 0;



        }

        private void btn_ReturnVideo_Click(object sender, EventArgs e)
        {
           /* try
            {
            */
                MovieBooking obj = new MovieBooking(rentId, Convert.ToInt32(txt_CustomerID.Text), Convert.ToInt32(txt_MovieID.Text), dtp_IssueDate.Text, dtp_ReturnDate.Text);

                DateTime new_date = DateTime.Now;


                Movie objct = new Movie();

                

                //convert the old date from string to Date fromat
                DateTime prev_date = Convert.ToDateTime(dtp_IssueDate.Text);


                //get the difference in the days fromat
                String Daysdiff = (new_date - prev_date).TotalDays.ToString();


                // calculate the round off value 
                Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));


                string query1 = "select * from MovieTable where Movie_Pk=" + Convert.ToInt32(txt_MovieID.Text) + "";
                DataTable tbl1 = new DataTable();
                tbl1 = objct.Sql_Record(query1);
                int cost = Convert.ToInt32(tbl1.Rows[0]["Movie_Cost"]);




                int Price = Convert.ToInt32(DaysInterval) * cost;

                MessageBox.Show("Your bill is: " + Price);


            /*
            }
            catch (Exception ex)
            {
                MessageBox.Show("select the video to return ");
            }
            finally {*/
                txt_CustomerID.Text = "";
                txt_MovieID.Text = "";

                tarun_CustomerAddress.Text = "";
                tarun_CustomerFName.Text = "";
                tarun_CustomerLName.Text = "";
                tarun_CustomerMobile.Value = 0;
                tarun_VideoTitle.Text = "";
                tarun_VideoRatting.Text = "";
                tarun_movie_year.Text = "";
                tarun_VideoCopies.Value = 0;
                tarun_VideoCost.Value = 0;
                tarun_VideoPlot.Text = "";
                tarun_VideoGenre.Text = "";


           // }






        }

        private void btn_BookVideo_Click(object sender, EventArgs e)
        {
            MovieBooking obj = new MovieBooking(Convert.ToInt32(txt_CustomerID.Text), Convert.ToInt32(txt_MovieID.Text),dtp_IssueDate.Text);

            txt_CustomerID.Text = "";
            txt_MovieID.Text = "";

            tarun_CustomerAddress.Text = "";
            tarun_CustomerFName.Text = "";
            tarun_CustomerLName.Text = "";
            tarun_CustomerMobile.Value = 0;
            tarun_VideoTitle.Text = "";
            tarun_VideoRatting.Text = "";
            tarun_movie_year.Text = "";
            tarun_VideoCopies.Value = 0;
            tarun_VideoCost.Value = 0;
            tarun_VideoPlot.Text = "";
            tarun_VideoGenre.Text = "";


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dtp_ReturnDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tarun_CustomerAdd_Click(object sender, EventArgs e)
        {
            Client obj = new Client(tarun_CustomerFName.Text,tarun_CustomerLName.Text,tarun_CustomerMobile.Value.ToString(),tarun_CustomerAddress.Text);

            tarun_CustomerAddress.Text = "";
            tarun_CustomerFName.Text = "";
            tarun_CustomerLName.Text = "";
            tarun_CustomerMobile.Value = 0;
            
        }

        private void tarun_Customer_Delete_Click(object sender, EventArgs e)
        {
            try {
                //calling the paramterized constructor with one parameter to delete the customer delete 

                Client obj = new Client(Convert.ToInt32(txt_CustomerID.Text.ToString()));

            }
            catch (Exception ex) {
                MessageBox.Show("select the Client ID first to delete ");
            }


            tarun_CustomerAddress.Text = "";
            tarun_CustomerFName.Text = "";
            tarun_CustomerLName.Text = "";
            tarun_CustomerMobile.Value = 0;
            txt_CustomerID.Text = "";

        }

        private void tarun_CustomerUpdate_Click(object sender, EventArgs e)
        {
            try {
                Client obj=new Client(Convert.ToInt32(txt_CustomerID.Text.ToString()),tarun_CustomerFName.Text, tarun_CustomerLName.Text, tarun_CustomerMobile.Value.ToString(), tarun_CustomerAddress.Text);
            }
            catch (Exception ex) {
                MessageBox.Show("select the Client ID first to delete and fill all the details ");
            }

            tarun_CustomerAddress.Text = "";
            tarun_CustomerFName.Text = "";
            tarun_CustomerLName.Text = "";
            tarun_CustomerMobile.Value = 0;
            txt_CustomerID.Text = "";

        }

        private void tarun_VideoAdd_Click(object sender, EventArgs e)
        {
            Movie obj = new Movie(tarun_VideoTitle.Text,tarun_VideoRatting.Text,Convert.ToInt32(tarun_movie_year.Text.ToString()),Convert.ToInt32(tarun_VideoCopies.Value),Convert.ToInt32(tarun_VideoCost.Value),tarun_VideoPlot.Text,tarun_VideoGenre.Text);

            tarun_VideoTitle.Text = "";
            tarun_VideoRatting.Text = "";
            tarun_movie_year.Text = "";
            tarun_VideoCopies.Value = 0;
            tarun_VideoCost.Value = 0;
            tarun_VideoPlot.Text = "";
            tarun_VideoGenre.Text = "";


        }

        private void tarun_VideoDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Movie obj = new Movie(Convert.ToInt32(txt_MovieID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select the Movie id first ");
            }
            finally {

                tarun_VideoTitle.Text = "";
                tarun_VideoRatting.Text = "";
                tarun_movie_year.Text = "";
                tarun_VideoCopies.Value = 0;
                tarun_VideoCost.Value = 0;
                tarun_VideoPlot.Text = "";
                tarun_VideoGenre.Text = "";
                txt_MovieID.Text = "";
            }




        }

        private void tarun_movie_year_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Movie obj = new Movie();
                tarun_VideoCost.Text = "" + obj.checkCost(Convert.ToInt32(tarun_movie_year.Text.ToString()));
            }
            catch (Exception ex) {

            }
        }

        private void tarun_VideoUpdate_Click(object sender, EventArgs e)
        {
            try
            {


                Movie obj = new Movie(Convert.ToInt32(txt_MovieID.Text), tarun_VideoTitle.Text, tarun_VideoRatting.Text, Convert.ToInt32(tarun_movie_year.Text.ToString()), Convert.ToInt32(tarun_VideoCopies.Value), Convert.ToInt32(tarun_VideoCost.Value), tarun_VideoPlot.Text, tarun_VideoGenre.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill all the details");
            }
            finally
            {
                tarun_VideoTitle.Text = "";
                tarun_VideoRatting.Text = "";
                tarun_movie_year.Text = "";
                tarun_VideoCopies.Value = 0;
                tarun_VideoCost.Value = 0;
                tarun_VideoPlot.Text = "";
                tarun_VideoGenre.Text = "";
                txt_MovieID.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client obj = new Client();
            DataTable tbl = new DataTable();
            tbl = obj.Sql_Record("select * from ClientTable");
            dgvTable.DataSource = tbl;
            record ="customer";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movie obj = new Movie();
            DataTable tbl = new DataTable();
            tbl = obj.Sql_Record("select * from MovieTable");
            dgvTable.DataSource = tbl;
            record = "movie";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MovieBooking obj = new MovieBooking();
            DataTable tbl = new DataTable();
            tbl = obj.Sql_Record("select * from RentalTable");
            dgvTable.DataSource = tbl;
            record = "rental";
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (record.Equals("customer"))
            {
                txt_CustomerID.Text = dgvTable.CurrentRow.Cells[0].Value.ToString();
                String[] nm = dgvTable.CurrentRow.Cells[1].Value.ToString().Split(' ');
                tarun_CustomerFName.Text = nm[0];
                tarun_CustomerLName.Text = nm[1];

                tarun_CustomerMobile.Value = Convert.ToInt32(dgvTable.CurrentRow.Cells[2].Value.ToString());
                tarun_CustomerAddress.Text = dgvTable.CurrentRow.Cells[3].Value.ToString();

            }
            else if (record.Equals("movie"))
            {

                txt_MovieID.Text = dgvTable.CurrentRow.Cells[0].Value.ToString();
                tarun_VideoTitle.Text = dgvTable.CurrentRow.Cells[1].Value.ToString();
                tarun_VideoRatting.Text = dgvTable.CurrentRow.Cells[2].Value.ToString();
                tarun_movie_year.Text = dgvTable.CurrentRow.Cells[3].Value.ToString();
                tarun_VideoCopies.Value = Convert.ToInt32(dgvTable.CurrentRow.Cells[4].Value.ToString());
                tarun_VideoCost.Value = Convert.ToInt32(dgvTable.CurrentRow.Cells[5].Value.ToString());
                tarun_VideoPlot.Text = dgvTable.CurrentRow.Cells[6].Value.ToString();
                tarun_VideoPlot.Text = dgvTable.CurrentRow.Cells[7].Value.ToString();


            }
            else if (record.Equals("rental"))
            {

                rentId = Convert.ToInt32(dgvTable.CurrentRow.Cells[0].Value.ToString());
                txt_CustomerID.Text = dgvTable.CurrentRow.Cells[1].Value.ToString();
                txt_MovieID.Text = dgvTable.CurrentRow.Cells[2].Value.ToString();
                dtp_IssueDate.Text = dgvTable.CurrentRow.Cells[3].Value.ToString();
            }
            else {
                MessageBox.Show("Select the option first ");
            }

            record = "";

        }
    }
}

namespace tarun_video_rental_store
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tarun_movie_year = new System.Windows.Forms.TextBox();
            this.tarun_VideoDelete = new System.Windows.Forms.Button();
            this.tarun_VideoUpdate = new System.Windows.Forms.Button();
            this.tarun_VideoAdd = new System.Windows.Forms.Button();
            this.tarun_VideoCopies = new System.Windows.Forms.NumericUpDown();
            this.tarun_VideoCost = new System.Windows.Forms.NumericUpDown();
            this.tarun_VideoGenre = new System.Windows.Forms.TextBox();
            this.tarun_VideoPlot = new System.Windows.Forms.TextBox();
            this.tarun_VideoRatting = new System.Windows.Forms.TextBox();
            this.tarun_VideoTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tarun_CustomerMobile = new System.Windows.Forms.NumericUpDown();
            this.tarun_Customer_Delete = new System.Windows.Forms.Button();
            this.tarun_CustomerUpdate = new System.Windows.Forms.Button();
            this.tarun_CustomerAdd = new System.Windows.Forms.Button();
            this.tarun_CustomerAddress = new System.Windows.Forms.TextBox();
            this.tarun_CustomerLName = new System.Windows.Forms.TextBox();
            this.tarun_CustomerFName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtp_ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_IssueDate = new System.Windows.Forms.DateTimePicker();
            this.txt_MovieID = new System.Windows.Forms.TextBox();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.btn_DeleteVideo = new System.Windows.Forms.Button();
            this.btn_ReturnVideo = new System.Windows.Forms.Button();
            this.btn_BookVideo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarun_VideoCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarun_VideoCost)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarun_CustomerMobile)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(108, -16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video Rental Store";
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(12, 130);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(861, 204);
            this.dgvTable.TabIndex = 1;
            this.dgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellClick);
            this.dgvTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(151, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Customers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(411, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Videos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkRed;
            this.button3.Location = new System.Drawing.Point(662, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "Rentals";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tarun_movie_year);
            this.groupBox1.Controls.Add(this.tarun_VideoDelete);
            this.groupBox1.Controls.Add(this.tarun_VideoUpdate);
            this.groupBox1.Controls.Add(this.tarun_VideoAdd);
            this.groupBox1.Controls.Add(this.tarun_VideoCopies);
            this.groupBox1.Controls.Add(this.tarun_VideoCost);
            this.groupBox1.Controls.Add(this.tarun_VideoGenre);
            this.groupBox1.Controls.Add(this.tarun_VideoPlot);
            this.groupBox1.Controls.Add(this.tarun_VideoRatting);
            this.groupBox1.Controls.Add(this.tarun_VideoTitle);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(29, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 348);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Movie";
            // 
            // tarun_movie_year
            // 
            this.tarun_movie_year.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarun_movie_year.Location = new System.Drawing.Point(127, 96);
            this.tarun_movie_year.Name = "tarun_movie_year";
            this.tarun_movie_year.Size = new System.Drawing.Size(154, 32);
            this.tarun_movie_year.TabIndex = 210;
            this.tarun_movie_year.TextChanged += new System.EventHandler(this.tarun_movie_year_TextChanged);
            // 
            // tarun_VideoDelete
            // 
            this.tarun_VideoDelete.BackColor = System.Drawing.Color.Gray;
            this.tarun_VideoDelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarun_VideoDelete.Location = new System.Drawing.Point(196, 282);
            this.tarun_VideoDelete.Name = "tarun_VideoDelete";
            this.tarun_VideoDelete.Size = new System.Drawing.Size(85, 32);
            this.tarun_VideoDelete.TabIndex = 209;
            this.tarun_VideoDelete.Text = "Delete";
            this.tarun_VideoDelete.UseVisualStyleBackColor = false;
            this.tarun_VideoDelete.Click += new System.EventHandler(this.tarun_VideoDelete_Click);
            // 
            // tarun_VideoUpdate
            // 
            this.tarun_VideoUpdate.BackColor = System.Drawing.Color.Gray;
            this.tarun_VideoUpdate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarun_VideoUpdate.Location = new System.Drawing.Point(105, 282);
            this.tarun_VideoUpdate.Name = "tarun_VideoUpdate";
            this.tarun_VideoUpdate.Size = new System.Drawing.Size(85, 32);
            this.tarun_VideoUpdate.TabIndex = 208;
            this.tarun_VideoUpdate.Text = "Update";
            this.tarun_VideoUpdate.UseVisualStyleBackColor = false;
            this.tarun_VideoUpdate.Click += new System.EventHandler(this.tarun_VideoUpdate_Click);
            // 
            // tarun_VideoAdd
            // 
            this.tarun_VideoAdd.BackColor = System.Drawing.Color.Gray;
            this.tarun_VideoAdd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarun_VideoAdd.Location = new System.Drawing.Point(14, 280);
            this.tarun_VideoAdd.Name = "tarun_VideoAdd";
            this.tarun_VideoAdd.Size = new System.Drawing.Size(85, 32);
            this.tarun_VideoAdd.TabIndex = 207;
            this.tarun_VideoAdd.Text = "Add";
            this.tarun_VideoAdd.UseVisualStyleBackColor = false;
            this.tarun_VideoAdd.Click += new System.EventHandler(this.tarun_VideoAdd_Click);
            // 
            // tarun_VideoCopies
            // 
            this.tarun_VideoCopies.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarun_VideoCopies.Location = new System.Drawing.Point(127, 135);
            this.tarun_VideoCopies.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.tarun_VideoCopies.Name = "tarun_VideoCopies";
            this.tarun_VideoCopies.Size = new System.Drawing.Size(154, 29);
            this.tarun_VideoCopies.TabIndex = 206;
            // 
            // tarun_VideoCost
            // 
            this.tarun_VideoCost.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarun_VideoCost.Location = new System.Drawing.Point(127, 171);
            this.tarun_VideoCost.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.tarun_VideoCost.Name = "tarun_VideoCost";
            this.tarun_VideoCost.Size = new System.Drawing.Size(154, 29);
            this.tarun_VideoCost.TabIndex = 205;
            // 
            // tarun_VideoGenre
            // 
            this.tarun_VideoGenre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarun_VideoGenre.Location = new System.Drawing.Point(127, 244);
            this.tarun_VideoGenre.Name = "tarun_VideoGenre";
            this.tarun_VideoGenre.Size = new System.Drawing.Size(154, 32);
            this.tarun_VideoGenre.TabIndex = 203;
            // 
            // tarun_VideoPlot
            // 
            this.tarun_VideoPlot.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarun_VideoPlot.Location = new System.Drawing.Point(127, 206);
            this.tarun_VideoPlot.Name = "tarun_VideoPlot";
            this.tarun_VideoPlot.Size = new System.Drawing.Size(154, 32);
            this.tarun_VideoPlot.TabIndex = 202;
            // 
            // tarun_VideoRatting
            // 
            this.tarun_VideoRatting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarun_VideoRatting.Location = new System.Drawing.Point(127, 58);
            this.tarun_VideoRatting.Name = "tarun_VideoRatting";
            this.tarun_VideoRatting.Size = new System.Drawing.Size(154, 32);
            this.tarun_VideoRatting.TabIndex = 201;
            // 
            // tarun_VideoTitle
            // 
            this.tarun_VideoTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarun_VideoTitle.Location = new System.Drawing.Point(127, 20);
            this.tarun_VideoTitle.Name = "tarun_VideoTitle";
            this.tarun_VideoTitle.Size = new System.Drawing.Size(154, 32);
            this.tarun_VideoTitle.TabIndex = 200;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LemonChiffon;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 199;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LemonChiffon;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 24);
            this.label6.TabIndex = 198;
            this.label6.Text = "Plot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LemonChiffon;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 197;
            this.label5.Text = "Copies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LemonChiffon;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 196;
            this.label4.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LemonChiffon;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 195;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 194;
            this.label2.Text = "Ratting";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.LemonChiffon;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(26, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 24);
            this.label16.TabIndex = 193;
            this.label16.Text = "Title";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tarun_CustomerMobile);
            this.groupBox2.Controls.Add(this.tarun_Customer_Delete);
            this.groupBox2.Controls.Add(this.tarun_CustomerUpdate);
            this.groupBox2.Controls.Add(this.tarun_CustomerAdd);
            this.groupBox2.Controls.Add(this.tarun_CustomerAddress);
            this.groupBox2.Controls.Add(this.tarun_CustomerLName);
            this.groupBox2.Controls.Add(this.tarun_CustomerFName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(348, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 339);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Customer ";
            // 
            // tarun_CustomerMobile
            // 
            this.tarun_CustomerMobile.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarun_CustomerMobile.Location = new System.Drawing.Point(132, 117);
            this.tarun_CustomerMobile.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.tarun_CustomerMobile.Name = "tarun_CustomerMobile";
            this.tarun_CustomerMobile.Size = new System.Drawing.Size(154, 29);
            this.tarun_CustomerMobile.TabIndex = 192;
            // 
            // tarun_Customer_Delete
            // 
            this.tarun_Customer_Delete.BackColor = System.Drawing.Color.DimGray;
            this.tarun_Customer_Delete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarun_Customer_Delete.Location = new System.Drawing.Point(12, 235);
            this.tarun_Customer_Delete.Name = "tarun_Customer_Delete";
            this.tarun_Customer_Delete.Size = new System.Drawing.Size(274, 37);
            this.tarun_Customer_Delete.TabIndex = 191;
            this.tarun_Customer_Delete.Text = "Delete";
            this.tarun_Customer_Delete.UseVisualStyleBackColor = false;
            this.tarun_Customer_Delete.Click += new System.EventHandler(this.tarun_Customer_Delete_Click);
            // 
            // tarun_CustomerUpdate
            // 
            this.tarun_CustomerUpdate.BackColor = System.Drawing.Color.DimGray;
            this.tarun_CustomerUpdate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarun_CustomerUpdate.Location = new System.Drawing.Point(132, 197);
            this.tarun_CustomerUpdate.Name = "tarun_CustomerUpdate";
            this.tarun_CustomerUpdate.Size = new System.Drawing.Size(154, 32);
            this.tarun_CustomerUpdate.TabIndex = 190;
            this.tarun_CustomerUpdate.Text = "Update";
            this.tarun_CustomerUpdate.UseVisualStyleBackColor = false;
            this.tarun_CustomerUpdate.Click += new System.EventHandler(this.tarun_CustomerUpdate_Click);
            // 
            // tarun_CustomerAdd
            // 
            this.tarun_CustomerAdd.BackColor = System.Drawing.Color.DimGray;
            this.tarun_CustomerAdd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarun_CustomerAdd.Location = new System.Drawing.Point(10, 197);
            this.tarun_CustomerAdd.Name = "tarun_CustomerAdd";
            this.tarun_CustomerAdd.Size = new System.Drawing.Size(101, 32);
            this.tarun_CustomerAdd.TabIndex = 188;
            this.tarun_CustomerAdd.Text = "Add";
            this.tarun_CustomerAdd.UseVisualStyleBackColor = false;
            this.tarun_CustomerAdd.Click += new System.EventHandler(this.tarun_CustomerAdd_Click);
            // 
            // tarun_CustomerAddress
            // 
            this.tarun_CustomerAddress.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarun_CustomerAddress.Location = new System.Drawing.Point(132, 153);
            this.tarun_CustomerAddress.Name = "tarun_CustomerAddress";
            this.tarun_CustomerAddress.Size = new System.Drawing.Size(154, 32);
            this.tarun_CustomerAddress.TabIndex = 189;
            // 
            // tarun_CustomerLName
            // 
            this.tarun_CustomerLName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarun_CustomerLName.Location = new System.Drawing.Point(132, 77);
            this.tarun_CustomerLName.Name = "tarun_CustomerLName";
            this.tarun_CustomerLName.Size = new System.Drawing.Size(154, 32);
            this.tarun_CustomerLName.TabIndex = 187;
            // 
            // tarun_CustomerFName
            // 
            this.tarun_CustomerFName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarun_CustomerFName.Location = new System.Drawing.Point(132, 39);
            this.tarun_CustomerFName.Name = "tarun_CustomerFName";
            this.tarun_CustomerFName.Size = new System.Drawing.Size(154, 32);
            this.tarun_CustomerFName.TabIndex = 186;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 185;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 24);
            this.label9.TabIndex = 184;
            this.label9.Text = "Mobile No.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 24);
            this.label10.TabIndex = 183;
            this.label10.Text = "Last Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 24);
            this.label11.TabIndex = 182;
            this.label11.Text = "First Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp_ReturnDate);
            this.groupBox3.Controls.Add(this.dtp_IssueDate);
            this.groupBox3.Controls.Add(this.txt_MovieID);
            this.groupBox3.Controls.Add(this.txt_CustomerID);
            this.groupBox3.Controls.Add(this.btn_DeleteVideo);
            this.groupBox3.Controls.Add(this.btn_ReturnVideo);
            this.groupBox3.Controls.Add(this.btn_BookVideo);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(682, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 330);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movie";
            // 
            // dtp_ReturnDate
            // 
            this.dtp_ReturnDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ReturnDate.Location = new System.Drawing.Point(168, 155);
            this.dtp_ReturnDate.Name = "dtp_ReturnDate";
            this.dtp_ReturnDate.Size = new System.Drawing.Size(154, 32);
            this.dtp_ReturnDate.TabIndex = 205;
            this.dtp_ReturnDate.ValueChanged += new System.EventHandler(this.dtp_ReturnDate_ValueChanged);
            // 
            // dtp_IssueDate
            // 
            this.dtp_IssueDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_IssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_IssueDate.Location = new System.Drawing.Point(168, 112);
            this.dtp_IssueDate.Name = "dtp_IssueDate";
            this.dtp_IssueDate.Size = new System.Drawing.Size(154, 32);
            this.dtp_IssueDate.TabIndex = 204;
            this.dtp_IssueDate.ValueChanged += new System.EventHandler(this.dtp_IssueDate_ValueChanged);
            // 
            // txt_MovieID
            // 
            this.txt_MovieID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MovieID.Location = new System.Drawing.Point(168, 71);
            this.txt_MovieID.Name = "txt_MovieID";
            this.txt_MovieID.Size = new System.Drawing.Size(154, 32);
            this.txt_MovieID.TabIndex = 203;
            this.txt_MovieID.TextChanged += new System.EventHandler(this.txt_MovieID_TextChanged);
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomerID.Location = new System.Drawing.Point(168, 30);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.Size = new System.Drawing.Size(154, 32);
            this.txt_CustomerID.TabIndex = 202;
            this.txt_CustomerID.TextChanged += new System.EventHandler(this.txt_CustomerID_TextChanged);
            // 
            // btn_DeleteVideo
            // 
            this.btn_DeleteVideo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_DeleteVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteVideo.Location = new System.Drawing.Point(12, 229);
            this.btn_DeleteVideo.Name = "btn_DeleteVideo";
            this.btn_DeleteVideo.Size = new System.Drawing.Size(274, 37);
            this.btn_DeleteVideo.TabIndex = 201;
            this.btn_DeleteVideo.Text = "Delete";
            this.btn_DeleteVideo.UseVisualStyleBackColor = false;
            this.btn_DeleteVideo.Click += new System.EventHandler(this.btn_DeleteVideo_Click);
            // 
            // btn_ReturnVideo
            // 
            this.btn_ReturnVideo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_ReturnVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReturnVideo.Location = new System.Drawing.Point(132, 191);
            this.btn_ReturnVideo.Name = "btn_ReturnVideo";
            this.btn_ReturnVideo.Size = new System.Drawing.Size(154, 32);
            this.btn_ReturnVideo.TabIndex = 200;
            this.btn_ReturnVideo.Text = "Return";
            this.btn_ReturnVideo.UseVisualStyleBackColor = false;
            this.btn_ReturnVideo.Click += new System.EventHandler(this.btn_ReturnVideo_Click);
            // 
            // btn_BookVideo
            // 
            this.btn_BookVideo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_BookVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BookVideo.Location = new System.Drawing.Point(10, 191);
            this.btn_BookVideo.Name = "btn_BookVideo";
            this.btn_BookVideo.Size = new System.Drawing.Size(101, 32);
            this.btn_BookVideo.TabIndex = 199;
            this.btn_BookVideo.Text = "Issue";
            this.btn_BookVideo.UseVisualStyleBackColor = false;
            this.btn_BookVideo.Click += new System.EventHandler(this.btn_BookVideo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Silver;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 24);
            this.label12.TabIndex = 198;
            this.label12.Text = "Date of Return ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 24);
            this.label13.TabIndex = 197;
            this.label13.Text = "Date of Issue";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Silver;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 24);
            this.label14.TabIndex = 196;
            this.label14.Text = "Movie ID";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Silver;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 24);
            this.label15.TabIndex = 195;
            this.label15.Text = "Customer ID";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 691);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarun_VideoCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarun_VideoCost)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarun_CustomerMobile)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tarun_VideoDelete;
        private System.Windows.Forms.Button tarun_VideoUpdate;
        private System.Windows.Forms.Button tarun_VideoAdd;
        private System.Windows.Forms.NumericUpDown tarun_VideoCopies;
        private System.Windows.Forms.NumericUpDown tarun_VideoCost;
        private System.Windows.Forms.TextBox tarun_VideoGenre;
        private System.Windows.Forms.TextBox tarun_VideoPlot;
        private System.Windows.Forms.TextBox tarun_VideoRatting;
        private System.Windows.Forms.TextBox tarun_VideoTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown tarun_CustomerMobile;
        private System.Windows.Forms.Button tarun_Customer_Delete;
        private System.Windows.Forms.Button tarun_CustomerUpdate;
        private System.Windows.Forms.Button tarun_CustomerAdd;
        private System.Windows.Forms.TextBox tarun_CustomerAddress;
        private System.Windows.Forms.TextBox tarun_CustomerLName;
        private System.Windows.Forms.TextBox tarun_CustomerFName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtp_ReturnDate;
        private System.Windows.Forms.DateTimePicker dtp_IssueDate;
        private System.Windows.Forms.TextBox txt_MovieID;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.Button btn_DeleteVideo;
        private System.Windows.Forms.Button btn_ReturnVideo;
        private System.Windows.Forms.Button btn_BookVideo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tarun_movie_year;
    }
}


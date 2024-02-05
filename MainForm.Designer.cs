namespace Cmpt_291_MilestoneOne
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            Car = new TabPage();
            inv_cancel = new Button();
            label9 = new Label();
            inv_type = new ComboBox();
            inv_year = new ComboBox();
            inv_save = new Button();
            search = new Button();
            inv_transmission = new ComboBox();
            inv_mileage = new ComboBox();
            inv_condition = new ComboBox();
            inv_model = new ComboBox();
            inv_make = new ComboBox();
            inv_carID = new ComboBox();
            inv_dateOfPurchase = new DateTimePicker();
            inv_reset = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Delete = new Button();
            Modify = new Button();
            Add = new Button();
            inv_cars = new DataGridView();
            table_carID = new DataGridViewTextBoxColumn();
            table_make = new DataGridViewTextBoxColumn();
            table_model = new DataGridViewTextBoxColumn();
            table_condition = new DataGridViewTextBoxColumn();
            table_year = new DataGridViewTextBoxColumn();
            table_dateOfPurchase = new DataGridViewTextBoxColumn();
            table_mileage = new DataGridViewTextBoxColumn();
            table_Transmission = new DataGridViewTextBoxColumn();
            table_type = new DataGridViewTextBoxColumn();
            Rent = new TabPage();
            Price_value = new ComboBox();
            Price_label = new Label();
            Reserve_table = new DataGridView();
            R_ID = new DataGridViewTextBoxColumn();
            date_start = new DataGridViewTextBoxColumn();
            date_stop = new DataGridViewTextBoxColumn();
            B_Pickup_ID = new DataGridViewTextBoxColumn();
            B_Return_ID = new DataGridViewTextBoxColumn();
            E_ID = new DataGridViewTextBoxColumn();
            Car_ID = new DataGridViewTextBoxColumn();
            C_ID = new DataGridViewTextBoxColumn();
            Reservation_ID_Values = new ComboBox();
            Reservation_ID_Label = new Label();
            Delete_reserve = new Button();
            Employee_list = new ComboBox();
            Customer_Name = new ComboBox();
            Customer_label = new Label();
            Employee_label = new Label();
            Car_List = new ComboBox();
            Confirm_Rent = new Button();
            Car_Name = new Label();
            Dropoff_Branch = new ComboBox();
            Pickup_Branch = new ComboBox();
            d_branch_label = new Label();
            p_branch_label = new Label();
            Dropoff_Label = new Label();
            Pickup_Label = new Label();
            Dropoff_Date = new DateTimePicker();
            Pickup_Date = new DateTimePicker();
            Report = new TabPage();
            Report_name = new Label();
            Report3 = new Button();
            Report4 = new Button();
            Report5 = new Button();
            Report2 = new Button();
            Reports_grid = new DataGridView();
            Report_t1 = new DataGridViewTextBoxColumn();
            Report_t2 = new DataGridViewTextBoxColumn();
            Report_t3 = new DataGridViewTextBoxColumn();
            Report_t4 = new DataGridViewTextBoxColumn();
            Report_t5 = new DataGridViewTextBoxColumn();
            Report_t6 = new DataGridViewTextBoxColumn();
            Report_t7 = new DataGridViewTextBoxColumn();
            Report_t8 = new DataGridViewTextBoxColumn();
            Report1 = new Button();
            button1 = new Button();
            Report6 = new Button();
            inv_tableCarID = new DataGridViewTextBoxColumn();
            inv_tableMake = new DataGridViewTextBoxColumn();
            inv_tableModel = new DataGridViewTextBoxColumn();
            Condition = new DataGridViewTextBoxColumn();
            year = new DataGridViewTextBoxColumn();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            tabControl1.SuspendLayout();
            Car.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inv_cars).BeginInit();
            Rent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Reserve_table).BeginInit();
            Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Reports_grid).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Car);
            tabControl1.Controls.Add(Rent);
            tabControl1.Controls.Add(Report);
            tabControl1.Location = new Point(9, 8);
            tabControl1.Margin = new Padding(1, 3, 1, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1089, 427);
            tabControl1.TabIndex = 0;
            // 
            // Car
            // 
            Car.Controls.Add(inv_cancel);
            Car.Controls.Add(label9);
            Car.Controls.Add(inv_type);
            Car.Controls.Add(inv_year);
            Car.Controls.Add(inv_save);
            Car.Controls.Add(search);
            Car.Controls.Add(inv_transmission);
            Car.Controls.Add(inv_mileage);
            Car.Controls.Add(inv_condition);
            Car.Controls.Add(inv_model);
            Car.Controls.Add(inv_make);
            Car.Controls.Add(inv_carID);
            Car.Controls.Add(inv_dateOfPurchase);
            Car.Controls.Add(inv_reset);
            Car.Controls.Add(label8);
            Car.Controls.Add(label7);
            Car.Controls.Add(label6);
            Car.Controls.Add(label5);
            Car.Controls.Add(label4);
            Car.Controls.Add(label3);
            Car.Controls.Add(label2);
            Car.Controls.Add(label1);
            Car.Controls.Add(Delete);
            Car.Controls.Add(Modify);
            Car.Controls.Add(Add);
            Car.Controls.Add(inv_cars);
            Car.Location = new Point(4, 34);
            Car.Margin = new Padding(1, 3, 1, 3);
            Car.Name = "Car";
            Car.Padding = new Padding(1, 3, 1, 3);
            Car.Size = new Size(1081, 389);
            Car.TabIndex = 0;
            Car.Text = "Car Inventory";
            Car.UseVisualStyleBackColor = true;
            // 
            // inv_cancel
            // 
            inv_cancel.BackColor = Color.FromArgb(255, 255, 192);
            inv_cancel.Location = new Point(841, 117);
            inv_cancel.Margin = new Padding(1, 3, 1, 3);
            inv_cancel.Name = "inv_cancel";
            inv_cancel.Size = new Size(134, 73);
            inv_cancel.TabIndex = 40;
            inv_cancel.Text = "Cancel";
            inv_cancel.UseVisualStyleBackColor = false;
            inv_cancel.Visible = false;
            inv_cancel.Click += inv_cancel_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 165);
            label9.Margin = new Padding(1, 0, 1, 0);
            label9.Name = "label9";
            label9.Size = new Size(49, 25);
            label9.TabIndex = 39;
            label9.Text = "Type";
            // 
            // inv_type
            // 
            inv_type.FormattingEnabled = true;
            inv_type.Location = new Point(111, 157);
            inv_type.Margin = new Padding(1, 3, 1, 3);
            inv_type.Name = "inv_type";
            inv_type.Size = new Size(193, 33);
            inv_type.TabIndex = 38;
            // 
            // inv_year
            // 
            inv_year.FormattingEnabled = true;
            inv_year.Location = new Point(491, 7);
            inv_year.Margin = new Padding(1, 3, 1, 3);
            inv_year.Name = "inv_year";
            inv_year.Size = new Size(193, 33);
            inv_year.TabIndex = 37;
            // 
            // inv_save
            // 
            inv_save.BackColor = Color.FromArgb(255, 255, 192);
            inv_save.Location = new Point(704, 157);
            inv_save.Margin = new Padding(1, 3, 1, 3);
            inv_save.Name = "inv_save";
            inv_save.Size = new Size(134, 33);
            inv_save.TabIndex = 36;
            inv_save.Text = "Save";
            inv_save.UseVisualStyleBackColor = false;
            inv_save.Visible = false;
            inv_save.Click += Save_Click;
            // 
            // search
            // 
            search.BackColor = Color.White;
            search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            search.Location = new Point(349, 157);
            search.Margin = new Padding(1, 3, 1, 3);
            search.Name = "search";
            search.Size = new Size(339, 33);
            search.TabIndex = 35;
            search.Text = "Search";
            search.UseVisualStyleBackColor = false;
            search.Click += Search_Click;
            // 
            // inv_transmission
            // 
            inv_transmission.FormattingEnabled = true;
            inv_transmission.Location = new Point(491, 118);
            inv_transmission.Margin = new Padding(1, 3, 1, 3);
            inv_transmission.Name = "inv_transmission";
            inv_transmission.Size = new Size(193, 33);
            inv_transmission.TabIndex = 32;
            // 
            // inv_mileage
            // 
            inv_mileage.FormattingEnabled = true;
            inv_mileage.Location = new Point(491, 82);
            inv_mileage.Margin = new Padding(1, 3, 1, 3);
            inv_mileage.Name = "inv_mileage";
            inv_mileage.Size = new Size(193, 33);
            inv_mileage.TabIndex = 31;
            // 
            // inv_condition
            // 
            inv_condition.FormattingEnabled = true;
            inv_condition.Location = new Point(111, 118);
            inv_condition.Margin = new Padding(1, 3, 1, 3);
            inv_condition.Name = "inv_condition";
            inv_condition.Size = new Size(193, 33);
            inv_condition.TabIndex = 30;
            // 
            // inv_model
            // 
            inv_model.FormattingEnabled = true;
            inv_model.Location = new Point(111, 82);
            inv_model.Margin = new Padding(1, 3, 1, 3);
            inv_model.Name = "inv_model";
            inv_model.Size = new Size(193, 33);
            inv_model.TabIndex = 29;
            // 
            // inv_make
            // 
            inv_make.AutoCompleteMode = AutoCompleteMode.Suggest;
            inv_make.AutoCompleteSource = AutoCompleteSource.ListItems;
            inv_make.FormattingEnabled = true;
            inv_make.Location = new Point(111, 43);
            inv_make.Margin = new Padding(1, 3, 1, 3);
            inv_make.Name = "inv_make";
            inv_make.Size = new Size(193, 33);
            inv_make.TabIndex = 28;
            // 
            // inv_carID
            // 
            inv_carID.AutoCompleteMode = AutoCompleteMode.Suggest;
            inv_carID.AutoCompleteSource = AutoCompleteSource.ListItems;
            inv_carID.FormattingEnabled = true;
            inv_carID.Location = new Point(111, 7);
            inv_carID.Margin = new Padding(1, 3, 1, 3);
            inv_carID.Name = "inv_carID";
            inv_carID.Size = new Size(193, 33);
            inv_carID.TabIndex = 27;
            // 
            // inv_dateOfPurchase
            // 
            inv_dateOfPurchase.CalendarForeColor = Color.Black;
            inv_dateOfPurchase.CalendarMonthBackground = Color.Black;
            inv_dateOfPurchase.CalendarTitleBackColor = Color.Black;
            inv_dateOfPurchase.Format = DateTimePickerFormat.Short;
            inv_dateOfPurchase.Location = new Point(491, 47);
            inv_dateOfPurchase.Margin = new Padding(1, 3, 1, 3);
            inv_dateOfPurchase.Name = "inv_dateOfPurchase";
            inv_dateOfPurchase.Size = new Size(193, 31);
            inv_dateOfPurchase.TabIndex = 23;
            // 
            // inv_reset
            // 
            inv_reset.BackColor = Color.FromArgb(255, 255, 192);
            inv_reset.Location = new Point(704, 117);
            inv_reset.Margin = new Padding(1, 3, 1, 3);
            inv_reset.Name = "inv_reset";
            inv_reset.Size = new Size(134, 33);
            inv_reset.TabIndex = 22;
            inv_reset.Text = "reset";
            inv_reset.UseVisualStyleBackColor = false;
            inv_reset.Click += Reset_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(349, 125);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(113, 25);
            label8.TabIndex = 21;
            label8.Text = "Transmission";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 127);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(90, 25);
            label7.TabIndex = 19;
            label7.Text = "Condition";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(349, 88);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 17;
            label6.Text = "Mileage";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(346, 48);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(146, 25);
            label5.TabIndex = 15;
            label5.Text = "Date of Purchase";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(349, 15);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 13;
            label4.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 88);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 11;
            label3.Text = "Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 52);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 9;
            label2.Text = "Make";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 13);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 7;
            label1.Text = "Car ID";
            // 
            // Delete
            // 
            Delete.Location = new Point(704, 80);
            Delete.Margin = new Padding(1, 3, 1, 3);
            Delete.Name = "Delete";
            Delete.Size = new Size(134, 33);
            Delete.TabIndex = 5;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Modify
            // 
            Modify.Location = new Point(704, 43);
            Modify.Margin = new Padding(1, 3, 1, 3);
            Modify.Name = "Modify";
            Modify.Size = new Size(134, 33);
            Modify.TabIndex = 4;
            Modify.Text = "Modify";
            Modify.UseVisualStyleBackColor = true;
            Modify.Click += Modify_Click;
            // 
            // Add
            // 
            Add.Location = new Point(704, 8);
            Add.Margin = new Padding(1, 3, 1, 3);
            Add.Name = "Add";
            Add.Size = new Size(134, 32);
            Add.TabIndex = 3;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // inv_cars
            // 
            inv_cars.AllowUserToAddRows = false;
            inv_cars.AllowUserToDeleteRows = false;
            inv_cars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            inv_cars.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            inv_cars.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            inv_cars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inv_cars.Columns.AddRange(new DataGridViewColumn[] { table_carID, table_make, table_model, table_condition, table_year, table_dateOfPurchase, table_mileage, table_Transmission, table_type });
            inv_cars.Location = new Point(6, 197);
            inv_cars.Margin = new Padding(1, 3, 1, 3);
            inv_cars.MultiSelect = false;
            inv_cars.Name = "inv_cars";
            inv_cars.RowHeadersVisible = false;
            inv_cars.RowHeadersWidth = 62;
            inv_cars.RowTemplate.Height = 33;
            inv_cars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            inv_cars.Size = new Size(1066, 197);
            inv_cars.TabIndex = 34;
            inv_cars.Click += Select_Click;
            // 
            // table_carID
            // 
            table_carID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            table_carID.HeaderText = "Car ID";
            table_carID.MinimumWidth = 8;
            table_carID.Name = "table_carID";
            table_carID.Resizable = DataGridViewTriState.True;
            // 
            // table_make
            // 
            table_make.HeaderText = "Make";
            table_make.MinimumWidth = 8;
            table_make.Name = "table_make";
            table_make.Width = 91;
            // 
            // table_model
            // 
            table_model.HeaderText = "Model";
            table_model.MinimumWidth = 8;
            table_model.Name = "table_model";
            table_model.Width = 99;
            // 
            // table_condition
            // 
            table_condition.HeaderText = "Condition";
            table_condition.MinimumWidth = 8;
            table_condition.Name = "table_condition";
            table_condition.Width = 126;
            // 
            // table_year
            // 
            table_year.HeaderText = "Year";
            table_year.MinimumWidth = 8;
            table_year.Name = "table_year";
            table_year.Width = 80;
            // 
            // table_dateOfPurchase
            // 
            dataGridViewCellStyle1.Format = "\"yyyy'-'mm'-'dd\"";
            table_dateOfPurchase.DefaultCellStyle = dataGridViewCellStyle1;
            table_dateOfPurchase.HeaderText = "Date of Purchase";
            table_dateOfPurchase.MaxInputLength = 10;
            table_dateOfPurchase.MinimumWidth = 8;
            table_dateOfPurchase.Name = "table_dateOfPurchase";
            table_dateOfPurchase.Width = 182;
            // 
            // table_mileage
            // 
            table_mileage.HeaderText = "Mileage";
            table_mileage.MinimumWidth = 8;
            table_mileage.Name = "table_mileage";
            table_mileage.Width = 110;
            // 
            // table_Transmission
            // 
            table_Transmission.HeaderText = "Transmission";
            table_Transmission.MinimumWidth = 8;
            table_Transmission.Name = "table_Transmission";
            table_Transmission.Width = 149;
            // 
            // table_type
            // 
            table_type.HeaderText = "Type";
            table_type.MinimumWidth = 8;
            table_type.Name = "table_type";
            table_type.Width = 85;
            // 
            // Rent
            // 
            Rent.Controls.Add(Price_value);
            Rent.Controls.Add(Price_label);
            Rent.Controls.Add(Reserve_table);
            Rent.Controls.Add(Reservation_ID_Values);
            Rent.Controls.Add(Reservation_ID_Label);
            Rent.Controls.Add(Delete_reserve);
            Rent.Controls.Add(Employee_list);
            Rent.Controls.Add(Customer_Name);
            Rent.Controls.Add(Customer_label);
            Rent.Controls.Add(Employee_label);
            Rent.Controls.Add(Car_List);
            Rent.Controls.Add(Confirm_Rent);
            Rent.Controls.Add(Car_Name);
            Rent.Controls.Add(Dropoff_Branch);
            Rent.Controls.Add(Pickup_Branch);
            Rent.Controls.Add(d_branch_label);
            Rent.Controls.Add(p_branch_label);
            Rent.Controls.Add(Dropoff_Label);
            Rent.Controls.Add(Pickup_Label);
            Rent.Controls.Add(Dropoff_Date);
            Rent.Controls.Add(Pickup_Date);
            Rent.Location = new Point(4, 34);
            Rent.Margin = new Padding(1, 3, 1, 3);
            Rent.Name = "Rent";
            Rent.Padding = new Padding(1, 3, 1, 3);
            Rent.Size = new Size(1081, 389);
            Rent.TabIndex = 1;
            Rent.Text = "Rental";
            Rent.UseVisualStyleBackColor = true;
            // 
            // Price_value
            // 
            Price_value.FormattingEnabled = true;
            Price_value.Location = new Point(816, 50);
            Price_value.Margin = new Padding(1, 2, 1, 2);
            Price_value.Name = "Price_value";
            Price_value.Size = new Size(257, 33);
            Price_value.TabIndex = 29;
            Price_value.Visible = false;
            // 
            // Price_label
            // 
            Price_label.AutoSize = true;
            Price_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Price_label.Location = new Point(754, 52);
            Price_label.Margin = new Padding(1, 0, 1, 0);
            Price_label.Name = "Price_label";
            Price_label.Size = new Size(54, 25);
            Price_label.TabIndex = 28;
            Price_label.Text = "Price";
            Price_label.Visible = false;
            // 
            // Reserve_table
            // 
            Reserve_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Reserve_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Reserve_table.Columns.AddRange(new DataGridViewColumn[] { R_ID, date_start, date_stop, B_Pickup_ID, B_Return_ID, E_ID, Car_ID, C_ID });
            Reserve_table.Location = new Point(9, 164);
            Reserve_table.Name = "Reserve_table";
            Reserve_table.RowHeadersVisible = false;
            Reserve_table.RowHeadersWidth = 62;
            Reserve_table.RowTemplate.Height = 25;
            Reserve_table.Size = new Size(1064, 219);
            Reserve_table.TabIndex = 27;
            // 
            // R_ID
            // 
            R_ID.HeaderText = "Reservation ID";
            R_ID.MinimumWidth = 8;
            R_ID.Name = "R_ID";
            // 
            // date_start
            // 
            date_start.HeaderText = "Start Date";
            date_start.MinimumWidth = 8;
            date_start.Name = "date_start";
            // 
            // date_stop
            // 
            date_stop.HeaderText = "Stop Date";
            date_stop.MinimumWidth = 8;
            date_stop.Name = "date_stop";
            // 
            // B_Pickup_ID
            // 
            B_Pickup_ID.HeaderText = "Pickup Branch ID";
            B_Pickup_ID.MinimumWidth = 8;
            B_Pickup_ID.Name = "B_Pickup_ID";
            // 
            // B_Return_ID
            // 
            B_Return_ID.HeaderText = "Dropoff Branch";
            B_Return_ID.MinimumWidth = 8;
            B_Return_ID.Name = "B_Return_ID";
            // 
            // E_ID
            // 
            E_ID.HeaderText = "Employee ID";
            E_ID.MinimumWidth = 8;
            E_ID.Name = "E_ID";
            // 
            // Car_ID
            // 
            Car_ID.HeaderText = "Car ID";
            Car_ID.MinimumWidth = 8;
            Car_ID.Name = "Car_ID";
            // 
            // C_ID
            // 
            C_ID.HeaderText = "Customer ID";
            C_ID.MinimumWidth = 8;
            C_ID.Name = "C_ID";
            // 
            // Reservation_ID_Values
            // 
            Reservation_ID_Values.FormattingEnabled = true;
            Reservation_ID_Values.Location = new Point(922, 10);
            Reservation_ID_Values.Margin = new Padding(1, 2, 1, 2);
            Reservation_ID_Values.Name = "Reservation_ID_Values";
            Reservation_ID_Values.Size = new Size(151, 33);
            Reservation_ID_Values.TabIndex = 26;
            // 
            // Reservation_ID_Label
            // 
            Reservation_ID_Label.AutoSize = true;
            Reservation_ID_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Reservation_ID_Label.Location = new Point(773, 15);
            Reservation_ID_Label.Margin = new Padding(1, 0, 1, 0);
            Reservation_ID_Label.Name = "Reservation_ID_Label";
            Reservation_ID_Label.Size = new Size(138, 25);
            Reservation_ID_Label.TabIndex = 25;
            Reservation_ID_Label.Text = "Reservation ID";
            // 
            // Delete_reserve
            // 
            Delete_reserve.Location = new Point(890, 88);
            Delete_reserve.Margin = new Padding(1, 3, 1, 3);
            Delete_reserve.Name = "Delete_reserve";
            Delete_reserve.Size = new Size(183, 65);
            Delete_reserve.TabIndex = 24;
            Delete_reserve.Text = "Delete";
            Delete_reserve.UseVisualStyleBackColor = true;
            Delete_reserve.Click += Delete_reserve_Click;
            // 
            // Employee_list
            // 
            Employee_list.FormattingEnabled = true;
            Employee_list.Location = new Point(443, 93);
            Employee_list.Margin = new Padding(1, 3, 1, 3);
            Employee_list.Name = "Employee_list";
            Employee_list.Size = new Size(257, 33);
            Employee_list.TabIndex = 23;
            // 
            // Customer_Name
            // 
            Customer_Name.FormattingEnabled = true;
            Customer_Name.Location = new Point(443, 52);
            Customer_Name.Margin = new Padding(1, 3, 1, 3);
            Customer_Name.Name = "Customer_Name";
            Customer_Name.Size = new Size(257, 33);
            Customer_Name.TabIndex = 22;
            // 
            // Customer_label
            // 
            Customer_label.AutoSize = true;
            Customer_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Customer_label.Location = new Point(342, 60);
            Customer_label.Margin = new Padding(1, 0, 1, 0);
            Customer_label.Name = "Customer_label";
            Customer_label.Size = new Size(93, 25);
            Customer_label.TabIndex = 21;
            Customer_label.Text = "Customer";
            // 
            // Employee_label
            // 
            Employee_label.AutoSize = true;
            Employee_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Employee_label.Location = new Point(340, 95);
            Employee_label.Margin = new Padding(1, 0, 1, 0);
            Employee_label.Name = "Employee_label";
            Employee_label.Size = new Size(95, 25);
            Employee_label.TabIndex = 20;
            Employee_label.Text = "Employee";
            // 
            // Car_List
            // 
            Car_List.FormattingEnabled = true;
            Car_List.Location = new Point(443, 12);
            Car_List.Margin = new Padding(1, 3, 1, 3);
            Car_List.Name = "Car_List";
            Car_List.Size = new Size(257, 33);
            Car_List.TabIndex = 19;
            // 
            // Confirm_Rent
            // 
            Confirm_Rent.Location = new Point(710, 88);
            Confirm_Rent.Margin = new Padding(1, 3, 1, 3);
            Confirm_Rent.Name = "Confirm_Rent";
            Confirm_Rent.Size = new Size(178, 65);
            Confirm_Rent.TabIndex = 11;
            Confirm_Rent.Text = "Rent";
            Confirm_Rent.UseVisualStyleBackColor = true;
            Confirm_Rent.Click += Confirm_Rent_Click;
            // 
            // Car_Name
            // 
            Car_Name.AutoSize = true;
            Car_Name.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Car_Name.Location = new Point(395, 15);
            Car_Name.Margin = new Padding(1, 0, 1, 0);
            Car_Name.Name = "Car_Name";
            Car_Name.Size = new Size(40, 25);
            Car_Name.TabIndex = 10;
            Car_Name.Text = "Car";
            // 
            // Dropoff_Branch
            // 
            Dropoff_Branch.FormattingEnabled = true;
            Dropoff_Branch.Location = new Point(89, 125);
            Dropoff_Branch.Margin = new Padding(1, 3, 1, 3);
            Dropoff_Branch.Name = "Dropoff_Branch";
            Dropoff_Branch.Size = new Size(229, 33);
            Dropoff_Branch.TabIndex = 9;
            // 
            // Pickup_Branch
            // 
            Pickup_Branch.FormattingEnabled = true;
            Pickup_Branch.Location = new Point(88, 49);
            Pickup_Branch.Margin = new Padding(1, 3, 1, 3);
            Pickup_Branch.Name = "Pickup_Branch";
            Pickup_Branch.Size = new Size(230, 33);
            Pickup_Branch.TabIndex = 8;
            // 
            // d_branch_label
            // 
            d_branch_label.AutoSize = true;
            d_branch_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            d_branch_label.Location = new Point(12, 125);
            d_branch_label.Margin = new Padding(1, 0, 1, 0);
            d_branch_label.Name = "d_branch_label";
            d_branch_label.Size = new Size(72, 25);
            d_branch_label.TabIndex = 7;
            d_branch_label.Text = "Branch";
            // 
            // p_branch_label
            // 
            p_branch_label.AutoSize = true;
            p_branch_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            p_branch_label.Location = new Point(14, 52);
            p_branch_label.Margin = new Padding(1, 0, 1, 0);
            p_branch_label.Name = "p_branch_label";
            p_branch_label.Size = new Size(72, 25);
            p_branch_label.TabIndex = 6;
            p_branch_label.Text = "Branch";
            // 
            // Dropoff_Label
            // 
            Dropoff_Label.AutoSize = true;
            Dropoff_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Dropoff_Label.ForeColor = SystemColors.ControlText;
            Dropoff_Label.Location = new Point(5, 93);
            Dropoff_Label.Margin = new Padding(1, 0, 1, 0);
            Dropoff_Label.Name = "Dropoff_Label";
            Dropoff_Label.Size = new Size(79, 25);
            Dropoff_Label.TabIndex = 3;
            Dropoff_Label.Text = "Dropoff";
            // 
            // Pickup_Label
            // 
            Pickup_Label.AutoSize = true;
            Pickup_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Pickup_Label.ForeColor = SystemColors.ControlText;
            Pickup_Label.Location = new Point(15, 15);
            Pickup_Label.Margin = new Padding(1, 0, 1, 0);
            Pickup_Label.Name = "Pickup_Label";
            Pickup_Label.Size = new Size(69, 25);
            Pickup_Label.TabIndex = 2;
            Pickup_Label.Text = "Pickup";
            // 
            // Dropoff_Date
            // 
            Dropoff_Date.CustomFormat = "MMM d yyyy";
            Dropoff_Date.Format = DateTimePickerFormat.Custom;
            Dropoff_Date.Location = new Point(89, 88);
            Dropoff_Date.Margin = new Padding(1, 3, 1, 3);
            Dropoff_Date.Name = "Dropoff_Date";
            Dropoff_Date.Size = new Size(229, 31);
            Dropoff_Date.TabIndex = 1;
            // 
            // Pickup_Date
            // 
            Pickup_Date.CustomFormat = "MMM d yyyy";
            Pickup_Date.Format = DateTimePickerFormat.Custom;
            Pickup_Date.Location = new Point(89, 10);
            Pickup_Date.Margin = new Padding(4, 5, 4, 5);
            Pickup_Date.Name = "Pickup_Date";
            Pickup_Date.Size = new Size(229, 31);
            Pickup_Date.TabIndex = 18;
            // 
            // Report
            // 
            Report.AutoScroll = true;
            Report.Controls.Add(Report_name);
            Report.Controls.Add(Report3);
            Report.Controls.Add(Report4);
            Report.Controls.Add(Report5);
            Report.Controls.Add(Report2);
            Report.Controls.Add(Reports_grid);
            Report.Controls.Add(Report1);
            Report.Location = new Point(4, 34);
            Report.Margin = new Padding(1, 2, 1, 2);
            Report.Name = "Report";
            Report.Size = new Size(1081, 389);
            Report.TabIndex = 2;
            Report.Text = "Reports";
            Report.UseVisualStyleBackColor = true;
            // 
            // Report_name
            // 
            Report_name.AutoSize = true;
            Report_name.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Report_name.Location = new Point(10, 47);
            Report_name.Name = "Report_name";
            Report_name.Size = new Size(0, 54);
            Report_name.TabIndex = 40;
            // 
            // Report3
            // 
            Report3.Location = new Point(202, 12);
            Report3.Margin = new Padding(1, 3, 1, 3);
            Report3.Name = "Report3";
            Report3.Size = new Size(96, 32);
            Report3.TabIndex = 39;
            Report3.Text = "Report 3";
            Report3.UseVisualStyleBackColor = true;
            Report3.Click += Report3_Click_1;
            // 
            // Report4
            // 
            Report4.Location = new Point(301, 12);
            Report4.Margin = new Padding(1, 3, 1, 3);
            Report4.Name = "Report4";
            Report4.Size = new Size(96, 32);
            Report4.TabIndex = 38;
            Report4.Text = "Report 4";
            Report4.UseVisualStyleBackColor = true;
            Report4.Click += Report4_Click_1;
            // 
            // Report5
            // 
            Report5.Location = new Point(400, 12);
            Report5.Margin = new Padding(1, 3, 1, 3);
            Report5.Name = "Report5";
            Report5.Size = new Size(96, 32);
            Report5.TabIndex = 37;
            Report5.Text = "Report 5";
            Report5.UseVisualStyleBackColor = true;
            Report5.Click += Report5_Click_1;
            // 
            // Report2
            // 
            Report2.Location = new Point(107, 12);
            Report2.Margin = new Padding(1, 3, 1, 3);
            Report2.Name = "Report2";
            Report2.Size = new Size(96, 32);
            Report2.TabIndex = 36;
            Report2.Text = "Report 2";
            Report2.UseVisualStyleBackColor = true;
            Report2.Click += Report2_Click_1;
            // 
            // Reports_grid
            // 
            Reports_grid.AllowUserToAddRows = false;
            Reports_grid.AllowUserToDeleteRows = false;
            Reports_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Reports_grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Reports_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Reports_grid.Columns.AddRange(new DataGridViewColumn[] { Report_t1, Report_t2, Report_t3, Report_t4, Report_t5, Report_t6, Report_t7, Report_t8 });
            Reports_grid.Location = new Point(9, 115);
            Reports_grid.Margin = new Padding(1, 2, 1, 2);
            Reports_grid.MultiSelect = false;
            Reports_grid.Name = "Reports_grid";
            Reports_grid.RowHeadersVisible = false;
            Reports_grid.RowHeadersWidth = 62;
            Reports_grid.RowTemplate.Height = 33;
            Reports_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Reports_grid.Size = new Size(1060, 272);
            Reports_grid.TabIndex = 35;
            // 
            // Report_t1
            // 
            Report_t1.HeaderText = "";
            Report_t1.MinimumWidth = 8;
            Report_t1.Name = "Report_t1";
            // 
            // Report_t2
            // 
            Report_t2.HeaderText = "";
            Report_t2.MinimumWidth = 8;
            Report_t2.Name = "Report_t2";
            // 
            // Report_t3
            // 
            Report_t3.HeaderText = "";
            Report_t3.MinimumWidth = 8;
            Report_t3.Name = "Report_t3";
            // 
            // Report_t4
            // 
            Report_t4.HeaderText = "";
            Report_t4.MinimumWidth = 8;
            Report_t4.Name = "Report_t4";
            // 
            // Report_t5
            // 
            Report_t5.HeaderText = "";
            Report_t5.MinimumWidth = 8;
            Report_t5.Name = "Report_t5";
            // 
            // Report_t6
            // 
            Report_t6.HeaderText = "";
            Report_t6.MinimumWidth = 8;
            Report_t6.Name = "Report_t6";
            // 
            // Report_t7
            // 
            Report_t7.HeaderText = "";
            Report_t7.MinimumWidth = 8;
            Report_t7.Name = "Report_t7";
            // 
            // Report_t8
            // 
            Report_t8.HeaderText = "";
            Report_t8.MinimumWidth = 8;
            Report_t8.Name = "Report_t8";
            // 
            // Report1
            // 
            Report1.Location = new Point(10, 12);
            Report1.Margin = new Padding(1, 3, 1, 3);
            Report1.Name = "Report1";
            Report1.Size = new Size(96, 32);
            Report1.TabIndex = 0;
            Report1.Text = "Report 1";
            Report1.UseVisualStyleBackColor = true;
            Report1.Click += Report1_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(659, 187);
            button1.Name = "button1";
            button1.Size = new Size(111, 33);
            button1.TabIndex = 22;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // Report6
            // 
            Report6.Location = new Point(0, 0);
            Report6.Name = "Report6";
            Report6.Size = new Size(75, 23);
            Report6.TabIndex = 0;
            // 
            // inv_tableCarID
            // 
            inv_tableCarID.HeaderText = "Car ID";
            inv_tableCarID.MinimumWidth = 8;
            inv_tableCarID.Name = "inv_tableCarID";
            inv_tableCarID.Width = 150;
            // 
            // inv_tableMake
            // 
            inv_tableMake.HeaderText = "Make";
            inv_tableMake.MinimumWidth = 8;
            inv_tableMake.Name = "inv_tableMake";
            inv_tableMake.Width = 150;
            // 
            // inv_tableModel
            // 
            inv_tableModel.HeaderText = "Model";
            inv_tableModel.MinimumWidth = 8;
            inv_tableModel.Name = "inv_tableModel";
            inv_tableModel.Width = 150;
            // 
            // Condition
            // 
            Condition.HeaderText = "inv_tableCondition";
            Condition.MinimumWidth = 8;
            Condition.Name = "Condition";
            Condition.Width = 150;
            // 
            // year
            // 
            year.HeaderText = "inv_tableYear";
            year.MinimumWidth = 8;
            year.Name = "year";
            year.Width = 150;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 450);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1, 3, 1, 3);
            Name = "MainForm";
            Text = "Car Rental Company";
            tabControl1.ResumeLayout(false);
            Car.ResumeLayout(false);
            Car.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inv_cars).EndInit();
            Rent.ResumeLayout(false);
            Rent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Reserve_table).EndInit();
            Report.ResumeLayout(false);
            Report.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Reports_grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Car;
        private TabPage Rent;
        private TabPage Report;
        private TextBox CarID;
        private Button Delete;
        private Button Modify;
        private Button Add;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox Model;
        private Label label2;
        private Label label8;
        private TextBox Transmission;
        private Label label7;
        private Label label6;
        private TextBox Mileage;
        private Label label5;
        private TextBox textBox5;
        private Button button1;
        private Label Dropoff_Label;
        private Label Pickup_Label;
        private DateTimePicker Dropoff_Date;
        private DateTimePicker Pickup_Date;
        private Label Car_Name;
        private ComboBox Dropoff_Branch;
        private ComboBox Pickup_Branch;
        private Label d_branch_label;
        private Label p_branch_label;
        private Button Confirm_Rent;
        private Label d_time_label;
        private Label Report_name;
        private Button inv_reset;
        private ListBox listBox1;
        private ComboBox inv_carID;
        private ComboBox inv_make;
        private ComboBox inv_model;
        private ComboBox inv_transmission;
        private ComboBox inv_mileage;
        private ComboBox inv_condition;
        private DataGridView inv_cars;
        private DataGridViewTextBoxColumn inv_tableCarID;
        private DataGridViewTextBoxColumn inv_tableMake;
        private DataGridViewTextBoxColumn inv_tableModel;
        private DataGridViewTextBoxColumn Condition;
        private DataGridViewTextBoxColumn year;
        private Button search;
        private Button inv_save;
        private Button Report1;
        private Button Report2;
        private Button Report3;
        private Button Report4;
        private Button Report5;
        private Button Report6;
        private DataGridView Reports_grid;
        private ComboBox inv_year;
        private DateTimePicker inv_dateOfPurchase;
        private ComboBox inv_type;
        private Label label9;
        private DataGridViewTextBoxColumn table_carID;
        private DataGridViewTextBoxColumn table_make;
        private DataGridViewTextBoxColumn table_model;
        private DataGridViewTextBoxColumn table_condition;
        private DataGridViewTextBoxColumn table_year;
        private DataGridViewTextBoxColumn table_dateOfPurchase;
        private DataGridViewTextBoxColumn table_mileage;
        private DataGridViewTextBoxColumn table_Transmission;
        private DataGridViewTextBoxColumn table_type;
        private Label Customer_label;
        private Label Employee_label;
        private ComboBox Car_List;
        private Button Delete_reserve;
        private ComboBox Employee_list;
        private ComboBox Customer_Name;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox Reservation_ID_Values;
        private Label Reservation_ID_Label;
        private DataGridView Reserve_table;
        private Button inv_cancel;
        private DataGridViewTextBoxColumn R_ID;
        private DataGridViewTextBoxColumn date_start;
        private DataGridViewTextBoxColumn date_stop;
        private DataGridViewTextBoxColumn B_Pickup_ID;
        private DataGridViewTextBoxColumn B_Return_ID;
        private DataGridViewTextBoxColumn E_ID;
        private DataGridViewTextBoxColumn Car_ID;
        private DataGridViewTextBoxColumn C_ID;
        private DataGridViewTextBoxColumn Report_t1;
        private DataGridViewTextBoxColumn Report_t2;
        private DataGridViewTextBoxColumn Report_t3;
        private DataGridViewTextBoxColumn Report_t4;
        private DataGridViewTextBoxColumn Report_t5;
        private DataGridViewTextBoxColumn Report_t6;
        private DataGridViewTextBoxColumn Report_t7;
        private DataGridViewTextBoxColumn Report_t8;
        private ComboBox Price_value;
        private Label Price_label;
    }
}
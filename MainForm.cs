using Microsoft.IdentityModel.Tokens;
using System.CodeDom;
using System.Data.Common;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Cmpt_291_MilestoneOne
{
    public partial class MainForm : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;


        public MainForm()
        {


            InitializeComponent();

            UpdateAll();
            Update_table(inv_cars);
            Update_Reserve();
            ResetReportTable();

        }

        private void OpenConnection()
        /*
         * purpose: establishes connection with sql server
         *          call before myconnection commands
         * 
         */
        {
            // choose server, DB, login type;
            string server = "DESKTOP-LFJL7JC";
            string database = "Car_Rental_Service";
            string connectionString = "Server = " + server + "; Database = " + database + "; Trusted_Connection = yes;";

            SqlConnection myConnection = new(connectionString);

            try
            {
                myConnection.Open(); //open connection
                myCommand = new SqlCommand
                {
                    Connection = myConnection
                };
                //link command stream to the c...
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }


        }

        private void CloseConnection()
        /*
         * purpose: closes sql connection
         *          call after myconnection commands
         */
        {
            myCommand.Connection.Close();
        }

        private string AddCriteria()
        {
            /* 
             * purpose: creates the criteria for query
             * parameters: n/a
             * return: string of criteria to be included in query
             */

            string tempString = " where "; // all queries start with where
            int tempCount = 0; // count of items added to query


            // next few lines add criteria to string
            if (inv_carID.SelectedItem != null)
            {
                tempString += "Car_ID = '" + inv_carID.SelectedItem + "' and ";
                tempCount++;
            }

            if (inv_make.SelectedItem != null)
            {
                tempString += "make = '" + inv_make.SelectedItem + "' and ";
                tempCount++;
            }

            if (inv_model.SelectedItem != null)
            {
                tempString += "model = '" + inv_model.SelectedItem + "' and ";
                tempCount++;
            }

            if (inv_condition.SelectedItem != null)
            {
                tempString += "condition = '" + inv_condition.SelectedItem + "' and ";
                tempCount++;
            }

            if (inv_year.SelectedItem != null)
            {
                tempString += "year = '" + inv_year.SelectedItem + "' and ";
                tempCount++;
            }

            if (inv_mileage.SelectedItem != null)
            {
                tempString += "mileage = '" + inv_mileage.SelectedItem + "' and ";
                tempCount++;
            }

            if (inv_transmission.SelectedItem != null)
            {
                tempString += "transmission = '" + inv_transmission.SelectedItem + "' and ";
                tempCount++;
            }

            if (inv_type.SelectedItem != null)
            {
                tempString += "T_ID = '" + inv_type.SelectedItem + "' and ";
                tempCount++;
            }

            if (tempCount == 0) // set string to empty as nothing was added
            {
                tempString = "";
            }
            else // remove and at end of string
            {
                tempString = tempString.Remove(tempString.Length - 5, 5);
            }

            return tempString;
        }

        private void Update_table(DataGridView tableName)
        /*
         * purpose: updates all values in table
         * parameters: datagridview object to update, string of table to list
         * return: n/a
         */
        {

            string table = "dbo.Cars"; //update

            OpenConnection();
            myCommand.CommandText = "select * from " + table; // write command
            myCommand.CommandText += AddCriteria();



            try
            {

                myReader = myCommand.ExecuteReader(); // execute command

                tableName.Rows.Clear();

                while (myReader.Read())
                {
                    tableName.Rows.Add(myReader["Car_ID"].ToString(),
                                       myReader["make"].ToString(),
                                       myReader["model"].ToString(),
                                       myReader["condition"].ToString(),
                                       myReader["year"].ToString(),
                                       myReader["date_of_purchase"].ToString()[..10],
                                       myReader["mileage"].ToString(),
                                       myReader["transmission"].ToString(),
                                       myReader["T_ID"].ToString()); // add elements to comboBox
                }

                myReader.Close();
                CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("'update_table' SQL Command Failed:\n " + myCommand.CommandText);
                CloseConnection();
            }
            return;
        }

        private void Update_comboBox(ComboBox boxName, string column, string table)
        {
            OpenConnection();
            myCommand.CommandText = "select distinct " + column + " from " + table; // write command

            try
            {

                myReader = myCommand.ExecuteReader(); // execute command
                boxName.Items.Clear(); // clear current values int combobox

                while (myReader.Read())
                {
                    boxName.Items.Add(myReader[column].ToString()); // add elements to comboBox
                }

                myReader.Close();
                CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show(myCommand.CommandText);
                CloseConnection();
            }
        }

        private void UpdateAll()
        {
            /*
             * purpose: update all combo boxes with latest details
             * parameters: n/a
             * return: n/a
             */

            string carID = "Car_ID"; // update this value to change column
            string make = "make"; // update this value to change column
            string model = "model";
            string condition = "condition";
            string year = "year";
            string mileage = "mileage";
            string transmission = "transmission";
            string r_id = "R_ID";
            string city = "city";

            string table = "dbo.Cars"; // update this value to change table
            string branch = "dbo.Branch";
            string employees = "dbo.Employees";
            string customers = "dbo.Customer";
            string typeID = "T_ID";
            string reserve = "dbo.Reservation";
            string type = "dbo.Type";

            // tables being updated
            Update_comboBox(inv_carID, carID, table);
            Update_comboBox(inv_make, make, table);
            Update_comboBox(inv_model, model, table);
            Update_comboBox(inv_year, year, table);
            Update_comboBox(inv_condition, condition, table);
            Update_comboBox(inv_mileage, mileage, table);
            Update_comboBox(inv_transmission, transmission, table);
            Update_comboBox(inv_type, typeID, table);
            Update_comboBox(Pickup_Branch, city, branch);
            Update_comboBox(Dropoff_Branch, city, branch);
            Update_comboBox(Reservation_ID_Values, r_id, reserve);
            concat_car_name(Car_List, table);
            concat_names(Customer_Name, customers);
            concat_names(Employee_list, employees);
        }


        private void Select_Click(object sender, EventArgs e)
        {   /*
             * purpose: update box values with selected column
             */
            inv_carID.Text = inv_cars.Rows[inv_cars.CurrentRow.Index].Cells["table_carID"].Value.ToString();
            inv_make.Text = inv_cars.Rows[inv_cars.CurrentRow.Index].Cells["table_make"].Value.ToString();
            inv_model.Text = inv_cars.Rows[inv_cars.CurrentRow.Index].Cells["table_model"].Value.ToString();
            inv_condition.Text = inv_cars.Rows[inv_cars.CurrentRow.Index].Cells["table_condition"].Value.ToString();
            inv_year.Text = inv_cars.Rows[inv_cars.CurrentRow.Index].Cells["table_year"].Value.ToString();
            inv_mileage.Text = inv_cars.Rows[inv_cars.CurrentRow.Index].Cells["table_mileage"].Value.ToString();
            inv_transmission.Text = inv_cars.Rows[inv_cars.CurrentRow.Index].Cells["table_transmission"].Value.ToString();
            inv_dateOfPurchase.Text = inv_cars.Rows[inv_cars.CurrentRow.Index].Cells["table_dateOfPurchase"].Value.ToString();
            inv_type.Text = inv_cars.Rows[inv_cars.CurrentRow.Index].Cells["table_type"].Value.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        /*
         * Purpose: this function checks if entry is valid then writes sql command then shows save to finish action
         */
        {
            // check valid entries
            if (!inv_carID.Text.IsNullOrEmpty() &&
                !inv_make.Text.IsNullOrEmpty() &&
                !inv_model.Text.IsNullOrEmpty() &&
                !inv_year.Text.IsNullOrEmpty() &&
                !inv_condition.Text.IsNullOrEmpty() &&
                !inv_mileage.Text.IsNullOrEmpty() &&
                !inv_transmission.Text.IsNullOrEmpty() &&
                !inv_type.Text.IsNullOrEmpty())

            {
                OpenConnection();

                //write sql command
                myCommand.CommandText = "insert into dbo.Cars values ('" +
                                                                inv_carID.Text + "', '" +
                                                                inv_year.Text + "', '" +
                                                                inv_make.Text + "', '" +
                                                                inv_model.Text + "', '" +
                                                                inv_dateOfPurchase.Text + "', '" +
                                                                inv_mileage.Text + "', '" +
                                                                inv_condition.Text + "', '" +
                                                                inv_transmission.Text + "', '" +
                                                                inv_type.Text + "');";

                //show save
                inv_save.Visible = true;
                inv_cancel.Visible = true;
            }
            else
            {
                //handle empty box
                MessageBox.Show("Please enter values to add!");
                CloseConnection();
            }
        }

        private string ModifySet()
        {
            /* 
             * purpose: creates the criteria for query
             * parameters: n/a
             * return: string of criteria to be included in query
             */

            string tempString = " set "; // all queries start with where
            int tempCount = 0; // count of items added to query


            // next few lines add criteria to string
            if (inv_carID.SelectedItem != null)
            {
                tempString += "Car_ID = '" + inv_cars.Rows[inv_cars.CurrentRow.Index].Cells["table_carID"].Value.ToString() + "', ";
                tempCount++;
            }

            if (inv_make.SelectedItem != null)
            {
                tempString += "make = '" + inv_cars.Rows[inv_cars.CurrentRow.Index].Cells["table_make"].Value.ToString() + "', ";
                tempCount++;
            }

            if (inv_model.SelectedItem != null)
            {
                tempString += "model = '" + inv_cars.Rows[inv_cars.CurrentRow.Index].Cells["table_model"].Value.ToString() + "', ";
                tempCount++;
            }

            if (inv_condition.SelectedItem != null)
            {
                tempString += "condition = '" + inv_cars.Rows[inv_cars.CurrentRow.Index].Cells["table_condition"].Value.ToString() + "', ";
                tempCount++;
            }

            if (inv_year.SelectedItem != null)
            {
                tempString += "year = '" + inv_cars.Rows[inv_cars.CurrentRow.Index].Cells["table_year"].Value.ToString() + "', ";
                tempCount++;
            }

            if (!inv_dateOfPurchase.Text.IsNullOrEmpty())
            {
                tempString += "date_of_purchase = '" + inv_cars.Rows[inv_cars.CurrentRow.Index].Cells["table_dateOfPurchase"].Value.ToString() + "', ";
                tempCount++;
            }

            if (inv_mileage.SelectedItem != null)
            {
                tempString += "mileage = '" + inv_cars.Rows[inv_cars.CurrentRow.Index].Cells["table_mileage"].Value.ToString() + "', ";
                tempCount++;
            }

            if (inv_transmission.SelectedItem != null)
            {
                tempString += "transmission = '" + inv_cars.Rows[inv_cars.CurrentRow.Index].Cells["table_transmission"].Value.ToString() + "', ";
                tempCount++;
            }

            if (inv_type.SelectedItem != null)
            {
                tempString += "T_ID = '" + inv_cars.Rows[inv_cars.CurrentRow.Index].Cells["table_type"].Value.ToString() + "', ";
                tempCount++;
            }

            if (tempCount == 0) // set string to empty as nothing was added
            {
                tempString = "";
            }
            else // remove and at end of string
            {
                tempString = tempString.Remove(tempString.Length - 2, 2);
            }

            return tempString;
        }



        private void Modify_Click(object sender, EventArgs e)
        {


            if (!inv_carID.Text.IsNullOrEmpty() &&
                !inv_make.Text.IsNullOrEmpty() &&
                !inv_model.Text.IsNullOrEmpty() &&
                !inv_year.Text.IsNullOrEmpty() &&
                !inv_condition.Text.IsNullOrEmpty() &&
                !inv_mileage.Text.IsNullOrEmpty() &&
                !inv_transmission.Text.IsNullOrEmpty() &&
                !inv_type.Text.IsNullOrEmpty())

            {

                OpenConnection();

                //write sql command
                myCommand.CommandText = "update dbo.Cars";
                myCommand.CommandText += ModifySet(); // adds values that will change
                myCommand.CommandText += AddCriteria(); // makes sure correct entry is being changed
                //show save
                inv_save.Visible = true;
                inv_cancel.Visible = true;
            }
            else
            {
                //handle empty box
                MessageBox.Show("Please select entry to edit!");
                CloseConnection();
            }

        }


        private void Delete_Click(object sender, EventArgs e)
        {


            // check valid entries
            if (!inv_carID.Text.IsNullOrEmpty() &&
                !inv_make.Text.IsNullOrEmpty() &&
                !inv_model.Text.IsNullOrEmpty() &&
                !inv_year.Text.IsNullOrEmpty() &&
                !inv_condition.Text.IsNullOrEmpty() &&
                !inv_mileage.Text.IsNullOrEmpty() &&
                !inv_transmission.Text.IsNullOrEmpty() &&
                !inv_type.Text.IsNullOrEmpty())
            {

                OpenConnection();
                myCommand.CommandText = "delete from dbo.Cars";
                myCommand.CommandText += AddCriteria();


                //show save
                inv_save.Visible = true;
                inv_cancel.Visible = true;
            }
            else
            {
                //handle empty box
                MessageBox.Show("Please select entry to delete!");
                CloseConnection();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.ExecuteNonQuery();
                inv_save.Visible = false;
                inv_cancel.Visible = false;
                Reset_Click(sender, e);
                CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("'Save_Click' invalid command:\n" + myCommand.CommandText);
                inv_save.Visible = false;
                inv_cancel.Visible = false;
                CloseConnection();
            }
        }




        private void Search_Click(object sender, EventArgs e)
        {
            Update_table(inv_cars);


        }


        private void Reset_Click(object sender, EventArgs e)
        {
            inv_carID.Text = null;
            inv_make.Text = null;
            inv_model.Text = null;
            inv_year.Text = null;
            inv_mileage.Text = null;
            inv_condition.Text = null;
            inv_dateOfPurchase.Text = null;
            inv_transmission.Text = null;
            inv_type.Text = null;

            inv_save.Visible = false;
            inv_cancel.Visible = false;

            UpdateAll();
            Update_table(inv_cars);
        }

        private int Check_Rental_Avail(int car_id, DateTime date_start, DateTime date_stop)
        {
            int ret_val = 0; // If not in same date range then will return 0, otherwise return 1
            OpenConnection();
            myCommand.CommandText = "Select date_start, date_stop, Car_ID From Reservation Where Car_ID = " + car_id;
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                DateTime db_date_start = (DateTime)myReader["date_start"];
                DateTime db_date_end = (DateTime)myReader["date_stop"];
                int comp_date_start = DateTime.Compare(db_date_start, date_start); // Return <0 if DB_date is earlier than new booking and return >0 if DB_date is later than new reservation
                int comp_date_end = DateTime.Compare(db_date_end, date_stop);       // Return <0 if DB_date is earlier than new booking and return >0 if DB_date is later than new reservation
                if (comp_date_start <= 0 & comp_date_end >= 0)
                {
                    ret_val = 1;
                }
                else if (comp_date_start >= 0) // Case if start date earlier than DB date
                {
                    int comp_date = DateTime.Compare(db_date_start, date_stop); // Compares the start date in DB to the end date of the new reservation
                    if (comp_date <= 0)
                    {
                        ret_val = 1;
                    }
                }
                else if (comp_date_end <= 0) // Case if end date later than DB date
                {
                    int comp_date = DateTime.Compare(db_date_end, date_start);
                    if (comp_date >= 0)
                    {
                        ret_val = 1;
                    }
                }
            }
            myReader.Close();
            CloseConnection();
            return ret_val;
        }

        private void Update_Reserve()
        {
            OpenConnection();
            myCommand.CommandText = "Select * from dbo.Reservation";

            try
            {
                myReader = myCommand.ExecuteReader();

                Reserve_table.Rows.Clear();
                while (myReader.Read())
                {
                    Reserve_table.Rows.Add(myReader["R_ID"].ToString(),
                                           myReader["date_start"].ToString()[..10],
                                           myReader["date_stop"].ToString()[..10],
                                           myReader["B_Pickup_ID"].ToString(),
                                           myReader["B_Return_ID"].ToString(),
                                           myReader["E_ID"].ToString(),
                                           myReader["Car_ID"].ToString(),
                                           myReader["C_ID"].ToString());
                }
                myReader.Close();
                CloseConnection();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                CloseConnection();
            }
        }
        private void Confirm_Rent_Click(object sender, EventArgs e)
        {
            if (!Reservation_ID_Values.Text.IsNullOrEmpty() &&
                !Pickup_Date.Text.IsNullOrEmpty() &&
                !Dropoff_Date.Text.IsNullOrEmpty() &&
                !Pickup_Branch.Text.IsNullOrEmpty() &&
                !Dropoff_Branch.Text.IsNullOrEmpty() &&
                !Employee_list.Text.IsNullOrEmpty() &&
                !Car_List.Text.IsNullOrEmpty() &&
                !Customer_Name.Text.IsNullOrEmpty())
            {
                int car_id = car_to_ID(Car_List, "dbo.Cars");
                int valid = Check_Rental_Avail(car_id, Pickup_Date.Value, Dropoff_Date.Value);
                if (valid == 0)
                {
                    //write sql command
                    try
                    {
                        int pickup = branch_to_ID(Pickup_Branch, "dbo.Branch");
                        int dropoff = branch_to_ID(Dropoff_Branch, "dbo.Branch");
                        int emp_name = name_to_ID(Employee_list, "dbo.Employees");
                        int cust_name = name_to_ID(Customer_Name, "dbo.Customer");
                        string type = get_type(car_id, "dbo.Cars");

                        OpenConnection();
                        myCommand.CommandText = "insert into dbo.reservation values ('" + Reservation_ID_Values.Text + "', +'" +
                                                                Pickup_Date.Value + "', '" +
                                                                Dropoff_Date.Value + "', '" +
                                                                pickup + "', '" +
                                                                dropoff + "', '" +
                                                                emp_name + "', '" +
                                                                car_id + "', '" +
                                                                cust_name + "');";
                        myCommand.ExecuteNonQuery();
                        Update_Reserve();
                        UpdateAll();
                        Rental_Price(type, Pickup_Date.Value, Dropoff_Date.Value);
                        Price_value.Visible = true;
                        Price_label.Visible = true;
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Already a reservation with this ID");
                    }
                    CloseConnection();
                }
                else
                {
                    MessageBox.Show("Car is already reserved in this time frame");
                }
            }
            else
            {
                MessageBox.Show("Please fill out all boxes to reserve a car!");
            }
        }
        private void Delete_reserve_Click(object sender, EventArgs e)
        {
            if (!Reservation_ID_Values.Text.IsNullOrEmpty() &&
                !Pickup_Date.Text.IsNullOrEmpty() &&
                !Dropoff_Date.Text.IsNullOrEmpty() &&
                !Pickup_Branch.Text.IsNullOrEmpty() &&
                !Dropoff_Branch.Text.IsNullOrEmpty() &&
                !Employee_list.Text.IsNullOrEmpty() &&
                !Car_List.Text.IsNullOrEmpty() &&
                !Customer_Name.Text.IsNullOrEmpty())
            {
                OpenConnection();
                try
                {
                    myCommand.CommandText = "delete from Reservation Where R_ID = '" + Reservation_ID_Values.Text + "'";


                    myCommand.ExecuteNonQuery();
                    Update_Reserve();
                    UpdateAll();
                }
                catch (Exception)
                {
                    MessageBox.Show("Not a Valid Reservation");
                }
            }
            else
            {
                MessageBox.Show("Please Select Reservation to Delete");
            }
            CloseConnection();
        }

        private void Rental_Price(string TypeID, DateTime pickup, DateTime dropoff)
        /* Purpose: Takes the type ID of the car and amount of days the car is rented for and returns
         *          the price accordingly
         * Parameters: string TypeID
         *             int days_rented
         * Return: None
         */
        {
            string column;
            TimeSpan ts = dropoff - pickup;
            int days_rented = ts.Days + 1;
            OpenConnection();
            try
            {
                if (days_rented < 7) // returns day price
                {
                    myCommand.CommandText = "Select day_price from dbo.Type where T_ID = '" + TypeID + "'";
                    column = "day_price";
                }

                else if (days_rented >= 7 & days_rented <= 28) // returns a weekly price
                {
                    myCommand.CommandText = "Select week_price from dbo.Type where T_ID = '" + TypeID + "'";
                    column = "week_price";
                }

                else // returns a monthly price
                {
                    myCommand.CommandText = "Select month_price from dbo.Type where T_ID = '" + TypeID + "'";
                    column = "month_price";
                }

                myCommand.ExecuteNonQuery();
                myReader = myCommand.ExecuteReader();
                Price_value.Items.Clear(); // clear current values int combobox

                while (myReader.Read())
                {
                    int price = (int)myReader[column];
                    Price_value.Text = price.ToString();
                    Price_value.Items.Add(myReader[column].ToString()); // add elements to comboBox
                }

                myReader.Close();
                CloseConnection();

            }

            catch (Exception)
            {
                MessageBox.Show("Invalid");
            }

            CloseConnection();
        }

        private void concat_names(ComboBox boxName, string table)
        /* Purpose: Converts the ID values and concatenates the f_name and l_name boxes to return a full name */
        {
            OpenConnection();
            myCommand.CommandText = "Select f_name + ' ' + l_name as fullName from " + table;
            try
            {
                boxName.Items.Clear();
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    boxName.Items.Add(myReader["fullName"].ToString());
                }

                myReader.Close();
                CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured when concatenating first and last names");
            }
        }

        private void concat_car_name(ComboBox boxName, string table)
        /* Purpose: Converts the ID value to the full string of the cars year, make and model */
        {
            OpenConnection();
            myCommand.CommandText = "Select Cast (year as VARCHAR(4)) + ' ' + make + ' ' + model as car from " + table;
            try
            {
                boxName.Items.Clear();
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    boxName.Items.Add(myReader["car"].ToString());
                }

                myReader.Close();
                CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured when concatenating car year, make, and model");
            }
        }

        private int branch_to_ID(ComboBox boxName, string table)
        /* Purpose: Converts the branch city name to it's equivalent ID from the DB */
        {
            int ret_val = 0;
            OpenConnection();
            myCommand.CommandText = "Select B_ID from Branch where City = '" + boxName.Text + "'";
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                int b_id = (int)myReader["B_ID"];
                ret_val = b_id;
            }
            myReader.Close();
            CloseConnection();
            return ret_val;
        }

        private int name_to_ID(ComboBox boxName, string table)
        /* Purpose: Converts the Full name string in the combo box to it's equivalent ID in the DB */
        {
            int ret_val = 0;
            string fullName = boxName.Text;
            string[] fullName_Split = fullName.Split(' ');
            OpenConnection();
            if (table == "dbo.Customer")
            {
                myCommand.CommandText = "Select C_ID from Customer where f_name = '" + fullName_Split[0] + "' and l_name = '" + fullName_Split[1] + "'";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    int c_id = (int)myReader["C_ID"];
                    ret_val = c_id;
                }
                myReader.Close();
                CloseConnection();

            }

            else // Table == dbo.Employees
            {
                myCommand.CommandText = "Select E_ID from Employees where f_name = '" + fullName_Split[0] + "' and l_name = '" + fullName_Split[1] + "'";
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    int e_id = (int)myReader["E_ID"];
                    ret_val = e_id;
                }
                myReader.Close();
                CloseConnection();
            }
            return ret_val;
        }

        private int car_to_ID(ComboBox boxName, string table)
        /* Purpose: Converts the Full name string in the combo box to it's equivalent ID in the DB */
        {
            int ret_val = 0;
            string car = boxName.Text;
            string[] car_Split = car.Split(' ');
            int car_year = Convert.ToInt32(car_Split[0]);

            OpenConnection();
            myCommand.CommandText = "Select Car_ID from Cars where year = " + car_year + " and make = '" + car_Split[1] + "' and model = '" + car_Split[2] + "'";
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                int car_id = (int)myReader["Car_ID"];
                ret_val = car_id;
            }
            myReader.Close();
            CloseConnection();
            return ret_val;

        }

        private string get_type(int car_id, string table)
        /* Purpose: Converts the Car ID given to the Type_ID */
        {
            string ret_val = "";

            OpenConnection();
            myCommand.CommandText = "Select T_ID from Cars where Car_ID = " + car_id;
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                string t_id = (string)myReader["T_ID"];
                ret_val = t_id;
            }
            myReader.Close();
            CloseConnection();
            return ret_val;

        }





        private void inv_cancel_Click(object sender, EventArgs e)
        {
            CloseConnection();
            inv_save.Visible = false;
            inv_cancel.Visible = false;
            Reset_Click(sender, e);
        }



        private void ResetReportTable()
        {
            Report_t1.Visible = false;
            Report_t2.Visible = false;
            Report_t3.Visible = false;
            Report_t4.Visible = false;
            Report_t5.Visible = false;
            Report_t6.Visible = false;
            Report_t7.Visible = false;
            Report_t8.Visible = false;

            return;
        }

        private void Report1_Click_1(object sender, EventArgs e)
        {

            Report_name.Text = "Average miles and number of cars per type"; //rename header

            ResetReportTable(); //show and rename columns
            Report_t1.Visible = true;
            Report_t2.Visible = true;
            Report_t3.Visible = true;
            Report_t1.HeaderText = "Type";
            Report_t2.HeaderText = "Number of Cars";
            Report_t3.HeaderText = "Average Miles";

            OpenConnection();
            myCommand.CommandText = "select T_ID as Type, count(Car_ID) as Cars, avg(mileage) as AvgMile from Cars group by T_ID;"; // write command

            try
            {

                myReader = myCommand.ExecuteReader(); // execute command

                Reports_grid.Rows.Clear();

                while (myReader.Read()) // fill columns
                {
                    Reports_grid.Rows.Add(myReader["Type"].ToString(),
                                       myReader["Cars"].ToString(),
                                       myReader["AvgMile"].ToString());
                }

                myReader.Close();
                CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("'report1_click' SQL Command Failed:\n " + myCommand.CommandText);
                CloseConnection();
            }
            return;

        }

        private void Report2_Click_1(object sender, EventArgs e)
        {
            Report_name.Text = "Find cars returned to different branches"; //rename header

            ResetReportTable(); //show and rename columns
            Report_t1.Visible = true;
            Report_t2.Visible = true;
            Report_t1.HeaderText = "Car ID";
            Report_t2.HeaderText = "Number of Reservations";

            OpenConnection();
            myCommand.CommandText = "select Cars.Car_ID, count(Reservation.R_ID) as NumOfRes from Reservation, Cars, Customer \r\nwhere Reservation.Car_ID = Cars.Car_ID and Reservation.C_ID = Customer.C_ID\r\nand B_pickup_ID != B_Return_ID\r\ngroup by Cars.Car_ID;"; // write command

            try
            {

                myReader = myCommand.ExecuteReader(); // execute command

                Reports_grid.Rows.Clear();

                while (myReader.Read()) // fill columns
                {
                    Reports_grid.Rows.Add(myReader["Car_ID"].ToString(),
                                       myReader["NumOfRes"].ToString());
                }

                myReader.Close();
                CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("'report2_click' SQL Command Failed:\n " + myCommand.CommandText);
                CloseConnection();
            }
            return;
        }

        private void Report3_Click_1(object sender, EventArgs e)
        {
            Report_name.Text = "Total customers by the same area code"; //rename header

            ResetReportTable(); //show and rename columns
            Report_t1.Visible = true;
            Report_t2.Visible = true;
            Report_t1.HeaderText = "Area Code";
            Report_t2.HeaderText = "Total";

            OpenConnection();
            myCommand.CommandText = "select temp.areacode, count (*) as total from\r\n(select substring(Phone_No, 1, 3) as areacode from Customer, Phone\r\nwhere Customer.C_ID = Phone.C_ID) as temp\r\ngroup by temp.areacode;"; // write command

            try
            {

                myReader = myCommand.ExecuteReader(); // execute command

                Reports_grid.Rows.Clear();

                while (myReader.Read()) // fill columns
                {
                    Reports_grid.Rows.Add(myReader["areacode"].ToString(),
                                       myReader["total"].ToString());
                }

                myReader.Close();
                CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("'report3_click' SQL Command Failed:\n " + myCommand.CommandText);
                CloseConnection();
            }
            return;
        }

        private void Report4_Click_1(object sender, EventArgs e)
        {

            Report_name.Text = "Employees with a higher than average salary"; //rename header

            ResetReportTable(); //show and rename columns
            Report_t1.Visible = true;
            Report_t2.Visible = true;
            Report_t3.Visible = true;
            Report_t4.Visible = true;
            Report_t5.Visible = true;
            Report_t1.HeaderText = "Employee Number";
            Report_t2.HeaderText = "First Name";
            Report_t3.HeaderText = "Last Name";
            Report_t4.HeaderText = "Salary";
            Report_t5.HeaderText = "Drivers License Number";

            OpenConnection();
            myCommand.CommandText = "select * from Employees where salary > (select avg(salary) from Employees);"; // write command

            try
            {

                myReader = myCommand.ExecuteReader(); // execute command

                Reports_grid.Rows.Clear();

                while (myReader.Read()) // fill columns
                {
                    Reports_grid.Rows.Add(myReader["E_ID"].ToString(),
                                           myReader["f_name"].ToString(),
                                           myReader["l_name"].ToString(),
                                           myReader["salary"].ToString(),
                                           myReader["DL_No"].ToString());
                }

                myReader.Close();
                CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("'report4_click' SQL Command Failed:\n " + myCommand.CommandText);
                CloseConnection();
            }
            return;
        }

        private void Report5_Click_1(object sender, EventArgs e)
        {
            Report_name.Text = "Yearly salary greater than a sports car year rent"; //rename header

            ResetReportTable(); //show and rename columns
            Report_t1.Visible = true;
            Report_t2.Visible = true;
            Report_t3.Visible = true;
            Report_t1.HeaderText = "Employee Number";
            Report_t2.HeaderText = "First Name";
            Report_t3.HeaderText = "Last Name";

            OpenConnection();
            myCommand.CommandText = "select distinct Employees.E_ID, Employees.f_name, Employees.l_name from Reservation, Employees, Cars, Type \r\nwhere Reservation.E_ID = Employees.E_ID and Reservation.Car_ID = Cars.Car_ID and Type.T_ID = Cars.T_ID\r\nand salary > (select month_price*12 from Type where T_ID = 'Sports Car');"; // write command

            try
            {

                myReader = myCommand.ExecuteReader(); // execute command

                Reports_grid.Rows.Clear();

                while (myReader.Read()) // fill columns
                {
                    Reports_grid.Rows.Add(myReader["E_ID"].ToString(),
                                       myReader["f_name"].ToString(),
                                       myReader["l_name"].ToString());
                }

                myReader.Close();
                CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("'report5_click' SQL Command Failed:\n " + myCommand.CommandText);
                CloseConnection();
            }
            return;
        }
    }
}

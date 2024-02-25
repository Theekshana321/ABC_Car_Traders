using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ABC_Car_Traders.User;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Data;

namespace ABC_Car_Traders
{
    internal class database
    {

        internal string connectionString; // Remove the initial assignment here
        internal SqlConnection sqlConnection;
        internal SqlDataAdapter sqlDataAdapter;
        internal SqlCommand sqlCommand;

        public database()
        {
            // Initialize the connection string here
            connectionString = "Data Source= DESKTOP-JA796TP\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        public string GetUserType(string username, string password)
        {
            string userType = null;
            try
            {
                sqlConnection.Open();
                string query = "SELECT UserType FROM Users WHERE Username = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", (password));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userType = reader["UserType"].ToString();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
            return userType;
        }

        public void InsertAdmin(Users users)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("INSERT INTO Users (UserName, Password, UserType) " +
                                   "VALUES (@Username, @Password, @UserType)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@UserName", users.UserName);
                sqlCommand.Parameters.AddWithValue("@Password", users.Password);
                sqlCommand.Parameters.AddWithValue("@UserType", "admin");


                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Registered Successfully", "Registered", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool UpdateAdmin(Users users)
        {
            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("UPDATE Users SET UserName = @UserName, Password = @Password WHERE UserID = @UserID", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@UserName", users.UserName);
                sqlCommand.Parameters.AddWithValue("@Password", users.Password);
                sqlCommand.Parameters.AddWithValue("@UserID", users.UserID);

                int rowsAffected = sqlCommand.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public List<Users> GetSelectedUserDetails()
        {
            List<Users> usersList = new List<Users>();

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT UserID, UserName, UserType FROM Users", sqlConnection);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Users user = new Users()
                    {
                        UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                        UserName = reader.GetString(reader.GetOrdinal("UserName")),
                        UserType = reader.GetString(reader.GetOrdinal("UserType"))
                    };


                    usersList.Add(user);
                }

                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return usersList;
        }

        public Users LoadAdminDetails(int userIDToUpdate)
        {
            Users adminUser = null;

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT UserID, UserName, Password FROM Users WHERE UserID = @UserID", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@UserID", userIDToUpdate);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    adminUser = new Users()
                    {
                        UserID = reader.GetInt32(reader.GetOrdinal("UserID")),

                    };
                }
                else
                {
                    MessageBox.Show("Admin user not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return adminUser;
        }

        public bool DeleteAdmin(int userIDToDelete)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE FROM Users WHERE UserID = @UserID", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@UserID", userIDToDelete);

                int usersRowsAffected = sqlCommand.ExecuteNonQuery();

                return (usersRowsAffected > 0);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        //admin CRUD

        public int InsertCustomer(Customer customer)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("INSERT INTO Customers (FirstName, LastName, Address, ContactNumber, Email, Gender) " +
                                   "OUTPUT INSERTED.CustomerID " +
                                   "VALUES (@FirstName, @LastName, @Address, @ContactNumber, @Email, @Gender)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@FirstName", customer.Fname);
                sqlCommand.Parameters.AddWithValue("@LastName", customer.Lname);
                sqlCommand.Parameters.AddWithValue("@Address", customer.Address);
                sqlCommand.Parameters.AddWithValue("@ContactNumber", customer.contactNumber);
                sqlCommand.Parameters.AddWithValue("@Email", customer.Email);
                sqlCommand.Parameters.AddWithValue("@Gender", customer.Gender);
                int generatedCustomerID = (int)sqlCommand.ExecuteScalar();
                sqlConnection.Close();
                return generatedCustomerID;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public void InsertUsers(Users users, int generatedCustomerID)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("INSERT INTO Users (Username, Password, CustomerID, UserType) " +
                                   "VALUES (@Username, @Password, @CustomerID, @UserType)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Username", users.UserName);
                sqlCommand.Parameters.AddWithValue("@Password", users.Password);
                sqlCommand.Parameters.AddWithValue("@CustomerID", generatedCustomerID);
                sqlCommand.Parameters.AddWithValue("@UserType", "customer");

                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Registered Successfully", "Registered", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertCar(car cars, byte[] imageData)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("INSERT INTO Car (CarMake, CarModel, Year, Price, Quantity, CarImage) " +
                                   "VALUES (@CarMake, @CarModel, @Year, @Price, @Quantity, @CarImage)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@CarMake", cars.carMake);
                sqlCommand.Parameters.AddWithValue("@CarModel", cars.carModel);
                sqlCommand.Parameters.AddWithValue("@Year", cars.year);
                sqlCommand.Parameters.AddWithValue("@Price", cars.Price);
                sqlCommand.Parameters.AddWithValue("@Quantity", cars.Quantity);
                sqlCommand.Parameters.AddWithValue("@CarImage", imageData);

                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Registered Successfully", "Registered", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool updateCar(car cars, byte[] newImageData)
        {
            bool success = false;
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("UPDATE Car SET CarMake = @CarMake, CarModel = @CarModel, Year = @Year, Price = @Price, Quantity = @Quantity, ImageData = @ImageData WHERE CarID = @CarID", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@CarMake", cars.carMake);
                sqlCommand.Parameters.AddWithValue("@CarModel", cars.carModel);
                sqlCommand.Parameters.AddWithValue("@Year", cars.year);
                sqlCommand.Parameters.AddWithValue("@Price", cars.Price);
                sqlCommand.Parameters.AddWithValue("@Quantity", cars.Quantity);
                sqlCommand.Parameters.AddWithValue("@ImageData", newImageData);
                sqlCommand.Parameters.AddWithValue("@CarID", cars.carId);

                int rowsAffected = sqlCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Car data updated successfully!");
                    success = true;
                }
                else
                {
                    MessageBox.Show("Update failed. Car ID not found or no changes made.");
                }

                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return success;
        }



        public bool DeleteCar(int carIDToDelete)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE FROM Car WHERE CarID = @CarID", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@CarID", carIDToDelete);

                int usersRowsAffected = sqlCommand.ExecuteNonQuery();

                return (usersRowsAffected > 0);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public List<car> GetAllCarDetails()
        {
            List<car> carList = new List<car>();
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT CarID, CarMake, CarModel, Year, Price, Quantity, CarImage FROM Car", sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    car Car = new car()
                    {
                        carId = reader.GetInt32(reader.GetOrdinal("CarID")),
                        carMake = reader.GetString(reader.GetOrdinal("CarMake")),
                        carModel = reader.GetString(reader.GetOrdinal("CarModel")),
                        year = reader.GetInt32(reader.GetOrdinal("Year")),
                        Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                        Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                        ImageData = reader["CarImage"] as byte[]
                    };
                    carList.Add(Car);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return carList;
        }

        public void InsertCarParts(carPart carsparts, byte[] imageData)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("INSERT INTO carparts (partName, description, Price, Quantity, partImage) " +
                                   "VALUES (@partName, @description, @Price, @Quantity, @partImage)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@partName", carsparts.partName);
                sqlCommand.Parameters.AddWithValue("@description", carsparts.description);
                sqlCommand.Parameters.AddWithValue("@Price", carsparts.Price);
                sqlCommand.Parameters.AddWithValue("@Quantity", carsparts.Quantity);
                sqlCommand.Parameters.AddWithValue("@partImage", imageData);

                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Registered Successfully", "Registered", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public car GetCarDetails(int carId)
        {
            car Car = null;

            try
            {
                sqlConnection.Open();

                string query = "SELECT CarID, CarMake, CarModel, Year, Price, Quantity, CarImage " +
                                "FROM Car WHERE CarID = @CarID";


                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@CarID", carId);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Car = new car()
                        {
                            carId = reader.GetInt32(reader.GetOrdinal("CarID")),
                            carMake = reader.GetString(reader.GetOrdinal("CarMake")),
                            carModel = reader.GetString(reader.GetOrdinal("CarModel")),
                            year = reader.GetInt32(reader.GetOrdinal("Year")),
                            Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                            Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                            ImageData = reader["CarImage"] as byte[]

                        };
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }

            return Car;
        }

        public List<carPart> GetAllPartCarDetails()
        {
            List<carPart> carPartList = new List<carPart>();
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT partId, partName, description, Quantity, Price, partImage FROM carparts", sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    carPart CarPart = new carPart()
                    {
                        carPartId = reader.GetInt32(reader.GetOrdinal("partId")),
                        partName = reader.GetString(reader.GetOrdinal("partName")),
                        description = reader.GetString(reader.GetOrdinal("description")),
                         
                        Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                        Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                        ImageData = reader["partImage"] as byte[]
                    };
                    carPartList.Add(CarPart);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return carPartList;
        }

        public List<car> SearchCars(string searchTerm)
        {
            List<car> cars = new List<car>();

            try
            {
                sqlConnection.Open();

                // Implement your SQL query to search for cars based on the search term
                // For example:
                string query = "SELECT * FROM Car WHERE CarMake LIKE @searchTerm OR CarModel LIKE @searchTerm";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    car car = new car()
                    {
                        carId = reader.GetInt32(reader.GetOrdinal("CarID")),
                        carMake = reader.GetString(reader.GetOrdinal("CarMake")),
                        carModel = reader.GetString(reader.GetOrdinal("CarModel")),
                        year = reader.GetInt32(reader.GetOrdinal("Year")),
                        Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                        Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                        ImageData = reader["CarImage"] as byte[]
                    };

                    cars.Add(car);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            return cars;
        }

        public car GetCarById(int carId)
        {
            car car = null;
            string query = "SELECT * FROM Car WHERE CarID = @CarID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CarID", carId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        car = new car
                        {
                            carId = (int)reader["CarID"],
                            carMake = (string)reader["CarMake"],
                            carModel = (string)reader["CarModel"],
                            year = (int)reader["Year"],
                            Price = (decimal)reader["Price"],
                            Quantity = (int)reader["Quantity"]
                            // Add other properties as needed
                        };
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return car;
        }

        public void InsertCustomerOrder(customerOrder order)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("INSERT INTO CustomerOrders (CustomerId, ItemId, OrderDate, Quantity, TotalPrice) " +
                                   "VALUES (@CustomerId, @ItemId, @OrderDate, @Quantity, @TotalPrice)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@CustomerId", order.CustomerId);
                sqlCommand.Parameters.AddWithValue("@ItemId", order.ItemId);
                sqlCommand.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                sqlCommand.Parameters.AddWithValue("@Quantity", order.Quantity);
                sqlCommand.Parameters.AddWithValue("@TotalPrice", order.TotalPrice);

                int rowsAffected = sqlCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order placed successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to place order.");
                }

                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }










    }
}

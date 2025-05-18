using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace eventManagementSystem.Class
{
    public class UserHelper
    {
        private string connectionString;

        public UserHelper()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        }

        public string checkAccountStatus(string Email)
        {
            string userStatus = null;
            string query = "select userStatus from user_participant where userEmail=@email";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", Email);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        userStatus = reader["userStatus"].ToString();
                    }
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
            return userStatus;
        }

        public bool checkForEmail(string email)
        {
            bool isExists = false;
            string query = "SELECT COUNT(1) FROM user_participant WHERE userEmail= @email";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    
                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.Parameters.AddWithValue("@email",email);
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    isExists = count > 0;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
            return isExists;
        }

        public void updatePassword(string email, string password)
        {
            string query = "UPDATE user_participant SET userPassword=@password, userStatus='Active' WHERE userEmail=@email";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@password",password);
                    cmd.Parameters.AddWithValue("@email", email);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }


        public void updatePasswordAdmin(string email, string password)
        {
            string query = "UPDATE user_admin SET userPassword=@password, userStatus='Active' WHERE userEmail=@email";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }


        public void updatePasswordOrg(string email, string password)
        {
            string query = "UPDATE user_organizer SET userPassword=@password, userStatus='Active' WHERE userEmail=@email";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }


        public void accountRecovery(string email, string password)
        {
            string query = "UPDATE user_participant SET userPassword=@password, userStatus='Password Reset' WHERE userEmail=@email";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);
                    

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }

        public void addAdmin(Admin admin)
        {
            string query = "INSERT INTO user_admin(userEmail,userPassword,userRole,userStatus) VALUES(@email,@password,@role,'Password Reset')";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", admin.email);
                    cmd.Parameters.AddWithValue("@password", admin.password);
                    cmd.Parameters.AddWithValue("@role", admin.userRole);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: "+ex);
                }
                conn.Close();

            }
        }

        public (bool,string,int) validateAdminLogin(string email,string password)
        {
            bool isSuccessfull = false;
            bool isEmailCorrent = false;
            string pw = null;
            string Status = null;
            int userId = 0;
            string query = "SELECT userId,userPassword,userStatus from user_admin where userEmail=@email";
            using (SqlConnection conn = new SqlConnection(connectionString))

            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", email);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        pw = reader["userPassword"].ToString();
                        Status = reader["userStatus"].ToString();
                        userId = (int)reader["userId"];
                        isEmailCorrent = true;
                        if (isEmailCorrent == true)
                        {
                            if (password == pw)
                            {
                                isSuccessfull = true;
                                MessageBox.Show("login Success");
                            }
                            else
                            {
                                isSuccessfull = false;
                                MessageBox.Show("Invalid email or password", "login failed", MessageBoxButton.OK);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password", "login failed", MessageBoxButton.OK);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }


            return (isSuccessfull, Status, userId);
        }


        public (bool, string,int) validatOrganizerLogin(string email, string password)
        {
            bool isSuccessfull = false;
            bool isEmailCorrent = false;
            string pw = null;
            string Status = null;
            int userId = 0;
            string query = "SELECT userId,userPassword,userStatus from user_organizer where userEmail=@email";
            using (SqlConnection conn = new SqlConnection(connectionString))

            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", email);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        pw = reader["userPassword"].ToString();
                        Status = reader["userStatus"].ToString();
                        userId = (int)reader["userId"];
                        isEmailCorrent = true;
                        if (isEmailCorrent == true)
                        {
                            if (password == pw)
                            {
                                isSuccessfull = true;
                                MessageBox.Show("login Success");
                            }
                            else
                            {
                                isSuccessfull = false;
                                MessageBox.Show("Invalid email or password", "login failed", MessageBoxButton.OK);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password", "login failed", MessageBoxButton.OK);
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }


            return (isSuccessfull, Status,userId);
        }

        public void addOrganizer(Organizer og)
        {
            string query = "INSERT INTO user_organizer(userEmail,firstName,lastName,mobileNumber,profileImage,userPassword,userRole) VALUES(@email,@firstName,@lastName,@mobileNumber, @profileImage,@userPassword,@userRole)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email",og.email);
                    cmd.Parameters.AddWithValue("@firstName",og.firstName);
                    cmd.Parameters.AddWithValue("@lastName",og.lastName);
                    cmd.Parameters.AddWithValue("@mobileNumber", og.mobileNumer);
                    cmd.Parameters.AddWithValue("@profileImage", og.profileImage);
                    cmd.Parameters.AddWithValue("@userPassword", og.password);
                    cmd.Parameters.AddWithValue("@userRole", og.userRole);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
                conn.Close();

            }
        }

        public void deleteAdmin(string recordId)
        {
            string query = "DELETE FROM user_admin WHERE userId=@id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", recordId);
                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex);
                }
                conn.Close();

            }

        }


        public void deleteOrganizer(string recordId)
        {
            string query = "DELETE FROM user_organizer WHERE userId=@id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", recordId);
                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex);
                }
                conn.Close();

            }

        }


        public Admin returnAdmin(string userId)
        {
            Admin admin = null;
            string query = "SELECT * FROM user_admin WHERE userId=@id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", userId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string email = reader["userEmail"].ToString();
                        string password = reader["userPassword"].ToString();
                        string role = reader["userRole"].ToString();
                        string status = reader["userStatus"].ToString();

                        admin = new Admin(email, password, role,status);
                    }
                    conn.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("er: "+ ex.Message);
                }

            }

            return admin;
        }

        public void updateActiveAdmin(string id, string email, string userRole, string status)
        {
            string query = "UPDATE user_admin SET userEmail=@email, userRole=@role, userStatus=@status WHERE userId=@id";
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email",email);
                    cmd.Parameters.AddWithValue("@role", userRole);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@status", status);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void updatePRAdmin(string id, string email, string userRole, string status,string password)
        {
            string query = "UPDATE user_admin SET userEmail=@email, userRole=@role, userStatus=@status, userPassword=@password WHERE userId=@id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@role", userRole);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@password", password);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        public void addOrganizerRequest(Organizer_REQ orgReq)
        {
            string query = "INSERT INTO user_organizer_pending(userEmail, firstName, lastName, mobileNumber,prfImage, moreInfo, userRole) VALUES(@email, @firstName, @lastName, @mobileNumber,@ProfileImage, @moreInfo, @role)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", orgReq.email);
                    cmd.Parameters.AddWithValue("@firstName", orgReq.firstName);
                    cmd.Parameters.AddWithValue("@lastName", orgReq.lastName);
                    cmd.Parameters.AddWithValue("@mobileNumber", orgReq.mobileNumer);
                    cmd.Parameters.AddWithValue("@ProfileImage", orgReq.profileImage);
                    cmd.Parameters.AddWithValue("@moreInfo", orgReq.moreInfo);
                    cmd.Parameters.AddWithValue("@role", orgReq.userRole);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error [location: UserHelper.cs addorganizerRequest()]: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        public Organizer_REQ returnRequest(string recordId)
        {
            Organizer_REQ req = null;

            string query = "SELECT * FROM user_organizer_pending WHERE userId=@id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id",recordId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string email = reader["userEmail"].ToString();
                        string firstName = reader["firstName"].ToString();
                        string lastName = reader["lastName"].ToString();
                        string mobileNumber = reader["mobileNumber"].ToString();
                        string profileImage = reader["prfImage"].ToString();
                        string moreInfo = reader["moreInfo"].ToString();
                        string role = reader["userRole"].ToString();

                        req = new Organizer_REQ(email, firstName, lastName, mobileNumber, profileImage, moreInfo, role);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }
            return req;
        }

        public void deleteRequest(string recordId)
        {
            string query = "DELETE FROM user_organizer_pending WHERE userId = @id;";
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id",recordId);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjectTracker
{
    public class User
    {
        public int UserID { get; private set; }  
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public User(string username, string email, string passwordHash)
        {
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
        }

        public User(int userId, string username, string email, string passwordHash)
        {
            UserID = userId;
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
        }
        public void Save()
        {
            using (var connection = new Database().GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Users (Username, Email, PasswordHash) VALUES (@Username, @Email, @PasswordHash)";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@PasswordHash", PasswordHash);
                    cmd.ExecuteNonQuery();

                    UserID = (int)cmd.LastInsertedId;
                }
            }
        }

        public static User Authenticate(string email, string passwordHash)
        {
            using (var connection = new Database().GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Users WHERE Email = @Email AND PasswordHash = @PasswordHash";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User(
                                reader.GetInt32("UserID"),    
                                reader.GetString("Username"),
                                reader.GetString("Email"),
                                reader.GetString("PasswordHash")
                            );
                        }
                        else
                        {
                            return null; 
                        }
                    }
                }
            }
        }

        public static User FindByEmail(string email)
        {
            using (var connection = new Database().GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Users WHERE Email = @Email";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User(
                                reader.GetInt32("UserID"),    
                                reader.GetString("Username"),
                                reader.GetString("Email"),
                                reader.GetString("PasswordHash")
                            );
                        }
                        else
                        {
                            return null; 
                        }
                    }
                }
            }
        }

        public void UpdatePassword(string newPasswordHash)
        {
            using (var connection = new Database().GetConnection())
            {
                connection.Open();
                string query = "UPDATE Users SET PasswordHash = @PasswordHash WHERE UserID = @UserID";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PasswordHash", newPasswordHash);
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

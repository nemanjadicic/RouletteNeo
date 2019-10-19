using Dapper;
using RouletteNeoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteNeoLibrary.DataAccess
{
    public static class SQLiteDataAccess
    {
        private const string UpdateUserWonField = "UPDATE Users SET Won = 1 WHERE Id = @Id";
        private const string GetAllUsers = "SELECT * FROM Users";
        private const string UpdateUserSubscriptionField = "UPDATE Users SET BoughtSub = 1 WHERE Id = @Id";
        private const string InsertNewUser = "INSERT INTO Users (FirstName, LastName, EmailAdress, Username, Password)" +
            "VALUES (@FirstName, @LastName, @EmailAdress, @Username, @Password)";



        private static string GetConnectionString(string name = "RouletteNeoDB")
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }



        public static List<UserModel> GetUsers()
        {
            using (IDbConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                return connection.Query<UserModel>(GetAllUsers).ToList();
            }
        }



        public static void CreateNewUser(UserModel user)
        {
            using (IDbConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                connection.Query<UserModel>(InsertNewUser, user);
            }
        }



        public static void UpdateUserSubscription(UserModel user)
        {
            using (IDbConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                connection.Query<UserModel>(UpdateUserSubscriptionField, user);
            }
        }



        public static void UpdateUserWon(UserModel user)
        {
            using (IDbConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                connection.Query<UserModel>(UpdateUserWonField, user);
            }
        }
    }
}

using DBLayer;
using Evaluation_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Repositories {
    public class ActivityRepository {

        public static Activity GetActivity(int id) {
            Activity activity = null;
            string sql = $"SELECT * FROM Activities WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows) {
                reader.Read();
                activity = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return activity;
        }
        public static List<Activity> GetActivity() {
            List<Activity> activities = new List<Activity>();
            string sql = "SELECT * FROM Activities";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Activity activity = CreateObject(reader);
                activities.Add(activity);
            }
            reader.Close();
            DB.CloseConnection();
            return activities;
        }
        private static Activity CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["Id"].ToString());
            string Description = reader["Description"].ToString();
            string Name = reader["Name"].ToString();
            int MaxPoints = int.Parse(reader["MaxPoints"].ToString());
            int MinPointsForGrade = int.Parse(reader["MinPointsForGrade"].ToString());
            int MinPointsForSignature = int.Parse(reader["MinPointsForSignature"].ToString());

            var activity = new Activity {
                Id = id,
                Description = Description,
                Name = Name,
                MaxPoints= MaxPoints,
                MinPointsForGrade = MinPointsForGrade,
                MinPointsForSignature = MinPointsForSignature,
                


            };
            return activity;
        }

    }
}

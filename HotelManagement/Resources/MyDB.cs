using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace hotel_management
{

    public class Entity
    {
        public ObjectId Id { get; set; }

        public string Name { get; set; }
    }

    internal class MyDB
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=HotelManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        //static MongoClient client = new MongoClient("mongodb://localhost:27017");
        //static MongoClient client = new MongoClient("mongodb+srv://aegis:Vipman123@cluster0.vu0jp.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
        //static IMongoDatabase db = client.GetDatabase("HotelManagement");


        public SqlConnection getConnection
        {
            get { return con; }
        }
        //var settings = MongoClientSettings.FromConnectionString("<connection string>");


        public bool existedKey(string cll, string col, string key)
        {
            /*
             * cll is database name
             * col is column to compare
             * key is value to compare
             * Example: SELECT TOP 1 col FROM cll WHERE col = key
             */
            //var collection = db.GetCollection<Entity>(cll);
            //var collection = db.GetCollection<BsonDocument>("Customer");
            //var filter = Builders<BsonDocument>.Filter.Eq("Name", key);
            //var result = collection.Find(filter).ToList();
            //if (result.Count > 0)
            //    return true;
            //else
            //    return false;

            SqlCommand cmd = new SqlCommand("SELECT TOP 1" + col + " FROM " + cll + " WHERE " + col + " = @key", con);
            cmd.Parameters.AddWithValue("@key", key);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
                con.Open();
        }

        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
                con.Close();
        }

    }
}

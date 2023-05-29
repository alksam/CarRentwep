using System.Data.SqlClient;

namespace CarRentwep.modeldatabase
{
    public class DBCarExeption : IDBCar
    {
        private const String ConnectionString = @"Data Source=mssql6.unoeuro.com;User ID=mohamed_ksam_dk;Password=rcBGhFneAEbzkpaDd5R4;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        
        public List<car1> GetAll()
        {
            String sql = "select * from car";

            // forbindelse
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<car1> carr = new List<car1>();
            while (reader.Read())
            {
                carr.Add(Readcar1(reader));
            }

            return carr;
        }

        private car1 Readcar1(SqlDataReader reader)
        {
            car1 ca = new car1();

            ca.Id = reader.GetInt32(0);
            ca.Model = reader.GetString(1);
            ca.Pric = reader.GetInt32(2);



            return ca;
        }

        public car1 GetById(int id)
        {
            String sql = "select * from car where Id = @ID";

            // forbindelse
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID", id);

            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                return Readcar1(reader);
            }

            return null; // mulighed 1
                         //throw new KeyNotFoundException(); // mulighed 2
        }
        public car1 Create(car1 carr)
        {
            String sql = "insert into car values(@ID,@Model, @Pric)";

            // forbindelse
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID", carr.Id);
            cmd.Parameters.AddWithValue("@Model", carr.Model);
            cmd.Parameters.AddWithValue("@Pric", carr.Pric);


            int row = cmd.ExecuteNonQuery();

            if (row == 1)
            {
                return carr;
            }
            else
            {
                return null; // eller exception
            }



        }

        public car1 Delete(int id)
        {
            // finder først car
            car1 ca = GetById(id);
            if (ca is null)
            {
                return null;
            }

            String sql = "delete from car where Id = @ID";

            // forbindelse
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID", id);


            int row = cmd.ExecuteNonQuery();

            if (row == 1)
            {
                return ca;
            }
            else
            {
                return null; // eller exception
            }
        }

        public car1 Update(int id, car1 carr)
        {
            String sql = "update car set model=@Model, Pric=@Pric,  where Id = 1";

            // forbindelse
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Model", carr.Model);
            cmd.Parameters.AddWithValue("@Pric", carr.Pric);



            int row = cmd.ExecuteNonQuery();

            if (row == 1)
            {
                carr.Id = id;
                return carr;
            }
            else
            {
                return null; // eller exception
            }
        }
    }
}

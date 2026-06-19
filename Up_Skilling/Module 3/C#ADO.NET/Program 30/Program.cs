using System;
using System.Data.SqlClient;

class Program
{
    static string connectionString =
        "Server=localhost;Database=EventDB;Trusted_Connection=True;";

    static void Main()
    {
        using (SqlConnection con =
            new SqlConnection(connectionString))
        {
            con.Open();

            // INSERT
            SqlCommand insert =
                new SqlCommand(
                "INSERT INTO Users(Name) VALUES('Kusuma')",
                con);

            insert.ExecuteNonQuery();

            // SELECT
            SqlCommand select =
                new SqlCommand(
                "SELECT * FROM Users",
                con);

            SqlDataReader reader =
                select.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(
                    reader["Name"]);
            }

            reader.Close();

            // UPDATE
            SqlCommand update =
                new SqlCommand(
                "UPDATE Users SET Name='Kesari' WHERE Name='Kusuma'",
                con);

            update.ExecuteNonQuery();

            // DELETE
            SqlCommand delete =
                new SqlCommand(
                "DELETE FROM Users WHERE Name='Kesari'",
                con);

            delete.ExecuteNonQuery();
        }
    }
}
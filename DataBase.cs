using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProiectBD
{
    class DataBase
    {

        public SqlConnection conn;
        private String connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Fac\Anul 2\Semestrul II\BD\Proiect\ProiectBD\database.mdf;Integrated Security=True";

        public DataBase()
        {
            conn = new SqlConnection(connString);
        }

        public List<Client> getClienti() {
            List<Client> clienti = new List<Client>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Clienti]", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clienti.Add(new Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
            }
            conn.Close();
            return clienti;
        }        

        public Client getClientById(int IdClient) {
            Client client = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Clienti] WHERE IdClient = @IdClient", conn);
            cmd.Parameters.AddWithValue("@IdClient", IdClient);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();            
            
            while (reader.Read())
            {
                client = new Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
            }
            conn.Close();
            return client;
        }

        public void insertClient(String nume, String adresa) {
            SqlCommand cmd = new SqlCommand("INSERT INTO [Clienti] (Nume, Adresa) VALUES (@Nume, @Adresa)", conn);
            cmd.Parameters.AddWithValue("@Nume", nume);
            cmd.Parameters.AddWithValue("@Adresa", adresa);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void updateClient(Client client) {
            SqlCommand cmd = new SqlCommand("UPDATE [Clienti] SET Nume = @Nume, Adresa = @Adresa WHERE IdClient = @IdClient", conn);
            cmd.Parameters.AddWithValue("@Nume", client.nume);
            cmd.Parameters.AddWithValue("@Adresa", client.adresa);
            cmd.Parameters.AddWithValue("@IdClient", client.idClient);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteClient(Client client) {
            SqlCommand cmd = new SqlCommand("DELETE FROM [Clienti] WHERE IdClient = @IdClient", conn);
            cmd.Parameters.AddWithValue("@IdClient", client.idClient);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Interventie> getInterventii() {
            List<Interventie> interventii = new List<Interventie>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Interventii]", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                interventii.Add(new Interventie(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2)));
            }
            conn.Close();
            return interventii;
        }

        public Interventie getInterventieById(int idInterventie) {
            Interventie interventie = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Interventii] WHERE IdInterventie = @IdInterventie", conn);
            cmd.Parameters.AddWithValue("@IdInterventie", idInterventie);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                interventie = new Interventie(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2));
            }
            conn.Close();
            return interventie;
        }

        public List<Tratament> getTratamente() {
            List<Tratament> Tratament = new List<Tratament>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Tratament]", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Tratament.Add(new Tratament(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetDateTime(4)));
            }
            conn.Close();
            return Tratament;
        }

        public List<Tratament> getTratamenteByClientId(int IdClient) {
            List<Tratament> Tratament = new List<Tratament>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Tratament] WHERE IdClient = @IdClient", conn);
            cmd.Parameters.AddWithValue("@IdClient", IdClient);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Tratament.Add(new Tratament(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetDateTime(4)));
            }
            conn.Close();
            return Tratament;
        }

        public Tratament getTratamentById(int IdTratament) {
            Tratament tratament = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Tratament] WHERE IdTratament = @IdTratament", conn);
            cmd.Parameters.AddWithValue("@IdTratament", IdTratament);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tratament = new Tratament(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetDateTime(4));
            }
            conn.Close();
            return tratament;
        }

        public void insertTratament(int IdClient, int IdInterventie, int IdStare, DateTime data) {
            SqlCommand cmd = new SqlCommand("INSERT INTO [Tratament] (IdClient, IdInterventie, IdStare, Data) VALUES (@IdClient, @IdInterventie, @IdStare, @Data)", conn);
            cmd.Parameters.AddWithValue("@IdClient", IdClient);
            cmd.Parameters.AddWithValue("@IdInterventie", IdInterventie);
            cmd.Parameters.AddWithValue("@IdStare", IdStare);
            cmd.Parameters.AddWithValue("@Data", data);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void updateTratament(Tratament tratament) {
            SqlCommand cmd = new SqlCommand("UPDATE [Tratament] SET IdClient = @IdClient, IdInterventie = @IdInterventie, IdStare = @IdStare, Data = @Data WHERE IdTratament = @IdTratament", conn);
            cmd.Parameters.AddWithValue("@IdClient", tratament.idClient);
            cmd.Parameters.AddWithValue("@IdInterventie", tratament.idInterventie);
            cmd.Parameters.AddWithValue("@IdStare", tratament.idStare);
            cmd.Parameters.AddWithValue("@Data", tratament.data);
            cmd.Parameters.AddWithValue("@IdTratament", tratament.idTratament);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void deleteTratament(Tratament tratament) {
            SqlCommand cmd = new SqlCommand("DELETE FROM [Tratament] WHERE IdTratament = @IdTratament", conn);
            cmd.Parameters.AddWithValue("@IdTratament", tratament.idTratament);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Stare> getStari() {
            List<Stare> stari = new List<Stare>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [StareTratament]", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                stari.Add(new Stare(reader.GetInt32(0), reader.GetString(1)));
            }
            conn.Close();
            return stari;
        }

        public Stare getStareById(int idStare) {
            Stare stare = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM [StareTratament] WHERE IdStare = @IdStare", conn);
            cmd.Parameters.AddWithValue("@IdStare", idStare);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                stare = new Stare(reader.GetInt32(0), reader.GetString(1));
            }
            conn.Close();
            return stare;
        }
    }
}

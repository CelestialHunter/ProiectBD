using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectBD
{
    public class Client
    {
        public int idClient;
        public String nume;
        public String adresa;

        public Client(int idClient, String nume, String adresa)
        {
            this.idClient = idClient;
            this.nume = nume;
            this.adresa = adresa;
        }
    }

    public class Interventie
    {
        public int idInterventie;
        public String denumire;
        public Double pret;

        public Interventie(int idInterventie, String denumire, Double pret)
        {
            this.idInterventie = idInterventie;
            this.denumire = denumire;
            this.pret = pret;
        }
    }

    public class Tratament
    {
        public int idTratament;
        public int idClient;
        public int idInterventie;
        public int idStare;
        public DateTime data;

        public Tratament(int idTratament, int idClient, int idInterventie, int idStare, DateTime data)
        {
            this.idTratament = idTratament;
            this.idClient = idClient;
            this.idInterventie = idInterventie;
            this.idStare = idStare;
            this.data = data;
        }
    }

    public class Stare {
        public int idStare;
        public String denumire;
        public Double pret;
        public Stare(int idStare, String denumire, Double pret)
        {
            this.idStare = idStare;
            this.denumire = denumire;
            this.pret = pret;
        }
    }
}

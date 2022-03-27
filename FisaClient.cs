using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectBD
{
    public partial class FisaClient : Form
    {
        Form1 parent;
        DataBase db;
        Client client;
        public FisaClient(Form1 parent, Client client)
        {
            InitializeComponent();
            this.parent = parent;
            db = parent.db;
            this.client = client;

            fillFisa();
        }

        public void fillFisa() {
            numeTB.Text = client.nume;
            adresaTB.Text = client.adresa;

            BindingList<Tratament> tratamente = new BindingList<Tratament>(db.getTratamenteByClientId(client.idClient));

            foreach(Tratament t in tratamente)
            {
                Interventie i = db.getInterventieById(t.idInterventie);
                Stare s = db.getStareById(t.idStare);
                tratamenteDGV.Rows.Add(t.idTratament, i.denumire, s.denumire, t.data);
            }

            tratamenteDGV.Update();
            tratamenteDGV.Refresh();            
        }

        private void backBT_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }
    }

    
}

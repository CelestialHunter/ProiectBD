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
        internal DataBase db;
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

            tratamenteDGV.Rows.Clear();

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
            if (numeTB.Text.CompareTo(client.nume) != 0 || adresaTB.Text.CompareTo(client.adresa) != 0)
            {
                if (MessageBox.Show("Modificati datele clientului?", "Modificare date client", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    client.nume = numeTB.Text;
                    client.adresa = adresaTB.Text;
                    db.updateClient(client);
                }
            }
            this.Close();
        }

        private void newTratBT_Click(object sender, EventArgs e)
        {
            FormaTratament ft = new FormaTratament(this, client, null);
            ft.Show();
            this.Hide();
        }

        private void FisaClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.refreshClienti();
            parent.Show();
        }

        private void tratamenteDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idTratament = Convert.ToInt32(tratamenteDGV.Rows[e.RowIndex].Cells[0].Value);
                Tratament t = db.getTratamentById(idTratament);
                FormaTratament ft = new FormaTratament(this, client, t);
                ft.Show();
                this.Hide();
            }
        }
    }

    
}

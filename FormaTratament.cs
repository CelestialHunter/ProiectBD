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
    public partial class FormaTratament : Form
    {
        FisaClient parent;
        Client client;
        DataBase db;
        Tratament tratament;
        bool update;

        public FormaTratament(FisaClient parent, Client client, Tratament tratament)
        {
            InitializeComponent();
            this.parent = parent;
            db = parent.db;
            this.client = client;
            this.tratament = tratament;
            update = (tratament != null);
            fillForm();
        }

        void fillForm() {
            clientTB.Text = client.nume;

            BindingList<Interventie> interventii = new BindingList<Interventie>(db.getInterventii());
            intervCB.DataSource = interventii;
            intervCB.DisplayMember = "ProiectBD.Interventie.denumire";
            intervCB.ValueMember = "idInterventie";

            intervCB.Format += (s, e) => {
                e.Value = ((Interventie)e.Value).denumire;
            };

            intervCB.SelectedIndexChanged += (s, e) => {
                if (intervCB.SelectedItem == null) return;
                pretTB.Text = ((Interventie)intervCB.SelectedItem).pret.ToString();
            };

            intervCB.SelectedIndex = -1;

            pretTB.Text = "";

            BindingList<Stare> stare = new BindingList<Stare>(db.getStari());
            stareCB.DataSource = stare;
            stareCB.DisplayMember = "denumire";
            stareCB.ValueMember = "idStare";

            stareCB.Format += (s, e) => {
                e.Value = ((Stare)e.Value).denumire;
            };

            stareCB.SelectedIndex = -1;

            if (update)
            {
                foreach(Interventie i in intervCB.Items)
                {
                    if (i.idInterventie == tratament.idInterventie)
                    {
                        intervCB.SelectedItem = i;
                        break;
                    }
                }               

                pretTB.Text = (db.getInterventieById(tratament.idInterventie)).pret.ToString();

                foreach (Stare s in stareCB.Items)
                {
                    if (s.idStare == tratament.idStare)
                    {
                        stareCB.SelectedItem = s;
                        break;
                    }
                }
                titleLB.Text = "Vizualizare Tratament";
            }
        }

        private async void actionBT_Click(object sender, EventArgs e)
        {
            if(!update) {
                DialogResult dr = MessageBox.Show("Adăugare tratament?", "Confirmare", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes) {
                    if(intervCB.SelectedIndex == -1) {
                        MessageBox.Show("Selectati o interventie!");
                        return;
                    }
                    if(stareCB.SelectedIndex == -1) {
                        MessageBox.Show("Selectati o stare!");
                        return;
                    }
                    //db.insertTratament(client.idClient, (int)intervCB.SelectedValue, (int)stareCB.SelectedValue, DateTime.Now);
                    Interventie i = (Interventie)intervCB.SelectedItem;
                    Stare s = (Stare)stareCB.SelectedItem;
                    db.insertTratament(client.idClient, i.idInterventie, s.idStare, DateTime.Now);
                    parent.fillFisa();
                }                                
                
            }
            else 
            {   
                Interventie i = (Interventie)intervCB.SelectedItem;
                Stare s = (Stare)stareCB.SelectedItem;
                if ( i == null || s == null ) {
                    MessageBox.Show("Selectati o interventie si o stare!");
                    return;
                }
                
                if(i.idInterventie != tratament.idInterventie || s.idStare != tratament.idStare) {
                    DialogResult dr = MessageBox.Show("Modificare tratament?", "Confirmare", MessageBoxButtons.YesNo);
                    if(dr == DialogResult.Yes) {
                        //Interventie i = (Interventie)intervCB.SelectedItem;
                        //Stare s = (Stare)stareCB.SelectedItem;
                        db.updateTratament(new Tratament(tratament.idTratament, client.idClient, i.idInterventie, s.idStare, DateTime.Now));
                        parent.fillFisa();
                    }
                }
            }            
            this.Close();
        }

        private void FormaTratament_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}

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
    public partial class Form1 : Form
    {
        DataBase db;
        public Form1()
        {
            InitializeComponent();
            db = new DataBase();
            refreshClienti();
        }

        private void refreshClienti()
        {
            clientiDGV.DataBindings.Clear();
            clientiDGV.Rows.Clear();

            BindingList<Client> clienti = new BindingList<Client>(db.getClienti());

            //clientiDGV.DataSource = clienti;

            foreach(Client c in clienti)
            {
                clientiDGV.Rows.Add(c.idClient, c.nume, c.adresa);
            }

            clientiDGV.Update();
            clientiDGV.Refresh();
        }

        private void initNewClientTab() {
            numeTB.Text = "";
            adresaTB.Text = "";
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == clientiTab)
            {
                refreshClienti();
            }
            else if (tabControl.SelectedTab == newClientTab)
            {
                initNewClientTab();                
            }
            else if (tabControl.SelectedTab == exitTab)
                Application.Exit();
        }

        private void clientiDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void addBT_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(numeTB.Text) || String.IsNullOrWhiteSpace(adresaTB.Text))
            {
                MessageBox.Show("Toate câmpurile sunt obligatorii!");
                return;
            }
            db.insertClient(numeTB.Text, adresaTB.Text);
            tabControl.SelectedTab = clientiTab;
        }
    }
}

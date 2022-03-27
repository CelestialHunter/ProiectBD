
namespace ProiectBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.tabControl = new System.Windows.Forms.TabControl();
            this.clientiTab = new System.Windows.Forms.TabPage();
            this.clientiDGV = new System.Windows.Forms.DataGridView();
            this.IdClientCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeClientCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newClientTab = new System.Windows.Forms.TabPage();
            this.exitTab = new System.Windows.Forms.TabPage();
            this.newClientLayout = new System.Windows.Forms.TableLayoutPanel();
            this.numeTB = new System.Windows.Forms.TextBox();
            this.adresaTB = new System.Windows.Forms.TextBox();
            this.addBT = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.clientiTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientiDGV)).BeginInit();
            this.newClientTab.SuspendLayout();
            this.newClientLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.clientiTab);
            this.tabControl.Controls.Add(this.newClientTab);
            this.tabControl.Controls.Add(this.exitTab);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 426);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // clientiTab
            // 
            this.clientiTab.Controls.Add(this.clientiDGV);
            this.clientiTab.Location = new System.Drawing.Point(4, 27);
            this.clientiTab.Name = "clientiTab";
            this.clientiTab.Padding = new System.Windows.Forms.Padding(3);
            this.clientiTab.Size = new System.Drawing.Size(768, 395);
            this.clientiTab.TabIndex = 0;
            this.clientiTab.Text = "Clienți";
            this.clientiTab.UseVisualStyleBackColor = true;
            // 
            // clientiDGV
            // 
            this.clientiDGV.AllowUserToAddRows = false;
            this.clientiDGV.AllowUserToDeleteRows = false;
            this.clientiDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientiDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdClientCol,
            this.NumeClientCol,
            this.AdresaCol});
            this.clientiDGV.Location = new System.Drawing.Point(3, 3);
            this.clientiDGV.Name = "clientiDGV";
            this.clientiDGV.ReadOnly = true;
            this.clientiDGV.RowTemplate.Height = 25;
            this.clientiDGV.Size = new System.Drawing.Size(762, 389);
            this.clientiDGV.TabIndex = 0;
            this.clientiDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientiDGV_CellClick);
            // 
            // IdClientCol
            // 
            this.IdClientCol.DataPropertyName = "idClient";
            this.IdClientCol.HeaderText = "Id";
            this.IdClientCol.Name = "IdClientCol";
            this.IdClientCol.ReadOnly = true;
            this.IdClientCol.Visible = false;
            // 
            // NumeClientCol
            // 
            this.NumeClientCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumeClientCol.DataPropertyName = "nume";
            this.NumeClientCol.HeaderText = "Nume";
            this.NumeClientCol.Name = "NumeClientCol";
            this.NumeClientCol.ReadOnly = true;
            this.NumeClientCol.Width = 65;
            // 
            // AdresaCol
            // 
            this.AdresaCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AdresaCol.DataPropertyName = "adresa";
            this.AdresaCol.HeaderText = "Adresa";
            this.AdresaCol.Name = "AdresaCol";
            this.AdresaCol.ReadOnly = true;
            // 
            // newClientTab
            // 
            this.newClientTab.Controls.Add(this.newClientLayout);
            this.newClientTab.Location = new System.Drawing.Point(4, 27);
            this.newClientTab.Name = "newClientTab";
            this.newClientTab.Padding = new System.Windows.Forms.Padding(3);
            this.newClientTab.Size = new System.Drawing.Size(768, 395);
            this.newClientTab.TabIndex = 1;
            this.newClientTab.Text = "Adăugare Client";
            this.newClientTab.UseVisualStyleBackColor = true;
            // 
            // exitTab
            // 
            this.exitTab.Location = new System.Drawing.Point(4, 27);
            this.exitTab.Name = "exitTab";
            this.exitTab.Size = new System.Drawing.Size(768, 395);
            this.exitTab.TabIndex = 2;
            this.exitTab.Text = "Părăsire Aplicație";
            this.exitTab.UseVisualStyleBackColor = true;
            // 
            // newClientLayout
            // 
            this.newClientLayout.ColumnCount = 4;
            this.newClientLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.newClientLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.newClientLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.newClientLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.newClientLayout.Controls.Add(this.adresaTB, 1, 2);
            this.newClientLayout.Controls.Add(label1, 1, 1);
            this.newClientLayout.Controls.Add(this.numeTB, 2, 1);
            this.newClientLayout.Controls.Add(label2, 1, 2);
            this.newClientLayout.Controls.Add(this.addBT, 1, 3);
            this.newClientLayout.Location = new System.Drawing.Point(3, 3);
            this.newClientLayout.Name = "newClientLayout";
            this.newClientLayout.RowCount = 5;
            this.newClientLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.newClientLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.newClientLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.newClientLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.newClientLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.newClientLayout.Size = new System.Drawing.Size(762, 389);
            this.newClientLayout.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(155, 108);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(146, 15);
            label1.TabIndex = 0;
            label1.Text = "Nume";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numeTB
            // 
            this.numeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numeTB.Location = new System.Drawing.Point(320, 104);
            this.numeTB.Margin = new System.Windows.Forms.Padding(16);
            this.numeTB.Name = "numeTB";
            this.numeTB.Size = new System.Drawing.Size(272, 23);
            this.numeTB.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(155, 185);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(146, 15);
            label2.TabIndex = 2;
            label2.Text = "Adresa";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adresaTB
            // 
            this.adresaTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.adresaTB.Location = new System.Drawing.Point(320, 181);
            this.adresaTB.Margin = new System.Windows.Forms.Padding(16);
            this.adresaTB.Name = "adresaTB";
            this.adresaTB.Size = new System.Drawing.Size(272, 23);
            this.adresaTB.TabIndex = 3;
            // 
            // addBT
            // 
            this.addBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addBT.CausesValidation = false;
            this.newClientLayout.SetColumnSpan(this.addBT, 2);
            this.addBT.Location = new System.Drawing.Point(168, 258);
            this.addBT.Margin = new System.Windows.Forms.Padding(16);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(424, 23);
            this.addBT.TabIndex = 4;
            this.addBT.Text = "Adăugare Client";
            this.addBT.UseVisualStyleBackColor = true;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediCare";
            this.tabControl.ResumeLayout(false);
            this.clientiTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientiDGV)).EndInit();
            this.newClientTab.ResumeLayout(false);
            this.newClientLayout.ResumeLayout(false);
            this.newClientLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage clientiTab;
        private System.Windows.Forms.TabPage newClientTab;
        private System.Windows.Forms.TabPage exitTab;
        private System.Windows.Forms.DataGridView clientiDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClientCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeClientCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresaCol;
        private System.Windows.Forms.TableLayoutPanel newClientLayout;
        private System.Windows.Forms.TextBox adresaTB;
        private System.Windows.Forms.TextBox numeTB;
        private System.Windows.Forms.Button addBT;
    }
}



namespace ProiectBD
{
    partial class FisaClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.backBT = new System.Windows.Forms.Button();
            this.newTratBT = new System.Windows.Forms.Button();
            this.numeTB = new System.Windows.Forms.TextBox();
            this.adresaTB = new System.Windows.Forms.TextBox();
            this.tratamenteDGV = new System.Windows.Forms.DataGridView();
            this.idTratamentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interventieCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stareCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTratamentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tratamenteDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 15);
            label1.TabIndex = 2;
            label1.Text = "Client";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(390, 13);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 15);
            label2.TabIndex = 4;
            label2.Text = "Adresa";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.backBT, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.newTratBT, 0, 2);
            this.tableLayoutPanel1.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numeTB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.adresaTB, 3, 0);
            this.tableLayoutPanel1.Controls.Add(label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tratamenteDGV, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // backBT
            // 
            this.backBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.backBT.CausesValidation = false;
            this.tableLayoutPanel1.SetColumnSpan(this.backBT, 2);
            this.backBT.Location = new System.Drawing.Point(403, 388);
            this.backBT.Margin = new System.Windows.Forms.Padding(16, 3, 16, 3);
            this.backBT.MinimumSize = new System.Drawing.Size(0, 32);
            this.backBT.Name = "backBT";
            this.backBT.Size = new System.Drawing.Size(357, 32);
            this.backBT.TabIndex = 8;
            this.backBT.Text = "Revenire";
            this.backBT.UseVisualStyleBackColor = true;
            this.backBT.Click += new System.EventHandler(this.backBT_Click);
            // 
            // newTratBT
            // 
            this.newTratBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.newTratBT.CausesValidation = false;
            this.tableLayoutPanel1.SetColumnSpan(this.newTratBT, 2);
            this.newTratBT.Location = new System.Drawing.Point(16, 388);
            this.newTratBT.Margin = new System.Windows.Forms.Padding(16, 3, 16, 3);
            this.newTratBT.MinimumSize = new System.Drawing.Size(0, 32);
            this.newTratBT.Name = "newTratBT";
            this.newTratBT.Size = new System.Drawing.Size(355, 32);
            this.newTratBT.TabIndex = 7;
            this.newTratBT.Text = "Adăugare Tratament";
            this.newTratBT.UseVisualStyleBackColor = true;
            this.newTratBT.Click += new System.EventHandler(this.newTratBT_Click);
            // 
            // numeTB
            // 
            this.numeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numeTB.Location = new System.Drawing.Point(93, 9);
            this.numeTB.Margin = new System.Windows.Forms.Padding(16, 3, 16, 3);
            this.numeTB.Name = "numeTB";
            this.numeTB.Size = new System.Drawing.Size(278, 23);
            this.numeTB.TabIndex = 3;
            // 
            // adresaTB
            // 
            this.adresaTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.adresaTB.Location = new System.Drawing.Point(480, 9);
            this.adresaTB.Margin = new System.Windows.Forms.Padding(16, 3, 16, 3);
            this.adresaTB.Name = "adresaTB";
            this.adresaTB.Size = new System.Drawing.Size(280, 23);
            this.adresaTB.TabIndex = 5;
            // 
            // tratamenteDGV
            // 
            this.tratamenteDGV.AllowUserToAddRows = false;
            this.tratamenteDGV.AllowUserToDeleteRows = false;
            this.tratamenteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tratamenteDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTratamentCol,
            this.interventieCol,
            this.stareCol,
            this.dataTratamentCol});
            this.tableLayoutPanel1.SetColumnSpan(this.tratamenteDGV, 4);
            this.tratamenteDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tratamenteDGV.Location = new System.Drawing.Point(3, 45);
            this.tratamenteDGV.Name = "tratamenteDGV";
            this.tratamenteDGV.ReadOnly = true;
            this.tratamenteDGV.RowTemplate.Height = 25;
            this.tratamenteDGV.Size = new System.Drawing.Size(770, 334);
            this.tratamenteDGV.TabIndex = 6;
            this.tratamenteDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tratamenteDGV_CellClick);
            // 
            // idTratamentCol
            // 
            this.idTratamentCol.DataPropertyName = "idTratament";
            this.idTratamentCol.HeaderText = "idTratament";
            this.idTratamentCol.Name = "idTratamentCol";
            this.idTratamentCol.ReadOnly = true;
            this.idTratamentCol.Visible = false;
            // 
            // interventieCol
            // 
            this.interventieCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.interventieCol.HeaderText = "Intervenție";
            this.interventieCol.Name = "interventieCol";
            this.interventieCol.ReadOnly = true;
            // 
            // stareCol
            // 
            this.stareCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stareCol.HeaderText = "Stare";
            this.stareCol.Name = "stareCol";
            this.stareCol.ReadOnly = true;
            this.stareCol.Width = 58;
            // 
            // dataTratamentCol
            // 
            this.dataTratamentCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataTratamentCol.HeaderText = "Data";
            this.dataTratamentCol.Name = "dataTratamentCol";
            this.dataTratamentCol.ReadOnly = true;
            this.dataTratamentCol.Width = 56;
            // 
            // FisaClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FisaClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FisaClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FisaClient_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tratamenteDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox numeTB;
        private System.Windows.Forms.TextBox adresaTB;
        private System.Windows.Forms.DataGridView tratamenteDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTratamentCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn interventieCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn stareCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataTratamentCol;
        private System.Windows.Forms.Button backBT;
        private System.Windows.Forms.Button newTratBT;
    }
}
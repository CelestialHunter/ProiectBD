
namespace ProiectBD
{
    partial class FormaTratament
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.titleLB = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.stareCB = new System.Windows.Forms.ComboBox();
            this.clientTB = new System.Windows.Forms.TextBox();
            this.pretTB = new System.Windows.Forms.TextBox();
            this.intervCB = new System.Windows.Forms.ComboBox();
            this.actionBT = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(3, 104);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(382, 30);
            label2.TabIndex = 1;
            label2.Text = "Client";
            label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(3, 172);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(382, 30);
            label3.TabIndex = 2;
            label3.Text = "Intervenție";
            label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(3, 240);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(382, 30);
            label4.TabIndex = 3;
            label4.Text = "Preț";
            label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(3, 308);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(382, 30);
            label5.TabIndex = 4;
            label5.Text = "Stare";
            label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // titleLB
            // 
            this.titleLB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLB.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.titleLB, 2);
            this.titleLB.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLB.Location = new System.Drawing.Point(3, 20);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(770, 45);
            this.titleLB.TabIndex = 0;
            this.titleLB.Text = "Adăugare Tratament";
            this.titleLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.stareCB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.titleLB, 0, 0);
            this.tableLayoutPanel1.Controls.Add(label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.clientTB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pretTB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.intervCB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.actionBT, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // stareCB
            // 
            this.stareCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stareCB.DisplayMember = "denumire";
            this.stareCB.FormattingEnabled = true;
            this.stareCB.Location = new System.Drawing.Point(404, 311);
            this.stareCB.Margin = new System.Windows.Forms.Padding(16);
            this.stareCB.Name = "stareCB";
            this.stareCB.Size = new System.Drawing.Size(356, 23);
            this.stareCB.TabIndex = 8;
            this.stareCB.ValueMember = "idStare";
            // 
            // clientTB
            // 
            this.clientTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clientTB.Location = new System.Drawing.Point(404, 107);
            this.clientTB.Margin = new System.Windows.Forms.Padding(16);
            this.clientTB.Name = "clientTB";
            this.clientTB.ReadOnly = true;
            this.clientTB.Size = new System.Drawing.Size(356, 23);
            this.clientTB.TabIndex = 5;
            // 
            // pretTB
            // 
            this.pretTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pretTB.Location = new System.Drawing.Point(404, 243);
            this.pretTB.Margin = new System.Windows.Forms.Padding(16);
            this.pretTB.Name = "pretTB";
            this.pretTB.ReadOnly = true;
            this.pretTB.Size = new System.Drawing.Size(356, 23);
            this.pretTB.TabIndex = 6;
            // 
            // intervCB
            // 
            this.intervCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.intervCB.DisplayMember = "denumire";
            this.intervCB.FormattingEnabled = true;
            this.intervCB.Location = new System.Drawing.Point(404, 175);
            this.intervCB.Margin = new System.Windows.Forms.Padding(16);
            this.intervCB.Name = "intervCB";
            this.intervCB.Size = new System.Drawing.Size(356, 23);
            this.intervCB.TabIndex = 7;
            this.intervCB.ValueMember = "idInterventie";
            // 
            // actionBT
            // 
            this.actionBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.actionBT, 2);
            this.actionBT.Location = new System.Drawing.Point(16, 380);
            this.actionBT.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.actionBT.Name = "actionBT";
            this.actionBT.Size = new System.Drawing.Size(744, 23);
            this.actionBT.TabIndex = 9;
            this.actionBT.Text = "Revenire";
            this.actionBT.UseVisualStyleBackColor = true;
            this.actionBT.Click += new System.EventHandler(this.actionBT_Click);
            // 
            // FormaTratament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormaTratament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaTratament";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormaTratament_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox clientTB;
        private System.Windows.Forms.TextBox pretTB;
        private System.Windows.Forms.ComboBox intervCB;
        private System.Windows.Forms.ComboBox stareCB;
        private System.Windows.Forms.Button actionBT;
        private System.Windows.Forms.Label titleLB;
    }
}
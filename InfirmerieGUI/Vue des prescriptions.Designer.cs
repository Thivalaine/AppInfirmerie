
namespace InfirmerieGUI
{
    partial class Vue_des_prescriptions
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableauPrescriptions = new System.Windows.Forms.DataGridView();
            this.saisieQuantite = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.listeMedicament = new System.Windows.Forms.ComboBox();
            this.saisieIdVisite = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableauPrescriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 31);
            this.label2.TabIndex = 24;
            this.label2.Text = "Préscription";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(73, 247);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 23;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(198, 247);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 22;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(352, 401);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 21;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(688, 401);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(75, 23);
            this.btnActualiser.TabIndex = 20;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Vue des prescriptions";
            // 
            // tableauPrescriptions
            // 
            this.tableauPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauPrescriptions.Location = new System.Drawing.Point(352, 77);
            this.tableauPrescriptions.Name = "tableauPrescriptions";
            this.tableauPrescriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableauPrescriptions.Size = new System.Drawing.Size(411, 282);
            this.tableauPrescriptions.TabIndex = 27;
            this.tableauPrescriptions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableauPrescriptions_CellClick);
            this.tableauPrescriptions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableauPrescriptions_CellContentClick);
            // 
            // saisieQuantite
            // 
            this.saisieQuantite.Location = new System.Drawing.Point(73, 195);
            this.saisieQuantite.Name = "saisieQuantite";
            this.saisieQuantite.Size = new System.Drawing.Size(200, 20);
            this.saisieQuantite.TabIndex = 28;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(137, 299);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 31;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // listeMedicament
            // 
            this.listeMedicament.FormattingEnabled = true;
            this.listeMedicament.Location = new System.Drawing.Point(73, 168);
            this.listeMedicament.Name = "listeMedicament";
            this.listeMedicament.Size = new System.Drawing.Size(200, 21);
            this.listeMedicament.TabIndex = 32;
            this.listeMedicament.SelectedIndexChanged += new System.EventHandler(this.listeMedicament_SelectedIndexChanged);
            // 
            // saisieIdVisite
            // 
            this.saisieIdVisite.Location = new System.Drawing.Point(73, 142);
            this.saisieIdVisite.Name = "saisieIdVisite";
            this.saisieIdVisite.Size = new System.Drawing.Size(200, 20);
            this.saisieIdVisite.TabIndex = 29;
            this.saisieIdVisite.Visible = false;
            this.saisieIdVisite.TextChanged += new System.EventHandler(this.saisieIdMedic_TextChanged);
            // 
            // Vue_des_prescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listeMedicament);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.saisieIdVisite);
            this.Controls.Add(this.saisieQuantite);
            this.Controls.Add(this.tableauPrescriptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.label1);
            this.Name = "Vue_des_prescriptions";
            this.Text = "Vue_des_prescriptions";
            this.Load += new System.EventHandler(this.Vue_des_prescriptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableauPrescriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tableauPrescriptions;
        private System.Windows.Forms.TextBox saisieQuantite;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox listeMedicament;
        private System.Windows.Forms.TextBox saisieIdVisite;
    }
}
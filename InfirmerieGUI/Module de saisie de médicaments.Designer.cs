
namespace InfirmerieGUI
{
    partial class Module_de_saisie_de_médicaments
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
            this.saisieLibelle = new System.Windows.Forms.TextBox();
            this.labelNomEleve = new System.Windows.Forms.Label();
            this.labelSaisieEleve = new System.Windows.Forms.Label();
            this.btnSoumettreMedicament = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // saisieLibelle
            // 
            this.saisieLibelle.Location = new System.Drawing.Point(242, 109);
            this.saisieLibelle.Name = "saisieLibelle";
            this.saisieLibelle.Size = new System.Drawing.Size(115, 20);
            this.saisieLibelle.TabIndex = 14;
            this.saisieLibelle.TextChanged += new System.EventHandler(this.saisieLibelle_TextChanged);
            // 
            // labelNomEleve
            // 
            this.labelNomEleve.AutoSize = true;
            this.labelNomEleve.Location = new System.Drawing.Point(102, 112);
            this.labelNomEleve.Name = "labelNomEleve";
            this.labelNomEleve.Size = new System.Drawing.Size(112, 13);
            this.labelNomEleve.TabIndex = 13;
            this.labelNomEleve.Text = "Libellé du médicament";
            // 
            // labelSaisieEleve
            // 
            this.labelSaisieEleve.AutoSize = true;
            this.labelSaisieEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaisieEleve.Location = new System.Drawing.Point(148, 19);
            this.labelSaisieEleve.Name = "labelSaisieEleve";
            this.labelSaisieEleve.Size = new System.Drawing.Size(299, 31);
            this.labelSaisieEleve.TabIndex = 12;
            this.labelSaisieEleve.Text = "Saisie d\'un médicament";
            // 
            // btnSoumettreMedicament
            // 
            this.btnSoumettreMedicament.Location = new System.Drawing.Point(401, 166);
            this.btnSoumettreMedicament.Name = "btnSoumettreMedicament";
            this.btnSoumettreMedicament.Size = new System.Drawing.Size(75, 23);
            this.btnSoumettreMedicament.TabIndex = 15;
            this.btnSoumettreMedicament.Text = "Soumettre";
            this.btnSoumettreMedicament.UseVisualStyleBackColor = true;
            this.btnSoumettreMedicament.Click += new System.EventHandler(this.btnSoumettreMedicament_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(105, 166);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 16;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::InfirmerieGUI.Properties.Resources.medicament_risque_depression;
            this.pictureBox3.Location = new System.Drawing.Point(223, 166);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(149, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // Module_de_saisie_de_médicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 260);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnSoumettreMedicament);
            this.Controls.Add(this.saisieLibelle);
            this.Controls.Add(this.labelNomEleve);
            this.Controls.Add(this.labelSaisieEleve);
            this.Name = "Module_de_saisie_de_médicaments";
            this.Text = "Module_de_saisie_de_médicaments";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox saisieLibelle;
        private System.Windows.Forms.Label labelNomEleve;
        private System.Windows.Forms.Label labelSaisieEleve;
        private System.Windows.Forms.Button btnSoumettreMedicament;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
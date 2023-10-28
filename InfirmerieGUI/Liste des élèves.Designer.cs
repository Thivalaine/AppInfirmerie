
namespace InfirmerieGUI
{
    partial class Liste_des_élèves
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
            this.components = new System.ComponentModel.Container();
            this.tableauEleve = new System.Windows.Forms.DataGridView();
            this.btnModifierListeEleves = new System.Windows.Forms.Button();
            this.btnSupprimerEleve = new System.Windows.Forms.Button();
            this.btnActualiserListeEleve = new System.Windows.Forms.Button();
            this.listeClasse = new System.Windows.Forms.ComboBox();
            this.labelClasseEleve = new System.Windows.Forms.Label();
            this.saisieNumTelParentModif = new System.Windows.Forms.TextBox();
            this.saisieNumTelModif = new System.Windows.Forms.TextBox();
            this.saisieDateEleveModif = new System.Windows.Forms.DateTimePicker();
            this.saisiePrenomModif = new System.Windows.Forms.TextBox();
            this.saisieNomModif = new System.Windows.Forms.TextBox();
            this.saisieCommentaireSanteModif = new System.Windows.Forms.RichTextBox();
            this.labelCommentaire = new System.Windows.Forms.Label();
            this.radioTiersTempsNonModif = new System.Windows.Forms.RadioButton();
            this.radioTiersTempsOuiModif = new System.Windows.Forms.RadioButton();
            this.labelTiersTemps = new System.Windows.Forms.Label();
            this.labelNumTelParent = new System.Windows.Forms.Label();
            this.labelNumTel = new System.Windows.Forms.Label();
            this.labelDateNaissance = new System.Windows.Forms.Label();
            this.labelPrenomEleve = new System.Windows.Forms.Label();
            this.labelNomEleve = new System.Windows.Forms.Label();
            this.labelSaisieEleve = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.eleveDAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tableauEleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleveDAOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableauEleve
            // 
            this.tableauEleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauEleve.Location = new System.Drawing.Point(381, 12);
            this.tableauEleve.Name = "tableauEleve";
            this.tableauEleve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableauEleve.Size = new System.Drawing.Size(751, 477);
            this.tableauEleve.TabIndex = 0;
            this.tableauEleve.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableauEleve_CellClick);
            this.tableauEleve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableauEleve_CellContentClick);
            // 
            // btnModifierListeEleves
            // 
            this.btnModifierListeEleves.Location = new System.Drawing.Point(35, 569);
            this.btnModifierListeEleves.Name = "btnModifierListeEleves";
            this.btnModifierListeEleves.Size = new System.Drawing.Size(75, 23);
            this.btnModifierListeEleves.TabIndex = 1;
            this.btnModifierListeEleves.Text = "Modifier";
            this.btnModifierListeEleves.UseVisualStyleBackColor = true;
            this.btnModifierListeEleves.Click += new System.EventHandler(this.btnModifierListeEleves_Click);
            // 
            // btnSupprimerEleve
            // 
            this.btnSupprimerEleve.Location = new System.Drawing.Point(156, 418);
            this.btnSupprimerEleve.Name = "btnSupprimerEleve";
            this.btnSupprimerEleve.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerEleve.TabIndex = 3;
            this.btnSupprimerEleve.Text = "Supprimer";
            this.btnSupprimerEleve.UseVisualStyleBackColor = true;
            this.btnSupprimerEleve.Click += new System.EventHandler(this.btnSupprimerEleve_Click);
            // 
            // btnActualiserListeEleve
            // 
            this.btnActualiserListeEleve.Location = new System.Drawing.Point(381, 520);
            this.btnActualiserListeEleve.Name = "btnActualiserListeEleve";
            this.btnActualiserListeEleve.Size = new System.Drawing.Size(75, 23);
            this.btnActualiserListeEleve.TabIndex = 4;
            this.btnActualiserListeEleve.Text = "Actualiser";
            this.btnActualiserListeEleve.UseVisualStyleBackColor = true;
            this.btnActualiserListeEleve.Click += new System.EventHandler(this.btnActualiserListeEleve_Click);
            // 
            // listeClasse
            // 
            this.listeClasse.FormattingEnabled = true;
            this.listeClasse.Location = new System.Drawing.Point(158, 180);
            this.listeClasse.Name = "listeClasse";
            this.listeClasse.Size = new System.Drawing.Size(121, 21);
            this.listeClasse.TabIndex = 38;
            this.listeClasse.SelectedIndexChanged += new System.EventHandler(this.listeClasseModif_SelectedIndexChanged);
            // 
            // labelClasseEleve
            // 
            this.labelClasseEleve.AutoSize = true;
            this.labelClasseEleve.Location = new System.Drawing.Point(31, 181);
            this.labelClasseEleve.Name = "labelClasseEleve";
            this.labelClasseEleve.Size = new System.Drawing.Size(86, 13);
            this.labelClasseEleve.TabIndex = 36;
            this.labelClasseEleve.Text = "Classe de l\'élève";
            // 
            // saisieNumTelParentModif
            // 
            this.saisieNumTelParentModif.Location = new System.Drawing.Point(212, 313);
            this.saisieNumTelParentModif.Name = "saisieNumTelParentModif";
            this.saisieNumTelParentModif.Size = new System.Drawing.Size(122, 20);
            this.saisieNumTelParentModif.TabIndex = 35;
            // 
            // saisieNumTelModif
            // 
            this.saisieNumTelModif.Location = new System.Drawing.Point(158, 272);
            this.saisieNumTelModif.Name = "saisieNumTelModif";
            this.saisieNumTelModif.Size = new System.Drawing.Size(122, 20);
            this.saisieNumTelModif.TabIndex = 34;
            // 
            // saisieDateEleveModif
            // 
            this.saisieDateEleveModif.Location = new System.Drawing.Point(158, 221);
            this.saisieDateEleveModif.Name = "saisieDateEleveModif";
            this.saisieDateEleveModif.Size = new System.Drawing.Size(200, 20);
            this.saisieDateEleveModif.TabIndex = 33;
            // 
            // saisiePrenomModif
            // 
            this.saisiePrenomModif.Location = new System.Drawing.Point(158, 143);
            this.saisiePrenomModif.Name = "saisiePrenomModif";
            this.saisiePrenomModif.Size = new System.Drawing.Size(100, 20);
            this.saisiePrenomModif.TabIndex = 32;
            // 
            // saisieNomModif
            // 
            this.saisieNomModif.Location = new System.Drawing.Point(158, 95);
            this.saisieNomModif.Name = "saisieNomModif";
            this.saisieNomModif.Size = new System.Drawing.Size(100, 20);
            this.saisieNomModif.TabIndex = 31;
            this.saisieNomModif.TextChanged += new System.EventHandler(this.saisieNomModif_TextChanged);
            // 
            // saisieCommentaireSanteModif
            // 
            this.saisieCommentaireSanteModif.Location = new System.Drawing.Point(158, 406);
            this.saisieCommentaireSanteModif.Name = "saisieCommentaireSanteModif";
            this.saisieCommentaireSanteModif.Size = new System.Drawing.Size(176, 83);
            this.saisieCommentaireSanteModif.TabIndex = 30;
            this.saisieCommentaireSanteModif.Text = "";
            // 
            // labelCommentaire
            // 
            this.labelCommentaire.AutoSize = true;
            this.labelCommentaire.Location = new System.Drawing.Point(31, 409);
            this.labelCommentaire.Name = "labelCommentaire";
            this.labelCommentaire.Size = new System.Drawing.Size(97, 13);
            this.labelCommentaire.TabIndex = 29;
            this.labelCommentaire.Text = "Commentaire santé";
            // 
            // radioTiersTempsNonModif
            // 
            this.radioTiersTempsNonModif.AutoSize = true;
            this.radioTiersTempsNonModif.Location = new System.Drawing.Point(274, 354);
            this.radioTiersTempsNonModif.Name = "radioTiersTempsNonModif";
            this.radioTiersTempsNonModif.Size = new System.Drawing.Size(45, 17);
            this.radioTiersTempsNonModif.TabIndex = 28;
            this.radioTiersTempsNonModif.Text = "Non";
            this.radioTiersTempsNonModif.UseVisualStyleBackColor = true;
            // 
            // radioTiersTempsOuiModif
            // 
            this.radioTiersTempsOuiModif.AutoSize = true;
            this.radioTiersTempsOuiModif.Checked = true;
            this.radioTiersTempsOuiModif.Location = new System.Drawing.Point(201, 354);
            this.radioTiersTempsOuiModif.Name = "radioTiersTempsOuiModif";
            this.radioTiersTempsOuiModif.Size = new System.Drawing.Size(41, 17);
            this.radioTiersTempsOuiModif.TabIndex = 27;
            this.radioTiersTempsOuiModif.TabStop = true;
            this.radioTiersTempsOuiModif.Text = "Oui";
            this.radioTiersTempsOuiModif.UseVisualStyleBackColor = true;
            this.radioTiersTempsOuiModif.CheckedChanged += new System.EventHandler(this.radioTiersTempsOui_CheckedChanged);
            // 
            // labelTiersTemps
            // 
            this.labelTiersTemps.AutoSize = true;
            this.labelTiersTemps.Location = new System.Drawing.Point(32, 359);
            this.labelTiersTemps.Name = "labelTiersTemps";
            this.labelTiersTemps.Size = new System.Drawing.Size(126, 13);
            this.labelTiersTemps.TabIndex = 26;
            this.labelTiersTemps.Text = "Tiers temps aux examens";
            // 
            // labelNumTelParent
            // 
            this.labelNumTelParent.AutoSize = true;
            this.labelNumTelParent.Location = new System.Drawing.Point(31, 313);
            this.labelNumTelParent.Name = "labelNumTelParent";
            this.labelNumTelParent.Size = new System.Drawing.Size(167, 13);
            this.labelNumTelParent.TabIndex = 25;
            this.labelNumTelParent.Text = "Numéro de téléphone des parents";
            // 
            // labelNumTel
            // 
            this.labelNumTel.AutoSize = true;
            this.labelNumTel.Location = new System.Drawing.Point(26, 272);
            this.labelNumTel.Name = "labelNumTel";
            this.labelNumTel.Size = new System.Drawing.Size(109, 13);
            this.labelNumTel.TabIndex = 24;
            this.labelNumTel.Text = "Numéro de téléphone";
            // 
            // labelDateNaissance
            // 
            this.labelDateNaissance.AutoSize = true;
            this.labelDateNaissance.Location = new System.Drawing.Point(31, 221);
            this.labelDateNaissance.Name = "labelDateNaissance";
            this.labelDateNaissance.Size = new System.Drawing.Size(96, 13);
            this.labelDateNaissance.TabIndex = 23;
            this.labelDateNaissance.Text = "Date de naissance";
            // 
            // labelPrenomEleve
            // 
            this.labelPrenomEleve.AutoSize = true;
            this.labelPrenomEleve.Location = new System.Drawing.Point(31, 143);
            this.labelPrenomEleve.Name = "labelPrenomEleve";
            this.labelPrenomEleve.Size = new System.Drawing.Size(91, 13);
            this.labelPrenomEleve.TabIndex = 22;
            this.labelPrenomEleve.Text = "Prénom de l\'élève";
            // 
            // labelNomEleve
            // 
            this.labelNomEleve.AutoSize = true;
            this.labelNomEleve.Location = new System.Drawing.Point(31, 98);
            this.labelNomEleve.Name = "labelNomEleve";
            this.labelNomEleve.Size = new System.Drawing.Size(77, 13);
            this.labelNomEleve.TabIndex = 21;
            this.labelNomEleve.Text = "Nom de l\'élève";
            this.labelNomEleve.Click += new System.EventHandler(this.labelNomEleve_Click);
            // 
            // labelSaisieEleve
            // 
            this.labelSaisieEleve.AutoSize = true;
            this.labelSaisieEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaisieEleve.Location = new System.Drawing.Point(31, 25);
            this.labelSaisieEleve.Name = "labelSaisieEleve";
            this.labelSaisieEleve.Size = new System.Drawing.Size(288, 31);
            this.labelSaisieEleve.TabIndex = 20;
            this.labelSaisieEleve.Text = "Modification d\'un élève\r\n";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(259, 569);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 39;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::InfirmerieGUI.Properties.Resources.reforme_des_lycees_rentree_septembre_2019_1024x854_1;
            this.pictureBox5.Location = new System.Drawing.Point(706, 495);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(115, 86);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 40;
            this.pictureBox5.TabStop = false;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(1057, 520);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 41;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // eleveDAOBindingSource
            // 
            this.eleveDAOBindingSource.DataSource = typeof(InfirmerieDAL.EleveDAO);
            // 
            // Liste_des_élèves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 618);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.listeClasse);
            this.Controls.Add(this.labelClasseEleve);
            this.Controls.Add(this.saisieNumTelParentModif);
            this.Controls.Add(this.saisieNumTelModif);
            this.Controls.Add(this.saisieDateEleveModif);
            this.Controls.Add(this.saisiePrenomModif);
            this.Controls.Add(this.saisieNomModif);
            this.Controls.Add(this.saisieCommentaireSanteModif);
            this.Controls.Add(this.labelCommentaire);
            this.Controls.Add(this.radioTiersTempsNonModif);
            this.Controls.Add(this.radioTiersTempsOuiModif);
            this.Controls.Add(this.labelTiersTemps);
            this.Controls.Add(this.labelNumTelParent);
            this.Controls.Add(this.labelNumTel);
            this.Controls.Add(this.labelDateNaissance);
            this.Controls.Add(this.labelPrenomEleve);
            this.Controls.Add(this.labelNomEleve);
            this.Controls.Add(this.labelSaisieEleve);
            this.Controls.Add(this.btnActualiserListeEleve);
            this.Controls.Add(this.btnSupprimerEleve);
            this.Controls.Add(this.btnModifierListeEleves);
            this.Controls.Add(this.tableauEleve);
            this.Name = "Liste_des_élèves";
            this.Text = "Liste_des_élèves";
            this.Load += new System.EventHandler(this.Liste_des_élèves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableauEleve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleveDAOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableauEleve;
        private System.Windows.Forms.Button btnModifierListeEleves;
        private System.Windows.Forms.Button btnSupprimerEleve;
        private System.Windows.Forms.Button btnActualiserListeEleve;
        private System.Windows.Forms.ComboBox listeClasse;
        private System.Windows.Forms.Label labelClasseEleve;
        private System.Windows.Forms.TextBox saisieNumTelParentModif;
        private System.Windows.Forms.TextBox saisieNumTelModif;
        private System.Windows.Forms.DateTimePicker saisieDateEleveModif;
        private System.Windows.Forms.TextBox saisiePrenomModif;
        private System.Windows.Forms.TextBox saisieNomModif;
        private System.Windows.Forms.RichTextBox saisieCommentaireSanteModif;
        private System.Windows.Forms.Label labelCommentaire;
        private System.Windows.Forms.RadioButton radioTiersTempsNonModif;
        private System.Windows.Forms.RadioButton radioTiersTempsOuiModif;
        private System.Windows.Forms.Label labelTiersTemps;
        private System.Windows.Forms.Label labelNumTelParent;
        private System.Windows.Forms.Label labelNumTel;
        private System.Windows.Forms.Label labelDateNaissance;
        private System.Windows.Forms.Label labelPrenomEleve;
        private System.Windows.Forms.Label labelNomEleve;
        private System.Windows.Forms.Label labelSaisieEleve;
        private System.Windows.Forms.BindingSource eleveDAOBindingSource;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnRetour;
    }
}
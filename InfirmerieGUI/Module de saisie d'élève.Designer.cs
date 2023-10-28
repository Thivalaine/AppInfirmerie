
namespace InfirmerieGUI
{
    partial class Module_de_saisie_d_élève
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
            this.labelSaisieEleve = new System.Windows.Forms.Label();
            this.labelNomEleve = new System.Windows.Forms.Label();
            this.labelPrenomEleve = new System.Windows.Forms.Label();
            this.labelDateNaissance = new System.Windows.Forms.Label();
            this.labelNumTel = new System.Windows.Forms.Label();
            this.labelNumTelParent = new System.Windows.Forms.Label();
            this.labelTiersTemps = new System.Windows.Forms.Label();
            this.radioTiersTempsOui = new System.Windows.Forms.RadioButton();
            this.radioTiersTempsNon = new System.Windows.Forms.RadioButton();
            this.labelCommentaire = new System.Windows.Forms.Label();
            this.saisieCommentaireSante = new System.Windows.Forms.RichTextBox();
            this.saisieNom = new System.Windows.Forms.TextBox();
            this.saisiePrenom = new System.Windows.Forms.TextBox();
            this.saisieDateEleve = new System.Windows.Forms.DateTimePicker();
            this.saisieNumTel = new System.Windows.Forms.TextBox();
            this.saisieNumTelParent = new System.Windows.Forms.TextBox();
            this.boutonSoumettre = new System.Windows.Forms.Button();
            this.labelClasseEleve = new System.Windows.Forms.Label();
            this.listeClasse = new System.Windows.Forms.ComboBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSaisieEleve
            // 
            this.labelSaisieEleve.AutoSize = true;
            this.labelSaisieEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaisieEleve.Location = new System.Drawing.Point(110, 34);
            this.labelSaisieEleve.Name = "labelSaisieEleve";
            this.labelSaisieEleve.Size = new System.Drawing.Size(217, 31);
            this.labelSaisieEleve.TabIndex = 0;
            this.labelSaisieEleve.Text = "Saisie d\'un élève";
            // 
            // labelNomEleve
            // 
            this.labelNomEleve.AutoSize = true;
            this.labelNomEleve.Location = new System.Drawing.Point(53, 114);
            this.labelNomEleve.Name = "labelNomEleve";
            this.labelNomEleve.Size = new System.Drawing.Size(77, 13);
            this.labelNomEleve.TabIndex = 1;
            this.labelNomEleve.Text = "Nom de l\'élève";
            // 
            // labelPrenomEleve
            // 
            this.labelPrenomEleve.AutoSize = true;
            this.labelPrenomEleve.Location = new System.Drawing.Point(53, 159);
            this.labelPrenomEleve.Name = "labelPrenomEleve";
            this.labelPrenomEleve.Size = new System.Drawing.Size(91, 13);
            this.labelPrenomEleve.TabIndex = 2;
            this.labelPrenomEleve.Text = "Prénom de l\'élève";
            // 
            // labelDateNaissance
            // 
            this.labelDateNaissance.AutoSize = true;
            this.labelDateNaissance.Location = new System.Drawing.Point(53, 243);
            this.labelDateNaissance.Name = "labelDateNaissance";
            this.labelDateNaissance.Size = new System.Drawing.Size(96, 13);
            this.labelDateNaissance.TabIndex = 3;
            this.labelDateNaissance.Text = "Date de naissance";
            // 
            // labelNumTel
            // 
            this.labelNumTel.AutoSize = true;
            this.labelNumTel.Location = new System.Drawing.Point(48, 294);
            this.labelNumTel.Name = "labelNumTel";
            this.labelNumTel.Size = new System.Drawing.Size(109, 13);
            this.labelNumTel.TabIndex = 4;
            this.labelNumTel.Text = "Numéro de téléphone";
            this.labelNumTel.Click += new System.EventHandler(this.labelNumTel_Click);
            // 
            // labelNumTelParent
            // 
            this.labelNumTelParent.AutoSize = true;
            this.labelNumTelParent.Location = new System.Drawing.Point(53, 335);
            this.labelNumTelParent.Name = "labelNumTelParent";
            this.labelNumTelParent.Size = new System.Drawing.Size(167, 13);
            this.labelNumTelParent.TabIndex = 5;
            this.labelNumTelParent.Text = "Numéro de téléphone des parents";
            // 
            // labelTiersTemps
            // 
            this.labelTiersTemps.AutoSize = true;
            this.labelTiersTemps.Location = new System.Drawing.Point(54, 381);
            this.labelTiersTemps.Name = "labelTiersTemps";
            this.labelTiersTemps.Size = new System.Drawing.Size(126, 13);
            this.labelTiersTemps.TabIndex = 6;
            this.labelTiersTemps.Text = "Tiers temps aux examens";
            // 
            // radioTiersTempsOui
            // 
            this.radioTiersTempsOui.AutoSize = true;
            this.radioTiersTempsOui.Location = new System.Drawing.Point(223, 380);
            this.radioTiersTempsOui.Name = "radioTiersTempsOui";
            this.radioTiersTempsOui.Size = new System.Drawing.Size(41, 17);
            this.radioTiersTempsOui.TabIndex = 7;
            this.radioTiersTempsOui.TabStop = true;
            this.radioTiersTempsOui.Text = "Oui";
            this.radioTiersTempsOui.UseVisualStyleBackColor = true;
            this.radioTiersTempsOui.CheckedChanged += new System.EventHandler(this.radioTiersTempsOui_CheckedChanged);
            // 
            // radioTiersTempsNon
            // 
            this.radioTiersTempsNon.AutoSize = true;
            this.radioTiersTempsNon.Location = new System.Drawing.Point(295, 380);
            this.radioTiersTempsNon.Name = "radioTiersTempsNon";
            this.radioTiersTempsNon.Size = new System.Drawing.Size(45, 17);
            this.radioTiersTempsNon.TabIndex = 8;
            this.radioTiersTempsNon.TabStop = true;
            this.radioTiersTempsNon.Text = "Non";
            this.radioTiersTempsNon.UseVisualStyleBackColor = true;
            this.radioTiersTempsNon.CheckedChanged += new System.EventHandler(this.radioTiersTempsNon_CheckedChanged);
            // 
            // labelCommentaire
            // 
            this.labelCommentaire.AutoSize = true;
            this.labelCommentaire.Location = new System.Drawing.Point(53, 431);
            this.labelCommentaire.Name = "labelCommentaire";
            this.labelCommentaire.Size = new System.Drawing.Size(97, 13);
            this.labelCommentaire.TabIndex = 9;
            this.labelCommentaire.Text = "Commentaire santé";
            // 
            // saisieCommentaireSante
            // 
            this.saisieCommentaireSante.Location = new System.Drawing.Point(180, 428);
            this.saisieCommentaireSante.Name = "saisieCommentaireSante";
            this.saisieCommentaireSante.Size = new System.Drawing.Size(200, 83);
            this.saisieCommentaireSante.TabIndex = 10;
            this.saisieCommentaireSante.Text = "";
            this.saisieCommentaireSante.TextChanged += new System.EventHandler(this.saisieCommentaireSante_TextChanged);
            // 
            // saisieNom
            // 
            this.saisieNom.Location = new System.Drawing.Point(180, 111);
            this.saisieNom.Name = "saisieNom";
            this.saisieNom.Size = new System.Drawing.Size(100, 20);
            this.saisieNom.TabIndex = 11;
            this.saisieNom.TextChanged += new System.EventHandler(this.saisieNom_TextChanged);
            // 
            // saisiePrenom
            // 
            this.saisiePrenom.Location = new System.Drawing.Point(180, 159);
            this.saisiePrenom.Name = "saisiePrenom";
            this.saisiePrenom.Size = new System.Drawing.Size(100, 20);
            this.saisiePrenom.TabIndex = 12;
            this.saisiePrenom.TextChanged += new System.EventHandler(this.saisiePrenom_TextChanged);
            // 
            // saisieDateEleve
            // 
            this.saisieDateEleve.Location = new System.Drawing.Point(180, 243);
            this.saisieDateEleve.Name = "saisieDateEleve";
            this.saisieDateEleve.Size = new System.Drawing.Size(200, 20);
            this.saisieDateEleve.TabIndex = 13;
            this.saisieDateEleve.ValueChanged += new System.EventHandler(this.saisieDateEleve_ValueChanged);
            // 
            // saisieNumTel
            // 
            this.saisieNumTel.Location = new System.Drawing.Point(180, 294);
            this.saisieNumTel.Name = "saisieNumTel";
            this.saisieNumTel.Size = new System.Drawing.Size(122, 20);
            this.saisieNumTel.TabIndex = 14;
            this.saisieNumTel.TextChanged += new System.EventHandler(this.saisieNumTel_TextChanged);
            // 
            // saisieNumTelParent
            // 
            this.saisieNumTelParent.Location = new System.Drawing.Point(234, 335);
            this.saisieNumTelParent.Name = "saisieNumTelParent";
            this.saisieNumTelParent.Size = new System.Drawing.Size(122, 20);
            this.saisieNumTelParent.TabIndex = 15;
            this.saisieNumTelParent.TextChanged += new System.EventHandler(this.saisieNumTelParent_TextChanged);
            // 
            // boutonSoumettre
            // 
            this.boutonSoumettre.Location = new System.Drawing.Point(305, 557);
            this.boutonSoumettre.Name = "boutonSoumettre";
            this.boutonSoumettre.Size = new System.Drawing.Size(75, 23);
            this.boutonSoumettre.TabIndex = 16;
            this.boutonSoumettre.Text = "Soumettre";
            this.boutonSoumettre.UseVisualStyleBackColor = true;
            this.boutonSoumettre.Click += new System.EventHandler(this.boutonSoumettre_Click);
            // 
            // labelClasseEleve
            // 
            this.labelClasseEleve.AutoSize = true;
            this.labelClasseEleve.Location = new System.Drawing.Point(53, 197);
            this.labelClasseEleve.Name = "labelClasseEleve";
            this.labelClasseEleve.Size = new System.Drawing.Size(86, 13);
            this.labelClasseEleve.TabIndex = 17;
            this.labelClasseEleve.Text = "Classe de l\'élève";
            // 
            // listeClasse
            // 
            this.listeClasse.FormattingEnabled = true;
            this.listeClasse.Location = new System.Drawing.Point(180, 196);
            this.listeClasse.Name = "listeClasse";
            this.listeClasse.Size = new System.Drawing.Size(121, 21);
            this.listeClasse.TabIndex = 19;
            this.listeClasse.SelectedIndexChanged += new System.EventHandler(this.listeClasse_SelectedIndexChanged);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(51, 557);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 20;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::InfirmerieGUI.Properties.Resources.reforme_des_lycees_rentree_septembre_2019_1024x854_1;
            this.pictureBox5.Location = new System.Drawing.Point(132, 525);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(167, 74);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // Module_de_saisie_d_élève
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 611);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.listeClasse);
            this.Controls.Add(this.labelClasseEleve);
            this.Controls.Add(this.boutonSoumettre);
            this.Controls.Add(this.saisieNumTelParent);
            this.Controls.Add(this.saisieNumTel);
            this.Controls.Add(this.saisieDateEleve);
            this.Controls.Add(this.saisiePrenom);
            this.Controls.Add(this.saisieNom);
            this.Controls.Add(this.saisieCommentaireSante);
            this.Controls.Add(this.labelCommentaire);
            this.Controls.Add(this.radioTiersTempsNon);
            this.Controls.Add(this.radioTiersTempsOui);
            this.Controls.Add(this.labelTiersTemps);
            this.Controls.Add(this.labelNumTelParent);
            this.Controls.Add(this.labelNumTel);
            this.Controls.Add(this.labelDateNaissance);
            this.Controls.Add(this.labelPrenomEleve);
            this.Controls.Add(this.labelNomEleve);
            this.Controls.Add(this.labelSaisieEleve);
            this.Name = "Module_de_saisie_d_élève";
            this.Text = "Module_de_saisie_d_élève";
            this.Load += new System.EventHandler(this.Module_de_saisie_d_élève_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSaisieEleve;
        private System.Windows.Forms.Label labelNomEleve;
        private System.Windows.Forms.Label labelPrenomEleve;
        private System.Windows.Forms.Label labelDateNaissance;
        private System.Windows.Forms.Label labelNumTel;
        private System.Windows.Forms.Label labelNumTelParent;
        private System.Windows.Forms.Label labelTiersTemps;
        private System.Windows.Forms.RadioButton radioTiersTempsOui;
        private System.Windows.Forms.RadioButton radioTiersTempsNon;
        private System.Windows.Forms.Label labelCommentaire;
        private System.Windows.Forms.RichTextBox saisieCommentaireSante;
        private System.Windows.Forms.TextBox saisieNom;
        private System.Windows.Forms.TextBox saisiePrenom;
        private System.Windows.Forms.DateTimePicker saisieDateEleve;
        private System.Windows.Forms.TextBox saisieNumTel;
        private System.Windows.Forms.TextBox saisieNumTelParent;
        private System.Windows.Forms.Button boutonSoumettre;
        private System.Windows.Forms.Label labelClasseEleve;
        private System.Windows.Forms.ComboBox listeClasse;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}
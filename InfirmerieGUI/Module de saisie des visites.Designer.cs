
namespace InfirmerieGUI
{
    partial class Module_de_saisie_des_visites
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
            this.labelHeureFin = new System.Windows.Forms.Label();
            this.radioHopitalVisite = new System.Windows.Forms.RadioButton();
            this.labelCommentaireVisite = new System.Windows.Forms.Label();
            this.labelDateNaissance = new System.Windows.Forms.Label();
            this.labelHeureDebut = new System.Windows.Forms.Label();
            this.labelNomEleve = new System.Windows.Forms.Label();
            this.listeEleves = new System.Windows.Forms.ComboBox();
            this.saisieDateDeb = new System.Windows.Forms.DateTimePicker();
            this.saisieDateFin = new System.Windows.Forms.DateTimePicker();
            this.saisieMotifVisite = new System.Windows.Forms.TextBox();
            this.radioPasSuiteVisite = new System.Windows.Forms.RadioButton();
            this.radioParentsNon = new System.Windows.Forms.RadioButton();
            this.radioParentsOui = new System.Windows.Forms.RadioButton();
            this.btnRetour = new System.Windows.Forms.Button();
            this.boutonSoumettre = new System.Windows.Forms.Button();
            this.groupeRadioSuite = new System.Windows.Forms.GroupBox();
            this.groupeRadioParents = new System.Windows.Forms.GroupBox();
            this.saisieCommentaireVisite = new System.Windows.Forms.RichTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupeRadioSuite.SuspendLayout();
            this.groupeRadioParents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSaisieEleve
            // 
            this.labelSaisieEleve.AutoSize = true;
            this.labelSaisieEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaisieEleve.Location = new System.Drawing.Point(86, 34);
            this.labelSaisieEleve.Name = "labelSaisieEleve";
            this.labelSaisieEleve.Size = new System.Drawing.Size(230, 31);
            this.labelSaisieEleve.TabIndex = 22;
            this.labelSaisieEleve.Text = "Saisie d\'une visite";
            // 
            // labelHeureFin
            // 
            this.labelHeureFin.AutoSize = true;
            this.labelHeureFin.Location = new System.Drawing.Point(69, 197);
            this.labelHeureFin.Name = "labelHeureFin";
            this.labelHeureFin.Size = new System.Drawing.Size(65, 13);
            this.labelHeureFin.TabIndex = 37;
            this.labelHeureFin.Text = "Heure de fin";
            // 
            // radioHopitalVisite
            // 
            this.radioHopitalVisite.AutoSize = true;
            this.radioHopitalVisite.Location = new System.Drawing.Point(6, 31);
            this.radioHopitalVisite.Name = "radioHopitalVisite";
            this.radioHopitalVisite.Size = new System.Drawing.Size(58, 17);
            this.radioHopitalVisite.TabIndex = 30;
            this.radioHopitalVisite.Text = "Hopital";
            this.radioHopitalVisite.UseVisualStyleBackColor = true;
            // 
            // labelCommentaireVisite
            // 
            this.labelCommentaireVisite.AutoSize = true;
            this.labelCommentaireVisite.Location = new System.Drawing.Point(43, 294);
            this.labelCommentaireVisite.Name = "labelCommentaireVisite";
            this.labelCommentaireVisite.Size = new System.Drawing.Size(121, 13);
            this.labelCommentaireVisite.TabIndex = 27;
            this.labelCommentaireVisite.Text = "Commentaire de la visite";
            // 
            // labelDateNaissance
            // 
            this.labelDateNaissance.AutoSize = true;
            this.labelDateNaissance.Location = new System.Drawing.Point(69, 243);
            this.labelDateNaissance.Name = "labelDateNaissance";
            this.labelDateNaissance.Size = new System.Drawing.Size(83, 13);
            this.labelDateNaissance.TabIndex = 26;
            this.labelDateNaissance.Text = "Motif de la visite";
            // 
            // labelHeureDebut
            // 
            this.labelHeureDebut.AutoSize = true;
            this.labelHeureDebut.Location = new System.Drawing.Point(69, 159);
            this.labelHeureDebut.Name = "labelHeureDebut";
            this.labelHeureDebut.Size = new System.Drawing.Size(81, 13);
            this.labelHeureDebut.TabIndex = 25;
            this.labelHeureDebut.Text = "Heure du début";
            // 
            // labelNomEleve
            // 
            this.labelNomEleve.AutoSize = true;
            this.labelNomEleve.Location = new System.Drawing.Point(69, 114);
            this.labelNomEleve.Name = "labelNomEleve";
            this.labelNomEleve.Size = new System.Drawing.Size(77, 13);
            this.labelNomEleve.TabIndex = 24;
            this.labelNomEleve.Text = "Nom de l\'élève";
            // 
            // listeEleves
            // 
            this.listeEleves.FormattingEnabled = true;
            this.listeEleves.Location = new System.Drawing.Point(196, 111);
            this.listeEleves.Name = "listeEleves";
            this.listeEleves.Size = new System.Drawing.Size(137, 21);
            this.listeEleves.TabIndex = 39;
            // 
            // saisieDateDeb
            // 
            this.saisieDateDeb.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.saisieDateDeb.Location = new System.Drawing.Point(191, 159);
            this.saisieDateDeb.Name = "saisieDateDeb";
            this.saisieDateDeb.Size = new System.Drawing.Size(70, 20);
            this.saisieDateDeb.TabIndex = 40;
            this.saisieDateDeb.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // saisieDateFin
            // 
            this.saisieDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.saisieDateFin.Location = new System.Drawing.Point(191, 197);
            this.saisieDateFin.Name = "saisieDateFin";
            this.saisieDateFin.Size = new System.Drawing.Size(70, 20);
            this.saisieDateFin.TabIndex = 41;
            // 
            // saisieMotifVisite
            // 
            this.saisieMotifVisite.Location = new System.Drawing.Point(191, 240);
            this.saisieMotifVisite.Name = "saisieMotifVisite";
            this.saisieMotifVisite.Size = new System.Drawing.Size(142, 20);
            this.saisieMotifVisite.TabIndex = 42;
            // 
            // radioPasSuiteVisite
            // 
            this.radioPasSuiteVisite.AutoSize = true;
            this.radioPasSuiteVisite.Checked = true;
            this.radioPasSuiteVisite.Location = new System.Drawing.Point(189, 31);
            this.radioPasSuiteVisite.Name = "radioPasSuiteVisite";
            this.radioPasSuiteVisite.Size = new System.Drawing.Size(83, 17);
            this.radioPasSuiteVisite.TabIndex = 43;
            this.radioPasSuiteVisite.TabStop = true;
            this.radioPasSuiteVisite.Text = "Pas de suite";
            this.radioPasSuiteVisite.UseVisualStyleBackColor = true;
            // 
            // radioParentsNon
            // 
            this.radioParentsNon.AutoSize = true;
            this.radioParentsNon.Checked = true;
            this.radioParentsNon.Location = new System.Drawing.Point(63, 19);
            this.radioParentsNon.Name = "radioParentsNon";
            this.radioParentsNon.Size = new System.Drawing.Size(45, 17);
            this.radioParentsNon.TabIndex = 46;
            this.radioParentsNon.TabStop = true;
            this.radioParentsNon.Text = "Non";
            this.radioParentsNon.UseVisualStyleBackColor = true;
            // 
            // radioParentsOui
            // 
            this.radioParentsOui.AutoSize = true;
            this.radioParentsOui.Location = new System.Drawing.Point(6, 19);
            this.radioParentsOui.Name = "radioParentsOui";
            this.radioParentsOui.Size = new System.Drawing.Size(41, 17);
            this.radioParentsOui.TabIndex = 45;
            this.radioParentsOui.Text = "Oui";
            this.radioParentsOui.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(39, 566);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 48;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // boutonSoumettre
            // 
            this.boutonSoumettre.Location = new System.Drawing.Point(293, 566);
            this.boutonSoumettre.Name = "boutonSoumettre";
            this.boutonSoumettre.Size = new System.Drawing.Size(75, 23);
            this.boutonSoumettre.TabIndex = 47;
            this.boutonSoumettre.Text = "Soumettre";
            this.boutonSoumettre.UseVisualStyleBackColor = true;
            this.boutonSoumettre.Click += new System.EventHandler(this.boutonSoumettre_Click);
            // 
            // groupeRadioSuite
            // 
            this.groupeRadioSuite.Controls.Add(this.radioHopitalVisite);
            this.groupeRadioSuite.Controls.Add(this.radioPasSuiteVisite);
            this.groupeRadioSuite.Location = new System.Drawing.Point(46, 383);
            this.groupeRadioSuite.Name = "groupeRadioSuite";
            this.groupeRadioSuite.Size = new System.Drawing.Size(287, 59);
            this.groupeRadioSuite.TabIndex = 49;
            this.groupeRadioSuite.TabStop = false;
            this.groupeRadioSuite.Text = "Suite de la visite";
            // 
            // groupeRadioParents
            // 
            this.groupeRadioParents.Controls.Add(this.radioParentsOui);
            this.groupeRadioParents.Controls.Add(this.radioParentsNon);
            this.groupeRadioParents.Location = new System.Drawing.Point(72, 481);
            this.groupeRadioParents.Name = "groupeRadioParents";
            this.groupeRadioParents.Size = new System.Drawing.Size(108, 45);
            this.groupeRadioParents.TabIndex = 50;
            this.groupeRadioParents.TabStop = false;
            this.groupeRadioParents.Text = "Parents prévenus";
            // 
            // saisieCommentaireVisite
            // 
            this.saisieCommentaireVisite.Location = new System.Drawing.Point(191, 288);
            this.saisieCommentaireVisite.Name = "saisieCommentaireVisite";
            this.saisieCommentaireVisite.Size = new System.Drawing.Size(142, 79);
            this.saisieCommentaireVisite.TabIndex = 51;
            this.saisieCommentaireVisite.Text = "";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::InfirmerieGUI.Properties.Resources._16094;
            this.pictureBox4.Location = new System.Drawing.Point(120, 560);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(167, 74);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 52;
            this.pictureBox4.TabStop = false;
            // 
            // Module_de_saisie_des_visites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 641);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.saisieCommentaireVisite);
            this.Controls.Add(this.groupeRadioParents);
            this.Controls.Add(this.groupeRadioSuite);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.boutonSoumettre);
            this.Controls.Add(this.saisieMotifVisite);
            this.Controls.Add(this.saisieDateFin);
            this.Controls.Add(this.saisieDateDeb);
            this.Controls.Add(this.listeEleves);
            this.Controls.Add(this.labelHeureFin);
            this.Controls.Add(this.labelCommentaireVisite);
            this.Controls.Add(this.labelDateNaissance);
            this.Controls.Add(this.labelHeureDebut);
            this.Controls.Add(this.labelNomEleve);
            this.Controls.Add(this.labelSaisieEleve);
            this.Name = "Module_de_saisie_des_visites";
            this.Text = "Module_de_saisie_des_visites";
            this.groupeRadioSuite.ResumeLayout(false);
            this.groupeRadioSuite.PerformLayout();
            this.groupeRadioParents.ResumeLayout(false);
            this.groupeRadioParents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSaisieEleve;
        private System.Windows.Forms.Label labelHeureFin;
        private System.Windows.Forms.RadioButton radioHopitalVisite;
        private System.Windows.Forms.Label labelCommentaireVisite;
        private System.Windows.Forms.Label labelDateNaissance;
        private System.Windows.Forms.Label labelHeureDebut;
        private System.Windows.Forms.Label labelNomEleve;
        private System.Windows.Forms.ComboBox listeEleves;
        private System.Windows.Forms.DateTimePicker saisieDateDeb;
        private System.Windows.Forms.DateTimePicker saisieDateFin;
        private System.Windows.Forms.TextBox saisieMotifVisite;
        private System.Windows.Forms.RadioButton radioPasSuiteVisite;
        private System.Windows.Forms.RadioButton radioParentsNon;
        private System.Windows.Forms.RadioButton radioParentsOui;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button boutonSoumettre;
        private System.Windows.Forms.GroupBox groupeRadioSuite;
        private System.Windows.Forms.GroupBox groupeRadioParents;
        private System.Windows.Forms.RichTextBox saisieCommentaireVisite;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
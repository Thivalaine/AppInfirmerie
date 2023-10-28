
namespace InfirmerieGUI
{
    partial class Vue_des_visites
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
            this.btnRetour = new System.Windows.Forms.Button();
            this.labelSaisieEleve = new System.Windows.Forms.Label();
            this.btnActualiserListeEleve = new System.Windows.Forms.Button();
            this.btnModifierListeEleves = new System.Windows.Forms.Button();
            this.tableauVisite = new System.Windows.Forms.DataGridView();
            this.groupeRadioParents = new System.Windows.Forms.GroupBox();
            this.radioParentsOui = new System.Windows.Forms.RadioButton();
            this.radioParentsNon = new System.Windows.Forms.RadioButton();
            this.groupeRadioSuite = new System.Windows.Forms.GroupBox();
            this.radioHopitalVisite = new System.Windows.Forms.RadioButton();
            this.radioPasSuiteVisite = new System.Windows.Forms.RadioButton();
            this.saisieMotifVisite = new System.Windows.Forms.TextBox();
            this.saisieDateFin = new System.Windows.Forms.DateTimePicker();
            this.saisieDateDeb = new System.Windows.Forms.DateTimePicker();
            this.listeEleves = new System.Windows.Forms.ComboBox();
            this.labelHeureFin = new System.Windows.Forms.Label();
            this.saisieCommentaireVisite = new System.Windows.Forms.TextBox();
            this.labelCommentaireVisite = new System.Windows.Forms.Label();
            this.labelDateNaissance = new System.Windows.Forms.Label();
            this.labelHeureDebut = new System.Windows.Forms.Label();
            this.labelNomEleve = new System.Windows.Forms.Label();
            this.btnPrescription = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableauVisite)).BeginInit();
            this.groupeRadioParents.SuspendLayout();
            this.groupeRadioSuite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(1084, 542);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 66;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // labelSaisieEleve
            // 
            this.labelSaisieEleve.AutoSize = true;
            this.labelSaisieEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaisieEleve.Location = new System.Drawing.Point(58, 47);
            this.labelSaisieEleve.Name = "labelSaisieEleve";
            this.labelSaisieEleve.Size = new System.Drawing.Size(301, 31);
            this.labelSaisieEleve.TabIndex = 46;
            this.labelSaisieEleve.Text = "Modification d\'une visite\r\n";
            // 
            // btnActualiserListeEleve
            // 
            this.btnActualiserListeEleve.Location = new System.Drawing.Point(408, 542);
            this.btnActualiserListeEleve.Name = "btnActualiserListeEleve";
            this.btnActualiserListeEleve.Size = new System.Drawing.Size(75, 23);
            this.btnActualiserListeEleve.TabIndex = 45;
            this.btnActualiserListeEleve.Text = "Actualiser";
            this.btnActualiserListeEleve.UseVisualStyleBackColor = true;
            this.btnActualiserListeEleve.Click += new System.EventHandler(this.btnActualiserListeEleve_Click);
            // 
            // btnModifierListeEleves
            // 
            this.btnModifierListeEleves.Location = new System.Drawing.Point(300, 582);
            this.btnModifierListeEleves.Name = "btnModifierListeEleves";
            this.btnModifierListeEleves.Size = new System.Drawing.Size(75, 23);
            this.btnModifierListeEleves.TabIndex = 43;
            this.btnModifierListeEleves.Text = "Modifier";
            this.btnModifierListeEleves.UseVisualStyleBackColor = true;
            this.btnModifierListeEleves.Click += new System.EventHandler(this.btnModifierListeEleves_Click);
            // 
            // tableauVisite
            // 
            this.tableauVisite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauVisite.Location = new System.Drawing.Point(408, 34);
            this.tableauVisite.Name = "tableauVisite";
            this.tableauVisite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableauVisite.Size = new System.Drawing.Size(751, 477);
            this.tableauVisite.TabIndex = 42;
            this.tableauVisite.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableauVisite_CellClick);
            this.tableauVisite.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableauVisite_CellContentClick);
            // 
            // groupeRadioParents
            // 
            this.groupeRadioParents.Controls.Add(this.radioParentsOui);
            this.groupeRadioParents.Controls.Add(this.radioParentsNon);
            this.groupeRadioParents.Location = new System.Drawing.Point(64, 424);
            this.groupeRadioParents.Name = "groupeRadioParents";
            this.groupeRadioParents.Size = new System.Drawing.Size(108, 45);
            this.groupeRadioParents.TabIndex = 82;
            this.groupeRadioParents.TabStop = false;
            this.groupeRadioParents.Text = "Parents prévenus";
            // 
            // radioParentsOui
            // 
            this.radioParentsOui.AutoSize = true;
            this.radioParentsOui.Location = new System.Drawing.Point(6, 19);
            this.radioParentsOui.Name = "radioParentsOui";
            this.radioParentsOui.Size = new System.Drawing.Size(41, 17);
            this.radioParentsOui.TabIndex = 45;
            this.radioParentsOui.TabStop = true;
            this.radioParentsOui.Text = "Oui";
            this.radioParentsOui.UseVisualStyleBackColor = true;
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
            // groupeRadioSuite
            // 
            this.groupeRadioSuite.Controls.Add(this.radioHopitalVisite);
            this.groupeRadioSuite.Controls.Add(this.radioPasSuiteVisite);
            this.groupeRadioSuite.Location = new System.Drawing.Point(64, 346);
            this.groupeRadioSuite.Name = "groupeRadioSuite";
            this.groupeRadioSuite.Size = new System.Drawing.Size(314, 59);
            this.groupeRadioSuite.TabIndex = 81;
            this.groupeRadioSuite.TabStop = false;
            this.groupeRadioSuite.Text = "Suite de la visite";
            // 
            // radioHopitalVisite
            // 
            this.radioHopitalVisite.AutoSize = true;
            this.radioHopitalVisite.Location = new System.Drawing.Point(6, 31);
            this.radioHopitalVisite.Name = "radioHopitalVisite";
            this.radioHopitalVisite.Size = new System.Drawing.Size(58, 17);
            this.radioHopitalVisite.TabIndex = 30;
            this.radioHopitalVisite.TabStop = true;
            this.radioHopitalVisite.Text = "Hopital";
            this.radioHopitalVisite.UseVisualStyleBackColor = true;
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
            // saisieMotifVisite
            // 
            this.saisieMotifVisite.Location = new System.Drawing.Point(194, 235);
            this.saisieMotifVisite.Name = "saisieMotifVisite";
            this.saisieMotifVisite.Size = new System.Drawing.Size(122, 20);
            this.saisieMotifVisite.TabIndex = 78;
            // 
            // saisieDateFin
            // 
            this.saisieDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.saisieDateFin.Location = new System.Drawing.Point(194, 192);
            this.saisieDateFin.Name = "saisieDateFin";
            this.saisieDateFin.Size = new System.Drawing.Size(70, 20);
            this.saisieDateFin.TabIndex = 77;
            // 
            // saisieDateDeb
            // 
            this.saisieDateDeb.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.saisieDateDeb.Location = new System.Drawing.Point(194, 154);
            this.saisieDateDeb.Name = "saisieDateDeb";
            this.saisieDateDeb.Size = new System.Drawing.Size(70, 20);
            this.saisieDateDeb.TabIndex = 76;
            // 
            // listeEleves
            // 
            this.listeEleves.FormattingEnabled = true;
            this.listeEleves.Location = new System.Drawing.Point(194, 106);
            this.listeEleves.Name = "listeEleves";
            this.listeEleves.Size = new System.Drawing.Size(121, 21);
            this.listeEleves.TabIndex = 75;
            this.listeEleves.SelectedIndexChanged += new System.EventHandler(this.listeEleves_SelectedIndexChanged);
            // 
            // labelHeureFin
            // 
            this.labelHeureFin.AutoSize = true;
            this.labelHeureFin.Location = new System.Drawing.Point(72, 192);
            this.labelHeureFin.Name = "labelHeureFin";
            this.labelHeureFin.Size = new System.Drawing.Size(65, 13);
            this.labelHeureFin.TabIndex = 74;
            this.labelHeureFin.Text = "Heure de fin";
            // 
            // saisieCommentaireVisite
            // 
            this.saisieCommentaireVisite.Location = new System.Drawing.Point(194, 289);
            this.saisieCommentaireVisite.Name = "saisieCommentaireVisite";
            this.saisieCommentaireVisite.Size = new System.Drawing.Size(122, 20);
            this.saisieCommentaireVisite.TabIndex = 72;
            // 
            // labelCommentaireVisite
            // 
            this.labelCommentaireVisite.AutoSize = true;
            this.labelCommentaireVisite.Location = new System.Drawing.Point(46, 289);
            this.labelCommentaireVisite.Name = "labelCommentaireVisite";
            this.labelCommentaireVisite.Size = new System.Drawing.Size(121, 13);
            this.labelCommentaireVisite.TabIndex = 70;
            this.labelCommentaireVisite.Text = "Commentaire de la visite";
            // 
            // labelDateNaissance
            // 
            this.labelDateNaissance.AutoSize = true;
            this.labelDateNaissance.Location = new System.Drawing.Point(72, 238);
            this.labelDateNaissance.Name = "labelDateNaissance";
            this.labelDateNaissance.Size = new System.Drawing.Size(83, 13);
            this.labelDateNaissance.TabIndex = 69;
            this.labelDateNaissance.Text = "Motif de la visite";
            // 
            // labelHeureDebut
            // 
            this.labelHeureDebut.AutoSize = true;
            this.labelHeureDebut.Location = new System.Drawing.Point(72, 154);
            this.labelHeureDebut.Name = "labelHeureDebut";
            this.labelHeureDebut.Size = new System.Drawing.Size(81, 13);
            this.labelHeureDebut.TabIndex = 68;
            this.labelHeureDebut.Text = "Heure du début";
            // 
            // labelNomEleve
            // 
            this.labelNomEleve.AutoSize = true;
            this.labelNomEleve.Location = new System.Drawing.Point(72, 109);
            this.labelNomEleve.Name = "labelNomEleve";
            this.labelNomEleve.Size = new System.Drawing.Size(77, 13);
            this.labelNomEleve.TabIndex = 67;
            this.labelNomEleve.Text = "Nom de l\'élève";
            // 
            // btnPrescription
            // 
            this.btnPrescription.Location = new System.Drawing.Point(64, 582);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.Size = new System.Drawing.Size(75, 23);
            this.btnPrescription.TabIndex = 87;
            this.btnPrescription.Text = "Prescription";
            this.btnPrescription.UseVisualStyleBackColor = true;
            this.btnPrescription.Click += new System.EventHandler(this.btnPrescription_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::InfirmerieGUI.Properties.Resources._16094;
            this.pictureBox4.Location = new System.Drawing.Point(654, 517);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(252, 86);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 88;
            this.pictureBox4.TabStop = false;
            // 
            // Vue_des_visites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 672);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnPrescription);
            this.Controls.Add(this.groupeRadioParents);
            this.Controls.Add(this.groupeRadioSuite);
            this.Controls.Add(this.saisieMotifVisite);
            this.Controls.Add(this.saisieDateFin);
            this.Controls.Add(this.saisieDateDeb);
            this.Controls.Add(this.listeEleves);
            this.Controls.Add(this.labelHeureFin);
            this.Controls.Add(this.saisieCommentaireVisite);
            this.Controls.Add(this.labelCommentaireVisite);
            this.Controls.Add(this.labelDateNaissance);
            this.Controls.Add(this.labelHeureDebut);
            this.Controls.Add(this.labelNomEleve);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.labelSaisieEleve);
            this.Controls.Add(this.btnActualiserListeEleve);
            this.Controls.Add(this.btnModifierListeEleves);
            this.Controls.Add(this.tableauVisite);
            this.Name = "Vue_des_visites";
            this.Text = "Vue_des_visites";
            this.Load += new System.EventHandler(this.Vue_des_visites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableauVisite)).EndInit();
            this.groupeRadioParents.ResumeLayout(false);
            this.groupeRadioParents.PerformLayout();
            this.groupeRadioSuite.ResumeLayout(false);
            this.groupeRadioSuite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label labelSaisieEleve;
        private System.Windows.Forms.Button btnActualiserListeEleve;
        private System.Windows.Forms.Button btnModifierListeEleves;
        private System.Windows.Forms.DataGridView tableauVisite;
        private System.Windows.Forms.GroupBox groupeRadioParents;
        private System.Windows.Forms.RadioButton radioParentsOui;
        private System.Windows.Forms.RadioButton radioParentsNon;
        private System.Windows.Forms.GroupBox groupeRadioSuite;
        private System.Windows.Forms.RadioButton radioHopitalVisite;
        private System.Windows.Forms.RadioButton radioPasSuiteVisite;
        private System.Windows.Forms.TextBox saisieMotifVisite;
        private System.Windows.Forms.DateTimePicker saisieDateFin;
        private System.Windows.Forms.DateTimePicker saisieDateDeb;
        private System.Windows.Forms.ComboBox listeEleves;
        private System.Windows.Forms.Label labelHeureFin;
        private System.Windows.Forms.TextBox saisieCommentaireVisite;
        private System.Windows.Forms.Label labelCommentaireVisite;
        private System.Windows.Forms.Label labelDateNaissance;
        private System.Windows.Forms.Label labelHeureDebut;
        private System.Windows.Forms.Label labelNomEleve;
        private System.Windows.Forms.Button btnPrescription;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
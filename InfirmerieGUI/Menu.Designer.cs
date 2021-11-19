namespace InfirmerieGUI
{
    partial class Menu
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
            this.labelMenu = new System.Windows.Forms.Label();
            this.btnSaisieVisite = new System.Windows.Forms.Button();
            this.btnSaisieMedoc = new System.Windows.Forms.Button();
            this.btnAncienneVisite = new System.Windows.Forms.Button();
            this.btnVueMedoc = new System.Windows.Forms.Button();
            this.btnListeEleve = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAjoutEleve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Location = new System.Drawing.Point(277, 48);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(34, 13);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "Menu";
            this.labelMenu.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSaisieVisite
            // 
            this.btnSaisieVisite.Location = new System.Drawing.Point(99, 81);
            this.btnSaisieVisite.Name = "btnSaisieVisite";
            this.btnSaisieVisite.Size = new System.Drawing.Size(95, 48);
            this.btnSaisieVisite.TabIndex = 1;
            this.btnSaisieVisite.Text = "Saisie de nouvelles visites";
            this.btnSaisieVisite.UseVisualStyleBackColor = true;
            // 
            // btnSaisieMedoc
            // 
            this.btnSaisieMedoc.Location = new System.Drawing.Point(99, 150);
            this.btnSaisieMedoc.Name = "btnSaisieMedoc";
            this.btnSaisieMedoc.Size = new System.Drawing.Size(95, 44);
            this.btnSaisieMedoc.TabIndex = 2;
            this.btnSaisieMedoc.Text = "Saisie des médicaments";
            this.btnSaisieMedoc.UseVisualStyleBackColor = true;
            // 
            // btnAncienneVisite
            // 
            this.btnAncienneVisite.Location = new System.Drawing.Point(379, 80);
            this.btnAncienneVisite.Name = "btnAncienneVisite";
            this.btnAncienneVisite.Size = new System.Drawing.Size(90, 49);
            this.btnAncienneVisite.TabIndex = 3;
            this.btnAncienneVisite.Text = "Vue d\'anciennes visites";
            this.btnAncienneVisite.UseVisualStyleBackColor = true;
            // 
            // btnVueMedoc
            // 
            this.btnVueMedoc.Location = new System.Drawing.Point(379, 150);
            this.btnVueMedoc.Name = "btnVueMedoc";
            this.btnVueMedoc.Size = new System.Drawing.Size(85, 45);
            this.btnVueMedoc.TabIndex = 4;
            this.btnVueMedoc.Text = "Vue des médicaments";
            this.btnVueMedoc.UseVisualStyleBackColor = true;
            // 
            // btnListeEleve
            // 
            this.btnListeEleve.Location = new System.Drawing.Point(315, 227);
            this.btnListeEleve.Name = "btnListeEleve";
            this.btnListeEleve.Size = new System.Drawing.Size(81, 41);
            this.btnListeEleve.TabIndex = 5;
            this.btnListeEleve.Text = "Liste des élèves";
            this.btnListeEleve.UseVisualStyleBackColor = true;
            this.btnListeEleve.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(256, 340);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // btnAjoutEleve
            // 
            this.btnAjoutEleve.Location = new System.Drawing.Point(207, 227);
            this.btnAjoutEleve.Name = "btnAjoutEleve";
            this.btnAjoutEleve.Size = new System.Drawing.Size(78, 43);
            this.btnAjoutEleve.TabIndex = 7;
            this.btnAjoutEleve.Text = "Ajout d\'élèves";
            this.btnAjoutEleve.UseVisualStyleBackColor = true;
            this.btnAjoutEleve.Click += new System.EventHandler(this.btnAjoutEleve_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjoutEleve);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnListeEleve);
            this.Controls.Add(this.btnVueMedoc);
            this.Controls.Add(this.btnAncienneVisite);
            this.Controls.Add(this.btnSaisieMedoc);
            this.Controls.Add(this.btnSaisieVisite);
            this.Controls.Add(this.labelMenu);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button btnSaisieVisite;
        private System.Windows.Forms.Button btnSaisieMedoc;
        private System.Windows.Forms.Button btnAncienneVisite;
        private System.Windows.Forms.Button btnVueMedoc;
        private System.Windows.Forms.Button btnListeEleve;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAjoutEleve;
    }
}
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAjoutEleve = new System.Windows.Forms.Button();
            this.btnListeEleves = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(377, 28);
            this.labelMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(238, 91);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "Menu";
            this.labelMenu.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSaisieVisite
            // 
            this.btnSaisieVisite.Location = new System.Drawing.Point(32, 150);
            this.btnSaisieVisite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaisieVisite.Name = "btnSaisieVisite";
            this.btnSaisieVisite.Size = new System.Drawing.Size(300, 103);
            this.btnSaisieVisite.TabIndex = 1;
            this.btnSaisieVisite.Text = "Saisie de nouvelles visites";
            this.btnSaisieVisite.UseVisualStyleBackColor = true;
            this.btnSaisieVisite.Click += new System.EventHandler(this.btnSaisieVisite_Click);
            // 
            // btnSaisieMedoc
            // 
            this.btnSaisieMedoc.Location = new System.Drawing.Point(32, 261);
            this.btnSaisieMedoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaisieMedoc.Name = "btnSaisieMedoc";
            this.btnSaisieMedoc.Size = new System.Drawing.Size(300, 103);
            this.btnSaisieMedoc.TabIndex = 2;
            this.btnSaisieMedoc.Text = "Saisie des médicaments";
            this.btnSaisieMedoc.UseVisualStyleBackColor = true;
            this.btnSaisieMedoc.Click += new System.EventHandler(this.btnSaisieMedoc_Click);
            // 
            // btnAncienneVisite
            // 
            this.btnAncienneVisite.Location = new System.Drawing.Point(688, 150);
            this.btnAncienneVisite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAncienneVisite.Name = "btnAncienneVisite";
            this.btnAncienneVisite.Size = new System.Drawing.Size(300, 103);
            this.btnAncienneVisite.TabIndex = 3;
            this.btnAncienneVisite.Text = "Vue d\'anciennes visites";
            this.btnAncienneVisite.UseVisualStyleBackColor = true;
            this.btnAncienneVisite.Click += new System.EventHandler(this.btnAncienneVisite_Click);
            // 
            // btnVueMedoc
            // 
            this.btnVueMedoc.Location = new System.Drawing.Point(688, 261);
            this.btnVueMedoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVueMedoc.Name = "btnVueMedoc";
            this.btnVueMedoc.Size = new System.Drawing.Size(300, 103);
            this.btnVueMedoc.TabIndex = 4;
            this.btnVueMedoc.Text = "Vue des médicaments";
            this.btnVueMedoc.UseVisualStyleBackColor = true;
            this.btnVueMedoc.Click += new System.EventHandler(this.btnVueMedoc_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(457, 511);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(100, 28);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnAjoutEleve
            // 
            this.btnAjoutEleve.Location = new System.Drawing.Point(32, 370);
            this.btnAjoutEleve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjoutEleve.Name = "btnAjoutEleve";
            this.btnAjoutEleve.Size = new System.Drawing.Size(300, 103);
            this.btnAjoutEleve.TabIndex = 7;
            this.btnAjoutEleve.Text = "Ajout d\'élèves";
            this.btnAjoutEleve.UseVisualStyleBackColor = true;
            this.btnAjoutEleve.Click += new System.EventHandler(this.btnAjoutEleve_Click);
            // 
            // btnListeEleves
            // 
            this.btnListeEleves.Location = new System.Drawing.Point(688, 370);
            this.btnListeEleves.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListeEleves.Name = "btnListeEleves";
            this.btnListeEleves.Size = new System.Drawing.Size(300, 103);
            this.btnListeEleves.TabIndex = 9;
            this.btnListeEleves.Text = "Liste des élèves";
            this.btnListeEleves.UseVisualStyleBackColor = true;
            this.btnListeEleves.Click += new System.EventHandler(this.btnListeEleves_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::InfirmerieGUI.Properties.Resources.reforme_des_lycees_rentree_septembre_2019_1024x854_1;
            this.pictureBox5.Location = new System.Drawing.Point(407, 384);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(199, 91);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::InfirmerieGUI.Properties.Resources._16094;
            this.pictureBox4.Location = new System.Drawing.Point(407, 150);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(199, 91);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::InfirmerieGUI.Properties.Resources.medicament_risque_depression;
            this.pictureBox3.Location = new System.Drawing.Point(407, 261);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(199, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InfirmerieGUI.Properties.Resources.unnamed;
            this.pictureBox2.Location = new System.Drawing.Point(867, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InfirmerieGUI.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(32, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 554);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnListeEleves);
            this.Controls.Add(this.btnAjoutEleve);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnVueMedoc);
            this.Controls.Add(this.btnAncienneVisite);
            this.Controls.Add(this.btnSaisieMedoc);
            this.Controls.Add(this.btnSaisieVisite);
            this.Controls.Add(this.labelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button btnSaisieVisite;
        private System.Windows.Forms.Button btnSaisieMedoc;
        private System.Windows.Forms.Button btnAncienneVisite;
        private System.Windows.Forms.Button btnVueMedoc;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAjoutEleve;
        private System.Windows.Forms.Button btnListeEleves;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}
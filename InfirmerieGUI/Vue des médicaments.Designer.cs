
namespace InfirmerieGUI
{
    partial class Vue_des_médicaments
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saisieLibelleModif = new System.Windows.Forms.TextBox();
            this.tableauMedicament = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableauMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vue des médicaments";
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(675, 383);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(75, 23);
            this.btnActualiser.TabIndex = 2;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(339, 383);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 3;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(185, 229);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(60, 229);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 5;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Libellé du médicament";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // saisieLibelleModif
            // 
            this.saisieLibelleModif.Location = new System.Drawing.Point(60, 154);
            this.saisieLibelleModif.Name = "saisieLibelleModif";
            this.saisieLibelleModif.Size = new System.Drawing.Size(200, 20);
            this.saisieLibelleModif.TabIndex = 9;
            this.saisieLibelleModif.TextChanged += new System.EventHandler(this.saisieLibelleModif_TextChanged);
            // 
            // tableauMedicament
            // 
            this.tableauMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauMedicament.Location = new System.Drawing.Point(339, 59);
            this.tableauMedicament.Name = "tableauMedicament";
            this.tableauMedicament.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableauMedicament.Size = new System.Drawing.Size(411, 282);
            this.tableauMedicament.TabIndex = 10;
            this.tableauMedicament.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableauMedicament_CellClick);
            this.tableauMedicament.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableauMedicament_CellContentClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::InfirmerieGUI.Properties.Resources.medicament_risque_depression;
            this.pictureBox3.Location = new System.Drawing.Point(84, 267);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(149, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // Vue_des_médicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tableauMedicament);
            this.Controls.Add(this.saisieLibelleModif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.label1);
            this.Name = "Vue_des_médicaments";
            this.Text = "Vue_des_médicaments";
            this.Load += new System.EventHandler(this.Vue_des_médicaments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableauMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox saisieLibelleModif;
        private System.Windows.Forms.DataGridView tableauMedicament;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
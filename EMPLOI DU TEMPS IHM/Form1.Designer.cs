namespace EMPLOI_DU_TEMPS_IHM
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTN_COURS = new System.Windows.Forms.Button();
            this.Data_cours = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBX_ID_COURS = new System.Windows.Forms.TextBox();
            this.TBX_ID_ELEVE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Data_Etudiants = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cCoursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cCoursBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cCoursBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.donneCoursResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Data_cours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Etudiants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCoursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCoursBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCoursBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donneCoursResponseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_COURS
            // 
            this.BTN_COURS.BackColor = System.Drawing.Color.MistyRose;
            this.BTN_COURS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_COURS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_COURS.Location = new System.Drawing.Point(28, 423);
            this.BTN_COURS.Name = "BTN_COURS";
            this.BTN_COURS.Size = new System.Drawing.Size(246, 88);
            this.BTN_COURS.TabIndex = 1;
            this.BTN_COURS.Text = "Menu Administrateur";
            this.BTN_COURS.UseVisualStyleBackColor = false;
            this.BTN_COURS.Click += new System.EventHandler(this.BTN_COURS_Click);
            // 
            // Data_cours
            // 
            this.Data_cours.BackgroundColor = System.Drawing.Color.White;
            this.Data_cours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Data_cours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_cours.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_cours.DefaultCellStyle = dataGridViewCellStyle7;
            this.Data_cours.GridColor = System.Drawing.Color.Black;
            this.Data_cours.Location = new System.Drawing.Point(28, 62);
            this.Data_cours.Name = "Data_cours";
            this.Data_cours.Size = new System.Drawing.Size(749, 315);
            this.Data_cours.TabIndex = 2;
            this.Data_cours.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_cours_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(921, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 89);
            this.button1.TabIndex = 3;
            this.button1.Text = "Signaler sa présence\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(28, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(40, 0, 45, 0);
            this.label1.Size = new System.Drawing.Size(749, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "EMPLOI DU TEMPS DE LA SEMAINE";
            // 
            // TBX_ID_COURS
            // 
            this.TBX_ID_COURS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_ID_COURS.Location = new System.Drawing.Point(1118, 250);
            this.TBX_ID_COURS.Name = "TBX_ID_COURS";
            this.TBX_ID_COURS.Size = new System.Drawing.Size(100, 26);
            this.TBX_ID_COURS.TabIndex = 5;
            // 
            // TBX_ID_ELEVE
            // 
            this.TBX_ID_ELEVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_ID_ELEVE.Location = new System.Drawing.Point(1118, 298);
            this.TBX_ID_ELEVE.Name = "TBX_ID_ELEVE";
            this.TBX_ID_ELEVE.Size = new System.Drawing.Size(100, 26);
            this.TBX_ID_ELEVE.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(916, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choisir un Cours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(916, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choisir Son Nom";
            // 
            // Data_Etudiants
            // 
            this.Data_Etudiants.BackgroundColor = System.Drawing.Color.White;
            this.Data_Etudiants.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Data_Etudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Etudiants.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Etudiants.DefaultCellStyle = dataGridViewCellStyle8;
            this.Data_Etudiants.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Data_Etudiants.Location = new System.Drawing.Point(894, 62);
            this.Data_Etudiants.Name = "Data_Etudiants";
            this.Data_Etudiants.Size = new System.Drawing.Size(349, 144);
            this.Data_Etudiants.TabIndex = 9;
            this.Data_Etudiants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Etudiants_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(867, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(1);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(40, 0, 45, 0);
            this.label4.Size = new System.Drawing.Size(422, 44);
            this.label4.TabIndex = 10;
            this.label4.Text = "Liste des étudiants";
            // 
            // cCoursBindingSource
            // 
            this.cCoursBindingSource.DataSource = typeof(EMPLOI_DU_TEMPS_IHM.ServiceReference1.C_Cours);
            // 
            // cCoursBindingSource1
            // 
            this.cCoursBindingSource1.DataSource = typeof(EMPLOI_DU_TEMPS_IHM.ServiceReference1.C_Cours);
            // 
            // cCoursBindingSource2
            // 
            this.cCoursBindingSource2.DataSource = typeof(EMPLOI_DU_TEMPS_IHM.ServiceReference1.C_Cours);
            // 
            // donneCoursResponseBindingSource
            // 
            this.donneCoursResponseBindingSource.DataSource = typeof(EMPLOI_DU_TEMPS_IHM.ServiceReference1.DonneCoursResponse);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 544);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Data_Etudiants);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBX_ID_ELEVE);
            this.Controls.Add(this.TBX_ID_COURS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Data_cours);
            this.Controls.Add(this.BTN_COURS);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Data_cours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Etudiants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCoursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCoursBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCoursBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donneCoursResponseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource cCoursBindingSource;
        private System.Windows.Forms.Button BTN_COURS;
        private System.Windows.Forms.DataGridView Data_cours;
        private System.Windows.Forms.BindingSource cCoursBindingSource1;
        private System.Windows.Forms.BindingSource donneCoursResponseBindingSource;
        private System.Windows.Forms.BindingSource cCoursBindingSource2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBX_ID_COURS;
        private System.Windows.Forms.TextBox TBX_ID_ELEVE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Data_Etudiants;
        private System.Windows.Forms.Label label4;
    }
}


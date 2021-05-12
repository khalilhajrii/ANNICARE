
namespace application_adoption.Forms
{
    partial class List_users
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.combouser = new System.Windows.Forms.ComboBox();
            this.deleteuuser = new System.Windows.Forms.Button();
            this.moduser = new System.Windows.Forms.Button();
            this.btnadduser = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.griduser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griduser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // combouser
            // 
            this.combouser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.combouser.Cursor = System.Windows.Forms.Cursors.Default;
            this.combouser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combouser.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.combouser.FormattingEnabled = true;
            this.combouser.Items.AddRange(new object[] {
            "Nom"});
            this.combouser.Location = new System.Drawing.Point(520, 39);
            this.combouser.Name = "combouser";
            this.combouser.Size = new System.Drawing.Size(121, 21);
            this.combouser.TabIndex = 18;
            // 
            // deleteuuser
            // 
            this.deleteuuser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteuuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(195)))), ((int)(((byte)(158)))));
            this.deleteuuser.FlatAppearance.BorderSize = 0;
            this.deleteuuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteuuser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteuuser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteuuser.Image = global::application_adoption.Properties.Resources.icon_disk_disk_icon_disk_line_icon_dvd_icon_icon_1320073118181264386_48;
            this.deleteuuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteuuser.Location = new System.Drawing.Point(13, 636);
            this.deleteuuser.Name = "deleteuuser";
            this.deleteuuser.Size = new System.Drawing.Size(202, 48);
            this.deleteuuser.TabIndex = 12;
            this.deleteuuser.Text = "Supprimer";
            this.deleteuuser.UseVisualStyleBackColor = false;
            this.deleteuuser.Click += new System.EventHandler(this.deleteuuser_Click);
            // 
            // moduser
            // 
            this.moduser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.moduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(195)))), ((int)(((byte)(158)))));
            this.moduser.FlatAppearance.BorderSize = 0;
            this.moduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moduser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.moduser.Image = global::application_adoption.Properties.Resources.post_share_update_icon_1320184669913435325_48;
            this.moduser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moduser.Location = new System.Drawing.Point(13, 342);
            this.moduser.Name = "moduser";
            this.moduser.Size = new System.Drawing.Size(202, 48);
            this.moduser.TabIndex = 11;
            this.moduser.Text = "Modifier";
            this.moduser.UseVisualStyleBackColor = false;
            this.moduser.Click += new System.EventHandler(this.moduser_Click);
            // 
            // btnadduser
            // 
            this.btnadduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(195)))), ((int)(((byte)(158)))));
            this.btnadduser.FlatAppearance.BorderSize = 0;
            this.btnadduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadduser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadduser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadduser.Image = global::application_adoption.Properties.Resources.upload_icon_upload_line_icon_icon_1320073121636456908_48;
            this.btnadduser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadduser.Location = new System.Drawing.Point(13, 36);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(202, 48);
            this.btnadduser.TabIndex = 10;
            this.btnadduser.Text = "Ajouter";
            this.btnadduser.UseVisualStyleBackColor = false;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::application_adoption.Properties.Resources.BIENVENUE_CHEZ_ANICARE;
            this.pictureBox2.Location = new System.Drawing.Point(429, -95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(307, 297);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // griduser
            // 
            this.griduser.AllowUserToAddRows = false;
            this.griduser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.griduser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.griduser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.griduser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.griduser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griduser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.griduser.DefaultCellStyle = dataGridViewCellStyle8;
            this.griduser.EnableHeadersVisualStyles = false;
            this.griduser.Location = new System.Drawing.Point(243, 107);
            this.griduser.Name = "griduser";
            this.griduser.RowHeadersVisible = false;
            this.griduser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.griduser.Size = new System.Drawing.Size(878, 536);
            this.griduser.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Selectionner";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nom utilisateur";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mot de passe";
            this.Column4.Name = "Column4";
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsearch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtsearch.Location = new System.Drawing.Point(776, 42);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(174, 29);
            this.txtsearch.TabIndex = 16;
            this.txtsearch.Text = "Rechercher";
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.Enter += new System.EventHandler(this.txtsearch_Enter);
            this.txtsearch.Leave += new System.EventHandler(this.txtsearch_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(481, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 1);
            this.panel2.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(482, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 1);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::application_adoption.Properties.Resources.BIENVENUE_CHEZ_ANICARE;
            this.pictureBox1.Location = new System.Drawing.Point(705, -93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // List_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.combouser);
            this.Controls.Add(this.deleteuuser);
            this.Controls.Add(this.moduser);
            this.Controls.Add(this.btnadduser);
            this.Controls.Add(this.griduser);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "List_users";
            this.Size = new System.Drawing.Size(1137, 720);
            this.Load += new System.EventHandler(this.List_users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griduser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combouser;
        private System.Windows.Forms.Button deleteuuser;
        private System.Windows.Forms.Button moduser;
        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView griduser;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

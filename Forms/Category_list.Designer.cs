
namespace application_adoption.Forms
{
    partial class Category_list
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
            this.txtrecherche1 = new System.Windows.Forms.TextBox();
            this.btndeletecategory = new System.Windows.Forms.Button();
            this.combocategory = new System.Windows.Forms.ComboBox();
            this.gridcategory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnmodcategory = new System.Windows.Forms.Button();
            this.btnaddcategory = new System.Windows.Forms.Button();
            this.imageee = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridcategory)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtrecherche1
            // 
            this.txtrecherche1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtrecherche1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrecherche1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecherche1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtrecherche1.Location = new System.Drawing.Point(852, 58);
            this.txtrecherche1.Multiline = true;
            this.txtrecherche1.Name = "txtrecherche1";
            this.txtrecherche1.Size = new System.Drawing.Size(174, 29);
            this.txtrecherche1.TabIndex = 28;
            this.txtrecherche1.Text = "Rechercher";
            this.txtrecherche1.TextChanged += new System.EventHandler(this.txtrecherche1_TextChanged);
            this.txtrecherche1.Enter += new System.EventHandler(this.txtrecherche1_Enter);
            this.txtrecherche1.Leave += new System.EventHandler(this.txtrecherche1_Leave);
            // 
            // btndeletecategory
            // 
            this.btndeletecategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btndeletecategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(195)))), ((int)(((byte)(158)))));
            this.btndeletecategory.FlatAppearance.BorderSize = 0;
            this.btndeletecategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletecategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletecategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndeletecategory.Image = global::application_adoption.Properties.Resources.icon_disk_disk_icon_disk_line_icon_dvd_icon_icon_1320073118181264386_48;
            this.btndeletecategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeletecategory.Location = new System.Drawing.Point(17, 654);
            this.btndeletecategory.Name = "btndeletecategory";
            this.btndeletecategory.Size = new System.Drawing.Size(202, 48);
            this.btndeletecategory.TabIndex = 27;
            this.btndeletecategory.Text = "Supprimer";
            this.btndeletecategory.UseVisualStyleBackColor = false;
            this.btndeletecategory.Click += new System.EventHandler(this.btndeletecategory_Click);
            // 
            // combocategory
            // 
            this.combocategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.combocategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.combocategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combocategory.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.combocategory.FormattingEnabled = true;
            this.combocategory.Items.AddRange(new object[] {
            "Nom"});
            this.combocategory.Location = new System.Drawing.Point(600, 58);
            this.combocategory.Name = "combocategory";
            this.combocategory.Size = new System.Drawing.Size(121, 21);
            this.combocategory.TabIndex = 25;
            // 
            // gridcategory
            // 
            this.gridcategory.AllowUserToAddRows = false;
            this.gridcategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridcategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridcategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridcategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridcategory.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridcategory.EnableHeadersVisualStyles = false;
            this.gridcategory.Location = new System.Drawing.Point(247, 157);
            this.gridcategory.Name = "gridcategory";
            this.gridcategory.RowHeadersVisible = false;
            this.gridcategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridcategory.Size = new System.Drawing.Size(875, 501);
            this.gridcategory.TabIndex = 24;
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
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nom";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(561, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 1);
            this.panel2.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, -61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 1);
            this.panel1.TabIndex = 23;
            // 
            // btnmodcategory
            // 
            this.btnmodcategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnmodcategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(195)))), ((int)(((byte)(158)))));
            this.btnmodcategory.FlatAppearance.BorderSize = 0;
            this.btnmodcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodcategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodcategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmodcategory.Image = global::application_adoption.Properties.Resources.post_share_update_icon_1320184669913435325_48;
            this.btnmodcategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodcategory.Location = new System.Drawing.Point(17, 339);
            this.btnmodcategory.Name = "btnmodcategory";
            this.btnmodcategory.Size = new System.Drawing.Size(202, 48);
            this.btnmodcategory.TabIndex = 21;
            this.btnmodcategory.Text = "Modifier";
            this.btnmodcategory.UseVisualStyleBackColor = false;
            this.btnmodcategory.Click += new System.EventHandler(this.btnmodcategory_Click);
            // 
            // btnaddcategory
            // 
            this.btnaddcategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(195)))), ((int)(((byte)(158)))));
            this.btnaddcategory.FlatAppearance.BorderSize = 0;
            this.btnaddcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddcategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnaddcategory.Image = global::application_adoption.Properties.Resources.upload_icon_upload_line_icon_icon_1320073121636456908_48;
            this.btnaddcategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddcategory.Location = new System.Drawing.Point(17, 52);
            this.btnaddcategory.Name = "btnaddcategory";
            this.btnaddcategory.Size = new System.Drawing.Size(202, 48);
            this.btnaddcategory.TabIndex = 20;
            this.btnaddcategory.Text = "Ajouter";
            this.btnaddcategory.UseVisualStyleBackColor = false;
            this.btnaddcategory.Click += new System.EventHandler(this.btnaddcategory_Click);
            // 
            // imageee
            // 
            this.imageee.Image = global::application_adoption.Properties.Resources.BIENVENUE_CHEZ_ANICARE;
            this.imageee.Location = new System.Drawing.Point(785, -74);
            this.imageee.Name = "imageee";
            this.imageee.Size = new System.Drawing.Size(307, 289);
            this.imageee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageee.TabIndex = 23;
            this.imageee.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::application_adoption.Properties.Resources.BIENVENUE_CHEZ_ANICARE;
            this.pictureBox2.Location = new System.Drawing.Point(509, -76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(307, 297);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // Category_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtrecherche1);
            this.Controls.Add(this.btndeletecategory);
            this.Controls.Add(this.combocategory);
            this.Controls.Add(this.gridcategory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnmodcategory);
            this.Controls.Add(this.btnaddcategory);
            this.Controls.Add(this.imageee);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Category_list";
            this.Size = new System.Drawing.Size(1137, 720);
            this.Load += new System.EventHandler(this.Category_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridcategory)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtrecherche1;
        private System.Windows.Forms.Button btndeletecategory;
        private System.Windows.Forms.ComboBox combocategory;
        private System.Windows.Forms.DataGridView gridcategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnmodcategory;
        private System.Windows.Forms.Button btnaddcategory;
        private System.Windows.Forms.PictureBox imageee;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}


namespace application_adoption.Forms
{
    partial class Animal_list
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboanimal = new System.Windows.Forms.ComboBox();
            this.gridanimal = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.btndeleteanimal = new System.Windows.Forms.Button();
            this.btnmodanimal = new System.Windows.Forms.Button();
            this.btnaddanimal = new System.Windows.Forms.Button();
            this.imageee = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridanimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboanimal
            // 
            this.comboanimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.comboanimal.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboanimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboanimal.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.comboanimal.FormattingEnabled = true;
            this.comboanimal.Items.AddRange(new object[] {
            "Nom",
            "Categorie"});
            this.comboanimal.Location = new System.Drawing.Point(597, 31);
            this.comboanimal.Name = "comboanimal";
            this.comboanimal.Size = new System.Drawing.Size(121, 21);
            this.comboanimal.TabIndex = 16;
            this.comboanimal.SelectedIndexChanged += new System.EventHandler(this.comboclient_SelectedIndexChanged);
            // 
            // gridanimal
            // 
            this.gridanimal.AllowUserToAddRows = false;
            this.gridanimal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridanimal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridanimal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridanimal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridanimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridanimal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridanimal.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridanimal.EnableHeadersVisualStyles = false;
            this.gridanimal.Location = new System.Drawing.Point(244, 130);
            this.gridanimal.Name = "gridanimal";
            this.gridanimal.RowHeadersVisible = false;
            this.gridanimal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridanimal.Size = new System.Drawing.Size(875, 501);
            this.gridanimal.TabIndex = 15;
            this.gridanimal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataclient_CellContentClick);
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
            // Column4
            // 
            this.Column4.HeaderText = "Quantité";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Type";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Sexe";
            this.Column8.Name = "Column8";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Categorie";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(558, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 1);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(559, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 1);
            this.panel1.TabIndex = 12;
            // 
            // txtrecherche
            // 
            this.txtrecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtrecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrecherche.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecherche.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtrecherche.Location = new System.Drawing.Point(849, 31);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(174, 29);
            this.txtrecherche.TabIndex = 19;
            this.txtrecherche.Text = "Rechercher";
            this.txtrecherche.TextChanged += new System.EventHandler(this.txtrecherche_TextChanged);
            this.txtrecherche.Enter += new System.EventHandler(this.txtrecherche_Enter);
            this.txtrecherche.Leave += new System.EventHandler(this.txtrecherche_Leave);
            // 
            // btndeleteanimal
            // 
            this.btndeleteanimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btndeleteanimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(195)))), ((int)(((byte)(158)))));
            this.btndeleteanimal.FlatAppearance.BorderSize = 0;
            this.btndeleteanimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeleteanimal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteanimal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndeleteanimal.Image = global::application_adoption.Properties.Resources.icon_disk_disk_icon_disk_line_icon_dvd_icon_icon_1320073118181264386_48;
            this.btndeleteanimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeleteanimal.Location = new System.Drawing.Point(14, 627);
            this.btndeleteanimal.Name = "btndeleteanimal";
            this.btndeleteanimal.Size = new System.Drawing.Size(202, 48);
            this.btndeleteanimal.TabIndex = 18;
            this.btndeleteanimal.Text = "Supprimer";
            this.btndeleteanimal.UseVisualStyleBackColor = false;
            this.btndeleteanimal.Click += new System.EventHandler(this.btndeleteanimal_Click);
            // 
            // btnmodanimal
            // 
            this.btnmodanimal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnmodanimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(195)))), ((int)(((byte)(158)))));
            this.btnmodanimal.FlatAppearance.BorderSize = 0;
            this.btnmodanimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodanimal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodanimal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmodanimal.Image = global::application_adoption.Properties.Resources.post_share_update_icon_1320184669913435325_48;
            this.btnmodanimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodanimal.Location = new System.Drawing.Point(14, 312);
            this.btnmodanimal.Name = "btnmodanimal";
            this.btnmodanimal.Size = new System.Drawing.Size(202, 48);
            this.btnmodanimal.TabIndex = 11;
            this.btnmodanimal.Text = "Modifier";
            this.btnmodanimal.UseVisualStyleBackColor = false;
            this.btnmodanimal.Click += new System.EventHandler(this.btnmodanimal_Click);
            // 
            // btnaddanimal
            // 
            this.btnaddanimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(195)))), ((int)(((byte)(158)))));
            this.btnaddanimal.FlatAppearance.BorderSize = 0;
            this.btnaddanimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddanimal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddanimal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnaddanimal.Image = global::application_adoption.Properties.Resources.upload_icon_upload_line_icon_icon_1320073121636456908_48;
            this.btnaddanimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddanimal.Location = new System.Drawing.Point(14, 25);
            this.btnaddanimal.Name = "btnaddanimal";
            this.btnaddanimal.Size = new System.Drawing.Size(202, 48);
            this.btnaddanimal.TabIndex = 10;
            this.btnaddanimal.Text = "Ajouter";
            this.btnaddanimal.UseVisualStyleBackColor = false;
            this.btnaddanimal.Click += new System.EventHandler(this.btnaddclient_Click);
            // 
            // imageee
            // 
            this.imageee.Image = global::application_adoption.Properties.Resources.BIENVENUE_CHEZ_ANICARE;
            this.imageee.Location = new System.Drawing.Point(782, -101);
            this.imageee.Name = "imageee";
            this.imageee.Size = new System.Drawing.Size(307, 289);
            this.imageee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageee.TabIndex = 14;
            this.imageee.TabStop = false;
            this.imageee.Click += new System.EventHandler(this.txtsearch_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::application_adoption.Properties.Resources.BIENVENUE_CHEZ_ANICARE;
            this.pictureBox2.Location = new System.Drawing.Point(506, -103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(307, 297);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // Animal_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.btndeleteanimal);
            this.Controls.Add(this.comboanimal);
            this.Controls.Add(this.gridanimal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnmodanimal);
            this.Controls.Add(this.btnaddanimal);
            this.Controls.Add(this.imageee);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Animal_list";
            this.Size = new System.Drawing.Size(1137, 720);
            this.Load += new System.EventHandler(this.Animal_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridanimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboanimal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnmodanimal;
        private System.Windows.Forms.Button btnaddanimal;
        private System.Windows.Forms.PictureBox imageee;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btndeleteanimal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.DataGridView gridanimal;
    }
}

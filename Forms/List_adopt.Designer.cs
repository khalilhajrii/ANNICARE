
namespace application_adoption.Forms
{
    partial class List_adopt
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
            this.gridadopt = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedeb = new System.Windows.Forms.DateTimePicker();
            this.debdate = new System.Windows.Forms.Label();
            this.datefin = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnaddadopt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridadopt)).BeginInit();
            this.SuspendLayout();
            // 
            // gridadopt
            // 
            this.gridadopt.AllowUserToAddRows = false;
            this.gridadopt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridadopt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridadopt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridadopt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridadopt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridadopt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridadopt.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridadopt.EnableHeadersVisualStyles = false;
            this.gridadopt.Location = new System.Drawing.Point(247, 108);
            this.gridadopt.Name = "gridadopt";
            this.gridadopt.RowHeadersVisible = false;
            this.gridadopt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridadopt.Size = new System.Drawing.Size(878, 536);
            this.gridadopt.TabIndex = 17;
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
            this.Column2.HeaderText = "Id adopt";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date d\'adoption";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Id client";
            this.Column4.Name = "Column4";
            // 
            // datedeb
            // 
            this.datedeb.Location = new System.Drawing.Point(488, 64);
            this.datedeb.Name = "datedeb";
            this.datedeb.Size = new System.Drawing.Size(200, 20);
            this.datedeb.TabIndex = 20;
            // 
            // debdate
            // 
            this.debdate.AutoSize = true;
            this.debdate.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.debdate.Location = new System.Drawing.Point(488, 36);
            this.debdate.Name = "debdate";
            this.debdate.Size = new System.Drawing.Size(99, 23);
            this.debdate.TabIndex = 21;
            this.debdate.Text = "Date debut";
            // 
            // datefin
            // 
            this.datefin.AutoSize = true;
            this.datefin.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datefin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.datefin.Location = new System.Drawing.Point(741, 36);
            this.datefin.Name = "datefin";
            this.datefin.Size = new System.Drawing.Size(73, 23);
            this.datefin.TabIndex = 23;
            this.datefin.Text = "Date fin";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(741, 64);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // btnsearch
            // 
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Image = global::application_adoption.Properties.Resources.search;
            this.btnsearch.Location = new System.Drawing.Point(989, 47);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(49, 47);
            this.btnsearch.TabIndex = 24;
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // btnaddadopt
            // 
            this.btnaddadopt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(195)))), ((int)(((byte)(158)))));
            this.btnaddadopt.FlatAppearance.BorderSize = 0;
            this.btnaddadopt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddadopt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddadopt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnaddadopt.Image = global::application_adoption.Properties.Resources.upload_icon_upload_line_icon_icon_1320073121636456908_48;
            this.btnaddadopt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddadopt.Location = new System.Drawing.Point(17, 83);
            this.btnaddadopt.Name = "btnaddadopt";
            this.btnaddadopt.Size = new System.Drawing.Size(202, 48);
            this.btnaddadopt.TabIndex = 10;
            this.btnaddadopt.Text = "Ajouter";
            this.btnaddadopt.UseVisualStyleBackColor = false;
            this.btnaddadopt.Click += new System.EventHandler(this.btnaddadopt_Click);
            // 
            // List_adopt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.datefin);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.debdate);
            this.Controls.Add(this.datedeb);
            this.Controls.Add(this.gridadopt);
            this.Controls.Add(this.btnaddadopt);
            this.Name = "List_adopt";
            this.Size = new System.Drawing.Size(1137, 720);
            this.Load += new System.EventHandler(this.List_adopt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridadopt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridadopt;
        private System.Windows.Forms.Button btnaddadopt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DateTimePicker datedeb;
        private System.Windows.Forms.Label debdate;
        private System.Windows.Forms.Label datefin;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnsearch;
    }
}

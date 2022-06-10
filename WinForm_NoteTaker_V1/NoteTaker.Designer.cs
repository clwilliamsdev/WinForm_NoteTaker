
namespace WinForm_NoteTaker_V1
{
    partial class NoteTaker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NoteDgv = new System.Windows.Forms.DataGridView();
            this.Noteslbl = new System.Windows.Forms.Label();
            this.NewBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NoteDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // NoteDgv
            // 
            this.NoteDgv.AllowUserToAddRows = false;
            this.NoteDgv.AllowUserToDeleteRows = false;
            this.NoteDgv.AllowUserToResizeColumns = false;
            this.NoteDgv.AllowUserToResizeRows = false;
            this.NoteDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NoteDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.NoteDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NoteDgv.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NoteDgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.NoteDgv.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NoteDgv.Location = new System.Drawing.Point(34, 98);
            this.NoteDgv.MultiSelect = false;
            this.NoteDgv.Name = "NoteDgv";
            this.NoteDgv.ReadOnly = true;
            this.NoteDgv.RowHeadersVisible = false;
            this.NoteDgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteDgv.ShowCellErrors = false;
            this.NoteDgv.ShowCellToolTips = false;
            this.NoteDgv.ShowEditingIcon = false;
            this.NoteDgv.ShowRowErrors = false;
            this.NoteDgv.Size = new System.Drawing.Size(156, 254);
            this.NoteDgv.TabIndex = 0;
            this.NoteDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NoteDgv_CellClick);
            
            // 
            // Noteslbl
            // 
            this.Noteslbl.AutoSize = true;
            this.Noteslbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noteslbl.Location = new System.Drawing.Point(30, 46);
            this.Noteslbl.Name = "Noteslbl";
            this.Noteslbl.Size = new System.Drawing.Size(62, 23);
            this.Noteslbl.TabIndex = 1;
            this.Noteslbl.Text = "Notes";
            // 
            // NewBtn
            // 
            this.NewBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NewBtn.FlatAppearance.BorderSize = 2;
            this.NewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBtn.Location = new System.Drawing.Point(225, 98);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(75, 33);
            this.NewBtn.TabIndex = 2;
            this.NewBtn.Text = "New";
            this.NewBtn.UseVisualStyleBackColor = false;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ViewBtn.FlatAppearance.BorderSize = 2;
            this.ViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBtn.Location = new System.Drawing.Point(225, 171);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(75, 33);
            this.ViewBtn.TabIndex = 3;
            this.ViewBtn.Text = "View";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeleteBtn.FlatAppearance.BorderSize = 2;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(225, 244);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 33);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ExitBtn.FlatAppearance.BorderSize = 2;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(278, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(48, 33);
            this.ExitBtn.TabIndex = 22;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SettingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SettingsBtn.FlatAppearance.BorderSize = 2;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.Location = new System.Drawing.Point(225, 317);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(75, 33);
            this.SettingsBtn.TabIndex = 23;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.UseVisualStyleBackColor = false;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // NoteTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.ControlBox = false;
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.Noteslbl);
            this.Controls.Add(this.NoteDgv);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "NoteTaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.NoteTaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NoteDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NoteDgv;
        private System.Windows.Forms.Label Noteslbl;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button SettingsBtn;
    }
}


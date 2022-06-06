
namespace WinForm_NoteTaker_V1
{
    partial class NewNote
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
            this.NewDetailEntry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewTitleEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewDetailEntry
            // 
            this.NewDetailEntry.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.NewDetailEntry.Location = new System.Drawing.Point(69, 165);
            this.NewDetailEntry.Multiline = true;
            this.NewDetailEntry.Name = "NewDetailEntry";
            this.NewDetailEntry.Size = new System.Drawing.Size(201, 200);
            this.NewDetailEntry.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(69, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Details";
            // 
            // NewTitleEntry
            // 
            this.NewTitleEntry.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.NewTitleEntry.Location = new System.Drawing.Point(69, 72);
            this.NewTitleEntry.Name = "NewTitleEntry";
            this.NewTitleEntry.Size = new System.Drawing.Size(201, 22);
            this.NewTitleEntry.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(69, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Title";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SaveBtn.FlatAppearance.BorderSize = 2;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(69, 392);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 33);
            this.SaveBtn.TabIndex = 14;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BackBtn.FlatAppearance.BorderSize = 2;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(197, 392);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 33);
            this.BackBtn.TabIndex = 20;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
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
            this.ExitBtn.TabIndex = 21;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // NewNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.NewDetailEntry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewTitleEntry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "NewNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NewDetailEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewTitleEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}
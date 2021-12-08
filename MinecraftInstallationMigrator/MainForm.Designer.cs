
namespace MinecraftÍnstallationMigrator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backup_start = new System.Windows.Forms.Button();
            this.backup_richtextbox = new System.Windows.Forms.RichTextBox();
            this.info_button = new System.Windows.Forms.Button();
            this.backup_cancel = new System.Windows.Forms.Button();
            this.backup_progressbar = new AltoControls.AltoPB();
            this.mc_path_auto = new AltoControls.AltoButton();
            this.mc_path_textbox = new AltoControls.AltoTextBox();
            this.mc_path_open = new AltoControls.AltoButton();
            this.backup_open = new AltoControls.AltoButton();
            this.backup_textbox = new AltoControls.AltoTextBox();
            this.SuspendLayout();
            // 
            // backup_start
            // 
            this.backup_start.Location = new System.Drawing.Point(12, 93);
            this.backup_start.Name = "backup_start";
            this.backup_start.Size = new System.Drawing.Size(75, 23);
            this.backup_start.TabIndex = 6;
            this.backup_start.Text = "Backup!";
            this.backup_start.UseVisualStyleBackColor = true;
            this.backup_start.Click += new System.EventHandler(this.backup_start_Click);
            // 
            // backup_richtextbox
            // 
            this.backup_richtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backup_richtextbox.Location = new System.Drawing.Point(12, 160);
            this.backup_richtextbox.Name = "backup_richtextbox";
            this.backup_richtextbox.Size = new System.Drawing.Size(481, 57);
            this.backup_richtextbox.TabIndex = 8;
            this.backup_richtextbox.Text = "";
            // 
            // info_button
            // 
            this.info_button.Location = new System.Drawing.Point(435, 223);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(58, 23);
            this.info_button.TabIndex = 9;
            this.info_button.Text = "Info";
            this.info_button.UseVisualStyleBackColor = true;
            // 
            // backup_cancel
            // 
            this.backup_cancel.Location = new System.Drawing.Point(93, 93);
            this.backup_cancel.Name = "backup_cancel";
            this.backup_cancel.Size = new System.Drawing.Size(75, 23);
            this.backup_cancel.TabIndex = 10;
            this.backup_cancel.Text = "Cancel";
            this.backup_cancel.UseVisualStyleBackColor = true;
            this.backup_cancel.Click += new System.EventHandler(this.backup_cancel_Click);
            // 
            // backup_progressbar
            // 
            this.backup_progressbar.Location = new System.Drawing.Point(12, 134);
            this.backup_progressbar.MaxValue = 100;
            this.backup_progressbar.MinValue = 0;
            this.backup_progressbar.Name = "backup_progressbar";
            this.backup_progressbar.ProgressColor = System.Drawing.Color.LightGreen;
            this.backup_progressbar.Size = new System.Drawing.Size(481, 20);
            this.backup_progressbar.TabIndex = 11;
            this.backup_progressbar.Text = "altopb1";
            this.backup_progressbar.Value = 0;
            // 
            // mc_path_auto
            // 
            this.mc_path_auto.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mc_path_auto.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mc_path_auto.BackColor = System.Drawing.Color.Transparent;
            this.mc_path_auto.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mc_path_auto.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mc_path_auto.ForeColor = System.Drawing.Color.Black;
            this.mc_path_auto.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mc_path_auto.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mc_path_auto.Location = new System.Drawing.Point(416, 12);
            this.mc_path_auto.Name = "mc_path_auto";
            this.mc_path_auto.Radius = 5;
            this.mc_path_auto.Size = new System.Drawing.Size(77, 33);
            this.mc_path_auto.Stroke = false;
            this.mc_path_auto.StrokeColor = System.Drawing.Color.Black;
            this.mc_path_auto.TabIndex = 12;
            this.mc_path_auto.Text = "Auto Get";
            this.mc_path_auto.Transparency = false;
            this.mc_path_auto.Click += new System.EventHandler(this.mc_path_auto_Click);
            // 
            // mc_path_textbox
            // 
            this.mc_path_textbox.BackColor = System.Drawing.Color.Transparent;
            this.mc_path_textbox.Br = System.Drawing.Color.White;
            this.mc_path_textbox.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mc_path_textbox.ForeColor = System.Drawing.Color.Black;
            this.mc_path_textbox.Location = new System.Drawing.Point(12, 11);
            this.mc_path_textbox.Name = "mc_path_textbox";
            this.mc_path_textbox.Size = new System.Drawing.Size(359, 33);
            this.mc_path_textbox.TabIndex = 13;
            this.mc_path_textbox.Text = "Mc Path Here";
            // 
            // mc_path_open
            // 
            this.mc_path_open.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mc_path_open.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mc_path_open.BackColor = System.Drawing.Color.Transparent;
            this.mc_path_open.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mc_path_open.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mc_path_open.ForeColor = System.Drawing.Color.Black;
            this.mc_path_open.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mc_path_open.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mc_path_open.Location = new System.Drawing.Point(376, 11);
            this.mc_path_open.Name = "mc_path_open";
            this.mc_path_open.Radius = 5;
            this.mc_path_open.Size = new System.Drawing.Size(34, 34);
            this.mc_path_open.Stroke = false;
            this.mc_path_open.StrokeColor = System.Drawing.Color.Gray;
            this.mc_path_open.TabIndex = 14;
            this.mc_path_open.Text = "...";
            this.mc_path_open.Transparency = false;
            this.mc_path_open.Click += new System.EventHandler(this.mc_path_open_Click);
            // 
            // backup_open
            // 
            this.backup_open.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backup_open.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backup_open.BackColor = System.Drawing.Color.Transparent;
            this.backup_open.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.backup_open.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backup_open.ForeColor = System.Drawing.Color.Black;
            this.backup_open.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backup_open.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backup_open.Location = new System.Drawing.Point(376, 51);
            this.backup_open.Name = "backup_open";
            this.backup_open.Radius = 5;
            this.backup_open.Size = new System.Drawing.Size(34, 34);
            this.backup_open.Stroke = false;
            this.backup_open.StrokeColor = System.Drawing.Color.Gray;
            this.backup_open.TabIndex = 15;
            this.backup_open.Text = "...";
            this.backup_open.Transparency = false;
            this.backup_open.Click += new System.EventHandler(this.backup_open_Click);
            // 
            // backup_textbox
            // 
            this.backup_textbox.BackColor = System.Drawing.Color.Transparent;
            this.backup_textbox.Br = System.Drawing.Color.White;
            this.backup_textbox.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backup_textbox.ForeColor = System.Drawing.Color.Black;
            this.backup_textbox.Location = new System.Drawing.Point(12, 54);
            this.backup_textbox.Name = "backup_textbox";
            this.backup_textbox.Size = new System.Drawing.Size(359, 33);
            this.backup_textbox.TabIndex = 16;
            this.backup_textbox.Text = "Backup Path Here";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(505, 244);
            this.Controls.Add(this.backup_textbox);
            this.Controls.Add(this.backup_open);
            this.Controls.Add(this.mc_path_open);
            this.Controls.Add(this.mc_path_textbox);
            this.Controls.Add(this.mc_path_auto);
            this.Controls.Add(this.backup_progressbar);
            this.Controls.Add(this.backup_cancel);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.backup_richtextbox);
            this.Controls.Add(this.backup_start);
            this.Name = "MainForm";
            this.Text = "MinecraftInstallationMigrator";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backup_start;
        private System.Windows.Forms.RichTextBox backup_richtextbox;
        private System.Windows.Forms.Button info_button;
        private System.Windows.Forms.Button backup_cancel;
        private AltoControls.AltoPB backup_progressbar;
        private AltoControls.AltoButton mc_path_auto;
        private AltoControls.AltoTextBox mc_path_textbox;
        private AltoControls.AltoButton mc_path_open;
        private AltoControls.AltoButton backup_open;
        private AltoControls.AltoTextBox backup_textbox;
    }
}



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
            this.mc_path_textbox = new System.Windows.Forms.TextBox();
            this.backup_textbox = new System.Windows.Forms.TextBox();
            this.mc_Path_open = new System.Windows.Forms.Button();
            this.mc_path_auto = new System.Windows.Forms.Button();
            this.backup_open = new System.Windows.Forms.Button();
            this.backup_start = new System.Windows.Forms.Button();
            this.backup_progressbar = new System.Windows.Forms.ProgressBar();
            this.backup_richtextbox = new System.Windows.Forms.RichTextBox();
            this.info_button = new System.Windows.Forms.Button();
            this.backup_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mc_path_textbox
            // 
            this.mc_path_textbox.Location = new System.Drawing.Point(12, 12);
            this.mc_path_textbox.Name = "mc_path_textbox";
            this.mc_path_textbox.Size = new System.Drawing.Size(244, 23);
            this.mc_path_textbox.TabIndex = 1;
            this.mc_path_textbox.Text = "Minecraft Path Here";
            // 
            // backup_textbox
            // 
            this.backup_textbox.Location = new System.Drawing.Point(12, 53);
            this.backup_textbox.Name = "backup_textbox";
            this.backup_textbox.Size = new System.Drawing.Size(244, 23);
            this.backup_textbox.TabIndex = 2;
            this.backup_textbox.Text = "Backup Path Here";
            // 
            // mc_Path_open
            // 
            this.mc_Path_open.Location = new System.Drawing.Point(282, 12);
            this.mc_Path_open.Name = "mc_Path_open";
            this.mc_Path_open.Size = new System.Drawing.Size(27, 23);
            this.mc_Path_open.TabIndex = 3;
            this.mc_Path_open.Text = "...";
            this.mc_Path_open.UseVisualStyleBackColor = true;
            this.mc_Path_open.Click += new System.EventHandler(this.mc_Path_open_Click);
            // 
            // mc_path_auto
            // 
            this.mc_path_auto.Location = new System.Drawing.Point(315, 12);
            this.mc_path_auto.Name = "mc_path_auto";
            this.mc_path_auto.Size = new System.Drawing.Size(75, 23);
            this.mc_path_auto.TabIndex = 4;
            this.mc_path_auto.Text = "Auto get";
            this.mc_path_auto.UseVisualStyleBackColor = true;
            this.mc_path_auto.Click += new System.EventHandler(this.mc_path_auto_Click);
            // 
            // backup_open
            // 
            this.backup_open.Location = new System.Drawing.Point(282, 53);
            this.backup_open.Name = "backup_open";
            this.backup_open.Size = new System.Drawing.Size(27, 23);
            this.backup_open.TabIndex = 5;
            this.backup_open.Text = "...";
            this.backup_open.UseVisualStyleBackColor = true;
            this.backup_open.Click += new System.EventHandler(this.backup_open_Click);
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
            // backup_progressbar
            // 
            this.backup_progressbar.Location = new System.Drawing.Point(12, 131);
            this.backup_progressbar.Name = "backup_progressbar";
            this.backup_progressbar.Size = new System.Drawing.Size(481, 23);
            this.backup_progressbar.TabIndex = 7;
            // 
            // backup_richtextbox
            // 
            this.backup_richtextbox.Location = new System.Drawing.Point(12, 160);
            this.backup_richtextbox.Name = "backup_richtextbox";
            this.backup_richtextbox.Size = new System.Drawing.Size(481, 57);
            this.backup_richtextbox.TabIndex = 8;
            this.backup_richtextbox.Text = "";
            // 
            // info_button
            // 
            this.info_button.Location = new System.Drawing.Point(435, 11);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 244);
            this.Controls.Add(this.backup_cancel);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.backup_richtextbox);
            this.Controls.Add(this.backup_progressbar);
            this.Controls.Add(this.backup_start);
            this.Controls.Add(this.backup_open);
            this.Controls.Add(this.mc_path_auto);
            this.Controls.Add(this.mc_Path_open);
            this.Controls.Add(this.backup_textbox);
            this.Controls.Add(this.mc_path_textbox);
            this.Name = "MainForm";
            this.Text = "MinecraftInstallationMigrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox mc_path_textbox;
        private System.Windows.Forms.TextBox backup_textbox;
        private System.Windows.Forms.Button mc_Path_open;
        private System.Windows.Forms.Button mc_path_auto;
        private System.Windows.Forms.Button backup_open;
        private System.Windows.Forms.Button backup_start;
        private System.Windows.Forms.ProgressBar backup_progressbar;
        private System.Windows.Forms.RichTextBox backup_richtextbox;
        private System.Windows.Forms.Button info_button;
        private System.Windows.Forms.Button backup_cancel;
    }
}


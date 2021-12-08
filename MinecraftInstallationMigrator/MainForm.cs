using IOExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopyManager = IOExtensions.FileTransferManager;

namespace MinecraftÍnstallationMigrator
{
    public partial class MainForm : Form
    {
        string MinecraftPath = "";
        CancellationTokenSource cancelSource;



        public MainForm()
        {
            InitializeComponent();
        }

        private void mc_path_open_Click(object sender, EventArgs e)
        {
            var mcopendialog = new FolderBrowserDialog();

            var result = mcopendialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(mcopendialog.SelectedPath))
            {
                MinecraftPath = mcopendialog.SelectedPath;
                mc_path_textbox.Text = MinecraftPath;

            }
        }

        private void mc_path_auto_Click(object sender, EventArgs e)
        {
            MinecraftPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft";
            mc_path_textbox.Text = MinecraftPath;
        }

        private void backup_open_Click(object sender, EventArgs e)
        {
            var backupopendialog = new FolderBrowserDialog();

            var result = backupopendialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(backupopendialog.SelectedPath))
            {
                MinecraftPath = backupopendialog.SelectedPath;
                backup_textbox.Text = MinecraftPath;

            }
        }

        private async void backup_start_Click(object sender, EventArgs e)
        {
            cancelSource = new CancellationTokenSource();

            if (Directory.Exists(mc_path_textbox.Text) && Directory.Exists(backup_textbox.Text))
            {
                TransferResult transferResult = await CopyManager.CopyWithProgressAsync(mc_path_textbox.Text, backup_textbox.Text, HandleProgress, true, cancelSource.Token);

                switch(transferResult)
                {
                    case TransferResult.Success:
                        MessageBox.Show("Hippy jeah war erfolgreich!");
                        break;

                    case TransferResult.Failed:
                        MessageBox.Show("Shit war nicht erfolgreich :-(");
                        break;

                    case TransferResult.Cancelled:
                        MessageBox.Show("CANCELED!!!!!!");
                        break;

                }
            }
            else
            {
                MessageBox.Show("You entered an invalid Path");

            }
        }

        private void HandleProgress(IOExtensions.TransferProgress progress)
        {
            if (InvokeRequired)
            {
                Invoke(new HandleProgressDelegate(HandleProgressShower), progress);
                return;
            }
            
        }

        private delegate void HandleProgressDelegate(IOExtensions.TransferProgress progress);

        private void HandleProgressShower(IOExtensions.TransferProgress progress)
        {
            backup_progressbar.Value = (int)progress.Percentage;
            backup_richtextbox.AppendText(progress.ProcessedFile);
            backup_richtextbox.ScrollToCaret();
        }

        private void backup_cancel_Click(object sender, EventArgs e)
        {
            cancelSource.Cancel();
        }

    }
}

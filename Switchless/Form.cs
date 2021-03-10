using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Switchless
{
    public partial class Switchless : Form
    {
        // Application variables.
        private bool mouseDown;
        private Point lastAppLocation;

        // osu! variables.
        private bool osuSelected = false;
        private string osuPath = null;
        private string osuServer = null;

        public Switchless()
        {
            InitializeComponent();
        }

        // Select osu! button.
        private void selectOsuClick(object sender, EventArgs e)
        {
            // Get file
            OpenFileDialog fdlg = new OpenFileDialog
            {
                Title = "Select your osu!.exe file",
                InitialDirectory = @"c:\%appdata%",
                FileName = "osu!*",
                Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            // Set path and set as selected.
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                // Check if file is osu!.exe
                if (fdlg.FileName.EndsWith("osu!.exe"))
                {
                    this.osuPath = fdlg.FileName;
                    this.osuSelected = true;
                } else
                {
                    this.osuPath = null;
                    this.osuSelected = false;
                    // TODO: Display message saying invalid osu! EXE.
                    MessageBox.Show(
                        "Invalid file selected!\nPlease select your osu!.exe file.",
                        "Switchless",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                }
                Console.WriteLine("DEBUG: Selected osu! path: " + this.osuPath);
            }

        }

        // Start osu! button.
        private void startOsuClick(object sender, EventArgs e)
        {
            // No osu!.exe file is selected.
            if (!this.osuSelected)
            {
                // Display message if osu!.exe file isn't selected.
                MessageBox.Show(
                        "No osu!.exe file was selected.",
                        "Switchless",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
            }
            // osu!.exe is selected but no osu! server is provided.
            else if (this.osuSelected && string.IsNullOrEmpty(this.osuServer))
            {
                // Display message if no osu! server is provided.
                MessageBox.Show(
                        "You must provide a valid osu! server domain to connect to!",
                        "Switchless",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
            }
            // If osu! is selected start osu!.
            else
            {
                // Prepare osu!.exe with arguments.
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    CreateNoWindow = false,
                    UseShellExecute = false,
                    FileName = this.osuPath,
                    Arguments = "-devserver " + this.osuServer
                };

                // Try starting osu!.
                try
                {
                    Process.Start(startInfo);
                }
                catch
                {
                    // Display message if osu! fails to start.
                    MessageBox.Show(
                        "Fatal error when starting osu!.\nContact the developer.",
                        "Switchless",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
                finally
                {
                    Console.WriteLine("DEBUG: Started osu! at: " + this.osuPath + " on: " + this.osuServer + ".");
                }
            }
        }

        // osu! server text box.
        private void osuServerText(object sender, EventArgs e)
        {
            // Set this.osuServer on TextChange.
            TextBox currentText = sender as TextBox;
            if (currentText != null)
            {
                this.osuServer = currentText.Text;
            }
        }

        // Custom exit button.
        private void exitAppClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Custom application movement.
        private void switchlessMouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.lastAppLocation = e.Location;
        }

        private void switchlessMouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }

        private void switchlessMouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown)
            {
                this.Location = new Point((this.Location.X - this.lastAppLocation.X) + e.X, (this.Location.Y - this.lastAppLocation.Y) + e.Y);
                this.Update();
            }
        }
    }
}


namespace Switchless
{
    partial class Switchless
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Switchless));
            this.startOsu = new System.Windows.Forms.Button();
            this.selectOsu = new System.Windows.Forms.Button();
            this.osuServerTextBox = new System.Windows.Forms.TextBox();
            this.exitApp = new System.Windows.Forms.Button();
            this.switchlessLabel = new System.Windows.Forms.Label();
            this.osuServerLabel = new System.Windows.Forms.Label();
            this.cuttingEdgeNoteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startOsu
            // 
            this.startOsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.startOsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startOsu.FlatAppearance.BorderSize = 0;
            this.startOsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startOsu.Font = new System.Drawing.Font("Whitney Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startOsu.ForeColor = System.Drawing.Color.Transparent;
            this.startOsu.Location = new System.Drawing.Point(442, 298);
            this.startOsu.Name = "startOsu";
            this.startOsu.Size = new System.Drawing.Size(174, 86);
            this.startOsu.TabIndex = 0;
            this.startOsu.TabStop = false;
            this.startOsu.Text = "Start osu!";
            this.startOsu.UseVisualStyleBackColor = false;
            this.startOsu.Click += new System.EventHandler(this.startOsuClick);
            // 
            // selectOsu
            // 
            this.selectOsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.selectOsu.FlatAppearance.BorderSize = 0;
            this.selectOsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectOsu.Font = new System.Drawing.Font("Whitney Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectOsu.ForeColor = System.Drawing.Color.Transparent;
            this.selectOsu.Location = new System.Drawing.Point(172, 298);
            this.selectOsu.Name = "selectOsu";
            this.selectOsu.Size = new System.Drawing.Size(174, 86);
            this.selectOsu.TabIndex = 1;
            this.selectOsu.Text = "Select osu!.exe";
            this.selectOsu.UseVisualStyleBackColor = false;
            this.selectOsu.Click += new System.EventHandler(this.selectOsuClick);
            // 
            // osuServerTextBox
            // 
            this.osuServerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.osuServerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.osuServerTextBox.Font = new System.Drawing.Font("Whitney", 15F);
            this.osuServerTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.osuServerTextBox.Location = new System.Drawing.Point(195, 237);
            this.osuServerTextBox.Name = "osuServerTextBox";
            this.osuServerTextBox.Size = new System.Drawing.Size(400, 29);
            this.osuServerTextBox.TabIndex = 2;
            this.osuServerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.osuServerTextBox.TextChanged += new System.EventHandler(this.osuServerText);
            // 
            // exitApp
            // 
            this.exitApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.exitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitApp.FlatAppearance.BorderSize = 0;
            this.exitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitApp.Font = new System.Drawing.Font("Whitney Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitApp.ForeColor = System.Drawing.Color.White;
            this.exitApp.Location = new System.Drawing.Point(752, 0);
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(49, 39);
            this.exitApp.TabIndex = 4;
            this.exitApp.TabStop = false;
            this.exitApp.Text = "X";
            this.exitApp.UseVisualStyleBackColor = false;
            this.exitApp.Click += new System.EventHandler(this.exitAppClick);
            // 
            // switchlessLabel
            // 
            this.switchlessLabel.AutoSize = true;
            this.switchlessLabel.Font = new System.Drawing.Font("Whitney BookSC", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchlessLabel.ForeColor = System.Drawing.Color.White;
            this.switchlessLabel.Location = new System.Drawing.Point(281, 146);
            this.switchlessLabel.Name = "switchlessLabel";
            this.switchlessLabel.Size = new System.Drawing.Size(227, 48);
            this.switchlessLabel.TabIndex = 5;
            this.switchlessLabel.Text = "Switchless";
            // 
            // osuServerLabel
            // 
            this.osuServerLabel.AutoSize = true;
            this.osuServerLabel.Font = new System.Drawing.Font("Whitney", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osuServerLabel.ForeColor = System.Drawing.Color.White;
            this.osuServerLabel.Location = new System.Drawing.Point(323, 215);
            this.osuServerLabel.Name = "osuServerLabel";
            this.osuServerLabel.Size = new System.Drawing.Size(149, 20);
            this.osuServerLabel.TabIndex = 6;
            this.osuServerLabel.Text = "osu! server domain:";
            this.osuServerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Switchless
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cuttingEdgeNoteLabel);
            this.Controls.Add(this.osuServerLabel);
            this.Controls.Add(this.switchlessLabel);
            this.Controls.Add(this.exitApp);
            this.Controls.Add(this.osuServerTextBox);
            this.Controls.Add(this.selectOsu);
            this.Controls.Add(this.startOsu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Switchless";
            this.Text = "Switchless";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.switchlessMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.switchlessMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.switchlessMouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startOsu;
        private System.Windows.Forms.Button selectOsu;
        private System.Windows.Forms.TextBox osuServerTextBox;
        private System.Windows.Forms.Button exitApp;
        private System.Windows.Forms.Label switchlessLabel;
        private System.Windows.Forms.Label osuServerLabel;
        private System.Windows.Forms.Label cuttingEdgeNoteLabel;
    }
}


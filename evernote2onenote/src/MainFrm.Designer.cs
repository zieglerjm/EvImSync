// Evernote2Onenote - imports Evernote notes to Onenote
// Copyright (C) 2014 - Stefan Kueng

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace Evernote2Onenote
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoText1 = new System.Windows.Forms.Label();
            this.infoText2 = new System.Windows.Forms.Label();
            this.progressIndicator = new System.Windows.Forms.ProgressBar();
            this.infoText0 = new System.Windows.Forms.Label();
            this.homeLink = new System.Windows.Forms.LinkLabel();
            this.versionLabel = new System.Windows.Forms.Label();
            this.btnENEXImport = new System.Windows.Forms.Button();
            this.importDatePicker = new System.Windows.Forms.DateTimePicker();
            this.datelabel = new System.Windows.Forms.Label();
            this.modifiedDateCheckbox = new System.Windows.Forms.CheckBox();
            this.btnENEXImportFolder = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(388, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // infoText1
            // 
            this.infoText1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.infoText1.AutoSize = true;
            this.infoText1.Location = new System.Drawing.Point(9, 96);
            this.infoText1.Name = "infoText1";
            this.infoText1.Size = new System.Drawing.Size(0, 13);
            this.infoText1.TabIndex = 3;
            // 
            // infoText2
            // 
            this.infoText2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoText2.AutoSize = true;
            this.infoText2.Location = new System.Drawing.Point(9, 114);
            this.infoText2.Name = "infoText2";
            this.infoText2.Size = new System.Drawing.Size(10, 13);
            this.infoText2.TabIndex = 4;
            this.infoText2.Text = " ";
            // 
            // progressIndicator
            // 
            this.progressIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressIndicator.Location = new System.Drawing.Point(8, 132);
            this.progressIndicator.Name = "progressIndicator";
            this.progressIndicator.Size = new System.Drawing.Size(371, 14);
            this.progressIndicator.TabIndex = 5;
            // 
            // infoText0
            // 
            this.infoText0.AutoSize = true;
            this.infoText0.Location = new System.Drawing.Point(12, 56);
            this.infoText0.Name = "infoText0";
            this.infoText0.Size = new System.Drawing.Size(10, 13);
            this.infoText0.TabIndex = 6;
            this.infoText0.Text = " ";
            // 
            // homeLink
            // 
            this.homeLink.AutoSize = true;
            this.homeLink.Location = new System.Drawing.Point(12, 21);
            this.homeLink.Name = "homeLink";
            this.homeLink.Size = new System.Drawing.Size(59, 13);
            this.homeLink.TabIndex = 8;
            this.homeLink.TabStop = true;
            this.homeLink.Text = "Homepage";
            this.homeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homeLink_LinkClicked);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(77, 21);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(45, 13);
            this.versionLabel.TabIndex = 9;
            this.versionLabel.Text = "Version:";
            // 
            // btnENEXImport
            // 
            this.btnENEXImport.Location = new System.Drawing.Point(166, 66);
            this.btnENEXImport.Name = "btnENEXImport";
            this.btnENEXImport.Size = new System.Drawing.Size(213, 23);
            this.btnENEXImport.TabIndex = 13;
            this.btnENEXImport.Text = "Import ENEX File";
            this.btnENEXImport.UseVisualStyleBackColor = true;
            this.btnENEXImport.Click += new System.EventHandler(this.btnENEXImport_Click);
            // 
            // importDatePicker
            // 
            this.importDatePicker.Location = new System.Drawing.Point(166, 42);
            this.importDatePicker.MinDate = new System.DateTime(1799, 1, 1, 0, 0, 0, 0);
            this.importDatePicker.Name = "importDatePicker";
            this.importDatePicker.Size = new System.Drawing.Size(215, 20);
            this.importDatePicker.TabIndex = 14;
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Location = new System.Drawing.Point(9, 44);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(145, 13);
            this.datelabel.TabIndex = 15;
            this.datelabel.Text = "only import notes newer than:";
            // 
            // modifiedDateCheckbox
            // 
            this.modifiedDateCheckbox.AutoSize = true;
            this.modifiedDateCheckbox.Checked = true;
            this.modifiedDateCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.modifiedDateCheckbox.Location = new System.Drawing.Point(12, 66);
            this.modifiedDateCheckbox.Name = "modifiedDateCheckbox";
            this.modifiedDateCheckbox.Size = new System.Drawing.Size(147, 30);
            this.modifiedDateCheckbox.TabIndex = 16;
            this.modifiedDateCheckbox.Text = "Use Modified-Date of\r\nnotes as Date in Onenote";
            this.modifiedDateCheckbox.UseVisualStyleBackColor = true;
            // 
            // btnENEXImportFolder
            // 
            this.btnENEXImportFolder.Location = new System.Drawing.Point(166, 91);
            this.btnENEXImportFolder.Name = "btnENEXImportFolder";
            this.btnENEXImportFolder.Size = new System.Drawing.Size(213, 23);
            this.btnENEXImportFolder.TabIndex = 17;
            this.btnENEXImportFolder.Text = "Import ENEX Files from Folder";
            this.btnENEXImportFolder.UseVisualStyleBackColor = true;
            this.btnENEXImportFolder.Click += new System.EventHandler(this.btnENEXImportFolder_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 150);
            this.Controls.Add(this.btnENEXImportFolder);
            this.Controls.Add(this.modifiedDateCheckbox);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.importDatePicker);
            this.Controls.Add(this.btnENEXImport);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.homeLink);
            this.Controls.Add(this.infoText0);
            this.Controls.Add(this.progressIndicator);
            this.Controls.Add(this.infoText2);
            this.Controls.Add(this.infoText1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(632, 206);
            this.Name = "MainFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Evernote2Onenote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label infoText1;
        private System.Windows.Forms.Label infoText2;
        private System.Windows.Forms.ProgressBar progressIndicator;
        private System.Windows.Forms.Label infoText0;
        private System.Windows.Forms.LinkLabel homeLink;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Button btnENEXImport;
        private System.Windows.Forms.DateTimePicker importDatePicker;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.CheckBox modifiedDateCheckbox;
        private System.Windows.Forms.Button btnENEXImportFolder;
    }
}


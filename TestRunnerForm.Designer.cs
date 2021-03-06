﻿using System.Drawing;

namespace TestRunner
{
    partial class TestRunnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestRunnerForm));
            this.treeView_Tests = new System.Windows.Forms.TreeView();
            this.btn_Run = new System.Windows.Forms.Button();
            this.lblParameters = new System.Windows.Forms.Label();
            this.textBoxParameters = new System.Windows.Forms.TextBox();
            this.FileUploadDailog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.attachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attachToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropdownTestClass = new System.Windows.Forms.ComboBox();
            this.lblTestClass = new System.Windows.Forms.Label();
            this.btnRunAllTests = new System.Windows.Forms.Button();
            this.progressBarTests = new TestRunner.CustomProgressBar();
            this.txtBoxOutput = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView_Tests
            // 
            this.treeView_Tests.Location = new System.Drawing.Point(36, 136);
            this.treeView_Tests.Name = "treeView_Tests";
            this.treeView_Tests.Size = new System.Drawing.Size(447, 477);
            this.treeView_Tests.TabIndex = 0;
            this.treeView_Tests.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Tests_AfterSelect);
            // 
            // btn_Run
            // 
            this.btn_Run.Enabled = false;
            this.btn_Run.Location = new System.Drawing.Point(500, 86);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(152, 44);
            this.btn_Run.TabIndex = 1;
            this.btn_Run.Text = "Run Test";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // lblParameters
            // 
            this.lblParameters.AutoSize = true;
            this.lblParameters.Location = new System.Drawing.Point(33, 633);
            this.lblParameters.Name = "lblParameters";
            this.lblParameters.Size = new System.Drawing.Size(81, 17);
            this.lblParameters.TabIndex = 5;
            this.lblParameters.Text = "Parameters";
            this.lblParameters.Visible = false;
            // 
            // textBoxParameters
            // 
            this.textBoxParameters.Location = new System.Drawing.Point(36, 669);
            this.textBoxParameters.Name = "textBoxParameters";
            this.textBoxParameters.Size = new System.Drawing.Size(447, 22);
            this.textBoxParameters.TabIndex = 6;
            this.textBoxParameters.Visible = false;
            // 
            // FileUploadDailog
            // 
            this.FileUploadDailog.FileName = "FileUploadDialog";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attachToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1806, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // attachToolStripMenuItem
            // 
            this.attachToolStripMenuItem.Name = "attachToolStripMenuItem";
            this.attachToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attachToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // attachToolStripMenuItem1
            // 
            this.attachToolStripMenuItem1.Name = "attachToolStripMenuItem1";
            this.attachToolStripMenuItem1.Size = new System.Drawing.Size(135, 26);
            this.attachToolStripMenuItem1.Text = "Attach";
            this.attachToolStripMenuItem1.Click += new System.EventHandler(this.attachToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.howToUseToolStripMenuItem.Text = "How to use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // dropdownTestClass
            // 
            this.dropdownTestClass.FormattingEnabled = true;
            this.dropdownTestClass.Location = new System.Drawing.Point(138, 86);
            this.dropdownTestClass.Name = "dropdownTestClass";
            this.dropdownTestClass.Size = new System.Drawing.Size(345, 24);
            this.dropdownTestClass.TabIndex = 10;
            this.dropdownTestClass.Visible = false;
            this.dropdownTestClass.SelectedIndexChanged += new System.EventHandler(this.dropdownTestClass_SelectedIndexChanged);
            // 
            // lblTestClass
            // 
            this.lblTestClass.AutoSize = true;
            this.lblTestClass.Location = new System.Drawing.Point(33, 86);
            this.lblTestClass.Name = "lblTestClass";
            this.lblTestClass.Size = new System.Drawing.Size(74, 17);
            this.lblTestClass.TabIndex = 11;
            this.lblTestClass.Text = "Test Class";
            this.lblTestClass.Visible = false;
            // 
            // btnRunAllTests
            // 
            this.btnRunAllTests.Enabled = false;
            this.btnRunAllTests.Location = new System.Drawing.Point(670, 86);
            this.btnRunAllTests.Name = "btnRunAllTests";
            this.btnRunAllTests.Size = new System.Drawing.Size(152, 44);
            this.btnRunAllTests.TabIndex = 12;
            this.btnRunAllTests.Text = "Run All Tests";
            this.btnRunAllTests.UseVisualStyleBackColor = true;
            this.btnRunAllTests.Click += new System.EventHandler(this.btnRunAllTests_Click);
            // 
            // progressBarTests
            // 
            this.progressBarTests.BackColor = System.Drawing.Color.Green;
            this.progressBarTests.ForeColor = System.Drawing.Color.Green;
            this.progressBarTests.Location = new System.Drawing.Point(500, 669);
            this.progressBarTests.Name = "progressBarTests";
            this.progressBarTests.Size = new System.Drawing.Size(1277, 23);
            this.progressBarTests.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarTests.TabIndex = 8;
            this.progressBarTests.Visible = false;
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOutput.Location = new System.Drawing.Point(489, 136);
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.Size = new System.Drawing.Size(1277, 477);
            this.txtBoxOutput.TabIndex = 13;
            this.txtBoxOutput.Text = "";
            this.txtBoxOutput.WordWrap = false;
            // 
            // TestRunnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 795);
            this.ControlBox = false;
            this.Controls.Add(this.txtBoxOutput);
            this.Controls.Add(this.btnRunAllTests);
            this.Controls.Add(this.lblTestClass);
            this.Controls.Add(this.dropdownTestClass);
            this.Controls.Add(this.progressBarTests);
            this.Controls.Add(this.textBoxParameters);
            this.Controls.Add(this.lblParameters);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.treeView_Tests);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TestRunnerForm";
            this.Text = "TestRunner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.TreeView treeView_Tests;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Label lblParameters;
        private System.Windows.Forms.TextBox textBoxParameters;
        private System.Windows.Forms.OpenFileDialog FileUploadDailog;
        private CustomProgressBar progressBarTests;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem attachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attachToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ComboBox dropdownTestClass;
        private System.Windows.Forms.Label lblTestClass;
        private System.Windows.Forms.Button btnRunAllTests;
        private System.Windows.Forms.RichTextBox txtBoxOutput;
    }
}


﻿using System.Windows.Forms;
namespace Trampolin.FilterSportTecResults
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.btnReadInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputFileName = new System.Windows.Forms.TextBox();
            this.tabViewInput = new System.Windows.Forms.TabPage();
            this.gridInput = new System.Windows.Forms.DataGridView();
            this.tabFilter = new System.Windows.Forms.TabPage();
            this.txtPlaceFilter = new System.Windows.Forms.TextBox();
            this.cmbClassFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateOutputGtPlace = new System.Windows.Forms.Button();
            this.btnCreateOutputLtePlace = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TabPage();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.tabReportTemplate = new System.Windows.Forms.TabPage();
            this.txtTemplate = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnMakePdf = new System.Windows.Forms.Button();
            this.txtPdfPrg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabs.SuspendLayout();
            this.tabInput.SuspendLayout();
            this.tabViewInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInput)).BeginInit();
            this.tabFilter.SuspendLayout();
            this.Output.SuspendLayout();
            this.tabReportTemplate.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabInput);
            this.tabs.Controls.Add(this.tabViewInput);
            this.tabs.Controls.Add(this.tabFilter);
            this.tabs.Controls.Add(this.Output);
            this.tabs.Controls.Add(this.tabReportTemplate);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1231, 483);
            this.tabs.TabIndex = 0;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // tabInput
            // 
            this.tabInput.Controls.Add(this.btnReadInput);
            this.tabInput.Controls.Add(this.label1);
            this.tabInput.Controls.Add(this.txtInputFileName);
            this.tabInput.Location = new System.Drawing.Point(4, 25);
            this.tabInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabInput.Size = new System.Drawing.Size(1203, 866);
            this.tabInput.TabIndex = 0;
            this.tabInput.Text = "Eingabe";
            this.tabInput.UseVisualStyleBackColor = true;
            // 
            // btnReadInput
            // 
            this.btnReadInput.Location = new System.Drawing.Point(48, 150);
            this.btnReadInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReadInput.Name = "btnReadInput";
            this.btnReadInput.Size = new System.Drawing.Size(704, 117);
            this.btnReadInput.TabIndex = 2;
            this.btnReadInput.Text = "Datei einlesen";
            this.btnReadInput.UseVisualStyleBackColor = true;
            this.btnReadInput.Click += new System.EventHandler(this.btnReadInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Csv Datei Name";
            // 
            // txtInputFileName
            // 
            this.txtInputFileName.AllowDrop = true;
            this.txtInputFileName.Location = new System.Drawing.Point(48, 56);
            this.txtInputFileName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInputFileName.Name = "txtInputFileName";
            this.txtInputFileName.Size = new System.Drawing.Size(703, 28);
            this.txtInputFileName.TabIndex = 0;
            this.txtInputFileName.Text = "\"C:\\Users\\Ralf\\Downloads\\24. Barmstedt Cup 2025(3).csv\"";
            this.txtInputFileName.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtInputFileName_DragDrop);
            this.txtInputFileName.DragOver += new System.Windows.Forms.DragEventHandler(this.txtInputFileName_DragOver);
            // 
            // tabViewInput
            // 
            this.tabViewInput.Controls.Add(this.gridInput);
            this.tabViewInput.Location = new System.Drawing.Point(4, 25);
            this.tabViewInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabViewInput.Name = "tabViewInput";
            this.tabViewInput.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabViewInput.Size = new System.Drawing.Size(1203, 866);
            this.tabViewInput.TabIndex = 1;
            this.tabViewInput.Text = "Tabelle";
            this.tabViewInput.UseVisualStyleBackColor = true;
            // 
            // gridInput
            // 
            this.gridInput.AllowUserToAddRows = false;
            this.gridInput.AllowUserToDeleteRows = false;
            this.gridInput.AllowUserToResizeRows = false;
            this.gridInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridInput.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridInput.Location = new System.Drawing.Point(4, 3);
            this.gridInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridInput.Name = "gridInput";
            this.gridInput.ReadOnly = true;
            this.gridInput.RowHeadersWidth = 51;
            this.gridInput.Size = new System.Drawing.Size(1195, 860);
            this.gridInput.TabIndex = 0;
            this.gridInput.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridInput_ColumnHeaderMouseClick);
            // 
            // tabFilter
            // 
            this.tabFilter.Controls.Add(this.txtPlaceFilter);
            this.tabFilter.Controls.Add(this.cmbClassFilter);
            this.tabFilter.Controls.Add(this.label3);
            this.tabFilter.Controls.Add(this.label2);
            this.tabFilter.Controls.Add(this.btnCreateOutputGtPlace);
            this.tabFilter.Controls.Add(this.btnCreateOutputLtePlace);
            this.tabFilter.Location = new System.Drawing.Point(4, 25);
            this.tabFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabFilter.Name = "tabFilter";
            this.tabFilter.Size = new System.Drawing.Size(1203, 866);
            this.tabFilter.TabIndex = 2;
            this.tabFilter.Text = "Filter";
            this.tabFilter.UseVisualStyleBackColor = true;
            // 
            // txtPlaceFilter
            // 
            this.txtPlaceFilter.Location = new System.Drawing.Point(188, 209);
            this.txtPlaceFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlaceFilter.Name = "txtPlaceFilter";
            this.txtPlaceFilter.Size = new System.Drawing.Size(272, 28);
            this.txtPlaceFilter.TabIndex = 3;
            this.txtPlaceFilter.Text = "8";
            // 
            // cmbClassFilter
            // 
            this.cmbClassFilter.FormattingEnabled = true;
            this.cmbClassFilter.Location = new System.Drawing.Point(188, 87);
            this.cmbClassFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbClassFilter.Name = "cmbClassFilter";
            this.cmbClassFilter.Size = new System.Drawing.Size(594, 30);
            this.cmbClassFilter.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Platzierung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Klasse";
            // 
            // btnCreateOutputGtPlace
            // 
            this.btnCreateOutputGtPlace.Location = new System.Drawing.Point(80, 248);
            this.btnCreateOutputGtPlace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateOutputGtPlace.Name = "btnCreateOutputGtPlace";
            this.btnCreateOutputGtPlace.Size = new System.Drawing.Size(702, 45);
            this.btnCreateOutputGtPlace.TabIndex = 0;
            this.btnCreateOutputGtPlace.Text = "Filter: \"Qualification\", Platz > Platzierung";
            this.btnCreateOutputGtPlace.UseVisualStyleBackColor = true;
            this.btnCreateOutputGtPlace.Click += new System.EventHandler(this.btnCreateOutputGtPlace_Click);
            // 
            // btnCreateOutputLtePlace
            // 
            this.btnCreateOutputLtePlace.Location = new System.Drawing.Point(80, 362);
            this.btnCreateOutputLtePlace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateOutputLtePlace.Name = "btnCreateOutputLtePlace";
            this.btnCreateOutputLtePlace.Size = new System.Drawing.Size(702, 45);
            this.btnCreateOutputLtePlace.TabIndex = 0;
            this.btnCreateOutputLtePlace.Text = "Filter: \"Final\"";
            this.btnCreateOutputLtePlace.UseVisualStyleBackColor = true;
            this.btnCreateOutputLtePlace.Click += new System.EventHandler(this.btnCreateOutputLtePlace_Click);
            // 
            // Output
            // 
            this.Output.Controls.Add(this.txtOutput);
            this.Output.Location = new System.Drawing.Point(4, 25);
            this.Output.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(1203, 866);
            this.Output.TabIndex = 3;
            this.Output.Text = "Ausgabe";
            this.Output.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.AcceptsReturn = true;
            this.txtOutput.AcceptsTab = true;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(1203, 866);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.WordWrap = false;
            // 
            // tabReportTemplate
            // 
            this.tabReportTemplate.Controls.Add(this.txtTemplate);
            this.tabReportTemplate.Location = new System.Drawing.Point(4, 25);
            this.tabReportTemplate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabReportTemplate.Name = "tabReportTemplate";
            this.tabReportTemplate.Size = new System.Drawing.Size(1203, 866);
            this.tabReportTemplate.TabIndex = 4;
            this.tabReportTemplate.Text = "Urkundenvorlage";
            this.tabReportTemplate.UseVisualStyleBackColor = true;
            // 
            // txtTemplate
            // 
            this.txtTemplate.AcceptsReturn = true;
            this.txtTemplate.AcceptsTab = true;
            this.txtTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTemplate.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemplate.Location = new System.Drawing.Point(0, 0);
            this.txtTemplate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTemplate.Multiline = true;
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTemplate.Size = new System.Drawing.Size(1203, 866);
            this.txtTemplate.TabIndex = 1;
            this.txtTemplate.Text = resources.GetString("txtTemplate.Text");
            this.txtTemplate.WordWrap = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnMakePdf);
            this.tabPage2.Controls.Add(this.txtPdfPrg);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1223, 448);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Urkunden erzeugen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnMakePdf
            // 
            this.btnMakePdf.Location = new System.Drawing.Point(45, 183);
            this.btnMakePdf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMakePdf.Name = "btnMakePdf";
            this.btnMakePdf.Size = new System.Drawing.Size(702, 45);
            this.btnMakePdf.TabIndex = 4;
            this.btnMakePdf.Text = "PDF erzeugen";
            this.btnMakePdf.UseVisualStyleBackColor = true;
            this.btnMakePdf.Click += new System.EventHandler(this.btnMakePdf_Click);
            // 
            // txtPdfPrg
            // 
            this.txtPdfPrg.AllowDrop = true;
            this.txtPdfPrg.Location = new System.Drawing.Point(45, 109);
            this.txtPdfPrg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPdfPrg.Name = "txtPdfPrg";
            this.txtPdfPrg.Size = new System.Drawing.Size(703, 28);
            this.txtPdfPrg.TabIndex = 3;
            this.txtPdfPrg.Text = "pdflatex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Programm zum Erzeugen der PDF-Datei";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 483);
            this.Controls.Add(this.tabs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Filter SportsTec Result";
            this.tabs.ResumeLayout(false);
            this.tabInput.ResumeLayout(false);
            this.tabInput.PerformLayout();
            this.tabViewInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridInput)).EndInit();
            this.tabFilter.ResumeLayout(false);
            this.tabFilter.PerformLayout();
            this.Output.ResumeLayout(false);
            this.Output.PerformLayout();
            this.tabReportTemplate.ResumeLayout(false);
            this.tabReportTemplate.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabs;
        private TabPage tabInput;
        private TabPage tabViewInput;
        private TabPage tabFilter;
        private TabPage Output;
        private Button btnReadInput;
        private Label label1;
        private TextBox txtInputFileName;
        private DataGridView gridInput;
        private ComboBox cmbClassFilter;
        private Label label2;
        private Button btnCreateOutputLtePlace;
        private TextBox txtPlaceFilter;
        private Label label3;
        private Button btnCreateOutputGtPlace;
        private TextBox txtOutput;
        private TabPage tabReportTemplate;
        private TabPage tabPage2;
        private Button btnMakePdf;
        private TextBox txtPdfPrg;
        private Label label4;
        private TextBox txtTemplate;
    }
}

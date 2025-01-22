using System.Windows.Forms;
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
            this.tabs.SuspendLayout();
            this.tabInput.SuspendLayout();
            this.tabViewInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInput)).BeginInit();
            this.tabFilter.SuspendLayout();
            this.Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabInput);
            this.tabs.Controls.Add(this.tabViewInput);
            this.tabs.Controls.Add(this.tabFilter);
            this.tabs.Controls.Add(this.Output);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(888, 468);
            this.tabs.TabIndex = 0;
            // 
            // tabInput
            // 
            this.tabInput.Controls.Add(this.btnReadInput);
            this.tabInput.Controls.Add(this.label1);
            this.tabInput.Controls.Add(this.txtInputFileName);
            this.tabInput.Location = new System.Drawing.Point(4, 25);
            this.tabInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabInput.Size = new System.Drawing.Size(880, 439);
            this.tabInput.TabIndex = 0;
            this.tabInput.Text = "Eingabe";
            this.tabInput.UseVisualStyleBackColor = true;
            // 
            // btnReadInput
            // 
            this.btnReadInput.Location = new System.Drawing.Point(38, 109);
            this.btnReadInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadInput.Name = "btnReadInput";
            this.btnReadInput.Size = new System.Drawing.Size(563, 85);
            this.btnReadInput.TabIndex = 2;
            this.btnReadInput.Text = "Datei einlesen";
            this.btnReadInput.UseVisualStyleBackColor = true;
            this.btnReadInput.Click += new System.EventHandler(this.btnReadInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Csv Datei Name";
            // 
            // txtInputFileName
            // 
            this.txtInputFileName.AllowDrop = true;
            this.txtInputFileName.Location = new System.Drawing.Point(38, 41);
            this.txtInputFileName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputFileName.Name = "txtInputFileName";
            this.txtInputFileName.Size = new System.Drawing.Size(563, 22);
            this.txtInputFileName.TabIndex = 0;
            this.txtInputFileName.Text = "\"C:\\Users\\Ralf\\Downloads\\Wölfe Cup 2024(2).csv\"";
            this.txtInputFileName.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtInputFileName_DragDrop);
            this.txtInputFileName.DragOver += new System.Windows.Forms.DragEventHandler(this.txtInputFileName_DragOver);
            // 
            // tabViewInput
            // 
            this.tabViewInput.Controls.Add(this.gridInput);
            this.tabViewInput.Location = new System.Drawing.Point(4, 25);
            this.tabViewInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabViewInput.Name = "tabViewInput";
            this.tabViewInput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabViewInput.Size = new System.Drawing.Size(880, 439);
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
            this.gridInput.Location = new System.Drawing.Point(3, 2);
            this.gridInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridInput.Name = "gridInput";
            this.gridInput.ReadOnly = true;
            this.gridInput.RowHeadersWidth = 51;
            this.gridInput.Size = new System.Drawing.Size(874, 435);
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
            this.tabFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFilter.Name = "tabFilter";
            this.tabFilter.Size = new System.Drawing.Size(880, 439);
            this.tabFilter.TabIndex = 2;
            this.tabFilter.Text = "Filter";
            this.tabFilter.UseVisualStyleBackColor = true;
            // 
            // txtPlaceFilter
            // 
            this.txtPlaceFilter.Location = new System.Drawing.Point(150, 110);
            this.txtPlaceFilter.Name = "txtPlaceFilter";
            this.txtPlaceFilter.Size = new System.Drawing.Size(218, 22);
            this.txtPlaceFilter.TabIndex = 3;
            this.txtPlaceFilter.Text = "8";
            // 
            // cmbClassFilter
            // 
            this.cmbClassFilter.FormattingEnabled = true;
            this.cmbClassFilter.Location = new System.Drawing.Point(150, 63);
            this.cmbClassFilter.Name = "cmbClassFilter";
            this.cmbClassFilter.Size = new System.Drawing.Size(218, 24);
            this.cmbClassFilter.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Platzierung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Klasse";
            // 
            // btnCreateOutputGtPlace
            // 
            this.btnCreateOutputGtPlace.Location = new System.Drawing.Point(64, 220);
            this.btnCreateOutputGtPlace.Name = "btnCreateOutputGtPlace";
            this.btnCreateOutputGtPlace.Size = new System.Drawing.Size(562, 33);
            this.btnCreateOutputGtPlace.TabIndex = 0;
            this.btnCreateOutputGtPlace.Text = "Filter > Platzierung";
            this.btnCreateOutputGtPlace.UseVisualStyleBackColor = true;
            this.btnCreateOutputGtPlace.Click += new System.EventHandler(this.btnCreateOutputGtPlace_Click);
            // 
            // btnCreateOutputLtePlace
            // 
            this.btnCreateOutputLtePlace.Location = new System.Drawing.Point(64, 172);
            this.btnCreateOutputLtePlace.Name = "btnCreateOutputLtePlace";
            this.btnCreateOutputLtePlace.Size = new System.Drawing.Size(562, 33);
            this.btnCreateOutputLtePlace.TabIndex = 0;
            this.btnCreateOutputLtePlace.Text = "Filter <= Platzierung";
            this.btnCreateOutputLtePlace.UseVisualStyleBackColor = true;
            this.btnCreateOutputLtePlace.Click += new System.EventHandler(this.btnCreateOutputLtePlace_Click);
            // 
            // Output
            // 
            this.Output.Controls.Add(this.txtOutput);
            this.Output.Location = new System.Drawing.Point(4, 25);
            this.Output.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(880, 439);
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
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(880, 439);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 468);
            this.Controls.Add(this.tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}

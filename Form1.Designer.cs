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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.btnReadInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputFileName = new System.Windows.Forms.TextBox();
            this.tabViewInput = new System.Windows.Forms.TabPage();
            this.gridInput = new System.Windows.Forms.DataGridView();
            this.tabFilter = new System.Windows.Forms.TabPage();
            this.Output = new System.Windows.Forms.TabPage();
            this.tabs.SuspendLayout();
            this.tabInput.SuspendLayout();
            this.tabViewInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInput)).BeginInit();
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
            this.tabInput.Size = new System.Drawing.Size(792, 331);
            this.tabInput.TabIndex = 0;
            this.tabInput.Text = "Input";
            this.tabInput.UseVisualStyleBackColor = true;
            // 
            // btnReadInput
            // 
            this.btnReadInput.Location = new System.Drawing.Point(45, 139);
            this.btnReadInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadInput.Name = "btnReadInput";
            this.btnReadInput.Size = new System.Drawing.Size(556, 23);
            this.btnReadInput.TabIndex = 2;
            this.btnReadInput.Text = "Read";
            this.btnReadInput.UseVisualStyleBackColor = true;
            this.btnReadInput.Click += new System.EventHandler(this.btnReadInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Csv File Name";
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
            this.tabViewInput.Text = "View Input";
            this.tabViewInput.UseVisualStyleBackColor = true;
            // 
            // gridInput
            // 
            this.gridInput.AllowUserToAddRows = false;
            this.gridInput.AllowUserToDeleteRows = false;
            this.gridInput.AllowUserToResizeRows = false;
            this.gridInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.tabFilter.Location = new System.Drawing.Point(4, 25);
            this.tabFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFilter.Name = "tabFilter";
            this.tabFilter.Size = new System.Drawing.Size(792, 331);
            this.tabFilter.TabIndex = 2;
            this.tabFilter.Text = "Filter";
            this.tabFilter.UseVisualStyleBackColor = true;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(4, 25);
            this.Output.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(880, 439);
            this.Output.TabIndex = 3;
            this.Output.Text = "Output";
            this.Output.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 468);
            this.Controls.Add(this.tabs);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Filter SportsTec Result";
            this.tabs.ResumeLayout(false);
            this.tabInput.ResumeLayout(false);
            this.tabInput.PerformLayout();
            this.tabViewInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridInput)).EndInit();
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
    }
}

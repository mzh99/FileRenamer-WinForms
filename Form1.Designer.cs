namespace FileRenamer {
   partial class Main_Frm {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.components = new System.ComponentModel.Container();
         System.Windows.Forms.ColumnHeader columnHeader1;
         System.Windows.Forms.ColumnHeader columnHeader2;
         this.StatusBar = new System.Windows.Forms.StatusStrip();
         this.Lbl1 = new System.Windows.Forms.ToolStripStatusLabel();
         this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
         this.StartFolder_TB = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.FolderBrowse_Btn = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.Filter_TB = new System.Windows.Forms.TextBox();
         this.ProcessSubs_CB = new System.Windows.Forms.CheckBox();
         this.label3 = new System.Windows.Forms.Label();
         this.RenameCode_TB = new System.Windows.Forms.TextBox();
         this.Process_Btn = new System.Windows.Forms.Button();
         this.label4 = new System.Windows.Forms.Label();
         this.OutputType_CB = new System.Windows.Forms.ComboBox();
         this.Preview_Pnl = new System.Windows.Forms.Panel();
         this.Output_LV = new System.Windows.Forms.ListView();
         this.Folder_Dlg = new System.Windows.Forms.FolderBrowserDialog();
         this.Save_Dlg = new System.Windows.Forms.SaveFileDialog();
         this.OutputOpts_Pnl = new System.Windows.Forms.Panel();
         this.OutputBrowse_Btn = new System.Windows.Forms.Button();
         this.label5 = new System.Windows.Forms.Label();
         this.OutputName_TB = new System.Windows.Forms.TextBox();
         this.Cancel_CB = new System.Windows.Forms.CheckBox();
         this.ExcludeSys_CB = new System.Windows.Forms.CheckBox();
         this.ExcludeHidden_CB = new System.Windows.Forms.CheckBox();
         this.label6 = new System.Windows.Forms.Label();
         this.SampleCode_CB = new System.Windows.Forms.ComboBox();
         this.CodeSelect_Btn = new System.Windows.Forms.Button();
         columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.StatusBar.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
         this.Preview_Pnl.SuspendLayout();
         this.OutputOpts_Pnl.SuspendLayout();
         this.SuspendLayout();
         // 
         // columnHeader1
         // 
         columnHeader1.Text = "Current File Name";
         columnHeader1.Width = 550;
         // 
         // columnHeader2
         // 
         columnHeader2.Text = "New Name:";
         columnHeader2.Width = 150;
         // 
         // StatusBar
         // 
         this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lbl1});
         this.StatusBar.Location = new System.Drawing.Point(0, 839);
         this.StatusBar.Name = "StatusBar";
         this.StatusBar.Size = new System.Drawing.Size(984, 22);
         this.StatusBar.SizingGrip = false;
         this.StatusBar.TabIndex = 0;
         // 
         // Lbl1
         // 
         this.Lbl1.AutoSize = false;
         this.Lbl1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
         this.Lbl1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
         this.Lbl1.Name = "Lbl1";
         this.Lbl1.Size = new System.Drawing.Size(969, 17);
         this.Lbl1.Spring = true;
         this.Lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // StartFolder_TB
         // 
         this.StartFolder_TB.Location = new System.Drawing.Point(170, 19);
         this.StartFolder_TB.MaxLength = 250;
         this.StartFolder_TB.Name = "StartFolder_TB";
         this.StartFolder_TB.Size = new System.Drawing.Size(544, 24);
         this.StartFolder_TB.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 22);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(152, 18);
         this.label1.TabIndex = 2;
         this.label1.Text = "Starting Folder Name:";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // FolderBrowse_Btn
         // 
         this.FolderBrowse_Btn.Location = new System.Drawing.Point(734, 15);
         this.FolderBrowse_Btn.Name = "FolderBrowse_Btn";
         this.FolderBrowse_Btn.Size = new System.Drawing.Size(93, 33);
         this.FolderBrowse_Btn.TabIndex = 3;
         this.FolderBrowse_Btn.Text = "Browse...";
         this.FolderBrowse_Btn.UseVisualStyleBackColor = true;
         this.FolderBrowse_Btn.Click += new System.EventHandler(this.FolderBrowse_Btn_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(69, 61);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(95, 18);
         this.label2.TabIndex = 5;
         this.label2.Text = "Search Filter:";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // Filter_TB
         // 
         this.Filter_TB.Location = new System.Drawing.Point(170, 58);
         this.Filter_TB.MaxLength = 64;
         this.Filter_TB.Name = "Filter_TB";
         this.Filter_TB.Size = new System.Drawing.Size(128, 24);
         this.Filter_TB.TabIndex = 9;
         this.Filter_TB.Text = "*.*";
         // 
         // ProcessSubs_CB
         // 
         this.ProcessSubs_CB.AutoSize = true;
         this.ProcessSubs_CB.Location = new System.Drawing.Point(332, 61);
         this.ProcessSubs_CB.Name = "ProcessSubs_CB";
         this.ProcessSubs_CB.Size = new System.Drawing.Size(158, 22);
         this.ProcessSubs_CB.TabIndex = 11;
         this.ProcessSubs_CB.Text = "Process Subfolders";
         this.ProcessSubs_CB.UseVisualStyleBackColor = true;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(31, 135);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(133, 18);
         this.label3.TabIndex = 8;
         this.label3.Text = "C# Rename Script:";
         this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // RenameCode_TB
         // 
         this.RenameCode_TB.AcceptsReturn = true;
         this.RenameCode_TB.Location = new System.Drawing.Point(170, 132);
         this.RenameCode_TB.MaxLength = 4096;
         this.RenameCode_TB.Multiline = true;
         this.RenameCode_TB.Name = "RenameCode_TB";
         this.RenameCode_TB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.RenameCode_TB.Size = new System.Drawing.Size(472, 125);
         this.RenameCode_TB.TabIndex = 21;
         this.RenameCode_TB.WordWrap = false;
         // 
         // Process_Btn
         // 
         this.Process_Btn.Location = new System.Drawing.Point(57, 319);
         this.Process_Btn.Name = "Process_Btn";
         this.Process_Btn.Size = new System.Drawing.Size(107, 33);
         this.Process_Btn.TabIndex = 61;
         this.Process_Btn.Text = "Process...";
         this.Process_Btn.UseVisualStyleBackColor = true;
         this.Process_Btn.Click += new System.EventHandler(this.Process_Btn_Click);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(666, 197);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(132, 18);
         this.label4.TabIndex = 64;
         this.label4.Text = "Output Results To:";
         this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // OutputType_CB
         // 
         this.OutputType_CB.FormattingEnabled = true;
         this.OutputType_CB.Items.AddRange(new object[] {
            "Preview to List",
            "Windows Batch File",
            "Unix/Linux Shell Script",
            "Tab-separated Text File",
            "Powershell Script"});
         this.OutputType_CB.Location = new System.Drawing.Point(669, 218);
         this.OutputType_CB.Name = "OutputType_CB";
         this.OutputType_CB.Size = new System.Drawing.Size(281, 26);
         this.OutputType_CB.TabIndex = 23;
         this.OutputType_CB.SelectedIndexChanged += new System.EventHandler(this.OutputType_CB_SelectedIndexChanged);
         // 
         // Preview_Pnl
         // 
         this.Preview_Pnl.Controls.Add(this.Output_LV);
         this.Preview_Pnl.Location = new System.Drawing.Point(170, 266);
         this.Preview_Pnl.Name = "Preview_Pnl";
         this.Preview_Pnl.Size = new System.Drawing.Size(780, 553);
         this.Preview_Pnl.TabIndex = 31;
         // 
         // Output_LV
         // 
         this.Output_LV.AutoArrange = false;
         this.Output_LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2});
         this.Output_LV.Dock = System.Windows.Forms.DockStyle.Fill;
         this.Output_LV.FullRowSelect = true;
         this.Output_LV.GridLines = true;
         this.Output_LV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
         this.Output_LV.Location = new System.Drawing.Point(0, 0);
         this.Output_LV.MultiSelect = false;
         this.Output_LV.Name = "Output_LV";
         this.Output_LV.Size = new System.Drawing.Size(780, 553);
         this.Output_LV.TabIndex = 42;
         this.Output_LV.UseCompatibleStateImageBehavior = false;
         this.Output_LV.View = System.Windows.Forms.View.Details;
         // 
         // Folder_Dlg
         // 
         this.Folder_Dlg.Description = "Select a starting folder";
         this.Folder_Dlg.RootFolder = System.Environment.SpecialFolder.MyComputer;
         this.Folder_Dlg.ShowNewFolderButton = false;
         // 
         // Save_Dlg
         // 
         this.Save_Dlg.AddExtension = false;
         this.Save_Dlg.RestoreDirectory = true;
         this.Save_Dlg.Title = "Ouput File Name:";
         // 
         // OutputOpts_Pnl
         // 
         this.OutputOpts_Pnl.Controls.Add(this.OutputBrowse_Btn);
         this.OutputOpts_Pnl.Controls.Add(this.label5);
         this.OutputOpts_Pnl.Controls.Add(this.OutputName_TB);
         this.OutputOpts_Pnl.Location = new System.Drawing.Point(170, 263);
         this.OutputOpts_Pnl.Name = "OutputOpts_Pnl";
         this.OutputOpts_Pnl.Size = new System.Drawing.Size(780, 58);
         this.OutputOpts_Pnl.TabIndex = 65;
         // 
         // OutputBrowse_Btn
         // 
         this.OutputBrowse_Btn.Location = new System.Drawing.Point(654, 14);
         this.OutputBrowse_Btn.Name = "OutputBrowse_Btn";
         this.OutputBrowse_Btn.Size = new System.Drawing.Size(93, 33);
         this.OutputBrowse_Btn.TabIndex = 65;
         this.OutputBrowse_Btn.Text = "Browse...";
         this.OutputBrowse_Btn.UseVisualStyleBackColor = true;
         this.OutputBrowse_Btn.Click += new System.EventHandler(this.OutputBrowse_Btn_Click);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(6, 18);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(123, 18);
         this.label5.TabIndex = 65;
         this.label5.Text = "Ouput File Name:";
         this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // OutputName_TB
         // 
         this.OutputName_TB.Location = new System.Drawing.Point(145, 18);
         this.OutputName_TB.MaxLength = 250;
         this.OutputName_TB.Name = "OutputName_TB";
         this.OutputName_TB.Size = new System.Drawing.Size(490, 24);
         this.OutputName_TB.TabIndex = 66;
         // 
         // Cancel_CB
         // 
         this.Cancel_CB.AutoSize = true;
         this.Cancel_CB.Location = new System.Drawing.Point(12, 370);
         this.Cancel_CB.Name = "Cancel_CB";
         this.Cancel_CB.Size = new System.Drawing.Size(152, 22);
         this.Cancel_CB.TabIndex = 65;
         this.Cancel_CB.Text = "Cancel Processing";
         this.Cancel_CB.UseVisualStyleBackColor = true;
         this.Cancel_CB.Visible = false;
         // 
         // ExcludeSys_CB
         // 
         this.ExcludeSys_CB.AutoSize = true;
         this.ExcludeSys_CB.Checked = true;
         this.ExcludeSys_CB.CheckState = System.Windows.Forms.CheckState.Checked;
         this.ExcludeSys_CB.Location = new System.Drawing.Point(669, 131);
         this.ExcludeSys_CB.Name = "ExcludeSys_CB";
         this.ExcludeSys_CB.Size = new System.Drawing.Size(176, 22);
         this.ExcludeSys_CB.TabIndex = 17;
         this.ExcludeSys_CB.Text = "Exclude System Files?";
         this.ExcludeSys_CB.UseVisualStyleBackColor = true;
         // 
         // ExcludeHidden_CB
         // 
         this.ExcludeHidden_CB.AutoSize = true;
         this.ExcludeHidden_CB.Checked = true;
         this.ExcludeHidden_CB.CheckState = System.Windows.Forms.CheckState.Checked;
         this.ExcludeHidden_CB.Location = new System.Drawing.Point(669, 159);
         this.ExcludeHidden_CB.Name = "ExcludeHidden_CB";
         this.ExcludeHidden_CB.Size = new System.Drawing.Size(172, 22);
         this.ExcludeHidden_CB.TabIndex = 19;
         this.ExcludeHidden_CB.Text = "Exclude Hidden Files?";
         this.ExcludeHidden_CB.UseVisualStyleBackColor = true;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(62, 97);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(102, 18);
         this.label6.TabIndex = 66;
         this.label6.Text = "Sample Code:";
         this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // SampleCode_CB
         // 
         this.SampleCode_CB.FormattingEnabled = true;
         this.SampleCode_CB.Items.AddRange(new object[] {
            "Lower case",
            "Upper case",
            "Letters only + renumbering + extension",
            "Extension change (dangerous)",
            "Remove extension (dangerous)",
            "Renumber and keep extension",
            "Prefix File with Creation Date",
            "Prefix File with Creation Date and Time"});
         this.SampleCode_CB.Location = new System.Drawing.Point(170, 94);
         this.SampleCode_CB.Name = "SampleCode_CB";
         this.SampleCode_CB.Size = new System.Drawing.Size(472, 26);
         this.SampleCode_CB.TabIndex = 15;
         // 
         // CodeSelect_Btn
         // 
         this.CodeSelect_Btn.Location = new System.Drawing.Point(669, 87);
         this.CodeSelect_Btn.Name = "CodeSelect_Btn";
         this.CodeSelect_Btn.Size = new System.Drawing.Size(93, 33);
         this.CodeSelect_Btn.TabIndex = 16;
         this.CodeSelect_Btn.Text = "Select";
         this.CodeSelect_Btn.UseVisualStyleBackColor = true;
         this.CodeSelect_Btn.Click += new System.EventHandler(this.CodeSelect_Btn_Click);
         // 
         // Main_Frm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(984, 861);
         this.Controls.Add(this.CodeSelect_Btn);
         this.Controls.Add(this.SampleCode_CB);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.ExcludeHidden_CB);
         this.Controls.Add(this.ExcludeSys_CB);
         this.Controls.Add(this.Cancel_CB);
         this.Controls.Add(this.OutputOpts_Pnl);
         this.Controls.Add(this.Preview_Pnl);
         this.Controls.Add(this.OutputType_CB);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.Process_Btn);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.RenameCode_TB);
         this.Controls.Add(this.ProcessSubs_CB);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.Filter_TB);
         this.Controls.Add(this.FolderBrowse_Btn);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.StartFolder_TB);
         this.Controls.Add(this.StatusBar);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "Main_Frm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "File Renamer";
         this.Load += new System.EventHandler(this.Main_Frm_Load);
         this.StatusBar.ResumeLayout(false);
         this.StatusBar.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
         this.Preview_Pnl.ResumeLayout(false);
         this.OutputOpts_Pnl.ResumeLayout(false);
         this.OutputOpts_Pnl.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.StatusStrip StatusBar;
      private System.Windows.Forms.ToolStripStatusLabel Lbl1;
      private System.Windows.Forms.BindingSource bindingSource1;
      private System.Windows.Forms.TextBox StartFolder_TB;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button FolderBrowse_Btn;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox Filter_TB;
      private System.Windows.Forms.CheckBox ProcessSubs_CB;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox RenameCode_TB;
      private System.Windows.Forms.Button Process_Btn;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.ComboBox OutputType_CB;
      private System.Windows.Forms.Panel Preview_Pnl;
      private System.Windows.Forms.ListView Output_LV;
      private System.Windows.Forms.FolderBrowserDialog Folder_Dlg;
      private System.Windows.Forms.SaveFileDialog Save_Dlg;
      private System.Windows.Forms.Panel OutputOpts_Pnl;
      private System.Windows.Forms.Button OutputBrowse_Btn;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox OutputName_TB;
      private System.Windows.Forms.CheckBox Cancel_CB;
      private System.Windows.Forms.CheckBox ExcludeSys_CB;
      private System.Windows.Forms.CheckBox ExcludeHidden_CB;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.ComboBox SampleCode_CB;
      private System.Windows.Forms.Button CodeSelect_Btn;
   }
}


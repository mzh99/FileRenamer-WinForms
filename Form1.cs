using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using OCSS.MHMassFileRenamer;

namespace FileRenamer {
   public partial class Main_Frm: Form {

      private MassFileRenamer mfr = null;

      // Keep these next two arrays in sync
      private readonly static string[] SAMPLE_DESCS = {
         "Lower case",
         "Upper case",
         "Letters only + renumbering + extension",
         "Extension change (use caution)",
         "Remove extension (use caution)",
         "Renumber + extension",
         "Creation Date Prefix",
         "Creation Date + Time Prefix"
      };
      private readonly static string[] SAMPLE_CODE = {
         "FileName.ToLower()",
         "FileName.ToUpper()",
         "Path.GetFileNameWithoutExtension(FileName).LetterOnly() + FileNum.ToString(\"D3\") + Path.GetExtension(FileName)",
         "Path.ChangeExtension(FileName, \".new\")",
         "Path.ChangeExtension(FileName, null)",
         "FileNum.ToString(\"D3\") + Path.GetExtension(FileName)",
         "CreationTime.ToString(\"yyyy-MM-dd_\") + FileName",
         "CreationTime.ToString(\"yyyy-MM-dd_HHmmss_\") + FileName"
      };
      // out-of-the-box rename formatters
      private static readonly IRenameFormatter[] formatters = { null, new RenameFormatterWinBatch(), new RenameFormatterUnixBatch(), new RenameFormatterTSV(), new RenameFormatterPS() };

      public Main_Frm() {
         InitializeComponent();
         SampleCode_CB.DataSource = SAMPLE_DESCS;
      }

      private void Main_Frm_Load(object sender, EventArgs e) {
         OutputType_CB.SelectedIndex = 0;    // default to preview (this will trigger SetupUI)
      }

      private void Process_Btn_Click(object sender, EventArgs e) {
         string outputFileName = null;
         if (DataInputIsValid()) {
            outputFileName = (OutputType_CB.SelectedIndex == 0) ? null : OutputName_TB.Text;
            Cancel_CB.Checked = false;
            Cancel_CB.Visible = true;
            mfr = new MassFileRenamer(StartFolder_TB.Text, Filter_TB.Text, ProcessSubs_CB.Checked, RenameCode_TB.Text, formatters[OutputType_CB.SelectedIndex], outputFileName, true, ExcludeSys_CB.Checked, ExcludeHidden_CB.Checked, 100);
            mfr.OnProcessingFolder += Mfr_OnProcessingFolder;
            var results = mfr.ProcessFiles();
            mfr.OnProcessingFolder -= Mfr_OnProcessingFolder;
            Cancel_CB.Visible = false;
            string msg = $"Done Processing. Files: {results.FileCount} Folders: {results.FolderCount} Errors: {results.ErrorCount}";
            Lbl1.Text = msg;
            if (OutputType_CB.SelectedIndex > 0)
               ShowInfoMsg(msg);
            if (OutputType_CB.SelectedIndex == 0)
               LoadItemsIntoListView(results.NameChanges);
            if (results.ErrorCount > 0) {
               var msgs = results.ErrorMessages;
               var maxErr = (results.ErrorCount > 5) ? 5 : results.ErrorCount;
               string firstFew = string.Empty;
               for (int z = 0; z < maxErr; z++) {
                  firstFew += msgs[z] + Environment.NewLine;
               }
               ShowErrMsg(firstFew);
            }
         }
      }

      private void Mfr_OnProcessingFolder(string folder, ref bool cancelFlag) {
         cancelFlag = Cancel_CB.Checked;
         Lbl1.Text = $"Files matched: {mfr.Results.FileCount}. Processing folder: {folder}";
         StatusBar.Refresh();
         StatusBar.Update();
         Application.DoEvents();
      }

      private void LoadItemsIntoListView(IEnumerable<OldAndNewNames> nameChanges) {
         Output_LV.Items.Clear();
         Output_LV.BeginUpdate();
         try {
            foreach (var item in nameChanges) {
               var lvi = new ListViewItem(item.CurrentName);
               lvi.SubItems.Add(Path.GetFileName(item.NewName));
               Output_LV.Items.Add(lvi);
            }
         }
         finally {
            Output_LV.EndUpdate();
         }
      }

      private bool DataInputIsValid() {
         if (Directory.Exists(StartFolder_TB.Text) == false) {
            ShowErrMsg("Starting folder is not valid.");
            return false;
         }
         if (string.IsNullOrWhiteSpace(Filter_TB.Text)) {
            ShowErrMsg("Filter may not be left blank. For all files, use *.*");
            return false;
         }
         if (string.IsNullOrWhiteSpace(RenameCode_TB.Text)) {
            ShowErrMsg("Rename code may not be left blank.");
            return false;
         }
         if (OutputType_CB.SelectedIndex >= 1 && OutputType_CB.SelectedIndex <= 4 && string.IsNullOrWhiteSpace(OutputName_TB.Text)) {
            ShowErrMsg("Please specify an output file name.");
            return false;
         }
         return true;
      }

      private void ShowErrMsg(string msg) {
         MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         this.DialogResult = DialogResult.None;
      }

      private void ShowInfoMsg(string msg) {
         MessageBox.Show(msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
         this.DialogResult = DialogResult.None;
      }

      private void FolderBrowse_Btn_Click(object sender, EventArgs e) {
         if (Folder_Dlg.ShowDialog() == DialogResult.OK) {
            StartFolder_TB.Text = Folder_Dlg.SelectedPath;
         }
      }

      private void OutputBrowse_Btn_Click(object sender, EventArgs e) {
         switch (OutputType_CB.SelectedIndex) {
            case 1:     //  Windows Batch
               Save_Dlg.Filter = "Windows Batch Files|*.bat";
               Save_Dlg.FilterIndex = 0;
               break;
            case 2:     //  Unix Batch
               Save_Dlg.Filter = "Shell script|*.sh";
               Save_Dlg.FilterIndex = 0;
               break;
            case 3:     //  TSV
               Save_Dlg.Filter = "Tab-Separated Data File|*.txt|Tab-Separated Data File|.dat|Tab-Separated Data File|*.tsv";
               Save_Dlg.FilterIndex = 0;
               break;
            case 4:     //  Powershell
               Save_Dlg.Filter = "Powershell Script|*.ps1";
               Save_Dlg.FilterIndex = 0;
               break;
            default:
               throw new ApplicationException("Browse should not be called when Selected Output Index is: " + OutputType_CB.SelectedIndex.ToString());
         }

         if (Save_Dlg.ShowDialog() == DialogResult.OK) {
            OutputName_TB.Text = Save_Dlg.FileName;
         }
      }

      private void OutputType_CB_SelectedIndexChanged(object sender, EventArgs e) {
         SetupUI();
      }

      private void SetupUI() {
         switch (OutputType_CB.SelectedIndex) {
            case 0:     // preview
               OutputOpts_Pnl.Visible = false;
               Preview_Pnl.Visible = true;
               break;
            default:
               OutputOpts_Pnl.Visible = true;
               Preview_Pnl.Visible = false;
               break;
         }
      }

      private void CodeSelect_Btn_Click(object sender, EventArgs e) {
         RenameCode_TB.Text = (SampleCode_CB.SelectedIndex < 0) ? string.Empty : SAMPLE_CODE[SampleCode_CB.SelectedIndex];
      }
   }

}

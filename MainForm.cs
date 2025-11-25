

namespace GenerateSubjectLists
{
    public partial class MainForm : Form
    {
        private string? _subjectsFilePath;
        private string? _outputFolderPath;

        public MainForm()
        {
            InitializeComponent();
            btnProcess.Enabled = false;
        }
        private void UpdateGenerateButtonState()
        {
            btnProcess.Enabled =
                !string.IsNullOrWhiteSpace(_subjectsFilePath) &&
                !string.IsNullOrWhiteSpace(_outputFolderPath);
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();
            dialog.Title = "Select Subjects.txt";
            dialog.Filter = "Text and CSV files (*.txt;*.csv)|*.txt;*.csv|All files (*.*)|*.*";

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                _subjectsFilePath = dialog.FileName;
                lblSelectedFile.Text = Path.GetFileName(_subjectsFilePath);
                txtOutput.Clear();
                txtOutput.AppendText("Subjects file selected.\r\n");
                UpdateGenerateButtonState();
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_subjectsFilePath) ||
                string.IsNullOrWhiteSpace(_outputFolderPath))
            {
                MessageBox.Show(
                    "Please select both a subjects file and an output folder.",
                    "Bragi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                txtOutput.Clear();
                txtOutput.AppendText("Generating subject lists...\r\n");

                var uncategorizedPath = Path.Combine(
                    _outputFolderPath,
                    "NotCategorizedSubjects.txt");

                BragiProcessor.GenerateSubjectLists(
                    _subjectsFilePath,
                    uncategorizedPath,
                    _outputFolderPath);

                txtOutput.AppendText("Done.\r\n");
                txtOutput.AppendText($"Uncategorized file: {uncategorizedPath}\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while generating subject lists:\r\n" + ex.Message,
                    "Bragi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }



        private void btnSelectOutputFolder_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog();
            dialog.Description = "Select output folder for subject lists";

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                _outputFolderPath = dialog.SelectedPath;

                // Show only folder name under the button
                var folderName = Path.GetFileName(
                    _outputFolderPath.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar));
                lblOutputFolder.Text = string.IsNullOrEmpty(folderName)
                    ? _outputFolderPath
                    : folderName;

                // Optional: log full path in the Output window
                txtOutput.AppendText($"Output folder selected.\r\n");

                UpdateGenerateButtonState();
            }
        }
    }
}

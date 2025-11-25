namespace GenerateSubjectLists
{
    partial class MainForm
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
            btnSelectFile = new Button();
            lblSelectedFile = new Label();
            btnSelectOutputFolder = new Button();
            txtOutput = new TextBox();
            groupBox1 = new GroupBox();
            lblOutputFolder = new Label();
            groupBox2 = new GroupBox();
            btnProcess = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelectFile
            // 
            btnSelectFile.Font = new Font("Calibri", 9F);
            btnSelectFile.Location = new Point(21, 27);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(162, 29);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "Select Subjects File...";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // lblSelectedFile
            // 
            lblSelectedFile.AutoSize = true;
            lblSelectedFile.Font = new Font("Calibri Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSelectedFile.Location = new Point(21, 59);
            lblSelectedFile.Name = "lblSelectedFile";
            lblSelectedFile.Size = new Size(99, 18);
            lblSelectedFile.TabIndex = 1;
            lblSelectedFile.Text = "No file selected";
            // 
            // btnSelectOutputFolder
            // 
            btnSelectOutputFolder.Font = new Font("Calibri", 9F);
            btnSelectOutputFolder.Location = new Point(254, 27);
            btnSelectOutputFolder.Name = "btnSelectOutputFolder";
            btnSelectOutputFolder.Size = new Size(162, 29);
            btnSelectOutputFolder.TabIndex = 2;
            btnSelectOutputFolder.Text = "Select Output Folder...";
            btnSelectOutputFolder.UseVisualStyleBackColor = true;
            btnSelectOutputFolder.Click += btnSelectOutputFolder_Click;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = SystemColors.ButtonFace;
            txtOutput.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOutput.Location = new Point(8, 27);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(422, 115);
            txtOutput.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblOutputFolder);
            groupBox1.Controls.Add(btnSelectFile);
            groupBox1.Controls.Add(lblSelectedFile);
            groupBox1.Controls.Add(btnSelectOutputFolder);
            groupBox1.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(169, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 93);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input";
            // 
            // lblOutputFolder
            // 
            lblOutputFolder.AutoSize = true;
            lblOutputFolder.Font = new Font("Calibri Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOutputFolder.Location = new Point(254, 59);
            lblOutputFolder.Name = "lblOutputFolder";
            lblOutputFolder.Size = new Size(167, 18);
            lblOutputFolder.TabIndex = 3;
            lblOutputFolder.Text = "No Output Folder Selected";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(txtOutput);
            groupBox2.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(169, 244);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(436, 148);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Output";
            // 
            // btnProcess
            // 
            btnProcess.BackColor = Color.PaleGreen;
            btnProcess.Location = new Point(271, 186);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(222, 50);
            btnProcess.TabIndex = 7;
            btnProcess.Text = "Generate Subject Lists";
            btnProcess.UseVisualStyleBackColor = false;
            btnProcess.Click += btnProcess_Click;
            // 
            // MainForm
            // 
            AcceptButton = btnProcess;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProcess);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bragi – Generate Subject Lists";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelectFile;
        private Label lblSelectedFile;
        private Button btnSelectOutputFolder;
        private TextBox txtOutput;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnProcess;
        private Label lblOutputFolder;
    }
}
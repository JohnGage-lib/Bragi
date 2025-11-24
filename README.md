# Bragi
Bragi – Generate Subject Lists

A lightweight Windows Forms utility for automatic subject categorization

Bragi is a .NET 8 WinForms application that reads a .txt or .csv subjects file, categorizes each line into discipline-specific lists (Art, Biology, Business, etc.), and then exports a full set of subject files into a chosen output directory. Any subjects that do not match known disciplines are placed into a separate NotCategorizedSubjects.txt file.

This tool was originally built to support library systems (e.g., LCC, NewBooks distributions), but can easily be adapted for any categorization workflow.

📂 Project Structure
GenerateSubjectLists/
│
├── BragiProcessor.cs          # Core logic for parsing & generating subject lists.
├── MainForm.cs                # UI logic, event handlers, workflow control.
├── MainForm.Designer.cs       # Auto-generated Windows Forms layout.
├── Program.cs                 # Application entry point (WinForms startup).
└── README.md                  # Documentation

🚀 Features

Import subjects from .txt or .csv

Automatic classification into 20+ discipline categories

Outputs one text file per discipline

Generates "NotCategorizedSubjects.txt" for anything unmatched

Clean GUI for selecting input file and output folder

Clear progress updates in an on-screen log

Input validation (Generate button only enabled when both paths are selected)

Press Enter to trigger Generate

🖼️ User Workflow

Select Subjects File
Choose your .txt or .csv file containing subjects (one per line).

Select Output Folder
Choose the directory where Bragi will generate all subject files.

Generate Subject Lists
Bragi processes the file, categorizes the subjects, and writes output files.

Review Output
In your chosen folder, you will find:

ArtSubjects.txt
BiologySubjects.txt
BusinessSubjects.txt
...
SlimSubjects.txt
NotCategorizedSubjects.txt

🧠 Code Overview
1. BragiProcessor.cs

This file contains the categorization logic.

Main Method:

public static void GenerateSubjectLists(string inputSubjectsFile, string uncategorizedOutputFile, string outputFolder)


Responsibilities:

Reads input subjects file

Splits lines into an array

Applies keyword-based filters for each discipline

Builds 20+ categorized lists

Builds the “not categorized” list

Writes out every list as a text file

The processor itself does no UI work and has no dependency on Windows Forms.

2. Program.cs

Standard WinForms entry point.

ApplicationConfiguration.Initialize();
Application.Run(new MainForm());


Previously, the app was console-driven. Now it launches the GUI and all file paths come from user interaction.

3. MainForm.cs

Handles all UI logic.

Key fields:
private string? _subjectsFilePath;
private string? _outputFolderPath;

Major event handlers:

btnSelectFile_Click
Opens a file dialog, loads file path, updates UI.

btnSelectOutputFolder_Click
Opens folder browser, saves folder path, updates UI.

btnProcess_Click
Validates inputs, calls BragiProcessor.GenerateSubjectLists, and logs progress.

Additional improvements:

Only file/folder names shown to user (clean UI)

Full paths only in internal variables and log window

Generate button is disabled until inputs are valid

Pressing Enter triggers Generate (via AcceptButton = btnProcess;)

4. MainForm.Designer.cs

Auto-generated layout file defining:

Input group (file + folder)

Output log panel

Main Generate button

Form properties (center screen, fixed dialog, colors, font)

This file is not manually edited, except for cosmetic tweaks.

📦 Output Files Example

After running Bragi, your output folder will contain:

ArtSubjects.txt
BiologySubjects.txt
BusinessSubjects.txt
ChemistrySubjects.txt
ComputerSubjects.txt
EducationSubjects.txt
FictionSubjects.txt
ForensicsSubjects.txt
GeoscienceSubjects.txt
HistorySubjects.txt
HPERSubjects.txt
HumanitiesSubjects.txt
IDTSubjects.txt
InterDisSubjects.txt
MathSubjects.txt
MusicSubjects.txt
NursingSubjects.txt
PerformanceSubjects.txt
PhysicsSubjects.txt
PsychSubjects.txt
PoliticsSubjects.txt
SlimSubjects.txt
NotCategorizedSubjects.txt

🛠️ Requirements

.NET 8 SDK

Windows 10/11

Visual Studio 2022 (recommended)


📚 License

This project is for internal / academic use unless extended with proper licensing.

✨ Author Notes

This version of Bragi includes significant UX improvements:

Replaced console-based workflow with polished WinForms UI

Cleaned up file path presentation

Added validation, logging, and safer processing

Removed unnecessary buttons and fields

Centered, modern layout for better user experience
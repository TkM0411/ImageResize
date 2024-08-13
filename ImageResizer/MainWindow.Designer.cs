namespace ImageResizer
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tblpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblpnlSource = new System.Windows.Forms.TableLayoutPanel();
            this.lblSourcePath = new System.Windows.Forms.Label();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.tblpnlDestination = new System.Windows.Forms.TableLayoutPanel();
            this.lblTargetPath = new System.Windows.Forms.Label();
            this.txtTargetPath = new System.Windows.Forms.TextBox();
            this.btnBrowseTarget = new System.Windows.Forms.Button();
            this.tblpnlWidthControl = new System.Windows.Forms.TableLayoutPanel();
            this.lblDimensions = new System.Windows.Forms.Label();
            this.txtDimension = new System.Windows.Forms.TextBox();
            this.rdbWidth = new System.Windows.Forms.RadioButton();
            this.rdbHeight = new System.Windows.Forms.RadioButton();
            this.tblpnlButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnResize = new System.Windows.Forms.Button();
            this.rtbConsoleLogs = new System.Windows.Forms.RichTextBox();
            this.folderSource = new System.Windows.Forms.FolderBrowserDialog();
            this.folderTarget = new System.Windows.Forms.FolderBrowserDialog();
            this.tblpnlMain.SuspendLayout();
            this.tblpnlSource.SuspendLayout();
            this.tblpnlDestination.SuspendLayout();
            this.tblpnlWidthControl.SuspendLayout();
            this.tblpnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpnlMain
            // 
            this.tblpnlMain.ColumnCount = 1;
            this.tblpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlMain.Controls.Add(this.tblpnlSource, 0, 0);
            this.tblpnlMain.Controls.Add(this.tblpnlDestination, 0, 1);
            this.tblpnlMain.Controls.Add(this.tblpnlWidthControl, 0, 2);
            this.tblpnlMain.Controls.Add(this.tblpnlButton, 0, 4);
            this.tblpnlMain.Controls.Add(this.rtbConsoleLogs, 0, 3);
            this.tblpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlMain.Location = new System.Drawing.Point(0, 0);
            this.tblpnlMain.Name = "tblpnlMain";
            this.tblpnlMain.RowCount = 5;
            this.tblpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblpnlMain.Size = new System.Drawing.Size(652, 492);
            this.tblpnlMain.TabIndex = 0;
            // 
            // tblpnlSource
            // 
            this.tblpnlSource.ColumnCount = 3;
            this.tblpnlSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblpnlSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblpnlSource.Controls.Add(this.lblSourcePath, 0, 0);
            this.tblpnlSource.Controls.Add(this.txtSourcePath, 1, 0);
            this.tblpnlSource.Controls.Add(this.btnBrowseSource, 2, 0);
            this.tblpnlSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlSource.Location = new System.Drawing.Point(3, 3);
            this.tblpnlSource.Name = "tblpnlSource";
            this.tblpnlSource.RowCount = 1;
            this.tblpnlSource.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlSource.Size = new System.Drawing.Size(646, 34);
            this.tblpnlSource.TabIndex = 0;
            // 
            // lblSourcePath
            // 
            this.lblSourcePath.AutoSize = true;
            this.lblSourcePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSourcePath.Location = new System.Drawing.Point(3, 0);
            this.lblSourcePath.Name = "lblSourcePath";
            this.lblSourcePath.Size = new System.Drawing.Size(114, 34);
            this.lblSourcePath.TabIndex = 0;
            this.lblSourcePath.Text = "Source Path:";
            this.lblSourcePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSourcePath.Location = new System.Drawing.Point(123, 3);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(400, 25);
            this.txtSourcePath.TabIndex = 1;
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowseSource.Location = new System.Drawing.Point(529, 3);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(114, 28);
            this.btnBrowseSource.TabIndex = 2;
            this.btnBrowseSource.Text = "Browse";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // tblpnlDestination
            // 
            this.tblpnlDestination.ColumnCount = 3;
            this.tblpnlDestination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblpnlDestination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlDestination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblpnlDestination.Controls.Add(this.lblTargetPath, 0, 0);
            this.tblpnlDestination.Controls.Add(this.txtTargetPath, 1, 0);
            this.tblpnlDestination.Controls.Add(this.btnBrowseTarget, 2, 0);
            this.tblpnlDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlDestination.Location = new System.Drawing.Point(3, 43);
            this.tblpnlDestination.Name = "tblpnlDestination";
            this.tblpnlDestination.RowCount = 1;
            this.tblpnlDestination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlDestination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpnlDestination.Size = new System.Drawing.Size(646, 34);
            this.tblpnlDestination.TabIndex = 2;
            // 
            // lblTargetPath
            // 
            this.lblTargetPath.AutoSize = true;
            this.lblTargetPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTargetPath.Location = new System.Drawing.Point(3, 0);
            this.lblTargetPath.Name = "lblTargetPath";
            this.lblTargetPath.Size = new System.Drawing.Size(114, 34);
            this.lblTargetPath.TabIndex = 0;
            this.lblTargetPath.Text = "Target Path:";
            this.lblTargetPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTargetPath
            // 
            this.txtTargetPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTargetPath.Location = new System.Drawing.Point(123, 3);
            this.txtTargetPath.Name = "txtTargetPath";
            this.txtTargetPath.Size = new System.Drawing.Size(400, 25);
            this.txtTargetPath.TabIndex = 1;
            // 
            // btnBrowseTarget
            // 
            this.btnBrowseTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowseTarget.Location = new System.Drawing.Point(529, 3);
            this.btnBrowseTarget.Name = "btnBrowseTarget";
            this.btnBrowseTarget.Size = new System.Drawing.Size(114, 28);
            this.btnBrowseTarget.TabIndex = 2;
            this.btnBrowseTarget.Text = "Browse";
            this.btnBrowseTarget.UseVisualStyleBackColor = true;
            this.btnBrowseTarget.Click += new System.EventHandler(this.btnBrowseTarget_Click);
            // 
            // tblpnlWidthControl
            // 
            this.tblpnlWidthControl.ColumnCount = 4;
            this.tblpnlWidthControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblpnlWidthControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlWidthControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblpnlWidthControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblpnlWidthControl.Controls.Add(this.lblDimensions, 0, 0);
            this.tblpnlWidthControl.Controls.Add(this.txtDimension, 1, 0);
            this.tblpnlWidthControl.Controls.Add(this.rdbWidth, 2, 0);
            this.tblpnlWidthControl.Controls.Add(this.rdbHeight, 3, 0);
            this.tblpnlWidthControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlWidthControl.Location = new System.Drawing.Point(3, 83);
            this.tblpnlWidthControl.Name = "tblpnlWidthControl";
            this.tblpnlWidthControl.RowCount = 1;
            this.tblpnlWidthControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlWidthControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpnlWidthControl.Size = new System.Drawing.Size(646, 34);
            this.tblpnlWidthControl.TabIndex = 3;
            // 
            // lblDimensions
            // 
            this.lblDimensions.AutoSize = true;
            this.lblDimensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDimensions.Location = new System.Drawing.Point(3, 0);
            this.lblDimensions.Name = "lblDimensions";
            this.lblDimensions.Size = new System.Drawing.Size(114, 34);
            this.lblDimensions.TabIndex = 0;
            this.lblDimensions.Text = "Dimension:";
            this.lblDimensions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDimension
            // 
            this.txtDimension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDimension.Location = new System.Drawing.Point(123, 3);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.Size = new System.Drawing.Size(280, 25);
            this.txtDimension.TabIndex = 1;
            this.txtDimension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDimension_KeyPress);
            // 
            // rdbWidth
            // 
            this.rdbWidth.AutoSize = true;
            this.rdbWidth.Checked = true;
            this.rdbWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbWidth.Location = new System.Drawing.Point(409, 3);
            this.rdbWidth.Name = "rdbWidth";
            this.rdbWidth.Size = new System.Drawing.Size(114, 28);
            this.rdbWidth.TabIndex = 2;
            this.rdbWidth.TabStop = true;
            this.rdbWidth.Text = "Width";
            this.rdbWidth.UseVisualStyleBackColor = true;
            // 
            // rdbHeight
            // 
            this.rdbHeight.AutoSize = true;
            this.rdbHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbHeight.Location = new System.Drawing.Point(529, 3);
            this.rdbHeight.Name = "rdbHeight";
            this.rdbHeight.Size = new System.Drawing.Size(114, 28);
            this.rdbHeight.TabIndex = 3;
            this.rdbHeight.Text = "Height";
            this.rdbHeight.UseVisualStyleBackColor = true;
            // 
            // tblpnlButton
            // 
            this.tblpnlButton.ColumnCount = 3;
            this.tblpnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblpnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlButton.Controls.Add(this.btnResize, 1, 0);
            this.tblpnlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlButton.Location = new System.Drawing.Point(3, 455);
            this.tblpnlButton.Name = "tblpnlButton";
            this.tblpnlButton.RowCount = 1;
            this.tblpnlButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlButton.Size = new System.Drawing.Size(646, 34);
            this.tblpnlButton.TabIndex = 4;
            // 
            // btnResize
            // 
            this.btnResize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResize.Location = new System.Drawing.Point(251, 3);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(144, 28);
            this.btnResize.TabIndex = 0;
            this.btnResize.Text = "Resize";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // rtbConsoleLogs
            // 
            this.rtbConsoleLogs.BackColor = System.Drawing.Color.Black;
            this.rtbConsoleLogs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbConsoleLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbConsoleLogs.ForeColor = System.Drawing.Color.Transparent;
            this.rtbConsoleLogs.Location = new System.Drawing.Point(3, 123);
            this.rtbConsoleLogs.Name = "rtbConsoleLogs";
            this.rtbConsoleLogs.ReadOnly = true;
            this.rtbConsoleLogs.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbConsoleLogs.Size = new System.Drawing.Size(646, 326);
            this.rtbConsoleLogs.TabIndex = 5;
            this.rtbConsoleLogs.Text = "";
            // 
            // folderSource
            // 
            this.folderSource.Description = "Browse Source Folder";
            this.folderSource.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderSource.ShowNewFolderButton = false;
            // 
            // folderTarget
            // 
            this.folderTarget.Description = "Browse Destination";
            this.folderTarget.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 492);
            this.Controls.Add(this.tblpnlMain);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Image Resize Utility";
            this.tblpnlMain.ResumeLayout(false);
            this.tblpnlSource.ResumeLayout(false);
            this.tblpnlSource.PerformLayout();
            this.tblpnlDestination.ResumeLayout(false);
            this.tblpnlDestination.PerformLayout();
            this.tblpnlWidthControl.ResumeLayout(false);
            this.tblpnlWidthControl.PerformLayout();
            this.tblpnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblpnlMain;
        private TableLayoutPanel tblpnlSource;
        private TableLayoutPanel tblpnlDestination;
        private TableLayoutPanel tblpnlWidthControl;
        private TableLayoutPanel tblpnlButton;
        private RichTextBox rtbConsoleLogs;
        private Label lblSourcePath;
        private TextBox txtSourcePath;
        private Button btnBrowseSource;
        private Label lblTargetPath;
        private TextBox txtTargetPath;
        private Button btnBrowseTarget;
        private Label lblDimensions;
        private TextBox txtDimension;
        private RadioButton rdbWidth;
        private RadioButton rdbHeight;
        private Button btnResize;
        private FolderBrowserDialog folderSource;
        private FolderBrowserDialog folderTarget;
    }
}
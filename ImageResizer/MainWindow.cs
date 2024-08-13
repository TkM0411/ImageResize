using ImageResize.Core;
using System.ComponentModel;

namespace ImageResizer
{
    public partial class MainWindow : Form
    {
        #region Fields
        string _sourceFolder;
        string _destinationFolder;
        ImageDimensionType _dimensionType;
        BackgroundWorker _worker;
        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
            _worker = new BackgroundWorker();
            _worker.DoWork += ProcessImagesInBackground;
        }

        private void ProcessImagesInBackground(object? sender, DoWorkEventArgs e)
        {
            try
            {
                List<ImageEntity> imagesToBeConverted = new List<ImageEntity>();
                foreach (var jpeg in Directory.GetFiles(_sourceFolder, "*.jpeg", SearchOption.TopDirectoryOnly))
                {
                    LogMessage($"Adding Image: {jpeg}\n");
                    imagesToBeConverted.Add(new ImageEntity(jpeg, _destinationFolder, Convert.ToSingle(txtDimension.Text), _dimensionType));
                }
                foreach (var jpg in Directory.GetFiles(_sourceFolder, "*.jpg", SearchOption.TopDirectoryOnly))
                {
                    LogMessage($"Adding Image: {jpg}\n");
                    imagesToBeConverted.Add(new ImageEntity(jpg, _destinationFolder, Convert.ToSingle(txtDimension.Text), _dimensionType));
                }

                LogMessage($"\n\n ----- Starting conversion of {imagesToBeConverted.Count} image(s) -- \n\n");
                foreach (ImageEntity img in imagesToBeConverted)
                {
                    LogMessage($"Resizing Source Image: {img.SourceFileName}\n");
                    img.Resize();
                    LogMessage($"New Image Dimensions: {img.ResizedWidth}x{img.ResizedHeight}\n");
                    LogMessage($"Resized Image FileName: {img.TargetFileName}\n\n");
                }
            }
            catch (Exception ex)
            {
                LogMessage($"Error: {ex.Message}");
            }
        }
        #endregion

        #region Methods
        private void LogMessage(string message)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(() =>
                {
                    rtbConsoleLogs.AppendText(message);
                    rtbConsoleLogs.ScrollToCaret();
                }));
            }
            else
            {
                rtbConsoleLogs.AppendText(message);
                rtbConsoleLogs.ScrollToCaret();
            }
        }
        #endregion

        #region Event Handlers
        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            if (folderSource.ShowDialog() == DialogResult.OK)
            {
                txtSourcePath.Text = folderSource.SelectedPath;
            }
        }

        private void btnBrowseTarget_Click(object sender, EventArgs e)
        {
            if (folderTarget.ShowDialog() == DialogResult.OK)
            {
                txtTargetPath.Text = folderTarget.SelectedPath;
            }
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSourcePath.Text) || string.IsNullOrWhiteSpace(txtTargetPath.Text) || string.IsNullOrEmpty(txtDimension.Text))
                    throw new ArgumentException("Mandatory fields missing.");
                else
                {
                    _sourceFolder = txtSourcePath.Text;
                    _destinationFolder = txtTargetPath.Text;
                    _dimensionType = rdbWidth.Checked ? ImageDimensionType.Width : ImageDimensionType.Height;
                    rtbConsoleLogs.Clear();
                    _worker.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDimension_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && txtDimension.TextLength < 5;
        }
        #endregion
    }
}
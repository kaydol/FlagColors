
namespace FlagColors
{
    internal partial class MainForm : Form
    {
        public IEnumerable<CheckBox> GetEditorColorControls()
        {
            return new[]
            {
                editorCheckBoxRed, editorCheckBoxYellow, editorCheckBoxGreen, editorCheckBoxBlue,
                editorCheckBoxPurple, editorCheckBoxBlack, editorCheckBoxWhite, editorCheckBoxPicture
            };
        }

        public IEnumerable<CheckBox> GetEditorShapeControls()
        {
            return new[]
            {
                editorCheckBoxHorizontal, editorCheckBoxVertical, editorCheckBoxDiagonal,
                editorCheckBoxCrosses, editorCheckBoxTriangles, editorCheckBoxMoon, editorCheckBoxWriting
            };
        }

        public Button GetEditorRenameButton() => editorButtonRename;
        public TextBox GetEditorCountry() => editorTextBoxCountry;

        public ListView GetListView() => flagsListView;

        public ImageList GetImageList() => imageList1;

        public OpenFileDialog GetOpenFileDialog() => openFileDialog1;
        public SaveFileDialog GetSaveFileDialog() => saveFileDialog1;




        private IEnumerable<string> GetColors()
        {
            return GetEditorColorControls().Where(e => e.Checked).Select(e => e.Text);
        }

        private IEnumerable<string> GetShapes()
        {
            return GetEditorShapeControls().Where(e => e.Checked).Select(e => e.Text);
        }

        private void OnEditorCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (GetCurrentSelection() == null)
                return;

            GetCurrentSelection()!.AssignColors(GetColors().ToArray());
            GetCurrentSelection()!.AssignShapes(GetShapes().ToArray());
        }

        private void OnEditorTextBoxCountryTextChanged(object sender, EventArgs e)
        {
            if (GetCurrentSelection() == null)
                return;

            if (GetCurrentSelection()!.Name != GetEditorCountry().Text)
                GetEditorRenameButton().Enabled = true;
            else
                GetEditorRenameButton().Enabled = false;
        }

        private void OnEditorButtonRenameClick(object sender, EventArgs e)
        {
            var x = GetCurrentSelection()!;

            var index = GetListView().Items.IndexOfKey(x.Name); // index must be calculated before AssignTitle
            x.AssignTitle(GetEditorCountry().Text); // after we know the index, we can AssignTitle

            GetListView().Items.RemoveAt(index);
            GetListView().Items.Add(x.Name, x.Name, GetData()!.Flags!.IndexOf(x));

            GetEditorRenameButton().Enabled = false;
        }

        private void ClearEditorControls()
        {
            GetEditorRenameButton().Enabled = false;

            SetCurrentSelection(null); // has to be done first, because...

            foreach (var cb in GetEditorColorControls())
                cb.Checked = false; // ...this triggers OnEditorCheckBoxCheckedChanged...

            foreach (var cb in GetEditorShapeControls())
                cb.Checked = false; // ...this triggers OnEditorCheckBoxCheckedChanged...

            GetEditorCountry().Text = string.Empty; // ...and this triggers OnEditorTextBoxCountryTextChanged
        }

        private void OnEditorButtonSaveClick(object sender, EventArgs e)
        {
            var dialog = GetSaveFileDialog();

            dialog.AddExtension = true;
            dialog.CreatePrompt = false;
            dialog.OverwritePrompt = true;
            dialog.DefaultExt = "FlagColors";
            dialog.Filter = "FlagColors data (*.xml)|*.xml";
            dialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FlagService.Serialize(dialog.FileName, GetData()!);
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message);
                }
            }
        }

        private void OnEditorButtonLoadClick(object sender, EventArgs e)
        {
            var dialog = GetOpenFileDialog();

            dialog.AddExtension = true;
            dialog.DefaultExt = "*.xml";
            dialog.Filter = "FlagColors data (*.xml)|*.xml";
            dialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var data = FlagService.Deserialize(dialog.FileName);
                    
                    GetImageList().Images.Clear();
                    GetListView().Items.Clear();

                    var imageWidth = GetImageList().ImageSize.Width;
                    var imageHeight = GetImageList().ImageSize.Height;

                    data.Flags?.ForEach(x =>
                    {
                        GetImageList().Images.Add(x.Name!, x.GetSvgDocument().Draw(imageWidth, imageHeight));
                        GetListView().Items.Add(x.Name, x.Name, GetData()!.Flags!.IndexOf(x));
                    });

                    SetData(data);

                    GetListView().Sort();
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message);
                }
            }
        }

    }
}

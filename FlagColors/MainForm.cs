
using System.Collections.Immutable;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FlagColors
{
    public partial class MainForm : Form
    {
        private FlagData _data;
        private FlagModel? _currentSelection;

        public MainForm()
        {
            InitializeComponent();

            var defaultData = FlagService.LoadDefaultDataFile();
            _data = defaultData ?? new FlagData();

            //var pathToFile = "C:\\Users\\volya\\Desktop\\Flags of the world\\ToParse.txt";
            //_data.Flags = FlagService.ParseWebPage(pathToFile);

            _data.Flags?.ForEach(x =>
            {
                imageList1.Images.Add(x.Name!, x.GetSvgDocument().Draw(imageList1.ImageSize.Width, imageList1.ImageSize.Height));
                flagsListView.Items.Add(x.Name, x.Name, _data.Flags.IndexOf(x));
            });

            flagsListView.Sorting = SortOrder.Ascending;
            flagsListView.Sort();
        }

        private void ShowError(string message)
        {
            var form = new PopupMessageForm("Error", message);
            form.ShowDialog();
        }

        enum Tabs
        {
            Filter,
            Editor
        }

        private TabControl GetTabControl() => tabControl1;
        private FlagModel? GetCurrentSelection() => _currentSelection;
        private void SetCurrentSelection(FlagModel? flag) => _currentSelection = flag;

        private void OnTabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            ClearFilterControls();

            // If an item was selected in the Filter tab, and then the tab was switched to Editor
            // this makes sure that the Editor controls are filled
            OnItemSelectionChanged(null, null);
        }

        private void OnItemSelectionChanged(object? sender, ListViewItemSelectionChangedEventArgs? e)
        {
            ClearEditorControls();

            if (flagsListView.SelectedItems.Count != 1)
                return;

            // fill Editor tab controls with values of the selected item
            var selection = flagsListView.SelectedItems[0];
            var flagModel = _data.Flags!.First(model => model.Name == selection.Text);

            if (GetTabControl().SelectedIndex == (int)Tabs.Editor)
            {
                var controlsToEnable = GetEditorControls()
                    .Where(cb => flagModel.GetColors().Contains(cb.Text, StringComparer.OrdinalIgnoreCase));

                foreach (var cb in controlsToEnable)
                    cb.Checked = true; // this triggers OnEditorCheckBoxCheckedChanged...

                GetEditorCountry().Text = selection.Text; // ...and this triggers OnEditorEditorTextBoxCountryEditorTextChanged
            }

            SetCurrentSelection(flagModel); // ...only do this after those
        }

        #region Editor

        private IEnumerable<CheckBox> GetEditorControls()
        {
            return new[]
            {
                editorCheckBoxRed, editorCheckBoxYellow, editorCheckBoxGreen, editorCheckBoxBlue,
                editorCheckBoxPurple, editorCheckBoxBlack, editorCheckBoxWhite, editorCheckBoxPicture
            };
        }

        private Button GetEditorRenameButton() => editorButtonRename;
        private TextBox GetEditorCountry() => editorTextBoxCountry;

        private IEnumerable<string> GetEditorControlsColors()
        {
            return GetEditorControls().Where(e => e.Checked).Select(e => e.Text);
        }

        private void OnEditorCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (GetCurrentSelection() == null)
                return;

            GetCurrentSelection()!.AssignColors(GetEditorControlsColors().ToArray());
        }

        private void OnEditorEditorTextBoxCountryEditorTextChanged(object sender, EventArgs e)
        {
            if (GetCurrentSelection() == null)
                return;

            if (GetCurrentSelection()!.Name != GetEditorCountry().Text)
                GetEditorRenameButton().Enabled = true;
            else
                GetEditorRenameButton().Enabled = false;
        }

        private void OnEditorEditorButtonRenameClick(object sender, EventArgs e)
        {
            var x = GetCurrentSelection()!;

            var index = flagsListView.Items.IndexOfKey(x.Name); // index must be calculated before AssignTitle
            x.AssignTitle(GetEditorCountry().Text); // after we know the index, we can AssignTitle

            flagsListView.Items.RemoveAt(index);
            flagsListView.Items.Add(x.Name, x.Name, _data.Flags!.IndexOf(x));

            GetEditorRenameButton().Enabled = false;
        }

        private void ClearEditorControls()
        {
            GetEditorRenameButton().Enabled = false;

            SetCurrentSelection(null); // has to be done first, because...

            foreach (var cb in GetEditorControls())
                cb.Checked = false; // ...this triggers OnEditorCheckBoxCheckedChanged...

            GetEditorCountry().Text = string.Empty; // ...and this triggers OnEditorEditorTextBoxCountryEditorTextChanged
        }

        private void OnEditorButtonSaveClick(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.CreatePrompt = false;
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.DefaultExt = "FlagColors";
            saveFileDialog1.Filter = "FlagColors data (*.xml)|*.xml";
            saveFileDialog1.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FlagService.Serialize(saveFileDialog1.FileName, _data);
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message);
                }
            }
        }

        private void OnEditorButtonLoadClick(object sender, EventArgs e)
        {
            openFileDialog1.AddExtension = true;
            openFileDialog1.DefaultExt = "*.xml";
            openFileDialog1.Filter = "FlagColors data (*.xml)|*.xml";
            openFileDialog1.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _data = FlagService.Deserialize(openFileDialog1.FileName);

                    imageList1.Images.Clear();
                    flagsListView.Items.Clear();

                    _data.Flags?.ForEach(x =>
                    {
                        imageList1.Images.Add(x.Name!, x.GetSvgDocument().Draw(imageList1.ImageSize.Width, imageList1.ImageSize.Height));
                        flagsListView.Items.Add(x.Name, x.Name, _data.Flags.IndexOf(x));
                    });

                    flagsListView.Sorting = SortOrder.Ascending;
                    flagsListView.Sort();
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message);
                }
            }
        }

        #endregion

        #region Filter

        private IEnumerable<CheckBox> GetFilterControls()
        {
            return new[]
            {
                filterCheckBoxRed, filterCheckBoxYellow, filterCheckBoxGreen, filterCheckBoxBlue,
                filterCheckBoxPurple, filterCheckBoxBlack, filterCheckBoxWhite, filterCheckBoxPicture
            };
        }

        private Button GetFilterNameResetButton() => filterButtonReset;
        private TextBox GetFilterName() => filterTextBoxName;

        private CheckBox GetFilterExactMatch() => filterCheckBoxExactMatch;

        private IEnumerable<string> GetFilterControlsColors()
        {
            return GetFilterControls().Where(e => e.Checked).Select(e => e.Text);
        }

        private void ClearFilterControls()
        {
            SetCurrentSelection(null); // has to be done first, because...

            GetFilterExactMatch().Checked = false; // ...this triggers OnEditorCheckBoxCheckedChanged...

            foreach (var cb in GetFilterControls())
                cb.Checked = false; // ...this triggers OnEditorCheckBoxCheckedChanged...

            GetFilterName().Text = string.Empty; // ...and this triggers OnEditorEditorTextBoxCountryEditorTextChanged
        }

        private void UpdateItems()
        {
            if (_data.Flags == null)
                return;

            var colors = GetFilterControlsColors().ToArray();

            var isExactMatch = GetFilterExactMatch().Checked;

            var toAdd = new List<FlagModel>();
            var toRemove = new List<string>();

            toAdd.AddRange(_data.Flags.Where(x =>
                // model satisfies color filter 
                (!colors.Any() || (!isExactMatch && colors.All(c => x.GetColors().Contains(c, StringComparer.OrdinalIgnoreCase))) ||
                                  (isExactMatch && colors.Order().SequenceEqual(x.GetColors().Order(), StringComparer.OrdinalIgnoreCase)))
                &&
                // model satisfies name filter 
                (GetFilterName().Text == string.Empty || (x.Name!.Contains(GetFilterName().Text, StringComparison.OrdinalIgnoreCase)))
                &&
                // model is not in flagsListView.Items
                !flagsListView.Items.ContainsKey(x.Name)
            ));

            foreach (ListViewItem item in flagsListView.Items)
            {
                var x = _data.Flags.First(x => x.Name == item.Name);

                var deleteByName = GetFilterName().Text != string.Empty &&
                    !item.Text.Contains(GetFilterName().Text, StringComparison.OrdinalIgnoreCase);

                var deleteByColor = colors.Any() &&
                    ((!isExactMatch && !colors.All(c => x.GetColors().Contains(c, StringComparer.OrdinalIgnoreCase))) ||
                     (isExactMatch && !colors.Order().SequenceEqual(x.GetColors().Order(), StringComparer.OrdinalIgnoreCase)));

                if (deleteByName || deleteByColor)
                    toRemove.Add(x.Name!);
            }

            toAdd.ForEach(x =>
            {
                flagsListView.Items.Add(x.Name, x.Name, _data.Flags.IndexOf(x));
            });

            toRemove.ForEach(flagsListView.Items.RemoveByKey);

            flagsListView.Sorting = SortOrder.Ascending;
            flagsListView.Sort();
        }

        private void OnFilterCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            UpdateItems();
        }

        private void OnFilterTextBoxNameTextChanged(object sender, EventArgs e)
        {
            if (GetFilterName().Text != string.Empty)
                GetFilterNameResetButton().Enabled = true;
            else
                GetFilterNameResetButton().Enabled = false;

            UpdateItems();
        }

        private void OnFilterButtonResetClick(object sender, EventArgs e)
        {
            GetFilterName().Text = string.Empty;
        }

        #endregion
    }
}
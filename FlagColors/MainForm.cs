
namespace FlagColors
{
    internal partial class MainForm : Form
    {
        private FlagData? _data;

        public FlagData? GetData() => _data;
        public void SetData(FlagData? data) => _data = data;


        private FlagModel? _currentSelection;

        private bool _preventUpdate;

        public void PreventUpdate(bool value)
        {
            _preventUpdate = value;
        }

        public MainForm()
        {
            InitializeComponent();
            
            try
            {
                var defaultData = FlagService.LoadDefaultDataFile();
                SetData(defaultData);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }

            if (GetData() == null)
                SetData(new FlagData());

            GetData()?.Flags?.ForEach(x =>
            {
                GetImageList().Images.Add(x.Name!, x.GetSvgDocument().Draw(GetImageList().ImageSize.Width, GetImageList().ImageSize.Height));
                GetListView().Items.Add(x.Name, x.Name, GetData()!.Flags!.IndexOf(x));
            });

            GetListView().Sorting = SortOrder.Ascending;
            GetListView().Sort();

            GetFilterResetAllButton().Enabled = false;
            GetFilterColorsResetButton().Enabled = false;
            GetFilterShapesResetButton().Enabled = false;
            GetFilterNameResetButton().Enabled = false;
        }

        public void ShowError(string message)
        {
            var form = new PopupMessageForm("Error", message);
            form.ShowDialog();
        }

        enum Tabs
        {
            Filter,
            Editor
        }

        public TabControl GetTabControl() => tabControl1;
        public FlagModel? GetCurrentSelection() => _currentSelection;
        public void SetCurrentSelection(FlagModel? flag) => _currentSelection = flag;

        private void OnTabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            //ClearFilterControls();

            // If an item was selected in the Filter tab, and then the tab was switched to Editor
            // this makes sure that the Editor controls are filled
            OnItemSelectionChanged(null, null);
        }

        public void OnItemSelectionChanged(object? sender, ListViewItemSelectionChangedEventArgs? e)
        {
            ClearEditorControls();

            if (GetListView().SelectedItems.Count != 1)
                return;

            // fill Editor tab controls with values of the selected item
            var selection = GetListView().SelectedItems[0];
            var flagModel = GetData()!.Flags!.First(model => model.Name == selection.Text);

            if (GetTabControl().SelectedIndex == (int)Tabs.Editor)
            {
                var colorsToEnable = GetEditorColorControls()
                    .Where(cb => flagModel.GetColors().Contains(cb.Text, StringComparer.OrdinalIgnoreCase));

                var shapesToEnable = GetEditorShapeControls()
                    .Where(cb => flagModel.GetShapes().Contains(cb.Text, StringComparer.OrdinalIgnoreCase));

                foreach (var cb in colorsToEnable)
                    cb.Checked = true; // this triggers OnEditorCheckBoxCheckedChanged...

                foreach (var cb in shapesToEnable)
                    cb.Checked = true; // this triggers OnEditorCheckBoxCheckedChanged...

                GetEditorCountry().Text = selection.Text; // ...and this triggers OnEditorTextBoxCountryTextChanged
            }

            SetCurrentSelection(flagModel); // ...only do this after those
        }

        public void UpdateItems()
        {
            if (_preventUpdate || GetData()!.Flags == null)
                return;

            var colors = GetFilterColors().ToArray();
            var shapes = GetFilterShapes().ToArray();

            var isExactMatch = GetFilterExactMatch().Checked;

            var toAdd = new List<FlagModel>();
            var toRemove = new List<string>();

            toAdd.AddRange(GetData()!.Flags!.Where(x =>
                // model satisfies color filter 
                (!colors.Any() || (!isExactMatch && colors.All(c => x.GetColors().Contains(c, StringComparer.OrdinalIgnoreCase))) ||
                                  (isExactMatch && colors.Order().SequenceEqual(x.GetColors().Order(), StringComparer.OrdinalIgnoreCase)))
                &&
                // model satisfies shape filter
                (!shapes.Any() || shapes.All(s => x.GetShapes().Contains(s, StringComparer.OrdinalIgnoreCase)))
                &&
                // model satisfies name filter 
                (GetFilterName().Text == string.Empty || (x.Name!.Contains(GetFilterName().Text, StringComparison.OrdinalIgnoreCase)))
                &&
                // model is not in flagsListView.Items
                !GetListView().Items.ContainsKey(x.Name)
            ));

            foreach (ListViewItem item in GetListView().Items)
            {
                var x = GetData()!.Flags!.First(x => x.Name == item.Name);

                var deleteByName = GetFilterName().Text != string.Empty &&
                    !item.Text.Contains(GetFilterName().Text, StringComparison.OrdinalIgnoreCase);

                if (deleteByName)
                {
                    toRemove.Add(x.Name!);
                    continue;
                }

                var deleteByColor = colors.Any() &&
                    ((!isExactMatch && !colors.All(c => x.GetColors().Contains(c, StringComparer.OrdinalIgnoreCase))) ||
                     (isExactMatch && !colors.Order().SequenceEqual(x.GetColors().Order(), StringComparer.OrdinalIgnoreCase)));

                if (deleteByColor)
                {
                    toRemove.Add(x.Name!);
                    continue;
                }

                var deleteByShape = !shapes.All(c => x.GetShapes().Contains(c, StringComparer.OrdinalIgnoreCase));

                if (deleteByShape)
                {
                    toRemove.Add(x.Name!);
                    continue;
                }
            }

            toAdd.ForEach(x =>
            {
                GetListView().Items.Add(x.Name, x.Name, GetData()!.Flags!.IndexOf(x));
            });

            toRemove.ForEach(GetListView().Items.RemoveByKey);

            GetListView().Sort();
        }
    }
}
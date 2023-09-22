
namespace FlagColors
{
    internal partial class MainForm : Form
    {
        public IEnumerable<CheckBox> GetFilterColorControls()
        {
            return new[]
            {
                filterCheckBoxRed, filterCheckBoxYellow, filterCheckBoxGreen, filterCheckBoxBlue,
                filterCheckBoxPurple, filterCheckBoxBlack, filterCheckBoxWhite, filterCheckBoxPicture
            };
        }
        public IEnumerable<CheckBox> GetFilterShapeControls()
        {
            return new[]
            {
                filterCheckBoxHorizontal, filterCheckBoxVertical, filterCheckBoxDiagonal,
                filterCheckBoxCrosses, filterCheckBoxTriangles, filterCheckBoxMoon, filterCheckBoxWriting
            };
        }
        public Button GetFilterNameResetButton() => filterButtonResetName;
        public Button GetFilterColorsResetButton() => filterButtonResetColors;
        public Button GetFilterShapesResetButton() => filterButtonResetShapes;
        public Button GetFilterResetAllButton() => filterButtonResetAll;
        public TextBox GetFilterName() => filterTextBoxName;
        public CheckBox GetFilterExactMatch() => filterCheckBoxExactMatch;




        private IEnumerable<string> GetFilterColors()
        {
            return GetFilterColorControls().Where(e => e.Checked).Select(e => e.Text);
        }

        private IEnumerable<string> GetFilterShapes()
        {
            return GetFilterShapeControls().Where(e => e.Checked).Select(e => e.Text);
        }

        private void ClearFilterControls()
        {
            PreventUpdate(true);

            GetFilterName().Text = string.Empty;

            foreach (var cb in GetFilterShapeControls().Where(cb => cb.Checked))
                cb.Checked = false; // ...this triggers OnFilterCheckBoxCheckedChanged...

            foreach (var cb in GetFilterColorControls().Where(cb => cb.Checked))
                cb.Checked = false; // ...this triggers OnFilterCheckBoxCheckedChanged...

            PreventUpdate(false);
            UpdateItems();
        }

        private void OnFilterCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            var resetAllEnabled = false;

            if (GetFilterColorControls().Any(cb => cb.Checked))
            {
                GetFilterColorsResetButton().Enabled = true;
                resetAllEnabled = true;
            } 
            else 
                GetFilterColorsResetButton().Enabled = false;

            if (GetFilterShapeControls().Any(cb => cb.Checked)) 
            {
                GetFilterShapesResetButton().Enabled = true;
                resetAllEnabled = true;
            }
            else
                GetFilterShapesResetButton().Enabled = false;

            if (GetFilterName().Text != string.Empty)
            {
                resetAllEnabled = true;
            }

            GetFilterResetAllButton().Enabled = resetAllEnabled;

            UpdateItems();
        }

        private void OnFilterTextBoxNameTextChanged(object sender, EventArgs e)
        {
            if (GetFilterName().Text != string.Empty)
                GetFilterNameResetButton().Enabled = true;
            else
                GetFilterNameResetButton().Enabled = false;

            var resetAllEnabled = GetFilterNameResetButton().Enabled || 
                                  GetFilterColorsResetButton().Enabled || 
                                  GetFilterShapesResetButton().Enabled;

            GetFilterResetAllButton().Enabled = resetAllEnabled;

            UpdateItems();
        }

        private void OnFilterButtonResetNameClick(object sender, EventArgs e)
        {
            GetFilterName().Text = string.Empty;
        }

        private void OnFilterButtonResetShapesClick(object sender, EventArgs e)
        {
            PreventUpdate(true);

            foreach (var cb in GetFilterShapeControls().Where(cb => cb.Checked))
                cb.Checked = false; // ...this triggers OnFilterCheckBoxCheckedChanged...

            PreventUpdate(false);
            UpdateItems();
        }

        private void OnFilterButtonResetColorsClick(object sender, EventArgs e)
        {
            PreventUpdate(true);

            foreach (var cb in GetFilterColorControls().Where(cb => cb.Checked))
                cb.Checked = false; // ...this triggers OnFilterCheckBoxCheckedChanged...

            PreventUpdate(false);
            UpdateItems();
        }

        private void OnFilterButtonResetAllClick(object sender, EventArgs e)
        {
            ClearFilterControls();
        }
    }
}

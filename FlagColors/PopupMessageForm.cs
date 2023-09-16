
namespace FlagColors
{
    public partial class PopupMessageForm : Form
    {
        public PopupMessageForm(string title, string message, Icon? icon = null)
        {
            InitializeComponent();

            Icon = icon;
            Text = title;
            richTextBox1.Text = message;
        }

        private void OnOKButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}

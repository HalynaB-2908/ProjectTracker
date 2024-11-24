using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Windows.Forms;

namespace ProjectTracker
{
    public partial class AddProjectForm : MaterialForm
    {
        public string ProjectName { get; private set; }

        public AddProjectForm()
        {
            InitializeComponent();
            InitializeMaterialDesign();
        }

        private void InitializeMaterialDesign()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey600,
                Primary.Grey800,
                Primary.Grey200,
                Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ProjectName = projectNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(ProjectName))
            {
                MessageBox.Show("Please enter a project name.");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

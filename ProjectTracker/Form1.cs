using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTracker
{
    public partial class RegistrationForm : MaterialSkin.Controls.MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
            InitializeMaterialDesign();
        }
        private void InitializeMaterialDesign()
        {
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey600,   
                Primary.Grey800,   
                Primary.Grey200,   
                Accent.LightBlue200, 
                TextShade.WHITE
                );
        }
    }
}

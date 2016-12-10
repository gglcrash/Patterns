using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Factory;
using WindowsFormsApplication1.Factory.Facilities;


namespace WindowsFormsApplication1
{
    public partial class AbstractFactoryForm : Form
    {
        public AbstractFactoryForm()
        {
            InitializeComponent();
        }
        String result;
        private void createButton_Click(object sender, EventArgs e)
        {
            if (CatRadioButton.Checked)
            {
                result = Helper.getInstance().createFacilities(new CatFacilitiesFactory()).ToString();

            } else if (DogRadioButton.Checked) {
                result = Helper.getInstance().createFacilities(new DogFacilitiesFactory()).ToString();
            }
            richTextBox.Text=result;
        }
    }
}

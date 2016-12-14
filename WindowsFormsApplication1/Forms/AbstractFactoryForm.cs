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
            Helper helper = new Helper();
            if (CatRadioButton.Checked)
            {
                //объект "приспособления", содержащий в себе миску, клетку и ошейник, преобразованный в строку
                //для отображения на форме
                result = helper.createFacilities(new CatFacilitiesFactory()).ToString();

            } else if (DogRadioButton.Checked) {
                result = helper.createFacilities(new DogFacilitiesFactory()).ToString();
            }
            richTextBox.Text=result;
        }
    }
}

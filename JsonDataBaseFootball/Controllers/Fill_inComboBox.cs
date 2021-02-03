using JsonDataBaseFootball.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonDataBaseFootball.Controllers
{
    public static class Fill_inComboBox
    {
        public static void ID<T>(ComboBox comboBoxDelete)
        {
            comboBoxDelete.DataSource = Repository.Get<T>();
            comboBoxDelete.DisplayMember = "ID";
            comboBoxDelete.ValueMember = "ID";
        }
        public static void Name<T>(ComboBox comboBox)
        {
            comboBox.DataSource = Repository.Get<T>();
            comboBox.ValueMember = "ID";
            comboBox.DisplayMember = "Name";
            
        }
    }
}
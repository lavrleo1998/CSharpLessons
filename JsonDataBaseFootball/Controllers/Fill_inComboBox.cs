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
        public static void DeleteComboBox<T>(ComboBox comboBox)
        {
            comboBox.DataSource = Repository.Get<T>();
            comboBox.DisplayMember = "ID";
            comboBox.ValueMember = "ID";
        }
    }
}

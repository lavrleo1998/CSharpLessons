using JsonDataBaseFootball.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonDataBaseFootball.Controllers
{
    class TeamTypeControllers
    {
        public static void Print(RichTextBox richTextBox)
        {
            richTextBox.Text = TeamTypeServices.Download();
        }
    }
}

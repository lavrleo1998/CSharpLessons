using JsonDataBaseFootball.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonDataBaseFootball.Controllers
{
    public static class EventControllers
    {
        public static void Print(RichTextBox richTextBox)
        {
            richTextBox.Text = EventServices.Download();
        }
    }
}

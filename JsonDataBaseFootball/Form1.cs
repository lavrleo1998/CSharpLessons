using JsonDataBaseFootball.Controllers;
using JsonDataBaseFootball.Entities;
using JsonDataBaseFootball.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonDataBaseFootball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ////NewDB.GenerateFiles();
            ////NewDB.GenerateNewDB();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<string> R3 = new List<string>();

            R3 = TeamCompositionServices.GetTeamByFootballer(1);

            foreach (var item in R3)
            {
                richTextBox2.Text += "\n" + Convert.ToString(item);
            }



            List<Event> events = new List<Event>();
            events = EventServices.GetEventsByFootballer(Convert.ToInt32(textBox7.Text));
            foreach (var item in events)
            {
                richTextBox2.Text += Convert.ToString(item.ID) + " " + Convert.ToString(item.DateTime) + " " + Convert.ToString(item.EventTypeID) + "\n";
            }


            List<string> R2 = new List<string>();

            R2 = TeamCompositionServices.GetTeamByDate(dateTimePicker2.Value.Date);

            foreach (var item in R2)
            {
                richTextBox2.Text += Convert.ToString(item) + "\n";
            }


            List<Event> R1 = new List<Event>();

            R1 = EventServices.GetEventsByFootballerAndDate(2, dateTimePicker2.Value.Date);

            foreach (var item in R1)
            {
                richTextBox2.Text += Convert.ToString(item.ID) + " " + Convert.ToString(item.DateTime) + " " + Convert.ToString(item.EventTypeID) + "\n";
            }
            

        }
    }
}

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
        {/*
            List<string> R = new List<string>();

            R = TeamCompositionServices.GetTeamByFootballer(1);

            foreach (var item in R)
            {
                richTextBox2.Text += "\n"+Convert.ToString(item);
            }
            */
            /*
            List<Event> events = new List<Event>();
            events = EventServices.GetEventsByFootballer(4);
            foreach (var item in events)
            {
                richTextBox2.Text += Convert.ToString(item.ID)+" " + Convert.ToString(item.DateTime) + " " + Convert.ToString(item.EventTypeID) + "\n";
            }
            */

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_exchange_between_windows
{
    public partial class questionnaire : Form
    {
        public questionnaire()
        {
            InitializeComponent();
        }
        string gend;
        class Data
        {
            public string Name { set; get; }
            public Data(string name)
            {
                Name = name;
            }
        }
        private void nation_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> listing = new List<string>();
            if (nation.Text == "беларусь")
            {
                listing.Add("брест");
                listing.Add("витебск");
                listing.Add("гомель");
            }
            else if (nation.Text == "россия")
            {
                listing.Add("москва");
                listing.Add("санкт-петербург");
                listing.Add("севастополь");
            }
            else
            {
                listing.Add("киев");
                listing.Add("харьков");
                listing.Add("николаев");
            }
            town.DataSource = listing;
        }

        private void watch_res_Click(object sender, EventArgs e)
        {
            if (gend == "мужской") MessageBox.Show($"{fam_name.Text}, {behalf.Text}, {patr.Text}, {nation.Text}, {town.Text}, {telephone.Text}, {birth_day.Text}, {gend}");
            else MessageBox.Show($"{fam_name.Text}, {behalf.Text}, {patr.Text}, {nation.Text}, {town.Text}, {telephone.Text}, {birth_day.Text}, {gend}");
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            gend = "мужской";
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            gend = "женский";
        }
    }
}
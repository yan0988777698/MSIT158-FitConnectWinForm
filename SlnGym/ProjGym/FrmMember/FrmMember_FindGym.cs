using ProjGym.使用者控制項;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjGym
{
    public partial class FrmMember_FindGym : Form
    {
        gymEntities _gymEntities = new gymEntities();
        public FrmMember_FindGym()
        {
            InitializeComponent();
        }
        private void FrmMember_FindGym_Load(object sender, EventArgs e)
        {
            LoadCitys();
            LoadGyms();
        }
        private void LoadGyms()
        {
            var gyms = from gym in _gymEntities.tGym
                       select gym;
            foreach (var gym in gyms)
            {
                UCMember_Gym uCAdmin_Gym = new UCMember_Gym()
                {
                    gymid = gym.Gym_id,
                    gymname = gym.name,
                    gymtime = gym.time,
                    gymaddress = gym.address,
                    gymphoto = gym.photo,
                };
                uCAdmin_Gym.showGymInfo();
                this.flowLayoutPanel_Gym.Controls.Add(uCAdmin_Gym);
            }
        }
        private void LoadCitys()
        {
            cb_City.Items.Clear();
            var gyms = (from gym in _gymEntities.tGym
                        select gym.tregion_table.tcity).Distinct();
            gyms.ToList().ForEach(gym => cb_City.Items.Add(gym.city));
        }


        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Region.Items.Clear();
            string selectedCity = ((ComboBox)sender).SelectedItem.ToString();

            var regions = from region in _gymEntities.tregion_table
                          where region.tcity.city.Equals(selectedCity)
                          select region;
            regions.ToList().ForEach(region => cb_Region.Items.Add(region.region));
        }

        private void cb_Region_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel_Gym.Controls.Clear();

            string selectedRegion = ((ComboBox)sender).SelectedItem.ToString();
            if (selectedRegion == null)
                return;

            var gyms = from gym in _gymEntities.tGym
                       where gym.tregion_table.region.Equals(selectedRegion)
                       select gym;

            gyms.ToList().ForEach(gym =>
            {
                UCMember_Gym uCAdmin_Gym = new UCMember_Gym
                {
                    gymid = gym.Gym_id,
                    gymname = gym.name,
                    gymtime = gym.time,
                    gymaddress = gym.address,
                    gymphoto = gym.photo,
                };
                uCAdmin_Gym.showGymInfo();
                flowLayoutPanel_Gym.Controls.Add(uCAdmin_Gym);
            });
        }


        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            string keyword = tb_Search.Text;
            var gyms = from gym in _gymEntities.tGym
                       where gym.address.Contains(keyword)
                       select gym;
            flowLayoutPanel_Gym.Controls.Clear();
            foreach (var gym in gyms)
            {
                UCMember_Gym uCAdmin_Gym = new UCMember_Gym
                {
                    gymid = gym.Gym_id,
                    gymname = gym.name,
                    gymtime = gym.time,
                    gymaddress = gym.address,
                    gymphoto = gym.photo,
                    
                };
                uCAdmin_Gym.showGymInfo();
                flowLayoutPanel_Gym.Controls.Add(uCAdmin_Gym);
            }
        }
    }
}


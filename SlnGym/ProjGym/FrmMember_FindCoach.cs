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
    public partial class FrmMember_FindCoach : Form
    {

        gymEntities _gymEntities = new gymEntities();
        public tIdentity member { get; set; }
        public FrmMember_FindCoach()
        {
            InitializeComponent();
        }

        private void FrmMember_FindCoach_Load(object sender, EventArgs e)
        {
            showCoaches();
            loadComboBox();
        }

        private void loadComboBox()
        {
            this.cb_Region.Items.Clear();
            var regions = from regoin in _gymEntities.tregion_table
                          select regoin;
            regions.ToList().ForEach(region => { this.cb_Region.Items.Add(region.region); });

            this.cb_Classes.Items.Clear();
            var tclasses = from tclass in _gymEntities.tclasses
                           select tclass;
            tclasses.ToList().ForEach(tclass => { this.cb_Classes.Items.Add(tclass.class_name); });

            this.cb_Gender.Items.Clear();
            var genders = from gender in _gymEntities.tgender_Table
                          select gender;
            genders.ToList().ForEach(gender => { this.cb_Gender.Items.Add(gender.gender_text); });
        }

        private void showCoaches()
        {
            var coaches = from coach in _gymEntities.tIdentity
                          join info in _gymEntities.tcoach_info_id
                          on coach.id equals info.coach_id
                          where coach.role_id == 2
                          && coach.activated == true
                          && coach.name.Contains(tb_CoachName.Text)
                          select new
                          {
                              編號 = coach.id,
                              姓名 = coach.name,
                              性別 = coach.tgender_Table.gender_text,
                              介紹 = info.coach_intro,
                          };

            coaches.ToList().ForEach(
                coach =>
                {
                    var expertises = from expertise in _gymEntities.tcoach_expert
                                     where expertise.coach_id == coach.編號
                                     select expertise;

                    var districts = from schedule in _gymEntities.tclass_schedule
                                    where schedule.coach_id == coach.編號
                                    select new
                                    {
                                        district = schedule.tfield.tGym.tregion_table.region
                                    };
                    UCMember_FindCoach uCMember_FindCoach = new UCMember_FindCoach();
                    uCMember_FindCoach.name = coach.姓名;
                    expertises.ToList().ForEach(expertise =>
                    {
                        uCMember_FindCoach.expertise += $"#{expertise.tclasses.class_name} ";
                    });
                    if (districts.Any())
                    {
                        districts.Distinct().ToList().ForEach(expertise =>
                        {
                            uCMember_FindCoach.district += $"#{expertise.district}";
                        });
                    }
                    else
                    {
                        uCMember_FindCoach.district = "尚未開課";
                    }

                    uCMember_FindCoach.intro = coach.介紹;
                    this.flowLayoutPanel_Coaches.Controls.Add(uCMember_FindCoach);
                }
            );

            lbl_NumberOfCoaches.Text = $"共有{coaches.ToList().Count}位教練";
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel_Coaches.Controls.Clear();
            showCoaches();
        }

        private void cb_Region_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.flowLayoutPanel_Coaches.Controls.Clear();
            var coachesInSelectedRegoin = (from schedule in _gymEntities.tclass_schedule
                                           where schedule.tfield.tGym.tregion_table.region == cb_Region.SelectedItem.ToString()
                                           select new { schedule.coach_id }).Distinct();
            var coaches = from coachInSelectedRegoin in coachesInSelectedRegoin
                          join coach in _gymEntities.tIdentity
                          on coachInSelectedRegoin.coach_id equals coach.id
                          join info in _gymEntities.tcoach_info_id
                          on coachInSelectedRegoin.coach_id equals info.coach_id
                          select new
                          {
                              編號 = coach.id,
                              姓名 = coach.name,
                              性別 = coach.tgender_Table.gender_text,
                              介紹 = info.coach_intro,
                          };
            coaches.ToList().ForEach(
                coach =>
                {
                    var expertises = from expertise in _gymEntities.tcoach_expert
                                     where expertise.coach_id == coach.編號
                                     select expertise;

                    var districts = from schedule in _gymEntities.tclass_schedule
                                    where schedule.coach_id == coach.編號
                                    select new
                                    {
                                        district = schedule.tfield.tGym.tregion_table.region
                                    };
                    UCMember_FindCoach uCMember_FindCoach = new UCMember_FindCoach();
                    uCMember_FindCoach.name = coach.姓名;
                    expertises.ToList().ForEach(expertise =>
                    {
                        uCMember_FindCoach.expertise += $"#{expertise.tclasses.class_name} ";
                    });
                    if (districts.Any())
                    {
                        districts.Distinct().ToList().ForEach(expertise =>
                        {
                            uCMember_FindCoach.district += $"#{expertise.district}";
                        });
                    }
                    else
                    {
                        uCMember_FindCoach.district = "尚未開課";
                    }
                    uCMember_FindCoach.intro = coach.介紹;
                    this.flowLayoutPanel_Coaches.Controls.Add(uCMember_FindCoach);
                }
            );

            lbl_NumberOfCoaches.Text = $"共有{coaches.ToList().Count}位教練";
        }

        private void cb_Classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.flowLayoutPanel_Coaches.Controls.Clear();
            var coachesInSelectedClass = (from schedule in _gymEntities.tclass_schedule
                                          where schedule.tclasses.class_name == cb_Classes.SelectedItem.ToString()
                                          select new { schedule.coach_id }).Distinct();
            var coaches = from coachInSelectedRegoin in coachesInSelectedClass
                          join coach in _gymEntities.tIdentity
                          on coachInSelectedRegoin.coach_id equals coach.id
                          join info in _gymEntities.tcoach_info_id
                          on coachInSelectedRegoin.coach_id equals info.coach_id
                          select new
                          {
                              編號 = coach.id,
                              姓名 = coach.name,
                              性別 = coach.tgender_Table.gender_text,
                              介紹 = info.coach_intro,
                          };
            coaches.ToList().ForEach(
                coach =>
                {
                    var expertises = from expertise in _gymEntities.tcoach_expert
                                     where expertise.coach_id == coach.編號
                                     select expertise;

                    var districts = from schedule in _gymEntities.tclass_schedule
                                    where schedule.coach_id == coach.編號
                                    select new
                                    {
                                        district = schedule.tfield.tGym.tregion_table.region
                                    };
                    UCMember_FindCoach uCMember_FindCoach = new UCMember_FindCoach();
                    uCMember_FindCoach.name = coach.姓名;
                    expertises.ToList().ForEach(expertise =>
                    {
                        uCMember_FindCoach.expertise += $"#{expertise.tclasses.class_name} ";
                    });
                    if (districts.Any())
                    {
                        districts.Distinct().ToList().ForEach(expertise =>
                        {
                            uCMember_FindCoach.district += $"#{expertise.district}";
                        });
                    }
                    else
                    {
                        uCMember_FindCoach.district = "尚未開課";
                    }
                    uCMember_FindCoach.intro = coach.介紹;
                    this.flowLayoutPanel_Coaches.Controls.Add(uCMember_FindCoach);
                }
            );

            lbl_NumberOfCoaches.Text = $"共有{coaches.ToList().Count}位教練";
        }

        private void cb_Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: 依照性別選擇教練
            this.flowLayoutPanel_Coaches.Controls.Clear();
            var coachesInSelectedClass = (from schedule in _gymEntities.tclass_schedule
                                          where schedule.tIdentity.tgender_Table.gender_text == cb_Gender.SelectedItem.ToString()
                                          select new { schedule.coach_id }).Distinct();
            var coaches = from coachInSelectedRegoin in coachesInSelectedClass
                          join coach in _gymEntities.tIdentity
                          on coachInSelectedRegoin.coach_id equals coach.id
                          join info in _gymEntities.tcoach_info_id
                          on coachInSelectedRegoin.coach_id equals info.coach_id
                          select new
                          {
                              編號 = coach.id,
                              姓名 = coach.name,
                              性別 = coach.tgender_Table.gender_text,
                              介紹 = info.coach_intro,
                          };
            coaches.ToList().ForEach(
                coach =>
                {
                    var expertises = from expertise in _gymEntities.tcoach_expert
                                     where expertise.coach_id == coach.編號
                                     select expertise;

                    var districts = from schedule in _gymEntities.tclass_schedule
                                    where schedule.coach_id == coach.編號
                                    select new
                                    {
                                        district = schedule.tfield.tGym.tregion_table.region
                                    };
                    UCMember_FindCoach uCMember_FindCoach = new UCMember_FindCoach();
                    uCMember_FindCoach.name = coach.姓名;
                    expertises.ToList().ForEach(expertise =>
                    {
                        uCMember_FindCoach.expertise += $"#{expertise.tclasses.class_name} ";
                    });
                    if (districts.Any())
                    {
                        districts.Distinct().ToList().ForEach(expertise =>
                        {
                            uCMember_FindCoach.district += $"#{expertise.district}";
                        });
                    }
                    else
                    {
                        uCMember_FindCoach.district = "尚未開課";
                    }
                    uCMember_FindCoach.intro = coach.介紹;
                    this.flowLayoutPanel_Coaches.Controls.Add(uCMember_FindCoach);
                }
            );

            lbl_NumberOfCoaches.Text = $"共有{coaches.ToList().Count}位教練";
        }
    }
}

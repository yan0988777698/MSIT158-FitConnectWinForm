using mid_Coonect;
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

    public partial class FrmMain_Main : Form
    {
        //設置[主程式]表單一個名為member的屬性，用來記錄目前的[登入者]
        public tIdentity member { get; set; }

        //FrmMain的建構子，在new FrmMain()時被執行
        public FrmMain_Main()
        {
            InitializeComponent();
        }

        //關閉前一個form
        private void closeCurrentForm()
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        //[主程式]表單在載入階段要做的事情(此時的主程式還沒顯示在畫面上)
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //將首頁的Info文字設為空字串
            lbl_Info.Text = string.Empty;
            //載入主程式前，先新增[登入頁面]
            FrmMain_Login frmLogin = new FrmMain_Login();
            //在[登入頁面]表單的afterLogin事件上，註冊showinfo方法，觸發條件:當[登入頁面]的[登入]按鈕被按下時，執行showinfo
            frmLogin.StartPosition = FormStartPosition.CenterScreen;
            frmLogin.afterLogin += this.showinfo;
            //將[登入頁面]顯示出來，並禁止使用者與其他視窗互動
            frmLogin.ShowDialog();

        }

        private void showHomePage()
        {
            FrmHomePage_Announce frmHomePage_Announce = new FrmHomePage_Announce();
            setPage(frmHomePage_Announce);

        }

        private void setPage(Form form)
        {
            form.MdiParent = this;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            //frmHomePage_Announce.ControlBox = false;
            form.Visible = true;
            this.panel_Bottom.Controls.Add(form);
        }



        //處理首頁Info文字的內容(用來顯示使用者基本資料)
        private void showinfo(tIdentity m)//m為[登入頁面]表單傳回的一筆[登入者]資料
        {
            //將m記錄在[主程式]表單的member屬性
            //任何子表單都可以透過MdiParent屬性找到[主程式]表單
            //再利用[主程式]表單的member屬性，找到當前的[登入者]資料
            this.member = m;
            //將Info設為可視
            lbl_Info.Visible = true;
            //產生[gym資料庫實體]
            gymEntities gymEntities = new gymEntities();
            //利用m的性別ID，找出ID對應的真實性別(g為m的性別ID所對應到的資料行)
            tgender_Table g = gymEntities.tgender_Table.FirstOrDefault(x => x.gender_id == m.gender_id);
            //將m的名稱、生日、電話、地址、信箱屬性與g的性別名稱屬性，寫入Info的Text屬性
            this.lbl_Info.Text = $"{m.tidentity_role_detail.role_describe}: {m.name}, 您好";
        }

        private void 修改會員資料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //先關閉前一個視窗
            closeCurrentForm();
            //將Info設為隱藏
            //lbl_Info.Visible = false;
            //新增一個[編輯會員資料]表單
            FrmMember_EditRegister editMemberRegister = new FrmMember_EditRegister();
            //在[編輯會員資料]表單上，註冊showinfo方法，觸發條件:當[編輯會員資料]表單的[保存]按鈕被按下時，執行showinfo
            editMemberRegister.member = this.member;
            editMemberRegister.afterEdit += this.showinfo;
            setPage(editMemberRegister);

        }

        private void 公告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeCurrentForm();
            showHomePage();
        }

        private void 訓練課程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeCurrentForm();
            FrmMember_FindClass frmMember_ClassList = new FrmMember_FindClass();
            frmMember_ClassList.member = this.member;
            setPage(frmMember_ClassList);

        }

        private void 新增課程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeCurrentForm();
            FrmCoach_AddNewCourse frmCoach_AddNewCourse = new FrmCoach_AddNewCourse();
            frmCoach_AddNewCourse.member = this.member;
            setPage(frmCoach_AddNewCourse);
        }

        private void 開課審核ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeCurrentForm();
            FrmAdmin_ClassUpdate frmAdmin_ClassUpdate = new FrmAdmin_ClassUpdate();
            setPage(frmAdmin_ClassUpdate);
        }

        private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.member = null;
            closeCurrentForm();
            FrmMain_Login frmLogin = new FrmMain_Login();
            this.lbl_Info.Text = string.Empty;
            frmLogin.StartPosition = FormStartPosition.CenterScreen;
            frmLogin.afterLogin += this.showinfo;
            frmLogin.ShowDialog();
        }

        private void 常見問題ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeCurrentForm();
            FrmMember_QandA frmMember_QandA = new FrmMember_QandA();
            setPage(frmMember_QandA);
        }

        private void 付款資訊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeCurrentForm();
            FrmAdmin_MemberPayment frmAdmin_Payment = new FrmAdmin_MemberPayment();

            setPage(frmAdmin_Payment);
        }

        private void 已預約課程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeCurrentForm();
            FrmMember_CourseCart frmMember_CheckCourse = new FrmMember_CourseCart();
            frmMember_CheckCourse.member = this.member;
            frmMember_CheckCourse.goBack += this.goback;
            setPage(frmMember_CheckCourse);
        }

        private void goback()
        {
            closeCurrentForm();
            FrmMember_FindClass frmMember_ClassList = new FrmMember_FindClass();
            frmMember_ClassList.member = this.member;
            setPage(frmMember_ClassList);
        }

        private void 教練款項ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 修改教練資料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeCurrentForm();
            FrmCoach_EditRegister frmCoach_EditRegister = new FrmCoach_EditRegister();
            frmCoach_EditRegister.coach = this.member;
            frmCoach_EditRegister.afterEdit += this.showinfo;
            setPage(frmCoach_EditRegister);
        }

        private void 教練審核ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeCurrentForm();
            FrmAdmin_CoachVerification frmAdmin_CoachVerification = new FrmAdmin_CoachVerification();
            setPage(frmAdmin_CoachVerification);
        }

        private void 歷史訂單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeCurrentForm();
            FrmMember_CourseHistory frmMember_CourseHistory = new FrmMember_CourseHistory();
            frmMember_CourseHistory.member = this.member;
            setPage(frmMember_CourseHistory);
        }

        private void 教練資訊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeCurrentForm();
            FrmMember_FindCoach frmMember_FindCoach = new FrmMember_FindCoach();
            frmMember_FindCoach.member = this.member;
            setPage(frmMember_FindCoach);
        }

        private void 我的開課ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeCurrentForm();
            FrmCoach_CheckCourse frmCoach_CheckCourse = new FrmCoach_CheckCourse();
            frmCoach_CheckCourse.member = this.member;
            setPage(frmCoach_CheckCourse);
        }
    }
}

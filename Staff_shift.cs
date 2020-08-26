using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 写真館システム
{
    public partial class Staff_shift : UserControlExp
    {
        private checkOperation chk;
        private modifyCheck mod;
        private bool RefreshFlg;

        public Staff_shift()
        {
            InitializeComponent();

            chk = new checkOperation(this);

            mod = new modifyCheck();
            mod.add(t_start_time);
            mod.add(t_end_time);
            mod.add(t_syugyoukubun);
        }

        public override void PageRefresh()
        {
            RefreshFlg = true;
            d_tenpo.DataSource = DB.m_store.getStoreNameList();
            d_staff.DataSource = DB.m_staff.getStaffNameList(MainForm.session_m_staff.store_code);
            t_syugyoukubun.DataSource = Enum.GetValues(typeof(Utile.Data.就業区分));

            d_tenpo.SelectedIndex = d_tenpo.FindStringExact(DB.m_store.getSingle(MainForm.session_m_staff.store_code).store_name);
            d_staff.SelectedIndex = d_staff.FindStringExact(DB.m_staff.getSingle(MainForm.session_m_staff.staff_code).staff_name);

            monthCalendar1.SetDate(DateTime.Now.Date);

            //初期化
            SetDisp(GetStaff_Shift());

            mod.reset();
            RefreshFlg = false;
        }
        
        private DB.m_staff_shift GetStaff_Shift()
        {
            if(d_staff.Items.Count == 0 || d_staff.SelectedItem == null)
            {
                return null;
            }else{

                var storeCode = DB.m_store.getSingleName(d_tenpo.SelectedItem.ToString()).store_code;
                var staffCode = DB.m_staff.getSingleName(storeCode, d_staff.SelectedItem.ToString()).staff_code;
                var date = monthCalendar1.SelectionStart;
                return DB.m_staff_shift.getSingle(staffCode, date);

            }
        }

        //初期化
        private void SetDisp(DB.m_staff_shift ss)
        {
            //年表示
            t_year.Text = (string)monthCalendar1.SelectionStart.Year.ToString("0000") + "年";

            //月・日・曜日表示
            t_days.Text = (string)monthCalendar1.SelectionStart.Month.ToString("0") + "月" +
                monthCalendar1.SelectionStart.Day.ToString("0") + "日（" +
                monthCalendar1.SelectionStart.Date.ToString("dddd") + "）";

            if(ss != null)
            {
                //開始時刻
                t_start_time.Text = ss.start_time.ToString(@"hh\:mm");
                //終了時刻
                t_end_time.Text = ss.end_time.ToString(@"hh\:mm");
                //就業区分
                t_syugyoukubun.SelectedIndex = int.Parse(ss.work_class);
            }
            else
            {
                //開始時刻
                t_start_time.Text ="";
                //終了時刻
                t_end_time.Text ="";
                //就業区分
                t_syugyoukubun.SelectedIndex = -1;
            }

            if (d_staff.Items.Count == 0)
                b_regist.Enabled = false;
            else
                b_regist.Enabled = true;

            mod.reset();
        }
        
        //一日戻す。
        private void b_decrease_Click(object sender, EventArgs e)
        {
            mod.chackMessage("スタッフシフトの変更破棄");
            monthCalendar1.SetDate(monthCalendar1.SelectionStart.AddDays(-1));
            SetDisp(GetStaff_Shift());
        }

        //一日進める。
        private void b_increase_Click(object sender, EventArgs e)
        {
            mod.chackMessage("スタッフシフトの変更破棄");
            monthCalendar1.SetDate(monthCalendar1.SelectionStart.AddDays(1));
            SetDisp(GetStaff_Shift());
        }

        private void b_regist_Click(object sender, EventArgs e)
        {
            chk.clear();
            chk.addControl(t_start_time);
            chk.addControl(t_end_time);
            chk.addControl(t_syugyoukubun);
            chk.addControl(d_staff);
            if (chk.check("W00000", chk.checkControlImportant))
                return;


            chk.clear();
            chk.addControl(t_start_time);
            chk.addControl(t_end_time);
            if (chk.check("W00003", chk.checkTextboxFormat, @"^([0-9]|[0-1][0-9]|[2][0-3]):[0-5][0-9]$", "00:00"))
                return;

            var ss = GetStaff_Shift();
            if (ss == null)
            {
                ss = new DB.m_staff_shift();
                ss.store_code = DB.m_store.getSingleName(d_tenpo.SelectedItem.ToString()).store_code;
                ss.staff_code = DB.m_staff.getSingleName(ss.store_code, d_staff.SelectedItem.ToString()).staff_code;
                ss.work_day = monthCalendar1.SelectionStart;
            }
            ss.start_time = TimeSpan.Parse(t_start_time.Text);
            ss.end_time = TimeSpan.Parse(t_end_time.Text);
            ss.work_class = t_syugyoukubun.SelectedIndex.ToString();
            ss.Command();
            
            Utile.Message.showMessageOK("I11001");
            mod.reset();
        }

        private void b_return_Click(object sender, EventArgs e)
        {
            mod.chackMessage("スタッフシフトの変更破棄");
            pageParent.PageRefresh();
            MainForm.backPage(this);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (!RefreshFlg)
                mod.chackMessage("スタッフシフトの変更破棄");
            SetDisp(GetStaff_Shift());
        }

        private void d_staff_id_KeyDown(object sender, KeyEventArgs e)
        {
            mod.chackMessage("スタッフシフトの変更破棄");
            if (e.KeyCode == Keys.Enter)
            {
                var staff = DB.m_staff.getSingle(d_staff_id.Text);
                if (staff == null)
                    d_staff.SelectedIndex = -1;
                else
                    d_staff.SelectedIndex = d_staff.FindStringExact(staff.staff_name);
            }
        }

        private void d_tenpo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!RefreshFlg)
                mod.chackMessage("スタッフシフトの変更破棄");
            var storeCode = DB.m_store.getSingleName(d_tenpo.SelectedItem.ToString()).store_code;
            d_staff.DataSource = DB.m_staff.getStaffNameList(storeCode);
            SetDisp(GetStaff_Shift());
        }

        private void d_staff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!RefreshFlg)
                mod.chackMessage("スタッフシフトの変更破棄");
            d_staff_id.Text = "";
            SetDisp(GetStaff_Shift());

        }
    }
}

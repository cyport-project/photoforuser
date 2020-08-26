using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using 写真館システム.DB;
using System.Text.RegularExpressions;

namespace 写真館システム
{
    public partial class Costume_master : UserControlExp
    {
        //変更フラグ
        //private Boolean changeValue;
        private modifyCheck mod;

        //現在ページ
        private int currentPage;
        // 総ページ
        private int totalPage;
        //チェッククラス
        private checkOperation chk;

        //構造体の生成（店舗）
        public struct storeCodeArray
        {
            public string store_code;
            public string store_name;
        }
        //店舗リストの生成
        private List<storeCodeArray> storeCodeList = new List<storeCodeArray>();


        //リストの生成（データベース）
        private List<DB.m_costume> costumeDBList = new List<DB.m_costume>();

        private string Costume_Image_Path = "";


        public Costume_master()
        {
            InitializeComponent();

            //LostFocus設定
            t_image_file1.Leave += new EventHandler(t_image_file1_Leave);
            t_image_file2.Leave += new EventHandler(t_image_file2_Leave);
            t_image_file3.Leave += new EventHandler(t_image_file3_Leave);
            t_image_file4.Leave += new EventHandler(t_image_file4_Leave);

            //チェックリストの生成
            chk = new checkOperation(this);

            mod = new modifyCheck();
            mod.add(t_age);
            mod.add(t_brand);
            mod.add(t_bunrui);
            mod.add(t_color);
            mod.add(t_costume);
            mod.add(t_costume_code);
            mod.add(t_customer_display);
            mod.add(t_gara);
            mod.add(t_image_file1);
            mod.add(t_image_file2);
            mod.add(t_image_file3);
            mod.add(t_image_file4);
            mod.add(t_kashidashi_tenpo);
            mod.add(t_mitame);
            mod.add(t_price1);
            mod.add(t_price2);
            mod.add(t_price3);
            mod.add(t_rank);
            mod.add(t_size);
            mod.add(t_tekiyou);
            mod.add(d_seibetsu);
            mod.add(d_siyoukahi);
            mod.add(d_status);
        }

        private void Set_intialDiaplay()
        {

            //storeCodeListの初期化
            storeCodeList.Clear();
            NpgsqlDataReader dataReader = null;
            var dbc = new DB.DBConnect();
            dbc.npg.Open();
            StringBuilder sb = new StringBuilder();
            sb.Append(@"select store_code, store_name ");
            sb.Append(@"from m_store ");
            sb.Append(@"where m_store.delete_flag = '0' order by m_store.store_code");
            var command = new NpgsqlCommand(sb.ToString(), dbc.npg);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {

                //storeCodeListの生成
                storeCodeList.Add(new storeCodeArray
                {
                    store_code = dataReader["store_code"].ToString(),
                    store_name = dataReader["store_name"].ToString()
                });

            }

            dbc.npg.Close();

            //店舗名の生成
            d_tenpo.Items.Clear();
            for (int i = 0; i < storeCodeList.Count; i++)
            {
                d_tenpo.Items.Add(storeCodeList[i].store_name);
            }

            if (costumeDBList.Count == 0)
            {
                ShowBlank();
            }
            else
            {
                Listshow();
            }


            //変更フラグクリア
            mod.reset();

            //エラー項目クリア
            chk.clear();

        }

        private void ShowBlank()
        {

            d_tenpo.SelectedIndex = d_tenpo.FindStringExact(DB.m_store.getSingle(MainForm.session_m_staff.store_code).store_name);
            t_costume_code.Text = null;
            t_costume.Text = null;
            t_size.Text = null;
            d_seibetsu.DataSource = Enum.GetValues(typeof(Utile.Data.性別));
            d_seibetsu.SelectedIndex = -1;
            t_brand.Text = null;
            t_rank.Text = null;
            d_siyoukahi.DataSource = Enum.GetValues(typeof(Utile.Data.衣装使用可否));
            d_siyoukahi.SelectedIndex = -1;
            t_price1.Text = null;
            t_price2.Text = null;
            t_price3.Text = null;
            t_color.Text = null;
            t_age.Text = null;
            t_tekiyou.Text = null;
            t_image_file1.Text = null;
            t_image_file2.Text = null;
            t_image_file3.Text = null;
            t_image_file4.Text = null;
            t_bunrui.Text = null;
            t_mitame.Text = null;
            t_gara.Text = null;
            d_status.DataSource = Enum.GetValues(typeof(Utile.Data.衣装ステータス));
            d_status.SelectedIndex = -1;
            t_kashidashi_tenpo.Text = null;
            t_customer_display.Text = null;

            t_current_page.Text = (string)currentPage.ToString("0");
            t_total_page.Text = (string)totalPage.ToString("0");

            //pictureboxのクリア
            this.p_image1.Image = null;
            this.p_image2.Image = null;
            this.p_image3.Image = null;
            this.p_image4.Image = null;
            mod.reset();
        }
        //list表示
        public void Listshow()
        {

            var cos = costumeDBList[currentPage - 1];
            d_tenpo.SelectedIndex = d_tenpo.FindStringExact(DB.m_store.getSingle(cos.store_code).store_name);
            t_costume_code.Text = cos.costume_code;
            t_costume.Text = cos.costume_name;
            t_size.Text = cos.size;
            d_seibetsu.DataSource = Enum.GetValues(typeof(Utile.Data.性別));
            d_seibetsu.SelectedIndex = int.Parse(cos.sex);
            t_brand.Text = cos.brand_name;
            t_rank.Text = cos.rank;
            d_siyoukahi.DataSource = Enum.GetValues(typeof(Utile.Data.衣装使用可否));
            d_siyoukahi.SelectedIndex = int.Parse(cos.usability);
            t_price1.Text = cos.price1.ToString();
            t_price2.Text = cos.price2.ToString();
            t_price3.Text = cos.price3.ToString();
            t_color.Text = cos.color;
            t_age.Text = cos.target_age.ToString();
            t_tekiyou.Text = cos.remarks;
            t_image_file1.Text = cos.image1;
            t_image_file2.Text = cos.image2;
            t_image_file3.Text = cos.image3;
            t_image_file4.Text = cos.image4;
            t_bunrui.Text = cos.Class;
            t_mitame.Text = cos.appearance;
            t_gara.Text = cos.handle;
            d_status.DataSource = Enum.GetValues(typeof(Utile.Data.衣装ステータス));
            d_status.SelectedIndex = int.Parse(cos.status);
            t_kashidashi_tenpo.Text = cos.rental_store;
            t_customer_display.Text = cos.customer_display;

            t_current_page.Text = (string)currentPage.ToString("0");
            t_total_page.Text = (string)totalPage.ToString("0");

            //pictureboxのクリア
            setImage(p_image1, t_image_file1);
            setImage(p_image2, t_image_file2);
            setImage(p_image3, t_image_file3);
            setImage(p_image4, t_image_file4);

            mod.reset();
        }
        

        //ページの初期化
        public override void PageRefresh()
        {

            //データ取得
            costumeDBList = DB.m_costume.GetAllTable();
            totalPage = costumeDBList.Count == 0 ? 1 : costumeDBList.Count;
            currentPage = 1;

            var rootPath = System.Configuration.ConfigurationManager.AppSettings["photo_root"].ToString();
            var cosDir = System.Configuration.ConfigurationManager.AppSettings["Costume_Image"].ToString();
            Costume_Image_Path = System.IO.Path.Combine(rootPath, cosDir);

            Set_intialDiaplay();

            b_new_regist.Visible = true;
            b_regist.Visible = true;
            b_delete.Visible = true;
            t_current_page.Visible = true;
            label4.Visible = true;
            t_total_page.Visible = true;
            b_decrease.Visible = true;
            b_increase.Visible = true;

            d_tenpo.Enabled = false;
            t_costume_code.Enabled = false;

        }

        public void PageRefresh(string id)
        {

            //データ取得
            costumeDBList = DB.m_costume.GetAllTable();
            totalPage = costumeDBList.Count;
            currentPage = 1;
            foreach (var cos in costumeDBList)
            {
                if (cos.costume_code == id)
                    break;
                currentPage++;
            }

            var rootPath = System.Configuration.ConfigurationManager.AppSettings["photo_root"].ToString();
            var cosDir = System.Configuration.ConfigurationManager.AppSettings["Costume_Image"].ToString();
            Costume_Image_Path = System.IO.Path.Combine(rootPath, cosDir);

            Set_intialDiaplay();

            b_new_regist.Visible = false;
            b_regist.Visible = false;
            b_delete.Visible = false;
            t_current_page.Visible = false;
            label4.Visible = false;
            t_total_page.Visible = false;
            b_decrease.Visible = false;
            b_increase.Visible = false;


        }

        private void setImage(PictureBox pic, TextBox tex)
        {
            var storeName = d_tenpo.SelectedItem.ToString();
            var cosId = t_costume_code.Text;
            var imgPath = System.IO.Path.Combine(Costume_Image_Path, storeName, cosId, tex.Text);

            if (System.IO.File.Exists(imgPath))
            {
                //ファイル表示およびサイズモード設定
                pic.Image = System.Drawing.Image.FromFile(imgPath);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pic.Image = null;
            }
        }

        private void t_image_file4_Leave(object sender, EventArgs e)
        {
            setImage(p_image4, t_image_file4);

        }

        private void t_image_file3_Leave(object sender, EventArgs e)
        {
            setImage(p_image3, t_image_file3);
        }

        private void t_image_file2_Leave(object sender, EventArgs e)
        {
            setImage(p_image2, t_image_file2);
        }

        private void t_image_file1_Leave(object sender, EventArgs e)
        {
            setImage(p_image1, t_image_file1);
        }
        
        //◀ボタン[クリック]処理
        private void b_decrease_Click(object sender, EventArgs e)
        {
            d_tenpo.Enabled = false;
            t_costume_code.Enabled = false;

            using(var dbc = new DB.DBConnect())
            {
                var q = from t in dbc.m_costume
                        select t;
                totalPage = q.Count();
            }

            if (currentPage > 1)
            {
                if (!mod.chackMessage("処理"))
                    return;

                currentPage--;
                Listshow();
            }
        }

        //▶ボタン[クリック]処理
        private void b_increase_Click(object sender, EventArgs e)
        {
            if(currentPage < totalPage)
            {
                if (!mod.chackMessage("処理"))
                    return;

                currentPage++;
                Listshow();
            }
        }

        //新規登録
        private void b_new_regist_Click(object sender, EventArgs e)
        {
            if (!mod.chackMessage("処理"))
                return;

            d_tenpo.Enabled = true;
            t_costume_code.Enabled = true;

            ShowBlank();
            t_total_page.Text = (totalPage+1).ToString();
            t_current_page.Text = (totalPage + 1).ToString();
            currentPage = totalPage + 1;

            mod.reset();
        }

        //削除
        private void b_delete_Click(object sender, EventArgs e)
        {
            if (!mod.chackMessage("削除"))
                return;

            if (totalPage == currentPage - 1)
                return;

            var cos = costumeDBList[currentPage - 1];
            cos.Command(delete: true);

            costumeDBList = DB.m_costume.GetAllTable();
            totalPage = costumeDBList.Count;
            currentPage = 1;

            Set_intialDiaplay();

            this.PageRefresh();
            MainForm.backPage(this);
        }

        //登録
        private void b_regist_Click(object sender, EventArgs e)
        {
            //if (!mod.chackMessage("登録"))
            //    return;

            //入力チェック
            chk.clear();
            chk.addControl(d_tenpo);
            chk.addControl(t_costume_code);
            chk.addControl(t_costume);
            chk.addControl(t_size);
            chk.addControl(d_seibetsu);
            chk.addControl(t_brand);
            chk.addControl(t_rank);
            chk.addControl(d_siyoukahi);
            chk.addControl(t_price1);
            chk.addControl(t_price2);
            chk.addControl(t_price3);
            chk.addControl(t_color);
            chk.addControl(t_age);
            chk.addControl(t_bunrui);
            chk.addControl(t_mitame);
            chk.addControl(t_gara);
            chk.addControl(d_status);
            chk.addControl(t_image_file1);
            if (chk.check("W00000", chk.checkControlImportant))
                return;

            //桁数チェック
            //衣装コード
            chk.clear();
            chk.addControl(t_costume_code);
            if (chk.check("W00001", chk.checkTextboxLength, 8))　
                return;

            //衣装名・ブランド名
            chk.clear();
            chk.addControl(t_costume);
            chk.addControl(t_brand);
            if (chk.check("W00001", chk.checkTextboxLength, 40))　
                return;

            //年齢
            chk.clear();
            chk.addControl(t_age);
            if (chk.check("W00001", chk.checkTextboxLength, 2))
                return;

            //価格・色・分類・柄・サイズ・ランク
            chk.clear();
            chk.addControl(t_size);
            chk.addControl(t_rank);
            chk.addControl(t_price1);
            chk.addControl(t_price2);
            chk.addControl(t_price3);
            chk.addControl(t_color);
            chk.addControl(t_bunrui);
            chk.addControl(t_gara);
            if (chk.check("W00001", chk.checkTextboxLength, 10))
                return;

            //見た目
            chk.clear();
            chk.addControl(t_mitame);
            if (chk.check("W00001", chk.checkTextboxLength, 20))
                return;

            //摘要・イメージファイル
            chk.clear();
            chk.addControl(t_tekiyou);
            chk.addControl(t_image_file1);
            chk.addControl(t_image_file2);
            chk.addControl(t_image_file3);
            chk.addControl(t_image_file4);
            if (chk.check("W00001", chk.checkTextboxLength, 255))
                return;

            //貸出店舗・お客様表示用
            chk.clear();
            chk.addControl(t_kashidashi_tenpo);
            chk.addControl(t_customer_display);
            if (chk.check("W00001", chk.checkTextboxLength, 30))
                return;

            //正規表現
            //価格
            chk.clear();
            chk.addControl(t_price1);
            chk.addControl(t_price2);
            chk.addControl(t_price3);
            if (chk.check("W00003", chk.checkTextboxFormat, @"\d{1,10}?\z", @"0～9999999999"))
                return;

            //正規表現
            //年齢
            chk.clear();
            chk.addControl(t_age);
            if (chk.check("W00003", chk.checkTextboxFormat, @"\d{1,3}?\z", @"0～999"))
                return;

            DB.m_costume cos = new m_costume();
            if (totalPage == currentPage - 1)
            {
                //新規登録
                cos.store_code = DB.m_store.getSingleName(d_tenpo.SelectedItem.ToString()).store_code;
                cos.costume_code = t_costume_code.Text;
                cos.costume_name = t_costume.Text;
                cos.size = t_size.Text;
                cos.sex = d_seibetsu.SelectedIndex.ToString();
                cos.brand_name = t_brand.Text;
                cos.rank = t_rank.Text;
                cos.usability = d_siyoukahi.SelectedIndex.ToString();
                cos.price1 = int.Parse(t_price1.Text);
                cos.price2 = int.Parse(t_price2.Text);
                cos.price3 = int.Parse(t_price3.Text);
                cos.color = t_color.Text;
                cos.target_age = int.Parse(t_age.Text);
                cos.remarks = t_tekiyou.Text;
                cos.image1 = t_image_file1.Text;
                cos.image2 = t_image_file2.Text;
                cos.image3 = t_image_file3.Text;
                cos.image4 = t_image_file4.Text;
                cos.Class = t_bunrui.Text;
                cos.appearance = t_mitame.Text;
                cos.handle = t_gara.Text;
                d_status.DataSource = Enum.GetValues(typeof(Utile.Data.衣装ステータス));
                cos.status = d_status.SelectedIndex.ToString();
                cos.rental_store = t_kashidashi_tenpo.Text;
                cos.customer_display = t_customer_display.Text;
            }
            else
            {
                //更新
                cos = costumeDBList[currentPage - 1];
                cos.costume_name = t_costume.Text;
                cos.size = t_size.Text;
                cos.sex = d_seibetsu.SelectedIndex.ToString();
                cos.brand_name = t_brand.Text;
                cos.rank = t_rank.Text;
                cos.usability = d_siyoukahi.SelectedIndex.ToString();
                cos.price1 = int.Parse(t_price1.Text);
                cos.price2 = int.Parse(t_price2.Text);
                cos.price3 = int.Parse(t_price3.Text);
                cos.color = t_color.Text;
                cos.target_age = int.Parse(t_age.Text);
                cos.remarks = t_tekiyou.Text;
                cos.image1 = t_image_file1.Text;
                cos.image2 = t_image_file2.Text;
                cos.image3 = t_image_file3.Text;
                cos.image4 = t_image_file4.Text;
                cos.Class = t_bunrui.Text;
                cos.appearance = t_mitame.Text;
                cos.handle = t_gara.Text;
                d_status.DataSource = Enum.GetValues(typeof(Utile.Data.衣装ステータス));
                cos.status = d_status.SelectedIndex.ToString();
                cos.rental_store = t_kashidashi_tenpo.Text;
                cos.customer_display = t_customer_display.Text;
            }

            cos.Command();

            this.PageRefresh();
            MainForm.backPage(this);
        }

        //戻る
        private void b_return_Click(object sender, EventArgs e)
        {
            if (!mod.chackMessage("戻る処理"))
                return;

            this.PageRefresh();
            MainForm.backPage(this);

        }

    }
}

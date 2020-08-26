using System;
using System.Windows.Forms;

namespace 写真館システム
{
    partial class Staff_shift
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.b_decrease = new System.Windows.Forms.LinkLabel();
            this.b_increase = new System.Windows.Forms.LinkLabel();
            this.t_year = new System.Windows.Forms.Label();
            this.t_days = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.d_tenpo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.t_start_time = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.t_end_time = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.t_syugyoukubun = new System.Windows.Forms.ComboBox();
            this.d_staff = new System.Windows.Forms.ComboBox();
            this.d_staff_id = new System.Windows.Forms.TextBox();
            this.b_regist = new System.Windows.Forms.Button();
            this.b_return = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 12;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.b_regist, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.b_return, 10, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1063, 718);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 30;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 10);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.Controls.Add(this.monthCalendar1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 9, 1);
            this.tableLayoutPanel2.Controls.Add(this.b_decrease, 9, 3);
            this.tableLayoutPanel2.Controls.Add(this.b_increase, 10, 3);
            this.tableLayoutPanel2.Controls.Add(this.t_year, 11, 3);
            this.tableLayoutPanel2.Controls.Add(this.t_days, 13, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 9, 5);
            this.tableLayoutPanel2.Controls.Add(this.d_tenpo, 12, 5);
            this.tableLayoutPanel2.Controls.Add(this.label5, 9, 7);
            this.tableLayoutPanel2.Controls.Add(this.label6, 9, 9);
            this.tableLayoutPanel2.Controls.Add(this.t_start_time, 12, 9);
            this.tableLayoutPanel2.Controls.Add(this.label7, 9, 11);
            this.tableLayoutPanel2.Controls.Add(this.t_end_time, 12, 11);
            this.tableLayoutPanel2.Controls.Add(this.label8, 9, 13);
            this.tableLayoutPanel2.Controls.Add(this.t_syugyoukubun, 12, 13);
            this.tableLayoutPanel2.Controls.Add(this.d_staff, 15, 7);
            this.tableLayoutPanel2.Controls.Add(this.d_staff_id, 12, 7);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 30;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333332F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1034, 652);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.monthCalendar1, 7);
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(0, 0, 9, 9);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.tableLayoutPanel2.SetRowSpan(this.monthCalendar1, 9);
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(309, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "出勤日";
            // 
            // b_decrease
            // 
            this.b_decrease.AutoSize = true;
            this.b_decrease.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.b_decrease.Location = new System.Drawing.Point(309, 63);
            this.b_decrease.Name = "b_decrease";
            this.b_decrease.Size = new System.Drawing.Size(14, 13);
            this.b_decrease.TabIndex = 2;
            this.b_decrease.TabStop = true;
            this.b_decrease.Text = "◀";
            this.b_decrease.Click += new System.EventHandler(this.b_decrease_Click);
            // 
            // b_increase
            // 
            this.b_increase.AutoSize = true;
            this.b_increase.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.b_increase.Location = new System.Drawing.Point(343, 63);
            this.b_increase.Name = "b_increase";
            this.b_increase.Size = new System.Drawing.Size(14, 13);
            this.b_increase.TabIndex = 2;
            this.b_increase.TabStop = true;
            this.b_increase.Text = "▶";
            this.b_increase.Click += new System.EventHandler(this.b_increase_Click);
            // 
            // t_year
            // 
            this.t_year.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.t_year, 2);
            this.t_year.Location = new System.Drawing.Point(377, 63);
            this.t_year.Name = "t_year";
            this.t_year.Size = new System.Drawing.Size(41, 12);
            this.t_year.TabIndex = 3;
            this.t_year.Text = "2018年";
            // 
            // t_days
            // 
            this.t_days.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.t_days, 5);
            this.t_days.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.t_days.Location = new System.Drawing.Point(445, 63);
            this.t_days.Name = "t_days";
            this.t_days.Size = new System.Drawing.Size(128, 16);
            this.t_days.TabIndex = 4;
            this.t_days.Text = "9月19日（水曜日）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label4, 2);
            this.label4.Location = new System.Drawing.Point(309, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "店舗名";
            // 
            // d_tenpo
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.d_tenpo, 5);
            this.d_tenpo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.d_tenpo.FormattingEnabled = true;
            this.d_tenpo.Location = new System.Drawing.Point(411, 108);
            this.d_tenpo.Name = "d_tenpo";
            this.d_tenpo.Size = new System.Drawing.Size(164, 20);
            this.d_tenpo.TabIndex = 6;
            this.d_tenpo.SelectedIndexChanged += new System.EventHandler(this.d_tenpo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label5, 2);
            this.label5.Location = new System.Drawing.Point(309, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "スタッフ名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label6, 2);
            this.label6.Location = new System.Drawing.Point(309, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "開始時刻";
            // 
            // t_start_time
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.t_start_time, 2);
            this.t_start_time.Location = new System.Drawing.Point(411, 192);
            this.t_start_time.Name = "t_start_time";
            this.t_start_time.Size = new System.Drawing.Size(62, 19);
            this.t_start_time.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label7, 2);
            this.label7.Location = new System.Drawing.Point(309, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "終了時刻";
            // 
            // t_end_time
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.t_end_time, 2);
            this.t_end_time.Location = new System.Drawing.Point(411, 234);
            this.t_end_time.Name = "t_end_time";
            this.t_end_time.Size = new System.Drawing.Size(62, 19);
            this.t_end_time.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label8, 2);
            this.label8.Location = new System.Drawing.Point(309, 276);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "就業区分";
            // 
            // t_syugyoukubun
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.t_syugyoukubun, 3);
            this.t_syugyoukubun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_syugyoukubun.FormattingEnabled = true;
            this.t_syugyoukubun.Location = new System.Drawing.Point(411, 276);
            this.t_syugyoukubun.Name = "t_syugyoukubun";
            this.t_syugyoukubun.Size = new System.Drawing.Size(96, 20);
            this.t_syugyoukubun.TabIndex = 6;
            // 
            // d_staff
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.d_staff, 5);
            this.d_staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.d_staff.FormattingEnabled = true;
            this.d_staff.Location = new System.Drawing.Point(513, 150);
            this.d_staff.Name = "d_staff";
            this.d_staff.Size = new System.Drawing.Size(164, 20);
            this.d_staff.TabIndex = 6;
            this.d_staff.SelectedIndexChanged += new System.EventHandler(this.d_staff_SelectedIndexChanged);
            // 
            // d_staff_id
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.d_staff_id, 3);
            this.d_staff_id.Location = new System.Drawing.Point(411, 150);
            this.d_staff_id.Name = "d_staff_id";
            this.d_staff_id.Size = new System.Drawing.Size(86, 19);
            this.d_staff_id.TabIndex = 8;
            this.d_staff_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.d_staff_id_KeyDown);
            // 
            // b_regist
            // 
            this.b_regist.Location = new System.Drawing.Point(845, 671);
            this.b_regist.Name = "b_regist";
            this.b_regist.Size = new System.Drawing.Size(89, 23);
            this.b_regist.TabIndex = 1;
            this.b_regist.Text = "登録";
            this.b_regist.UseVisualStyleBackColor = true;
            this.b_regist.Click += new System.EventHandler(this.b_regist_Click);
            // 
            // b_return
            // 
            this.b_return.Location = new System.Drawing.Point(949, 671);
            this.b_return.Name = "b_return";
            this.b_return.Size = new System.Drawing.Size(89, 23);
            this.b_return.TabIndex = 1;
            this.b_return.Text = "戻る";
            this.b_return.UseVisualStyleBackColor = true;
            this.b_return.Click += new System.EventHandler(this.b_return_Click);
            // 
            // Staff_shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Staff_shift";
            this.Size = new System.Drawing.Size(1063, 721);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel b_decrease;
        private System.Windows.Forms.LinkLabel b_increase;
        private System.Windows.Forms.Label t_year;
        private System.Windows.Forms.Label t_days;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox d_tenpo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox d_staff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t_start_time;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox t_end_time;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox t_syugyoukubun;
        private System.Windows.Forms.Button b_regist;
        private System.Windows.Forms.Button b_return;
        private System.Windows.Forms.TextBox d_staff_id;
    }
}

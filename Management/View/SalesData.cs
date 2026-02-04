using Batch.Common;
using Management.Common;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class SalesData : Form
    {

        DateTime SaveFrom;
        DateTime SaveTo;
        List<string> SaveCategory = new List<string>();
        string SaveNumber;
        string SaveName;

        public SalesData()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「検索」ボタンの処理
        /// </summary>
        private void search_btn_Click(object sender, EventArgs e)
        {
            DateTime from = default;
            DateTime to = default;
            List<string> category = new List<string>();
            string number;
            string name;

            try
            {
                // 入力チェック
                string message = checkInput();
                if (string.IsNullOrEmpty(message) == false)
                {
                    MessageDialog.Warning("検索条件エラー", message);
                    return;
                }

                // 検索ボタン投下時
                if (sender == search_btn)
                {
                    // 開始年月
                    from = new DateTime(dtpStart.Value.Year, dtpStart.Value.Month, 1);

                    // 終了年月
                    to = new DateTime(dtpEnd.Value.Year, dtpEnd.Value.Month, 1);

                    // 商品分類
                    if (cbxFood.Checked) category.Add("001");
                    if (cbxEquipment.Checked) category.Add("002");
                    if (cbxLiving.Checked) category.Add("003");
                    if (cbxOther.Checked) category.Add("004");

                    // 商品番号
                    number = string.IsNullOrEmpty(ProductNumber_txt.Text) ? null : ProductNumber_txt.Text;

                    // 商品名
                    name = string.IsNullOrEmpty(ProductName_txt.Text) ? null : ProductName_txt.Text;

                    // 検索条件を保存
                    SaveFrom = from;
                    SaveTo = to;
                    SaveCategory = category;
                    SaveNumber = number;
                    SaveName = name;
                }
                else
                {
                    // 保存している検索条件をリセット
                    from = SaveFrom;
                    to = SaveTo;
                    category = SaveCategory;
                    number = SaveNumber;
                    name = SaveName;
                }

                // 売上データ取得
                DBUtil db = new DBUtil();
                List<List<string>> data = db.Select_Sales(from, to, category, number, name);

                // データグリッドビューに適用
                dgvResult.Rows.Clear();
                foreach (List<string> record in data)
                {
                    dgvResult.Rows.Add(record.ToArray());
                }

                // 更新ボタンを有効化
                update_btn.Enabled = true;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary> 「条件クリア」ボタンの処理</summary>
        private void clear_btn_Click(object sender, EventArgs e)
        {
            // 初期表示の状態に戻す
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
            foreach (CheckBox cbx in new CheckBox[] { cbxFood, cbxEquipment, cbxLiving, cbxOther })
            {
                cbx.Checked = true;
            }
            ProductNumber_txt.Text = string.Empty;
            ProductName_txt.Text = string.Empty;
        }

        /// <summary>「閉じる」ボタンの処理</summary>
        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>数値入力制御</summary>
        private void NumericalInputControl(object sender, KeyPressEventArgs e)
        {
            //バックスペース、Deleteキーが押された時は入力有効
            if (e.KeyChar == '\b')
            {
                return;
            }

            //数値0～9以外が押された時は入力無効
            if ((e.KeyChar < '0' || '9' < e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>検索条件チェック</summary>
        private string checkInput()
        {
            bool checkFlg;

            // 期間：相関チェック
            DateTime start = new DateTime(dtpStart.Value.Year, dtpStart.Value.Month, 1);
            DateTime end = new DateTime(dtpEnd.Value.Year, dtpEnd.Value.Month, 1);
            if (start > end)
            {
                return "開始年月が終了年月を過ぎています。";
            }

            // 商品分類：未選択チェック
            checkFlg = false;
            foreach (CheckBox cbx in new CheckBox[] { cbxFood, cbxEquipment, cbxLiving, cbxOther })
            {
                if (cbx.Checked == true)
                {
                    checkFlg = true;
                    break;
                }
            }
            if (checkFlg == false)
            {
                return "商品分類が未選択です。";
            }

            return string.Empty;
        }

        /// <summary>「更新」ボタンの処理</summary>
        private void update_btn_Click(object sender, EventArgs e)
        {
            // 検索ボタンの処理を呼ぶ
            search_btn_Click(sender, e);
        }

        /// <summary>「売上データ送信」ボタンの処理</summary>>
        private void data_btn_Click(object sender, EventArgs e)
        {

        }
    }
}

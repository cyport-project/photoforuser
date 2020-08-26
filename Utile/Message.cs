using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 写真館システム.Utile
{
    class Message
    {
        //public const Dictionary<string, string> message = new Dictionary<string, string>();

        public static readonly Dictionary<string, string>message = new Dictionary<string, string>(new Dictionary<string, string>()
        {
            /*　共通　*/
            {"W00000", "必須項目が未記入です"},
            {"W00001", "最大文字数（@桁数）を超えています"},
            {"W00002", "入力内容に制限文字以外の文字が使われています。有効文字列は<@有効文字列>"},
            {"W00003", "入力フォーマット（@フォーマット）に誤りがあります。"},
            {"W00004", "編集中の項目があります。@処理を続けてもよろしいですか。"},

            /* 写真選択 */
            {"I12000", "受付が未選択です\n受付を行ってください"},
            {"E12001", "カラーリストの更新に失敗しました"},
            {"E12002", "サムネイルリストの更新に失敗しました"},
            {"E12003", "写真のカラー添付に失敗しました"},
            {"W12004", "半角数字を入力してください"},

            /* 施設予約 */
            {"I03000", "受付が未選択です\n受付を行ってください"},
            {"W03001", "施設予約が見つかりません\n削除を中止しました"},
            {"I03001", "施設予約を登録しました"},
            {"I03003", "スケジュールを登録しました"},
            {"I03004", "施設予約を削除しました"},
            {"I03005", "スケジュールを削除しました"},
            {"I03006", "選択した施設予約に差し替えてもよろしいですか"},
            {"I03007", "受付未選択のため、施設予約できません"},
            {"I03008", "すでにフォルダが存在します"},
            {"I03009", "施設予約が重複しているため登録できません"},

            /* 顧客登録 */
            {"W09000", "顧客情報が登録されていないため、削除できません"},
            {"I09001", "顧客情報を登録しました"},
            {"I09002", "顧客情報を削除しました"},
            {"I09003", "家族情報に未入力項目があります"},
            {"I09004", "家族情報の誕生日の入力に誤りがあります"},
            {"I09005", "家族情報の性別の入力に誤りがあります"},
            
            /* 衣装マスタ */
            {"I15000", "変更が保存されていません\n変更を破棄して次の処理へ進みますか"},

            /* スタッフマスタ */
            {"E14000", "スタッフコードが重複しているため登録できません"},
            {"E14001", "登録時にエラーが発生しました"},

            /* 店舗マスタ */
            {"E13000", "削除時にエラーが発生しました"},
            {"E13001", "登録時にエラーが発生しました"},

            /* スタッフシフト */
            {"I11001", "スタッフのシフトを登録しました"},

            /* 衣装タイムテーブル */
            {"I05000", "予約する衣装が選択されていません"},
            {"I05001", "貸出する店舗が選択されていません"},
            {"I05002", "予約する期間の範囲指定がされていません"},
            {"I05003", "予約さてていない衣装が選択されました"},
            {"I05004", "選択範囲と衣装予約が重複しています"},

            /* Maim form */
            {"I99000", "背景が見つかりません"},


            {"", ""}
        });

        private static MessageBoxIcon getIcon(string id)
        {

            MessageBoxIcon icon = MessageBoxIcon.Hand;
            switch (id.Substring(0, 1))
            {
                case "I":
                    icon = MessageBoxIcon.Asterisk;
                    break;
                case "W":
                    icon = MessageBoxIcon.Exclamation;
                    break;
                case "E":
                    icon = MessageBoxIcon.Hand;
                    break;
            }
            return icon;
        }

        private static string gettitle(string id)
        {

            string title = "エラー";
            switch (id.Substring(0, 1))
            {
                case "I":
                    title = "情報";
                    break;
                case "W":
                    title = "警告";
                    break;
                case "E":
                    title = "エラー";
                    break;
            }
            return title;
        }

        public static DialogResult showMessageOKCancel(string id)
        {
            DialogResult result = MessageBox.Show(Utile.Message.message[id],
                                                    gettitle(id),
                                                    MessageBoxButtons.OKCancel,
                                                    getIcon(id),
                                                    MessageBoxDefaultButton.Button2);

            return result;
        }

        public static DialogResult showMessageOKCancel(string id, string msg)
        {
            DialogResult result = MessageBox.Show(msg,
                                                    gettitle(id),
                                                    MessageBoxButtons.OKCancel,
                                                    getIcon(id),
                                                    MessageBoxDefaultButton.Button2);

            return result;
        }

        public static DialogResult showMessageOK(string id)
        {
            DialogResult result = MessageBox.Show(Utile.Message.message[id],
                                                    gettitle(id),
                                                    MessageBoxButtons.OK,
                                                    getIcon(id),
                                                    MessageBoxDefaultButton.Button2);

            return result;
        }
        public static DialogResult showMessageOK(string id, string msg)
        {
            DialogResult result = MessageBox.Show(msg,
                                                    gettitle(id),
                                                    MessageBoxButtons.OK,
                                                    getIcon(id),
                                                    MessageBoxDefaultButton.Button2);

            return result;
        }
    }
}

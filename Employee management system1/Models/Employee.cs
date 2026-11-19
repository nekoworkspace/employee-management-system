// このファイルが属するグループ（名前空間）の定義
// プロジェクト内の「Models」フォルダに入っていることを表す
namespace Employee_management_system1.Models
{
    // 社員1人分のデータ構造（設計図）を定義するモデルクラス
    // 今後、データベースのテーブルや画面表示のデータの受け渡しに使う
    public class Employee
    {
        // 社員ID（番号）を保持するプロパティ
        // 「get; set;」は、値の読み取り（get）と書き込み（set）ができることを表す
        public int Id { get; set; }

        // 社員の名前を保持するプロパティ
        public string Name { get; set; }

        // 所属部署を保持するプロパティ
        public string Department { get; set; }
    }
}

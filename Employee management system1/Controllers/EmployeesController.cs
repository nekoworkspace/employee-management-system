// ASP.NET Core MVCの標準機能(ControllerやIActionResultなど)を使うための宣言
using Microsoft.AspNetCore.Mvc;
using Employee_management_system1.Models;

// このファイルが属するグループ(名前空間)の定義
namespace Employee_management_system.Controllers
{
    // 社員管理に関するリクエストを受け付けるコントローラークラス
    // URLが「/Employees/...」のときにこのクラスが呼び出される
    public class EmployeesController : Controller
    {
        // 「/Employees」または「/Employees/Index」にアクセスされたときに動く処理（アクション）
        public IActionResult Index()
        {
            // 画面に表示するための社員リスト（仮のデータ）を作成
            // ※本来はここでデータベース（DBサーバ）から社員情報を取得することが多い
            var employees = new List<Employee>()
            {
                new Employee
                {
                    Id = 1,
                    Name = "田中",
                    Department = "営業"
                },

                new Employee
                {
                    Id = 2,
                    Name = "山田",
                    Department = "開発"
                },

                new Employee
                {
                    Id = 3,
                    Name = "鈴木",
                    Department = "総務"
                }
            };

            // 作成した社員リスト（employees）をView（Index.cshtml）に渡してHTMLを生成し、ブラウザへ返す
            return View(employees);
        }
    }
}
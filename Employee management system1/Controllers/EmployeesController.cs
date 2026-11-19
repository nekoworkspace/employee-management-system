using Employee_management_system1.Data;     // データベース接続用クラス(ApplicationDbContext)を使うための宣言
using Employee_management_system1.Models;   // モデルクラス(Employeeなど)を使うための宣言
using Microsoft.AspNetCore.Mvc;             // ASP.NET Core MVCの標準機能(ControllerやIActionResultなど)を使うための宣言

// このファイルが属するグループ(名前空間)の定義
namespace Employee_management_system.Controllers
{
    // 社員管理に関するリクエストを受け付けるコントローラークラス
    // URLが「/Employees/...」のときにこのクラスが呼び出される
    public class EmployeesController : Controller
    {
        // データベースとやり取りするための窓口(コンテキスト)を保持する変数
        // readonlyにすることで、コンストラクタ以外からの意図しない書き換えを防ぐ 
        private readonly ApplicationDbContext _context;

        // コンストラクタ(このクラスが作られるときに最初に実行される処理)
        // DI(依存性の注入)によって、Program.csで登録したDB接続設定が自動的に渡される
        public EmployeesController(
            ApplicationDbContext context)
        {
            // 受け取ったDB接続用のインスタンスをクラス内の変数に保存する
            _context = context;
        }

        // 社員一覧画面を表示するためのアクションメソッド
        // URLが「/Employees」または「/Employees/Index」のときに呼び出される
        public IActionResult Index()
        {
            // データベースのEmployeesテーブルから全社員のデータを取得し、リスト形式に変換する
            var employees = _context.Employees.ToList();

            // 取得した社員リストを画面(Views/Employees/Index.cshtml)に渡して表示する
            return View(employees);
        }
    }
}
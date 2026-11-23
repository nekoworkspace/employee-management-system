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


        [HttpGet]
        // 登録画面表示（GET）
        public IActionResult Create()
        {
            // 登録画面(Views/Employees/Create.cshtml)を表示する
            return View();
        }

        [HttpPost]
        // 登録処理（POST）
        public IActionResult Create(Employee employee)
        {
            // 受け取った社員情報をデータベースに追加する
            _context.Employees.Add(employee);

            // 変更をデータベースに保存する
            _context.SaveChanges();

            // 登録後は社員一覧画面にリダイレクトする
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        // 編集画面表示（GET）
        public IActionResult Edit(int id)
        {
            // 指定されたIDの社員情報をデータベースから取得する
            var employee = _context.Employees.Find(id);

            // もし社員情報が見つからなければ、404 Not Foundを返す
            if (employee == null)
            {
                // NotFound()は404エラーを返すASP.NET Core MVCの標準メソッド
                return NotFound();
            }

            // 取得した社員情報を編集画面(Views/Employees/Edit.cshtml)に渡して表示する
            return View(employee);
        }

        [HttpPost]
        // 編集処理（POST）
        public IActionResult Edit(Employee employee)
        {
            // 受け取った社員情報をデータベースに更新する
            _context.Employees.Update(employee);
            // 変更をデータベースに保存する
            _context.SaveChanges();

            // 編集後は社員一覧画面にリダイレクトする
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        // 削除画面表示（GET）
        public IActionResult Delete(int id)
        {
            // 指定されたIDの社員情報をデータベースから取得する
            var employee = _context.Employees.Find(id);

            // もし社員情報が見つからなければ、404 Not Foundを返す
            if (employee == null)
            {
                // NotFound()は404エラーを返すASP.NET Core MVCの標準メソッド
                return NotFound();
            }

            // 削除後は社員一覧画面にリダイレクトする
            return View(employee);
        }

        [HttpPost]
        // 削除処理（POST）
        public IActionResult Delete(Employee employee)
        {
            // 受け取った社員情報をデータベースから削除する
            _context.Employees.Remove(employee);

            // 変更をデータベースに保存する
            _context.SaveChanges();
            
            // 削除後は社員一覧画面にリダイレクトする
            return RedirectToAction(nameof(Index));
        }
    }
}
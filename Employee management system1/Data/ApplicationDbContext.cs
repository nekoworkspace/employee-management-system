using Employee_management_system1.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_management_system1.Data
{
    // SQL Server との接続処理
    public class ApplicationDbContext : DbContext
    {
        // コンストラクタ（クラスの初期化処理）
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        // データベースの「Employees」テーブルに対応するプロパティ
        public DbSet<Employee> Employees { get; set; }
    }
}

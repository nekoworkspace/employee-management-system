// DBコンテキストやEntity Framework Coreを使うための宣言
using Employee_management_system1.Data;
using Microsoft.EntityFrameworkCore;

// webアプリケーションのビルダー（設定やサービスを組み立てる土台）を作成する
var builder = WebApplication.CreateBuilder(args);

// SQL Server を使用するDBコンテキスト（ApplicationDbContext）をDIコンテナに登録する
// appsettings.json内の「DefaultConnection」という接続文字列を使用する
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// DIコンテナにサービスを追加する（MVCのコントローラーとビューの機能を有効化）
builder.Services.AddControllersWithViews();

// 設定した内容をもとにwebアプリケーションのインスタンスを構築する
var app = builder.Build();

// HTTPリクエストのパイプライン（通信処理の流れ）を構成する
// 開発環境（Development）以外（本番環境など）の場合の設定
if (!app.Environment.IsDevelopment())
{
    // エラー発生時に指定のエラーページ（/Home/Error）にリダイレクトする
    app.UseExceptionHandler("/Home/Error");
    // HSTS（HTTPS通信を強制するセキュリティ機能）のデフォルト値は30日間です。
    // 本番環境のシナリオに合わせて変更する場合は https://aka.ms/aspnetcore-hsts を参照してください。
    app.UseHsts();
}

// HTTPリクエストを自動的にHTTPSにリダイレクトする
app.UseHttpsRedirection();
// URLから適切な処理先を振り分けるルーティング機能を有効にする
app.UseRouting();
// ユーザーのアクセス権限を確認する認可機能を有効にする
app.UseAuthorization();
// CSSやJavaScript、画像などの静的アセットのマッピングを行う
app.MapStaticAssets();
// コントローラーのデフォルトのURLルーティング規則を設定し、静的アセットと紐づける
// 例：URLが「/」の場合は HomeController の Index アクションが呼ばれる（idは省略可能）
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

// アプリケーションを起動し、HTTPリクエストの待ち受けを開始する
app.Run();

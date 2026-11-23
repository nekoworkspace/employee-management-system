# Employee Management System

ASP.NET Core MVC の学習用として作成した社員管理システムです。

CRUD（Create, Read, Update, Delete）の基本機能を実装しながら、
C#、ASP.NET Core MVC、SQL Server、Entity Framework Core の学習を行っています。

---

## 画面イメージ

<img width="1203" height="323" alt="Index" src="https://github.com/user-attachments/assets/6385dfc3-70b7-4a61-ac04-0d3173ddaf0f" />

---

## 使用技術

- C#
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Visual Studio

---

## 主な機能

### 社員一覧

登録されている社員情報を一覧表示します。

<img width="735" height="403" alt="image" src="https://github.com/user-attachments/assets/ba5e4ef3-6cba-4fae-b4a5-bbce75b848ed" />

### 社員登録

新しい社員を登録できます。

<img width="696" height="360" alt="Create" src="https://github.com/user-attachments/assets/5b83a89a-3645-468e-9b5a-caf5e6163ee3" />

### 社員編集

登録済み社員の情報を編集できます。

<img width="675" height="396" alt="Edit" src="https://github.com/user-attachments/assets/a5de380d-3d25-4048-beb0-a5aefb99dc1f" />

### 社員削除

不要になった社員情報を削除できます。

<img width="698" height="436" alt="Delete" src="https://github.com/user-attachments/assets/be42b28f-f354-4d60-a608-4c7e6e85d8e7" />

---

## データベース

テーブル名

```sql
Employees
```

主な項目

| 項目 | 型 |
| --- | --- |
| Id | int |
| Name | nvarchar |
| Department | nvarchar |

サンプルデータ

- 田中（営業）
- 山田（開発）
- 鈴木（総務）

---

## 学習内容

このプロジェクトでは以下を学習しています。

- MVCアーキテクチャ
- Razor View
- Model
- Controller
- Entity Framework Core
- SQL Server連携
- CRUD処理
- バリデーション

---

## 今後追加予定

- ログイン機能
- 検索機能
- ページング機能
- ソート機能
- BootstrapによるUI改善

---

## 開発環境

| 項目 | 内容 |
| --- | --- |
| OS | Windows |
| IDE | Visual Studio 2022 |
| Framework | .NET |
| Database | SQL Server |

---

## 作成目的

ASP.NET Core MVC の学習を目的として作成しています。

単なるチュートリアルではなく、
機能追加や改善を行いながら実践的な開発経験を積むことを目標としています。

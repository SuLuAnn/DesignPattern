# MVC

定義 : Model-View-Controller 一種被廣泛使用的複合模式

---

### MVC 三者定義 : 
- Model : 保存所有資料、狀態與應用程式邏輯。View 和 Controller 無視 Model 的存在，不過 Model
提供一個介面來操作與取得狀態，也可以將狀態的改變通知觀察者。
- View : 提供 Model 的外觀。View 通常直接從 Model 取得顯示所需的狀態與資料。
- Controller : 取得使用者輸入，並解讀它對 Model 而言是什麼意思。

### MVC 如何互動
- View 通知 Controller 使用者做某件事
- Controller 解讀使用者的動作，確認意思，並操作 Model
- Controller 通知 解讀使用者的動作，要求 View 改變
- Model 通知 View 狀態改變了
- View 向 Model 詢問狀態

### MVC 中的設計模式
- Model 使用觀察者模式讓 View 及 Controller 註冊
- Controller 是 View 的策略，想改變行為時，可以換使用的 View
- View 本身使用組合模式控制畫面元件，只需告訴最上層的元件更新，下面會一起更新

※ MVC 有很多修改版
# 責任鍊模式(Chain of Responsibility)

定義 : 針對一個處理的請求，在一連串由不同節點組成的流程中，每一個節點可以決定是否進行處理、
傳遞給下一個節點或判斷不需要往下處理而駁回請求，請求最多只會被一個節點處理，也有可能沒被處
理

---

優點 : 
- 符合單一職責原則
- 方便調整組合順序與新增組合

缺點 :
- 檔案數量很多

實作 :
* [共同介面](IHandler.cs)，會包含設定下一個 Handler 及實際運行的方法
* [Handler 的抽象類別](BaseHandler.cs)，非必要，放所有 Handler 可共用的東西
* [被處理的請求](CustomerComplaintTask.cs)，Handler 實際運行時傳遞的資料
* [實際處理的 Handler](GeneralHandler.cs、AsiaCustomerHandler.cs、EngineerCustomerHandler.cs)
* [客戶端](Client.cs)，使用責任鍊的地方


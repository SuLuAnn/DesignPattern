# 觀察者模式(Observer)

定義 : 當一個物件改變狀態時，訂閱它的物件會收到通知

---

特點 : 
- 開放封閉原則
- 有從 Subject 推送資料及由觀察者取資料兩種(一般推送比較正統)

問題 :
- 通知順序是隨機的

實作 :
* [被觀察的對象](ISubject.cs)
* [被觀察對象的實作](WeatherData.cs)
* [觀察者](IObserver.cs)
* [觀察者的實作](MainDisplay.cs、SecondDisplay.cs)
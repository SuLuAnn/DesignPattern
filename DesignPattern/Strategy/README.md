# 策略模式(Strategy)

定義 : 封裝演算法，並讓它可以彼此替換

---

好處 : 
- 演算法的修改不會影響用戶端
- 擴展性好
- 演算法切換自由

問題 : 
- 策略的類數量很多
- 用戶端需知道各個策略的不同

實作 :
* [用戶端](GoogleMap.cs)
* [策略的共同介面](IPathCaculate.cs)
* [不同策略](Foot.cs、Car.cs)
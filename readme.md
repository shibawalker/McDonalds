請設計一個Console程式，讓顧客可以點速食。

首先確認使用者要【內用】或【外帶】
定義兩個新的類別Food(餐點)和OrderItem(訂單項目)；Food是餐點品項，OrderItem是每一筆訂單之個別項目，都使用List類別來呈現。
餐點品項價格如下(套餐與單點)，每種品項均可點不同份數，要驗證使用者是否輸入錯誤。
大麥克漢堡 150 90

麥香雞漢堡 140 75

雙層牛肉堡 160 100

訂購金額不論多寡均可得到10%的回饋點數1點(以未折扣前之總金額去除小數點計算)；此外訂購滿500元以上者9折，1000元以上者85折。
於訂購過程中，隨時按下x鍵均可離開程式。完成後顯示顧客所點的品項內容，以及此次訂購的回饋點數與所需付款金額(四捨五入計算)。

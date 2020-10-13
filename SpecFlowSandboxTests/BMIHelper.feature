Feature: BMIHelper
	In order to 避免錯誤計算
	As 當一個計算BMI計算器
	輸入身高與體重，會跟你說BMI的提示

@BMIHelper 輸入我的身高體重來取得BMI提示
Scenario: 輸入我的身高體重來取得BMI提示
	Given 輸入身高 172.0
	And 輸入體重 70.0
	When 經過BMI計算
	Then 結果應該是正常

@BMIHelper 輸下列資料來取得BMI提示
Scenario: 輸入下列身高體重來取得BMI提示
	Given 輸入身高體重
		| Height | Weight |
		| 164    |    55    |
		| 180    |    65    |
	When 經過BMI計算
	Then 結果應該是正常
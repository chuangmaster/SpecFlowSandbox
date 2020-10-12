Feature: Datetimehelper 
	In order to 判斷錯誤
	As 沒有時間概念的人
	我想知道這一天是不是聖誕夜

@Datetimehelper
Scenario: 判斷今天是聖誕夜(寫法1)
	Given 如果今天是 12/24
	When 當IsChristmasEve被執行
	Then 結果應該是 true 表示今天是聖誕夜

@Datetimehelper by Table one data
Scenario: 判斷今天是聖誕夜(寫法2)
	Given 如果是下情形:
	| pDate |
	| 12/24 |
	When 當IsChristmasEve被執行
	Then 結果應該是 true 表示今天是聖誕夜

@Datetimehelper by Table multiple data
Scenario: 判斷今天是聖誕夜(寫法3)
	Given 如果是以下幾種情形:
	| pDate |
	| 12/24 |
	| 2020/12/24 |
	| 2020.12.24 |
	When 當IsChristmasEve被執行
	Then 結果應該是 true 表示今天是聖誕夜
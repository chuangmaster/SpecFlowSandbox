using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlowSandbox;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowSandboxTests
{
    [Binding]
    public class DatetimehelperSteps
    {
        private DateTimeHelper _Sut;

        [BeforeScenario]
        private void Init()
        {
            _Sut = new DateTimeHelper();
        }

        [Given(@"如果今天是 (.*)")]
        public void Given如果今天是(string p0)
        {
            ScenarioContext.Current.Set<DateTime>(DateTime.Parse(p0), "pDate");
        }

        [When(@"當IsChristmasEve被執行")]
        public void When當IsChristmasEve被執行()
        {
            var date = ScenarioContext.Current.Get<DateTime>("pDate");
            bool actual = _Sut.IsChristmasEve(date);
            ScenarioContext.Current.Set<bool>(actual);

        }

        [Then(@"結果應該是 true 表示今天是聖誕夜")]
        public void Then結果應該是True表示今天是聖誕夜()
        {
            //取得上一步 result 計算的結果
            var actual = ScenarioContext.Current.Get<bool>();
            //驗證計算結果是否合乎預期
            Assert.AreEqual(true, actual);
        }




        [Given(@"如果是下情形:")]
        public void Given如果是下情形(Table table)
        {
            var data = table.CreateInstance<TestDateData>();
            ScenarioContext.Current.Set<DateTime>(DateTime.Parse(data.pDate), "pDate");
        }
        public class TestDateData
        {
            public string pDate { get; set; }
        }
        [Given(@"如果是以下幾種情形:")]
        public void Given如果是以下幾種情形(Table table)
        {
            var temp = table.CreateSet<TestDateData>();

            foreach (var data in temp)
            {
                ScenarioContext.Current.Set<DateTime>(DateTime.Parse(data.pDate), "pDate");
            }

        }
    }
}

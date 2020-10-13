using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlowSandbox;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowSandboxTests
{
    [Binding]
    public class BMIHelperSteps
    {
        private BMIHelper _Sut;
        [BeforeScenario()]
        public void Init()
        {
            _Sut = new BMIHelper();
        }

        [Given(@"輸入身高 (.*)")]
        public void Given輸入身高(Decimal p0)
        {
            ScenarioContext.Current.Set<float>(Convert.ToSingle(p0), "Height");
        }

        [Given(@"輸入體重 (.*)")]
        public void Given輸入體重KG(Decimal p0)
        {
            ScenarioContext.Current.Set<float>(Convert.ToSingle(p0), "Weight");
        }

        [When(@"經過BMI計算")]
        public void When經過BMI計算()
        {
            var Height = ScenarioContext.Current.Get<float>("Height");
            var Weight = ScenarioContext.Current.Get<float>("Weight");
            var actual = _Sut.GetBMIHint(Height, Weight);
            ScenarioContext.Current.Set<string>(actual, "actual");
        }

        [Then(@"結果應該是正常")]
        public void Then結果應該是正常()
        {
            //取得上一步 result 計算的結果
            var actual = ScenarioContext.Current.Get<string>("actual");
            //驗證計算結果是否合乎預期
            Assert.AreEqual("正常", actual);

        }

        public class BMIData
        {
            public decimal Height { get; set; }

            public decimal Weight { get; set; }

        }
        [Given(@"輸入身高體重")]
        public void Given輸入身高體重(Table table)
        {
            var data = table.CreateSet<BMIData>();
            foreach (var item in data)
            {
                ScenarioContext.Current.Set<float>(Convert.ToSingle(item.Height), "Height");
                ScenarioContext.Current.Set<float>(Convert.ToSingle(item.Weight), "Weight");
            }
        }

    }
}

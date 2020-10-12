using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlowSandbox;
using TechTalk.SpecFlow;

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
            ScenarioContext.Current.Set<float>(Convert.ToSingle(p0), "centimeter");
        }

        [Given(@"輸入體重 (.*)")]
        public void Given輸入體重KG(Decimal p0)
        {
            ScenarioContext.Current.Set<float>(Convert.ToSingle(p0), "kilogram");
        }

        [When(@"經過BMI計算")]
        public void When經過BMI計算()
        {
            var centimeter = ScenarioContext.Current.Get<float>("centimeter");
            var kilogram = ScenarioContext.Current.Get<float>("kilogram");
            var actual = _Sut.GetBMIHint(centimeter, kilogram);
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

    }
}

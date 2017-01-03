using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc;
using NUnit.Framework;

namespace TestLib
{
    public class Class1
    {
       [Test]
       public void Result_SumOf5and10_15()
        {
            Calc.Operation calc = new Calc.Operation();
            var sum = calc.Sum("5","10");
            Assert.AreEqual(15,sum);

        }
         [Test]
       public void Result_SumOf3and2_5()
       {
           Calc.Operation calc = new Calc.Operation();
           var sum = calc.Sum("3", "2");
           Assert.AreEqual(5, sum);

       }
         [Test]
       public void Result_SumOf100and100_200()
       {
           Calc.Operation calc = new Calc.Operation();
           var sum = calc.Sum("100", "100");
           Assert.AreEqual(200, sum);

       }
         [Test]
       public void Result_RazOf50and10_40()
       {
           Calc.Operation calc = new Calc.Operation();
           var sum = calc.Raz("50", "10");
           Assert.AreEqual(40, sum);

       }
         [Test]
       public void Result_RazOf30and3_27()
       {
           Calc.Operation calc = new Calc.Operation();
           var sum = calc.Raz("30", "3");
           Assert.AreEqual(27, sum);

       }
        [Test]
       public void Result_RazOf16and4_12()
       {
           Calc.Operation calc = new Calc.Operation();
           var sum = calc.Raz("16", "4");
           Assert.AreEqual(12, sum);

       }
         [Test]
       public void Result_DelenieOf16and4_4()
       {
           Calc.Operation calc = new Calc.Operation();
           var sum = calc.Del("16", "4");
           Assert.AreEqual(4, sum);

       }
         [Test]
       public void Result_DelenieOf100and10_10()
       {
           Calc.Operation calc = new Calc.Operation();
           var sum = calc.Del("100", "10");
           Assert.AreEqual(10, sum);

       }
         [Test]
       public void Result_DelenieOf25and10_5()
       {
           Calc.Operation calc = new Calc.Operation();
           var sum = calc.Del("25", "5");
           Assert.AreEqual(5, sum);

       }
         [Test]
       public void Result_YmnojenieOf3and4_12()
       {
           Calc.Operation calc = new Calc.Operation();
           var sum = calc.Ymn("3", "4");
           Assert.AreEqual(12, sum);

       }
         [Test]
       public void Result_YmnojenieOf15and2_30()
       {
           Calc.Operation calc = new Calc.Operation();
           var sum = calc.Ymn("15", "2");
           Assert.AreEqual(30, sum);

       }
         [Test]
       public void Result_YmnojenieOf6and6_36()
       {
           Calc.Operation calc = new Calc.Operation();
           var sum = calc.Ymn("6", "6");
           Assert.AreEqual(37, sum);

       }
    }
}

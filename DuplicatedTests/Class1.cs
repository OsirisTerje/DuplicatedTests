using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DuplicatedTests
{

    public enum Season
    {
        Winter, Spring, Summer, Autoumn
    }

   
    public class SUT
    {
        [TestCase(Season.Winter,true)]
        public void ThatEnumsWorks(Season season,bool expected )
        {
            Assert.That(expected);
        }


        [TestCase(1, true)]
        public void ThatIntsWorks(int whatever, bool expected)
        {
            Assert.That(expected);
        }
    }
}

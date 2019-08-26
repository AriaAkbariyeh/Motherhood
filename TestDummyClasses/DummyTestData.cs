using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TestDummyClasses
{
    public class DummyTestData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(1, 1);
                yield return new TestCaseData(2, 2);
                yield return new TestCaseData(3, 4);
            }
        }
    }
}

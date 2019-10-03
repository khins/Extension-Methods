using ExtensionMethods.Library;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Tests
{
    class TargetTests
    {
        [Test]
        public void StandardizedId()
        {
            // returns to lower on purpose to show failing test
            var obj = new Target("id01");
             Assert.AreEqual("ID01", obj.GetStandardizedId());
        }
    }
}

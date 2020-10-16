using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void NoBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launchcode"));
        }

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void OnlyBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        [TestMethod]
        public void BracketsWordsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }

        [TestMethod]
        public void BracketsWordsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]LaunchCode["));
        }

        [TestMethod]
        public void BracketsWordsAfterReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }

        [TestMethod]
        public void BracketsWordsAfterReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("][LaunchCode"));
        }

        [TestMethod]
        public void BracketsWordsSplitReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Launch]Code"));
        }

        [TestMethod]
        public void BracketWordsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Laun]"));
        }

        [TestMethod]
        public void OutwardBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void OutwardBracketsWordsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }

        [TestMethod]
        public void OutwardBracketsAllReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]][][[]"));
        }


        [TestMethod]
        public void MixedBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("launc[hc[od]e]"));
        }

        [TestMethod]
        public void MixedBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("launc]hc[od]e["));
        }



    }
}

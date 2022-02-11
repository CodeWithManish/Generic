using MaximumNumber;
using NUnit.Framework;

namespace TestMaximum
{
    public class Tests
    {
        FindMaxNumber findMaxNumber = new FindMaxNumber();

        [Test]
        public void GivenIntegerValuesFirstPosition_whenCheck_ShouldReturnMaxNum()
        {
            int max = findMaxNumber.FindMaxValueOfThree(1, 2, 3);
            Assert.AreEqual(3, max);
        }

        [Test]
        public void GivenIntegerValuesSecondPosition_whenCheck_ShouldReturnMaxNum()
        {
            int max = findMaxNumber.FindMaxValueOfThree(2, 3, 1);
            Assert.AreEqual(3, max);
        }

        [Test]
        public void GivenIntegerValuesThirdPosition_whenCheck_ShouldReturnMaxNum()
        {
            int max = findMaxNumber.FindMaxValueOfThree(3, 2, 1);
            Assert.AreEqual(3, max);
        }

      

       

    }
}
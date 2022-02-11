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

        //for Float Number
        public void GivenFloatValuesFirstPosition_whenCheck_ShouldReturnMaxNum()
        {
            float max = findMaxNumber.FloatMaxValueOfThree(1.2f, 2.1f, 3.0f);
            Assert.AreEqual(3.0, max);
        }

        [Test]
        public void GivenFloatValuesSecondPosition_whenCheck_ShouldReturnMaxNum()
        {
            float max = findMaxNumber.FloatMaxValueOfThree(2.1f, 3.0f, 1.2f);
            Assert.AreEqual(3.0, max);
        }

        [Test]
        public void GivenFloatValuesThirdPosition_whenCheck_ShouldReturnMaxNum()
        {
            float max = findMaxNumber.FloatMaxValueOfThree(3.0f, 2.1f, 1.2f);
            Assert.AreEqual(3.0, max);
        }




    }
}
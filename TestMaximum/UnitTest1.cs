using MaximumNumber;
using NUnit.Framework;

namespace TestMaximum
{
    public class Tests
    {
        FindMaxNumber<int> findMax=new FindMaxNumber<int>();
        FindMaxNumber<float> findMax2 = new FindMaxNumber<float>();
        FindMaxNumber<string> findMax3 = new FindMaxNumber<string>();

        [Test]
        public void GivenIntegerValuesFirstPosition_whenCheck_ShouldReturnMaxNum()
        {
            int max = findMax.FindMaxValueOfThree(1, 2, 3);
            Assert.AreEqual(3, max);
        }

        [Test]
        public void GivenIntegerValuesSecondPosition_whenCheck_ShouldReturnMaxNum()
        {
            int max = findMax.FindMaxValueOfThree(2, 3, 1);
            Assert.AreEqual(3, max);
        }

        [Test]
        public void GivenIntegerValuesThirdPosition_whenCheck_ShouldReturnMaxNum()
        {
            int max = findMax.FindMaxValueOfThree(3, 2, 1);
            Assert.AreEqual(3, max);
        }

        //for Float Number
               
        [Test]
        public void GivenFloatValuesFirstPosition_whenCheck_ShouldReturnMaxNum()
        {
            float max = findMax2.FloatMaxValueOfThree(3.0f, 1.2f, 2.1f);
            Assert.AreEqual(3.0, max);
        }

        [Test]
        public void GivenFloatValuesSecondPosition_whenCheck_ShouldReturnMaxNum()
        {
            float max = findMax2.FloatMaxValueOfThree(2.1f, 3.0f, 1.2f);
            Assert.AreEqual(3.0, max);
        }

        [Test]
        public void GivenFloatValuesThirdPosition_whenCheck_ShouldReturnMaxNum()
        {
            float max = findMax2.FloatMaxValueOfThree(3.0f, 2.1f, 1.2f);
            Assert.AreEqual(3.0, max);
        }

        /*For String */
               
        [Test]
        public void GivenStringValuesFirstPosition_whenCheck_ShouldReturnMaxString()
        {
            string max = findMax3.StringMaxValueOfThree("Peach", "Apple", "Banana");
            Assert.AreEqual("Peach", max);
        }
        [Test]
        public void GivenStringValuesSecondPosition_whenCheck_ShouldReturnMaxString()
        {
            string max = findMax3.StringMaxValueOfThree("Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", max);
        }
        [Test]
        public void GivenStringValuesThirdPosition_whenCheck_ShouldReturnMaxString()
        {
            string max = findMax3.StringMaxValueOfThree("Apple", "Banana", "Peach");
            Assert.AreEqual("Peach", max);
        }




    }
}
using System.Runtime.InteropServices;
using VideoApp;

namespace VideoAppTests
{
    [TestClass]
    public class ResizeAppTests
    {
        [TestMethod]
        public void ResizeIntArrAdd()
        {
            //arrange
            int[] IntArray = { 1, 2, 3, 4, 5, 6, 7 };
            
            //act
            ResizeApp.Resize(ref IntArray, 20);
        
            //assert
            Assert.AreEqual(20, IntArray.Length);
        }

        [TestMethod]
        public void ResizeIntArrSubstract()
        {
            //arrange
            int[] IntArray = { 1, 2, 3, 4, 5, 6, 7 };
            
            //act
            ResizeApp.Resize(ref IntArray, 3);
        
            //assert
            Assert.AreEqual(3, IntArray.Length);
        }

        [TestMethod]
        public void ResizeStrArrAdd()
        {
            //arrange
            string[] StringArray = { "Hello", "World!", "Rashid", "Clown" };
            
            //act
            ResizeApp.Resize(ref StringArray, 20);
        
            //assert
            Assert.AreEqual(20, StringArray.Length);
        }

        [TestMethod]
        public void ResizeStrArrSubstract()
        {
            //arrange
            string[] StringArray = { "Hello", "World!", "Rashid", "Clown" };

            //act
            ResizeApp.Resize(ref StringArray, 2);

            //assert
            Assert.AreEqual(2, StringArray.Length);
        }

        public void ResizeDoubleArrAdd()
        {
            //arrange
            double[] DoubleArray = { -1.5, 3, 5.5, 6.5 };

            //act
            ResizeApp.Resize(ref DoubleArray, 20);

            //assert
            Assert.AreEqual(20, DoubleArray.Length);
        }

        [TestMethod]
        public void ResizeDoubleArrSubstract()
        {
            //arrange
            double[] DoubleArray = {-1.5, 3, 5.5, 6.5};

            //act
            ResizeApp.Resize(ref DoubleArray, 2);

            //assert
            Assert.AreEqual(2, DoubleArray.Length);
        }

        [TestMethod]
        public void ResizeSubstract_AmountLessThanZero_Throws()
        {
            //arrange
            int[] IntArray = { 1, 2, 3, 4, 5, 6, 7 };

            //act and assert
            Assert.ThrowsException<System.OverflowException>(() => ResizeApp.Resize(ref IntArray, -1));
        }
    }
}
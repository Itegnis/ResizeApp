using System.Runtime.InteropServices;
using VideoApp;

namespace VideoAppTests
{
    [TestClass]
    public class ResizeAppTests
    {
        [TestMethod]
        public void ResizeResultCheck()
        {
            //arrange
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7 };
            int[] beforeProc = { 1, 2, 3, 4, 5, 6, 7, 0};

            //act
            ResizeApp.Resize(ref intArray, 8);

            //assert
            CollectionAssert.AreEqual(beforeProc, intArray);
        }

        [TestMethod]
        public void ResizeIntArrAdd()
        {
            //arrange
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7 };
            
            //act
            ResizeApp.Resize(ref intArray, 20);
        
            //assert
            Assert.AreEqual(20, intArray.Length);
        }

        [TestMethod]
        public void ResizeIntArrSubstract()
        {
            //arrange
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7 };
            
            //act
            ResizeApp.Resize(ref intArray, 3);
        
            //assert
            Assert.AreEqual(3, intArray.Length);
        }

        [TestMethod]
        public void ResizeStrArrAdd()
        {
            //arrange
            string[] stringArray = { "Hello", "World!", "Rashid", "Clown" };
            
            //act
            ResizeApp.Resize(ref stringArray, 20);
        
            //assert
            Assert.AreEqual(20, stringArray.Length);
        }

        [TestMethod]
        public void ResizeStrArrSubstract()
        {
            //arrange
            string[] stringArray = { "Hello", "World!", "Rashid", "Clown" };

            //act
            ResizeApp.Resize(ref stringArray, 2);

            //assert
            Assert.AreEqual(2, stringArray.Length);
        }

        public void ResizeDoubleArrAdd()
        {
            //arrange
            double[] doubleArray = { -1.5, 3, 5.5, 6.5 };

            //act
            ResizeApp.Resize(ref doubleArray, 20);

            //assert
            Assert.AreEqual(20, doubleArray.Length);
        }

        [TestMethod]
        public void ResizeDoubleArrSubstract()
        {
            //arrange
            double[] doubleArray = {-1.5, 3, 5.5, 6.5};

            //act
            ResizeApp.Resize(ref doubleArray, 2);

            //assert
            Assert.AreEqual(2, doubleArray.Length);
        }

        [TestMethod]
        public void ResizeSubstract_AmountLessThanZero_Throws()
        {
            //arrange
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7 };

            //act and assert
            Assert.ThrowsException<System.OverflowException>(() => ResizeApp.Resize(ref intArray, -1));
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;

namespace CalculationUnitTests
{
    [TestClass]
    public class CalculattionTests
    {
        [TestMethod]
        public void GetQuantityForProduct_CheckingFirstProductAndFirstMaterial_Successfully()
        {
            // Arrange
            int productType = 1; // product type = 1
            int materialType = 1; // material type = 1
            int countProduct = 15; // product's count = 15
            float width = 20;
            float lenth = 45;
            Calculation calculation = new Calculation();
            int expected = 14895;
                                    
            // Act
            calculation.GetQuantityForProduct(productType, materialType, countProduct, width, lenth);

            // Assert
            int actual = calculation.CountProduct;
            Assert.AreEqual(expected, actual, 1, "The number of products is incorrect");
        }

        [TestMethod]
        public void GetQuantityForProduct_CheckingSecondProductAndFirstMaterial_Successfully()
        {
            // Arrange
            int productType = 2; // product type = 2
            int materialType = 1; // material type = 1
            int countProduct = 15; // product's count = 15
            float width = 20;
            float lenth = 45;
            Calculation calculation = new Calculation();
            int expected = 33852;

            // Act
            calculation.GetQuantityForProduct(productType, materialType, countProduct, width, lenth);

            // Assert
            int actual = calculation.CountProduct;
            Assert.AreEqual(expected, actual, 1, "The number of products is incorrect");
        }

        [TestMethod]
        public void GetQuantityForProduct_CheckingThirdProductAndFirstMaterial_Successfully()
        {
            // Arrange
            int productType = 3; // product type = 3
            int materialType = 1; // material type = 1
            int countProduct = 15; // product's count = 15
            float width = 20;
            float lenth = 45;
            Calculation calculation = new Calculation();
            int expected = 114147;

            // Act
            calculation.GetQuantityForProduct(productType, materialType, countProduct, width, lenth);

            // Assert
            int actual = calculation.CountProduct;
            Assert.AreEqual(expected, actual, 1, "The number of products is incorrect");
        }

        [TestMethod]
        public void GetQuantityForProduct_CheckingThirdProductAndSecondMaterial_Successfully()
        {
            // Arrange
            int productType = 3; // product type = 3
            int materialType = 2; // material type = 1
            int countProduct = 15; // product's count = 15
            float width = 20;
            float lenth = 45;
            Calculation calculation = new Calculation();
            int expected = 113942;

            // Act
            calculation.GetQuantityForProduct(productType, materialType, countProduct, width, lenth);

            // Assert
            int actual = calculation.CountProduct;
            Assert.AreEqual(expected, actual, 1, "The number of products is incorrect");
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductType_ShowThrowArgumentOutOfRange()
        {
            // Arrange                 
            int productType = 4; // product type = 4
            int materialType = 1; // material type = 1
            int countProduct = 15; // product's count = 15
            float width = 20;
            float lenth = 45;
            Calculation calculation = new Calculation();

            // action and Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => 
            calculation.GetQuantityForProduct(productType, materialType, countProduct, width, lenth));
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentMaterialType_ShowThrowArgumentOutOfRange()
        {
            // Arrange
            int productType = 3; // product type = 3
            int materialType = 3; // material type = = 3
            int countProduct = 15; // product's count = 15
            float width = 20;
            float lenth = 45;
            Calculation calculation = new Calculation();

            // action and Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => 
            calculation.GetQuantityForProduct(productType, materialType, countProduct, width, lenth));
        }

        [TestMethod]
        public void GetQuantityForProduct_CountProductLessZero_ShowThrowArgumentOutOfRange()
        {
            // Arrange
            int productType = 3; // product type = 3
            int materialType = 1; // material type = = 1
            int countProduct = -1; // product's count = 15
            float width = 20;
            float lenth = 45;
            Calculation calculation = new Calculation();

            // action and Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => 
            calculation.GetQuantityForProduct(productType, materialType, countProduct, width, lenth));
        }

        [TestMethod]
        public void GetQuantityForProduct_CountProductEqualsZero_ShowThrowArgumentOutOfRange()
        {
            // Arrange
            int productType = 3; // product type = 3
            int materialType = 1; // material type = = 1
            int countProduct = 0; // product's count = 0
            float width = 20;
            float lenth = 45;
            Calculation calculation = new Calculation();

            // action and Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => 
            calculation.GetQuantityForProduct(productType, materialType, countProduct, width, lenth));
        }

        [TestMethod]
        public void GetQuantityForProduct_WidthProductLessZero_ShowThrowArgumentOutOfRange()
        {
            // Arrange
            int productType = 3; // product type = 3
            int materialType = 1; // material type = = 1
            int countProduct = 15; // product's count = 15
            float width = -20;
            float lenth = 45;
            Calculation calculation = new Calculation();

            // action and Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => 
            calculation.GetQuantityForProduct(productType, materialType, countProduct, width, lenth));
        }

        [TestMethod]
        public void GetQuantityForProduct_WidthProductEqualsZero_ShowThrowArgumentOutOfRange()
        {
            // Arrange
            int productType = 3; // product type = 3
            int materialType = 1; // material type = = 3
            int countProduct = 15; // product's count = 15
            float width = 0;
            float lenth = 45;
            Calculation calculation = new Calculation();

            // action and Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => 
            calculation.GetQuantityForProduct(productType, materialType, countProduct, width, lenth));
        }

        [TestMethod]
        public void GetQuantityForProduct_LengthProductLessZero_ShowThrowArgumentOutOfRange()
        {
            // Arrange
            int productType = 3; // product type = 3
            int materialType = 1; // material type = = 3
            int countProduct = 15; // product's count = 15
            float width = 20;
            float lenth = -45;
            Calculation calculation = new Calculation();

            // action and Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => 
            calculation.GetQuantityForProduct(productType, materialType, countProduct, width, lenth));
        }

        [TestMethod]
        public void GetQuantityForProduct_LengthProductEqualsZero_ShowThrowArgumentOutOfRange()
        {
            // Arrange
            int productType = 3; // product type = 3
            int materialType = 1; // material type = = 3
            int countProduct = 15; // product's count = 15
            float width = 20;
            float lenth = 0;
            Calculation calculation = new Calculation();

            // action and Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => 
            calculation.GetQuantityForProduct(productType, materialType, countProduct, width, lenth));
        }
    }
}
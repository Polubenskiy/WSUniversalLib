using System.Globalization;

namespace WSUniversalLib
{
    public class Calculation
    {
        private int countProduct;
        public int CountProduct
        {
            get => countProduct;
        }

        private double[] coefficientsProductType = { 1.1, 2.5, 8.43 };
        private double[] coefficientsMaterialType = { 0.3, 0.12 };

        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            if (productType > 3 || productType < 0)
            {
                throw new ArgumentOutOfRangeException("product type");
            }

            if (materialType > 2 || materialType < 0)
            {
                throw new ArgumentOutOfRangeException("material type");
            }    

            if (count <= 0)
            {
                throw new ArgumentOutOfRangeException("count product");
            }
            
            if (width <= 0)
            {
                throw new ArgumentOutOfRangeException("width");
            }

            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException("length");
            }

            // Quantity of high-quality raw materials without taking into account marriage
            double countQuantityProductWithoutMarriage = count * width * length * coefficientsProductType[productType - 1];

            // Calculation of marriage
            double mirriage = countQuantityProductWithoutMarriage * (coefficientsMaterialType[materialType - 1] / 100);

            // Calculation of the quantity of goods taking into account the marriage
            double countProductWithMarriage = countQuantityProductWithoutMarriage + mirriage;

            countProduct = Convert.ToInt32(Math.Ceiling(countProductWithMarriage));
            return countProduct;
        }
    }
}
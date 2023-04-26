using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumaniMoilaPart1
{
    internal class Ingredient
    {

        private string ingredientName = "";
        private double ingredientQuantity = 0;
        private string unitMeasurement = "";
        public Ingredient(string ingredientName, double ingredientQuantity, string unitMeasurement)
        {
            this.ingredientName = ingredientName;
            this.ingredientQuantity = ingredientQuantity;
            this.unitMeasurement = unitMeasurement;

        }
        //get and setters for the indegrient class
        public string GetIngredientName()
        {
            return ingredientName;
        }
        public void SetIngredientName(string ingredientName)
        {
            this.ingredientName = ingredientName;
        }
        public double GetIngredientQuantity()
        {
            return ingredientQuantity;
        }
        public void SetIngredientQuantity(double ingredientQuantity)
        {
            this.ingredientQuantity = ingredientQuantity;
        }

        public string GetUnitMeasurement()
        {
            return unitMeasurement;
        }
        public void SetUnitMeasurement(string unitMeasurement)
        {
            this.unitMeasurement = unitMeasurement;
        }
    }
}

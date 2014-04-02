using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication17
{

    public class Optomization
    {
        public class Jar
        {
            public string Type; 
            public int Size;
            public decimal Price;
           
        }

        public class Recipe
        {
         public List<string> recipe;
        }

        public class  Product
        {
           public  BOM bom;
           public Jar jar;
           public Recipe recipe;
           public decimal Price;
           public int production;
           public decimal CurrentProfit;
           public decimal ExtraCost;
           public decimal MaxCapacityOverall;
           public decimal ProductionRequired;
        }

        public class Fruit
        {
            public string Name;
            public List<decimal> prices;
            public List<int> amountsavailable;
        }
        public class BOM
        {
           public decimal AmountOfSugar;            
            public Dictionary<Fruit, decimal> Fruits;   //   fruits, amountsperkg
        }


        public void FindProfit(List<Product> Products, int weekNo)
        {
           

            
            decimal PriceOfFruits=0;

            foreach (Product product in Products)
	        
            {                  
                 
           
                decimal priceOfSugarPerKg =7;
               

                decimal PriceOfSUgar = priceOfSugarPerKg * product.bom.AmountOfSugar;
            
               

                    foreach(KeyValuePair<Fruit, decimal > pair in product.bom.Fruits)
                    {
                        PriceOfFruits += pair.Key.prices[weekNo] * pair.Value;
                    }
                    
                    
                    decimal CostOfProduct = PriceOfFruits + PriceOfSUgar + product.jar.Price + product.ExtraCost;

                 product.CurrentProfit = product.Price - CostOfProduct;
             
            }
            
        }

        public void CalculateOptimalAmounts(List<Product> products, int weekNo)
        {
            decimal MaxCapacityOfProd=decimal.MaxValue;
            decimal Capacity=0;
            decimal MacCapacityOverall;
            
            
            foreach (Product product in products)
            {
               
               foreach( KeyValuePair<Fruit, decimal> kvp in product.bom.Fruits )
               {
                   
                        if (kvp.Key.amountsavailable[weekNo] < kvp.Value)
                        {

                            decimal temp_MaxCapacityOfProd = kvp.Key.amountsavailable[weekNo] * Capacity / kvp.Value;

                           if (temp_MaxCapacityOfProd < MaxCapacityOfProd)
                           {
                               MaxCapacityOfProd = temp_MaxCapacityOfProd;
                           }

                        }
               
                        if (MaxCapacityOfProd > product.MaxCapacityOverall)
                        {
                            MaxCapacityOfProd = product.MaxCapacityOverall;
                        }
              
                decimal ProductionOfProductX = product.ProductionRequired + MaxCapacityOfProd;

                MacCapacityOverall = product.MaxCapacityOverall - ProductionOfProductX;
               
               }
            }

        }

    }
}

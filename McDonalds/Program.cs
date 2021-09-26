using System;

namespace McDonalds {
    
   class Program { 

        static void Main(string[] args) {
            
            Welcome();
            addfood();
            
        }

        static void Welcome() {
            Console.WriteLine("歡迎光臨，請完成實聯制並量體溫消毒");
            Console.WriteLine("您好，請問內用外帶?內用請按A，外帶請按B");
            Console.ReadKey(true);
        }
        static void addfood() {
         List<Food> foods = new List<Food>();
         List<Orderitem> order = new List<Orderitem>();
                
                //create new item for foods
            foods.Add(new Food() { Name = "大麥克漢堡",Set = true,  Price = 150 });
            foods.Add(new Food() { Name = "大麥克漢堡",Set = false, Price = 90  });
            foods.Add(new Food() { Name = "麥香雞漢堡",Set = true,  Price = 140 });
            foods.Add(new Food() { Name = "麥香雞漢堡",Set = false, Price = 75  });
            foods.Add(new Food() { Name = "雙層牛肉堡",Set = true,  Price = 160 });
            foods.Add(new Food() { Name = "雙層牛肉堡",Set = false, Price = 100 });

            DisplayFoodMenu(foods);//show food list
            PlaceOrder(foods, order);
        }

        

        static void DisplayFoodMenu(List<Food> myfoods) {
            Console.WriteLine("=========McDonald's Menu=========\n");
            Console.WriteLine(String.Format("{0,8}{1,6}{2,6}","品名","套餐價格", "單點價格"));
            Console.WriteLine();
            for (int i = 0; i < myfoods.Count; i+=2) {
                Console.WriteLine(String.Format("{0,5}{1,7}{2,10}",myfoods[i].Name,myfoods[i].Price,myfoods[i+1].Price));
            }
            
        }

        private static void PlaceOrder(List<Food> foods, List<Orderitem> order)
        {
            Console.WriteLine();
            Console.WriteLine("請開始訂購，按X鍵離開");
        }
        
    }
}
using System;

namespace McDonalds
{

    class Program
    {

        static void Main(string[] args)
        {

            Welcome();
            addfood();

        }

        static Boolean Welcome()
        {
            Console.WriteLine("歡迎光臨，請完成實聯制並量體溫消毒");
        A:
            Console.WriteLine("您好，請問內用外帶?內用請按A，外帶請按B");
            Console.WriteLine("\n");
            switch (Console.ReadKey().Key.ToString())
            {
                case ("A"):
                case ("a"):
                    return true;

                case ("B"):
                case ("b"):
                    return false;
                default:
                    goto A;

            }



        }
        static void addfood()
        {
            List<Food> foods = new List<Food>();
            List<Orderitem> order = new List<Orderitem>();

            //create new item for foods
            foods.Add(new Food() { Name = "1|大麥克漢堡", Set = "套餐", Price = 150 });
            foods.Add(new Food() { Name = "1|大麥克漢堡", Set = "單點", Price = 90 });
            foods.Add(new Food() { Name = "2|麥香雞漢堡", Set = "套餐", Price = 140 });
            foods.Add(new Food() { Name = "2|麥香雞漢堡", Set = "單點", Price = 75 });
            foods.Add(new Food() { Name = "3|雙層牛肉堡", Set = "套餐", Price = 160 });
            foods.Add(new Food() { Name = "3|雙層牛肉堡", Set = "單點", Price = 100 });

            DisplayFoodMenu(foods);//show food list
            PlaceOrder(foods, order);
            OrderComplete(order,foods);
        }



        static void DisplayFoodMenu(List<Food> myfoods)
        {
            Console.WriteLine("=========McDonald's Menu=========\n");
            Console.WriteLine(String.Format("{0,8}{1,6}{2,6}", "品名", "套餐價格", "單點價格"));
            Console.WriteLine();
            for (int i = 0; i < myfoods.Count; i += 2)
            {

                Console.WriteLine(String.Format("{0,5}{1,7}{2,10}", myfoods[i].Name, myfoods[i].Price, myfoods[i + 1].Price));
            }

        }

        static void PlaceOrder(List<Food> myfoods, List<Orderitem> myorder)
        {
            Console.WriteLine();
            Console.WriteLine("請開始訂購，按X鍵離開\n");

            string s;
            int i, Qty, SubTotal;

            while (true)
            {

                Console.WriteLine("請輸入您所想要的品項");
                s = Console.ReadLine();
                if (s == "x"|s=="X") break;
                else
                {
                    i = Convert.ToInt32(s);
                    if (i == 1) i = 0;
                    if (i == 2) i = 2;
                    if (i == 3) i = 4;
                }

                Console.WriteLine("組成套餐嗎?(Y/N)");
                s = Console.ReadLine();
                if (s == "x") break;
                else if (s == "Y" | s == "y")
                {

                }
                else if (s == "N" | s == "n")
                {
                    i = i + 1;
                }





                Console.WriteLine("請問要幾份呢?");
                s = Console.ReadLine();
                if (s == "x") break;
                else
                {
                    Qty = Convert.ToInt32(s);

                    SubTotal = myfoods[i].Price * Qty;
                }
                Console.WriteLine("您訂購{0}{1}，每份{2}元，共{3}元。\n", myfoods[i].Name, myfoods[i].Set, myfoods[i].Price, SubTotal);

                myorder.Add(new Orderitem() { Index = i, Qty = Qty, SubTotal = SubTotal });


            }


        }

        private static void OrderComplete(List<Orderitem> myorder, List<Food> myfoods)
        {
            Console.WriteLine("===================================================");
            int total = 0;
            int Sellprice = 0;
            string message = "";
            foreach (Orderitem oi in myorder) total += oi.SubTotal;
            if (total >= 1000)
            {
                message = "訂購滿1000，打85折，";
                Sellprice = (int)(total * 0.85);
            }
            else if (total >= 500)
            {
                message = "訂購滿500，打9折，";
                Sellprice = (int)(total * 0.9);
            }
            else
            {
                Sellprice = total;
            }
            Console.WriteLine("您訂購的商品為");
            for (int r = 0; r < myorder.Count; r++)
            {
               
                Console.WriteLine(myfoods[(myorder[r].Index)].Name + (myorder[r].Qty) + "份，小計"+(myorder[r].SubTotal)+"元");
            }
            
            Console.WriteLine($"您總共訂購{myorder.Count}項漢堡，總共{total}元\n{message}總共需付款{Sellprice}元");
            Console.WriteLine("您總共獲得" + (int)(total * 0.1)+"點");
            Console.WriteLine("訂購完成，按任意鍵離開。");
            Console.ReadLine();
        }
    }
}

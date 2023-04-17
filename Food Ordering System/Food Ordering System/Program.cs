using System;
using System.Collections.Generic;
using System.Linq.Expressions;

public class FOS
    {
         string chosenfood = "";
         string foodprice = "";
         string chosenbeverage = "";
         string beverageprice = "";
         int total;

    public static void Main(string[] args) 
    {
        var FOS = new FOS();
        FOS.WelcomeScreen();
        FOS.ProceedScreen();
        FOS.Foods();
        FOS.Proceed();
        FOS.Beverage();
        FOS.DisplayOrder();
    }
    public void ExitScreen() 
    {
        Console.Clear();
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
        Console.Write("                                            Exiting Now");
        for (int i = 0; i < 6; i++)
        {
            Thread.Sleep(250);
            Console.Write(".");
        }
        Environment.Exit(0);
    }
    public void ProceedScreen() 
    {
        Console.WriteLine("\n\n\n\n\n\n\n\n\n");
        Console.WriteLine("                      +==============================================================================+");
        Console.WriteLine("                                     WELCOME TO FOOD ORDERING SYSTEM by Lloyd Jiperson Diaz          ");
        Console.WriteLine("                      +==============================================================================+");
        Console.Write("\n\n\n                      Enter [1] to Proceed [0] to Exit : ");
        var enterscreen = Console.ReadLine();
        if (enterscreen == "1")
        {
            Console.Clear();
        }
        else 
        {
            ExitScreen();
        }
    }
    public void WelcomeScreen() 
    {
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n");
        Console.Write("                                             Loading Please Wait :) ");
        for (int i = 0; i < 6; i++) 
        {
            Thread.Sleep(250);
            Console.Write(".");
        }
        Console.Clear();
    }
    public void OrderAgain() 
    {
        Console.Write("\nDo you want to order again [1] to order [0] to exit : ");
        var orderagain = Console.ReadLine();
        if (orderagain == "1")
        {
            Console.Clear();
            Foods();
            Proceed();
        }
        else 
        {
            ExitScreen();
        }
    }
    public void Total() 
    {
        int convfoodprice;
        int convbeverageprice;
        convfoodprice = Convert.ToInt32(foodprice);
        convbeverageprice = Convert.ToInt32(beverageprice);
        total = convfoodprice + convbeverageprice;
        Console.WriteLine($"\nTotal Price : {total}");
    }
    public void DisplayOrderFoodOnly() 
    {
        
        Console.WriteLine($"Ordered Food : {chosenfood}");
        Console.WriteLine($"\nPrice : {foodprice}");
        OrderAgain();
          
        
    }
    public void DisplayOrder() 
    {
        
        Console.WriteLine($"Ordered Food : {chosenfood}");
        Console.WriteLine($"Price : {foodprice}"); 
        Console.WriteLine($"\nOrdered Beverage : {chosenbeverage}");
        Console.WriteLine($"Price : {beverageprice}");
        Total();
        OrderAgain();

    }
    public void Proceed() 
    {
        Console.Write("\n                    Proceed To Drinks [1] to proceed [0] to order food only : ");
        string proc = Console.ReadLine();
        if (proc == "1")
        {
            Console.Clear();
        }
        else 
        {
            Console.Clear();
            DisplayOrderFoodOnly();
        }
    }
    public void DisplayFoods() 
    {
        Console.Write("\n");
        Console.WriteLine("                   +==============================================================================+");
        Console.WriteLine("                                                        PIZZA                                      ");
        Console.WriteLine("                   +==============================================================================+");
        Console.WriteLine("                     [code]                                                                 Price  ");
        Console.WriteLine("");
        Console.WriteLine("                      [0]                              Pepperoni                             450   ");
        Console.WriteLine("                      [1]                              Margarita                             350   ");
        Console.WriteLine("                      [2]                              Carbonara                             650   ");
        Console.WriteLine("                      [3]                              Rustic Potatoes                       230   ");
        Console.WriteLine("                      [4]                              Vegetarian                            390   ");
        Console.WriteLine("                      [5]                              Donuts                                450   ");
        Console.WriteLine("                      [6]                              4 Cheeses                             450   ");
        Console.WriteLine("                   +==============================================================================+");
        Console.WriteLine("                                                        BURGERS                                      ");
        Console.WriteLine("                   +==============================================================================+");
        Console.WriteLine("");
        Console.WriteLine("                      [7]                              Beef Burger                           130   ");
        Console.WriteLine("                      [8]                              Cheese Burger                          99   ");
        Console.WriteLine("                      [9]                              Creamy Mushroom                       200   ");
        Console.WriteLine("                      [10]                             Spicy Buffalo                         140   ");
        Console.WriteLine("                      [11]                             Barbeque Burger                       120   ");
        Console.WriteLine("                      [12]                             Hawaiian Burger                       150   ");
        Console.WriteLine("                      [13]                             Fish Burger                           110   ");
        Console.WriteLine("\n");

    }
    public void DisplayBeverage() 
    {
        Console.Write("\n");
        Console.WriteLine("                   +==============================================================================+");
        Console.WriteLine("                                                     NON - ALCOHOLIC                               ");
        Console.WriteLine("                   +==============================================================================+");
        Console.WriteLine("                     [code]                                                                 Price  ");
        Console.WriteLine("");
        Console.WriteLine("                      [0]                              Bottled Water                          30   ");
        Console.WriteLine("                      [1]                              Coke                                   50   ");
        Console.WriteLine("                      [2]                              C2                                     50   ");
        Console.WriteLine("                      [3]                              Royal                                  50   ");
        Console.WriteLine("                      [4]                              Pepsi                                  50   ");
        Console.WriteLine("                      [5]                              Mountain Dew                           50   ");
        Console.WriteLine("                      [6]                              Sparkle                                50   ");
        Console.WriteLine("                   +==============================================================================+");
        Console.WriteLine("                                                        ALCOHOLIC                                  ");
        Console.WriteLine("                   +==============================================================================+");
        Console.WriteLine("");
        Console.WriteLine("                      [7]                              Draft Beer Glass                      660   ");
        Console.WriteLine("                      [8]                              Draft Beer Pitcher                    2970  ");
        Console.WriteLine("                      [9]                              Tanrel Beer                           495   ");
        Console.WriteLine("                      [10]                             Awaji Beer                            660   ");
        Console.WriteLine("                      [11]                             Corona Beer                           660   ");
        Console.WriteLine("                      [12]                             Shandy Gaff                           660   ");
        Console.WriteLine("                      [13]                             Malibu Surf                           660   ");
    }
    public void Foods() 
    {
        
        var listprice = new string[]
        {
            "450", "350", "650", "230", "390", "450", "450", 
            "130", "99", "200", "140", "120", "150", "110"
        };
        var listfoods = new string[] 
        {
            "Pepperoni", "Margarita", "Carbonara", "Rustic Potatoes", "Vegetarian", "Donuts", "4 Cheeses", 
            "Beef Burger", "Cheese Burger", "Creamy Mushroom", "Spicy Buffalo", "Barbeque Burger", "Hawaiian Burger", "Fish Burger"
        };
        DisplayFoods();
        try
        {
            Console.Write("                    Enter Code : ");
        var codefood = Convert.ToInt32(Console.ReadLine());
        
            switch (codefood)
            {
                case 0:
                    chosenfood = listfoods[codefood];
                    foodprice = listprice[codefood];
                    break;
                case 1:
                    chosenfood = listfoods[codefood];
                    foodprice = listprice[codefood];
                    break;
                case 2:
                    chosenfood = listfoods[codefood];
                    foodprice = listprice[codefood];
                    break;
                case 3:
                    chosenfood = listfoods[codefood];
                    foodprice = listprice[codefood];
                    break;
                case 4:
                    chosenfood = listfoods[codefood];
                    foodprice = listprice[codefood];
                    break;
                case 5:
                    chosenfood = listfoods[codefood];
                    foodprice= listprice[codefood];
                    break;
                case 6:
                    chosenfood = listfoods[codefood];
                    foodprice = listprice[codefood];
                    break;
                case 7:
                    chosenfood = listfoods[codefood];
                    foodprice = listprice[codefood];
                    break;
                case 8:
                    chosenfood = listfoods[codefood];
                    foodprice = listprice[codefood];
                    break;
                case 9:
                    chosenfood = listfoods[codefood];
                    foodprice = listprice[codefood];
                    break;
                case 10:
                    chosenfood = listfoods[codefood];
                    foodprice = listprice[codefood];
                    break;
                case 11:
                    chosenfood = listfoods[codefood];
                    foodprice = listprice[codefood];
                    break;
                case 12:
                    chosenfood = listfoods[codefood];
                    foodprice = listprice[codefood];
                    break;
                case 13:
                    chosenfood = listfoods[codefood];
                    foodprice = listprice[codefood];
                    break;

                default:
                    Console.WriteLine("                    Invalid Code Try Again");
                    Console.WriteLine("                    Wait 2 seconds to Re enter again");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Foods();
                    break;
                    
            }

        }
        catch (Exception) 
        {
            Console.WriteLine("                    Invalid Code Try Again");
            Console.WriteLine("                    Wait 2 seconds to Re enter again");
            Thread.Sleep(2000);
            Console.Clear();
            Foods();
        }
        
        
    }
    public void Beverage() 
    {
        
        var listbprice = new string[]
        {
            "30", "50", "50", "50", "50", "50", "50",
            "660", "2970", "495", "660", "660", "660", "660"
        };
        var listbeverage = new string[]
        {
            "Bottled Water", "Coke", "C2", "Royal", "Pepsi", "Mountain Dew", "Sparkle",
            "Draft Beer Glass", "Draft Beer Pitcher", "Tanrel Beer", "Awaji Beer", "Corona Beer", "Shandy Gaff", "Malibu Surf"
        };
        DisplayBeverage();
        try
        {
            Console.Write("\n\n                    Enter Code : ");
            var codebeverage = Convert.ToInt32(Console.ReadLine());

            switch (codebeverage)
            {
                case 0:
                    chosenbeverage = listbeverage[codebeverage];
                    beverageprice = listbprice[codebeverage];
                    break;
                case 1:
                    chosenbeverage = listbeverage[codebeverage];
                    beverageprice = listbprice[codebeverage];
                    break;
                case 2:
                    chosenbeverage = listbeverage[codebeverage];
                    beverageprice = listbprice[codebeverage];
                    break;
                case 3:
                    chosenbeverage = listbeverage[codebeverage];
                    beverageprice = listbprice[codebeverage];
                    break;
                case 4:
                    chosenbeverage = listbeverage[codebeverage];
                    beverageprice = listbprice[codebeverage];
                    break;
                case 5:
                    chosenbeverage = listbeverage[codebeverage];
                    beverageprice = listbprice[codebeverage];
                    break;
                case 6:
                    chosenbeverage = listbeverage[codebeverage];
                    beverageprice = listbprice[codebeverage];
                    break;
                case 7:
                    chosenbeverage = listbeverage[codebeverage];
                    beverageprice = listbprice[codebeverage];
                    break;
                case 8:
                    chosenbeverage = listbeverage[codebeverage];
                    beverageprice = listbprice[codebeverage];
                    break;
                case 9:
                    chosenbeverage = listbeverage[codebeverage];
                    beverageprice = listbprice[codebeverage];
                    break;
                case 10:
                    chosenbeverage = listbeverage[codebeverage];
                    beverageprice = listbprice[codebeverage];
                    break;
                case 11:
                    chosenbeverage = listbeverage[codebeverage];
                    beverageprice = listbprice[codebeverage];
                    break;
                case 12:
                    chosenbeverage = listbeverage[codebeverage];
                    beverageprice = listbprice[codebeverage];
                    break;
                case 13:
                    chosenbeverage = listbeverage[codebeverage];
                    beverageprice = listbprice[codebeverage];
                    break;

                default:
                    Console.WriteLine("                    Invalid Code Try Again");
                    Console.WriteLine("                    Wait 2 seconds to Re enter again");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Beverage();
                    break;
            }
            Console.Clear();
        }
        catch (Exception)
        {
            Console.WriteLine("                    Invalid Code Try Again");
            Console.WriteLine("                    Wait 2 seconds to Re enter again");
            Thread.Sleep(2000);
            Console.Clear();
            Beverage();
        }
        
    }
}
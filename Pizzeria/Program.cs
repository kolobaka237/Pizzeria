using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Hi, it's Freddy Fazbear's Pizzeria.");
        Console.WriteLine("Today we have a special offer: a 20% discount for orders over $50. Every 5th pizza is free. For drinks priced at $3 or more, there is a 15% discount when you buy more than 3 items.");
        Console.WriteLine("Choose a pizza: \nCarbonara - 1\t 15$ \nMeat - 2\t 25$ \nHawaiian - 3\t 20$ \nCheese - 4\t 23$ ");
        Pizza pizza = (Pizza)Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("How many pizzas to cook?");
        int pizzaQuantity = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Choose a drink: \nCola - 1\t 3$ \nFanta - 2\t 2$ \nSprite - 3\t 2$");
        Drink drink = (Drink)Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("how many drinks do you want?");
        int drinkQuantity = Convert.ToInt16(Console.ReadLine());
        double totalCost = 0;
        switch (pizza)
        {
            case Pizza.Carbonara:

                int pizzaPrice = 15;
                double result = pizzaQuantity * pizzaPrice;
                if (result > 50)
                {
                    double sale = result / 100 * 20;
                    result = result - sale;
                }
                totalCost += result;
                Console.WriteLine($"Your order:\n{pizza}\t {pizzaQuantity} шт\t {result}$");
                break;
            case Pizza.Meat:
                pizzaPrice = 25;
                result = pizzaQuantity * pizzaPrice;
                if (result > 50)
                {
                    double sale = result / 100 * 20;
                    result = result - sale;
                }
                Console.WriteLine($"Your order:\n{pizza}\t {pizzaQuantity} шт\t {result}$");
                break;
            case Pizza.Hawaiian:
                pizzaPrice = 20;
                result = pizzaQuantity * pizzaPrice;
                if (result > 50)
                {
                    double sale = result / 100 * 20;
                    result = result - sale;
                }
                Console.WriteLine($"Your order:\n{pizza}\t {pizzaQuantity} шт\t {result}$");
                break;
            case Pizza.Cheese:
                pizzaPrice = 23;
                result = pizzaQuantity * pizzaPrice;
                if (result > 50)
                {
                    double sale = result / 100 * 20;
                    result = result - sale;
                }
                Console.WriteLine($"Your order:\n{pizza}\t {pizzaQuantity} шт\t {result}$");
                break;


        }
        switch (drink)
        {
            case Drink.Cola:
                int drinkPrice = 3;
                double result = drinkQuantity * drinkPrice;
                if (drinkQuantity > 3)
                {
                    double sale = result / 100 * 15;
                    result = result - sale;
                }
                Console.WriteLine($"{drink} \t\t {drinkQuantity} шт\t {result}$");
                break;
            case Drink.Fanta:
                int fantaPrice = 2;
                result = drinkQuantity * fantaPrice;
                Console.WriteLine($"{drink} \t\t {drinkQuantity} шт\t {result}$");
                break;
            case Drink.Sprite:
                int spritePrice = 2;
                result = drinkQuantity * spritePrice;
                Console.WriteLine($"{drink} \t\t {drinkQuantity} шт\t {result}$");
                break;

        }
        Console.WriteLine($"Total cost: {totalCost}$");
    }



enum Drink
{
    Cola = 1,
    Fanta,
    Sprite

}
enum Pizza
{
    Carbonara = 1,
    Meat,
    Hawaiian,
    Cheese
}
}
    




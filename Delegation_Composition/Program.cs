using System;

namespace Delegation_Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(EatingHabits.Vegetarian, false);
            bool productIsSuitableForLactoseIntolerant = false;
            bool productIsSuitableForNonMeatEaters = false;

            Console.WriteLine("Would you like:");
            Console.WriteLine("1 - a cake\r\n2 - a chocolate\r\n3 - a cupcake");
            Console.WriteLine("Enter your choice:");

            switch (GetIntInput(3))
            {
                case 1:
                    FoodProduct cake = new FoodProduct(EatingHabits.Vegetarian, new DateTime(2020, 12, 01), 17.5, false);
                    CakeFactory cakeFactory = new CakeFactory(new SuitabilityForDifferentEatingHabits());

                    if (client.EatingHabits == EatingHabits.Vegan || client.EatingHabits == EatingHabits.Vegetarian)
                    {
                        productIsSuitableForNonMeatEaters = cakeFactory.IsSuitableForNonMeatEaters(cake);
                    }
                    if (!client.ToleratesLactose)
                    {
                        productIsSuitableForLactoseIntolerant = cakeFactory.IsSuitableForLactoseIntolerantPeople(cake);
                    }
                    if (productIsSuitableForNonMeatEaters && productIsSuitableForLactoseIntolerant)
                    {
                        Console.WriteLine("Cake price: " + cakeFactory.CountPrice(cake) + " eur");
        }
                    else
                    {
                        Console.WriteLine("This product is not suitable for you.");
                    }
                    break;
                case 2:
                    FoodProduct chocolate = new FoodProduct(EatingHabits.Vegan, new DateTime(2021, 12, 01), 10.5, false);
                    ChocolateFactory chocolateFactory = new ChocolateFactory(new HalfPriceDiscount());
                    Console.WriteLine("Chocolate price: " + chocolateFactory.CountPricePer200g(chocolate)*(1- chocolateFactory.CountExpirationDiscount(chocolate)) + " eur");
                    break;
                case 3:
                    FoodProduct cupCake = new FoodProduct(EatingHabits.Vegetarian, new DateTime(2020, 12, 01), 22.5, false);
                    CupcakeFactory cupcakeFactory = new CupcakeFactory(new DecoratingWithToppings(), new SuitabilityForDifferentEatingHabits());
                    double toppingsPrice = 0.0;
                    Console.WriteLine("The price of one cupcake:" + cupcakeFactory.CountPricePerOne(cupCake) + " eur");

                    if(client.EatingHabits == EatingHabits.Vegan || client.EatingHabits == EatingHabits.Vegetarian)
                    {
                        productIsSuitableForNonMeatEaters = cupcakeFactory.IsSuitableForNonMeatEaters(cupCake);
                    }
                    if (!client.ToleratesLactose)
                    {
                        productIsSuitableForLactoseIntolerant = cupcakeFactory.IsSuitableForLactoseIntolerantPeople(cupCake);
                    }
                    if (productIsSuitableForNonMeatEaters && productIsSuitableForLactoseIntolerant)
                    {
                        Console.WriteLine("Would you like to add toppings?");
                        Console.WriteLine("1 - yes\r\n2 - no");
                        Console.WriteLine("Enter your choice:");
                        if (GetIntInput(3) == 1)
                        {
                            toppingsPrice = cupcakeFactory.AddMarshmallows(cupCake) + cupcakeFactory.AddSprinkles(cupCake);
                        }
                        else
                        {
                            toppingsPrice = 0.0;
                        }

                        Console.WriteLine("How many cupcakes would you like?");
                        Console.WriteLine("Enter your choice:");
                        int quantity = GetIntInput(200);
                        Console.WriteLine("Total price: " + (cupcakeFactory.SellRequiredAmount(cupCake, quantity) + toppingsPrice * quantity) + " eur");

                    }
                    else
                    {
                        Console.WriteLine("This product is not suitable for you.");
                    }

                    break;
                default:
                    Console.WriteLine("A problem occured.");
                    break;
            }

        }

        static int GetIntInput(int bound)
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || input > bound || input < 1)
            {
                Console.WriteLine("\r\nYou've entered an invalid number. Try again:");
            }
            return input;
        }
    }
}

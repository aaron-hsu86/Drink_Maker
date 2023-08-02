Soda coke = new Soda("Coke", "Dark Amber", 10, 140);
Soda dietCoke = new Soda("Diet Coke", "Dark Amber", 10, 0);
Coffee darkCoffee = new Coffee("Dark Coffee", "Darkness of space", 93,2, "Dark", "Mexican");
Coffee lightCoffee = new Coffee("Light Coffee", "Dark as the abyss", 93,2, "Light", "African");
Wine redWine = new Wine("Red Wine", "Red",15,125,"California", 2000);
Wine whiteWine = new Wine("White Wine", "White",15,121,"France", 2000);

List<Drink> AllBeverages = new List<Drink>();
AllBeverages.Add(coke);
AllBeverages.Add(dietCoke);
AllBeverages.Add(darkCoffee);
AllBeverages.Add(lightCoffee);
AllBeverages.Add(redWine);
AllBeverages.Add(whiteWine);

foreach (Drink drink in AllBeverages)
{
    Console.WriteLine("==================");
    drink.ShowDrink();
}

// Coffee MyDrink = new Soda();
// Code shouldn't work because the Coffee class doesn't have a constructor using the Soda class.
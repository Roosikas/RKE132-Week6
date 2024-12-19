string[] snacks = { "sushi", "pizza", "burger", "chicken wings", " Asian takeway" };

Random random = new Random();

int randomIndex = random.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}");

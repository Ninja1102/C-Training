namespace Day3Collections
{

    class Stocks
    {
        public string Symbol { get; set; }
        public string CompanyName { get; set; }
        public int Quantity { get; set; }
        public double PricePerShare { get; set; }

        public double CalculateValue()
        {
            return Quantity * PricePerShare;
        }
    }

    internal class Practice
    {
        static string filePath = "../../../Practice.csv";

        static List<Stocks> LoadPortfolio()
        {
            List<Stocks> portfolio = new List<Stocks>();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 4)
                    {
                        Stocks stock = new Stocks
                        {
                            Symbol = parts[0],
                            CompanyName = parts[1],
                            Quantity = int.Parse(parts[2]),
                            PricePerShare = double.Parse(parts[3])
                        };
                        portfolio.Add(stock);
                    }
                }
            }
            return portfolio;
        }

        static void SavePortfolio(List<Stocks> portfolio)
        {
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                foreach (Stocks s in portfolio)
                {
                    sw.WriteLine($"{s.Symbol},{s.CompanyName},{s.Quantity},{s.PricePerShare}");
                }
            }
        }

        static void AddStock()
        {
            Stocks stock = new Stocks();

            Console.Write("Enter Symbol: ");
            stock.Symbol = Console.ReadLine();

            Console.Write("Enter Company Name: ");
            stock.CompanyName = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            stock.Quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter Price Per Share: ");
            stock.PricePerShare = double.Parse(Console.ReadLine());

            List<Stocks> portfolio = LoadPortfolio();
            portfolio.Add(stock);
            SavePortfolio(portfolio);

            Console.WriteLine("Stock Added Successfully!");
        }

        static void ViewStock()
        {
            List<Stocks> stocks = LoadPortfolio();

            if (stocks.Count == 0)
            {
                Console.WriteLine("No stocks available.");
                return;
            }
            foreach (Stocks s in stocks)
            {
                Console.WriteLine($"{s.Symbol}, {s.CompanyName}, {s.Quantity}, {s.PricePerShare}");
            }
        }

        static void UpdateStock()
        {
            List<Stocks> stocks = LoadPortfolio();
            if (stocks.Count == 0)
            {
                Console.WriteLine("No stocks available.");
                return;
            }

            Console.Write("Enter Symbol to Update: ");
            string symbol = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < stocks.Count; i++)
            {
                if (stocks[i].Symbol.ToLower() == symbol.ToLower())
                {
                    Console.Write("Enter New Quantity: ");
                    stocks[i].Quantity = int.Parse(Console.ReadLine());

                    Console.Write("Enter New Price Per Share: ");                    
                    stocks[i].PricePerShare = double.Parse(Console.ReadLine());

                    found = true;
                    break;
                }
            }

            if (found)
            {
                SavePortfolio(stocks);
                Console.WriteLine("\nStock Updated Successfully!");
            }
            else
            {
                Console.WriteLine("\nStock Not Found!");
            }
        }

        static void DeleteStock()
        {
            List<Stocks> stocks = LoadPortfolio();
            if (stocks.Count == 0)
            {
                Console.WriteLine("No stocks available.");
                return;
            }

            Console.Write("Enter Symbol to Delete: ");
            string symbol = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < stocks.Count; i++)
            {
                if (stocks[i].Symbol.ToLower() == symbol.ToLower())
                {
                    stocks.RemoveAt(i);
                    found = true;
                    break;
                }
            }

            if (found)
            {
                SavePortfolio(stocks);
                Console.WriteLine("\nStock Deleted Successfully!");
            }
            else
            {
                Console.WriteLine("\nStock Not Found!");
            }
        }

        static void PortfolioSummary()
        {
            List<Stocks> stocks = LoadPortfolio();
            if (stocks.Count == 0)
            {
                Console.WriteLine("No stocks available.");
                return;
            }

            double totalValue = 0;
            Stocks highestStock = stocks[0];
            Stocks lowestStock = stocks[0];

            foreach (Stocks stock in stocks)
            {
                double value = stock.CalculateValue();
                totalValue += value;

                if (value > highestStock.CalculateValue())
                {
                    highestStock = stock;
                }

                if (value < lowestStock.CalculateValue())
                {
                    lowestStock = stock;
                }
            }

            Console.WriteLine($"\nPortfolio Summary Report:");
            Console.WriteLine($"- Total Investment Value: {totalValue}");
            Console.WriteLine($"- Stock with Highest Value: {highestStock.Symbol} ({highestStock.CalculateValue()})");
            Console.WriteLine($"- Stock with Lowest Value: {lowestStock.Symbol} ({lowestStock.CalculateValue()})");
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("---Stock Portfolio Menu ---");
                Console.WriteLine("1.Add New Stock");
                Console.WriteLine("2.View All Stocks");
                Console.WriteLine("3.Update Stock Quantity/ Price");
                Console.WriteLine("4.Delete a Stock");
                Console.WriteLine("5.Portfolio Summary Report");
                Console.WriteLine("6.Exit");
                Console.Write("Choose option:");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1: AddStock(); break;
                    case 2: ViewStock(); break;
                    case 3: UpdateStock(); break;
                    case 4: DeleteStock(); break;
                    case 5: PortfolioSummary(); break;
                    case 6: return;
                    default: Console.WriteLine("Invalid choice."); break;

                }
            }
        }

    }
}
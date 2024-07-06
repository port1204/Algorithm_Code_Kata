namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] stocks = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int BNP(int money)
            {
                int stock = 0;
                for (int i = 0; i < stocks.Length; ++i)
                {
                    if (money >= stocks[i])
                    {
                        stock += money / stocks[i];
                        money %= stocks[i];
                    }
                }
                return money + (stock * stocks[stocks.Length - 1]);
            }

            int TIMING(int money)
            {
                int stock = 0;
                int buyCount = 0;
                int sellCount = 0;
                for (int i = 1; i < stocks.Length; ++i)
                {
                    if (stocks[i] > stocks[i - 1])
                    {
                        buyCount = 0;
                       ++sellCount;
                        if (sellCount == 3)
                        {
                            money += stock * stocks[i];
                            stock = 0;
                            sellCount = 0;
                        }
                    }
                    else if (stocks[i] < stocks[i - 1])
                    {
                        sellCount = 0;
                        ++buyCount;
                        if (money >= stocks[i] && buyCount == 3)
                        {
                            stock += money / stocks[i];
                            money %= stocks[i];
                            buyCount = 0;
                        }
                    }
                }
                return money + (stock * stocks[stocks.Length - 1]);
            }

            if (BNP(input) > TIMING(input))
            {
                Console.WriteLine("BNP");
            }
            else if (BNP(input) == TIMING(input))
            {
                Console.WriteLine("SAMESAME");
            }
            else
            {
                Console.WriteLine("TIMING");
            }
        }
    }
}
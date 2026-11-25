namespace C__Basics_Session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01

            //double[] Prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(Prices[1]);

            #endregion

            #region Q02

            //int[,] shelfCopies = {
            //    {3,5},
            //    {1,4} 
            //};
            //Console.WriteLine(shelfCopies[1,0]);

            #endregion

            #region Q03

            //PrintWelcomeMessage();

            #endregion

            #region Q04

            //string BookTitle = "Clean Code";
            //PrintBookTitle(BookTitle);

            #endregion

            #region Q05

            //int Pages = 400;
            //AddBonusPages(Pages);
            /*
             The original value of `Pages` will not be changed within the `main` method,
             because the variable was passed to the function 
             by its value only (passing by value)
             */
            //Console.WriteLine(Pages);

            #endregion

            #region Q06

            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            /*
             The change will occur in the original array because it is a reference type
             */
            //Console.WriteLine(prices[0]);

            #endregion

            #region Q07

            //int Pages = 400;
            //AddBonusPagesByRef(ref Pages);
            /*
            Because using `ref` only passes the address of the variable to the function,
            any change made to it inside the function actually affects the variable itself
             */
            //Console.WriteLine(Pages);

            #endregion

            #region Q08

            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);

            #endregion

            #region Q09

            //double price = 0;
            //string title = "Clean Code";
            //if (TryGetPrice(title,out price))
            //    Console.WriteLine(price);

            #endregion

            #region Q10

            //int Pages = 400;
            //string Title = "Clean Code";
            //Console.WriteLine("Call Function With Only Title ");
            //PrintBookInfo(Title);//With Only Title
            //Console.WriteLine("==============================================");
            //Console.WriteLine("Call Function With Title and Pages");
            //PrintBookInfo(Title, Pages);//With Title and Pages

            #endregion

            #region Q11

            //int Pages = 400;
            //string Title = "Clean Code";
            //PrintBookInfo(pages: Pages,title:Title);

            #endregion

            #region Q12

            //PrintAllTitles("Clean Code", "C#", "DataBase");
  
            #endregion
        }
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        public static void PrintBookTitle(string title)
        {

            Console.WriteLine("Book title: " + title);
        }
        public static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        public static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
        public static void AddBonusPagesByRef(ref int pages)
        { 
            pages += 50;
        }
        public static void ReplaceArray(ref double[] prices)
        {

            prices = new double[]{ 10.0, 12.5, 15.0 };
        }
        public static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            { 
                price = 25.5;
                return true;
            }
            price = 0;
            return false;
        }
        public static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Book Title :{title},With Pages :{pages}");
        }
        public static void PrintAllTitles(params string[] titles)
        { 
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }
        }

    }
}

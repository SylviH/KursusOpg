using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgTryCatch1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                stockItem s = new stockItem(-1);
            }
            catch (StockItemException ex)
            {
                Console.WriteLine("StockItem Error");
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error");
                
            }
        }
    }

    public class stockItem
    {
        public int ID { get; set; }

        public stockItem(int id)
        {
            if (id < 0)
                throw new StockItemException("Wrong ID");
        }
    }

    public class StockItemException : Exception
    {
        public StockItemException(string message) : base(message)
        {
        }
    }
}

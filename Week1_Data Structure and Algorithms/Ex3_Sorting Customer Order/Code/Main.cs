public class Order
{
    public int orderID;
    public string customerName;
    public double totalPrice;
    public Order(int orderID, string customerName, double totalPrice)
    {
        this.orderID = orderID;
        this.customerName = customerName;
        this.totalPrice = totalPrice;
    }

    
}

class Sorting
{
    public int QuickIterations = 0;
    public void bubbleSort(Order[] orders)
    {
        int interations = 0;
        for (int i = 0; i < orders.Length - 1; i++)
        {
            for (int j = 0; j < orders.Length - 1; j++)
            {
                if (orders[j].totalPrice > orders[j + 1].totalPrice)
                {
                    Order temp = orders[j];
                    orders[j] = orders[j + 1];
                    orders[j + 1] = temp;
                }
                interations++;
            }
        }
        Console.WriteLine($"total iterations: {interations}");
    }
    public void QuickSort(Order[] orders, int low, int high)
    {
        
        if (low < high)
        {

            int Partition(int l, int h)
            {
                double pivot = orders[h].totalPrice;
                int i = l - 1;

                for (int j = l; j < h; j++)
                {
                    if (orders[j].totalPrice <= pivot)
                    {
                        i++;

                        Order temp = orders[i];
                        orders[i] = orders[j];
                        orders[j] = temp;
                    }
                    QuickIterations++;
                }


                Order temp2 = orders[i + 1];
                orders[i + 1] = orders[h];
                orders[h] = temp2;

                return i + 1;
            }


            int pivotIndex = Partition(low, high);
            QuickSort(orders, low, pivotIndex - 1);
            QuickSort(orders, pivotIndex + 1, high);
        }
           
    }

    public void DisplayArray(Order[] orders)
    {
        foreach (Order o in orders)
        {
            Console.WriteLine($"Order ID: {o.orderID:D2}, Customer Name: {o.customerName}, Total Price: {o.totalPrice}");
        }
    }



}

class Program
{
    public static void Main(string[] args)
    {
        Order[] orders = new Order[]{

            new Order(1,"A",500),
            new Order(2,"B",200),
            new Order(3,"C",400),
            new Order(4,"D",100),
            new Order(5,"E",100.01),
            new Order(6,"F",10.21),
            new Order(7,"G",1000.2),
            new Order(8,"H",150),
            new Order(9,"I",110),
            new Order(10,"J",2000),
            new Order(11,"K",1500.1),
            new Order(12,"L",1200),
            new Order(13,"M",10),
            new Order(14,"N",152),
            new Order(15,"O",231),
            new Order(16,"P",123.1),
            new Order(17,"Q",54.1),
            new Order(18,"R",586),
            new Order(19,"S",999),
            new Order(20,"T",213)
        };
        Order[] bubbleArray = (Order[])orders.Clone();
        Order[] quickArray = (Order[])orders.Clone();
        
        Sorting sort = new Sorting();
        Console.WriteLine("---------Bubble Sort---------");
        sort.bubbleSort(bubbleArray);
        sort.DisplayArray(bubbleArray);
        Console.WriteLine("---------Quick Sort---------");
        sort.QuickSort(quickArray, 0, quickArray.Length - 1);
        Console.WriteLine($"Total Iterations: {sort.QuickIterations}");
        sort.DisplayArray(quickArray);
    }
}

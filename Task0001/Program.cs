
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the elements of the array: (separate them by space, pls)");
        string input = Console.ReadLine(); //get input 
        string[] elements = input.Split(' '); //store input values separated in massive 

        int size = elements.Length;  //analyze length of massive

        Console.WriteLine("The expected array is:");

        foreach (string element in elements) //printing whole massive
        {
            
            for (int e = 0; e < size; e++)
            {
                if (element.Length <= 3)
                {
                    Console.Write(element + " "); //simple print
                }
                {
                    break; //it helps to stop comparing
                }
            }
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the elements of the array: ");
        string input = Console.ReadLine(); //get input 
        string[] elements = input.Split(' '); //store input values separated in massive 

        int size = elements.Length;  //analyze length of massive

        Console.WriteLine("The expected array is:");

        foreach (string element in elements) //printing whole massive
        {
        
           if (element.Length <= 3) //condition that gives access to use elements just less than 4 symbols
            {
                Console.Write(element + " "); //simple print
            }

        }
    }
}
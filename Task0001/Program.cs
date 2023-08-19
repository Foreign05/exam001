
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
        
           Console.Write(element + " "); //simple print
        
        }
    }
}
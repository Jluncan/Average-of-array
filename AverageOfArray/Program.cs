namespace AverageOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 97, 92, 87, 88, 78 }; 

            int sum = 0;

            sum = sum + scores[0];
            sum =sum + scores[1];
            sum = sum + scores[2];
            sum = sum + scores[3];
            sum = sum + scores[4];

            Console.WriteLine($"The sum is {sum}");
            
            
            

            decimal avg = 0;

            avg = sum / (decimal)scores.Length;

            Console.WriteLine($"The average is {avg}"); 
        }
    }
}

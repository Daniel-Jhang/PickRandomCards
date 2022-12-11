namespace PickRandomCards
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string? line = Console.ReadLine();
            if (int.TryParse(line, out int numberOfCards))
            {
                var result = CardPicker.PickSomeCards(numberOfCards);
                foreach (var card in result)
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
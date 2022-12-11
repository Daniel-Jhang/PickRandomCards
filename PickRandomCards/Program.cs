namespace PickRandomCards
{
    public class Program
    {
        static void Main(string[] args)
        {
            /// 此程式碼提供使用者隨機抽取 1~13, 4 種花色的撲克牌，但不限定在同 1 副撲克牌(52張)中
            // 提示使用者輸入想要抽取的卡片張數
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
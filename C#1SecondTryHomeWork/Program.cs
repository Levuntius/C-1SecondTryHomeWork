namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main()
        {
            (char letter, int position)[] cards =
            {
            ('A', 0),
            ('A', 1),

            ('B', 2),
            ('B', 3),

            ('C', 4),
            ('C', 5),

            ('D', 6),
            ('D', 7),

            ('E', 8),
            ('E', 9),

            ('F', 10),
            ('F', 11),

            ('G', 12),
            ('G', 13),

            ('H', 14),
            ('H', 15)
            }

            Random random = new Random();

            for (int i = 0; i < cards.Length * 4; i++)
            {
                int index1 = random.Next(0, cards.Length);
                int index2 = random.Next(0, cards.Length);

                var temp = cards[index1];

                cards[index1] = cards[index2];
                cards[index2] = temp;
            }

            foreach (var card in cards)
            {
                Console.WriteLine($"{card.letter} : {card.position}");
            }
        }
    }
}

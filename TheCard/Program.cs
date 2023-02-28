List<Card> deck = GenerateDeck();
foreach (var card in deck)
{
    Console.WriteLine($"The {card.Color} {card.Rank}");
}
static List<Card> GenerateDeck()
{
    List<Card> deck = new();
    foreach (CardColor c in Enum.GetValues(typeof(CardColor)))
    {
        foreach (CardRank r in Enum.GetValues(typeof(CardRank)))
        {
            deck.Add(new Card(c, r));
        }
    }
    return deck;
}

class Card
{
    public CardColor Color { get; set; }
    public CardRank Rank { get; set; }

    public Card()
    {
        Color = CardColor.Blue;
        Rank = CardRank.One;
    }

    public Card(CardColor c, CardRank r)
    {
        Color = c;
        Rank = r;
    }
}

enum CardColor
{
    Red,
    Green,
    Blue,
    Yellow
}

enum CardRank
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Dollar,
    Modulus,
    Carrot,
    Ampersand
}
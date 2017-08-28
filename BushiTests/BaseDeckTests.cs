using System;
using System.Linq;
using NUnit.Framework;
using Bushi.Models;
using Bushi.JsonDtos;

[TestFixture]
public class BaseDeckTests
{
    [Test]
    public void IteratorTest()
    {
        var deck = new BaseDeck<Attachment>();

        var packInfo = new PackInformation()
        {
            Illustrator = "Imran Askem",
            Pack = new Pack() { Id = "1" },
            Position = 12,
            Quantity = 3
        };

        var jsonInfo = new Card()
        {
            Clan = "Lion",
            Side = "Conflict",
            Type = "Attachment",
            Cost = 1,
            DeckLimit = 1,
            InfluenceCost = 1,
            MilitaryBonus = "+1",
            PoliticalBonus = "+1",
            TextCanonical = "Card text goes here",
            Traits = new string[] { "Bushi", "Weapon" },
            Unicity = true,
            PackCards = new PackInformation[] { packInfo }
        };

        var attachment = new Attachment(jsonInfo);

        deck.Add(attachment);
        deck.Add(attachment);
        deck.Add(attachment);
        deck.Add(attachment);

        foreach (var item in deck)
        {
            Assert.That(item.Unique, Is.EqualTo(true));
        }
    }
}
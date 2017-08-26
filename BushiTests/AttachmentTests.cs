using System;
using System.Linq;
using NUnit.Framework;
using Bushi.Models;
using Bushi.JsonDtos;
using Bushi.Enums;

[TestFixture]
public class AttachmentTests
{
    [Test]
    public void ConstructorTest()
    {
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

        Assert.That(attachment.Unique, Is.EqualTo(true));
        Assert.That(attachment.Type, Is.EqualTo(CardType.Attachment));
        Assert.That(attachment.Clan, Is.EqualTo(Clan.Lion));
        Assert.That(attachment.Cost, Is.EqualTo(1));
        Assert.That(attachment.DeckLimit, Is.EqualTo(1));
        Assert.That(attachment.InfluenceCost, Is.EqualTo(1));
        Assert.That(attachment.MilitaryBonus, Is.EqualTo(1));
        Assert.That(attachment.PoliticalBonus, Is.EqualTo(1));
        Assert.That(attachment.Traits.Count, Is.EqualTo(2));
    }
}
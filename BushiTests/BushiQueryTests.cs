using System;
using System.Linq;
using NUnit.Framework;
using Bushi;
using Bushi.Enums;
using Bushi.Models;

[TestFixture]
public class BushiQueryTests
{
    [Test]
    public void GetAllCardsTest()
    {
        var query = new BushiQuery();

        var allCards = query.GetAllCards();

        Assert.That(allCards, Is.TypeOf<CardDeck>());
    }

    [Test]
    public void GetAllCardsOfTypeTest()
    {
        var query = new BushiQuery();

        var attachmentCards = query.GetCardsOfType(CardType.Attachment);

        Assert.That(attachmentCards, Is.TypeOf<BaseDeck<Attachment>>());
    }

    [Test]
    public void GetCardsByNameTest()
    {
        var query = new BushiQuery();

        var adeptCards = query.GetCardByName("adept", true);

        Assert.That(adeptCards.Count, Is.EqualTo(3));
    }
}
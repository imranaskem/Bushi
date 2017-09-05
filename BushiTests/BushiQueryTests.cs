using System;
using System.Linq;
using NUnit.Framework;
using Bushi;
using Bushi.Enums;
using Bushi.Models;
using System.Collections.Generic;

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

        var clans = new List<Clan>
        {
            Clan.Dragon,
            Clan.Scorpion,
            Clan.Phoenix
        };

        var searchTerm = "adept";

        var adeptCards = query.GetCardByName(searchTerm, true);

        Assert.That(adeptCards, Has.Exactly(3).Items);
        Assert.That(adeptCards, Is.Unique);

        var clanList = new List<Clan>();

        foreach (var card in adeptCards)
        {
            Assert.That(card.Name, Does.Contain(searchTerm).IgnoreCase);
            Assert.That(card, Is.TypeOf<Character>());
            Assert.That(card.Type, Is.EqualTo(CardType.Character));

            clanList.Add(card.Clan);
        }

        Assert.That(clanList, Is.EquivalentTo(clans));
    }
}
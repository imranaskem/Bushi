using System;
using System.Linq;
using NUnit.Framework;
using Bushi.Extensions;
using Bushi.Enums;

[TestFixture]
public class ExtensionTests
{
    [Test]
    public void ConvertBonusToIntXTest()
    {
        var test = "X";

        var toBeTested = test.ConvertBonusToInt();

        Assert.That(toBeTested, Is.EqualTo(0));
    }

    [Test]
    public void ConvertBonusToIntPositiveTest()
    {
        var test = "+2";

        var toBeTested = test.ConvertBonusToInt();

        Assert.That(toBeTested, Is.EqualTo(2));
    }

    [Test]
    public void ConvertBonusToIntNegativeTest()
    {
        var test = "-2";

        var toBeTested = test.ConvertBonusToInt();

        Assert.That(toBeTested, Is.EqualTo(-2));
    }

    [Test]
    public void ConvertToEnumTest()
    {
        var input = "lion-";

        var clanEnum = input.ConvertToEnum<Clan>();

        Assert.That(clanEnum, Is.EqualTo(Clan.Lion));

        input = "con-flict";

        var sideEnum = input.ConvertToEnum<Side>();

        Assert.That(sideEnum, Is.EqualTo(Side.Conflict));
    }
}
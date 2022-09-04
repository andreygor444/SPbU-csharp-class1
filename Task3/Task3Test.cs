using NUnit.Framework;
using System;
using static NUnit.Framework.Assert;
using static Task3.Task3;

public class Tests
{
    [Test]
    public void FTest()
    {
        That(F(0.0), Is.EqualTo(1.0).Within(1e-5));
        That(F(234.343), Is.EqualTo(1.0).Within(1e-5));
        That(F(231.343), Is.EqualTo(-1.0).Within(1e-5));
        That(F(-233.343), Is.EqualTo(0).Within(1e-5));
    }

    [Test]
    public void NumberOfDaysTest()
    { 
        That(NumberOfDays(2021), Is.EqualTo(365));
        That(NumberOfDays(2022), Is.EqualTo(365));
        That(NumberOfDays(228), Is.EqualTo(366));
        That(NumberOfDays(3333), Is.EqualTo(365));
    }

    [Test]
    public void Rotate2Test()
    {
        That(Rotate2('С', 1, -1), Is.EqualTo('С'));
        That(Rotate2('В', -1, -1), Is.EqualTo('З'));
        That(Rotate2('З', 1, 2), Is.EqualTo('С'));
    }

    [Test]
    public void AgeDescriptionTest()
    {
        That(AgeDescription(42), Is.EqualTo("сорок два года"));
        That(AgeDescription(69), Is.EqualTo("шестьдесят девять лет"));
        That(AgeDescription(55), Is.EqualTo("пятьдесят пять лет"));
        That(AgeDescription(21), Is.EqualTo("двадцать один год"));
    }

    [Test]
    public void MainTest()
    {
        Main(Array.Empty<string>());
    }
}
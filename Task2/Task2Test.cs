using NUnit.Framework;
using System;
using static NUnit.Framework.Assert;
using static Task2.Task2;

public class Tests
{
    [Test]
    public void Min3Test1()
    {
        That(Min3(2, 0, 3), Is.EqualTo(0));
    }

    [Test]
    public void Min3Test2()
    {
        That(Min3(1, 2, 3), Is.EqualTo(1));
    }

    [Test]
    public void Min3Test3()
    {
        That(Min3(-2, 0, 2), Is.EqualTo(-2));
    }

    [Test]
    public void Max3Test1()
    {
        That(Max3(2, 0, 3), Is.EqualTo(3));
    }

    [Test]
    public void Max3Test2()
    {
        That(Max3(1, 2, 3), Is.EqualTo(3));
    }

    [Test]
    public void Max3Test3()
    {
        That(Max3(-2, 0, 2), Is.EqualTo(2));
    }

    [Test]
    public void Deg2RadTest1()
    {
        That(Deg2Rad(180.0), Is.EqualTo(Math.PI).Within(1e-5));
        That(Deg2Rad(2 * 360 + 180.0), Is.EqualTo(5 * Math.PI).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest1()
    {
        That(Rad2Deg(Math.PI), Is.EqualTo(180.0).Within(1e-5));
        That(Rad2Deg(5 * Math.PI), Is.EqualTo(5 * 180.0).Within(1e-5));
    }

    [Test]
    public void MoreRadDegTests()
    {
        That(Deg2Rad(240), Is.EqualTo(Math.PI*2*2/3).Within(1e-5));
        That(Deg2Rad(360), Is.EqualTo(2*Math.PI).Within(1e-5));
        That(Deg2Rad(36), Is.EqualTo(Math.PI/5).Within(1e-5));
        That(Deg2Rad(9), Is.EqualTo(Math.PI/20).Within(1e-5));
        That(Deg2Rad(35), Is.EqualTo(Math.PI*2*35/360).Within(1e-5));
        
        That(Rad2Deg(Math.PI*2*2/3), Is.EqualTo(240).Within(1e-5));
        That(Rad2Deg(2*Math.PI), Is.EqualTo(360).Within(1e-5));
        That(Rad2Deg(Math.PI/5), Is.EqualTo(36).Within(1e-5));
        That(Rad2Deg(Math.PI/20), Is.EqualTo(9).Within(1e-5));
        That(Rad2Deg(Math.PI*2*35/360), Is.EqualTo(35).Within(1e-5));
    }
}
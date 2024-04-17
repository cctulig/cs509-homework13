namespace TestHomework13;

using FluentAssertions;
using Moq;
using AutoFixture;
using Homework13;

public class UnitTestA
{
    [Fact]
    public void f1_add_1()
    {
        A.f1(1).Should().Be(2);
    }
    
    [Fact]
    public void f2_add_2()
    {
        A.f2(1).Should().Be(3);
    }
    
    [Fact]
    public void f5_divide_2_by_2()
    {
        A.f5(2, 2).Should().Be(1);
    }
    
    [Fact]
    public void f5_divide_2_by_1()
    {
        A.f5(2, 1).Should().Be(2);
    }
    
    [Fact]
    public void f5_divide_2_by_0()
    {
        Action f5 = () => { var res = A.f5(2, 0); };
        f5.Should().Throw<DivideByZeroException>();
    }
    
    [Fact]
    public void f6_positive_add_5()
    {
        A.f6(0).Should().Be(5);
    }
    
    [Fact]
    public void f6_negative_add_5()
    {
        Action f6 = () => { var res = A.f6(-1); };
        f6.Should().Throw<Exception>().WithMessage("x can't be negative");;
    }
    
    [Fact]
    public void f7_append_abc()
    {
        A.f7("abc").Should().Be("abc more stuff");
    }
    
    [Fact]
    public void f7_append_empty()
    {
        A.f7("").Should().Be(" more stuff");
    }
    
    [Fact]
    public void f8_with_mock_db()
    {
        Fixture fixture = new Fixture();
        int expectedNumber = fixture.Create<int>();
        
        var a = new Mock<I_A>();
        a.Setup(x => x.f8(It.IsAny<int>())).Returns(expectedNumber+8);

        var b = B.g1(2, a.Object);

        b.Should().Be(expectedNumber+8);
    }
}
using FluentAssertions;
using Xunit;

namespace StaticFactoryMethod.Tests;

public class PaymentTests
{
    private const int PayAmount = 2000;
    private const int Saeed = 2;

    [Fact]
    public void CreateFromAmount_should_create_payment_based_on_amount()
    {
        var payment = Payment.CreateForIncreasingCredit(PayAmount, Saeed, "Increase");

        payment.Amount.Should().Be(PayAmount);
        payment.OrderId.Should().Be(null);
        payment.UserId.Should().Be(Saeed);
        payment.Description.Should().Be("Increase");
    }

    [Fact]
    public void CreateFromOrder_should_create_payment_based_on_order()
    {
        var order = new Order() { Amount = PayAmount, Id = 10, UserId = Saeed };
        var payment = Payment.CreateForPayingOrder("Order", order);

        payment.Amount.Should().Be(order.Amount);
        payment.OrderId.Should().Be(order.Id);
        payment.UserId.Should().Be(Saeed);
        payment.Description.Should().Be("Order");
    }
}
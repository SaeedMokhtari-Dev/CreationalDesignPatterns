namespace StaticFactoryMethod
{
    public class Payment
    {
        public int Amount { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public int? OrderId { get; set; }

        private Payment(int amount, int userId, string description, int? orderId)
        {
            Amount = amount;
            UserId = userId;
            Description = description;
            OrderId = orderId;
        }

        public static Payment CreateForIncreasingCredit(int amount, int userId, string description)
        {
            return new Payment(amount, userId, description, null);
        }

        public static Payment CreateForPayingOrder(string description, Order order)
        {
            return new Payment(order.Amount, order.UserId, description, order.Id);
        }
    }
}
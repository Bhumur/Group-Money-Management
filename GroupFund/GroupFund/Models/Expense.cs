namespace GroupFund.Models
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }

        public int PaidByUserId { get; set; }
        public User PaidBy { get; set; }

        public decimal Amount { get; set; }
        public string Description { get; set; }
        public ICollection<ExpenseSplit> Splits { get; set; }
    }
}

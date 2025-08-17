namespace GroupFund.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public ICollection<GroupMember> Members { get; set; }
        public ICollection<Expense> Expenses { get; set; }
    }
}

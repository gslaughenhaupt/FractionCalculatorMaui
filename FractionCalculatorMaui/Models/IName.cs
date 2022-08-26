namespace FractionCalculatorMaui.Models
{
    public interface IName
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        void SetFullName(string first, string last);
    }
}
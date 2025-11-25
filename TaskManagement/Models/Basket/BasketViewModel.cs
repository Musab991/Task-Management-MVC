namespace TaskManagement.Models.Basket
{

    public class BasketViewModel<T>
    {
        public List<T> Items { get; set; }
        public List<BasketColumn> Columns { get; set; }
    }

}

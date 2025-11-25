namespace TaskManagement.Models.Basket
{
    public class BasketColumn
    {
        public string Name { get; set; }     // column header
        public string Field { get; set; }    // property name of model
        public BasketColumn(string name , string field)
        {
            Name=name;
            Field=field;
            
        }
    }
}

namespace CheckBoxesAspCore.Models
{
    public class CheckBoxOption
    {
        public bool IsChecked { get; set; }
        public string? Text { get; set; }
        //value data recieve on submit
        public string? Value { get; set; }
    }
}

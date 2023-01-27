namespace lab2._2.Models
{
    public class CalcModel
    {
        public int x { get; set; }
        public int y { get; set; }
        public string Operation { get; set; }

        public string Calc()
        {
            return Operation switch
            {
                "+" => $"{x} + {y} = {x + y}",
                "-" => $"{x} - {y} = {x - y}",
                "*" => $"{x} * {y} = {x * y}",
                "/" => y != 0 ? $"{x} /  {y} = {x / y}" : "Division by zero",
                _ => "Invalid operation"
            };
        }
    }
}

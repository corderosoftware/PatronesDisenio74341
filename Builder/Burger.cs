namespace Builder;
public class Burger
{
    public string Bread { get; set; }
    public string Meat { get; set; }
    public string Cheese { get; set; }
    public string Dressing { get; set; }
    public bool Lettuce { get; set; }
    public bool Tomato { get; set; }
    public string DisplayInformation()
    {
        return $"Pan: {Bread}\r\nCarne: {Meat}\r\nQueso: {Cheese}\r\nSalsa: {Dressing}\r\nLechuga: {Lettuce}\r\nTomate: {Tomato}";
    }
}

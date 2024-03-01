namespace SomeSolution;

public class CProduct
{
    public string Name { get; private set; }
    public int Price { get; private set; }

    public CProduct(string name, int price)
    {
        this.Name = name;
        this.Price = price;
    }

    public void ChangeName(string name)
    {
        this.Name = name;
    }

    public void ChangePrice(int price)
    {
        this.Price = price;
    }
    
}
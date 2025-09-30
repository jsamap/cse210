using System.Dynamic;

class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    public double GetOrderTotal()
    {
        double productsTotal = 0;
        foreach (Product p in _products)
            productsTotal += p.GetProductTotal();

        double shippingCost = _customer.IsAddressInUS() ? 5 : 35;

        return productsTotal + shippingCost;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product p in _products)
        {
            packingLabel += _products.IndexOf(p) != 0 ? "\n" : "";
            packingLabel += $"[{p.GetID()}] {p.GetName()}";
        }

        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetName().ToUpper()}\n{_customer.GetAddress()}";
    }
}
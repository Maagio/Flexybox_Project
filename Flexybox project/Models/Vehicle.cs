namespace Flexybox_project.Models
{
    public class Vehicle
    {
        protected string Brand;
        protected double Weight;
        protected int MaxSpeed;

        public string GetBrand()
        {
            return Brand;
        }
    }
}

namespace project_21_11_24.Classes
{
    public class Rucksack
    {
        public string? Color { get; set; }
        public string? BrandAndManufacturer { get; set; }
        public string? Cotton { get; set; }
        public float Weight { get; set; }
        public float Volume { get; set; }
        public float OccupiedVolume { get; private set; }
        public List<string> Content { get; set; }
        public event Action<string>? AddingContent;
        public Rucksack()
        {
            Color = "";
            BrandAndManufacturer = "";
            Cotton = "";
            Weight = 0;
            Volume = 0;
            OccupiedVolume = 0;
            Content = [];
            AddingContent += content =>
            {
                Console.WriteLine($"Adding {content} to the rucksack.");
                Console.WriteLine($"Occupied volume: {OccupiedVolume} out of {Volume}");
            };
        }
        public Rucksack(string color, string brandAndManufacturer, string cotton, float weight, float volume, List<string> content) : this()
        {
            Color = color;
            BrandAndManufacturer = brandAndManufacturer;
            Cotton = cotton;
            Weight = weight;
            Volume = volume;
            Content = content;
        }
        public void AddContent(string item, float itemVolume)
        {
            if (OccupiedVolume + itemVolume > Volume)
            {
                throw new Exception($"Unable to add item '{item}' to the rucksack. The rucksack is full.");
            }
            Content.Add(item);
            OccupiedVolume += itemVolume;
            AddingContent?.Invoke(item);
        }
        public void RemoveContent(string item, float itemVolume)
        {
            if (Content.Remove(item))
            {
                OccupiedVolume -= itemVolume;
                Console.WriteLine($"Item '{item}' removed from the rucksack.");
                Console.WriteLine($"Occupied volume: {OccupiedVolume} out of {Volume}");
            }
            else
            {
                Console.WriteLine($"Item '{item}' not found in the rucksack.");
            }
        }
        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine("Rucksack:");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Brand and Manufacturer: {BrandAndManufacturer}");
            Console.WriteLine($"Cotton: {Cotton}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Volume: {Volume}");
            Console.WriteLine($"Occupied Volume: {OccupiedVolume}");
            Console.WriteLine("Content:");
            foreach (var item in Content)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}

namespace String_Ayrıştırma;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen ayrıştırmak istediğiniz cümleyi aralarda virgül olacak şekilde giriniz...");
        string input = Console.ReadLine();
        string[] items = input.Split(',');
        List<string> words = new List<string>();
        foreach (var item in items)
        {
            // Sayıları çıkararak sadece harfler ve boşlukları koruyan kısmı al
            string cleanedItem = new string(item.Where(c => !char.IsDigit(c)).ToArray());
            if (!string.IsNullOrEmpty(cleanedItem))
            {
                words.Add(cleanedItem.Trim());
            }
        }        
        Console.WriteLine("Kelimeler:");
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
        Console.ReadKey();
    }
}

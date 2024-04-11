
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
           List<string> myList = new List<string>();

            myList.Add("GTA 5");
            myList.Add("2K 15");
            myList.Add("Pub G");
            myList.Add("COD Black ops");
            myList.Add("APEX");
            myList.Add("FortNite");
            myList.Add("Dead Island 2");
            myList.Add("Roblox");
            myList.Add("MineCraft");
            myList.Add("Mortal Combat");
            myList.Add("Saints Row");
            myList.Add("Crackdown 3");

        var inOrderByLength = myList.OrderBy(x => x.Length);

            foreach(string item in inOrderByLength)
            {
                Console.WriteLine(item);
            }
        }
    }
}

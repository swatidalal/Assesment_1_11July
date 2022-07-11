namespace Assesment_1_11July
{
    public class Question_9
    {
        public void GenDic()
        {
            Dictionary<int,string> Players = new Dictionary<int, string>();
            Players.Add(1, "Virat");
            Players.Add(2, "Ms Dhoni");
            Players.Add(3, "Rahul");
            Players.Add(4, "Rohit");
            Players.Add(5,"Sachin");
            Players.Add(6, "Mohit");
            Players.Add(7, "Mitali");
            Players.Add(8, "Hardik");
            Players.Add(9, "yash");
            Players.Add(10, "Kartik");
            Players.Add(11, "Amit");
            Console.WriteLine("All players List:");
            foreach (KeyValuePair<int,string> player in Players)
            {
                Console.WriteLine(" Value: {1},Key: {0}", player.Value, player.Key);
            }
        }
    }
}

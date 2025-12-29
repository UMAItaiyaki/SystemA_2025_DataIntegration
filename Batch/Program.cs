using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        string category = args[0];  // 処理区分
        string start = args[1];     // 開始年月
        string end = args[2];       // 終了年月

        try
        {
            // 店舗売上データ送信
            if (category == "1")
            {
                //Console.WriteLine(category);
                //Console.WriteLine(start);
                //Console.WriteLine(end);                
            }
            //店舗売上データ送信
            else if (category == "2")
            {
                //Console.WriteLine(category);                
            }
            // 正常終了
            Environment.Exit(0);
        }
        catch (Exception ex)
        {
            // 異常終了
            Environment.Exit(1);
        }
    }
}
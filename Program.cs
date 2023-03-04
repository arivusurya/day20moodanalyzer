using System;


namespace MoodAnalyserWorkspace{


    public class Program{
        public static void Main(string[] args)
        {
            MoodAnalyser obj = new MoodAnalyser();
            string value =obj.analyzeMood("I am in Any Mood");
            Console.Write(value);
        }
    }



}
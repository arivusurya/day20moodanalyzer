using System;

public class MoodAnalyser{

    public String analyzeMood(string Message){
        if (Message == "I am in Sad Mood"){
            return "Sad";
        }else{
            return "Happy";
        }
    }

}
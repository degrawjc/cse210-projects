//Good

public class PromptGenerator
{
public List<string> _promptlist = new List<string>{
"What was something new you learned today?",
"What was your favorite part of the day?",
"What plans do you have for tomorrow?",
"What are you looking forward to in the next few days?",
"Is there anything that has been on your mind recently?",
"Who/what left an impact on you today?",
"What was the most challenging part of the day?",
"What am I the most proud of today?",
"How did I see the hand of the Lord in my lfe today?"
};
public string GetRandomPrompt()
{
    Random get_index = new Random();
    int index = get_index.Next(0, _promptlist.Count);
    return _promptlist[index];
}

}

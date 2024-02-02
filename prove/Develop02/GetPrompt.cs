public class GetPrompt
{
    string[] prompts = new string[5];
    public GetPrompt()
    {
        prompts[0] = "Who was the most interesting person I interacted with today?";
        prompts[1] = "What was the best part of my day?";
        prompts[2] = "How did I see the hand of the Lord in my life today?";
        prompts[3] = "What was the strongest emotion I felt today?";
        prompts[4] = "If I had one thing I could do over today, what would it be?";
    }
    public string Prompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 5);
        return prompts[randomNumber];
    }
}
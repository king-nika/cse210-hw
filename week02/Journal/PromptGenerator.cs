public class PromptGenerator
{
    List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What am I grateful for today?",
            "Did I do something kind for someone else today?",
            "What challenged me today, and how did I respond?",
            "Did I learn something new today?",
            "How did I take care of myself today?",
            "Was there a moment I felt at peace?",
            "What decision did I make today that I feel good about?",
            "Did I spend my time on what matters most to me?",
            "Is there something I need to forgive myself or someone else for?",
            "What am I looking forward to tomorrow?"
        };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
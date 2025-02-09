// Class template to generate random prompts.

public class RandomPrompts
{
    //method
    public string GetRandomPrompt(List<String> prompts)
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, prompts.Count);
        string randomPrompt = prompts[randomIndex];
        return randomPrompt;
    }
}
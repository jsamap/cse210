class PromptGenerator
{
    public List<string> _prompts;
    public string GetRandomPrompt()
    {
        return _prompts[new Random().Next(0,_prompts.Count-1)];
    }
}
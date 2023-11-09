using System;

class Reflection : Activity
{

    private string[] _prompts;
    private string[] _question;

    public Reflection(int duration, string spinner, string description, string response, string[] prompts, string[] question)
        : base(duration, spinner, description, response)
    {
        _prompts = prompts;
        _question = question;

    }

    public string getPrompt(int index)
    {
        return _prompts[index];
    }

    public void setPrompt(string prompt, int index)
    {
        _prompts[index] = prompt;

    }

    public string getQuestion(int index)
    {
        return _question[index];
    }

    public void setQuestion(string[] question)
    {
        _question = question;
    }

    public void startReflection()
    {
        List<string> prompts = new List<string>{
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        
    }
}
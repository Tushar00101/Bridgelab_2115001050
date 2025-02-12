using System;
using System.Collections.Generic;

class TextState
{
    public string Content;
    public TextState Prev, Next;
    
    public TextState(string content)
    {
        Content = content;
        
        Prev = Next = null;
    }
}

class TextEditor
{
    private TextState current;
    private int maxHistory = 10;
    
    private int historyCount = 0;
    
    public void AddState(string content)
    {
        TextState newState = new TextState(content);
        if (current != null)
        {
            newState.Prev = current;
            
            current.Next = newState;
        }
        current = newState;
        
        historyCount++;
        
        if (historyCount > maxHistory)
        {
            TextState temp = current;
            while (temp.Prev != null && historyCount > maxHistory)
            {
                temp = temp.Prev;
                
                temp.Next = null;
                
                historyCount--;
            }
        }
    }
    
    public void Undo()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            
            Console.WriteLine("Undo: " + current.Content);
        }
        else
            Console.WriteLine("No more undo available.");
    }
    
    public void Redo()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            
            Console.WriteLine("Redo: " + current.Content);
        }
        else
            Console.WriteLine("No more redo available.");
    }
    
    public void DisplayCurrent()
    {
        if (current != null)
            Console.WriteLine("Current State: " + current.Content);
        else
            Console.WriteLine("No content available.");
    }
    
    static void Main()
    {
        TextEditor editor = new TextEditor();
        editor.AddState("Hello");
        
        editor.AddState("Hello World");
        
        editor.AddState("Hello World!");
        
        Console.WriteLine("Displaying Current State:");
        
        editor.DisplayCurrent();
        
        Console.WriteLine("Performing Undo:");
        
        editor.Undo();
        
        editor.Undo();
        
        editor.Undo();
        
        Console.WriteLine("Performing Redo:");
        
        editor.Redo();
        
        editor.Redo();
    }
}

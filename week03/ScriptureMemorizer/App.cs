

public class App
{
    string _text = @"
Trust in the LORD with all thine heart; 
And lean not unto thine own understanding. 
In all thy ways acknowledge him, And he shall direct thy paths.
";
    public void Execute()
    {
        UI ui = new UI();
        
        // create a Reference
        Reference reference = new Reference("Proverbs","3","5","6");
        // create a Scripture;
        Scripture scripture = new Scripture(reference, _text);
        string input;

        // Display Scripture;
        //Console.WriteLine(scripture.Get_Scripture());
        ui.Clear_Console();
        ui.Display_Scripture(scripture, hidden: false);
        while (!scripture.All_WordsHidden())
        {
           

            
            
            input = ui.Wait_ForEnter();
            
             if (input == "quit")
            {
                ui.Display_QuitMessage();
                return;
            }
        
            scripture.Hide_RandomWords();
            ui.Clear_Console();
            ui.Display_Scripture(scripture, hidden: true);
            
        }
        
        
        
        ui.Display_EndingMessage();
    }
    
}
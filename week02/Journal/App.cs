


using System.Security.Cryptography.X509Certificates;

public class App
{
    UI _ui = new UI();
    Prompt _prompt = new Prompt();

    Journal _journal = new Journal();
    FileManager _fileManager = new FileManager();
    
    string _userChoice = "";
    bool isContinue = true;

    public void Execute()
    {
        _ui.Clear_Console();
        _ui.Display_Welcome_Message();
        while (isContinue)
        {

            _ui.Display_A_BlankLine();
            _ui.Display_Menu();
            _userChoice = _ui.Get_UserChoice();

            switch (_userChoice)
            {
                case "1":
                    string entry_text = "";
                    _prompt.Get_RandomPrompt();
                    _prompt.Display_RandomPrompt();
                    _prompt.Get_CurrentDate();
                    _prompt.Display_InputPrompt();
                    _prompt.Enter_UserAnswer();

                    entry_text = _prompt.AssignToEntry();
                    Entry _entry = new Entry(entry_text);
                    _journal.AssignToJournal(_entry);
                    _ui.Pause();
                    break;
                case "2":
                    _journal.Display_Journal();
                    _ui.Pause();
                    break;
                case "3": // Load
                    List<Entry> loadedEntries = _fileManager.Load_File();
                    foreach (Entry entry in loadedEntries)
                    {
                        _journal.AssignToJournal(entry);
                    }
                    _ui.Pause();
                    break;
                case "4": // Save
                    _fileManager.Save_File(_journal.Get_AllEntries());
                    _ui.Pause();
                    break;
                case "5":
                    isContinue = false;

                    break;
                default:
                    Console.WriteLine("Invalid Choice! ");
                    break;
            }






        }


    }

        


        




    
    
    
}
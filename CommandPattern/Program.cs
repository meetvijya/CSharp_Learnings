using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Document docObj = new Document();

            ActionOpen OpenActionObj = new ActionOpen(docObj);
            ActionSave SaveActionObj = new ActionSave(docObj);
            MenuOptions mo = new MenuOptions(OpenActionObj, SaveActionObj);

            mo.ClickOpen();
            mo.ClickSave();
            Console.ReadKey();
        }

        class Document
        {
            public void OpenDocument()
            { Console.WriteLine("Document Opened"); }

            public void SaveDocument()
            { Console.WriteLine("Document Saved"); }
        }

        interface IActionCommand
        {
            void execute();
        }

        class ActionOpen:IActionCommand
        {
            public Document doc;
            public ActionOpen(Document doc)
            { this.doc = doc; }   
            
            public void execute()
            { doc.OpenDocument(); }      
            
        }

        class ActionSave : IActionCommand
        {
            public Document doc;
            public ActionSave(Document doc)
            { this.doc = doc; }

            public void execute()
            { doc.SaveDocument(); }

        }

        class MenuOptions
        {
            IActionCommand openActionObj;
            IActionCommand savectionObj;

            public MenuOptions(IActionCommand open, IActionCommand save)
            {
                openActionObj = open;
                savectionObj = save;
            }

            public void ClickOpen()
            {
                openActionObj.execute();
            }

           public  void ClickSave()
            {
                savectionObj.execute();
            }
        }

    }
}

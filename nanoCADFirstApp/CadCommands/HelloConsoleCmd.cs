using HostMgd.ApplicationServices;
using HostMgd.EditorInput;
using Teigha.Runtime;
using Application = HostMgd.ApplicationServices.Application;

namespace nanoCADFirstApp.CadCommands
{
    public static class HelloConsoleCmd
    {
        [CommandMethod("-hello")]
        public static void HelloConsoleCommand()
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            if (doc == null)
            {
                // Если каким-то чудом активного документа нет, выходим
                return;
            }

            Editor ed = doc.Editor;

            ed.WriteMessage("\nHello");
        }
    }
}

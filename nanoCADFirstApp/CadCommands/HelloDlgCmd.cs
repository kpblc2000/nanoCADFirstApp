using Teigha.Runtime;

namespace nanoCADFirstApp.CadCommands
{
    public static class HelloDlgCmd
    {
        [CommandMethod("hello")]
        public static void HelloDlgCommand()
        {
            MessageBox.Show("Hello to MessageBox", "First Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

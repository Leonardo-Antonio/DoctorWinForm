using System.Windows.Forms;

namespace Doctor.LocalStorage
{
    public class MessageResponse
    {
        public static bool Show(int response, IWin32Window ow, string op)
        {
            if (response != 1)
            {
                MetroFramework.MetroMessageBox.Show(
                    ow, "No hubieron filas afectafas",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return false;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(
                    ow, $"Registro {op.ToLower()} correctamente",
                    op.ToUpper(),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );
                return true;
            }
        }
    }
}

using System.Windows.Forms;

namespace System
{
    internal class PaintEventHandler
    {
        private Action<object, PaintEventArgs> btnGrid_Click;

        public PaintEventHandler(Action<object, PaintEventArgs> btnGrid_Click)
        {
            this.btnGrid_Click = btnGrid_Click;
        }
    }
}
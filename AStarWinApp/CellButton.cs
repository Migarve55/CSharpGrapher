using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AStarWinApp
{
    public class CellButton : Button
    {

        private readonly int _x, _y;
        private bool _state;

        public int X => _x;
        public int Y => _y;

        public bool State
        {
            get => _state;
            set => _state = value;
        }

        public CellButton(int x, int y)
        {
            _x = x;
            _y = y;
            _state = false;
            Margin = new Padding(0);
            BackColor = Color.White;
        }

        public sealed override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }

        public void ToggleState()
        {
            _state = !_state;
            BackColor = _state ? Color.Black : Color.White;
            OnBackColorChanged(new EventArgs());
        }

        public void SetMarked()
        {
            BackColor = Color.Red;
        }

        public void SetUnmarked()
        {
            BackColor = _state ? Color.Black : Color.White;
        }

        public void ResetState()
        {
            _state = false;
            BackColor = Color.White;
        }
        
    }
}
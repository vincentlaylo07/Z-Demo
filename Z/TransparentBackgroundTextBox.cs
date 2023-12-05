using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Z
{
    // Custom TextBox with a transparent background and colored bottom border
    public class TransparentBackgroundTextBox : TextBox
    {
        private const int WM_PAINT = 0xF;
        private bool isTyping = false;

        // Importing necessary functions from user32.dll for caret visibility control
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int HideCaret(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int ShowCaret(IntPtr hWnd);

        // Constructor for the custom TextBox
        public TransparentBackgroundTextBox()
        {
            // Set various control styles for custom appearance
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);

            // Set the background color to transparent and remove the standard border
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.None;

            // Hide the caret (text cursor) by default
            SetCaretVisible(false);

            // Subscribe to events for tracking typing
            this.KeyPress += OnTextBoxKeyPress;
            this.KeyUp += OnTextBoxKeyUp;
        }

        // Helper method to show or hide the caret
        private void SetCaretVisible(bool visible)
        {
            if (visible)
            {
                ShowCaret(Handle);
            }
            else
            {
                HideCaret(Handle);
            }
        }

        // Handle the KeyPress event to show the caret when typing starts
        private void OnTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            isTyping = true;
            SetCaretVisible(true);
        }

        // Handle the KeyUp event to hide the caret when typing stops
        private void OnTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            isTyping = false;
            SetCaretVisible(false);
        }

        // Override WndProc to customize the painting of the TextBox
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // Handle the paint message
            if (m.Msg == WM_PAINT)
            {
                // Get the graphics object for drawing on the control
                using (Graphics graphics = Graphics.FromHwnd(Handle))
                {
                    // Fill the background with the specified back color
                    using (SolidBrush backBrush = new SolidBrush(BackColor))
                    {
                        graphics.FillRectangle(backBrush, ClientRectangle);
                    }

                    // Draw a custom-colored bottom border using a Pen
                    using (Pen borderPen = new Pen(Color.FromArgb(60, 60, 65), 1))
                    {
                        graphics.DrawLine(borderPen, new Point(0, ClientSize.Height - 1), new Point(ClientSize.Width, ClientSize.Height - 1));
                    }

                    // Draw the text with specified formatting
                    if (!string.IsNullOrEmpty(Text))
                    {
                        TextFormatFlags flags = TextFormatFlags.EndEllipsis | TextFormatFlags.NoPadding;
                        TextRenderer.DrawText(graphics, Text, Font, ClientRectangle, ForeColor, BackColor, flags);
                    }
                }

                // Check typing status and show/hide caret accordingly
                SetCaretVisible(isTyping);
            }
        }
        // Override methods to handle focus and text changes
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            SetCaretVisible(isTyping);
        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            SetCaretVisible(false);
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            SetCaretVisible(isTyping);
        }
    }
}
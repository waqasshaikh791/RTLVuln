using System;
using System.Drawing;
using System.Windows.Forms;

namespace RTLVuln
{
    public class RichTextBoxComparer
    {
        private readonly RichTextBox _rtbLeft;
        private readonly RichTextBox _rtbRight;
        private readonly Color _differenceColor = Color.Pink;
        private readonly Color _addedColor = Color.LightGreen;

        public RichTextBoxComparer(RichTextBox left, RichTextBox right)
        {
            _rtbLeft = left;
            _rtbRight = right;

            _rtbLeft.TextChanged += (s, e) => CompareText();
            _rtbRight.TextChanged += (s, e) => CompareText();
        }

        public void CompareText()
        {
            int currentPos = _rtbRight.SelectionStart;
            int currentLen = _rtbRight.SelectionLength;
            Color currentBackColor = _rtbRight.SelectionBackColor;
            Color currentForeColor = _rtbRight.SelectionColor;

            _rtbRight.SelectAll();
            _rtbRight.SelectionBackColor = _rtbRight.BackColor;
            _rtbRight.SelectionColor = _rtbRight.ForeColor;

            string[] leftLines = _rtbLeft.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            string[] rightLines = _rtbRight.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            int charIndex = 0;
            for (int i = 0; i < rightLines.Length; i++)
            {
                int lineLength = rightLines[i].Length;

                if (i < leftLines.Length && rightLines[i] != leftLines[i])
                {
                    _rtbRight.Select(charIndex, lineLength);
                    _rtbRight.SelectionBackColor = _differenceColor;
                }
                else if (i >= leftLines.Length)
                {
                    _rtbRight.Select(charIndex, lineLength);
                    _rtbRight.SelectionBackColor = _addedColor;
                }

                charIndex += lineLength;
                if (i < rightLines.Length - 1)
                {
                    charIndex += Environment.NewLine.Length;
                }
            }

            _rtbRight.Select(currentPos, currentLen);
            _rtbRight.SelectionBackColor = currentBackColor;
            _rtbRight.SelectionColor = currentForeColor;
            _rtbRight.ScrollToCaret();
        }
    }
}

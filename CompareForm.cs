using System;
using System.Windows.Forms;

namespace RTLVuln
{
    public partial class CompareForm : Form
    {
        string _response;
        string _vulnerableResponse;
        string _reason;

        public CompareForm(string response, string vulnerableResponse, string reason)
        {
            _response = response;
            _vulnerableResponse = vulnerableResponse;
            _reason = reason;
            InitializeComponent();
        }

        private void CompareForm_Load(object sender, EventArgs e)
        {
            VerilogSyntaxHighlighter rtbResponseHighlight = new VerilogSyntaxHighlighter(rtbResponse, false, true);
            rtbResponseHighlight.HighlightSyntax();
            VerilogSyntaxHighlighter rtbVunerableResponseHighlight = new VerilogSyntaxHighlighter(rtbVunerableResponse, true, true);
            rtbVunerableResponseHighlight.HighlightSyntax();
          //  RichTextBoxComparer richTextBoxComparer = new RichTextBoxComparer(rtbResponse, rtbVunerableResponse);
          //  richTextBoxComparer.CompareText();
            rtbResponse.Text = _response;
            rtbVunerableResponse.Text = _vulnerableResponse;
        }

        private void btnReason_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_reason, "Reason", MessageBoxButtons.OK);
        }
    }
}

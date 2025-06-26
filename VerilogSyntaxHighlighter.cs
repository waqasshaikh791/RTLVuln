using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class VerilogSyntaxHighlighter
{
    private readonly RichTextBox _rtb;
    private readonly string _bugMarker = "$$bug";
    private readonly Color _bugColor = Color.Yellow;
    bool IsVulnerable = false;
    bool IsExecute = false;

    private readonly string[] _keywords = {
        "module", "endmodule", "input", "output", "inout", "wire", "reg", "parameter",
        "localparam", "integer", "real", "time", "realtime", "supply0", "supply1",
        "assign", "always", "initial", "begin", "end", "if", "else", "case", "endcase",
        "default", "for", "while", "repeat", "forever", "fork", "join", "function",
        "endfunction", "task", "endtask", "specify", "endspecify", "posedge", "negedge",
        "or", "and", "xor", "xnor", "not", "buf", "nand", "nor", "defparam", "include",
        "timescale", "generate", "endgenerate", "celldefine", "endcelldefine"
    };

    // Verilog system tasks/functions
    private readonly string[] _systemTasks = {
        "$display", "$write", "$strobe", "$monitor", "$time", "$random", "$stop",
        "$finish", "$fopen", "$fclose", "$fdisplay", "$fwrite", "$readmemh", "$readmemb"
    };

    // Verilog operators
    private readonly string[] _operators = { "=", "<=", ">=", "==", "!=", "===", "!==", "&&", "||", "!", "&", "|", "^", "~", "<<", ">>", "+", "-", "*", "/", "%", "?", ":" };

    public VerilogSyntaxHighlighter(RichTextBox rtb, bool isVulnerable, bool IsExecute)
    {
        _rtb = rtb;
        this.IsVulnerable = isVulnerable;
        if (IsExecute)
        {
            _rtb.TextChanged += (s, e) => HighlightSyntax();
        }
    }

    public void HighlightSyntax()
    {
        int currentPos = _rtb.SelectionStart;
        int currentLen = _rtb.SelectionLength;
        Color currentColor = _rtb.SelectionColor;

        _rtb.SelectAll();
        _rtb.SelectionColor = _rtb.ForeColor;

        // Highlight keywords
        foreach (string keyword in _keywords)
        {
            HighlightPattern(@"\b" + keyword + @"\b", Color.Blue, FontStyle.Bold);
        }

        // Highlight system tasks
        foreach (string task in _systemTasks)
        {
            HighlightPattern(task + @"\b", Color.DarkMagenta, FontStyle.Regular);
        }

        // Highlight numbers
        HighlightPattern(@"\b\d+\b", Color.DarkRed, FontStyle.Regular);
        HighlightPattern(@"\b\d+'[bhd]\w+\b", Color.DarkRed, FontStyle.Regular);

        // Highlight strings
        HighlightPattern("\"[^\"]*\"", Color.DarkRed, FontStyle.Regular);

        // Highlight comments
        HighlightPattern(@"//.*$", Color.Green, FontStyle.Italic);
        HighlightPattern(@"/\*.*?\*/", Color.Green, FontStyle.Italic);

       
        // Highlight operators
        foreach (string op in _operators)
        {
            HighlightPattern(Regex.Escape(op), Color.DarkBlue, FontStyle.Regular);
        }

        if (IsVulnerable)
        {
            HighlightBugLines();
        }

        _rtb.Select(currentPos, currentLen);
        _rtb.SelectionColor = currentColor;
        _rtb.ScrollToCaret();
    }

    private void HighlightPattern(string pattern, Color color, FontStyle style)
    {
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);

        foreach (Match match in regex.Matches(_rtb.Text))
        {
            _rtb.Select(match.Index, match.Length);
            _rtb.SelectionColor = color;
            _rtb.SelectionFont = new Font(_rtb.Font, style);
        }
    }

    public void HighlightBugLines()
    {
        int currentPos = _rtb.SelectionStart;
        int currentLen = _rtb.SelectionLength;
        Color currentBackColor = _rtb.SelectionBackColor;

        _rtb.SelectAll();
        _rtb.SelectionBackColor = _rtb.BackColor;

        string[] lines = _rtb.Text.Split('\n');
        int charIndex = 0;

        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].Contains(_bugMarker))
            {
                int lineStart = charIndex;
                int lineLength = lines[i].Length;

                _rtb.Select(lineStart, lineLength);
                _rtb.SelectionBackColor = _bugColor;
            }

            charIndex += lines[i].Length + 1;
        }

        _rtb.Select(currentPos, currentLen);
        _rtb.SelectionBackColor = currentBackColor;
        _rtb.ScrollToCaret();
    }

}
using System;
using System.Windows.Forms;
using oic.Generator;
using oic.Lexer;
using oic.Parser;
using oic.Utils;
using ScintillaNET;

namespace oic
{
    public partial class MainForm : Form
    {
        private Scintilla _dfmTextArea;
        private Scintilla _codeTextArea;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            _dfmTextArea = new ScintillaNET.Scintilla();
            DfmPanel.Controls.Add(_dfmTextArea);
            InitDfmPanel(_dfmTextArea, 0x40568D, 0x007ACC, 0x5D6B99, 0xFFFFFF);

            _codeTextArea = new ScintillaNET.Scintilla();
            CodePanel.Controls.Add(_codeTextArea);
            InitDfmPanel(_codeTextArea, 0x40568D, 0x007ACC, 0x5D6B99, 0xFFFFFF);

            Logger.OnLog = (text) => LogTextBox.Text += (text + Environment.NewLine);
        }

        private void InitDfmPanel(Scintilla textArea, int backColor, int foreColor, int marginBackColor = 0x2A211C, int marginForeColor = 0xB7B7B7)
        {
            textArea.Dock = System.Windows.Forms.DockStyle.Fill;

            textArea.WrapMode = WrapMode.None;
            textArea.IndentationGuides = IndentView.LookBoth;

            textArea.SetSelectionBackColor(true, Ux.IntToColor(0x114D9C));

            // Configure the default style
            textArea.StyleResetDefault();
            textArea.Styles[Style.Default].Font = "Consolas";
            textArea.Styles[Style.Default].Size = 12;
            textArea.Styles[Style.Default].BackColor = Ux.IntToColor(backColor);
            textArea.Styles[Style.Default].ForeColor = Ux.IntToColor(foreColor);
            textArea.StyleClearAll();

            textArea.Styles[Style.Cpp.Operator].ForeColor = Ux.IntToColor(0xE0E0E0);

            // Configure the CPP (C#) lexer styles
            textArea.Styles[Style.Cpp.Identifier].ForeColor = Ux.IntToColor(0xD0DAE2);
            textArea.Styles[Style.Cpp.Comment].ForeColor = Ux.IntToColor(0xBD758B);
            textArea.Styles[Style.Cpp.CommentLine].ForeColor = Ux.IntToColor(0x40BF57);
            textArea.Styles[Style.Cpp.CommentDoc].ForeColor = Ux.IntToColor(0x2FAE35);
            textArea.Styles[Style.Cpp.Number].ForeColor = Ux.IntToColor(0xFFFF00);
            textArea.Styles[Style.Cpp.String].ForeColor = Ux.IntToColor(0xFFFF00);
            textArea.Styles[Style.Cpp.Character].ForeColor = Ux.IntToColor(0xE95454);
            textArea.Styles[Style.Cpp.Preprocessor].ForeColor = Ux.IntToColor(0x8AAFEE);
            textArea.Styles[Style.Cpp.Operator].ForeColor = Ux.IntToColor(0xE0E0E0);
            textArea.Styles[Style.Cpp.Regex].ForeColor = Ux.IntToColor(0xff00ff);
            textArea.Styles[Style.Cpp.CommentLineDoc].ForeColor = Ux.IntToColor(0x77A7DB);
            textArea.Styles[Style.Cpp.Word].ForeColor = Ux.IntToColor(0x48A8EE);
            textArea.Styles[Style.Cpp.Word2].ForeColor = Ux.IntToColor(0xF98906);
            textArea.Styles[Style.Cpp.CommentDocKeyword].ForeColor = Ux.IntToColor(0xB3D991);
            textArea.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = Ux.IntToColor(0xFF0000);
            textArea.Styles[Style.Cpp.GlobalClass].ForeColor = Ux.IntToColor(0x48A8EE);

            textArea.Lexer = ScintillaNET.Lexer.Cpp;

            textArea.SetKeywords(0, "class extends implements import interface new case do while else if for in switch throw get set function var try catch finally while with default break continue delete return each const namespace package include use is as instanceof typeof author copy default deprecated eventType example exampleText exception haxe inheritDoc internal link mtasc mxmlc param private return see serial serialData serialField since throws usage version langversion playerversion productversion dynamic private public partial static intrinsic internal native override protected AS3 final super this arguments null Infinity NaN undefined true false abstract as base bool break by byte case catch char checked class const continue decimal default delegate do double descending explicit event extern else enum false finally fixed float for foreach from goto group if implicit in int interface internal into is lock long new null namespace object operator out override orderby params private protected public readonly ref return switch struct sbyte sealed short sizeof stackalloc static string select this throw true try typeof uint ulong unchecked unsafe ushort using var virtual volatile void while where yield end begin var function procedure Result");
            textArea.SetKeywords(1, "void Null ArgumentError arguments Array Boolean Class Date DefinitionError Error EvalError Function int Math Namespace Number Object RangeError ReferenceError RegExp SecurityError String SyntaxError TypeError uint XML XMLList Boolean Byte Char DateTime Decimal Double Int16 Int32 Int64 IntPtr SByte Single UInt16 UInt32 UInt64 UIntPtr Void Path File System Windows Forms ScintillaNET");
  
            textArea.Styles[Style.LineNumber].BackColor = Ux.IntToColor(marginBackColor);
            textArea.Styles[Style.LineNumber].ForeColor = Ux.IntToColor(marginForeColor);
            textArea.Styles[Style.IndentGuide].ForeColor = Ux.IntToColor(marginForeColor);
            textArea.Styles[Style.IndentGuide].BackColor = Ux.IntToColor(marginBackColor);

            var nums = textArea.Margins[1];
            nums.Width = 30;
            nums.Type = MarginType.Number;
            nums.Sensitive = true;
            nums.Mask = 0;
        }

        private void ExampleButton_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(((Button) sender).Tag);
            var sample = DfmSamples.GetSample(id);
            _dfmTextArea.Text = sample;
            GenerateCode();
        }

        private void CodeGenButton_Click(object sender, EventArgs e) => GenerateCode();
        
        private void GenerateCode()
        {
            LogTextBox.Text = "";

            var dfm = _dfmTextArea.Text;

            _codeTextArea.ClearAll();

            Logger.WriteLn("Code generation beginning..." + Environment.NewLine);

            if (string.IsNullOrWhiteSpace(dfm))
            {
                Logger.WriteLn("Dfm is empty, nothing to do.");
                return;
            }

            try
            {
                var tokens = Tokenizer.Execute(dfm);
                var dfmObject = DfmParser.Execute(tokens);
                var code = CodeGen.Execute(dfmObject);

                _codeTextArea.Text = code;
            }
            catch (Exception e)
            {
                Logger.OnLog($"Error occured during processing:{Environment.NewLine}{e}");
            }
        }
    }
}

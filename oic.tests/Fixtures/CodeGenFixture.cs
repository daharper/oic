using System;
using NUnit.Framework;
using oic.Generator;
using oic.Lexer;
using oic.Parser;

namespace oic.tests.Fixtures
{
    [TestFixture]
    public class CodeGenFixture
    {
        private const string Dfm = @"
            object Rectangle1: TRectangle
                Align = Top
                DragMode = dmAutomatic
                Fill.Color = xFF0A45A6
                Margins.Top = 5.000000000000000000
                Margins.Bottom = 5.000000000000000000
                Position.Y = 5.000000000000000000
                Size.Width = 263.000000000000000000
                Size.Height = 84.000000000000000000
                Size.PlatformDefault = False
                OnDragOver = Rectangle1DragOver
                OnDragDrop = Rectangle1DragDrop
                OnMouseDown = Rectangle1MouseDown
                object Text2: TText
                    Align = Center
                    HitTest = False
                    Size.Width = 193.000000000000000000
                    Size.Height = 50.000000000000000000
                    Size.PlatformDefault = False
                    Text = 'DELPHI CREATIVE'
                    TextSettings.Font.Size = 20.000000000000000000
                    TextSettings.FontColor = claWhite
                end
            end
        ";

        [Test]
        public void Given_Dfm_Should_Produce_Code()
        {
            var tokens = Tokenizer.Execute(Dfm);
            var dfmObject = DfmParser.Execute(tokens);
            var code = CodeGen.Execute(dfmObject);

            Console.WriteLine(code);
        }
    }
}

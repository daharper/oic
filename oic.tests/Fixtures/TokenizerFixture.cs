using System;
using System.Collections.Generic;
using NUnit.Framework;
using oic.Lexer;

namespace oic.tests.Fixtures
{
    [TestFixture]
    public class TokenizerFixture
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
        public void Given_Dfm_Should_Emit_Tokens()
        {
            var expectedTokens = new List<string> {
                "object",
                "Rectangle1",
                "TRectangle",
                "Align",
                "=",
                "Top",
                "DragMode",
                "=",
                "dmAutomatic",
                "Fill.Color",
                "=",
                "xFF0A45A6",
                "Margins.Top",
                "=",
                "5.000000000000000000",
                "Margins.Bottom",
                "=",
                "5.000000000000000000",
                "Position.Y",
                "=",
                "5.000000000000000000",
                "Size.Width",
                "=",
                "263.000000000000000000",
                "Size.Height",
                "=",
                "84.000000000000000000",
                "Size.PlatformDefault",
                "=",
                "False",
                "OnDragOver",
                "=",
                "Rectangle1DragOver",
                "OnDragDrop",
                "=",
                "Rectangle1DragDrop",
                "OnMouseDown",
                "=",
                "Rectangle1MouseDown",
                "object",
                "Text2",
                "TText",
                "Align",
                "=",
                "Center",
                "HitTest",
                "=",
                "False",
                "Size.Width",
                "=",
                "193.000000000000000000",
                "Size.Height",
                "=",
                "50.000000000000000000",
                "Size.PlatformDefault",
                "=",
                "False",
                "Text",
                "=",
                "'DELPHI CREATIVE'",
                "TextSettings.Font.Size",
                "=",
                "20.000000000000000000",
                "TextSettings.FontColor",
                "=",
                "claWhite",
                "end",
                "end",
            };

            var tokens = Tokenizer.Execute(Dfm);

            foreach (var token in tokens)
                Console.WriteLine(token.Text);

            Assert.AreEqual(expectedTokens.Count, tokens.Count);

            for(var i = 0; i < expectedTokens.Count; ++i)
            {
                Assert.AreEqual(expectedTokens[i], tokens[i].Text, "Error occurred at token position {0}", i);
            }
        }
    }
}

using System.Collections.Generic;
using NUnit.Framework;
using oic.Lexer;
using oic.Parser;

namespace oic.tests.Fixtures
{
    [TestFixture]
    public class ParserFixture
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

        private readonly List<DfmProperty> recProps = new List<DfmProperty>
        {
            { new DfmProperty(NewToken("Align", 2), "Top") },
            { new DfmProperty(NewToken("DragMode", 3),"dmAutomatic") },
            { new DfmProperty(NewToken("Fill.Color", 4),"xFF0A45A6") },
            { new DfmProperty(NewToken("Margins.Top", 5),"5.000000000000000000") },
            { new DfmProperty(NewToken("Margins.Bottom", 6),"5.000000000000000000") },
            { new DfmProperty(NewToken("Position.Y", 7),"5.000000000000000000") },
            { new DfmProperty(NewToken("Size.Width", 8),"263.000000000000000000") },
            { new DfmProperty(NewToken("Size.Height", 9),"84.000000000000000000") },
            { new DfmProperty(NewToken("Size.PlatformDefault",10), "False") },
            { new DfmProperty(NewToken("OnDragOver", 11),"Rectangle1DragOver") },
            { new DfmProperty(NewToken("OnDragDrop", 12),"Rectangle1DragDrop") },
            { new DfmProperty(NewToken("OnMouseDown", 13),"Rectangle1MouseDown") },
        };

        private readonly List<DfmProperty> txtProps = new List<DfmProperty>
        {
            { new DfmProperty(NewToken("Align",15),"Center") },
            { new DfmProperty(NewToken("HitTest",16),"False") },
            { new DfmProperty(NewToken("Size.Width",17),"193.000000000000000000") },
            { new DfmProperty(NewToken("Size.Height",18),"50.000000000000000000") },
            { new DfmProperty(NewToken("Size.PlatformDefault",19),"False") },
            { new DfmProperty(NewToken("Text",20),"'DELPHI CREATIVE'") },
            { new DfmProperty(NewToken("TextSettings.Font.Size",21),"20.000000000000000000") },
            { new DfmProperty(NewToken("TextSettings.FontColor",22),"claWhite") },
        };

        private static Token NewToken(string name, int lineNumber) => new Token(name, lineNumber);

        [Test]
        public void Given_Tokens_Should_Build_DfmObjects()
        {
            var tokens = Tokenizer.Execute(Dfm.Trim());
            var dfmObject = DfmParser.Execute(tokens);

            Assert.AreEqual("Rectangle1", dfmObject.Name);
            Assert.AreEqual("TRectangle", dfmObject.Type);

            Assert.IsTrue(dfmObject.HasProperties);
            Assert.AreEqual(recProps.Count, dfmObject.PropertyCount);

            for (var i = 0; i < recProps.Count; ++i)
            {
                var recProp = recProps[i];
                var dfmProp = dfmObject.Properties[i];

                Assert.AreEqual(recProp.Name, dfmProp.Name);
                Assert.AreEqual(recProp.Value, dfmProp.Value);
                Assert.AreEqual(recProp.LineNumber, dfmProp.LineNumber);
            }

            Assert.IsTrue(dfmObject.HasObjects);
            Assert.AreEqual(1, dfmObject.ObjectCount);

            dfmObject = dfmObject.Objects[0];

            Assert.AreEqual("Text2", dfmObject.Name);
            Assert.AreEqual("TText", dfmObject.Type);

            Assert.IsTrue(dfmObject.HasProperties);
            Assert.AreEqual(txtProps.Count, dfmObject.PropertyCount);

            for (var i = 0; i < txtProps.Count; ++i)
            {
                var txtProp = txtProps[i];
                var dfmProp = dfmObject.Properties[i];

                Assert.AreEqual(txtProp.Name, dfmProp.Name);
                Assert.AreEqual(txtProp.Value, dfmProp.Value);
                Assert.AreEqual(txtProp.LineNumber, dfmProp.LineNumber);
            }
        }
    }
}

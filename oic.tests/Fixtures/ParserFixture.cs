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
            { new DfmProperty("Align", "Top") },
            { new DfmProperty("DragMode", "dmAutomatic") },
            { new DfmProperty("Fill.Color", "xFF0A45A6") },
            { new DfmProperty("Margins.Top", "5.000000000000000000") },
            { new DfmProperty("Margins.Bottom", "5.000000000000000000") },
            { new DfmProperty("Position.Y", "5.000000000000000000") },
            { new DfmProperty("Size.Width", "263.000000000000000000") },
            { new DfmProperty("Size.Height", "84.000000000000000000") },
            { new DfmProperty("Size.PlatformDefault", "False") },
            { new DfmProperty("OnDragOver", "Rectangle1DragOver") },
            { new DfmProperty("OnDragDrop", "Rectangle1DragDrop") },
            { new DfmProperty("OnMouseDown", "Rectangle1MouseDown") },
        };

        private readonly List<DfmProperty> txtProps = new List<DfmProperty>
        {
            { new DfmProperty("Align","Center") },
            { new DfmProperty("HitTest","False") },
            { new DfmProperty("Size.Width","193.000000000000000000") },
            { new DfmProperty("Size.Height","50.000000000000000000") },
            { new DfmProperty("Size.PlatformDefault","False") },
            { new DfmProperty("Text","'DELPHI CREATIVE'") },
            { new DfmProperty("TextSettings.Font.Size","20.000000000000000000") },
            { new DfmProperty("TextSettings.FontColor","claWhite") },
        };

        [Test]
        public void Given_Tokens_Should_Build_DfmObjects()
        {
            var tokens = Tokenizer.Execute(Dfm);
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
            }
        }
    }
}

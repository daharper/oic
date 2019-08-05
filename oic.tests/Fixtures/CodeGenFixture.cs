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

        private const string ExpectedCode = @"
// Add the function declaration to your form's private section in the interface
// You may need to add these units to the uses section: FMX.Objects, FMX.Layouts;

function TForm1.CreateRectangle() : TRectangle;
var
	Rectangle1: TRectangle;
	Text2: TText;
begin
	Rectangle1 := TRectangle.Create(nil);
	Rectangle1.Align := TAlignLayout.Top;
	Rectangle1.DragMode := TDragMode.dmAutomatic;
	Rectangle1.Fill.Color := $FF0A45A6;
	Rectangle1.Margins.Top := 5.000000000000000000;
	Rectangle1.Margins.Bottom := 5.000000000000000000;
	Rectangle1.Position.Y := 5.000000000000000000;
	Rectangle1.Size.Width := 263.000000000000000000;
	Rectangle1.Size.Height := 84.000000000000000000;
	Rectangle1.Size.PlatformDefault := False;
	// Rectangle1.OnDragOver := Rectangle1DragOver;
	// Rectangle1.OnDragDrop := Rectangle1DragDrop;
	// Rectangle1.OnMouseDown := Rectangle1MouseDown;

	Text2 := TText.Create(nil);
	Text2.Align := TAlignLayout.Center;
	Text2.HitTest := False;
	Text2.Size.Width := 193.000000000000000000;
	Text2.Size.Height := 50.000000000000000000;
	Text2.Size.PlatformDefault := False;
	Text2.Text := 'DELPHI CREATIVE';
	Text2.TextSettings.Font.Size := 20.000000000000000000;
	Text2.TextSettings.FontColor := TAlphaColors.White;

	Rectangle1.AddObject(Text2);

	Result := Rectangle1;
end;";

        [Test]
        public void Given_Dfm_Should_Produce_Code()
        {
            var tokens = Tokenizer.Execute(Dfm);
            var dfmObject = DfmParser.Execute(tokens);
            var code = CodeGen.Execute(dfmObject);

            Assert.AreEqual(ExpectedCode.Trim(), code.Trim());
        }
    }
}

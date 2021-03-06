﻿namespace oic.Utils
{
    public static class DfmSamples
    {
        public static string GetSample(int id)
        {
            switch (id)
            {
                case 2: return SampleTwo();
                case 3: return SampleThree();
                case 4: return SampleFour();
                default: return SampleOne();
            }
        }

        private static string SampleOne()
        {
            return @"
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
end".Trim();
        }

        private static string SampleTwo()
        {
            return @"
object Rectangle2: TRectangle
    Anchors = [akLeft, akTop, akBottom]
    Fill.Color = claWhite
    Position.X = 24.000000000000000000
    Position.Y = 24.000000000000000000
    Size.Width = 273.000000000000000000
    Size.Height = 441.000000000000000000
    Size.PlatformDefault = False
    Stroke.Color = claWhite
    object Rectangle3: TRectangle
      Align = Top
      ClipChildren = True
      Fill.Color = xFF396371
      Size.Width = 273.000000000000000000
      Size.Height = 50.000000000000000000
      Size.PlatformDefault = False
      Stroke.Color = xFF396371
      object Rectangle4: TRectangle
        Fill.Color = xFF1E8ACC
        Position.X = -49.000000000000000000
        Position.Y = -64.000000000000000000
        RotationAngle = 45.000000000000000000
        Size.Width = 130.000000000000000000
        Size.Height = 114.000000000000000000
        Size.PlatformDefault = False
        Stroke.Color = xFF1E8ACC
      end
    end
    object VertScrollBox1: TVertScrollBox
      Align = Client
      Margins.Left = 5.000000000000000000
      Margins.Top = 5.000000000000000000
      Margins.Right = 5.000000000000000000
      Margins.Bottom = 5.000000000000000000
      Size.Width = 263.000000000000000000
      Size.Height = 381.000000000000000000
      Size.PlatformDefault = False
      TabOrder = 1
      OnDragOver = Rectangle1DragOver
      OnDragDrop = Rectangle1DragDrop
      Viewport.Width = 263.000000000000000000
      Viewport.Height = 381.000000000000000000
      object Rectangle10: TRectangle
        Align = Top
        DragMode = dmAutomatic
        Fill.Color = xFFE26969
        Margins.Top = 5.000000000000000000
        Margins.Bottom = 5.000000000000000000
        Position.Y = 287.000000000000000000
        Size.Width = 263.000000000000000000
        Size.Height = 84.000000000000000000
        Size.PlatformDefault = False
        OnDragOver = Rectangle1DragOver
        OnDragDrop = Rectangle1DragDrop
        OnMouseDown = Rectangle1MouseDown
        object Text1: TText
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
      object Rectangle12: TRectangle
        Align = Top
        DragMode = dmAutomatic
        Fill.Color = xFFB9A811
        Margins.Top = 5.000000000000000000
        Margins.Bottom = 5.000000000000000000
        Position.Y = 193.000000000000000000
        Size.Width = 263.000000000000000000
        Size.Height = 84.000000000000000000
        Size.PlatformDefault = False
        OnDragOver = Rectangle1DragOver
        OnDragDrop = Rectangle1DragDrop
        OnMouseDown = Rectangle1MouseDown
        object Text5: TText
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
      object Rectangle13: TRectangle
        Align = Top
        DragMode = dmAutomatic
        Fill.Color = xFFCD0644
        Margins.Top = 5.000000000000000000
        Margins.Bottom = 5.000000000000000000
        Position.Y = 99.000000000000000000
        Size.Width = 263.000000000000000000
        Size.Height = 84.000000000000000000
        Size.PlatformDefault = False
        OnDragOver = Rectangle1DragOver
        OnDragDrop = Rectangle1DragDrop
        OnMouseDown = Rectangle1MouseDown
        object Text6: TText
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
    end
  end".Trim();
        }

        private static string SampleThree()
        {
            return @"
object Rectangle8: TRectangle
  Align = Contents
  Fill.Color = xFF54BEDA
  Size.Width = 1243.000000000000000000
  Size.Height = 480.000000000000000000
  Size.PlatformDefault = False
  object Rectangle14: TRectangle
    Anchors = [akLeft, akTop, akBottom]
    Fill.Color = claWhite
    Position.X = 616.000000000000000000
    Position.Y = 24.000000000000000000
    Size.Width = 273.000000000000000000
    Size.Height = 441.000000000000000000
    Size.PlatformDefault = False
    Stroke.Color = claWhite
    object Rectangle15: TRectangle
      Align = Top
      ClipChildren = True
      Fill.Color = xFF396371
      Size.Width = 273.000000000000000000
      Size.Height = 50.000000000000000000
      Size.PlatformDefault = False
      Stroke.Color = xFF396371
      object Rectangle16: TRectangle
        Fill.Color = xFF1B1BD8
        Position.X = -49.000000000000000000
        Position.Y = -64.000000000000000000
        RotationAngle = 45.000000000000000000
        Size.Width = 130.000000000000000000
        Size.Height = 114.000000000000000000
        Size.PlatformDefault = False
        Stroke.Color = xFF1E8ACC
      end
    end
    object VertScrollBox3: TVertScrollBox
      Align = Client
      Margins.Left = 5.000000000000000000
      Margins.Top = 5.000000000000000000
      Margins.Right = 5.000000000000000000
      Margins.Bottom = 5.000000000000000000
      Size.Width = 263.000000000000000000
      Size.Height = 381.000000000000000000
      Size.PlatformDefault = False
      TabOrder = 1
      OnDragOver = Rectangle1DragOver
      OnDragDrop = Rectangle1DragDrop
      Viewport.Width = 263.000000000000000000
      Viewport.Height = 381.000000000000000000
      object Rectangle17: TRectangle
        Align = Top
        DragMode = dmAutomatic
        Fill.Color = xFF242B28
        Margins.Top = 5.000000000000000000
        Margins.Bottom = 5.000000000000000000
        Position.Y = 5.000000000000000000
        Size.Width = 263.000000000000000000
        Size.Height = 84.000000000000000000
        Size.PlatformDefault = False
        OnDragOver = Rectangle1DragOver
        OnDragDrop = Rectangle1DragDrop
        OnMouseDown = Rectangle1MouseDown
        object Text7: TText
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
      object Rectangle18: TRectangle
        Align = Top
        DragMode = dmAutomatic
        Fill.Color = xFF288ADA
        Margins.Top = 5.000000000000000000
        Margins.Bottom = 5.000000000000000000
        Position.Y = 99.000000000000000000
        Size.Width = 263.000000000000000000
        Size.Height = 84.000000000000000000
        Size.PlatformDefault = False
        OnDragOver = Rectangle1DragOver
        OnDragDrop = Rectangle1DragDrop
        OnMouseDown = Rectangle1MouseDown
        object Text8: TText
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
    end
  end
  object Rectangle19: TRectangle
    Anchors = [akLeft, akTop, akBottom]
    Fill.Color = claWhite
    Position.X = 920.000000000000000000
    Position.Y = 24.000000000000000000
    Size.Width = 273.000000000000000000
    Size.Height = 441.000000000000000000
    Size.PlatformDefault = False
    Stroke.Color = claWhite
    object Rectangle20: TRectangle
      Align = Top
      ClipChildren = True
      Fill.Color = xFF396371
      Size.Width = 273.000000000000000000
      Size.Height = 50.000000000000000000
      Size.PlatformDefault = False
      Stroke.Color = xFF396371
      object Rectangle21: TRectangle
        Fill.Color = xFF1E8ACC
        Position.X = -49.000000000000000000
        Position.Y = -64.000000000000000000
        RotationAngle = 45.000000000000000000
        Size.Width = 130.000000000000000000
        Size.Height = 114.000000000000000000
        Size.PlatformDefault = False
        Stroke.Color = xFF1E8ACC
      end
    end
    object VertScrollBox4: TVertScrollBox
      Align = Client
      Margins.Left = 5.000000000000000000
      Margins.Top = 5.000000000000000000
      Margins.Right = 5.000000000000000000
      Margins.Bottom = 5.000000000000000000
      Size.Width = 263.000000000000000000
      Size.Height = 381.000000000000000000
      Size.PlatformDefault = False
      TabOrder = 1
      OnDragOver = Rectangle1DragOver
      OnDragDrop = Rectangle1DragDrop
      Viewport.Width = 263.000000000000000000
      Viewport.Height = 381.000000000000000000
      object Rectangle22: TRectangle
        Align = Top
        DragMode = dmAutomatic
        Fill.Color = xFFE26969
        Margins.Top = 5.000000000000000000
        Margins.Bottom = 5.000000000000000000
        Position.Y = 287.000000000000000000
        Size.Width = 263.000000000000000000
        Size.Height = 84.000000000000000000
        Size.PlatformDefault = False
        OnDragOver = Rectangle1DragOver
        OnDragDrop = Rectangle1DragDrop
        OnMouseDown = Rectangle1MouseDown
        object Text9: TText
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
      object Rectangle23: TRectangle
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
        object Text10: TText
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
      object Rectangle24: TRectangle
        Align = Top
        DragMode = dmAutomatic
        Fill.Color = xFFB9A811
        Margins.Top = 5.000000000000000000
        Margins.Bottom = 5.000000000000000000
        Position.Y = 193.000000000000000000
        Size.Width = 263.000000000000000000
        Size.Height = 84.000000000000000000
        Size.PlatformDefault = False
        OnDragOver = Rectangle1DragOver
        OnDragDrop = Rectangle1DragDrop
        OnMouseDown = Rectangle1MouseDown
        object Text11: TText
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
      object Rectangle25: TRectangle
        Align = Top
        DragMode = dmAutomatic
        Fill.Color = xFFCD0644
        Margins.Top = 5.000000000000000000
        Margins.Bottom = 5.000000000000000000
        Position.Y = 99.000000000000000000
        Size.Width = 263.000000000000000000
        Size.Height = 84.000000000000000000
        Size.PlatformDefault = False
        OnDragOver = Rectangle1DragOver
        OnDragDrop = Rectangle1DragDrop
        OnMouseDown = Rectangle1MouseDown
        object Text12: TText
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
    end
  end
  object Rectangle2: TRectangle
    Anchors = [akLeft, akTop, akBottom]
    Fill.Color = claWhite
    Position.X = 24.000000000000000000
    Position.Y = 24.000000000000000000
    Size.Width = 273.000000000000000000
    Size.Height = 441.000000000000000000
    Size.PlatformDefault = False
    Stroke.Color = claWhite
    object Rectangle3: TRectangle
      Align = Top
      ClipChildren = True
      Fill.Color = xFF396371
      Size.Width = 273.000000000000000000
      Size.Height = 50.000000000000000000
      Size.PlatformDefault = False
      Stroke.Color = xFF396371
      object Rectangle4: TRectangle
        Fill.Color = xFF1E8ACC
        Position.X = -49.000000000000000000
        Position.Y = -64.000000000000000000
        RotationAngle = 45.000000000000000000
        Size.Width = 130.000000000000000000
        Size.Height = 114.000000000000000000
        Size.PlatformDefault = False
        Stroke.Color = xFF1E8ACC
      end
    end
    object VertScrollBox1: TVertScrollBox
      Align = Client
      Margins.Left = 5.000000000000000000
      Margins.Top = 5.000000000000000000
      Margins.Right = 5.000000000000000000
      Margins.Bottom = 5.000000000000000000
      Size.Width = 263.000000000000000000
      Size.Height = 381.000000000000000000
      Size.PlatformDefault = False
      TabOrder = 1
      OnDragOver = Rectangle1DragOver
      OnDragDrop = Rectangle1DragDrop
      Viewport.Width = 263.000000000000000000
      Viewport.Height = 381.000000000000000000
      object Rectangle10: TRectangle
        Align = Top
        DragMode = dmAutomatic
        Fill.Color = xFFE26969
        Margins.Top = 5.000000000000000000
        Margins.Bottom = 5.000000000000000000
        Position.Y = 287.000000000000000000
        Size.Width = 263.000000000000000000
        Size.Height = 84.000000000000000000
        Size.PlatformDefault = False
        OnDragOver = Rectangle1DragOver
        OnDragDrop = Rectangle1DragDrop
        OnMouseDown = Rectangle1MouseDown
        object Text1: TText
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
      object Rectangle12: TRectangle
        Align = Top
        DragMode = dmAutomatic
        Fill.Color = xFFB9A811
        Margins.Top = 5.000000000000000000
        Margins.Bottom = 5.000000000000000000
        Position.Y = 193.000000000000000000
        Size.Width = 263.000000000000000000
        Size.Height = 84.000000000000000000
        Size.PlatformDefault = False
        OnDragOver = Rectangle1DragOver
        OnDragDrop = Rectangle1DragDrop
        OnMouseDown = Rectangle1MouseDown
        object Text5: TText
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
      object Rectangle13: TRectangle
        Align = Top
        DragMode = dmAutomatic
        Fill.Color = xFFCD0644
        Margins.Top = 5.000000000000000000
        Margins.Bottom = 5.000000000000000000
        Position.Y = 99.000000000000000000
        Size.Width = 263.000000000000000000
        Size.Height = 84.000000000000000000
        Size.PlatformDefault = False
        OnDragOver = Rectangle1DragOver
        OnDragDrop = Rectangle1DragDrop
        OnMouseDown = Rectangle1MouseDown
        object Text6: TText
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
    end
  end
  object Rectangle5: TRectangle
    Anchors = [akLeft, akTop, akBottom]
    Fill.Color = claWhite
    Position.X = 320.000000000000000000
    Position.Y = 24.000000000000000000
    Size.Width = 273.000000000000000000
    Size.Height = 441.000000000000000000
    Size.PlatformDefault = False
    Stroke.Color = claWhite
    object Rectangle6: TRectangle
      Align = Top
      ClipChildren = True
      Fill.Color = xFF396371
      Size.Width = 273.000000000000000000
      Size.Height = 50.000000000000000000
      Size.PlatformDefault = False
      Stroke.Color = xFF396371
      object Rectangle7: TRectangle
        Fill.Color = xFF48CC1E
        Position.X = -49.000000000000000000
        Position.Y = -64.000000000000000000
        RotationAngle = 45.000000000000000000
        Size.Width = 130.000000000000000000
        Size.Height = 114.000000000000000000
        Size.PlatformDefault = False
        Stroke.Color = xFF1E8ACC
      end
    end
    object VertScrollBox2: TVertScrollBox
      Align = Client
      Margins.Left = 5.000000000000000000
      Margins.Top = 5.000000000000000000
      Margins.Right = 5.000000000000000000
      Margins.Bottom = 5.000000000000000000
      Size.Width = 263.000000000000000000
      Size.Height = 381.000000000000000000
      Size.PlatformDefault = False
      TabOrder = 1
      OnDragOver = Rectangle1DragOver
      OnDragDrop = Rectangle1DragDrop
      Viewport.Width = 263.000000000000000000
      Viewport.Height = 381.000000000000000000
      object Rectangle11: TRectangle
        Align = Top
        DragMode = dmAutomatic
        Fill.Color = xFF088549
        Margins.Top = 5.000000000000000000
        Margins.Bottom = 5.000000000000000000
        Position.Y = 5.000000000000000000
        Size.Width = 263.000000000000000000
        Size.Height = 84.000000000000000000
        Size.PlatformDefault = False
        OnDragOver = Rectangle1DragOver
        OnDragDrop = Rectangle1DragDrop
        OnMouseDown = Rectangle1MouseDown
        object Text3: TText
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
      object Rectangle9: TRectangle
        Align = Top
        DragMode = dmAutomatic
        Fill.Color = xFF3E0547
        Margins.Top = 5.000000000000000000
        Margins.Bottom = 5.000000000000000000
        Position.Y = 99.000000000000000000
        Size.Width = 263.000000000000000000
        Size.Height = 84.000000000000000000
        Size.PlatformDefault = False
        OnDragOver = Rectangle1DragOver
        OnDragDrop = Rectangle1DragDrop
        OnMouseDown = Rectangle1MouseDown
        object Text4: TText
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
    end
  end
end".Trim();
        }

        private static string SampleFour()
        {
            return @"
object layout: TLayout
  Align = Top
  HitTest = True
  Size.Width = 250.000000000000000000
  Size.Height = 50.000000000000000000
  Size.PlatformDefault = False
  TabOrder = 0
  OnClick = layoutClick
  object img: TGlyph
    Position.X = 7.000000000000000000
    Position.Y = 9.000000000000000000
    Size.Width = 32.000000000000000000
    Size.Height = 32.000000000000000000
    Size.PlatformDefault = False
    ImageIndex = 0
    Images = ImageList1
  end
  object lbl: TLabel
    StyledSettings = [Family, Style]
    Position.X = 53.000000000000000000
    Position.Y = 9.000000000000000000
    Size.Width = 189.000000000000000000
    Size.Height = 32.000000000000000000
    Size.PlatformDefault = False
    TextSettings.Font.Size = 16.000000000000000000
    TextSettings.FontColor = claWhite
    Text = 'Toggle Menu'
    TabOrder = 1
  end
end".Trim();
        }
    }
}

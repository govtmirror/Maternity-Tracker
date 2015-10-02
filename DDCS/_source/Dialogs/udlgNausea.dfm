object dlgNausea: TdlgNausea
  Left = 217
  Top = 135
  BorderStyle = bsDialog
  ClientHeight = 228
  ClientWidth = 515
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Arial'
  Font.Style = []
  OldCreateOrder = False
  Position = poOwnerFormCenter
  Scaled = False
  PixelsPerInch = 96
  TextHeight = 14
  object Label3: TLabel
    Left = 10
    Top = 81
    Width = 95
    Height = 14
    Caption = 'Can tolerate solids?'
  end
  object Label4: TLabel
    Left = 8
    Top = 104
    Width = 97
    Height = 14
    Caption = 'Can tolerate liquids?'
  end
  object Label5: TLabel
    Left = 44
    Top = 164
    Width = 61
    Height = 14
    Caption = 'Fever/chills?'
  end
  object Label6: TLabel
    Left = 252
    Top = 53
    Width = 79
    Height = 14
    Caption = 'Abdominal pain?'
  end
  object Label1: TLabel
    Left = 264
    Top = 141
    Width = 67
    Height = 14
    Caption = 'Contractions?'
  end
  object Panel1: TPanel
    Left = 0
    Top = 0
    Width = 515
    Height = 33
    Align = alTop
    Color = clWhite
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clGray
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    TabOrder = 0
    object lbltitle: TLabel
      Left = 4
      Top = 4
      Width = 211
      Height = 20
      Caption = 'Nausea/Vomiting/Diarrhea'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clGray
      Font.Height = -16
      Font.Name = 'MS Sans Serif'
      Font.Style = [fsBold]
      ParentFont = False
    end
  end
  object Panel2: TPanel
    Tag = 19641
    Left = 0
    Top = 199
    Width = 515
    Height = 29
    Align = alBottom
    BevelOuter = bvNone
    TabOrder = 15
    object bbtnOK: TBitBtn
      Left = 356
      Top = 2
      Width = 75
      Height = 25
      Kind = bkOK
      NumGlyphs = 2
      TabOrder = 0
      OnClick = bbtnOKClick
    end
    object bbtnCancel: TBitBtn
      Left = 437
      Top = 2
      Width = 75
      Height = 25
      Kind = bkCancel
      NumGlyphs = 2
      TabOrder = 1
    end
  end
  object leOnset: TLabeledEdit
    Left = 44
    Top = 50
    Width = 157
    Height = 22
    EditLabel.Width = 32
    EditLabel.Height = 14
    EditLabel.Caption = 'Onset:'
    LabelPosition = lpLeft
    TabOrder = 1
  end
  object leLocal: TLabeledEdit
    Left = 335
    Top = 78
    Width = 156
    Height = 22
    EditLabel.Width = 60
    EditLabel.Height = 14
    EditLabel.Caption = 'Localization:'
    LabelPosition = lpLeft
    TabOrder = 11
    Visible = False
  end
  object leDur: TLabeledEdit
    Left = 56
    Top = 131
    Width = 145
    Height = 22
    EditLabel.Width = 43
    EditLabel.Height = 14
    EditLabel.Caption = 'Duration:'
    LabelPosition = lpLeft
    TabOrder = 6
  end
  object leDur1: TLabeledEdit
    Left = 335
    Top = 109
    Width = 156
    Height = 22
    EditLabel.Width = 43
    EditLabel.Height = 14
    EditLabel.Caption = 'Duration:'
    LabelPosition = lpLeft
    TabOrder = 12
    Visible = False
  end
  object cbSolidY: TCheckBox
    Tag = 1
    Left = 111
    Top = 81
    Width = 43
    Height = 17
    Caption = 'Yes'
    TabOrder = 2
    OnClick = cbSolidYClick
  end
  object cbSolidN: TCheckBox
    Tag = 2
    Left = 159
    Top = 81
    Width = 36
    Height = 17
    Caption = 'No'
    TabOrder = 3
    OnClick = cbSolidYClick
  end
  object cbLiquidY: TCheckBox
    Tag = 3
    Left = 111
    Top = 104
    Width = 43
    Height = 17
    Caption = 'Yes'
    TabOrder = 4
    OnClick = cbSolidYClick
  end
  object cbLiquidN: TCheckBox
    Tag = 4
    Left = 159
    Top = 104
    Width = 36
    Height = 17
    Caption = 'No'
    TabOrder = 5
    OnClick = cbSolidYClick
  end
  object cbFeverY: TCheckBox
    Tag = 5
    Left = 111
    Top = 164
    Width = 43
    Height = 17
    Caption = 'Yes'
    TabOrder = 7
    OnClick = cbSolidYClick
  end
  object cbFeverN: TCheckBox
    Tag = 6
    Left = 159
    Top = 164
    Width = 36
    Height = 17
    Caption = 'No'
    TabOrder = 8
    OnClick = cbSolidYClick
  end
  object cbAbdomY: TCheckBox
    Tag = 7
    Left = 348
    Top = 53
    Width = 43
    Height = 17
    Caption = 'Yes'
    TabOrder = 9
    OnClick = cbSolidYClick
  end
  object cbAbdomN: TCheckBox
    Tag = 8
    Left = 396
    Top = 53
    Width = 36
    Height = 17
    Caption = 'No'
    TabOrder = 10
    OnClick = cbSolidYClick
  end
  object cbContY: TCheckBox
    Tag = 9
    Left = 350
    Top = 141
    Width = 43
    Height = 17
    Caption = 'Yes'
    TabOrder = 13
    OnClick = cbSolidYClick
  end
  object cbContN: TCheckBox
    Tag = 10
    Left = 396
    Top = 141
    Width = 36
    Height = 17
    Caption = 'No'
    TabOrder = 14
    OnClick = cbSolidYClick
  end
end

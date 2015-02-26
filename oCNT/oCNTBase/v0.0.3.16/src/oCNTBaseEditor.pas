unit oCNTBaseEditor;

{
   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.

     Developer: Theodore Fontana
       Company: Document Storage Systems Inc.
   VA Contract: TAC-13-06464
}

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Dialogs, Controls, ComCtrls,
  DesignIntf, DesignEditors, DesignMenus, oCNTBase, frmReportOrder, uReportItems;

type
  ToPageEditor = class(TComponentEditor)
  protected
    function GetPageControl: ToForm;
  public
    procedure ExecuteVerb(Index: Integer); override;
    function GetVerbCount: Integer; override;
    function GetVerb(Index: Integer): string; override;
    procedure PrepareItem(Index: Integer; const AItem: IMenuItem); override;
  end;

//  TReportOrderEditor = class(TPropertyEditor)
//  public
//    procedure Edit; override;
//    function GetAttributes: TPropertyAttributes; override;
//    function GetValue: string; override;
//  end;

  procedure Register;

implementation

procedure Register;
begin
  RegisterComponentEditor(ToForm, ToPageEditor);
  RegisterComponentEditor(ToPage, ToPageEditor);
//  RegisterPropertyEditor(TypeInfo(TStringList), ToForm, 'ReportOrder', TReportOrderEditor);
end;

{ ToPageEditor }

function ToPageEditor.GetPageControl;
var
  Comp: TComponent;
begin
  Result := nil;
  Comp := GetComponent;
  if not Assigned(Comp) then Exit;

  if Comp is ToForm then
  Result := ToForm(Comp)
  else
  if Comp is ToPage then
  Result := ToForm(ToPage(Comp).PageControl);
end;

//Your actions from the popup menu of GetVerb
procedure ToPageEditor.ExecuteVerb(Index: Integer);
var
  PageControl: ToForm;
  TabSheet: ToPage;
begin
  PageControl := GetPageControl;
  if not Assigned(PageControl) then Exit;

  case Index of
    0: begin
         TabSheet := ToPage(GetDesigner.CreateComponent(ToPage, nil, 0, 0, 0, 0));
         TabSheet.PageControl := PageControl;
       end;
    1: PageControl.SelectNextPage(True);
    2: PageControl.SelectNextPage(False);
    3: begin
         TabSheet := ToPage(PageControl.ActivePage);
         if Assigned(TabSheet) then
         begin
           TabSheet.PageControl := nil;
           TabSheet.Free;
         end;
       end;
  else inherited ExecuteVerb(Index);
  end;
  PageControl.UpdateControlPanel;
end;

// Called the number of times you've stated you need in GetVerbCount.
// This is where you add your pop-up menu items
function ToPageEditor.GetVerb(Index: Integer): string;
begin
  case Index of
    0: Result := 'New Page';
    1: Result := 'Next Page';
    2: Result := 'Prev Page';
    3: Result := 'Delete Page';
  else Result := inherited GetVerb(Index);
  end;
end;

// Called when the IDE needs to populate the menu. Return the number
// of items you intend to add to the menu.
function ToPageEditor.GetVerbCount: Integer;
begin
  Result := 4;
end;

procedure ToPageEditor.PrepareItem(Index: Integer; const AItem: IMenuItem);
begin
  inherited PrepareItem(Index, AItem);
  if (Index = 3) and Assigned(AItem) then
  AItem.Enabled := GetComponent is ToPage;
end;

//{ TReportOrderEditor }
//procedure TReportOrderEditor.Edit;
//var
//  I: Integer;
//  Main: ToForm;
//  ItemObj: TObject;
//  Item: TNoteItem;
//begin
//  Main := ToForm(Self.GetComponent(0));
//  ReportOrderDlg := TReportOrderDlg.Create(nil);
//  try
//    for I := 0 to Main.ReportCollection.Count - 1 do
//    begin
//      ItemObj := Main.ReportCollection.Items[I].OwningObject;
//      ReportOrderDlg.ListBox1.AddItem(TWinControl(ItemObj).Name, ItemObj);
//    end;
//    ReportOrderDlg.ShowModal;
//  finally
//    if ReportOrderDlg.ModalResult = mrOK then
//    begin
//      for I := 0 to ReportOrderDlg.ListBox1.Count - 1 do
//      begin
//        Item := Main.ReportCollection.GetNoteItem(TWinControl(ReportOrderDlg.ListBox1.Items.Objects[I]));
//        Item.SetIndex(I);
//        Item.Order := I + 1;
//      end;
//    end;
//    ReportOrderDlg.ListBox1.Clear;
//    ReportOrderDlg.Free;
//  end;
//end;
//
//function TReportOrderEditor.GetAttributes: TPropertyAttributes;
//begin
//  //Makes the small button show to the right of the property
//  Result := [paDialog];
//end;
//
//function TReportOrderEditor.GetValue: String;
//begin
//  //Returns the string which should show in Object Inspector
//  Result := '(Reorder Report Items)';
//end;

end.
using System.Reflection;

namespace Learn;

// 接口
interface IControl
{
  void Paint();
}

interface ITextBox : IControl
{
  void SetText(string text);
}

interface IListBox : IControl
{
  void SetItems(string[] items);
}

interface IComboBox : ITextBox, IListBox { }


interface IDataBound
{
  void Bind(Binder b);
}

public class EditBox : IControl, IDataBound
{
  public void Paint() { }
  public void Bind(Binder b) { }
}

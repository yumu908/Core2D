#nullable enable
using Avalonia.Controls;
using Avalonia.Input;

namespace Core2D.Behaviors.DragAndDrop;

public class ScriptsListBoxDropHandler : ListBoxDropHandler
{
    public override bool Validate(object? sender, DragEventArgs e, object? sourceContext, object? targetContext, object? state)
    {
        if (e.Source is Control && sender is ListBox listBox)
        {
            // TODO:
        }
        return false;
    }

    public override bool Execute(object? sender, DragEventArgs e, object? sourceContext, object? targetContext, object? state)
    {
        if (e.Source is Control && sender is ListBox listBox)
        {
            // TODO:
        }
        return false;
    }
}

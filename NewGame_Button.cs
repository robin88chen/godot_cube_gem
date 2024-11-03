using Godot;
using System;

public partial class NewGame_Button : TextureButton
{
    private void _on_button_down()
    {
        Scale = new Vector2(1.1f, 1.1f);
        GD.Print("Mouse Entered New Game Button");
    }
    private void _on_button_up()
    {
        Scale = new Vector2(1.0f, 1.0f);
        GD.Print("Mouse Exited New Game Button");
    }
    private void _on_pressed()
    {
        GD.Print("New Game Button Pressed");
        //GetTree().ChangeScene("res://Game.tscn");
    }
}

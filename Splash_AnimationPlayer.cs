using Godot;
using System;

public partial class Splash_AnimationPlayer : AnimationPlayer
{
    private void _on_animation_finished(StringName anim_name)
    {
        GD.Print("Splash Animation Finished");
        GetTree().ChangeSceneToFile("res://start.tscn");
    }
}

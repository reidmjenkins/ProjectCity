using Godot;

namespace ProjectCity.Game;

// The first scene that opens when the game starts.
// Engine-side code lives in scripts/Game; pure game rules live in scripts/Core.
public partial class Main : Node2D
{
    public override void _Ready()
    {
        GD.Print($"Project City started (version {Core.GameInfo.Version}).");
    }
}

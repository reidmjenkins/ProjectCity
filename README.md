# Project City (working title)

A Godot 4.7 (.NET / C#) game, planned for release on Steam.

## Folders

| Folder | What goes there |
|---|---|
| `scenes/` | Godot scenes (`.tscn`): levels, menus, characters |
| `scripts/Game/` | C# code that uses Godot (drawing, input, sound) |
| `scripts/Core/` | C# game rules with **no Godot code**, so they can move to another engine unchanged |
| `data/` | Plain JSON/CSV game data (items, prices, dialogue) |
| `art/` | Sprites, tiles, UI images |
| `audio/` | Music and sound effects |

## Rules

- Everything for this game stays inside this folder.
- `scripts/Core` never has `using Godot;`.
- Game data goes in `data/` as plain files, not hard-coded in scenes.

## Running

Open Godot (Desktop shortcut) → Import → pick `project.godot` in this folder → Run (F5).

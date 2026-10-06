using OALib.Actions;
using OALib.AdofaiArc;
using OALib.Decorations;
using OALib.Lib;

namespace OAConsole;

public class RafflesiaLib
{
    public static void Rafflesia()
    {
        Random random = new Random();
        
        AdofaiFile input =  new AdofaiFile();
        input.FilePath = "D:\\ADOFAI NEW Custom Chart\\Rafflesia\\level.adofai";
        input.Load();
        
        AdofaiFile output = new AdofaiFile();
        output.Clone(input);
        output.FilePath = "D:\\ADOFAI NEW Custom Chart\\Rafflesia\\output.adofai";
        
        Part1(output, 24, 484, 8,0);
        Part1(output, 4, 700, 4,24);
        
        Part1(output, 24, 736, 8,28);
        Part1(output, 4, 952, 4,52);
        
        Part1(output, 24, 988, 8,56);
        Part1(output, 4, 1204, 4,80);
        
        Part1(output, 24, 1240, 8,84);
        Part1(output, 2, 1456, 4,108);
        Part1(output, 6, 1474, 8,110);
        output.Save();
    }

    private static void Part1
        (
            AdofaiFile output,
            int forNumber,
            int startFloor,
            float multi,
            int count
            )
    {
        Random random = new Random();
        
        for (int i = 1; i <= forNumber; i++)
        {
            SquareGenerate(output, [random.Next(-10,10),random.Next(-5,5)], 2f, $"Tile_4_{i + count}");
            SquareMove(output, startFloor + (i - 1) * 9, $"Tile_4_{i + count}", multi);
        }
    }

    private static void SquareGenerate
    (
        AdofaiFile output,
        float[] position,
        float scale,
        string tag
    )
    {
        AddObject addObject = new AddObject();
        
        addObject.RelativeTo = Lib.RelativeTo.Camera;
        addObject.LockScale = true;
        addObject.TrackAngle = 90;
        addObject.TrackOpacity = 0;
        addObject.Scale = [scale * 100, scale * 100];
        
        // 左下
        addObject.Tag = tag + $" {tag}_1";
        addObject.Rotation = -90;
        addObject.Position = position;
        output.DecoAdd(addObject.Create());
        
        
        // 左上
        addObject.Tag = tag + $" {tag}_2";
        addObject.Rotation = -180;
        addObject.Position[1] += scale;
        output.DecoAdd(addObject.Create());
        
        // 右上
        addObject.Tag = tag + $" {tag}_3";
        addObject.Rotation = -270;
        addObject.Position[0] += scale * 0.56f;
        output.DecoAdd(addObject.Create());
        
        // 右下
        addObject.Tag = tag + $" {tag}_4";
        addObject.Rotation = 0;
        addObject.Position[1] -= scale;
        output.DecoAdd(addObject.Create());
        
    }

    private static void SquareMove
    (
        AdofaiFile output,
        int floor,
        string tag,
        float multi
        )
    {
        Random random = new Random();
        
        MoveDecorations action1 = new MoveDecorations();
        action1.Floor = floor;
        action1.Tag = tag;
        action1.AngleOffset = -360 * multi;
        action1.Duration = 2 * multi;
        action1.Opacity = 100;
        action1.Ease = Lib.Ease.InCirc;
        output.ActionAdd(action1.Create());
        
        MoveDecorations action2 = new MoveDecorations();
        action2.Floor = floor;
        action2.AngleOffset = 0;
        action2.Duration = 0.125f * multi;
        action2.Opacity = 100;
        action2.Scale = [100000, 0];
        action2.Ease = Lib.Ease.OutCirc;

        for(int i = 1; i <=4; i++)
        {
            action2.Tag = $"{tag}_{i}";
            action2.RotationOffset = random.Next(0, 360);
            output.ActionAdd(action2.Create());
        }
        
        SetObject action3 = new SetObject();
        action3.Floor = floor;
        action3.Tag = tag;
        action3.AngleOffset = 0;
        action3.Duration = 0;
        action3.TrackColorAnimDuration = 0.1f;
        action3.TrackColorType = Lib.TrackColorType.Rainbow;
        output.ActionAdd(action3.Create());
    }
}
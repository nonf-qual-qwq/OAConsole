using ChartEffect.Lib;
using ChartEffect.Lib.Class;
using OALib.AdofaiArc;

namespace ChartEffect;

public class Program
{
    public static void Main(string[] args)
    {
        /*
        AdofaiFile input = new AdofaiFile();
        input.FilePath = "D:\\ADOFAI NEW Custom Chart\\Kyutatsuki - Synaptic Segmentation\\1.adofai";
        
        AdofaiFile multiTrackFile = new AdofaiFile();
        multiTrackFile.FilePath = "D:\\ADOFAI NEW Custom Chart\\Kyutatsuki - Synaptic Segmentation\\mt1.adofai";
        multiTrackFile.Load();
        
        AdofaiFile multiTrackFile2 = new AdofaiFile();
        multiTrackFile2.FilePath = "D:\\ADOFAI NEW Custom Chart\\Kyutatsuki - Synaptic Segmentation\\mt2.adofai";
        multiTrackFile2.Load();
        
        AdofaiFile output = new AdofaiFile();
        output.Clone(input);
        output.FilePath = "D:\\ADOFAI NEW Custom Chart\\Kyutatsuki - Synaptic Segmentation\\output.adofai";
        
        MultiTrack multiTrack = new MultiTrack
        {
            Input = multiTrackFile,
            Output = output,
            StartFloor = 1,
            EndFloor = 127,
            OutputFloor = 58,
            Scale = [224, 224],
            Size = [140, 140],
            TrackStyle = OALib.Lib.Lib.TrackStyle.Neon,
            DefaultPosition = [-1.5f, -0.2f],
            TileTag = "Tile_1",
            PlanetTag = "Planet_1",
            HasPlanet = true,
            HasBeat = true,
            Depth = 100,
            Parallax = [30, 30]
        };
        multiTrack.CreateMultiTrack();
        
        MultiTrack multiTrack2 = new MultiTrack
        {
            Input = multiTrackFile2,
            Output = output,
            StartFloor = 1,
            EndFloor = 56,
            OutputFloor = 58,
            Scale = [200, 200],
            Size = [160, 160],
            TrackStyle = OALib.Lib.Lib.TrackStyle.Standard,
            DefaultPosition = [-0.5f, 0],
            TileTag = "Tile_2",
            PlanetTag = "Planet_2",
            HasPlanet = true,
            HasBeat = false,
            Depth = 1,
            Parallax = [20, 20]
        };
        multiTrack2.CreateMultiTrack();


        output.Save();

        */
        
        /*
        AdofaiFile input = new AdofaiFile();
        input.FilePath = "D:\\ADOFAI NEW Custom Chart\\Kyutatsuki - Synaptic Segmentation\\2.adofai";
        
        AdofaiFile multiTrackFile3 = new AdofaiFile();
        multiTrackFile3.FilePath = "D:\\ADOFAI NEW Custom Chart\\Kyutatsuki - Synaptic Segmentation\\mt3.adofai";
        multiTrackFile3.Load();
        
        AdofaiFile output = new AdofaiFile();
        output.Clone(input);
        output.FilePath = "D:\\ADOFAI NEW Custom Chart\\Kyutatsuki - Synaptic Segmentation\\output.adofai";
        
        MultiTrack multiTrack3 = new MultiTrack
        {
            Input = multiTrackFile3,
            Output = output,
            StartFloor = 1,
            EndFloor = 15,
            OutputFloor = 194,
            Scale = [300, 300],
            Size = [145, 145],
            TrackStyle = OALib.Lib.Lib.TrackStyle.Standard,
            DefaultPosition = [-78f, -0.5f],
            TileTag = "Tile_3",
            PlanetTag = "Planet_3",
            HasPlanet = true,
            HasBeat = true,
            Depth = 0,
            Parallax = [50, 50]
        };
        multiTrack3.CreateMultiTrack();
        
                
        MultiTrack multiTrack4 = new MultiTrack
        {
            Input = multiTrackFile3,
            Output = output,
            StartFloor = 1,
            EndFloor = 15,
            OutputFloor = 238,
            Scale = [365, 365],
            Size = [160, 160],
            TrackStyle = OALib.Lib.Lib.TrackStyle.Standard,
            DefaultPosition = [-97f, -0.5f],
            TileTag = "Tile_4",
            PlanetTag = "Planet_4",
            HasPlanet = true,
            HasBeat = true,
            Depth = 0,
            Parallax = [55, 55]
        };
        multiTrack4.CreateMultiTrack();
        
        MultiTrack multiTrack5 = new MultiTrack
        {
            Input = multiTrackFile3,
            Output = output,
            StartFloor = 1,
            EndFloor = 15,
            OutputFloor = 282,
            Scale = [420, 420],
            Size = [160, 160],
            TrackStyle = OALib.Lib.Lib.TrackStyle.Standard,
            DefaultPosition = [-114f, -0.5f],
            TileTag = "Tile_5",
            PlanetTag = "Planet_5",
            HasPlanet = true,
            HasBeat = true,
            Depth = 0,
            Parallax = [60, 60]
        };
        multiTrack5.CreateMultiTrack();
        
        MultiTrack multiTrack6 = new MultiTrack
        {
            Input = multiTrackFile3,
            Output = output,
            StartFloor = 1,
            EndFloor = 15,
            OutputFloor = 326,
            Scale = [500, 500],
            Size = [160, 160],
            TrackStyle = OALib.Lib.Lib.TrackStyle.Standard,
            DefaultPosition = [-134f, -0.5f],
            TileTag = "Tile_6",
            PlanetTag = "Planet_6",
            HasPlanet = true,
            HasBeat = true,
            Depth = 0,
            Parallax = [65, 65]
        };
        multiTrack6.CreateMultiTrack();
        
        output.Save();
        
        */

        /*
        AdofaiFile input = new AdofaiFile();
        input.FilePath = "D:\\ADOFAI NEW Custom Chart\\Kyutatsuki - Synaptic Segmentation\\3.adofai";
        
        AdofaiFile multiTrackFile4 = new AdofaiFile();
        multiTrackFile4.FilePath = "D:\\ADOFAI NEW Custom Chart\\Kyutatsuki - Synaptic Segmentation\\mt4.adofai";
        multiTrackFile4.Load();
        
        AdofaiFile output = new AdofaiFile();
        output.Clone(input);
        output.FilePath = "D:\\ADOFAI NEW Custom Chart\\Kyutatsuki - Synaptic Segmentation\\output.adofai";
        
        MultiTrack multiTrack = new MultiTrack
        {
            Input = multiTrackFile4,
            Output = output,
            StartFloor = 1,
            EndFloor = 127,
            OutputFloor = 3821,
            Scale = [224, 224],
            Size = [140, 140],
            TrackStyle = OALib.Lib.Lib.TrackStyle.Neon,
            DefaultPosition = [-1.5f, -0.2f],
            TileTag = "Tile_15",
            PlanetTag = "Planet_15",
            HasPlanet = true,
            HasBeat = true,
            Depth = 100,
            Parallax = [30, 30]
        };
        multiTrack.CreateMultiTrack();
        
        output.Save();
        */
        
        /*
        AdofaiFile input = new AdofaiFile();
        input.FilePath = "D:\\ADOFAI NEW Custom Chart\\Kyutatsuki - Synaptic Segmentation\\4.adofai";
        
        AdofaiFile multiTrackFile5 = new AdofaiFile();
        multiTrackFile5.FilePath = "D:\\ADOFAI NEW Custom Chart\\Kyutatsuki - Synaptic Segmentation\\mt5.adofai";
        multiTrackFile5.Load();
        
        AdofaiFile output = new AdofaiFile();
        output.Clone(input);
        output.FilePath = "D:\\ADOFAI NEW Custom Chart\\Kyutatsuki - Synaptic Segmentation\\output.adofai";
        
        MultiTrack multiTrack = new MultiTrack
        {
            Input = multiTrackFile5,
            Output = output,
            StartFloor = 1,
            EndFloor = 127,
            OutputFloor = 4093,
            Scale = [224, 224],
            Size = [170, 170],
            TrackStyle = OALib.Lib.Lib.TrackStyle.Neon,
            DefaultPosition = [30f, -5f],
            TileTag = "Tile_19",
            PlanetTag = "Planet_19",
            HasPlanet = true,
            HasBeat = true,
            Depth = 100,
            Parallax = [15, 15]
        };
        multiTrack.CreateMultiTrack();
        
        output.Save();
        */
        
        /*
        
        AdofaiFile input = new AdofaiFile();
        input.FilePath = "D:\\ADOFAI NEW Custom Chart\\Kyutatsuki - Synaptic Segmentation\\5.adofai";
        
        AdofaiFile multiTrackFile5 = new AdofaiFile();
        multiTrackFile5.FilePath = "D:\\ADOFAI NEW Custom Chart\\Kyutatsuki - Synaptic Segmentation\\mt1.adofai";
        multiTrackFile5.Load();
        
        AdofaiFile multiTrackFile2 = new AdofaiFile();
        multiTrackFile2.FilePath = "D:\\ADOFAI NEW Custom Chart\\Kyutatsuki - Synaptic Segmentation\\mt2.adofai";
        multiTrackFile2.Load();
        
        AdofaiFile output = new AdofaiFile();
        output.Clone(input);
        output.FilePath = "D:\\ADOFAI NEW Custom Chart\\Kyutatsuki - Synaptic Segmentation\\output.adofai";
        
        MultiTrack multiTrack = new MultiTrack
        {
            Input = multiTrackFile5,
            Output = output,
            StartFloor = 1,
            EndFloor = 127,
            OutputFloor = 7097,
            Scale = [224, 224],
            Size = [140, 140],
            TrackStyle = OALib.Lib.Lib.TrackStyle.Neon,
            DefaultPosition = [-1.5f, -0.2f],
            TileTag = "Tile_21",
            PlanetTag = "Planet_21",
            HasPlanet = true,
            HasBeat = true,
            Depth = 100,
            Parallax = [30, 30]
        };
        multiTrack.CreateMultiTrack();
        
        MultiTrack multiTrack2 = new MultiTrack
        {
            Input = multiTrackFile2,
            Output = output,
            StartFloor = 1,
            EndFloor = 56,
            OutputFloor = 7097,
            Scale = [200, 200],
            Size = [160, 160],
            TrackStyle = OALib.Lib.Lib.TrackStyle.Standard,
            DefaultPosition = [-0.5f, 0],
            TileTag = "Tile_22",
            PlanetTag = "Planet_22",
            HasPlanet = true,
            HasBeat = false,
            Depth = 1,
            Parallax = [20, 20]
        };
        multiTrack2.CreateMultiTrack();
        
        output.Save();
        */
        
        AdofaiFile input = new AdofaiFile();
        input.FilePath = "D:\\ADOFAI NEW Custom Chart\\Kyutatsuki - Synaptic Segmentation\\6.adofai";
        
        AdofaiFile multiTrackFile2 = new AdofaiFile();
        multiTrackFile2.FilePath = "D:\\ADOFAI NEW Custom Chart\\Kyutatsuki - Synaptic Segmentation\\mt2.adofai";
        multiTrackFile2.Load();
        
        AdofaiFile output = new AdofaiFile();
        output.Clone(input);
        output.FilePath = "D:\\ADOFAI NEW Custom Chart\\Kyutatsuki - Synaptic Segmentation\\output.adofai";

        MultiTrack multiTrack2 = new MultiTrack
        {
            Input = multiTrackFile2,
            Output = output,
            StartFloor = 1,
            EndFloor = 112,
            OutputFloor = 7097,
            Scale = [200, 200],
            Size = [160, 160],
            TrackStyle = OALib.Lib.Lib.TrackStyle.Standard,
            DefaultPosition = [-0.5f, 0],
            TileTag = "Tile_22",
            PlanetTag = "Planet_22",
            HasPlanet = true,
            HasBeat = false,
            Depth = 1,
            Parallax = [20, 20]
        };
        multiTrack2.CreateMultiTrack();
        
        output.Save();
    }
}
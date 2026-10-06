using Newtonsoft.Json.Linq;
using OALib.AdofaiArc;
using OALib.Lib;
namespace AdofaiMidiConverter;

public class Program
{
    public static void Main(string[] args)
    {
        AdofaiFile input = new AdofaiFile();
        input.FilePath = "D:\\ADOFAI NEW Custom Chart\\1KNITE\\level.adofai";
        input.Load();

        bool change = false;
        float[] angle = Lib.CalculateAngleData(input.AngleData.ToObject<float[]>());
        int[] twirl = GetTwirl(input);

        for (int i = 0; i < angle.Length; i++)
        {
            foreach (int j in twirl)
            {
                if (i == j)
                {
                    change = !change;
                }
            }

            if (change && angle[i] != 0)
            {
                angle[i] = 360 - angle[i];
            }
            Console.WriteLine($"{angle[i]},{change},{i}");
        }



    }

    public static int[] GetTwirl(AdofaiFile input)
    {
        if (input?.Actions == null)
            return Array.Empty<int>();
    
        List<int> twirlList = new List<int>();
        JArray actions = input.Actions;
    
        foreach (JObject action in actions)
        {
            if (action["eventType"]?.ToString() == "Twirl")
            {
                JToken floorToken = action["floor"];
                if (floorToken != null && int.TryParse(floorToken.ToString(), out int floor))
                {
                    twirlList.Add(floor);
                }
            }
        }
        return twirlList.ToArray();
    }

    public static float[] GetBpm(AdofaiFile input)
    {
        float[] bpm = new float[input.AngleData.Count];
        float bpm_i = input.Settings["bpm"].ToObject<float>();
        bpm[0] = bpm_i;
        for (int i = 1; i < bpm.Length; i++)
        {
            
        }
        return bpm;
    }
}



using Newtonsoft.Json.Linq;
using OALib.AdofaiArc;
using OALib.Decorations;

namespace ChartEffect.Lib;

public class Actions
{
    public static int[] SearchTwirl(JArray actions)
    {
        List<int> twirl = [];
        foreach (JToken action in actions)
        {
            if (action["eventType"].ToObject<string>() ==  "Twirl")
            {
                twirl.Add(action["floor"].ToObject<int>());
            }
        }
        return twirl.ToArray();
    }
    
    public static JToken[] SearchBpm(JArray actions)
    {
        List<JToken> bpm = [];
        foreach (JToken action in actions)
        {
            if (action["eventType"].ToObject<string>() ==  "SetSpeed")
            {
                bpm.Add(action);
            }
        }
        return bpm.ToArray();
    }
    
    // 忽略角度偏移，一个方块最多只有一个设置速度
    public static float[] CalculateBpm(AdofaiFile input)
    {
        int count = input.AngleData.Count;
        float[] bpm = new float[count];
        float nowBpm = input.Settings["bpm"].ToObject<float>();

        JToken[] bpmList = SearchBpm(input.Actions);
        int idx = 0;

        bpm[0] = nowBpm;
        for (int floor = 1; floor < count; floor++)
        {
            while (idx < bpmList.Length &&
                   bpmList[idx]["floor"].ToObject<int>() == floor)
            {
                var item = bpmList[idx];
                if (item["speedType"].ToObject<string>() == "Bpm")
                    nowBpm = item["beatsPerMinute"].ToObject<float>();
                else
                    nowBpm *= item["bpmMultiplier"].ToObject<float>();
                idx++;
            }
            bpm[floor] = nowBpm;
        }

        return bpm;
    }
}
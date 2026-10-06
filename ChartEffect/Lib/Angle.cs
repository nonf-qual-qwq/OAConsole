using Newtonsoft.Json.Linq;
using OALib.AdofaiArc;

namespace ChartEffect.Lib;

public class Angle
{
    public static float AngleUniformity(float angle)
    {
        float num = angle;
        if ( num > 360.0 || num < -360.0)
            num = angle % 360f;
        if ( num < 0.0)
            num += 360f;
        return num;
    }

    public static float[] CalculateAngleData(JArray angleData)
    {
        float[] angleDataFloat = angleData.ToObject<float[]>();
        float[] angleData1 = new float[angleDataFloat.Length];
        for (int index = 0; index < angleDataFloat.Length; ++index)
        {
            int num = 0;
            if (angleDataFloat[index] == 999)
            {
                angleData1[index] = 0.0f;
            }
            else
            {
                while (index - 1 - num >= 0 && angleDataFloat[index - 1 - num] == 999)
                    ++num;
                if (index - 1 - num < 0)
                {
                    angleData1[index] = 180f - angleDataFloat[index];
                }
                else
                {
                    angleData1[index] = angleDataFloat[index - 1 - num] - angleDataFloat[index];
                    if (num % 2 == 0)
                        angleData1[index] += 180f;
                }
            }
            angleData1[index] = AngleUniformity(angleData1[index]);
        }
        return angleData1;
    }
    
    public static float[] CalculateTwirlAngleData(float[] angleData, int[] twirlData)
    {
        var twirlSet = new HashSet<int>(twirlData);
        bool twirl = false;
        for (int i = 0; i < angleData.Length; i++)
        {
            if (twirlSet.Contains(i))
                twirl = !twirl;

            if (twirl && angleData[i] != 0f && angleData[i] != 360)
                angleData[i] = 360f - angleData[i];
        }
        return angleData;
    }

    public static float[] CalculateTwirlAngleData(AdofaiFile input)
    {
        float[] angleData = CalculateAngleData(input.AngleData);
        int[] twirlData = Actions.SearchTwirl(input.Actions);
        CalculateTwirlAngleData(angleData, twirlData);
        return angleData;
    }

}
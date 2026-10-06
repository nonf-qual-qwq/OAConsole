namespace ChartEffect.Lib;

public class Arc
{
    public static float[] CalculateTime(float[] angle, float[] bpm)
    {
        float[] time = new float[angle.Length];

        for (int i = 0; i < time.Length; i++)
        {
            time[i] = angle[i] / 3 / bpm[i];
        }
        
        return time;
    }
}
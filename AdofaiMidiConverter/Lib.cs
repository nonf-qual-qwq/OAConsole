namespace AdofaiMidiConverter;

public class Lib
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

    public static float[] CalculateAngleData(float[] angleData)
    {
        float[] angleData1 = new float[angleData.Length];
        for (int index = 0; index < angleData.Length; ++index)
        {
            int num = 0;
            if (angleData[index] == 999)
            {
                angleData1[index] = 0.0f;
            }
            else
            {
                while (index - 1 - num >= 0 && angleData[index - 1 - num] == 999)
                    ++num;
                if (index - 1 - num < 0)
                {
                    angleData1[index] = 180f - angleData[index];
                }
                else
                {
                    angleData1[index] = angleData[index - 1 - num] - angleData[index];
                    if (num % 2 == 0)
                        angleData1[index] += 180f;
                }
            }
            angleData1[index] = AngleUniformity(angleData1[index]);
        }
        return angleData1;
    }
    
    
}
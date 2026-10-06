using OALib.AdofaiArc;
using OALib.Decorations;

namespace OAConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			AdofaiFile input = new AdofaiFile();
			AdofaiFile output = new AdofaiFile();
			input.FilePath = "D:\\ADOFAI NEW Custom Chart\\测试\\level.adofai";
			input.Load();
			output.Clone(input);
			output.FilePath = "D:\\ADOFAI NEW Custom Chart\\测试\\output.adofai";
			MyFunc(output, 5);
			MyFunc(output, 5);
			MyFunc(output, 5);

			output.Save();
			
		}

		static void MyFunc(AdofaiFile output, int times)
		{
			int x = 0;
			while (x < times)
			{
				AddObject deco = new AddObject();
				deco.Position = [x, 0];
				output.DecoAdd(deco.Create());
				x += 1;
			}
		}
	}
};


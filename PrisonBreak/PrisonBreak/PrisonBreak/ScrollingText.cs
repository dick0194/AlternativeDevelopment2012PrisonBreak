using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace PrisonBreak
{
	class ScrollingText
	{
	}

	public class OutputText : Game1
	{
			OutputText Words;
			int timeCounter = 0;
			int subIndex = 0;
			string output;
			bool ToLong = false;
			int loopcounter = 10;
			string text;
		public string Stuff()
		{
		
			

			List<string> dogs = new List<string>();
			dogs.Add("Hi"); // Add string 1
			dogs.Add("Spitz"); // 2
			dogs.Add("Mastiff"); // 3
			dogs.Add("Finnish Spitz"); // 4
			dogs.Add("Briard"); // 5

			text = string.Join(",", dogs.ToArray());

			for (int i = 0; i < text.Length; i++)
			{
				if ((float)i % 5f == 0)
				{
					text = text.Insert(i, "\n");
				}
			}
			Console.WriteLine(text);
			return text;
		}

		public string CurrentText
		{
			get
			{
				return text.Substring(0,text.Length);
			}
		}






		protected override void Update(GameTime gameTime)
		{
			Words = new OutputText();
			output = Words.Stuff();
			

			timeCounter += gameTime.ElapsedGameTime.Milliseconds;
			if (timeCounter >= 150 && subIndex < output.Length)
			{
				if (subIndex > loopcounter)
				{
					ToLong = true;
					loopcounter += 10;
				}

				if (ToLong == true)
				{
					output += "\n";
					//FontPos.Y += 20;
					ToLong = false;
				}

				timeCounter = 0;
				subIndex++;

			}

		}

	}
}
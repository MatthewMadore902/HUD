using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUD
{
	class Program
	{
		static void Main(string[] args)
		{
			//---------------Score------------------------

			int score;
			score = 0;
			//Console.WriteLine("your curent score: " + score);

			//Console.WriteLine("You have elimainated an enemy: + 50 point" );
			//score = 0 + 50;
			//Console.WriteLine("Your current score is: " + score);

			//----------Shield-------------

			string shield;
			shield = "^^^^^";

			//Console.WriteLine("Shield: " + shield);

			//----------Health------------

			float health;
			health = 100.0f;
			//Console.WriteLine("Health is " + health);

			//---------------Lives----------------

			int lives;
			lives = 4;
			//Console.WriteLine("Lives: " + lives);

			//-------------Game title----------
			string gameName;
			gameName = "Best Game Ever";
			//Console.WriteLine(gameName);

			//-------------Multiplier-------------
			int multiplier;
			multiplier = 2;

			int FinelScore;
			FinelScore = score * multiplier;




			//----------Ammo-------------
			int ammo;
			ammo = 64;
			//Console.WriteLine("AMMO - " + ammo);



			//------------------All Of It Together!!!!!!!!!--------------
			 Console.WriteLine("Your Current score: " + FinelScore + "            " + "Shield: " + shield + "            " + gameName);

			Console.WriteLine(" ");
			//Console.WriteLine(multiplier);
			Console.WriteLine(" ");

			Console.WriteLine("Your Current Health: " + health + "            " + "Lives: " + lives + "                  " + "AMMO - " + ammo);
		
			//----------Action-------------

			Console.WriteLine("Press any key to battle!!!");
			Console.ReadKey();

			Console.WriteLine("A ghoul came out of the bushes you killed it but you took some damage");
			health = 100.0f - 24.0f;
			score = score + 100;
			ammo = 64 - 12;

			Console.ReadKey();

			Console.WriteLine("Your Current score: " + FinelScore + "            " + "Shield: " + shield + "            " + gameName);

			Console.WriteLine(" ");
			//Console.WriteLine(multiplier);
			Console.WriteLine(" ");

			Console.WriteLine("Your Current Health: " + health + "            " + "Lives: " + lives + "                  " + "AMMO - " + ammo);

			Console.ReadKey();
			Console.ReadKey();
		}

			
		
	}
}

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
			score = 0 + 50;
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


			//----------Ammo-------------
			int ammo;
			ammo = 64;
			//Console.WriteLine("AMMO - " + ammo);



			//------------------All Of It Together!!!!!!!!!--------------

			Console.WriteLine("Your Current score: " + score + "            " + "Shield: " + shield + "            " + gameName);

			Console.WriteLine(" ");

			Console.WriteLine(" ");

			Console.WriteLine("Your Current Health: " + health + "            " + "Lives: " + lives + "                  " + "AMMO - " + ammo);


			//---------------Action Happaning----------------------

			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine("You were attacked by an enemy!!!");
			Console.WriteLine("The enemy dropped shield");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			score = 0 + 50;
			health = 95.0f;
			shield = "^^";
			ammo = 54;


			Console.WriteLine("Your Current score: " + score + "            " + "Shield: " + shield + "            " + gameName);

			Console.WriteLine(" ");

			Console.WriteLine(" ");

			Console.WriteLine(" ");

			Console.WriteLine("Your Current Health: " + health + "            " + "Lives: " + lives + "                  " + "AMMO - " + ammo);

			//Console.ReadLine

			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine("You shoot an enemy in the distance you take him out");
			Console.WriteLine(" ");
			Console.WriteLine(" ");

			ammo = 30;
			score = score + 100;

			Console.WriteLine("Your Current score: " + score + "            " + "Shield: " + shield + "            " + gameName);

			Console.WriteLine(" ");

			Console.WriteLine(" ");

			Console.WriteLine(" ");

			Console.WriteLine("Your Current Health: " + health + "            " + "Lives: " + lives + "                  " + "AMMO - " + ammo);

			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine("");
			Console.WriteLine(" ");
			Console.WriteLine(" ");

			if string("kill an enemy");
			{
				score = score + 100;			
			}

			
			Console.ReadKey();

		}

			
		
	}
}

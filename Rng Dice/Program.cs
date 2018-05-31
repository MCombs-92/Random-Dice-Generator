using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rng_Dice {
	class Program {

		int die = 0;
		int score = 0;
		Random rng = new Random();
		int Games = 0;
		int HighScore = 0;

		int RollDie() {
			return rng.Next(1, 7);
		}


		void ThrowDice() {
			score = 0;
			die = 0;

			while(die != 1) {
				score += die;
				die = RollDie();
			}
		}




		void Run() {
			Games = 0;
			while(score < 500) {
				ThrowDice();

				if (score > HighScore) {
					HighScore = score;
					Console.WriteLine("New highscore is {0}", HighScore);
				}
				

				Games++;

			}
			

		}

		static void Main(string[] args) {
			(new Program()).Run();
		}
	}
}

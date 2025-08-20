using System;
using System.Data;

class Game
{   
	
	Player[] _player = new Player[4];

	public int conflict, dice1, dice2;

	public void setUp()
	{
		var rander = Random.Shared;
		conflict = rander.Next(1, 16);
		dice1 = rander.Next(1, 7);
		dice2 = rander.Next(1, 7);


	}

	public void doRound(int rnum, int pnum)
	{
		setUp();

		for (int i = 0; i < 4; i++) _player[i].getCards();
		
		for(int i = 1; i <= 3; i++)
		{
			doTrack(pnum);
		}

	}

	public void doTrack(int pnum)
	{

	}
}

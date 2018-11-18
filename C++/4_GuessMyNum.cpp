// 4_GuessMyNum.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<iostream>

using namespace std;
//Adding Comment here: Do this work
int main()
{

	int answer = 7;
	int k;

	bool keeplooking = true;

	while (keeplooking)
	{
		cout << "Enter a number of your choice! ";

		cin >> k;

		if (k > answer)
		{
			cout << " Hey you are a bit high, try lower!" << endl;
		}
		else if (k < answer)
		{
			cout << " Hey your number is a bit low, try higher!" << endl;
		}
		else
		{
			cout << "CONGRATS  you got it!!!" << endl;
			keeplooking = false;
		}

	}
    return 0;
}


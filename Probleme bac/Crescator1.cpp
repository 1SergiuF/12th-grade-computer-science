#include <fstream>
#include <iostream>
using namespace std;

ifstream fin("crescator1.in"); 
ofstream fout("crescator1.out");

int main()
{
    int x;
    int currX;
    int nr = 0;
    bool ok = false;

    fin >> x;
    currX = x;
    nr++;

    while (fin >> x) 
    {
        if (x == currX)
            nr++;
        else
        {
            if (nr % 2 == 1) 
            {
                ok = true;
                break;
            }

            else
            {
                nr = 1;
                currX = x;
            }
        }
    }

    if (!ok && nr % 2 == 1)
        ok = true;
    
    if (ok)
        fout << currX;
    else
        fout << "nu exista";

    return 0;
}
#include <iostream>
#include <sstream>
using namespace std;

string seprar(int n) {
	string r;
	int[] a = new int[4];
	while (n != 0)
	{
		r += to_string(n % 10);
		n = n / 10;
	}

	return r;
}

int main()
{
	int num;
	string resultat;

	cout << "Escriu un numero: ";
	cin >> num;

	resultat = seprar(num);

	cout << "El numero es" << resultat;

}


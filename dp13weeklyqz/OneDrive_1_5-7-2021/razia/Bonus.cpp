#include <iostream>
using namespace std;
int main () {
	int articles;
	int impact;
	int scientists;
//	cout << "The number of articles you are going to publish : "<<endl;
	cin  >> articles;
//	cout << "The impact factor that is required by the owners : "<<endl;
	cin >> impact ;
	scientists=articles * (impact-1);
	cout << scientists+1;
}

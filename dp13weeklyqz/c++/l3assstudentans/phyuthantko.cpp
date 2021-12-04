#include<iostream>
using namespace std;

		void starPattern1()
        {
             for(int i = 1; i < 6; i++) {
		for (int j = 1; j <= i; j++) {
		cout << "*";
        }
        cout << endl;
    }

        }
        void starPattern2()
        {
            for(int i = 1; i < 6; i++) {
             for(int j = 4; j <= 1; j--) {
              for (int k = 1; k <= i; k++) {
              cout << "*" ;
            }
           cout << " " ;
        }
        cout << endl;
    }

        }
        void starPattern3()
        {
            for (int i = 1; i < 6; i++) {
        	for (int j = 5; j >= i; j--) {
            	cout << "*" ;
        }
        cout << endl;
    }

        }
        void starPattern4()
        {
            //write your code here

        }
        void starPattern5()
        {
            for(int i= 1 ; i < 6; i++) {
        cout << "*****" << endl;
    }

        }
        void starPattern6()
        {
		for(int i= 1 ; i < 6; i++) {
        	 for(int j = 0; j > i ; j--){
                 cout << " " << endl; 
                }
              cout << "*****" << endl;
    }

        }
        void starPattern7()
        {
            //write your code here

        }
        void starPattern8()
        {
            //write your code here

        }
        void starPattern9()
        {
            int n = 5;
        for (int i = 1; i <= n; i++) {
        for(int k = n-1; k > 0; k--) {
            cout << " ";
        }
        for (int j = 1; j <= j <= i; j++) {
            cout << "* ";
        }
        cout << endl;
    }

        }
        void starPattern10()
        {
            int n = 5;
        for(int i = n; i >= 1; i-- ) {
        for(int k = n-1; k >0; k--) {
            cout << " ";
        }
        for (int j = i; j > 0; j--) {
            cout << "* ";
        }
        cout << endl;
    }

        }

//wrong 2,3,4,6,7,8,9,10  =-20
int main(){
	starPattern1();
	

}

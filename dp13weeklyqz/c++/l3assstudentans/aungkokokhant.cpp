#include<iostream>
using namespace std;
        int a,b,c;
		void starPattern1()
        {
            int a,b;
            for(a=1; a<6;a++)
            {
            	for(b=1;b<=a;b++)
            	cout<<"*";
            	cout<<endl;
			}
			cout<<endl;
        }
        void starPattern2()
        {
            int a,b,number=6;
            for(a = 1; a <number; a++){
            	for(b = a; b < number ; b++)
            	{
            		cout<<" ";
				}
				for(b = 1 ;b<=a;b++)
				{
					cout<<"*";
				}
				cout<<endl;
			}
			cout<<endl;
	}
        void starPattern3()
        {
            int a,b,number=5;
            for(a=number; a>=1; a--){
            	for(b=1; b<= a;b++)
            	cout<<"*";
            	cout<<endl;
			}
          cout<<endl;
        }
        
        void starPattern4()
        {
            int a,b,number=6;
            for(a = number ; a >= 1; a--){
            	for(b = a; b <=  number ; b++)
            	{
            		cout<<" ";
				}
				for(b = 1; b < a;b++)
                {
                 cout<<"*";
                }
                cout<<endl;
			}
            
        }
        void starPattern5()
        {
            int a,b;
            for(a=0; a<5; a++){
            	for(b=0; b<5;b++)
            	cout<<"*";
            	cout<<endl;
			}
          cout<<endl;

        }
        void starPattern6()
        {
            int a,b,number=5;
            for(a=0; a<5; a++){
            	for(b=a; b<=number-1;b++){
            		cout<<" ";
				}
            	for(b=0; b<5;b++)
            	{
            		cout<<"*";
				}
            	cout<<endl;
			}
          cout<<endl;

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
//            int a,b,c,number;
//            for(a = 1; a <= number; a++){
//            	for(b = number; b <= number;c++){
//            		cout<<"  ";
//				}
//				for(c = 1 ; c<=)
//			}

        }
        void starPattern10()
        {
            //write your code here

        }
        
        
int main(){
	cout<<"1"<<endl;
	starPattern1();
	cout<<"2"<<endl;
	starPattern2();
	cout<<"3"<<endl;
	starPattern3();
	cout<<"4"<<endl;
	starPattern4();
	cout<<"5"<<endl;
	starPattern5();
	cout<<"6"<<endl;
	starPattern6();
	cout<<"7"<<endl;
	starPattern7();
	cout<<"8"<<endl;
	starPattern8();
	cout<<"9"<<endl;
	starPattern9();
	cout<<"10"<<endl;
	starPattern10();


	
	
	
}


#include<iostream>
using namespace std;

		void starPattern1()
        {
            //write your code here
           int i,j;
           for(i=0;i<=5;i++){  //
           	for(j=0;j<=i;j++){  //1<=2
           		cout<<"*";//       *
 			}
           	cout<<"\n";//      *
		   }               //      *
                           //      *
                           //      *
        }
        void starPattern2()
        {
            //write your code here
            int i,j,a=10;
            for(i=0;i<5;i++){
            	for(j=0;j<a;j++)
            		cout<<" ";
            	a=a-2;
            	for(j=0;j<=i;j++)
            		cout<<"* ";
            		cout<<"\n";
			}

        }
        void starPattern3()
        {
            //write your code here
        	int i,j;
        	for(i=5;i>=1;i--){
        		for(j=1;j<=i;j++){
        			cout<<"*";
				}
				cout<<"\n";
			}
        	
			
        }
        void starPattern4()
        {
            //write your code here
            int i,j,k;
            for(i=5;i>=1;i--){
            	for(j=5;j>i;j--){
            		cout<<" ";
				}
				for(k=1;k<=i;k++){
					cout<< "*";
				}
				cout<<"\n";
			}

        }
        void starPattern5()
        {
            //write your code here
            int i,j;
            for(i=1;i<5;i++){
            	for(j=1;j<=5;j++){
            		cout<<"*";
				}
				cout<<"\n";
			}

        }
        void starPattern6()
        {
            //write your code here
            int i,j;
            for(i=1;i<5;i++){
            	for(j=1;j<i;j++){
            		cout<<" ";
				}
				for(j=1;j<=5;j++){
					cout<<"*";
				}
				cout<<"\n";
			}
            

        }
        void starPattern7()
        {
            //write your code here
            int i,j;
            for(i=1;i<=5;i++){
            	
			}

        }
        void starPattern8()
        {
            //write your code here
             int i,j;
            for(i=1;i<=5;i++){
            	
			}

        }
        void starPattern9()
        {
            //write your code here
            int i,j,k;
            for(i=1;1<=5;i++){
            	for(j=i;j<5;j++){
            		cout<<" ";
				}
				for(k-1;k<(i*2);k++){
					cout<<"*";
				}
				cout<<"\n";
			}

        }
        void starPattern10()
        {
            //write your code here	
            int i,j,k;
            for(i=5;i>=i;i--){
            	for(j=5;j>i;j--){
            		cout<<" ";
				}
				for(k=1;k<(i*2);k++){
					cout<<"*";
				}
				cout<<"\n";
			}
            

        }
//10 2left =-6  1 wrong =-3  other -5=-14

int main(){
	starPattern10();
}

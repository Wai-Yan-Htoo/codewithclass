#include<iostream>
using namespace std;

		void starPattern1()
        {
            for(int i=1; i<=5; i++){
            	for(int j=1; j<=i; j++){
            		cout<<"*";
				}
				cout<<endl;
			}
        }
        void starPattern2()
        {
          int s=4;
		  for(int i=1; i<=5; i++){
				for(int k=s; k>=1; k--){
					cout<<" ";
				}
				s-=1;
        		for(int j=1; j<=i; j++){
            		cout<<"*";
				}
				cout<<endl;
			}
		}
        void starPattern3()
        {
        	for(int i=5; i>=1; i--){
				for(int j=1; j<=i; j++){
					cout<<"*";
				}
				cout<<endl;
			}
        }
        void starPattern4()
        {	
        	int s=1;
			for(int i=5; i>=1; i--){
				for(int k=1; k<=s; k++){
					cout<<" ";
				}
				s+=1;
				for(int j=1; j<=i; j++){
					cout<<"*";
				}
				cout<<endl;
			}
        }
        void starPattern5()
        {
			for(int i=1; i<=5; i++){
				for(int j=1; j<=5; j++){
					cout<<"*";
				}
				cout<<endl;
			}
        }
        void starPattern6()
        {	
            for(int i=1; i<=5; i++){
            	for(int k=1; k<=i; k++){
            		cout<<" ";
				}
				for(int j=1; j<=5; j++){
					cout<<"*";
				}
				cout<<endl;
			}

        }
        void starPattern7()
        {
           for(int i=1; i<=5; i++){
            	for(int j=1; j<=i; j++){
            		if(i==3&&j==2){
            			cout<<" ";
					}
					else if(i==4&&(j==2||j==3)){
						cout<<" ";
					}
					else {
            			cout<<"*";
            		}
				}
				cout<<endl;
			}

        }
        void starPattern8()
        {
        	int s=4;
		  	for(int i=1; i<=5; i++){
				for(int k=s; k>=1; k--){
					cout<<" ";
				}
				s-=1;
        		for(int j=1; j<=i; j++){
            		if(i==3&&j==2){
            			cout<<" ";
					}
					else if(i==4&&(j==2||j==3)){
						cout<<" ";
					}
					else {
            			cout<<"*";
            		}
				}
				cout<<endl;
			}

        }
        void starPattern9()
        {	
        	int s=4;	
			for(int i=1; i<=9; i++){
				if(i%2!=0){
					for(int k=s; k>=1; k--){
           				cout<<" ";
				   	}				   	
				   s-=1;
           			for(int j=1; j<=i; j++){           			
           				cout<<"*";
					}
				}
				cout<<endl;
			}
        }
        void starPattern10()
        {
            int s=1;	
			for(int i=9; i>=1; i--){
				if(i%2!=0){
					if(i!=9){
						for(int k=1; k<=s; k++){
           					cout<<" ";
				   		}
				   	s+=1;
					}	
           			for(int j=1; j<=i; j++){
           				cout<<"*";
					   }
				}
				cout<<endl;
			}
        }


int main(){
	starPattern1();
	starPattern2();
	starPattern3();
	starPattern4();
	starPattern5();
	starPattern6();
	starPattern7();
	starPattern8();
	starPattern9();
	starPattern10();
}

#include<iostream>
using namespace std;

		void starPattern1()
        {
        	int i,j;
			for(i=0;i<=4;i++){
			
			for(j=0;j<=i;j++){
			cout<<"*";
			}
			cout<<"\n";
			}
}
        void starPattern2()
        {
          int a, b, c;
             for(a=5;a>=1;a--){
                
			   for(b=1;b<a;b++){
                 cout<<" ";
				 }
                  for(c=5;c>=a;c--){
                     cout<<"*";
					 }
					 cout<<"\n";

        }
    }
        void starPattern3()
        {
            int i, j;
              for(i=5;i>=1;i--){
         
		         for(j=1;j<=i;j++){
                     cout<<"*";
					 }
					 cout<<"\n";
					 }

        }
        void starPattern4()
        {
        	
            int i, j, k;
	             for(i=5;i>=1;i--){
	             	
	             	for(j=5;j>i;j--){
					 cout<<" ";
					 }
					 for(k=1;k<=i;k++){
					 cout<<"*";
					 }
					 cout<<"\n";
					 }
	}
        void starPattern5()
        {
        	
            int i,j;
			for(int i = 1; i <= 5; i++){
				
				for(int j = 1; j <= 5; j++){
				cout<< "*";
				}
				cout<<"\n";
				}

}
        void starPattern6()
        {
            int i,j;
            for(i=1;i<6;i++){
            	for (j=1;j<i;j++){
            		cout<< " ";
				}
				for(j=1;j<=5;j++){
					cout<< "*";
				}
				cout<< "\n";
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
            int i, j, k;
			
			 for(i=1; i<=5; i++){
			 
			     for(j=i; j<5; j++){
			     	cout << " ";
				 }
				 
				 for(k=1; k<(i*2); k++){
				 	cout << "*";
				 }
				 cout << "\n";
				 }

}
        void starPattern10()
        {
            int i, j, k;
			 for(i=5; i>=1; i--){
			 
			 for(j=i; j<5; j++){
			 	cout << " ";
			 }
			 
			 for(k=i*2; k>1; k--){
			 	cout << "*";
			 }
			 cout << "\n";
			 }

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

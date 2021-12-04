#include<iostream>
using namespace std;

		void starPattern1(){
    	
 		int a,b,rows=5;

   for(a=1;a<=rows;a++)
   {
	for(b=1;b<=a;b++)
	   cout<<"*";
	cout<<endl;
   }
   
   }
        void starPattern2(){
        
    	int i, j, k;
    	for(i=5;i>=1;i--)
    {
        for(j=1;j<i;j++)
        {          
            cout << " ";
        }
        for(k=5;k>=i;k--)
        {
            cout << "*";
        }
        cout << endl;
    }
 //   return 0;
}
   

        void starPattern3(){
		
    	int r=5;
		for(int i = r; i >= 1; --i)
    {
        for(int j = 1; j <= i; ++j)
        {
            cout << "* ";
        }
        cout << endl;
    }
    
 //   return 0;
}
        void starPattern4(){
    
    int i, j, k;
    for(i=5;i>=1;i--)
    {
        for(j=5;j>i;j--)
        {
        	cout << " ";
        }
        for(k=1;k<=i;k++)
        {
        	cout << "*";            
        }
        cout <<endl;        
    }


        }
        void starPattern5()
        {
        
int size=5;
 for (int r = 1; r <= size; ++r)
 {
 for (int col = 1; col <= size; ++col)
 {
 cout << "* ";
 }
 cout << endl;}

        }
        void starPattern6()
        {

    int i, j;
    for(i=1; i<=5; i++)
    {
        for(j=1; j<i; j++)
        {
            cout << " ";   
        }
        for(j=1; j<=5; j++)
        {
            cout << "*";   
        }
       cout <<endl;   
    }

 }
        void starPattern7()
        {

	int i, j;
    for(i=1; i<=5; i++)
    {
        for(j=1; j<=i; j++)
        {
            if(j==1 || j==i || i==5)
            {
                cout<< "*";
            }
            else
            {
            	cout << " ";                
            }
        }
        cout <<endl;
    
}

        }
        void starPattern8()
        {

	int i, j;
    for(i=1; i<=5; i++)
    {
        for(j=i; j<5; j++)
        {
        	cout << " ";
        }
        for(j=1; j<=i; j++)
        {
            if(i==5 || j==1 || j==i)
            {
            	cout << "*";                
            }
            else
            {
               cout << " ";
            }
        }
        cout <<endl;
    }
 //   return 0;
}

        
        void starPattern9()
    {
       
   int r=5, i, j, space;

   for(i = 1; i <= r; i++)
   {
      for(space = i; space < r; space++)
      {
         cout << " ";
      }
      for(j = 1; j <= (2 * i - 1); j++)
      {
         cout << "*";
      }

      cout << "\n";
   }

        }
        void starPattern10()
        {
		
    	int r=5;
		for(int i = r; i >= 1; --i)
    {
        for(int space = 0; space < r-i; ++space)
            cout << "  ";

        for(int j = i; j <= 2*i-1; ++j)
            cout << "* ";

        for(int j = 0; j < i-1; ++j)
            cout << "* ";

        cout << endl;
    }

    //return 0;

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

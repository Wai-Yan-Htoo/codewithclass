#include<iostream>
using namespace std;

		void starPattern1()
        {
            //write your code here
        int rows;
    cout << "Enter number of rows: ";
    cin >> rows;
    for(int i = 1; i <= rows; ++i)
    {for(int j = 1; j <= i; ++j)
    {cout << "* ";}
    cout << "\n";}
	
    
           




    }
        void starPattern2()
        {
            //write your code here
            

    int n, s, x, y;
    cout << "Enter number of rows to show star pattern: ";
    cin >> n;
    for(x = 1; x <= n; x++)
    {for(s = x; s < n; s++)
    cout << " ";
    for(y = 1; y <= x; y++)
    cout << "* ";
    cout << "\n";}   
    //return 0;
	
	}
        
        
        void starPattern3()
        {
            //write your code here
           


    int rows;
    cout << "Enter number of rows: ";
    cin >> rows;
    for(int i = rows; i >= 1; --i)
    {for(int j = 1; j <= i; ++j)
    {cout << "* ";}
    cout << endl;}
   // return 0;
	
	}
        
        
        void starPattern4()
        {
            //write your code here
            


    int i, j, k;
    for(i=5;i>=1;i--)
    {for(j=5;j>i;j--)
    {cout << " ";}
	for(k=1;k<=i;k++)
    {cout << "*";}
    cout <<endl;}    
//	return 0;
	
	}
        
        
        void starPattern5()
        {
            //write your code here
            


    int i, j;
    for (i = 1; i <= 5; i++)
    {for (j = 1; j <= 5; j++)
    {cout<<"*";}
    cout<<endl;}
	
	}
        
        
        void starPattern6()
        {
            //write your code here
            


    int i, j;
    for(i=1; i<=5; i++)
    {for(j=1; j<i; j++)
    {cout << " ";}
    for(j=1; j<=5; j++)
    {cout << "*";}
    cout <<endl;}
	//return 0;
	
	}
        
        
        void starPattern7()
        {
            //write your code here
            
 

    int i, j;
    int MAX = 10;
    for (i = 1; i <= MAX; i++)
    {for (j = 1; j <= i; j++)
    {if (j == 1 || j == i || i == MAX)
    {cout<<"*";}
    else{cout<<" ";}}cout<<endl;}
	
	}
        
        
        void starPattern8()
        {
            //write your code here
            


    int i, j;
    for(i=1; i<=5; i++)
    {for(j=i; j<5; j++)
    {cout << " ";}
    for(j=1; j<=i; j++)
    {if(i==5 || j==1 || j==i)
    {cout << "*";}
    else{cout << " ";}}
    cout <<endl;}
   // return 0;
	
	}
    
    
        void starPattern9()
        {
            //write your code here
            


    int space, rows;
    cout <<"Enter number of rows: ";
    cin >> rows;
    for(int i = 1, k = 0; i <= rows; ++i, k = 0)
    {for(space = 1; space <= rows-i; ++space)
    {cout <<"  ";}
    while(k != 2*i-1)
    {cout << "* ";++k;}
    cout << endl;}//return 0;
	
	} 
        
        
        void starPattern10()
        {
            //write your code here


    int rows;
    cout << "Enter number of rows: ";
    cin >> rows;
    for(int i = rows; i >= 1; --i)                                                                                
	{for(int space = 0; space < rows-i; ++space)
    cout << "  ";
    for(int j = i; j <= 2*i-1; ++j)
    cout << "* ";
    for(int j = 0; j < i-1; ++j)
    cout << "* ";
    cout << endl;}  
   // return 0;

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

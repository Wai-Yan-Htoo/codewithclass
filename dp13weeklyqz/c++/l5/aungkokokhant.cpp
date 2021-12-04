#include<iostream>
using namespace std;

	void temperature_changer(){
	    double user_cel,c;
	    double f;
	    cout<<"enter cel:";
	    cin>>user_cel;
	    f=(user_cel*9/5)+32;
	    cout<<" Fer ="<<f<<"\370"<<"F"<<endl;
	    c=(f-32)*5/9;
	    cout<<"Cei= "<<c<<"\370";	
	    
	}
	
	void area_of_circle(){
	    float pi=3.142,r=12;
	    float area=pi*(r*r);
	    cout<<area<<endl;
	}
	
	void armstrongnumber(){
	  int n,f,s=0,t;
	  cout<<"Enter your number";
	  cin>>n;
	  f=n;
	   while(f!=0){
		t=f%10;
		s=s+(t*t*t);
		f=f/10;
	 }
	  if(s==n){
		cout<<n<<"is an amstrong number";
	  }
      else{
   	   cout<<n<<"is not armstrong number";
   }
}

void quiz2(){
	int R1,R2,S;
	cin>>R1>>S;
	cout<<S*2-R1<<endl;
	
	
}

void quiz3(){
	
}

void quiz4(){
	
}

void quiz5(){
	int x,y,z;
	cout<<"enter numbers";
	cin>>x>>y>>z;
	for(int i=1;i<=z;i++){
		if(i%x==0 && i&y==0){
			cout<<"FizzBuzz"<<endl;
		}
		else if(i%x==0){
			cout<<"Fizza"<<endl;
		}
		else if(i%y==0){
			cout<<"Buzz"<<endl;
		}
		else{
			cout<<i<<endl;
		}
	}
}

void quiz6(){
	
}

void quiz7(){
	int t,cal;
	cin>>t;
	for(int i=0;i<t;i++){
		cin>>cal;
		if(cal%400==0){
			cout<<cal/400<<endl;
		}
		else{
			cout<<cal/400+1<<endl;
		}
	}
}

void quiz8(){
	
}


int main(){
 //  temperature_changer();
 	area_of_circle();
}

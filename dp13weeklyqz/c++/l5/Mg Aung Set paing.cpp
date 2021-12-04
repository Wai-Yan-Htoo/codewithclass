#include<iostream>
using namespace std;
void quiz1(){
	void temperature_changer(){
		
	float fahren, celsius;
  
    cout << "temperature in fahrenheit : \n";
    cin >> fahren; 
    celsius = 5 * (fahren - 32) / 9;
    cout << fahren <<" Fahrenheit = " << celsius <<" Centigrade";
		
	}
	
	void area_of_circle(){ 
	
	    float radius, area;

 

    cout << "radius = ";

    cin >> radius;

    area = 3.14 * radius * radius;

    cout << "Area = "

     << area;
	
	
	}
	
	void armstrongnumber(){
	
    int num, count = 100, rem, sum;  
  
    while(count <= 500)  
    {  
        num = count;  
        sum = 0;  
  
        while(num)  
        {  
            rem = num % 10;  
            sum = sum + (rem * rem * rem);  
            num = num / 10;  
        }  
  
        if(count == sum)  
        {  
            printf("%d is a Armstrong number\n", count);  
        }  
  
        count++;  
    }  
  
	
	
}

void quiz2(){
	    int r1, s;
    cin >> r1 >> s; 
    cout << s * 2 - r1 <<endl;
	
}

void quiz3(){  
	int first, second;
    cin >> first >> second;

    int rev_first = 0, rev_second = 0;
    
    int x = 3;
    while (x--) {
        rev_first = rev_first * 10 + (first % 10);
        first /= 10;

        rev_second = rev_second * 10 + (second % 10);
        second /= 10;
    }

    cout << max(rev_first, rev_second) << endl;
}


void quiz4() {
	
	int idx = 0, f = 0, s = 0;
    char c;

    while (cin >> c) {
        if (c == ')' && (s == 1 || s == 2)) {
        cout << f <<endl;
            s = 0;
            f = idx;
        } else if (c == ':' || c == ';') {
            s = 1;
            f = idx;
        } else if (c == '-' && s == 1) {
            s = 2;
        } else {
            s = 0;
        }

        idx++;
}
}

void quiz5(){
	 int x, y, n;
  cin >> x >> y >> n;
  for (int i = 1; i <= n; i++) 
    {
    if (i % x == 0 and i % y == 0) 
	{
      cout << "FizzBuzz" << endl;
    } else if (i % x == 0) {
      cout << "Fizz" << endl;
    } else if (i % y == 0) {
      cout << "Buzz" << endl;
    } else {
      cout << i << endl;
    }
    }
	
}

void quiz6(){
	
	  int first, second;
    cin >> first >> second;

    int rev_first = 0, rev_second = 0;
    
    int x = 3;
    while (x--) {
        rev_first = rev_first * 10 + (first % 10);
        first /= 10;

        rev_second = rev_second * 10 + (second % 10);
        second /= 10;
    }

    cout << max(rev_first, rev_second) << endl;
}

void quiz7(){
	int n;
    cin >> n;
    for(int i = 0; i < n; i++) {
        int num;
        cin >> num;
        cout << ceil(num / 400.0) << endl;
    }
	
}

void quiz8(){
	   int a, b, c;
    cin >> a >> b >> c;

    if(a + b == c) {
        cout << a << "+" << b << "=" << c << endl;
   
    }
    if(a - b == c) {
        cout << a << "-" << b << "=" << c << endl;
    
    }
    if(a * b == c) {
        cout << a << "*" << b << "=" << c << endl;
    
    }
    if(a / b == c) {
        cout << a << "/" << b << "=" << c << endl;
    
    }
    if(a == b + c) {
        cout << a << "=" << b << "+" << c << endl;
      
    }
    if(a == b - c) {
        cout << a << "=" << b << "-" << c << endl;
       
    }
    if(a == b * c) {
        cout << a << "=" << b << "*" << c << endl;
      
    }
    if(a == b / c) {
        cout << a << "=" << b << "/" << c << endl;
    
    }
	
}


int main(){
	
	
}

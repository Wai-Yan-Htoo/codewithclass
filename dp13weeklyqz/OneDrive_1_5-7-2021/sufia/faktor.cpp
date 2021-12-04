#include<iostream>
using namespace std;
int main()
{
    int article ,impact ,scientists;
    //cout <<"Enter how many articles are u going to publish"<<endl;
    cin >>article;
    //cout <<"Enter the impact factor that is required" <<endl;
    cin >>impact;
    scientists = article * (impact -1);
    cout <<scientists +1;
    
    
}

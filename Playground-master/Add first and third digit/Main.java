#include<stdio.h>
int main()
{
  //Type your code here
  int n,temp;
  scanf("%d",&n);
  temp = n;
  n %= 10;
  n %= 10;
  temp /= 100;
  printf("%d",n+temp);
  return 0;
}
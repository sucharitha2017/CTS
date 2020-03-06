#include<stdio.h>
int main()
{
  //Type your code here
  int n,temp;
  scanf("%d",&n);
  temp = n;
  n %=10;
  temp /=10;
  printf("%d",n+temp);
  return 0;
}
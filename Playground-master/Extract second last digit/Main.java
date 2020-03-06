#include<stdio.h>
int main()
{
  //Type your code here
  int n,i=0;
  scanf("%d",&n);
  n = n/10;
  while(i<n)
  {
    n %=10;
    i++;
  }
  printf("%d",n);
  return 0;
}
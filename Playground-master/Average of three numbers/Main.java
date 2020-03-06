#include<stdio.h>
int main()
{
  //Type your code here
  int n1,n2,n3,sum = 0,avg;
  scanf("%d%d%d",&n1,&n2,&n3);
  sum = n1+n2+n3;
  avg = sum/3;
  printf("%d",avg);
  return 0;
}
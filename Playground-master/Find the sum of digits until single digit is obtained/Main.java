#include<stdio.h>
int main()
{
  int n,sum = 0,temp;
  scanf("%d", &n);
  while(n>0)
  {
 while(n!=0)
 {
      sum += n%10;
      n /= 10;
 }
  if(sum > 9)
  {
    n = sum;
    sum = 0;
  }
}
  printf("%d", sum);
  
  return 0;
}
#include<stdio.h>
int main()
{
  int a,b,c;

  scanf("%d%d%d",&a,&b,&c);
  if(a>b)
  {
    if(a>c)
    {
      printf("second greates = %d",c);
    }
    else{
    printf("second greatest = %d", a);}
  }
  else if(b>a)
  {
    if(b>c)
    {
      printf("second greatest = %d",c);
    }
    else{
    printf("second greatest = %d", b);}
  }
  
  return 0;
}
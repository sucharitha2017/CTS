#include<stdio.h>
#define PI 3.14

int main()
{
  float r,res;
  scanf("%f",&r);
  res = PI*r*r;
  printf("%.2f", res);
  
  return 0;
}
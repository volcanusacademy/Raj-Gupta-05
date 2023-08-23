problem5.c
//// modulous divide 

#include<stdio.h>

int main(){
    int a,b,div;
    printf("enter value a :");
    scanf("%d", &a);

    printf("enter value b :");
    scanf("%d", &b);

    div = a%b;

    printf("%d", &div);

    return 0;
}
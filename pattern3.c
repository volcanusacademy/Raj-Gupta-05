#include<stdio.h>

void main(){
    int row,i,j;
    printf("enter row  :");
    scanf("%d", &row);

    for(i=1;i<=row;i++)
    {
        for(j=1;j<=i;j++)
        {
            if(j%2==1)
            printf("##");
            else
            printf("*");
 }


          /// printf("%d");
        }
        printf("\n");
    
    return 0;
}    

#include<stdio.h>

void main(){
    
    int row,i,j; 
    
    printf("enter row :");
    scanf("%d",row);
    
    for(i=1;i<=row;i++)
    {
        
        for(j=1;j<=i;j++)
        {
            
            printf("*");
            
        }
    }
    for(i=row/2-1;i>=1;i--)
    {
        for(j=i;j<=i;j++)
        {
            printf("*");
            
        }
        printf("\n");
    }
return 0;    
} 

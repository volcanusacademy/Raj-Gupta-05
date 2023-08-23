#include<stdio.h>

int main(){
    
    int row,i,j; 
    
    printf("enter row :");
    scanf("%d", &row);
    
    for(i=1;i<=row;i++)
    
    {
        if(i%2!=0){
            printf("*");
            
        }
        else
        printf("#");
        for(j=1;j<=row-i+1;j++)
        {
            
            printf("*");
        }
        printf("\n");
    }
    
}
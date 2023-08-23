#include <stdio.h>

void main(){
    int row,i,j;
    printf("enter row  :");
    scanf("%d", &row);

    for(i=1;i<=row;i++)
    {
        for(j=1;j<=i;j++)
        {
            printf("%c",64+1);
           
}

          /// printf("%d");
        }
        printf("\n");
    
    return 0;
}    

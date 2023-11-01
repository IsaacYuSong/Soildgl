int screenWidth 80;
int screenHeight 25;
void sdDraw(int x,int y,short c=0x2588,short col=0x000F)
{
    char screen[screenHeight][screenWidth];
    short colors[screenHeight][screenWidth];
    if (x >= 0 && x < SCREEN_WIDTH && y >= 0 && y < SCREEN_HEIGHT)
    {
        screen[y][x] = c;
        colors[y][x] = col;
    }
}
void sdDrawLine(int x1,int y1,int x2,int y2)
{
    int lineLengthX=abs(x1-x2);
    int lineLengthY=abs(y1-y2);
    if(lineLengthX>lineLengthY)
    {
        for(int i=0;i<=lineLengthX;i++)
        {
            printf("-");
        
        }
    }
    else
    {
        for(int i=0;i<=lineLengthY;i++)
        {
            printf("|\n");
        
        }
    }
    
}
void sdDrawRect(int width,int height)
{
    for(int i=0;i<=width;i++)
    {
        for(int i=0;i<= height;i++)
        {
            printf("-");
        }
        printf("\n");
    }
}


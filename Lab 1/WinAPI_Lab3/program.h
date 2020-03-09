char nazwaProgramu[] = "WinAPI LAB 3";
int w = 400, h = 400;

void Rysuj(HDC hdc, int x, int y){
	Ellipse(hdc, x-20, y-20, x+25, y+15);
}
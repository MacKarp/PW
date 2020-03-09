const int Window_Width = 816, Window_Height = 634;
const char Window_Title[] = "WinAPI Laboratorium 3 - Zadanie 1";
void Draw_Window(HDC hdc, int ellipse_size_modifier)
{
	Ellipse(hdc, 400-ellipse_size_modifier,250-ellipse_size_modifier, 450+ellipse_size_modifier, 300+ellipse_size_modifier);
}

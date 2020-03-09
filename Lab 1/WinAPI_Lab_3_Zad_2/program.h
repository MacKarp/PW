const int Window_Width = 816, Window_Height = 634;
const char Window_Title[] = "WinAPI Laboratorium 3 - Zadanie 1";
void Draw_Window(HDC hdc, bool double_click_status, int cursor_x_position, int cursor_y_position)
{
	if(double_click_status == 0)
	{
		SetTextColor(hdc, RGB(0, 255, 0));
	}
	if(double_click_status == 1)
	{
		SetTextColor(hdc, RGB(255, 0, 0));
	}
	TextOut(hdc, cursor_x_position - 50, cursor_y_position - 10, "Karpiñski Maciej", 16);
}

// WindowsProject3.cpp : 응용 프로그램에 대한 진입점을 정의합니다.
//

#include "stdafx.h"
#include "WindowsProject3.h"
#include <windows.h>
#include <tchar.h>

LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM);

HWND hwndMain;

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, PSTR szCmdLine, int iCmdShow) {
	static TCHAR szAppName[] = _T("*틱택토 게임*");
	MSG msg;
	WNDCLASSEX wndclass;

	wndclass.cbSize = sizeof(wndclass);
	wndclass.style = CS_HREDRAW | CS_VREDRAW;
	wndclass.lpfnWndProc = WndProc;
	wndclass.cbClsExtra = 0;
	wndclass.cbWndExtra = 0;
	wndclass.hInstance = hInstance;
	wndclass.hIcon = LoadIcon(NULL, IDI_APPLICATION);
	wndclass.hCursor = LoadCursor(NULL, IDC_ARROW);
	wndclass.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);         //배경색을 지정해 주었습니다.
	wndclass.lpszMenuName = NULL;
	wndclass.lpszClassName = szAppName;
	wndclass.hIconSm = LoadIcon(NULL, IDI_APPLICATION);

	RegisterClassEx(&wndclass);

	hwndMain = CreateWindowEx(0,
		szAppName,
		_T("*틱택토 게임*"),                  //메인창 이름을 설정해 주었습니다.
		WS_OVERLAPPED | WS_SYSMENU | WS_CAPTION | WS_MINIMIZEBOX,
		CW_USEDEFAULT,
		CW_USEDEFAULT,
		366,                                 //메인창 크기를 설정해 주었습니다.
		382,
		NULL,
		NULL,
		hInstance,
		NULL);

	ShowWindow(hwndMain, iCmdShow);
	UpdateWindow(hwndMain);

	while (GetMessage(&msg, NULL, 0, 0))
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}
	return msg.wParam;
}

#define EX 1
#define OH 2

const RECT m_rcSquares[9] = {//틱택토 플레이어 
{ 16, 16,112,112},           //말들을놓을 수 있는 좌표값 입니다.
{128, 16,224,112},
{240, 16,336,112},
{ 16,128,112,224},
{128,128,224,224},
{240,128,336,224},
{ 16,240,112,336},
{128,240,224,336},
{240,240,336,336}
};

int m_nNextChar = EX, m_nGameGrid[9];

int GetRectID(int x, int y) {
	for (int i = 0; i < 9; i++)
	{
		if (x > m_rcSquares[i].left && x < m_rcSquares[i].right &&
			y > m_rcSquares[i].top && y < m_rcSquares[i].bottom)
			return i;
	}
	return -1;
}

void DrawX(HDC hdc, int nPos) {
	HPEN pen = ::CreatePen(PS_SOLID, 10, RGB(0, 0, 0));  //X플레이어의 색을 설정해 주었습니다.
	void *oldPen = ::SelectObject(hdc, pen);

	RECT rect = m_rcSquares[nPos];

	rect.top += 20;                                      //X플레이어의 네모칸 간격을 설정해 주었습니다.
	rect.bottom -= 20;
	rect.left += 20;
	rect.right -= 20;

	::MoveToEx(hdc, rect.left, rect.top, NULL);
	::LineTo(hdc, rect.right, rect.bottom);
	::MoveToEx(hdc, rect.left, rect.bottom, NULL);
	::LineTo(hdc, rect.right, rect.top);

	::SelectObject(hdc, (HGDIOBJ)oldPen);
	::DeleteObject(pen);
}

void DrawO(HDC hdc, int nPos) {
	HPEN pen = ::CreatePen(PS_SOLID, 10, RGB(0, 0, 0));//O플레이어의 색을 설정해 주었습니다.
	void *oldPen = ::SelectObject(hdc, pen);
	void *oldBr = ::SelectObject(hdc, GetStockObject(NULL_BRUSH));

	RECT rect = m_rcSquares[nPos];

	rect.top += 20;
	rect.bottom -= 20;
	rect.left += 20;
	rect.right -= 20;

	::Ellipse(hdc, rect.left, rect.top, rect.right, rect.bottom);
	::SelectObject(hdc, (HGDIOBJ)oldBr);
	::SelectObject(hdc, (HGDIOBJ)oldPen);
	::DeleteObject(pen);
}

void DrawBoard(HDC hdc) {
	// 선 그리기
	HPEN pen = ::CreatePen(PS_SOLID, 5, RGB(0, 0, 255));//틱택토 게임의 배경 선 색을 설정해 주었습니다.
	void *oldPen = ::SelectObject(hdc, pen);

	::MoveToEx(hdc, 120,16, NULL);
	::LineTo(hdc, 120, 336);

	::MoveToEx(hdc, 232, 16, NULL);
	::LineTo(hdc, 232, 336);

	::MoveToEx(hdc, 16, 120, NULL);
	::LineTo(hdc, 336, 120);

	::MoveToEx(hdc, 16, 232, NULL);
	::LineTo(hdc, 336, 232);

	// X O 표시
	for (int i = 0; i < 9; i++)
	{
		if (m_nGameGrid[i] == EX)
			DrawX(hdc, i);
		else if (m_nGameGrid[i] == OH)
			DrawO(hdc, i);
	}
	::SelectObject(hdc, (HGDIOBJ)oldPen);
	::DeleteObject(pen);
}

int IsWinner() {//승리 공식입니다.
	static int nPattern[8][3] = {
	0, 1, 2,
	3, 4, 5,
	6, 7, 8,
	0, 3, 6,
	1, 4, 7,
	2, 5, 8,
	0, 4, 8,
	2, 4, 6
	};

	for (int i = 0; i < 8; i++)
	{
		if ((m_nGameGrid[nPattern[i][0]] == EX) &&
			(m_nGameGrid[nPattern[i][1]] == EX) &&
			(m_nGameGrid[nPattern[i][2]] == EX))
			return EX;
		if ((m_nGameGrid[nPattern[i][0]] == OH) &&
			(m_nGameGrid[nPattern[i][1]] == OH) &&
			(m_nGameGrid[nPattern[i][2]] == OH))
			return OH;
	}
	return 0;
}

BOOL IsDraw() {
	for (int i = 0; i < 9; i++)
	{
		if (m_nGameGrid[i] == 0)
			return FALSE;
	}
	return TRUE;
}

void ResetGame() {
	RECT rect;

	m_nNextChar = EX;
	::ZeroMemory(m_nGameGrid, 9 * sizeof(int));
	::GetClientRect(hwndMain, &rect);
	::InvalidateRect(hwndMain, &rect, TRUE);
}

void CheckForGameOver() {
	int nWinner;

	if (nWinner = IsWinner())
	//게임이 끝났을시 멘트를 설정해 주었습니다.
	{
		MessageBox(hwndMain, ((nWinner == EX) ? _T("X플레이어의 승리!") : _T("O플레이어의 승리!")), 
			_T("게임 종료!"), MB_ICONEXCLAMATION | MB_OK);
		ResetGame();
	}
	else if (IsDraw())
	{
		MessageBox(hwndMain, _T("비겼습니다!"), _T("게임 종료!"), MB_ICONEXCLAMATION | MB_OK);
		ResetGame();
	}
}

LRESULT CALLBACK WndProc(HWND hwnd, UINT iMsg, WPARAM wParam, LPARAM lParam) {   
	//조작법 설정
	HDC hdc;
	PAINTSTRUCT ps;
	int nPos;

	switch (iMsg)
	{
	case WM_LBUTTONDOWN:       //마우스 하나로도 플레이할 수 있고 편리하도록
		if (m_nNextChar != EX) //X플레이어는 마우스 왼쪽버튼, O플레이어는 마우스 오른쪽버튼을 누르도록 하였습니다.
			return 0;
		nPos = GetRectID(LOWORD(lParam), HIWORD(lParam));
		if ((nPos == -1) || (m_nGameGrid[nPos] != 0))
			return 0;
		m_nGameGrid[nPos] = EX;
		m_nNextChar = OH;
		hdc = ::GetDC(hwndMain);
		DrawX(hdc, nPos);
		CheckForGameOver();
		return 0;

	case WM_RBUTTONDOWN:
		if (m_nNextChar != OH)
			return 0;
		nPos = GetRectID(LOWORD(lParam), HIWORD(lParam));
		if ((nPos == -1) || (m_nGameGrid[nPos] != 0))
			return 0;
		m_nGameGrid[nPos] = OH;
		m_nNextChar = EX;
		hdc = ::GetDC(hwndMain);
		DrawO(hdc, nPos);
		CheckForGameOver();
		return 0;

	case WM_MBUTTONDOWN:
		ResetGame();
		return 0;

	case WM_PAINT:
		hdc = BeginPaint(hwnd, &ps);

		//GetClientRect (hwnd, &rect);
		SetBkMode(hdc, TRANSPARENT);
		DrawBoard(hdc);

		EndPaint(hwnd, &ps);
		return 0;

	case WM_DESTROY:
		PostQuitMessage(0);
		return 0;
	}

	return DefWindowProc(hwnd, iMsg, wParam, lParam);
}
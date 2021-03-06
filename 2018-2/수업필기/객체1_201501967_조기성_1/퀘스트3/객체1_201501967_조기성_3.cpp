#include <iostream>
#include <string>
#include <vector>
#include <fstream>
using namespace std;

class License {
	string name;
	string number;
	string phone;
	string area;
	string area2;
public: //텍스트 불러오기
	License() :name(""), number(""), phone(""), area(""), area2("") {}
	void information(string na, string nb, string ph, string a, string a2) {
		name = na; number = nb; phone = ph; area = a; area2 = a2;
	}

	void display() { //텍스트 불러오기 바탕 양식
		cout << "######################################\n"
			<< "#########사장님 앞으로 등록된#########\n"
			<< "###########사업자 등록 증서###########\n"
			<< "######################################\n"
			<< "사업자등록증\n" << "사업자이름 : " << name << "\n사업자번호 : " << number
			<< "\n연락처 : 0" << phone << "\n거주지 : "
			<< area << "\n상호명 : " << area2 << endl;
	}
	License(string na, string nb, string ph) {
		name = na;
		number = nb;
		phone = ph;
	}
	void enter() {
		cout << name << number << phone << endl;
	}
};

class Node { //리스트 노드 선언
	int data;
	Node *next;
public:
	Node() : data(0), next(nullptr) {}
	int rData() {
		return data;
	}
	void wData(int val) {
		data = val;
	}
	Node* rNext() {
		return next;
	}
	void wNext(Node *n) {
		next = n;
	}
};

class List { //기능
	Node *head, *tail;
public:
	List() :head(nullptr), tail(nullptr) {}
	void createNode(int value) {   // 노드의 추가
		Node *temp = new Node;
		temp->wData(value);   // temp->data = value;
		temp->wNext(nullptr);
		if (head == nullptr) {
			head = temp;
			tail = temp;
			temp = nullptr;
		}
		else {
			tail->wNext(temp);
			tail = temp;
		}
	}
	void display() {
		Node *temp = new Node;
		temp = head;
		while (temp != nullptr)
		{
			cout << temp->rData() << "\t";
			temp = temp->rNext();
		}
		cout << endl << endl;
	}
	void insertFirst(int value) {
		Node *temp = new Node;
		temp->wData(value);
		temp->wNext(head);
		head = temp;
	}
	void deleteFirst() {
		Node *temp = new Node;
		temp = head;
		head = head->rNext();
		delete temp;
	}
	void deleteLast() {
		Node *current = new Node;
		Node *previous = new Node;
		current = head;
		while (current->rNext() != nullptr) {
			previous = current;
			current = current->rNext();
		}
		tail = previous;
		previous->wNext(nullptr);
		delete current;
	}
	void deleteAt(int pos) {
		Node *current = new Node;
		Node *previous = new Node;
		current = head;
		for (int i = 1; i < pos; i++) {
			previous = current;
			current = current->rNext();
		}
		previous->wNext(current->rNext());
	}
};

class reservation {
	string name2;
	int phone2;
	bool manager;
public:
};

class person {
	string name;
	int id;
	int balance;
public:
	void food_person(vector<person>& accts);
	void print_person(vector<person>& accts);
	bool less_than_by_name(person& e1, person& e2);
	bool less_than_by_id(person&e1, person& e2);
	bool less_than_by_balance(person& e1, person& e2);
	void swap(person& e1, person& e2);
};

void person::food_person(vector<person>& accts) {
	cout << "\n 배달 시키고싶은 음식 이름을 입력해주세요 : ";
	cin >> name;
	cout << "\n 배달 시키고싶은 음식의 수량을 입력해주세요 : ";
	cin >> id;
	cout << "\n 주문자님의 연락처를 입력해주세요 : ";
	cin >> balance;
	accts.push_back(*this);
}

void person::print_person(vector<person>& accts) {
	int n = accts.size();
	for (int i = 0; i < n; i++) {
		cout << accts[i].name << ", " << accts[i].id
			<< ", " << accts[i].balance << '\n';
	}
}

bool person::less_than_by_name(person& e1, person & e2) {
	return e1.name < e2.name;
}

bool person::less_than_by_id(person& e1, person & e2) {
	return e1.id < e2.id;
}

bool person::less_than_by_balance(person& e1, person& e2) {
	return e1.balance < e2.balance;
}

void person::swap(person& er1, person& er2) {
	person temp = er1;
	er1 = er2;
	er2 = temp;
}

int main() { //메인 화면 및 기능들
	List lst;
	ifstream fin("license1.txt");
	License temp;
	vector <License> gr;
	string nb, ph;
	string na, a, a2;
	while (!fin.eof()) {
		fin >> na >> nb >> ph >> a >> a2;
		temp.information(na, nb, ph, a, a2);
		gr.push_back(temp);
	}
	for (int i = 0; i < gr.size(); i++) {
		gr[i].display();
	}
	vector<person> customers;
	person tmp;
	char cmd;
	bool done = false;
	do {
		cout << "///////////////////////////////////////\n";
		cout << "////////////*배달의 민족*//////////////\n";
		cout << "///////////////////////////////////////\n";
		cout << "////////////*사업자 모드*//////////////\n";
		cout << "///////////////////////////////////////\n";
		cout << "[1]메뉴열람~ [2]주문등록~ [3]주문목록~ \n";
		cout << "[4]배달완료~ [5]배달현황~ [6]배민종료~ \n";
		cout << "~원하시는 작업의 번호를 입력해주세요!~ \n";

		cin >> cmd;
		switch (cmd)
		{
		case'2':
			tmp.food_person(customers);
			lst.insertFirst(0);
			cout << "\n50분 소요될 예정입니다.\n";
			break;
		case'3':
			tmp.print_person(customers);
			break;
		case'1':
			cout << "치킨은 3만원 입니다.\n";
			cout << "피자은 1만원 입니다.\n";
			cout << "족발은 3만원 입니다.\n";
			cout << "초밥은 5만원 입니다.\n";
			cout << "도시락은 1만원 입니다.\n";
			cout << "닭볶음탕은 2만원 입니다.\n";
			break;
		case'4':
			cout << "\최근 배달이 완료되었습니다.\n";
			lst.deleteFirst();
			break;
		case'5':
			cout << "\n현재 주문리스트 입니다.\n";
			lst.display();
			break;
		case'6':
			cout << "안녕히가세요!";
			done = true;
			break;
		default:
			break;
		}
	} while (!done);
}
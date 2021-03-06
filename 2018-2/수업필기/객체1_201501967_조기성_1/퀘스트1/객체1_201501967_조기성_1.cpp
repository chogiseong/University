#include <iostream>
#include <string>
#include <vector>
using namespace std;

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

	void sort(vector<person>&db, int n);

};



void person::food_person(vector<person>& accts) {

	cout << "치킨은 5만원입니다";

	cin >> name >> id >> balance;

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



void person::sort(vector<person>& db, int n) {

	int size = db.size();

	for (int i = 0; i < size - 1; i++) {

		int smallest = i;

		for (int j = i + 1; j < size; j++) {

			switch (n)

			{

			case 1://id

				if (less_than_by_id(db[j], db[smallest]))

					smallest = j;

				break;

			case 2://

				if (less_than_by_name(db[j], db[smallest]))

					break;

			case 3://id

				if (less_than_by_balance(db[j], db[smallest]))

					break;

			default:

				break;

			}

		}

	}

}

int main() {

	vector<person> customers;

	person tmp;

	char cmd;

	bool done = false;

	do {

		cout << "[1]치킨~ [2]피자~ [3]닭볶음탕~ ";

		cout << "[4]족발~ [5]초밥~ [6]도시락~ ";

		cin >> cmd;

		switch (cmd)

		{

		case'1':

			tmp.food_person(customers);

			break;

		case'2':

			tmp.print_person(customers);

			break;

		case'3':

			tmp.sort(customers, 2);

			tmp.print_person(customers);

			break;

		case'4':

			tmp.sort(customers, 1);

			tmp.print_person(customers);

			break;

		case '5':

			tmp.sort(customers, 3);

			tmp.print_person(customers);

			break;

		case'6':

			done = true;

			break;

		default:

			break;

		}

	} while (!done);

}
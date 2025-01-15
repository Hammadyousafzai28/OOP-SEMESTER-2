#include <iostream>
using namespace std;
void amount_Customer();
void depositAmount();
void takeLoan();
void giveLoan();
void deductZakaat();
void currentamount_Customer();

string name, option, roll, name2, option2, decision;
int amountOfCustomer;
int amountDeposit;
int loan;
int zakaatAmount;
int currentAmount;

int main()
{
    while (true)
    {
        cout << "ENTER YOUR ROLL: " << endl;
        cout << "CUSTOMER.." << endl;
        cout << "BANK..." << endl;
        cin >> roll;

        if (roll == "CUSTOMER")
        {

            cout << "Enter your name: ";
            cin >> name;
            while (true)
            {
                cout << "Welcome " << name << endl;
                cout << "ENTER OPTION TO CHOOSE..." << endl;
                cout << "1.BANK ACCOUNT" << endl;
                cout << "2.DEPOSIT AMOUNT" << endl;
                cout << "3.TAKE LOAN" << endl;
                cout << "ENTER YOUR OPTION..";
                cin >> option;

                if (option == "1")
                {
                    amount_Customer();
                }
                if (option == "2")
                {
                    depositAmount();
                }
                if (option == "3")
                {
                    takeLoan();
                }
                if (option == "4")
                {
                    break;
                }
            }
        }

        if (roll == "BANK")
        {
            cout << "Enter your name: ";
            cin >> name2;
            while(true)
            {
            cout << "Welcome " << name2 << endl;
            cout << "ENTER OPTION TO CHOOSE..." << endl;
            cout << "1.GIVE LOAN" << endl;
            cout << "2.DETUCT ZAKAAT" << endl;
            cout << "3.VIEW CUSTOMERS AMOUNT" << endl;
            cout << "ENTER YOUR OPTION..";
            cin >> option2;

            if (option2 == "1")
            {
                giveLoan();
            }
            if (option2 == "2")
            {
                deductZakaat();
            }
            if (option2 == "3")
            {
                currentamount_Customer();
            }
            }
        }
    }
}

void amount_Customer()
{

    cout << "Enter your amount: ";
    cin >> amountOfCustomer;
}
void depositAmount()
{
    cout << "ENTER THE AMOUNT YOU WANT TO DEPOSIT:";
    cin >> amountDeposit;
    amountOfCustomer = amountOfCustomer + amountDeposit;
}
void takeLoan()
{
    cout << "ENTER THE AMOUNT OF LOAN: ";
    cin >> loan;
    // amountOfCustomer = amountOfCustomer + loan;
}
void giveLoan()
{
    cout << "THE USER HAS DEMANDED THE FOLLOWING LOAN : " << loan << endl;
    cout << "DO YOU WANT TO GIVE LOAN TO THE CUSTOMER , TYPE YES OR NO : ";
    cin >> decision;
    if (decision == "YES")
    {
        amountOfCustomer = amountOfCustomer + loan;
    }
    if (decision == "NO")
    {
        cout << "LOAN HAS NOT BEEN GRANTED";
    }
}
void deductZakaat()
{
    cout << amountOfCustomer;
    if (amountOfCustomer >= 140000)
    {
        zakaatAmount = amountOfCustomer * 0.25;
        cout << "The amount of zakaat is :" << zakaatAmount;
        currentAmount = amountOfCustomer - zakaatAmount;
        cout << "CURRENT AMOUNT IS :" << currentAmount;
    }
    else
    {
        cout << "NO ZAKAAT HAS BEEN DETUCTED.";
    }
}
void currentamount_Customer()
{
    cout << amountOfCustomer;
}

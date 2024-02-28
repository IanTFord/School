/*
 * Name: Ian Ford
 * 
 * Proj: Assignment 1
 *
 * Course: Concepts of Programming Languages
 *
 * Date: 8/23/23
 *
 * Desc: four basic operations on complex numbers
 */
#include <iostream>
#include <string>

using namespace std;

class ComplexNumber{

	float realValue;
	float imaginaryValue;

	static const int precision = 2;

	public:

		ComplexNumber(float real, float iVal){
			realValue = real;
			imaginaryValue = iVal;
		}

		//Returns a string displaying the complex number as the sum of it's real and imaginary parts
		void GetString(string& outString){
			//Convert real float to string and truncate decimal to precision length
			string realString      = to_string(realValue);
			realString = realString.substr(0, GetDecimalIndex(realString) + 1 + precision);

			//Convert imaginary float to string and truncate decimal to precision length
			string imaginaryString = to_string(imaginaryValue);
			imaginaryString = imaginaryString.substr(0, GetDecimalIndex(imaginaryString) + 1 + precision);

			//Formatting Below
			outString = "";
			if(realValue != 0) outString += realString;

			if(realValue == 0 && imaginaryValue == 0) outString = "0";
			else if(realValue != 0)
			{ 
				if(imaginaryValue > 0) outString += " + ";
				else                   outString += "  ";
			}

			if(imaginaryValue != 0) outString += imaginaryString + "i";
		}
		//Returns Index of the first '.' in the string returning -1 if not found
		int GetDecimalIndex(string& s){
			for(int i = 0; i < s.length(); i++){
				if(s[i] == '.')
					return i;
			}

			return -1;
		}

		//Adds a to b
		static ComplexNumber Add(ComplexNumber a, ComplexNumber b){
			return ComplexNumber (a.realValue + b.realValue, a.imaginaryValue + b.imaginaryValue);
		}
		//Subtracts b from a
		static	ComplexNumber Subtract(ComplexNumber a, ComplexNumber b){
			return ComplexNumber(a.realValue - b.realValue, a.imaginaryValue - b.imaginaryValue);
		}
		//Multiplies a by b
		static	ComplexNumber Multiply(ComplexNumber a, ComplexNumber b){
			float newRealValue = a.realValue * b.realValue - a.imaginaryValue * b.imaginaryValue;
			float newImaginaryValue = a.realValue * b.imaginaryValue + a.imaginaryValue * b.realValue;

			return ComplexNumber (newRealValue, newImaginaryValue);
		}
		//Divides a by b
		static	ComplexNumber Divide(ComplexNumber a, ComplexNumber b){
			
			//If both values are 0 Return 0 0 Complex Number and Print Error
			if(b.realValue == 0 && b.imaginaryValue == 0) {
				cout << endl << endl << "Division Failed: Cannot divide by 0!" << endl << endl;
				return ComplexNumber(0,0);
			}

			//If one Value is 0 divide by only the other value
			if(b.realValue == 0)      return ComplexNumber(a.imaginaryValue / b.imaginaryValue, - a.realValue / b.imaginaryValue );
			if(b.imaginaryValue == 0) return ComplexNumber(a.realValue/b.realValue, a.imaginaryValue/b.realValue);
				


			//Default Division
			float denominator =        b.realValue * b.realValue + b.imaginaryValue * b.imaginaryValue;
			float newRealValue =      (a.realValue * b.realValue + a.imaginaryValue * b.imaginaryValue) / denominator;
			float newImaginaryValue = (a.imaginaryValue * b.realValue - a.realValue * b.imaginaryValue) / denominator;

			return ComplexNumber (newRealValue, newImaginaryValue);
		}
};


int main() {

	//Get Initial Complex Values
	cout << "Please enter an initial Real Value:";
	float realVal;
	cin >> realVal;
	cout << "Please enter an initial Imaginary Value:";
	float imaginaryVal;
	cin >> imaginaryVal;
	ComplexNumber currentNum(realVal, imaginaryVal);	
	


	bool exit = false;
	string toPrint;
	while(!exit){
		currentNum.GetString(toPrint);
		toPrint = "Current Value = " + toPrint;
		cout << endl << toPrint << endl << endl;
		cout << "-----------------------------------------------------------------------"
			"\n(1) Add\n(2) Subtract\n(3) Multiply\n(4) Divide\n(0) Exit\n";
		int input;
		cin >>	input;
		switch(input){
			float realVal, imaginaryVal;
			case 1:
				cout << "--------------------Addition--------------------\n";

				cout << "Please enter a Real Value to add: ";
				cin >> realVal;
				cout << "Please enter an Imaginary Value to add: ";
				cin >> imaginaryVal;
				currentNum = ComplexNumber::Add(currentNum, ComplexNumber(realVal, imaginaryVal));
			break;
			case 2:
				cout << "--------------------Subtraction--------------------\n";


				cout << "Please enter a Real Value to subtract: ";
				cin >> realVal;
				cout << "Please enter an Imaginary Value to subtract: ";
				cin >> imaginaryVal;
				currentNum = ComplexNumber::Subtract(currentNum, ComplexNumber(realVal, imaginaryVal));
			break;
			case 3:
				cout << "--------------------Multiplication--------------------\n";


				cout << "Please enter a Real Value to multiply: ";
				cin >> realVal;
				cout << "Please enter an Imaginary Value to multiply: ";
				cin >> imaginaryVal;
				currentNum = ComplexNumber::Multiply(currentNum, ComplexNumber(realVal, imaginaryVal));
			break;
			case 4:
				cout << "--------------------Division--------------------\n";
				
				
				cout << "Please enter a Real Value to divide by: ";
				cin >> realVal;
				cout << "Please enter an Imaginary Value to divide by: ";
				cin >> imaginaryVal;
				currentNum = ComplexNumber::Divide(currentNum, ComplexNumber(realVal, imaginaryVal));
			break;
			default:
				cout << "--------------------EXITED HOPE YOU ENJOYED YOUR STAY--------------------\n";
			exit = true;
			break;
		}
	}

	return 0;
}

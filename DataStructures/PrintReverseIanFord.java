//**********************************************
// Class:		    Data Structures 03
// Term:		    Spring 2022
// Name:		    Ian Ford
// Program Number:	Assignment 1
// IDE: 		    Eclipse 
// JDK:             17
//**********************************************
import java.util.Scanner;
public class PrintReverseIanFord {
	
	
	public static void main(String[] args) {
		//Initializes variables
		boolean exit = false;
		String inputString = "";
		Scanner input = new Scanner(System.in);
		
		//Loop for new inputs until user chooses to exit
		while(!exit) {
			System.out.print("Enter string to be reversed: ");
			inputString = input.nextLine();
			System.out.print("Entered String:   " + inputString + "\nReversed string:  ");
			printCharsReverse(inputString);
			System.out.print("Try again (Y/N):  ");
			
			//Handles Exit Input if receive N end loop
			inputString = input.nextLine();
			if(!inputString.equalsIgnoreCase("y"))
				exit = true;
			System.out.println();
		}
		
		//Closes scanner and tells user that loop is over
		input.close();
		System.out.print("Loop Terminated.");
	}
	
	
	//Recursive method that prints string in reverse
	public static void printCharsReverse(String s) {
		if(s.length() == 1) {
			System.out.println(s);
			return;
		}
		System.out.print(s.substring(s.length()-1));
		printCharsReverse(s.substring(0,s.length()-1));
		return;
	}
}

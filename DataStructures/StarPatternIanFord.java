//**********************************************
// Class:		    Data Structures 03
// Term:		    Spring 2022
// Name:		    Ian Ford
// Program Number:	Assignment 1
// IDE: 		    Eclipse 
// JDK:             17
//**********************************************
import java.util.Scanner;

public class StarPatternIanFord {

	public static void main(String[] args) {
		//Initializes variables
		boolean exit = false;
		String inputString = "";
		Scanner input = new Scanner(System.in);
		
		//Loop for new inputs until user chooses to exit
		while(!exit) {
			System.out.print("Enter Number of Rows: ");
			
			//Gets number input for rows retries if bad input then prints stars
			while(!exit) {
				inputString = input.nextLine();
				if(intTryParse(inputString) != 0)
					exit = true;
				else
					System.out.println("Invalid Input.\nEnter Number of Rows: ");
			}
			exit=false;
			printStars(intTryParse(inputString));
			
			//Handles Exit Input if receive N end loop
			System.out.print("Try again (Y/N):  ");

			inputString = input.nextLine();
			if(!inputString.equalsIgnoreCase("y"))
				exit = true;
			System.out.println();
		}
		
		//Closes scanner and tells user that loop is over
		input.close();
		System.out.print("Loop Terminated.");
	}
	
	//Helper recursive method
	public static void printStars(int rows, int stars, int spaces, int lastStars) {
		if(rows < 1)
			return;
		else if(spaces > 0 ) {
			System.out.print(" ");
			printStars(rows, stars, spaces-1, lastStars);
		}
		else if (spaces == 0) {
			System.out.print("*");
			printStars(rows, stars, spaces - 1, lastStars);
		}
		else if(stars > 0) {
			System.out.print("**");
			printStars(rows, stars-1, spaces, lastStars);
		}
		else{
			//if no stars left start new row
			System.out.println();
			printStars(--rows, lastStars + 1, rows - 1, lastStars + 1);
		}
	}
	
	//Recursive method that prints a row of stars per call
	public static void printStars(int rows) {
			printStars(rows, 0, rows-1, 0);
	}
	
	//Method that tries to parse input returning 0 if it cant be parsed
	public static int intTryParse(String input) {
		try {
			return Integer.parseInt(input);
		}
		catch(Exception e){
			return 0;
		}
	}
}

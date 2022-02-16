//**********************************************
// Class:		    Data Structures 03
// Term:		    Spring 2022
// Name:		    Ian Ford
// Program Number:	Assignment 1
// IDE: 		    Eclipse 
// JDK:             17
//**********************************************
import java.util.Arrays;
import java.util.Scanner;

public class AverageGradeIanFord {
	
	public static void main(String[] args) {
		//Initializes variables
		boolean exit = false;
		int classSize = 0, grade;
		int[] grades;
		String inputString = "";
		Scanner input = new Scanner(System.in);
		while(exit == false) {
			//Gets class size from user handles bad inputs
			do {
				System.out.print("Enter Class Size: ");
				inputString = input.nextLine();
				classSize = intTryParse(inputString);
				
				//asks for new input if class size is <1 or if given non-int input
				exit = true;
				if(classSize < 1) {
					exit = false;
					System.out.println("Invalid Input.\n");
				}
			}while(exit == false);
			grades = new int[classSize];
		
			//Loop for grade inputs
			for(int i = 0; i < classSize; i++) {
				System.out.print("Enter Next Grade: ");
				do {
					inputString = input.nextLine();
					grade = intTryParse(inputString);
					
					//asks for new input if class size is <1 or if given non-int input
					exit = true;
					if(grade < 0 || grade > 100) {
						exit = false;
						System.out.print("Invalid Input.\nEnter A Grade: ");
					}
				}while(exit == false);
				grades[i] = grade;
			}
			exit = false;
			System.out.println();
			
			//Prints outputs and calls recursive average method
			System.out.print("Class Size:      " + classSize+"\nEntered Grades:  ");
			for(int num : grades) {
				System.out.print(num+" ");
			}                                                   //rounds to nearest 100th
			System.out.print("\nClass Average:   "+ Math.round(findAverage(grades)*100)/(float)100+"\n");
			
			//Handles Exit Input if receive N end loop
			System.out.print("Try again (Y/N):  ");
			inputString = input.nextLine();
			if(!inputString.equalsIgnoreCase("y"))
				exit = true;
			System.out.println("\n");
		}
		//Closes scanner and tells user that loop is over
		input.close();
		System.out.print("Loop Terminated.");
	}
	
	
	//Recursive method that prints string in reverse
	public static float findAverage(int[] grades) {
		if(grades.length <= 1)
			return grades[0];
		return (findAverage(Arrays.copyOfRange(grades,0,grades.length-1)) * (grades.length-1) + grades[grades.length-1]) / grades.length;
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

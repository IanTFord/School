// Class:		    Data Structures 03
// Term:		    Spring 2022
// Name:		    Ian Ford
// Program Number:	Assignment 3
// IDE: 		    IntelliJ
// JDK:             17
//////////////////////////////////////
import java.util.Scanner;
public class TestStackIanFord {
    public static void main(String[]args){
        MyStackIanFord<String> stack = new MyStackIanFord();

        //Make Testing Loop
        Scanner in = new Scanner(System.in);
        boolean exit = false;
        boolean isGoodInput = false;
        while(!exit){
            //Print Menu
            System.out.print("\n-----MAIN MENU-----\n0 - Exit Program\n1 - Push\n2 - Pop\n3 - Peek\n4 - Size\n5 - isEmpty?\n6 - Print Stack\nEnter Action: ");
            int i = 0;
            while(!isGoodInput){
                try{
                    i = in.nextInt();
                    if(i < 7 && i >= 0)
                        isGoodInput = true;
                    else{
                        //purge input
                        in.nextLine();
                        System.out.println("\nBAD INPUT\nEnter an unsigned Integer 0-6: ");
                    }
                }
                catch(Exception e){
                    //purge input
                    in.nextLine();
                    System.out.println("\nBAD INPUT\nEnter an unsigned Integer 0-6: ");
                }
            }
            isGoodInput = false;

            //Switch statement for different inputs
            switch (i){
                case 0:
                    exit = true;
                    System.out.println("\nGOODNIGHT");
                    break;
                case 1:
                    System.out.print("\nEnter element to Push: ");
                    in.nextLine();
                    stack.push(in.nextLine());
                    break;
                case 2:
                    System.out.println("\n");
                    System.out.println(stack.pop()+" removed from the stack!");
                    break;
                case 3:
                    System.out.println("\n");
                    System.out.println("Top element is: "+stack.peek());
                    break;
                case 4:
                    System.out.println("\nSize is: "+stack.size());
                    break;
                case 5:
                    System.out.println("\nStack is empty?: "+stack.isEmpty());
                    break;
                case 6:
                    System.out.println("\nElements are: "+stack.toString());
                    break;
            }
        }
    }
}

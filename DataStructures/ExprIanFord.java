// Class:		    Data Structures 03
// Term:		    Spring 2022
// Name:		    Ian Ford
// Program Number:	Assignment 3
// IDE: 		    IntelliJ
// JDK:             17
//////////////////////////////////////
import java.util.HashMap;
import java.util.Scanner;
public class ExprIanFord {

    public static void main(String[]args){
        //Initialize variables
        Scanner in = new Scanner(System.in);

        //Run postfix loop
        boolean exit = false;
        while(!exit) {
            System.out.print("Input infix expression: ");
            try {
                String postfix = infixToPostfix(in.nextLine());
                System.out.print("Postfix expression: " + postfix + "\nResult Value: " + postFixEval(postfix) + "\n\nDo you want to continue?(Y/N): ");
                exit = !in.nextLine().equalsIgnoreCase("Y");
                System.out.println();
            } catch (Exception e) {
                System.out.print("\nBAD INPUT\n\n");
            }
        }

        System.out.print("GOODNIGHT");
    }

    public static String infixToPostfix(String infix){
        //Evaluates infix string to a postfix string
        //Declare Variables
        HashMap<String, Integer> weights = new HashMap<>();
        weights.put("+", 0);
        weights.put("-", 0);
        weights.put("*", 1);
        weights.put("/", 1);
        weights.put("^", 2);
        MyStackIanFord<String> stack = new MyStackIanFord<>();
        String postfix = "", next;

        //Parse through string adding operators to stack and operands to string
        while(infix.length() > 0){
            next = infix.substring(0,1);
            if(tryParse(next)){
                postfix += next;
            }
            else if (next.equals(")")){
                while(!stack.peek().equals("("))
                    postfix += stack.pop();
                stack.pop();
            }
            else if(next.equals("("))
                stack.push(next);
            else {
                while(!stack.isEmpty() && !stack.peek().equals("(") && weights.get(next) <= weights.get(stack.peek()))
                    postfix += stack.pop();
                stack.push(next);
            }
            infix = infix.substring(1);
        }

        //After Infix is empty append all operator from stack to postfix
        while(!stack.isEmpty())
            postfix += stack.pop();

        return postfix;
    }

    public static double postFixEval(String postfix){
        //Evaluates a postfix string to a single double
        //Assign variable
        double num1, num2;
        MyStackIanFord<String> stack = new MyStackIanFord<>();

        //Evaluate nums until string is empty
        while(postfix.length() > 0){
            String next = postfix.substring(0,1);
            if(tryParse(next)){
                stack.push(next);
            }
            else{
                num2 = Double.parseDouble(stack.pop());
                num1 = Double.parseDouble(stack.pop());
                stack.push(String.valueOf(evalOperator(num1,num2,next)));
            }
            postfix = postfix.substring(1);
        }
        return Double.parseDouble(stack.pop());
    }

    public static double evalOperator(double num1, double num2, String op){
        //Evaluate the result of two nums and an operator
        switch (op){
            case "*":
                return num1 * num2;
            case "/":
                return num1 / num2;
            case "+":
                return num1 + num2;
            case "-":
                return num1 - num2;
            case "^":
                return Math.pow(num1,num2);
        }
        return 0.0;
    }

    public static boolean tryParse(String toParse){
        //Returns true if input is Integer
        try{
            Integer.parseInt(toParse);
            return true;
        }
        catch(Exception e){
            return false;
        }

    }
}

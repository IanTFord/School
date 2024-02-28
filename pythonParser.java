// Name: Chris Freel & Ian Ford
// Class: CS 4308/Section 2
// Term: Fall 2023
// Instructor: Professor Abraham
// Assignment: Semester Project
// IDE Name: Eclipse

import java.io.File;
import java.util.ArrayList;

public class pythonParser {

    public static void main (String[] args){
        ArrayList<String> tokens = pythonLexer.simpleLexAnalysis(new File("testFile.py"));
        parseTokens(tokens);
    }

    //Parses token and prints a message based on the outcome of the parsing. Prints:
    //--Sucess
    //--Or some error message
    public static void parseTokens(ArrayList<String> tokens){
        //Recursive Descent parsing here
        //Make a method for each non terminal in the grammar
        //Grammer is already right recursive
        System.out.println(ifStatement(tokens));
    }

    static String ifStatement(ArrayList<String> tokens){

        if(!tokens.get(0).equals("IF")) return getError("If", tokens.get(0));
        tokens.remove(0);

        String errorMessage = conditionalStatement(tokens);
        if(!errorMessage.equals("SUCCESS")) return errorMessage;

        if(!tokens.get(0).equals("COLON")) return getError("Colon", tokens.get(0));
        tokens.remove(0);

        errorMessage = statementBlock(tokens);
        if(!errorMessage.equals("SUCCESS")) return errorMessage;

        //Decide on next component
        //--Elif
        //--Else
        //--EOF
        if(tokens.size() == 0) return "SUCCESS";
        else if(tokens.get(0).equals("ELIF")){
            errorMessage = elifStatement(tokens);
            if(!errorMessage.equals("SUCCESS")) return errorMessage;
            return "SUCCESS";
        }
        else if(tokens.get(0).equals("ELSE")){
            errorMessage = elseStatement(tokens);
            if(!errorMessage.equals("SUCCESS")) return errorMessage;
            return "SUCCESS";
        }
        else{
            return getError("else, elif, or EOF", tokens.get(0));
        }
    }
    static String conditionalStatement(ArrayList<String> tokens){
        if(!tokens.get(0).equals("IDENTIFIER") && !tokens.get(0).equals("LITERAL")) return getError("Literal or Identifier", tokens.get(0));
        tokens.remove(0);
        if(!tokens.get(0).equals("COMPARE_OPERATOR")) return getError("Comparison Operator", tokens.get(0));
        tokens.remove(0);
        if(!tokens.get(0).equals("IDENTIFIER") && !tokens.get(0).equals("LITERAL")) return getError("Literal or Identifier", tokens.get(0));
        tokens.remove(0);

        return "SUCCESS";
    }
    static String elifStatement(ArrayList<String> tokens){
        if(!tokens.get(0).equals("ELIF")) return getError("elif", tokens.get(0));
        tokens.remove(0);

        String errorMessage = conditionalStatement(tokens);
        if(!errorMessage.equals("SUCCESS")) return errorMessage;

        if(!tokens.get(0).equals("COLON")) return getError("Colon", tokens.get(0));
        tokens.remove(0);

        errorMessage = statementBlock(tokens);
        if(!errorMessage.equals("SUCCESS")) return errorMessage;

        //Decide on next component
        //--Elif
        //--Else
        //--EOF
        if(tokens.size() == 0) return "SUCCESS";
        else if(tokens.get(0).equals("ELIF")){
            errorMessage = elifStatement(tokens);
            if(!errorMessage.equals("SUCCESS")) return errorMessage;
            return "SUCCESS";
        }
        else if(tokens.get(0).equals("ELSE")){
            errorMessage = elseStatement(tokens);
            if(!errorMessage.equals("SUCCESS")) return errorMessage;
            return "SUCCESS";
        }
        else{
            return getError("else, elif, or EOF", tokens.get(0));
        }
    }
    static String elseStatement(ArrayList<String> tokens){
        if(!tokens.get(0).equals("ELSE")) return "SUCCESS";
        tokens.remove(0);

        if(!tokens.get(0).equals("COLON")) return getError("Colon", tokens.get(0));
        tokens.remove(0);

        String errorMessage = statementBlock(tokens);
        if(errorMessage != "SUCCESS") return errorMessage;

        return "SUCCESS";
    }
    static String statementBlock(ArrayList<String> tokens){
        //If expecting statement blokc and dont find other
        if(tokens.get(0).equals("IF") || tokens.get(0).equals("ELIF") || tokens.get(0).equals("ELSE") || tokens.get(0).equals("COLON")) return getError("Statement Block", tokens.get(0));

        //Remove all consecutive OTHER tokens then return success
        while(tokens.size() > 0 && !tokens.get(0).equals("IF") && !tokens.get(0).equals("ELIF") && !tokens.get(0).equals("ELSE") && !tokens.get(0).equals("COLON")){
            tokens.remove(0);
        }
        return "SUCCESS";
    }

    static String getError(String expected, String found) { return "Syntax Error: Expected \"" + expected + "\", but found: \"" + found + "\"";}
}
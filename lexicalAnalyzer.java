// Name: Chris Freel & Ian Ford
// Class: CS 4308/Section 2
// Term: Fall 2023
// Instructor: Professor Abraham
// Assignment: Semester Project
// IDE Name: Eclipse

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;
import java.util.*;

public class lexicalAnalyzer {

	//defining global variables
	static String charClass;
	static String lexeme = "";
	static char nextChar;
	static String lexemeClass;
	static ArrayList<String> lexemes = new ArrayList<String>();
	static String fileType;

	//defining keywords list
	static ArrayList<String> keywords = new ArrayList<String>(Arrays.asList(
			"public",
			"class",
			"static",
			"void",
			"int",
			"String",
			"def",
			"print"
			));


	//gets a lexeme's class
	static void getLexemeClass(String s) {

		if(keywords.contains(s)){
			System.out.format("\nLexeme: %-15s Token Class: Keyword", s);
		}

		else if(Character.isDigit(s.charAt(0))) {
			System.out.format("\nLexeme: %-15s Token Class: Int_Literal", s);
		}

		else if(s.charAt(0) == '"' || s.charAt(0) == '\'') {
			System.out.format("\nLexeme: %-15s Token Class: Str_Literal", s);
		}

		else if(s.charAt(0) == '=') {
			System.out.format("\nLexeme: %-15s Token Class: Ass_Op", s);
		}

		else if(s.charAt(0) == '+') {
			System.out.format("\nLexeme: %-15s Token Class: Add_Op", s);
		}

		else if(s.charAt(0) == '(') {
			System.out.format("\nLexeme: %-15s Token Class: Left_Paren", s);
		}

		else if(s.charAt(0) == ')') {
			System.out.format("\nLexeme: %-15s Token Class: Right_Paren", s);
		}

		else if(s.charAt(0) == ':') {
			System.out.format("\nLexeme: %-15s Token Class: Colon", s);
		}

		else if(s.charAt(0) == ';') {
			System.out.format("\nLexeme: %-15s Token Class: Semicolon", s);
		}

		else if(s.charAt(0) == '{') {
			System.out.format("\nLexeme: %-15s Token Class: Left_Brace", s);
		}

		else if(s.charAt(0) == '}') {
			System.out.format("\nLexeme: %-15s Token Class: Right_Brace", s);
		}

		else if(s.charAt(0) == '[') {
			System.out.format("\nLexeme: %-15s Token Class: Left_Bracket", s);
		}

		else if(s.charAt(0) == ']') {
			System.out.format("\nLexeme: %-15s Token Class: Right_Bracket", s);
		}

		else if(s.charAt(0) == ',') {
			System.out.format("\nLexeme: %-15s Token Class: Comma", s);
		}

		else if(s == "\\n") {
			System.out.format("\nLexeme: %-15s Token Class: Newline", s);
		}

		else if(s == "\\t") {
			System.out.format("\nLexeme: %-15s Token Class: Tab", s);
		}

		else {
			System.out.format("\nLexeme: %-15s Token Class: Identifier", s);
		}
	}

	//builds the lexeme character by character
	static void buildLexeme(char c) {
		if (lexeme == "") {
			if (charClass == "DIGIT") {
				lexemeClass = "INT_LITERAL";
			}
			else if(charClass == "LETTER") {
				lexemeClass = "IDENTIFIER";
			}
			else if (c == '"' || c == '\''){
				lexemeClass = "STRING_LITERAL";
				lexeme += c;
				return;
			}
			else {
				lexemeClass = "PUNCTUATION";
				lexeme = "";
				if (c == ' ' || c == '\t') {
					return;
				}
			}
		}


		if(charClass == "NEWLINE") {
			if(lexeme != "")lexemes.add(lexeme);
			lexemes.add("\\n");
			lexeme = "";
			lexemes.add("\\t");
			lexeme = "";
		}
		else if (charClass != "UNKNOWN"){
			lexeme += c;	
		}
		else if (lexemeClass != "STRING_LITERAL"){
			if(lexeme != "") {
				lexemes.add(lexeme);
			}

			lexeme = "";
			if (c != ' ') {
				lexeme += c;
				if(lexeme != "") {
					lexemes.add(lexeme);
				}
				lexeme = "";
			}

		}
		else if (lexemeClass == "STRING_LITERAL"){
			lexeme += c;
			if(c == '"' || c == '\'') {
				lexemes.add(lexeme);
				lexeme = "";
			}
		}
		else {
			if(lexeme != "") {
				lexemes.add(lexeme);
			}
			lexeme = "";
		}

	}

	//gets the char class of a character
	static void getCharClass(char c) {
		if(Character.isDigit(c)) {
			charClass = "INTEGER";
		}
		else if(Character.isAlphabetic(c) || c =='_') {
			charClass = "LETTER";
		}
		else if(c == '\n') {
			charClass = "NEWLINE";
		}
		else {
			charClass = "UNKNOWN";
		}
	}

	//runs lexical analysis on input file
	public static void lexAnalyzer(File inputProgram){
		if (inputProgram.getName().contains("java")) {
			fileType = "Java";
		}
		else {
			fileType = "Python";
		}


		try {
			Scanner fileScanner = new Scanner(inputProgram);
			while(fileScanner.hasNextLine()) {
				String line = fileScanner.nextLine();
				if(fileType == "Python") {
					line = line + "\n";
				}
				for(char c : line.toCharArray()) {
					getCharClass(c);
					buildLexeme(c);
				}

			}

			
			for(String s : lexemes){
				getLexemeClass(s);
			}
			
			lexemes.clear();
			
			fileScanner.close();

		} 
		catch (FileNotFoundException e) {
			e.printStackTrace();
		}
	}

	//calls lexical analysis for both files
	public static void main (String[] args){


		File javaProgram = new File("testFile.java");
		System.out.println("Lexically Analyzing testfile.java: ");
		lexAnalyzer(javaProgram);

		System.out.println("\n\n\n");
		File pythonProgram = new File("testFile.py");
		System.out.println("Lexically Analyzing testfile.py: ");
		lexAnalyzer(pythonProgram);

	}

}


// Name: Chris Freel & Ian Ford
// Class: CS 4308/Section 2
// Term: Fall 2023
// Instructor: Professor Abraham
// Assignment: Semester Project
// IDE Name: Eclipse
// Desc: A simple version of our original lexer for python parsing

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;
import java.util.*;

public class pythonLexer {

	//defining global variables
	static String lastCharClass;
	static String charClass;
	static String lexeme = "";
	static char nextChar;
	static String lexemeClass;
	static ArrayList<String> lexemes = new ArrayList<String>();
	static ArrayList<String> tokens = new ArrayList<String>();

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
	static String getLexemeClass(String s) {

		if(keywords.contains(s)) return "KEYWORD";
		if(Character.isDigit(s.charAt(0)) || s.charAt(0) == '\'' || s.charAt(0) == '"') return "LITERAL";
		else if(s.equals("(") || s.equals(")") || s.equals("=")) return "PUNCTUATION";
		else if(s.equals("if")) return "IF";
		else if(s.equals("elif")) return "ELIF";
		else if(s.equals("else")) return "ELSE";
		else if(s.equals(":")) return "COLON";
		else if(s.equals(">") || s.equals("!=") || s.equals(">=") || s.equals("<") || s.equals("<=") || s.equals("==")) return "COMPARE_OPERATOR";
		else return "IDENTIFIER";
	}

	//builds the lexeme character by character
	static void buildLexeme(char c) {

		//Lexeme is empty logic
		//--Always returns
		if (lexeme == "") {
			if(c == ' ') return;
			else if (charClass == "DIGIT") {
				lexemeClass = "INT_LITERAL";
				lexeme += c;
			}
			else if(charClass == "LETTER") {
				lexemeClass = "IDENTIFIER";
				lexeme += c;
			}
			else if (c == '"' || c == '\''){
				lexemeClass = "STRING_LITERAL";
				lexeme += c;
			}
			else if(charClass == "PUNCTUATION"){
				lexemes.add(Character.toString(c));
			}
			else{
				lexemeClass = "";
				lexeme += c;
			}
			return;
		}

		//Lexeme Not Empty logic
		if (lexemeClass == "STRING_LITERAL"){
			lexeme += c;
			if(c == '"' || c == '\'') {
				lexemes.add(lexeme);
				lexeme = "";
			}
		}
		else if (charClass == "UNKNOWN" || charClass == "PUNCTUATION"){
			
			lexemes.add(lexeme);
			lexeme = "";

			if (c != ' ') {
				lexemes.add(Character.toString(c));
			}

		}
		else{
			lexeme += c;	
		}
	}

	//gets the char class of a character
	static String getCharClass(char c) {
		if(Character.isDigit(c)) return "INTEGER";
		else if(Character.isAlphabetic(c) || c =='_') return "LETTER";
		else if(c == '>' || c =='<'|| c =='!'|| c =='='|| c =='+'|| c =='-'|| c =='/'|| c =='*') return "OPERATOR";
		else if (c== '(' || c==')') return "PUNCTUATION";
		else return "UNKNOWN";
	}

	//Performs Simple Lex analysis on a file,
	//--Gets all lexemes
	//--Compacts series of lexemes into statement blocks
	//--Upon finding: (':' 'if' 'elif' 'else') completes a block
	public static ArrayList<String> simpleLexAnalysis(File inputProgram){
		try {
			Scanner fileScanner = new Scanner(inputProgram);
			while(fileScanner.hasNextLine()) {
				String line = fileScanner.nextLine();
				for(char c : line.toCharArray()) {
					lastCharClass = charClass;
					charClass = getCharClass(c);
					buildLexeme(c);
				}
			}
			if(lexeme != "") lexemes.add(lexeme);//Flush last lexeme


			
			for(int i = 0; i < lexemes.size(); i++){
				tokens.add(getLexemeClass(lexemes.get(i)));
				System.out.format("Lexeme: %-15s Token Class: %s\n", lexemes.get(i), tokens.get(i));
			}
			
			lexemes.clear();
			fileScanner.close();

			return tokens;
		} 
		catch (FileNotFoundException e) {
			System.out.println("Lex analysis failed: HAHAHHA");
			return null;
		}
	}

	//calls lexical analysis for both files
	public static void main (String[] args){

		File pythonProgram = new File("testFile.py");
		simpleLexAnalysis(pythonProgram);

	}

}


/*
 * Name: Ian
 *
 * Proj: Basic Lexical Analyzer
 *
 * Date: 9/20/23
 *
 * Desc: Perform Lexical Analysis on the sample Java/Python code.
 *    Returns a table of Lexemes and their respective Tokens.
 */

#include <stdio.h>
#include <stdlib.h>
#include <memory.h>
#include <ctype.h>
#include <time.h>

//Languages
#define JAVA 1
#define PYTHON 2

//Char Classifications
#define TERMINATOR 50
#define SPACE 51
#define ALPHA 52
#define DIGIT 53
#define QUOTE 54
//Returns the Char Class of the passed in char
int GetCharClass(char c){
	if(isalpha(c) || c == '_') return ALPHA;
	if(isdigit(c)) return DIGIT; 	
	if(c == ' ')    return SPACE;
	if(c == '"' || c =='\'')    return QUOTE;
	return TERMINATOR;
}


//Tokens
#define IDENTIFIER 100
#define STRINGLITERAL 101
#define NUMBER 102
#define PUBLIC_KW 103
#define CLASS_KW 104
#define STATIC_KW 105
#define VOID_KW 106
#define LPARENTHESES 107
#define RPARENTHESES 108
#define COMMA 109
#define SEMICOLON 110
#define PERIOD 111
#define EQUAL_OP 112
#define PLUS_OP 113
#define LBRACKET 114
#define RBRACKET 115
#define LCURLYBRACE 116
#define RCURLYBRACE 117 
#define TAB 118
#define NEWLINE 119
#define COLON 120
#define CHARLITERAL 121
#define INTLITERAL 122
#define FLOATLITERAL 123
#define COMMENT 124

//Returns the lexemes token
int GetToken(char lexeme[]){
	if(strcmp(lexeme, "public") == 0) return PUBLIC_KW;
	if(strcmp(lexeme, "class") == 0)  return CLASS_KW;
	if(strcmp(lexeme, "static") == 0) return STATIC_KW;
	if(strcmp(lexeme, "void") == 0)   return VOID_KW;
	if(strcmp(lexeme, "    ") == 0) return TAB;
	if(strchr(lexeme, '.') != NULL && isdigit(lexeme[0])) return FLOATLITERAL;
	if(isdigit(lexeme[0])) return INTLITERAL;
	if(isalpha(lexeme[0])) return IDENTIFIER;
	if(lexeme[0] == '"' || lexeme[0] == '\'') return STRINGLITERAL;
	if(lexeme[0] == '(') return LPARENTHESES;
	if(lexeme[0] == ')') return RPARENTHESES;
	if(lexeme[0] == ',') return COMMA;
	if(lexeme[0] == ';') return SEMICOLON;
	if(lexeme[0] == '.') return PERIOD;
	if(lexeme[0] == '=') return EQUAL_OP;
	if(lexeme[0] == '+') return PLUS_OP;
	if(lexeme[0] == '[') return LBRACKET;
	if(lexeme[0] == ']') return RBRACKET;
	if(lexeme[0] == '{') return LCURLYBRACE;
	if(lexeme[0] == '}') return RCURLYBRACE;
	if(lexeme[0] == ' ') return TAB;
	if(lexeme[0] == '\n') return NEWLINE;
	if(lexeme[0] == ':') return COLON;
	if(lexeme[0] == '\'') return CHARLITERAL;
	if(lexeme[0] == '/' || lexeme[0] == '#') return COMMENT;

	printf("LEXER FAILED: No token found for: %s", lexeme);
}

int GetTokenOfChar(char lexeme){
	char currentChar[2];
	currentChar[0] = lexeme;
	currentChar[1] = '\0';
	return GetToken(currentChar);			
}
//Returns the token as a string
char* GetTokenString(int token){
	switch(token){
		case PUBLIC_KW: return "PUBLIC_KW";
		case CLASS_KW: return "CLASS_KW";
		case STATIC_KW: return "STATIC_KW";
		case VOID_KW: return "VOID_KW";
		case NUMBER: return "NUMBER";
		case IDENTIFIER: return "IDENTIFIER";
		case STRINGLITERAL: return "STRINGLITERAL";
		case LPARENTHESES: return "LPARENTHESES";
		case RPARENTHESES: return "RPARENTHESES";
		case COMMA: return "COMMA";
		case SEMICOLON: return "SEMICOLON";
		case PERIOD: return "PERIOD";
		case EQUAL_OP: return "EQUAL_OP";
		case PLUS_OP: return "PLUS_OP";
		case LBRACKET: return "LBRACKET";
		case RBRACKET: return "RBRACKET";
		case LCURLYBRACE: return "LCURLYBRACE";
		case RCURLYBRACE: return "RCURLYBRACE";
		case TAB: return "TAB";
		case NEWLINE: return "NEWLINE";
		case COLON: return "COLON";
		case CHARLITERAL: return "CHARLITERAL";
		case FLOATLITERAL: return "FLOATLITERAL";
		case INTLITERAL: return "INTLITERAL";
		case COMMENT: return "COMMENT";

		default: return "NO VALID TOKEN";
	}
}




//___________________________HELPER FUNCTIONS_____________________________//
//Appends a char to a str* str* must have allocated space for append
void appendchar(char *str, char c){
	int endOfStr = 0;
	while(str[endOfStr] != '\0') endOfStr++;

	str[endOfStr] = c;
	str[endOfStr+1] = '\0';
}
//Get str length
int strlength(char * str){
	int count = 0;
	while(str[count] != '\0')
		count ++;
	return count;
}
void printbar(){ printf("|--------------------------------------------------|\n"); }
//Returns the file extension ex: test.py --> py
char* getextension(char* fileName){
	
	//Cache period index
	int periodIndex = -1;
	for(int i = strlength(fileName)-1; i > 0; i--)
		if(fileName[i] == '.'){
			periodIndex = i;
			break;
		}
	if(periodIndex == -1) printf("\n\nError: Period not found!\n\n\n");	


	//Append chars after period            +1 for null terminator
	char* extension = malloc(strlength(fileName)-periodIndex);	
	for(int i = periodIndex+1; i < strlength(fileName); i++)
		extension[i-(periodIndex + 1)] = fileName[i];
	extension[strlength(extension)-1] = '\0'; //Append


	return extension;
}
//Converts a string to upper
void strToUpper(char* str){
	for(int i = 0; str[i] != '\0'; i++)
		str[i] = str[i]-32;
}



int main(){
	printf("------------------------Lexical Analyzer------------------------\n"
			"This is a Simple Lexical Analyzer capable of analyzing a simple java and python script\n"
		       	"Please enter the path of the file you would like to perform Lexical Analysis on: ");

	//GetPath to file User wants Analyzed
	char path[100];
	scanf("%s", path);
	clock_t start = clock();
	int pathLength = strlength(path);

	//Check that file !Null
	FILE* programFile = fopen(path, "rb");
	if(programFile == NULL) {
		printf("\n\nLEXING FAILED: File not found!\n\n");
		return 0;
	}

	//Get Extension
	char* extension = getextension(path);
	strToUpper(extension);
	printf("\n\nDetected %s Program in %s\n\n", extension, path);


	//Read file into a single string
 
	long length;

	fseek(programFile, 0, SEEK_END);
	length = ftell(programFile);
	fseek(programFile, 0, SEEK_SET);
	char* rawProgram = malloc( length+1);
	fread(rawProgram, 1, length, programFile);
	rawProgram[length] = '\0';
	fclose(programFile);
	
	printf("File Length: %d\n",length);
	printf("String Length: %d\n\n",strlen(rawProgram));
	printf("Raw Program:\n%s \n\n", rawProgram);



	//Lexical Analysis
	printf("Starting Lexical Analysis...\n");
	int isStringLiteral = 0;
	int lexemeCount = 0;
	char lexeme[100] = {0}; //Lexemes may contain 100 chars
	char lexemes[1000][100] = {0}; //May have 100 Lexemes
	int   tokens[1000] = {0}; //One token for each lexeme
	int programLength = strlen(rawProgram);
	int currentLine = 0;
	int currentColumn = 0;
	int token = -1;		//Current Lexemes Token


       	//Flushes Current Lexeme into lexemes
	void flush(){		
		//printf("Flushing [%s]: %s\n", lexeme, lexeme[0] == '\0' ? " Failed" : "Success");
		if(lexeme[0] == '\0') return;
		strcpy(lexemes[lexemeCount], lexeme);
		tokens[lexemeCount] = GetToken(lexeme);

		//Wipe Token and Lexeme
		token = -1;
		lexeme[0] = '\0'; //Place null terminator as first element
		lexemeCount ++;
	} 
	
	
	//LEXER LOOP
	for(int i = 0; i < programLength; i++){
		currentColumn ++;
		int charClass = GetCharClass(rawProgram[i]);
		

		//If current Lexeme is empty set expected token
		if(lexeme[0] == '\0') 
			token = GetTokenOfChar(rawProgram[i]);
		

		/* HANDLE TOKEN */
		//COMMENT HANDLING
		if(token == COMMENT && rawProgram[i] != '\n'){
			continue;
		}
		//TAB Handling
		if(token == TAB && strcmp(extension, "PY") == 0){
			if(rawProgram[i] != ' '){
				lexeme[0] = '\0';
				token = GetTokenOfChar(rawProgram[i]);
			}
			else{
				appendchar(lexeme, rawProgram[i]);
				if(strlen(lexeme) == 4) flush();
				continue;
			}
		}
		//FLOAT HANDLING
		if(token == INTLITERAL && rawProgram[i] == '.'){
			if(rawProgram[i] == '.'){
				appendchar(lexeme, rawProgram[i]);
				token = FLOATLITERAL;
				continue;
			}
			else if(charClass != DIGIT){
				printf("\nLEXING FAILED: Invalid Lexeme at %s:%d:%s", path, currentLine, lexeme);
				return 0;
			}
		}
		if(token == FLOATLITERAL && charClass != DIGIT && charClass != TERMINATOR){
			printf("\nLEXING FAILED: Invalid Lexeme at %s:%d,%d:%s", path, currentLine,currentColumn, lexeme);
			return 0;	
		}
		//String Literal Handling
		//Append the char to current string literal
		//If char is QUOTE flush the lexeme
		if(token == STRINGLITERAL){
			appendchar(lexeme, rawProgram[i]);
			
			//End StringLiteral
			if(charClass == QUOTE && strlen(lexeme) > 1)
				flush();
			//Invalid Lexeme if at end of program with no closing "
			if(i+1 == programLength){
				printf("\nLEXING FAILED: Invalid Lexeme at %s:%d,%d:%s", path, currentLine,currentColumn, lexeme);
				return 0;
			}
			continue;
		}
		
		/* HANDLE CHAR CLASS */
		//Handle TERMINATOR, SPACE, QUOTE, and OTHERS
		if(charClass == TERMINATOR){
			flush();
			lexeme[0] = rawProgram[i];
			lexeme[1] = '\0';

			//Handle New Line Terminator
			if(lexeme[0] == '\n'){ 
				currentColumn = 0;
				currentLine++;
				if(strcmp(extension, "PY") != 0){
				lexeme[0] = '\0';
					continue;
				}
			} 

			flush();
		}
		else if(charClass == SPACE){
			flush();
		}
		else
			appendchar(lexeme, rawProgram[i]);
	}
	free(rawProgram);

	//Printing Results
	printf("Lexical Analysis Complete in: %fs\n", (double)(clock()-start)/CLOCKS_PER_SEC);
	printbar();
	printf("|%10sLEXEMES%9s%6sTOKENS%12s|\n", "", "|", "", "");
	printbar();
	for(int i = 0; i < 1000; i++){
		if(lexemes[i][0] == '\n') strcpy(lexemes[i], "\\n");
		if(lexemes[i][0] != '\0')
			printf("| Lexeme: %-15s | Token: %-15s |\n", lexemes[i], GetTokenString(tokens[i]));
	}
	printbar();
}

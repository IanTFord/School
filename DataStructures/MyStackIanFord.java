// Class:		    Data Structures 03
// Term:		    Spring 2022
// Name:		    Ian Ford
// Program Number:	Assignment 3
// IDE: 		    IntelliJ
// JDK:             17
//////////////////////////////////////
import java.util.*;
public class MyStackIanFord <E>{
    public LinkedList<E> ll;
    //Constructor
    public MyStackIanFord(){
        ll = new LinkedList();
    }


    public boolean isEmpty(){
        //Tries to get the first element of the list
        //if it fails return true
        try {
            ll.getFirst();
            return false;
        }
        catch (Exception e){
            return true;
        }
    }
    public int size(){
        return ll.size();
    }
    public String toString(){
        //Prints values with commas inbetween in brackets
        ListIterator<E> i = ll.listIterator();
        String s = "[";
        while(i.hasNext()){
            s += i.next();
            if(i.hasNext())
                s += ", ";
        }
        s+="]";
        return s;
    }
    public void push(E e){
        ll.add(e);
    }
    public E pop(){
        //Returns and removes last element unless stack is empty
        if(isEmpty()){
            System.out.println("Stack is Empty!");
            return null;
        }
        return ll.removeLast();

    }
    public E peek(){
        //Returns last element unless stack is empty
        if(isEmpty()){
            System.out.println("Stack is Empty!");
            return null;
        }
        return ll.getLast();
    }
}

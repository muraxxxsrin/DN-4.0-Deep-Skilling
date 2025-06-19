package SingletonPatternExample;

import java.util.*;
public class Main{
    public static void main(String [] args){
        Date date = new Date();
        Logger log1 = Logger.getInstance();
        Logger log2 = Logger.getInstance();
        int i=0;
        Scanner sc = new Scanner(System.in);
        System.out.println("Type exit to stop loggind!\t");
        while(true){
            i+=1;
            System.out.println("Enter a message: ");
            String message = sc.nextLine();
            if (i%2!=0){
                System.out.println("Using Logger 1:");
                log1.logs(message);
            }else{
                System.out.println("Using Logger 2:");
                log2.logs(message);
            }
            System.out.println("\t");

            if(message.equalsIgnoreCase("exit")){
                log1.logs("Existing utility class : "+date);
                break;
            }
        }
 
        
    }
}
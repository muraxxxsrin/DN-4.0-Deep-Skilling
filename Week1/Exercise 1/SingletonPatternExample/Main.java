
public class Main{
    public static void main(String [] args){
        Logger log1 = Logger.getInstance();
        Logger log2 = Logger.getInstance();

        log1.logs("Initial test");
        log2.logs("Secondary test");
        log2.logs("Final test");

        
    }
}
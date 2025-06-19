

public class Logger{
    private static Logger instance;
    private int i=0;
    private Logger(){
        
        System.out.println("Logging utility class is initialized");
    }

    public static Logger getInstance(){
        if(instance==null){
            instance=new Logger();
        }
        return instance;
    }

    public void logs(String message){
        i += 1;
        System.out.println("Log "+i+":"+message);

    }
}
import java.io.FileWriter;
import java.io.IOException;

public class HW2_2 {

    public static void main(String[] args) {

        try(FileWriter writer = new FileWriter("notes.txt", true))
        {
            // запись всей строки
            String text = "test ".repeat(100);;
            writer.write(text);

            writer.flush();
        }
        catch(IOException ex){

            System.out.println(ex.getMessage());
        }
    }

}

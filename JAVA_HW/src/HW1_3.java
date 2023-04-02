
import java.time.LocalDateTime;
import java.time.LocalTime;
import java.time.format.DateTimeFormatter;
import java.util.Scanner;

public class HW1_3 {
    public static void main(String[] args) {
        String date = LocalDateTime.now().format(DateTimeFormatter.ofPattern("HH"));
        Scanner in = new Scanner(System.in);
        System.out.print("name");
        String name = in.nextLine();

        int hour = Integer.parseInt(date);
        if (hour >= 5 && hour < 12) {
            System.out.print("Доброе утро " + name);
        }
        if (hour >= 12 && hour < 18) {
            System.out.print("Добрый день " + name);
        }
        if (hour >= 18 && hour < 23) {
            System.out.print("Добрый вечер " + name);
        }
        if (hour >= 23 || hour < 5) {
            System.out.print("Доброй ночи " + name);
        }

    }
}


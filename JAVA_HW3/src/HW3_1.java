import java.lang.reflect.Array;
import java.util.function.Function;

public class HW3_1 {
    public static void main(String[] args) {
        int[] loc = {25, 11, 250, 5, 21, 45, 75, 65, 24, 12};

        for (int i = 0; i != loc.length; i++) {
            if (loc[i] % 2 != 0)
                System.out.print(loc[i]+ " ");
        }
    }
}
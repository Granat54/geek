public class HW1_1 {
    public static void main(String[] args) {
    int[] loc = {25, 11, 250, 5, 21, 45, 75, 65, 24, 12};
    int max = loc[0];
    int min = loc[0];
    for (int i = 0; i != loc.length; i++) {
        if (loc[i] > max) {
            max = loc[i];
        }
        if (loc[i] < min) {
            min = loc[i];
        }
    }
    System.out.println(min + " - минимальное");
    System.out.println(max + " - максимальное");
}
}

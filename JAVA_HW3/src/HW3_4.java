import java.util.ArrayList;

public class HW3_4 {
    public static void main(String[] args) {
        ArrayList<String> list = new ArrayList<>();
        list.add("текст 1");
        list.add("текст 2");
        list.add("трывфа");
        list.add("11253");
        list.add("4346");
        list.add("7549");

        System.out.println("Исходный список: " + list);

        for (int i = 0; i < list.size(); i++) {
            String element = list.get(i);
            try {
                Integer.parseInt(element);
                list.remove(i);
                i--;
            }
            catch (NumberFormatException ignored) {
            }
        }

        System.out.println("Список после удаления целых чисел: " + list);
    }
}


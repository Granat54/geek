import java.util.Collections;
import java.util.LinkedList;

public class HW4_2 {

    public static void main(String[] args) {
        LinkedList<String> list = new LinkedList<String>();
        list.add("a");
        list.add("b");
        list.add("c");
        LinkedList<String> reversedList = reverseLinkedList(list);
        System.out.println(reversedList);
    }

    public static LinkedList reverseLinkedList(LinkedList list) {
        Collections.reverse(list);
        return list;
    }
}
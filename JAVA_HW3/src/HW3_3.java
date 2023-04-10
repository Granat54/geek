import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.Random;

public class HW3_3 {
    public static void main(String[] args)

    {
        List<String> planetsNames = List.of("Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptun", "Pluto");
        Random random = new Random();
        List<String> list = new ArrayList<>();

        for (int i = 0; i < 15; i++) {
            list.add(planetsNames.get(random.nextInt(9)));
        }


        list.sort(Comparator.naturalOrder());
        System.out.println(list);

        StringBuilder sb = new StringBuilder();
        int count = 1;
        for (int i = 0; i < list.size()-1; i++) {
            if (list.get(i).equals(list.get(i+1))) {
                count++;
            }else{
                sb.append(list.get(i))
                        .append(": ")
                        .append(count)
                        .append("; ");
                count = 1;
            }
        }
        sb.append(list.get(list.size() - 1)).append(": ").append(count).append(".");

        System.out.println(sb);

        StringBuilder sb2 = new StringBuilder();
        for (int i = 0; i < list.size()-1; i++) {
            if (list.get(i).equals(list.get(i + 1))) {
                list.remove(list.get(i));
                i--;
            }
        }
        System.out.println(list);
            }
    }




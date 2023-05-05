package ToyStore;

import java.util.ArrayList;
import java.util.List;
import java.util.Arrays;
public class Program {
    public static void main(String[] args) {

        Toy toy1 = new Toy(0, "Кукла", 20);
        Toy toy2 = new Toy(1, "Машинка", 40);
        Toy toy3 = new Toy(2, "Робот", 3);
        Toy toy4 = new Toy(3, "Матрёшка", 60);
        Toy toy5 = new Toy(4,"Игра",70);

        List<Toy> toys = new ArrayList<Toy>();

            toys.add(toy5);
            toys.add(toy4);
            toys.add(toy3);
            toys.add(toy2);
            toys.add(toy1);



        ToysStore toyStore = new ToysStore(toys);
        toyStore.saveToyForLottery();
        toyStore.saveToyForLottery();
        toyStore.saveToyForLottery();
        toyStore.saveToyForLottery();
        toyStore.saveToyForLottery();


    }

}

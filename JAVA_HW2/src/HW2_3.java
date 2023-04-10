import java.io.File;



public class HW2_3 {
        public static void main(String[] args) {


            File dir = new File("C://Users//white//Desktop//geek//JAVA_HW2//src");

            if(dir.isDirectory())
            {

                for(File item : dir.listFiles()){

                    if(item.isDirectory()){

                        System.out.println(item.getName() + "  \t folder");
                    }
                    else{

                        System.out.println(item.getName() + "\t file");
                    }
                }
            }
        }
    }
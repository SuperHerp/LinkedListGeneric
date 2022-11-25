using System;
namespace LL{
    class Program{

        public static int test_Append(){
            Schueler tmp = new Schueler(012, "simon", "01771727899");
            Schueler tmp1 = new Schueler(020, "luca", "01771727899");
            Schueler tmp2 = new Schueler(024, "janus", "01771727899");
            Schueler tmp3 = new Schueler(015, "marvin", "01771727899");
            Schueler tmp4 = new Schueler(026, "stefan", "01771727899");

            LinkedList<Schueler> test = new LinkedList<Schueler>(tmp);
            if (test.Data.compare(tmp) != 0){
                return -1;
            }

            test.append(tmp1);
            if (test.Next.Data.compare(tmp1) != 0){
                return -1;
            }

            test.append(tmp2);
            if (test.Next.Next.Data.compare(tmp2) != 0){
                return -1;
            }

            test.append(tmp3);
            if (test.Next.Next.Next.Data.compare(tmp3) != 0){
                return -1;
            }

            test.append(tmp4);
            if (test.Next.Next.Next.Next.Data.compare(tmp4) != 0){
                return -1;
            }

            return 1;
        }

        public static int test_Prepend(){
            Schueler tmp = new Schueler(012, "simon", "01771727899");
            Schueler tmp1 = new Schueler(020, "luca", "01771727899");
            Schueler tmp2 = new Schueler(024, "janus", "01771727899");
            Schueler tmp3 = new Schueler(015, "marvin", "01771727899");
            Schueler tmp4 = new Schueler(026, "stefan", "01771727899");

            LinkedList<Schueler> test = new LinkedList<Schueler>(tmp);

            test.prepend(tmp1);
            test = test.giveHead();
            if (test.Data.compare(tmp1) != 0){
                return -1;
            }else{
                if (test.Next.Data.compare(tmp) != 0){
                    return -1;
                }
            }

            test.prepend(tmp2);
            test = test.giveHead();
            if (test.Data.compare(tmp2) != 0){
                return -1;
            }else{
                if (test.Next.Data.compare(tmp1) != 0){
                    return -1;
                }
            }

            test.prepend(tmp3);
            test = test.giveHead();
            if (test.Data.compare(tmp3) != 0){
                return -1;
            }else{
                if (test.Next.Data.compare(tmp2) != 0){
                    return -1;
                }
            }

            test.prepend(tmp4);
            test = test.giveHead();
            if (test.Data.compare(tmp4) != 0){
                return -1;
            }else{
                if (test.Next.Data.compare(tmp3) != 0){
                    return -1;
                }
            }

            return 1;
        }

        public static int test_Search(){
            Schueler tmp = new Schueler(012, "simon", "01771727899");
            Schueler tmp1 = new Schueler(020, "luca", "01771727899");
            Schueler tmp2 = new Schueler(024, "janus", "01771727899");
            Schueler tmp3 = new Schueler(015, "marvin", "01771727899");
            Schueler tmp4 = new Schueler(026, "stefan", "01771727899");

            LinkedList<Schueler> test = new LinkedList<Schueler>(tmp);
            test.append(tmp1);
            test.append(tmp2);
            test.append(tmp3);
            test.append(tmp4);

            Schueler test3 = test.search(tmp3);

            if (test3.compare(tmp3) != 0){
                return -1;
            }

            return 1;
        }

        public static int test_Delete(){
            Schueler tmp = new Schueler(012, "simon", "01771727899");
            Schueler tmp1 = new Schueler(020, "luca", "01771727899");
            Schueler tmp2 = new Schueler(024, "janus", "01771727899");
            Schueler tmp3 = new Schueler(015, "marvin", "01771727899");
            Schueler tmp4 = new Schueler(026, "stefan", "01771727899");

            LinkedList<Schueler> test = new LinkedList<Schueler>(tmp);
            test.append(tmp1);
            test.append(tmp2);
            test.append(tmp3);
            test.append(tmp4);

            test.delete(tmp2);

            if (test.search(tmp) != null){
                if(test.search(tmp1) != null){
                    if(test.search(tmp3) != null){
                        if(test.search(tmp4) != null){
                            if(test.search(tmp2) == null){
                                return 1;
                            }
                        }
                    }
                }
            }

            return -1;
        }
        
        public static void Main(){
            
            if (test_Append() != 1){
                Console.WriteLine("Error in append");
            }
            
            if (test_Prepend() != 1){
                Console.WriteLine("Error in prepend");
            }
            
            if (test_Search() != 1){
                Console.WriteLine("Error in search");
            }
            
            if (test_Delete() != 1){
                Console.WriteLine("Error in delete");
            }




            Schueler tmp = new Schueler(012, "simon", "01771727899");
            Schueler tmp1 = new Schueler(020, "luca", "01771727899");
            Schueler tmp2 = new Schueler(024, "janus", "01771727899");
            Schueler tmp3 = new Schueler(015, "marvin", "01771727899");
            Schueler tmp4 = new Schueler(026, "stefan", "01771727899");
            LinkedList<Schueler> test = new LinkedList<Schueler>(tmp);

            test.append(tmp1);
            test.append(tmp2);
            test.append(tmp3);
            test.append(tmp4);

            test.prepend(tmp4);
            test = test.giveHead();
            test.print();
            Console.WriteLine("-------------------------------------------------------------------------------");
            test.delete(tmp);
            test = test.giveHead();
            test.print();
            Console.WriteLine("-------------------------------------------------------------------------------");
            test.append(tmp);
            Schueler simon = test.search(tmp);
            simon.print();
            Console.WriteLine("-------------------------------------------------------------------------------");
            test.sort();
            test = test.giveHead();
            test.print();
        }

    }
    
}
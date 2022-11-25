using System;
namespace LL{
    class Program{
        
        public static void Main(){
            Schueler tmp = new Schueler(012, "simon", "01771727899");
            Schueler tmp1 = new Schueler(013, "luca", "01771727899");
            Schueler tmp2 = new Schueler(014, "janus", "01771727899");
            Schueler tmp3 = new Schueler(015, "marvin", "01771727899");
            Schueler tmp4 = new Schueler(016, "stefan", "01771727899");
            LinkedList<Schueler> test = new LinkedList<Schueler>(tmp);

            test.append(tmp1);
            test.append(tmp2);
            test.append(tmp3);
            test.append(tmp4);

            test.prepend(tmp4);
            test = test.giveHead();
            // test.print();
            test.delete(tmp);
            test = test.giveHead();
            test.print();
            test.append(tmp);
            Schueler simon = test.search(tmp);

            
        }

    }
    
}
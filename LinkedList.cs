using System;
class LinkedList<T> where T : class, IComparable, print, compare<T>
{
    private LinkedList<T> Next;
    private LinkedList<T> Previous;
    private T Data;


    public LinkedList(T data){
        Next = null;
        Previous = null;
        Data = data;
    }


    public T search(T data){
        bool noMoreItms = false;
        LinkedList<T> cur = this;
        while(!noMoreItms){
            if (data.compare(cur.Data) == 0){
               return cur.Data;
            }else if(cur.Next != null){
                cur = cur.Next;
            }else{
                noMoreItms = true;
            }
        }
        return null;
    }

    public bool delete(T data){
        bool noMoreItms = false;
        LinkedList<T> cur = this;
        while(!noMoreItms){
            if (cur.Data == data){
                if (cur.Previous != null){
                    cur.Previous.Next = cur.Next;
                    cur.Next.Previous = cur.Previous;
                    return true;
                }else{
                    if(cur.Next == null){
                        cur = null;
                        return true;
                    }else{
                        cur = cur.Next;
                        cur.Previous = null;
                        return true;
                    }
                }
            }else if(cur.Next != null){
                cur = cur.Next;
            }else{
                noMoreItms = true;
            }
        }
        return false;
    }

    public bool prepend(T data){
        LinkedList<T> cur = this;
        if(cur.Data != null){
            LinkedList<T> toPrep = new LinkedList<T>(data);
            cur.Previous = toPrep;
            toPrep.Next = cur;
            cur = cur.Previous;
            return true;
        }else{
            cur.Data = data;
            return true;
        }
    }

    public bool append(T data){
        LinkedList<T> cur = this;
        while(cur.Next != null){
            cur = cur.Next;
        }

        LinkedList<T> toApp = new LinkedList<T>(data);
        toApp.Previous = cur;
        cur.Next = toApp;

        return true;
    }
    public void print(){
        LinkedList<T> cur = this;

        while(true){
            if (cur.Next == null){
                cur.Data.print();
                return;
            }
            cur.Data.print();
            Console.WriteLine("-->");
            cur = cur.Next;
        }
    }

    public LinkedList<T> giveHead(){
        LinkedList<T> cur = this;
        while (cur.Previous != null){
            cur = cur.Previous;
        }
        return cur;
    }
}
using System;
class LinkedList<T> where T : class, print, Compare<T>
{
    public LinkedList<T> Next;
    public LinkedList<T> Previous;
    public T Data;


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

    private void insertBefore(LinkedList<T> insert){
        LinkedList<T> cur = this;
        if(cur.Previous == null){
            cur.Previous = insert;
            cur.Next = insert.Next;
            insert.Next = cur;
            insert.Previous = null;
        }else{
            insert.Previous = cur.Previous;
            cur.Next = insert.Next;
            insert.Next = cur;
            cur.Previous = insert;
        }
    }

    private void insertAfter(LinkedList <T> insert){
        LinkedList<T> cur = this;
        if(cur.Next == null){
            insert.Next = null;
            cur.Previous = insert.Previous;
            insert.Previous = cur;
            cur.Next = insert;

        }
    }

    private void swapNext (){
        LinkedList<T> cur = this;
        LinkedList<T> next = this.Next;

        // Orange
        cur.Next = next.Next;
        next.Next.Previous = cur;
        // Green
        next.Previous = cur.Previous;
        cur.Previous.Next = next;
        // Blue
        next.Next = cur;
        cur.Previous = next;

    }

    public void sort(){
        LinkedList<T> cur = this.giveHead();
        bool sorted = false;
        bool swapped = false;
        while(!sorted){
            int compRes = cur.Data.compare(cur.Next.Data);
            switch(compRes){
                case (1):
                    cur.swapNext();
                    swapped = true;
                    break;
                case (0):
                case (-1):
                    cur = cur.Next;
                    break;
            }

            if(cur.Next == null){
                if(swapped == false){
                    sorted = true;
                }else{
                    swapped = false;
                    cur = cur.giveHead();
                }
            }
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
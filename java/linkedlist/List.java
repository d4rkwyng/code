import java.util.*;

/**
 * CIS20  Asn 11
 * List.java
 * Purpose: Tests the usage of Linked Lists.
 *
 * @author Derek Wood
 * @version 1.0 5/14/03
 */
public class List {
    private ListNode first, current, previous;

    /**
     * return the current item
     */
    Object getData() {
        return current.data;
    }
      
   
    /**
     * remove current item and advance current to next
     */
    void remove() {
        if (first == null) return;
        if (current == null) return;
        if (current == first)
            first = current = current.nextNode;
        else
            current = previous.nextNode = current.nextNode;
    }

    /**
     * get the head of the list
     */
    ListNode getFirst() {
        return first;
    }

    /**
     * set current to the first item
     */
    void moveFirst() {
        previous = current = null;
    }
    
    /**
     * advance current to the next item and return it
     */
    Object next() {
        previous = current;
        if (current == null)
            current = first;
        else
            current = current.nextNode;
        if (current == null)
            return null;
        return current.data;
    }

    /**
     * returns true if current is not the last item
     */
    boolean hasNext() {
        if (current == null)
            return first != null;
        else
            return current.nextNode != null;
    }

    /**
     * Default constructor
     *
     * @return this -- Returns the element
     */
    Iterator iterator() {
        return new ListIter(this);
    }
    
  //insert after the item referred to by current
    void insert(Object value) {
        previous = current;
        if (current != null) {
            ListNode temp = current.nextNode;
            current.nextNode = new ListNode();
            current.nextNode.data = value;
            current = current.nextNode;
            current.nextNode = temp;
        } else if (first != null) {
            current = new ListNode();
            current.data = value;
            current.nextNode = first;
            first = current;
        } else { /* list is empty */
            first = current = new ListNode();
            current.data = value;
        }
    }
      
    //}
    /**
     * The method inserts a new element with the field data
     * set to value, following the element referred to by the
     * iterator it. The method should return a new Iterator,
     * positioned at the element just inserted. Note that an
     * iterator not pointing to any element (where current == null)
     * should be interpreted as positioned before the first element.
     * This interpretation allows inserting a node at any point.
     * The iterator cannot be positioned after the last element.
     *
     * @param it -- ; value --
     */
    
    Iterator insert(Iterator it, Object value) {
        previous = current;
        if (current == null) {
            first = current = new ListNode();
            current.data = value;
        } else {  
            current.nextNode = new ListNode();
            current.nextNode.data = value;
            current = current.nextNode;}
        ListIter lit = (ListIter) it;
        return lit;      //return iterator positioned at the element
    }

    /**
     * The method does not copy the elements like append().
     * Instead, it simply sets the nextNode field of the last
     * node to the first node of the list referred to by list.
     *
     * @param list --
     */
    void concatenate(List list) {
        Iterator itThis = this.iterator();
        Iterator itOther = list.iterator();
        //Begin at location of list1 and concatenate list 2
        while (itOther.hasNext())
            itThis = insert(itThis, itOther.next());
    }

    /**
     * Copies the elements
     */
    void append(List list) {
        Iterator itThis = this.iterator();
        Iterator itOther = list.iterator();
        //position at end of list
        while (itThis.hasNext())
            itThis.next();
        while (itOther.hasNext())
            itThis = insert(itThis, itOther.next());
    }

    public class ListNode {
        private Object data;
        private ListNode nextNode;

        public Object getData() { return data;}
        public ListNode getNextNode() { return nextNode;}
    }

    public static void main(String[] args) {
        List list = new List();
        for (int i = 0; i < 5; i++)
            list.insert(new Integer(i));
        list.moveFirst();
        System.out.print("Original List 1:  ");
        while (list.hasNext())
            System.out.print(list.next() + " ");
        System.out.println();
        list.moveFirst();
        list.next(); //1
        list.insert(new Integer(99));
        list.next(); //2
        list.remove();
        list.moveFirst();
        System.out.print("Insertion of 99:  ");
        while (list.hasNext())
            System.out.print(list.next() + " ");
        System.out.println();
        
        // Addition of code to validate the append
        // Create second list
        List list2 = new List();
        for (int i = 20; i < 25; i++)
            list2.insert(new Integer(i));
        list2.moveFirst();
        System.out.print("List 2:  ");
        while (list2.hasNext())
            System.out.print(list2.next() + " ");
        System.out.println();
        list.moveFirst();
        list2.moveFirst();
        list.append(list);
        list.append(list2);           //Question if appends to List
        System.out.print("Append Test:  ");
        list.moveFirst();
        while (list.hasNext())
            System.out.print(list.next() + " ");
        System.out.println();
        
        //Concatenate test
        //Create third test list and concatenate this new list beginning at the
        // 8th location of the original list
        List list3 = new List();
        for (int i = 30; i < 35; i++)
            list3.insert(new Integer(i));
        list3.moveFirst();
        list.moveFirst();
        for (int i =1; i < 8; i++)
            list.next();
        list.concatenate(list3);
        list.moveFirst();
        System.out.print("Concatenate Test:  ");
        while (list.hasNext())
            System.out.print(list.next() + " ");
        System.out.println();
        
        //end Concatenate
        
        Iterator it = list.iterator();
        System.out.print("Final List");
        while (it.hasNext())
            System.out.print(it.next() + " ");
        System.out.println("\n\nTest end of list");
        try {
            System.out.print(it.next() + " ");
        } catch(NoSuchElementException e) {
            System.out.println(e.getMessage());
        }
    }
}

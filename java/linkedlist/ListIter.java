import java.util.*;

class ListIter implements Iterator {
    List.ListNode current;
    List list;

    ListIter(List aList) {
        list = aList;
        current = null;
    }

    Object current() {
        if (current == null)
            return null;
        return current.getData();
    }

    public boolean hasNext() {
        if (current != null)
            return current.getNextNode() != null;
        else
            return list.getFirst() != null;
    }

    public Object next() {
        if (current == null)
            current = list.getFirst();
        else
            current = current.getNextNode();
        if (current == null)
            throw new NoSuchElementException(
                "No more elements");
        return current.getData();
    }

    public void remove() {
        throw new UnsupportedOperationException();
    }
}
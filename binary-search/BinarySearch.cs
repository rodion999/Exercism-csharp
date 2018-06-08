using System;

public class BinarySearch
{
    int[] _array;
    public BinarySearch(int[] input)
    {
        _array = input;
    }

    public int Find(int value)
    {
        int pos = Array.BinarySearch(_array, value);
        if (pos >= 0)
            return pos;
        else return -1;
    }
}


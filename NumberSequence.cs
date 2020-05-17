using System;
using System.Collections.Generic;
using System.Text;

namespace lv7.components
{
    //1. zad
    //class NumberSequence
    //{
    //    private double[] sequence;
    //    private int sequenceSize;
    //    private SortStrategy sortStrategy;
    //    public NumberSequence(int sequenceSize)
    //    {
    //        this.sequenceSize = sequenceSize;
    //        this.sequence = new double[sequenceSize];
    //    }
    //    public NumberSequence(double[] array) : this(array.Length)
    //    {
    //        array.CopyTo(this.sequence, 0);
    //    }
    //    public void InsertAt(int index, double value)
    //    {
    //        this.sequence[index] = value;
    //    }
    //    public void SetSortStrategy(SortStrategy strategy)
    //    {
    //        this.sortStrategy = strategy;
    //    }
    //    public void Sort() { this.sortStrategy.Sort(this.sequence); }
    //    public override string ToString()
    //    {
    //        StringBuilder builder = new StringBuilder();
    //        foreach (double element in this.sequence)
    //        {
    //            builder.Append(element).Append(Environment.NewLine);
    //        }
    //        return builder.ToString();
    //    }
    //}

    //2.zad
    class NumberSequence
    {
        private double[] sequence;
        private int sequenceSize;
        private SortStrategy sortStrategy;
        private SearchStrategy searchStrategy;
        private double key;
        public NumberSequence(int sequenceSize)
        {
            this.sequenceSize = sequenceSize;
            this.sequence = new double[sequenceSize];
        }
        public NumberSequence(double[] array) : this(array.Length)
        {
            array.CopyTo(this.sequence, 0);
        }
        public void InsertAt(int index, double value)
        {
            this.sequence[index] = value;
        }
        public void SetSortStrategy(SortStrategy strategy)
        {
            this.sortStrategy = strategy;
        }

        public void SetSearchStrategy(SearchStrategy strategy, double key)
        {
            this.searchStrategy = strategy;
            this.key = key;
        }
        public void Sort() { this.sortStrategy.Sort(this.sequence); }
        public void Search() { this.searchStrategy.Search(this.sequence, this.key); }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (double element in this.sequence)
            {
                builder.Append(element).Append(Environment.NewLine);
            }
            return builder.ToString();
        }
    }

}

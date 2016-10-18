﻿using System;

namespace ZeroFormatter
{
    public interface IKeyTuple
    {
        string ToString();
    }

    public static class KeyTuple
    {
        public static KeyTuple<T1, T2, T3, T4, T5, T6, T7, KeyTuple<T8>> Create<T1, T2, T3, T4, T5, T6, T7, T8>
            (
             T1 item1,
             T2 item2,
             T3 item3,
             T4 item4,
             T5 item5,
             T6 item6,
             T7 item7,
             T8 item8)
        {
            return new KeyTuple<T1, T2, T3, T4, T5, T6, T7, KeyTuple<T8>>(item1, item2, item3, item4, item5, item6, item7, new KeyTuple<T8>(item8));
        }

        public static KeyTuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>
            (
             T1 item1,
             T2 item2,
             T3 item3,
             T4 item4,
             T5 item5,
             T6 item6,
             T7 item7)
        {
            return new KeyTuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
        }

        public static KeyTuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>
            (
             T1 item1,
             T2 item2,
             T3 item3,
             T4 item4,
             T5 item5,
             T6 item6)
        {
            return new KeyTuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
        }

        public static KeyTuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>
            (
             T1 item1,
             T2 item2,
             T3 item3,
             T4 item4,
             T5 item5)
        {
            return new KeyTuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
        }

        public static KeyTuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>
            (
             T1 item1,
             T2 item2,
             T3 item3,
             T4 item4)
        {
            return new KeyTuple<T1, T2, T3, T4>(item1, item2, item3, item4);
        }

        public static KeyTuple<T1, T2, T3> Create<T1, T2, T3>
            (
             T1 item1,
             T2 item2,
             T3 item3)
        {
            return new KeyTuple<T1, T2, T3>(item1, item2, item3);
        }

        public static KeyTuple<T1, T2> Create<T1, T2>
            (
             T1 item1,
             T2 item2)
        {
            return new KeyTuple<T1, T2>(item1, item2);
        }

        public static KeyTuple<T1> Create<T1>
            (
             T1 item1)
        {
            return new KeyTuple<T1>(item1);
        }
    }

    public struct KeyTuple<T1> : IKeyTuple
    {
        T1 item1;

        public KeyTuple(T1 item1)
        {
            this.item1 = item1;
        }

        public T1 Item1
        {
            get { return item1; }
        }

        string IKeyTuple.ToString()
        {
            return String.Format("{0}", item1);
        }

        public override string ToString()
        {
            return "(" + ((IKeyTuple)this).ToString() + ")";
        }
    }

    public struct KeyTuple<T1, T2> : IKeyTuple
    {
        T1 item1;
        T2 item2;

        public KeyTuple(T1 item1, T2 item2)
        {
            this.item1 = item1;
            this.item2 = item2;
        }

        public T1 Item1
        {
            get { return item1; }
        }

        public T2 Item2
        {
            get { return item2; }
        }

        string IKeyTuple.ToString()
        {
            return String.Format("{0}, {1}", item1, item2);
        }

        public override string ToString()
        {
            return "(" + ((IKeyTuple)this).ToString() + ")";
        }
    }

    public struct KeyTuple<T1, T2, T3> : IKeyTuple
    {
        T1 item1;
        T2 item2;
        T3 item3;

        public KeyTuple(T1 item1, T2 item2, T3 item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public T1 Item1
        {
            get { return item1; }
        }

        public T2 Item2
        {
            get { return item2; }
        }

        public T3 Item3
        {
            get { return item3; }
        }

        string IKeyTuple.ToString()
        {
            return String.Format("{0}, {1}, {2}", item1, item2, item3);
        }

        public override string ToString()
        {
            return "(" + ((IKeyTuple)this).ToString() + ")";
        }
    }

    public struct KeyTuple<T1, T2, T3, T4> : IKeyTuple
    {
        T1 item1;
        T2 item2;
        T3 item3;
        T4 item4;

        public KeyTuple(T1 item1, T2 item2, T3 item3, T4 item4)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
        }

        public T1 Item1
        {
            get { return item1; }
        }

        public T2 Item2
        {
            get { return item2; }
        }

        public T3 Item3
        {
            get { return item3; }
        }

        public T4 Item4
        {
            get { return item4; }
        }

        string IKeyTuple.ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}", item1, item2, item3, item4);
        }

        public override string ToString()
        {
            return "(" + ((IKeyTuple)this).ToString() + ")";
        }
    }

    public struct KeyTuple<T1, T2, T3, T4, T5> : IKeyTuple
    {
        T1 item1;
        T2 item2;
        T3 item3;
        T4 item4;
        T5 item5;

        public KeyTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
            this.item5 = item5;
        }

        public T1 Item1
        {
            get { return item1; }
        }

        public T2 Item2
        {
            get { return item2; }
        }

        public T3 Item3
        {
            get { return item3; }
        }

        public T4 Item4
        {
            get { return item4; }
        }

        public T5 Item5
        {
            get { return item5; }
        }

        string IKeyTuple.ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}, {4}", item1, item2, item3, item4, item5);
        }

        public override string ToString()
        {
            return "(" + ((IKeyTuple)this).ToString() + ")";
        }
    }

    public struct KeyTuple<T1, T2, T3, T4, T5, T6> : IKeyTuple
    {
        T1 item1;
        T2 item2;
        T3 item3;
        T4 item4;
        T5 item5;
        T6 item6;

        public KeyTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
            this.item5 = item5;
            this.item6 = item6;
        }

        public T1 Item1
        {
            get { return item1; }
        }

        public T2 Item2
        {
            get { return item2; }
        }

        public T3 Item3
        {
            get { return item3; }
        }

        public T4 Item4
        {
            get { return item4; }
        }

        public T5 Item5
        {
            get { return item5; }
        }

        public T6 Item6
        {
            get { return item6; }
        }

        string IKeyTuple.ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}, {4}, {5}", item1, item2, item3, item4, item5, item6);
        }

        public override string ToString()
        {
            return "(" + ((IKeyTuple)this).ToString() + ")";
        }
    }

    public struct KeyTuple<T1, T2, T3, T4, T5, T6, T7> : IKeyTuple
    {
        T1 item1;
        T2 item2;
        T3 item3;
        T4 item4;
        T5 item5;
        T6 item6;
        T7 item7;

        public KeyTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
            this.item5 = item5;
            this.item6 = item6;
            this.item7 = item7;
        }

        public T1 Item1
        {
            get { return item1; }
        }

        public T2 Item2
        {
            get { return item2; }
        }

        public T3 Item3
        {
            get { return item3; }
        }

        public T4 Item4
        {
            get { return item4; }
        }

        public T5 Item5
        {
            get { return item5; }
        }

        public T6 Item6
        {
            get { return item6; }
        }

        public T7 Item7
        {
            get { return item7; }
        }

        string IKeyTuple.ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}", item1, item2, item3, item4, item5, item6, item7);
        }

        public override string ToString()
        {
            return "(" + ((IKeyTuple)this).ToString() + ")";
        }
    }

    public struct KeyTuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IKeyTuple
    {
        T1 item1;
        T2 item2;
        T3 item3;
        T4 item4;
        T5 item5;
        T6 item6;
        T7 item7;
        TRest rest;

        public KeyTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
            this.item5 = item5;
            this.item6 = item6;
            this.item7 = item7;
            this.rest = rest;

            if (!(rest is IKeyTuple))
                throw new ArgumentException("rest", "The last element of an eight element tuple must be a Tuple.");
        }

        public T1 Item1
        {
            get { return item1; }
        }

        public T2 Item2
        {
            get { return item2; }
        }

        public T3 Item3
        {
            get { return item3; }
        }

        public T4 Item4
        {
            get { return item4; }
        }

        public T5 Item5
        {
            get { return item5; }
        }

        public T6 Item6
        {
            get { return item6; }
        }

        public T7 Item7
        {
            get { return item7; }
        }

        public TRest Rest
        {
            get { return rest; }
        }

        string IKeyTuple.ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", item1, item2, item3, item4, item5, item6, item7, ((IKeyTuple)rest).ToString());
        }

        public override string ToString()
        {
            return "(" + ((IKeyTuple)this).ToString() + ")";
        }
    }
}
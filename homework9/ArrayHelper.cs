using System;
using System.Linq;

namespace homework9
{
    public static class ArrayHelper
    {
        public static T Pop<T>(ref T[] args)
        {
            var lastElement = args.Last();
            args = args.Take(args.Length - 1).ToArray();
            return lastElement;
        }

        public static int Push<T>(ref T[] args, T element)
        {
            var elements = args.Append(element);
            args = new T[args.Length];
            args = elements.ToArray();
            return args.Length;
        }

        public static T Shift<T>(ref T[] args)
        {
            var firstElement = args.First();
            args = args.Skip(1).ToArray();
            return firstElement;
        }

        public static int UnShift<T>(ref T[] args, T element)
        {
            args = new[] {element}.Concat(args).ToArray();
            return args.Length;
        }

        public static T[] Slice<T>(T[] args)
        {
            return args;
        }

        public static T[] Slice<T>(T[] args, int begin)
        {
            if (begin < 0)
                return args.Skip(args.Length + begin).ToArray();

            return begin > args.Length - 1 ? Array.Empty<T>() : args.Skip(begin).ToArray();
        }

        public static T[] Slice<T>(T[] args, int begin, int end)
        {
            var tempArray = Slice(args, begin);

            return end < 0
                ? tempArray.Take(tempArray.Length - end - 2).ToArray()
                : tempArray.Take(end - 1).ToArray();
        }
    }
}
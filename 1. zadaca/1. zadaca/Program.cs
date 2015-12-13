using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.zadaca
{
    class Program
    {



        static void Main(string[] args)
        {
        }

        public class IntegerList : IIntegerList
        {
            private int[] _internalStorage;
            private int _internalStorageSize;

            public IntegerList()
            {
                _internalStorageSize = 4;
            }
            public IntegerList(int size)
            {
                _internalStorageSize = this.size;
            }

            void Add(int x)
            {
                int position;
                if (Count() == _internalStorageSize)
                {
                    
                }
                position = Count();
                _internalStorage[position] = x;
            }

            bool RemoveAt(int x)
            {
                int _internalStorageSize, _internalStorage[];
                if (x > _internalStorageSize)
                {
                    return false;
                }
                for (i = 0; i < (Count() - x); i++)
                {
                    _internalStorage[x + i] == _internalStorage[x + i + 1];
                }
                _internalStorage[Count()] = null;
                return true;
            }

            bool Remove(int x)
            {
                int index;
                index = IndexOf(x);
                RemoveAt(index);
            }

            int GetElement(int index)
            {
                if (index <= Count())
                {
                    return _internalStorage[index];
                }
                return IndexOutOfRangeException;
            }

            int IndexOf(int x)
            {
                for (i = 0; i < Count(); i++)
                {
                    if (_internalStorage[i] == x) return i;
                }
                return -1;
            }

            int Count()
            {
                int size, clan;
                foreach (int clan in _internalStorage)
                {
                    if (clan = !null)
                    {
                        size++;
                    }
                }
                return size + 1;
            }

            void Clear()
            {
                foreach (int clan in _internalStorage)
                    Remove(clan);
            }

            bool Contains(int x)
            {
                if (IndexOf(this.x) == (-1))
                    return false;
                return true;
            }
        }

       


            

        }

        public interface IIntegerList
        {
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HomeWork_4
{
    internal class MyList<T> : IEnumerable, IComparable<T>
    {
        private T[] _array = Array.Empty<T>();

        private readonly double val;

        public MyList()
        {

        }

        public T this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }

        public int Count { get => _array.Length; }

        #region Добавление элемента
        public void Add(T value)
        {
            var newArray = new T[Count + 1];

            for (int i = 0; i < Count; i++)
                newArray[i] = _array[i];

            newArray[Count] = value;
            _array = newArray;

        }
        #endregion

        #region IEnumerable

        public IEnumerator GetEnumerator()
        {
            foreach (var item in _array)
                yield return item;
        }

        #endregion

        #region IComparable<T>

        public int CompareTo(T other)
        {
            return val.CompareTo(other);
        }


        #endregion

        #region Удаление элемента
        public bool Remove(int index)
        {
            if (index >= 0 && index < Count)
            {
                var newArray = new T[Count - 1];

                for (int i = 0, j = 0; i < Count; i++)
                {
                    if (i != index)
                    {
                        newArray[j] = _array[i];
                        j++;
                    }
                }
                _array = newArray;
                return true;
            }
            else return false;
        }
        #endregion

        #region Поиск минимума

        public T SearchingMinimum()
        {
            var result = _array.Min();
            return result;
        }

        #endregion

        #region Поиск максимума

        public T SearchingMaximum()
        {
            var result = _array.Max();
            return result;
        }

        #endregion

        #region Поиск индекса заданного элемента в массиве

        public int SearchingIndexArrayValue(dynamic value)
        {
            try
            {
                if (_array[0] is int)
                    value = Convert.ToInt32(value);
                else if (_array[0] is double)
                    value = Convert.ToDouble(value);
                else if (_array[0] is decimal)
                    value = Convert.ToDecimal(value);
                else if (_array[0] is DateTime)
                    value = Convert.ToDateTime(value);
                return Array.IndexOf(_array, value);
            }
            catch (Exception)
            {
                new AppException("Системная ошибка");
                return -1;
            }

        }

        #endregion

        #region Поиск элемента в массиве

        public bool Find(dynamic value)
        {
            try
            {
                foreach (var item in _array)
                    if (item == Convert.ToDouble(value))
                        return true;
                return false;
            }
            catch (Exception)
            {
                foreach (var item in _array)
                    if (item == value)
                        return true;
                return false;
            }
        }

        #endregion

        #region Сумма всех элементов массива

        public T SumValueArray()
        {
            T score = default(T);
            for (int i = 0; i <= Count - 1; i++)
                score += (dynamic)_array[i];
            return score;
        }

        #endregion

        #region Произвдение всех элементов массива

        public T MultiplicationValueArray()
        {
            try
            {
                T score = default;
                score += (dynamic)1;
                for (int i = 0; i <= Count - 1; i++)
                {
                    score *= (dynamic)_array[i];
                }
                return score;
            }
            catch
            {
                return SumValueArray();
            }
        }

        #endregion

        #region Получение элемента массива по индексу

        public T GetValueArrayIndex(int index)
        {
            T score = default;
            if (index >= 0 && index < Count)
            {
                foreach (var item in _array)
                    if ((dynamic)item == (dynamic)_array[index])
                        return item;
            }
            return score;
        }

        #endregion

        #region Задание значения элементу массива с заданным индексом

        public bool InsertElementAtIndex(int index, dynamic value)
        {
            if (index >= 0 && index < Count)
            {
                try
                {
                    foreach (var item in _array)
                    {
                        if ((dynamic)item == (dynamic)_array[index])
                        {
                            if(_array[index] is int)
                                _array[index] = Convert.ToInt32(value);
                            else if (_array[index] is double)
                                _array[index] = Convert.ToDouble(value);
                            else if (_array[index] is decimal)
                                _array[index] = Convert.ToDecimal(value);
                            else if (_array[index] is DateTime)
                                _array[index] = Convert.ToDateTime(value);
                            else if (_array[index] is string)
                                _array[index] = value;
                            // и тд.
                            return true;
                        }
                    }
                    return false;
                }
                catch (Exception)
                {
                    new AppException("Системная ошибка");
                    return false;
                }

            }
            else return false;
        }

        #endregion

        #region Пузырьковая сортировка

        public T[] BubbleSort()
        {
            bool KeepIterating = true;
            while (KeepIterating)
            {
                KeepIterating = false;
                for (int i = 0; i < _array.Length - 1; i++)
                {
                    T x = _array[i];
                    T y = _array[i + 1];
                    if (Comparer<T>.Default.Compare(x, y) > 0)
                    {
                        _array[i] = y;
                        _array[i + 1] = x;
                        KeepIterating = true;
                    }
                }
            }
            return _array;
        }

        #endregion

        #region Сортировка простыми вставками

        public T[] SortingWithSimpleInserts()
        {
            try
            {
                for (int i = 1; i < _array.Length; i++)
                {
                    T k = _array[i];
                    int j = i - 1;

                    while (j >= 0 && (dynamic)_array[j] > k)
                    {
                        _array[j + 1] = _array[j];
                        _array[j] = k;
                        j--;
                    }
                }
                return _array;
            }
            catch (Exception)
            {
                return BubbleSort();
            }

        }


        #endregion

        #region Сортировка простым выбором


        public T[] SortingSimpleChoice()
        {
            try
            {
                int i, j, min;
                T temp;
                for (i = 0; i < _array.Length - 1; i++)
                {
                    min = i; //устанавливаем начальное значение минимального индекса

                    //находим минимальный индекс элемента
                    for (j = i + 1; j < _array.Length; j++)
                    {
                        if ((dynamic)_array[j] < (dynamic)_array[min])
                            min = j;
                    }

                    //меняем значения местами
                    temp = _array[i];
                    _array[i] = _array[min];
                    _array[min] = temp;
                }
                return _array;
            }
            catch (Exception)
            {
                return BubbleSort();
            }

        }

        #endregion
    }
}

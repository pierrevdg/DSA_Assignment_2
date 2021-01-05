using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Assignment_2
{
    class CustomDataList
    {
        public List<Student> customList;
        public int length;
        public Student first;
        public Student last;
        public CustomDataList(List<Student> customList)
        {
            this.customList = customList;
            length = customList.Count;
        }
        public void Add(Student student)
        {
            customList.Add(student);
            length = length + 1;
            first = customList[0];
            last = student;
        }
        public void GetElement(int index)
        {
            Console.WriteLine(customList[index]);
        }
        public void RemoveByIndex(int index)
        {
            if (index == 0)
            {
                first = customList[1];
            }
            else
            {
                if (index == length - 1)
                {
                    last = customList[length - 2];
                }
            }
            length--;
            customList.RemoveAt(index);
        }
        public void RemoveFirst()
        {
            first = customList[1];
            customList.RemoveAt(0);
            length--;
        }
        public void RemoveLast()
        {
            last = customList[length - 2];
            customList.RemoveAt(length - 1);
            length--;
        }
        public void DisplayList()
        {
            for (int i = 0; i < length; i++)
            {
                GetElement(i);
            }
        }
        public void GetMaxElement()
        {
            Student bestStudent = customList[0];
            for (int i = 1; i < length; i++)
            {
                if (customList[i].averageScore > bestStudent.averageScore)
                {
                    bestStudent = customList[i];
                }
            }
            Console.WriteLine(bestStudent);
        }
        public void GetMinElement()
        {
            Student worstStudent = customList[0];
            for (int i = 1; i < length; i++)
            {
                if (customList[i].averageScore < worstStudent.averageScore)
                {
                    worstStudent = customList[i];
                }
            }
            Console.WriteLine(worstStudent);
        }
        public void SortByAscendingOrder()
        {
            Student student = customList[0];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (customList[j].averageScore > customList[j + 1].averageScore)
                    {
                        student = customList[j];
                        customList[j] = customList[j + 1];
                        customList[j + 1] = student;
                    }
                }
            }
            DisplayList();
        }
        public void SortByDescendingOrder()
        {
            Student student = customList[0];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (customList[j].averageScore < customList[j + 1].averageScore)
                    {
                        student = customList[j];
                        customList[j] = customList[j + 1];
                        customList[j + 1] = student;
                    }
                }
            }
            DisplayList();
        }
        public void SortByAlphabeticalOrderFirstName()
        {
            Student student = customList[0];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (Convert.ToInt32(customList[j].firstName[0]) == Convert.ToInt32(customList[j + 1].firstName[0]))
                    {
                        int k = 1;
                        bool verification = true;
                        while (verification == true)
                        {
                            if (Convert.ToInt32(customList[j].firstName[k]) > Convert.ToInt32(customList[j + 1].firstName[k]))
                            {
                                student = customList[j];
                                customList[j] = customList[j + 1];
                                customList[j + 1] = student;
                                verification = false;
                            }
                            k++;
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(customList[j].firstName[0]) > Convert.ToInt32(customList[j + 1].firstName[0]))
                        {
                            student = customList[j];
                            customList[j] = customList[j + 1];
                            customList[j + 1] = student;
                        }
                    }
                }
            }
            DisplayList();
        }
        public void SortByAlphabeticalOrderLastName()
        {
            Student student = customList[0];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (Convert.ToInt32(customList[j].lastName[0]) == Convert.ToInt32(customList[j + 1].lastName[0]))
                    {
                        int k = 1;
                        bool verification = true;
                        while (verification == true)
                        {
                            if (Convert.ToInt32(customList[j].lastName[k]) > Convert.ToInt32(customList[j + 1].lastName[k]))
                            {
                                student = customList[j];
                                customList[j] = customList[j + 1];
                                customList[j + 1] = student;
                                verification = false;
                            }
                            k++;
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(customList[j].lastName[0]) > Convert.ToInt32(customList[j + 1].lastName[0]))
                        {
                            student = customList[j];
                            customList[j] = customList[j + 1];
                            customList[j + 1] = student;
                        }
                    }
                }
            }
            DisplayList();
        }
    }
}

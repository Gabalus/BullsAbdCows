using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Game
    {
        private bool finish;
        public bool isfinished
        {
            get { return finish; }
            private set { finish = value; }
        }
        private string number;
        private string answer;
        private int lenghtnumber;
        public Game(string number)
        {
            lenghtnumber = number.Length;
            checknumber(number);
            this.number = number;
            GameRun.lenghtnumber = lenghtnumber;
            

        }
        private void checknumber(string number)
        {
            int d = int.Parse(number);
            if (number[0] == '0')
                throw new GenerateException("Число не в диапозоне");
           
            if (differentelements(number))
                throw new GenerateException("Число задано не по условию");
        }
        public void acceptAnswer(string num)
        {
            if(num.Length != lenghtnumber)
            {
                throw new Exception($"Ответ должен состоять из {lenghtnumber}");
            }
           checknumber(num);
            this.answer = num;
        }
        public string checkAnswer()
        {
            char[] result = new char[lenghtnumber];
            for (int i = 0; i<lenghtnumber; i++)
            {
                result[i] = 'n';
            }
            for (int i = 0; i < lenghtnumber; i++)
            {
                for (int j = 0; j < lenghtnumber; j++)
                {
                    if (i == j)
                    {
                        if (number[i] == answer[j])
                        {
                            result[j] = 'b';
                            break;
                        }
                        
                    }
                    else
                    {
                        if (number[i] == answer[j])
                        {
                            result[j] = 'c';
                            break;
                        }
                    }
                    
                }

                
            }
            string resultstr = null;
            for (int i = 0; i < lenghtnumber; i++)
            {
                resultstr = resultstr + result[i].ToString();
            }
             if (!((resultstr.Contains("n")) || (resultstr.Contains("c"))))
            {
                isfinished = true;
            }
            return resultstr;
        }

        private bool differentelements(string num)
        {
            for (int i = 0; i < lenghtnumber - 1; i++)
            {
                for (int j = i + 1; j < lenghtnumber; j++)
                {
                    if (num[i] == num[j])
                    {
                        return true;
                    }

                }
            }
            return false;
        }

    }
}

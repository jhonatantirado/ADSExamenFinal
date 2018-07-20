namespace Duplicates.Common{
    using System;
    using System.Collections.Generic;

    public class Duplicates{

        public ResultDto duplicateValues(int[] numbers)
        {
            ResultDto resultDto = new ResultDto();
            long steps = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    steps++;
                    if (i != j && numbers[i] == numbers[j])
                    {
                        resultDto.setHasDuplicates(true);
                        resultDto.setSteps(steps);
                        return resultDto;
                    }
                }
            }
            resultDto.setHasDuplicates(false);
            resultDto.setSteps(steps);
            return resultDto;
        }

        public ResultDto duplicateValuesNew(int[] numbers)
        {
            HashSet<int> unicos = new HashSet<int>();
            long steps = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                steps++;
                if (!unicos.Contains(numbers[i]))
                {
                    unicos.Add(numbers[i]);
                }
            }

            steps++;

            ResultDto resultDto = new ResultDto();

            if (unicos.Count < numbers.Length)
            {
                resultDto.setHasDuplicates(true);
                resultDto.setSteps(steps);
                return resultDto;
            }

            resultDto.setHasDuplicates(false);
            resultDto.setSteps(steps);
            return resultDto;
        }
        public class ResultDto
        {
            private bool _hasDuplicates;
            private long steps;

            public bool hasDuplicates()
            {
                return _hasDuplicates;
            }

            public void setHasDuplicates(bool hasDuplicates)
            {
                _hasDuplicates = hasDuplicates;
            }

            public long getSteps()
            {
                return steps;
            }

            public void setSteps(long steps)
            {
                this.steps = steps;
            }
        }
    }
}
﻿using System;

namespace GradeBook.GradeBooks
{
    public  class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if()
            {
                throw InvalidOperationException;
                return 'F';
            }
            return 'F';
        }
    }
}

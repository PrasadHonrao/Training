﻿using System.Collections;

namespace Introduction
{
    public class AnimalCollection : ArrayList
    {
        public override int Add(object value)
        {
            return base.Add(value);
        }

        public override object this[int index]
        {
            get
            {
                return base[index];
            }
            set
            {
                base[index] = value;
            }
        }
    }
}

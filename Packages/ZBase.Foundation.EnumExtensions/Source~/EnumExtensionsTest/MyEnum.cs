﻿using ZBase.Foundation.EnumExtensions;

namespace EnumExtensionsTests
{
    [EnumExtensions]
    public enum MyEnum
    {
        A, B, C
    }

    partial class MyEnumExtensions
    {

    }

    public class Program
    {
        public void Do()
        {
        }
    }
}

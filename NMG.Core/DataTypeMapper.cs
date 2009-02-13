using System;

namespace NMG.Core
{
    public class DataTypeMapper
    {
        public Type MapFromDBType(string dataType)
        {
            if (dataType == "DATE" || dataType == "datetime")
            {
                return typeof(DateTime);
            }
            if (dataType == "NUMBER" || dataType == "nchar")
            {
                return typeof(long);
            }
            if (dataType == "int")
            {
                return typeof(int);
            }
            return typeof(string);
        }
    }
}
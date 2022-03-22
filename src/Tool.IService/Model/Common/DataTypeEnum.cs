namespace Tool.IService.Model.Common
{
    /// <summary>
    /// 格式处理：
    /// 1.首下划线删除
    /// 2.三下划线转(
    /// 3.二下划线转,
    /// 4.一下换线转)
    /// </summary>
    public enum SqlServerDataType
    {
        /* 数据库设计原始类型
        
         * 数字类型（整型、浮点型）
        bit    tinyint   smallint      int       bigint
        float  real      smallmoney    money     numeric(18, 0)   decimal(18, 0)

         * 进制、字符类型
        uniqueidentifier
        image       binary(50)  varbinary(50)  varbinary(MAX)
        char(10)    nchar(10)   varchar(50)    varchar(MAX)    nvarchar(50)    nvarchar(MAX)
        text        ntext       xml
        
         * 时间类型
        time(7)   date   smalldatetime   datetime   datetime2(7)   datetimeoffset(7)   timestamp
        
         * 其他类型
        geography  geometry  hierarchyid  sql_variant
        */
        _bit = 1,
        _tinyint = 2,
        _smallint = 3,
        _int = 4,
        _bigint = 5,
        _float = 6,
        _real = 7,
        _smallmoney = 8,
        _money = 9,
        _numeric = 10,
        _decimal = 11,
        _uniqueidentifier = 12,
        _image = 13,
        _binary = 14,
        _varbinary = 15,
        _char = 16,
        _nchar = 17,
        _varchar = 18,
        _nvarchar = 19,
        _text = 20,
        _ntext = 21,
        _xml = 22,
        _time = 23,
        _date = 24,
        _smalldatetime = 25,
        _datetime = 26,
        _datetime2 = 27,
        _datetimeoffset = 28,
        _timestamp = 29,
        _geography = 30,
        _geometry = 31,
        _hierarchyid = 32,
        _sql_variant = 33
    }

    public enum SqliteDataType
    {
        /* 数据库设计原始类型
        
         * 数字类型（整型、浮点型）
        INTEGER  NUMERIC  REAL

         * 进制、字符类型
        TEXT  BLOB
        */
        _BLOB = 1,
        _INTEGER = 2,
        _NUMERIC = 3,
        _REAL = 4,
        _TEXT = 5
    }
}

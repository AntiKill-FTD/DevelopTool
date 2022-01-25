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
        bit = 1,
        tinyint = 2,
        smallint = 3,
        _int = 4,
        bigint = 5,
        ////////////////////////////////////////
        _float = 6,
        smallmoney = 7,
        money = 8,
        numeric___18__2_ = 9,
        _decimal___18__0_ = 10,
        ////////////////////////////////////////
        uniqueidentifier = 11,
        binary___50_ = 12,
        varbinary___50_ = 13,
        _char___10_ = 14,
        varchar___50_ = 15,
        nchar_10 = 16,
        nvarchar___50_ = 17,
        text = 18,
        ntext = 19,
        xml = 20,
        ////////////////////////////////////////
        time___7_ = 21,
        date = 22,
        smalldatetime = 23,
        datetime = 24,
        datetime2___7_ = 25,
        datetimeoffset___7_ = 26,
        timestamp = 27,
        ////////////////////////////////////////
        geography = 28,
        geometry = 29,
        hierarchyid = 30,
        image = 31,
        real = 32,
        sql_variant = 33
    }

    public enum SqliteDataType
    {
        bit = 1,
        tinyint = 2,
        smallint = 3,
        _int = 4,
        bigint = 5,
        ////////////////////////////////////////
        _float = 6,
        smallmoney = 7,
        money = 8,
        numeric___18__2_ = 9,
        _decimal___18__0_ = 10,
        ////////////////////////////////////////
        uniqueidentifier = 11,
        binary___50_ = 12,
        varbinary___50_ = 13,
        _char___10_ = 14,
        varchar___50_ = 15,
        nchar_10 = 16,
        nvarchar___50_ = 17,
        text = 18,
        ntext = 19,
        xml = 20,
        ////////////////////////////////////////
        time___7_ = 21,
        date = 22,
        smalldatetime = 23,
        datetime = 24,
        datetime2___7_ = 25,
        datetimeoffset___7_ = 26,
        timestamp = 27,
        ////////////////////////////////////////
        geography = 28,
        geometry = 29,
        hierarchyid = 30,
        image = 31,
        real = 32,
        sql_variant = 33
    }
}

namespace SupermarketWeb.Data;

[AttributeUsage(AttributeTargets.Class)]
public class TableNameAttribute(string tableName) : Attribute
{
    public string TableName { get; } = tableName;
}

[AttributeUsage(AttributeTargets.Property)]
public class FieldSizeAttribute(int size) : Attribute
{
    public int Size { get; } = size;
}

[AttributeUsage(AttributeTargets.Property)]
public class BinaryFieldAttribute : Attribute { }

[AttributeUsage(AttributeTargets.Property)]
public class NullableFieldAttribute(bool nullable) : Attribute
{
    public bool Nullable { get; } = nullable;
}

[AttributeUsage(AttributeTargets.Property)]
public class PrimaryKeyAttribute : Attribute { }

[AttributeUsage(AttributeTargets.Property)]
public class EncryptedAttribute : Attribute { }

[AttributeUsage(AttributeTargets.Property)]
public class ImageAttribute : Attribute { }

[AttributeUsage(AttributeTargets.Property)]
public class ExportAttribute(string name = "") : Attribute
{
    public string Name { get; } = name;
}

using System;

namespace ClassLibrary1
{
    public class TableNameAttribute : Attribute
    {
        string _tableName = "";

        public string TableName { get => _tableName; set => _tableName = value; }

        public TableNameAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }


    public class FieldSizeAttribute : Attribute
    {
        int _Size = 0;

        public int Size { get => _Size; set => _Size = value; }

        public FieldSizeAttribute(int Size)
        {
            _Size = Size;
        }
    }

    public class BinaryFieldAttribute : Attribute
    {

    }

    public class NullableFieldAttribute : Attribute
    {
        bool _Nullable = false;

        public bool Nullable { get => _Nullable; set => _Nullable = value; }

        public NullableFieldAttribute(bool Nullable)
        {
            _Nullable = Nullable;
        }
    }

    public class PrimaryKeyAttribute : Attribute
    {

    }

    public class EncryptedAttribute : Attribute
    {

    }

    public class ImageAttribute : Attribute
    {

    }

    public class ExportAttribute : Attribute
    {
        public string name { get; set; }

        public ExportAttribute(string name = "")
        {
            this.name = name;
        }
    }

    public class UpdateExtraFieldAttribute : Attribute
    {
        string _field = "";

        public UpdateExtraFieldAttribute(string field)
        {
            this.Field = field;
        }

        public string Field { get => _field; set => _field = value; }
    }
}

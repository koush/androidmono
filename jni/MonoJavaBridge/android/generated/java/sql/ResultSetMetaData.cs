namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.ResultSetMetaData_))]
	public interface ResultSetMetaData  : global::MonoJavaBridge.IJavaObject 
	{
		bool isReadOnly(int arg0);
		global::java.lang.String getColumnName(int arg0);
		int getColumnCount();
		int getScale(int arg0);
		int getPrecision(int arg0);
		bool isWritable(int arg0);
		bool isAutoIncrement(int arg0);
		bool isCaseSensitive(int arg0);
		bool isSearchable(int arg0);
		bool isCurrency(int arg0);
		int isNullable(int arg0);
		bool isSigned(int arg0);
		int getColumnDisplaySize(int arg0);
		global::java.lang.String getColumnLabel(int arg0);
		global::java.lang.String getSchemaName(int arg0);
		global::java.lang.String getTableName(int arg0);
		global::java.lang.String getCatalogName(int arg0);
		int getColumnType(int arg0);
		global::java.lang.String getColumnTypeName(int arg0);
		bool isDefinitelyWritable(int arg0);
		global::java.lang.String getColumnClassName(int arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.ResultSetMetaData))]
	public sealed partial class ResultSetMetaData_ : java.lang.Object, ResultSetMetaData
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ResultSetMetaData_()
		{
			InitJNI();
		}
		internal ResultSetMetaData_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly24824;
		 bool java.sql.ResultSetMetaData.isReadOnly(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isReadOnly24824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._isReadOnly24824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName24825;
		 global::java.lang.String java.sql.ResultSetMetaData.getColumnName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnName24825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getColumnName24825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnCount24826;
		 int java.sql.ResultSetMetaData.getColumnCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnCount24826);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getColumnCount24826);
		}
		internal static global::MonoJavaBridge.MethodId _getScale24827;
		 int java.sql.ResultSetMetaData.getScale(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getScale24827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getScale24827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrecision24828;
		 int java.sql.ResultSetMetaData.getPrecision(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getPrecision24828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getPrecision24828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isWritable24829;
		 bool java.sql.ResultSetMetaData.isWritable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isWritable24829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._isWritable24829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAutoIncrement24830;
		 bool java.sql.ResultSetMetaData.isAutoIncrement(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isAutoIncrement24830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._isAutoIncrement24830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCaseSensitive24831;
		 bool java.sql.ResultSetMetaData.isCaseSensitive(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isCaseSensitive24831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._isCaseSensitive24831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSearchable24832;
		 bool java.sql.ResultSetMetaData.isSearchable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isSearchable24832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._isSearchable24832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCurrency24833;
		 bool java.sql.ResultSetMetaData.isCurrency(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isCurrency24833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._isCurrency24833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNullable24834;
		 int java.sql.ResultSetMetaData.isNullable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isNullable24834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._isNullable24834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSigned24835;
		 bool java.sql.ResultSetMetaData.isSigned(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isSigned24835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._isSigned24835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnDisplaySize24836;
		 int java.sql.ResultSetMetaData.getColumnDisplaySize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnDisplaySize24836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getColumnDisplaySize24836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnLabel24837;
		 global::java.lang.String java.sql.ResultSetMetaData.getColumnLabel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnLabel24837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getColumnLabel24837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemaName24838;
		 global::java.lang.String java.sql.ResultSetMetaData.getSchemaName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getSchemaName24838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getSchemaName24838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTableName24839;
		 global::java.lang.String java.sql.ResultSetMetaData.getTableName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getTableName24839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getTableName24839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCatalogName24840;
		 global::java.lang.String java.sql.ResultSetMetaData.getCatalogName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getCatalogName24840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getCatalogName24840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnType24841;
		 int java.sql.ResultSetMetaData.getColumnType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnType24841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getColumnType24841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnTypeName24842;
		 global::java.lang.String java.sql.ResultSetMetaData.getColumnTypeName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnTypeName24842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getColumnTypeName24842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefinitelyWritable24843;
		 bool java.sql.ResultSetMetaData.isDefinitelyWritable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isDefinitelyWritable24843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._isDefinitelyWritable24843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnClassName24844;
		 global::java.lang.String java.sql.ResultSetMetaData.getColumnClassName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnClassName24844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getColumnClassName24844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.ResultSetMetaData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/ResultSetMetaData"));
			global::java.sql.ResultSetMetaData_._isReadOnly24824 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isReadOnly", "(I)Z");
			global::java.sql.ResultSetMetaData_._getColumnName24825 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			global::java.sql.ResultSetMetaData_._getColumnCount24826 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnCount", "()I");
			global::java.sql.ResultSetMetaData_._getScale24827 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getScale", "(I)I");
			global::java.sql.ResultSetMetaData_._getPrecision24828 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getPrecision", "(I)I");
			global::java.sql.ResultSetMetaData_._isWritable24829 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isWritable", "(I)Z");
			global::java.sql.ResultSetMetaData_._isAutoIncrement24830 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isAutoIncrement", "(I)Z");
			global::java.sql.ResultSetMetaData_._isCaseSensitive24831 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isCaseSensitive", "(I)Z");
			global::java.sql.ResultSetMetaData_._isSearchable24832 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isSearchable", "(I)Z");
			global::java.sql.ResultSetMetaData_._isCurrency24833 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isCurrency", "(I)Z");
			global::java.sql.ResultSetMetaData_._isNullable24834 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isNullable", "(I)I");
			global::java.sql.ResultSetMetaData_._isSigned24835 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isSigned", "(I)Z");
			global::java.sql.ResultSetMetaData_._getColumnDisplaySize24836 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnDisplaySize", "(I)I");
			global::java.sql.ResultSetMetaData_._getColumnLabel24837 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnLabel", "(I)Ljava/lang/String;");
			global::java.sql.ResultSetMetaData_._getSchemaName24838 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getSchemaName", "(I)Ljava/lang/String;");
			global::java.sql.ResultSetMetaData_._getTableName24839 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getTableName", "(I)Ljava/lang/String;");
			global::java.sql.ResultSetMetaData_._getCatalogName24840 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getCatalogName", "(I)Ljava/lang/String;");
			global::java.sql.ResultSetMetaData_._getColumnType24841 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnType", "(I)I");
			global::java.sql.ResultSetMetaData_._getColumnTypeName24842 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnTypeName", "(I)Ljava/lang/String;");
			global::java.sql.ResultSetMetaData_._isDefinitelyWritable24843 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isDefinitelyWritable", "(I)Z");
			global::java.sql.ResultSetMetaData_._getColumnClassName24844 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnClassName", "(I)Ljava/lang/String;");
		}
	}
}

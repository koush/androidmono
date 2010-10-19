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
		internal static global::MonoJavaBridge.MethodId _isReadOnly19132;
		 bool java.sql.ResultSetMetaData.isReadOnly(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isReadOnly19132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._isReadOnly19132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName19133;
		 global::java.lang.String java.sql.ResultSetMetaData.getColumnName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnName19133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getColumnName19133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnCount19134;
		 int java.sql.ResultSetMetaData.getColumnCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnCount19134);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getColumnCount19134);
		}
		internal static global::MonoJavaBridge.MethodId _getScale19135;
		 int java.sql.ResultSetMetaData.getScale(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getScale19135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getScale19135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrecision19136;
		 int java.sql.ResultSetMetaData.getPrecision(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getPrecision19136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getPrecision19136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isWritable19137;
		 bool java.sql.ResultSetMetaData.isWritable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isWritable19137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._isWritable19137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAutoIncrement19138;
		 bool java.sql.ResultSetMetaData.isAutoIncrement(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isAutoIncrement19138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._isAutoIncrement19138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCaseSensitive19139;
		 bool java.sql.ResultSetMetaData.isCaseSensitive(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isCaseSensitive19139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._isCaseSensitive19139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSearchable19140;
		 bool java.sql.ResultSetMetaData.isSearchable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isSearchable19140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._isSearchable19140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCurrency19141;
		 bool java.sql.ResultSetMetaData.isCurrency(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isCurrency19141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._isCurrency19141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNullable19142;
		 int java.sql.ResultSetMetaData.isNullable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isNullable19142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._isNullable19142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSigned19143;
		 bool java.sql.ResultSetMetaData.isSigned(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isSigned19143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._isSigned19143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnDisplaySize19144;
		 int java.sql.ResultSetMetaData.getColumnDisplaySize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnDisplaySize19144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getColumnDisplaySize19144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnLabel19145;
		 global::java.lang.String java.sql.ResultSetMetaData.getColumnLabel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnLabel19145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getColumnLabel19145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemaName19146;
		 global::java.lang.String java.sql.ResultSetMetaData.getSchemaName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getSchemaName19146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getSchemaName19146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTableName19147;
		 global::java.lang.String java.sql.ResultSetMetaData.getTableName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getTableName19147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getTableName19147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCatalogName19148;
		 global::java.lang.String java.sql.ResultSetMetaData.getCatalogName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getCatalogName19148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getCatalogName19148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnType19149;
		 int java.sql.ResultSetMetaData.getColumnType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnType19149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getColumnType19149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnTypeName19150;
		 global::java.lang.String java.sql.ResultSetMetaData.getColumnTypeName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnTypeName19150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getColumnTypeName19150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefinitelyWritable19151;
		 bool java.sql.ResultSetMetaData.isDefinitelyWritable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._isDefinitelyWritable19151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._isDefinitelyWritable19151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnClassName19152;
		 global::java.lang.String java.sql.ResultSetMetaData.getColumnClassName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_._getColumnClassName19152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSetMetaData_.staticClass, global::java.sql.ResultSetMetaData_._getColumnClassName19152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.ResultSetMetaData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/ResultSetMetaData"));
			global::java.sql.ResultSetMetaData_._isReadOnly19132 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isReadOnly", "(I)Z");
			global::java.sql.ResultSetMetaData_._getColumnName19133 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			global::java.sql.ResultSetMetaData_._getColumnCount19134 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnCount", "()I");
			global::java.sql.ResultSetMetaData_._getScale19135 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getScale", "(I)I");
			global::java.sql.ResultSetMetaData_._getPrecision19136 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getPrecision", "(I)I");
			global::java.sql.ResultSetMetaData_._isWritable19137 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isWritable", "(I)Z");
			global::java.sql.ResultSetMetaData_._isAutoIncrement19138 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isAutoIncrement", "(I)Z");
			global::java.sql.ResultSetMetaData_._isCaseSensitive19139 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isCaseSensitive", "(I)Z");
			global::java.sql.ResultSetMetaData_._isSearchable19140 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isSearchable", "(I)Z");
			global::java.sql.ResultSetMetaData_._isCurrency19141 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isCurrency", "(I)Z");
			global::java.sql.ResultSetMetaData_._isNullable19142 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isNullable", "(I)I");
			global::java.sql.ResultSetMetaData_._isSigned19143 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isSigned", "(I)Z");
			global::java.sql.ResultSetMetaData_._getColumnDisplaySize19144 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnDisplaySize", "(I)I");
			global::java.sql.ResultSetMetaData_._getColumnLabel19145 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnLabel", "(I)Ljava/lang/String;");
			global::java.sql.ResultSetMetaData_._getSchemaName19146 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getSchemaName", "(I)Ljava/lang/String;");
			global::java.sql.ResultSetMetaData_._getTableName19147 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getTableName", "(I)Ljava/lang/String;");
			global::java.sql.ResultSetMetaData_._getCatalogName19148 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getCatalogName", "(I)Ljava/lang/String;");
			global::java.sql.ResultSetMetaData_._getColumnType19149 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnType", "(I)I");
			global::java.sql.ResultSetMetaData_._getColumnTypeName19150 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnTypeName", "(I)Ljava/lang/String;");
			global::java.sql.ResultSetMetaData_._isDefinitelyWritable19151 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "isDefinitelyWritable", "(I)Z");
			global::java.sql.ResultSetMetaData_._getColumnClassName19152 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSetMetaData_.staticClass, "getColumnClassName", "(I)Ljava/lang/String;");
		}
	}
}

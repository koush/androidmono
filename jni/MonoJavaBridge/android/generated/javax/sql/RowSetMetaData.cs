namespace javax.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.sql.RowSetMetaData_))]
	public interface RowSetMetaData : java.sql.ResultSetMetaData
	{
		void setScale(int arg0, int arg1);
		void setCurrency(int arg0, bool arg1);
		void setColumnCount(int arg0);
		void setAutoIncrement(int arg0, bool arg1);
		void setCaseSensitive(int arg0, bool arg1);
		void setSearchable(int arg0, bool arg1);
		void setNullable(int arg0, int arg1);
		void setSigned(int arg0, bool arg1);
		void setColumnDisplaySize(int arg0, int arg1);
		void setColumnLabel(int arg0, java.lang.String arg1);
		void setColumnName(int arg0, java.lang.String arg1);
		void setSchemaName(int arg0, java.lang.String arg1);
		void setPrecision(int arg0, int arg1);
		void setTableName(int arg0, java.lang.String arg1);
		void setCatalogName(int arg0, java.lang.String arg1);
		void setColumnType(int arg0, int arg1);
		void setColumnTypeName(int arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.sql.RowSetMetaData))]
	public sealed partial class RowSetMetaData_ : java.lang.Object, RowSetMetaData
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RowSetMetaData_()
		{
			InitJNI();
		}
		internal RowSetMetaData_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setScale24030;
		 void javax.sql.RowSetMetaData.setScale(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setScale24030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setScale24030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCurrency24031;
		 void javax.sql.RowSetMetaData.setCurrency(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setCurrency24031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setCurrency24031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnCount24032;
		 void javax.sql.RowSetMetaData.setColumnCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setColumnCount24032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setColumnCount24032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAutoIncrement24033;
		 void javax.sql.RowSetMetaData.setAutoIncrement(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setAutoIncrement24033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setAutoIncrement24033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCaseSensitive24034;
		 void javax.sql.RowSetMetaData.setCaseSensitive(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setCaseSensitive24034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setCaseSensitive24034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSearchable24035;
		 void javax.sql.RowSetMetaData.setSearchable(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setSearchable24035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setSearchable24035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNullable24036;
		 void javax.sql.RowSetMetaData.setNullable(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setNullable24036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setNullable24036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSigned24037;
		 void javax.sql.RowSetMetaData.setSigned(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setSigned24037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setSigned24037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnDisplaySize24038;
		 void javax.sql.RowSetMetaData.setColumnDisplaySize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setColumnDisplaySize24038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setColumnDisplaySize24038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnLabel24039;
		 void javax.sql.RowSetMetaData.setColumnLabel(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setColumnLabel24039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setColumnLabel24039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnName24040;
		 void javax.sql.RowSetMetaData.setColumnName(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setColumnName24040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setColumnName24040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSchemaName24041;
		 void javax.sql.RowSetMetaData.setSchemaName(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setSchemaName24041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setSchemaName24041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setPrecision24042;
		 void javax.sql.RowSetMetaData.setPrecision(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setPrecision24042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setPrecision24042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTableName24043;
		 void javax.sql.RowSetMetaData.setTableName(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setTableName24043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setTableName24043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCatalogName24044;
		 void javax.sql.RowSetMetaData.setCatalogName(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setCatalogName24044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setCatalogName24044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnType24045;
		 void javax.sql.RowSetMetaData.setColumnType(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setColumnType24045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setColumnType24045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnTypeName24046;
		 void javax.sql.RowSetMetaData.setColumnTypeName(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setColumnTypeName24046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setColumnTypeName24046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly24047;
		 bool java.sql.ResultSetMetaData.isReadOnly(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isReadOnly24047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isReadOnly24047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName24048;
		 global::java.lang.String java.sql.ResultSetMetaData.getColumnName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnName24048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnName24048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnCount24049;
		 int java.sql.ResultSetMetaData.getColumnCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnCount24049);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnCount24049);
		}
		internal static global::MonoJavaBridge.MethodId _getScale24050;
		 int java.sql.ResultSetMetaData.getScale(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getScale24050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getScale24050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrecision24051;
		 int java.sql.ResultSetMetaData.getPrecision(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getPrecision24051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getPrecision24051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isWritable24052;
		 bool java.sql.ResultSetMetaData.isWritable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isWritable24052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isWritable24052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAutoIncrement24053;
		 bool java.sql.ResultSetMetaData.isAutoIncrement(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isAutoIncrement24053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isAutoIncrement24053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCaseSensitive24054;
		 bool java.sql.ResultSetMetaData.isCaseSensitive(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isCaseSensitive24054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isCaseSensitive24054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSearchable24055;
		 bool java.sql.ResultSetMetaData.isSearchable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isSearchable24055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isSearchable24055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCurrency24056;
		 bool java.sql.ResultSetMetaData.isCurrency(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isCurrency24056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isCurrency24056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNullable24057;
		 int java.sql.ResultSetMetaData.isNullable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isNullable24057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isNullable24057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSigned24058;
		 bool java.sql.ResultSetMetaData.isSigned(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isSigned24058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isSigned24058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnDisplaySize24059;
		 int java.sql.ResultSetMetaData.getColumnDisplaySize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnDisplaySize24059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnDisplaySize24059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnLabel24060;
		 global::java.lang.String java.sql.ResultSetMetaData.getColumnLabel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnLabel24060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnLabel24060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemaName24061;
		 global::java.lang.String java.sql.ResultSetMetaData.getSchemaName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getSchemaName24061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getSchemaName24061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTableName24062;
		 global::java.lang.String java.sql.ResultSetMetaData.getTableName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getTableName24062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getTableName24062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCatalogName24063;
		 global::java.lang.String java.sql.ResultSetMetaData.getCatalogName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getCatalogName24063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getCatalogName24063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnType24064;
		 int java.sql.ResultSetMetaData.getColumnType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnType24064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnType24064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnTypeName24065;
		 global::java.lang.String java.sql.ResultSetMetaData.getColumnTypeName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnTypeName24065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnTypeName24065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefinitelyWritable24066;
		 bool java.sql.ResultSetMetaData.isDefinitelyWritable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isDefinitelyWritable24066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isDefinitelyWritable24066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnClassName24067;
		 global::java.lang.String java.sql.ResultSetMetaData.getColumnClassName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnClassName24067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnClassName24067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.RowSetMetaData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/RowSetMetaData"));
			global::javax.sql.RowSetMetaData_._setScale24030 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setScale", "(II)V");
			global::javax.sql.RowSetMetaData_._setCurrency24031 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setCurrency", "(IZ)V");
			global::javax.sql.RowSetMetaData_._setColumnCount24032 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setColumnCount", "(I)V");
			global::javax.sql.RowSetMetaData_._setAutoIncrement24033 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setAutoIncrement", "(IZ)V");
			global::javax.sql.RowSetMetaData_._setCaseSensitive24034 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setCaseSensitive", "(IZ)V");
			global::javax.sql.RowSetMetaData_._setSearchable24035 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setSearchable", "(IZ)V");
			global::javax.sql.RowSetMetaData_._setNullable24036 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setNullable", "(II)V");
			global::javax.sql.RowSetMetaData_._setSigned24037 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setSigned", "(IZ)V");
			global::javax.sql.RowSetMetaData_._setColumnDisplaySize24038 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setColumnDisplaySize", "(II)V");
			global::javax.sql.RowSetMetaData_._setColumnLabel24039 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setColumnLabel", "(ILjava/lang/String;)V");
			global::javax.sql.RowSetMetaData_._setColumnName24040 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setColumnName", "(ILjava/lang/String;)V");
			global::javax.sql.RowSetMetaData_._setSchemaName24041 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setSchemaName", "(ILjava/lang/String;)V");
			global::javax.sql.RowSetMetaData_._setPrecision24042 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setPrecision", "(II)V");
			global::javax.sql.RowSetMetaData_._setTableName24043 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setTableName", "(ILjava/lang/String;)V");
			global::javax.sql.RowSetMetaData_._setCatalogName24044 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setCatalogName", "(ILjava/lang/String;)V");
			global::javax.sql.RowSetMetaData_._setColumnType24045 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setColumnType", "(II)V");
			global::javax.sql.RowSetMetaData_._setColumnTypeName24046 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setColumnTypeName", "(ILjava/lang/String;)V");
			global::javax.sql.RowSetMetaData_._isReadOnly24047 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isReadOnly", "(I)Z");
			global::javax.sql.RowSetMetaData_._getColumnName24048 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			global::javax.sql.RowSetMetaData_._getColumnCount24049 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnCount", "()I");
			global::javax.sql.RowSetMetaData_._getScale24050 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getScale", "(I)I");
			global::javax.sql.RowSetMetaData_._getPrecision24051 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getPrecision", "(I)I");
			global::javax.sql.RowSetMetaData_._isWritable24052 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isWritable", "(I)Z");
			global::javax.sql.RowSetMetaData_._isAutoIncrement24053 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isAutoIncrement", "(I)Z");
			global::javax.sql.RowSetMetaData_._isCaseSensitive24054 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isCaseSensitive", "(I)Z");
			global::javax.sql.RowSetMetaData_._isSearchable24055 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isSearchable", "(I)Z");
			global::javax.sql.RowSetMetaData_._isCurrency24056 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isCurrency", "(I)Z");
			global::javax.sql.RowSetMetaData_._isNullable24057 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isNullable", "(I)I");
			global::javax.sql.RowSetMetaData_._isSigned24058 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isSigned", "(I)Z");
			global::javax.sql.RowSetMetaData_._getColumnDisplaySize24059 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnDisplaySize", "(I)I");
			global::javax.sql.RowSetMetaData_._getColumnLabel24060 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnLabel", "(I)Ljava/lang/String;");
			global::javax.sql.RowSetMetaData_._getSchemaName24061 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getSchemaName", "(I)Ljava/lang/String;");
			global::javax.sql.RowSetMetaData_._getTableName24062 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getTableName", "(I)Ljava/lang/String;");
			global::javax.sql.RowSetMetaData_._getCatalogName24063 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getCatalogName", "(I)Ljava/lang/String;");
			global::javax.sql.RowSetMetaData_._getColumnType24064 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnType", "(I)I");
			global::javax.sql.RowSetMetaData_._getColumnTypeName24065 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnTypeName", "(I)Ljava/lang/String;");
			global::javax.sql.RowSetMetaData_._isDefinitelyWritable24066 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isDefinitelyWritable", "(I)Z");
			global::javax.sql.RowSetMetaData_._getColumnClassName24067 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnClassName", "(I)Ljava/lang/String;");
		}
	}
}

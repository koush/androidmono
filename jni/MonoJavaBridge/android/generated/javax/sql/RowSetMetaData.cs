namespace javax.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.sql.RowSetMetaData_))]
	public partial interface RowSetMetaData : java.sql.ResultSetMetaData
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
		internal static global::MonoJavaBridge.MethodId _setScale30464;
		 void javax.sql.RowSetMetaData.setScale(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setScale30464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setScale30464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCurrency30465;
		 void javax.sql.RowSetMetaData.setCurrency(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setCurrency30465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setCurrency30465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnCount30466;
		 void javax.sql.RowSetMetaData.setColumnCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setColumnCount30466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setColumnCount30466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAutoIncrement30467;
		 void javax.sql.RowSetMetaData.setAutoIncrement(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setAutoIncrement30467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setAutoIncrement30467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCaseSensitive30468;
		 void javax.sql.RowSetMetaData.setCaseSensitive(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setCaseSensitive30468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setCaseSensitive30468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSearchable30469;
		 void javax.sql.RowSetMetaData.setSearchable(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setSearchable30469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setSearchable30469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNullable30470;
		 void javax.sql.RowSetMetaData.setNullable(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setNullable30470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setNullable30470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSigned30471;
		 void javax.sql.RowSetMetaData.setSigned(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setSigned30471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setSigned30471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnDisplaySize30472;
		 void javax.sql.RowSetMetaData.setColumnDisplaySize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setColumnDisplaySize30472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setColumnDisplaySize30472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnLabel30473;
		 void javax.sql.RowSetMetaData.setColumnLabel(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setColumnLabel30473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setColumnLabel30473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnName30474;
		 void javax.sql.RowSetMetaData.setColumnName(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setColumnName30474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setColumnName30474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSchemaName30475;
		 void javax.sql.RowSetMetaData.setSchemaName(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setSchemaName30475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setSchemaName30475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setPrecision30476;
		 void javax.sql.RowSetMetaData.setPrecision(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setPrecision30476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setPrecision30476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTableName30477;
		 void javax.sql.RowSetMetaData.setTableName(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setTableName30477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setTableName30477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCatalogName30478;
		 void javax.sql.RowSetMetaData.setCatalogName(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setCatalogName30478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setCatalogName30478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnType30479;
		 void javax.sql.RowSetMetaData.setColumnType(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setColumnType30479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setColumnType30479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnTypeName30480;
		 void javax.sql.RowSetMetaData.setColumnTypeName(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setColumnTypeName30480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setColumnTypeName30480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly30481;
		 bool java.sql.ResultSetMetaData.isReadOnly(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isReadOnly30481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isReadOnly30481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName30482;
		 global::java.lang.String java.sql.ResultSetMetaData.getColumnName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnName30482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnName30482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnCount30483;
		 int java.sql.ResultSetMetaData.getColumnCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnCount30483);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnCount30483);
		}
		internal static global::MonoJavaBridge.MethodId _getScale30484;
		 int java.sql.ResultSetMetaData.getScale(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getScale30484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getScale30484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrecision30485;
		 int java.sql.ResultSetMetaData.getPrecision(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getPrecision30485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getPrecision30485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isWritable30486;
		 bool java.sql.ResultSetMetaData.isWritable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isWritable30486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isWritable30486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAutoIncrement30487;
		 bool java.sql.ResultSetMetaData.isAutoIncrement(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isAutoIncrement30487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isAutoIncrement30487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCaseSensitive30488;
		 bool java.sql.ResultSetMetaData.isCaseSensitive(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isCaseSensitive30488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isCaseSensitive30488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSearchable30489;
		 bool java.sql.ResultSetMetaData.isSearchable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isSearchable30489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isSearchable30489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCurrency30490;
		 bool java.sql.ResultSetMetaData.isCurrency(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isCurrency30490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isCurrency30490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNullable30491;
		 int java.sql.ResultSetMetaData.isNullable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isNullable30491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isNullable30491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSigned30492;
		 bool java.sql.ResultSetMetaData.isSigned(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isSigned30492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isSigned30492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnDisplaySize30493;
		 int java.sql.ResultSetMetaData.getColumnDisplaySize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnDisplaySize30493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnDisplaySize30493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnLabel30494;
		 global::java.lang.String java.sql.ResultSetMetaData.getColumnLabel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnLabel30494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnLabel30494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemaName30495;
		 global::java.lang.String java.sql.ResultSetMetaData.getSchemaName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getSchemaName30495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getSchemaName30495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTableName30496;
		 global::java.lang.String java.sql.ResultSetMetaData.getTableName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getTableName30496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getTableName30496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCatalogName30497;
		 global::java.lang.String java.sql.ResultSetMetaData.getCatalogName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getCatalogName30497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getCatalogName30497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnType30498;
		 int java.sql.ResultSetMetaData.getColumnType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnType30498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnType30498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnTypeName30499;
		 global::java.lang.String java.sql.ResultSetMetaData.getColumnTypeName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnTypeName30499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnTypeName30499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefinitelyWritable30500;
		 bool java.sql.ResultSetMetaData.isDefinitelyWritable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isDefinitelyWritable30500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isDefinitelyWritable30500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnClassName30501;
		 global::java.lang.String java.sql.ResultSetMetaData.getColumnClassName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnClassName30501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnClassName30501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.RowSetMetaData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/RowSetMetaData"));
			global::javax.sql.RowSetMetaData_._setScale30464 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setScale", "(II)V");
			global::javax.sql.RowSetMetaData_._setCurrency30465 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setCurrency", "(IZ)V");
			global::javax.sql.RowSetMetaData_._setColumnCount30466 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setColumnCount", "(I)V");
			global::javax.sql.RowSetMetaData_._setAutoIncrement30467 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setAutoIncrement", "(IZ)V");
			global::javax.sql.RowSetMetaData_._setCaseSensitive30468 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setCaseSensitive", "(IZ)V");
			global::javax.sql.RowSetMetaData_._setSearchable30469 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setSearchable", "(IZ)V");
			global::javax.sql.RowSetMetaData_._setNullable30470 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setNullable", "(II)V");
			global::javax.sql.RowSetMetaData_._setSigned30471 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setSigned", "(IZ)V");
			global::javax.sql.RowSetMetaData_._setColumnDisplaySize30472 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setColumnDisplaySize", "(II)V");
			global::javax.sql.RowSetMetaData_._setColumnLabel30473 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setColumnLabel", "(ILjava/lang/String;)V");
			global::javax.sql.RowSetMetaData_._setColumnName30474 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setColumnName", "(ILjava/lang/String;)V");
			global::javax.sql.RowSetMetaData_._setSchemaName30475 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setSchemaName", "(ILjava/lang/String;)V");
			global::javax.sql.RowSetMetaData_._setPrecision30476 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setPrecision", "(II)V");
			global::javax.sql.RowSetMetaData_._setTableName30477 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setTableName", "(ILjava/lang/String;)V");
			global::javax.sql.RowSetMetaData_._setCatalogName30478 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setCatalogName", "(ILjava/lang/String;)V");
			global::javax.sql.RowSetMetaData_._setColumnType30479 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setColumnType", "(II)V");
			global::javax.sql.RowSetMetaData_._setColumnTypeName30480 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setColumnTypeName", "(ILjava/lang/String;)V");
			global::javax.sql.RowSetMetaData_._isReadOnly30481 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isReadOnly", "(I)Z");
			global::javax.sql.RowSetMetaData_._getColumnName30482 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			global::javax.sql.RowSetMetaData_._getColumnCount30483 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnCount", "()I");
			global::javax.sql.RowSetMetaData_._getScale30484 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getScale", "(I)I");
			global::javax.sql.RowSetMetaData_._getPrecision30485 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getPrecision", "(I)I");
			global::javax.sql.RowSetMetaData_._isWritable30486 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isWritable", "(I)Z");
			global::javax.sql.RowSetMetaData_._isAutoIncrement30487 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isAutoIncrement", "(I)Z");
			global::javax.sql.RowSetMetaData_._isCaseSensitive30488 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isCaseSensitive", "(I)Z");
			global::javax.sql.RowSetMetaData_._isSearchable30489 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isSearchable", "(I)Z");
			global::javax.sql.RowSetMetaData_._isCurrency30490 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isCurrency", "(I)Z");
			global::javax.sql.RowSetMetaData_._isNullable30491 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isNullable", "(I)I");
			global::javax.sql.RowSetMetaData_._isSigned30492 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isSigned", "(I)Z");
			global::javax.sql.RowSetMetaData_._getColumnDisplaySize30493 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnDisplaySize", "(I)I");
			global::javax.sql.RowSetMetaData_._getColumnLabel30494 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnLabel", "(I)Ljava/lang/String;");
			global::javax.sql.RowSetMetaData_._getSchemaName30495 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getSchemaName", "(I)Ljava/lang/String;");
			global::javax.sql.RowSetMetaData_._getTableName30496 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getTableName", "(I)Ljava/lang/String;");
			global::javax.sql.RowSetMetaData_._getCatalogName30497 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getCatalogName", "(I)Ljava/lang/String;");
			global::javax.sql.RowSetMetaData_._getColumnType30498 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnType", "(I)I");
			global::javax.sql.RowSetMetaData_._getColumnTypeName30499 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnTypeName", "(I)Ljava/lang/String;");
			global::javax.sql.RowSetMetaData_._isDefinitelyWritable30500 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isDefinitelyWritable", "(I)Z");
			global::javax.sql.RowSetMetaData_._getColumnClassName30501 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnClassName", "(I)Ljava/lang/String;");
		}
	}
}

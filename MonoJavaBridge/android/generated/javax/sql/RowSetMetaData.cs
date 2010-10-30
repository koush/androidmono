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
	internal sealed partial class RowSetMetaData_ : java.lang.Object, RowSetMetaData
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RowSetMetaData_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setScale30583;
		void javax.sql.RowSetMetaData.setScale(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setScale", "(II)V", ref global::javax.sql.RowSetMetaData_._setScale30583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCurrency30584;
		void javax.sql.RowSetMetaData.setCurrency(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setCurrency", "(IZ)V", ref global::javax.sql.RowSetMetaData_._setCurrency30584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnCount30585;
		void javax.sql.RowSetMetaData.setColumnCount(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setColumnCount", "(I)V", ref global::javax.sql.RowSetMetaData_._setColumnCount30585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAutoIncrement30586;
		void javax.sql.RowSetMetaData.setAutoIncrement(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setAutoIncrement", "(IZ)V", ref global::javax.sql.RowSetMetaData_._setAutoIncrement30586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCaseSensitive30587;
		void javax.sql.RowSetMetaData.setCaseSensitive(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setCaseSensitive", "(IZ)V", ref global::javax.sql.RowSetMetaData_._setCaseSensitive30587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSearchable30588;
		void javax.sql.RowSetMetaData.setSearchable(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setSearchable", "(IZ)V", ref global::javax.sql.RowSetMetaData_._setSearchable30588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNullable30589;
		void javax.sql.RowSetMetaData.setNullable(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setNullable", "(II)V", ref global::javax.sql.RowSetMetaData_._setNullable30589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSigned30590;
		void javax.sql.RowSetMetaData.setSigned(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setSigned", "(IZ)V", ref global::javax.sql.RowSetMetaData_._setSigned30590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnDisplaySize30591;
		void javax.sql.RowSetMetaData.setColumnDisplaySize(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setColumnDisplaySize", "(II)V", ref global::javax.sql.RowSetMetaData_._setColumnDisplaySize30591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnLabel30592;
		void javax.sql.RowSetMetaData.setColumnLabel(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setColumnLabel", "(ILjava/lang/String;)V", ref global::javax.sql.RowSetMetaData_._setColumnLabel30592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnName30593;
		void javax.sql.RowSetMetaData.setColumnName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setColumnName", "(ILjava/lang/String;)V", ref global::javax.sql.RowSetMetaData_._setColumnName30593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSchemaName30594;
		void javax.sql.RowSetMetaData.setSchemaName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setSchemaName", "(ILjava/lang/String;)V", ref global::javax.sql.RowSetMetaData_._setSchemaName30594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setPrecision30595;
		void javax.sql.RowSetMetaData.setPrecision(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setPrecision", "(II)V", ref global::javax.sql.RowSetMetaData_._setPrecision30595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTableName30596;
		void javax.sql.RowSetMetaData.setTableName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setTableName", "(ILjava/lang/String;)V", ref global::javax.sql.RowSetMetaData_._setTableName30596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCatalogName30597;
		void javax.sql.RowSetMetaData.setCatalogName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setCatalogName", "(ILjava/lang/String;)V", ref global::javax.sql.RowSetMetaData_._setCatalogName30597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnType30598;
		void javax.sql.RowSetMetaData.setColumnType(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setColumnType", "(II)V", ref global::javax.sql.RowSetMetaData_._setColumnType30598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnTypeName30599;
		void javax.sql.RowSetMetaData.setColumnTypeName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setColumnTypeName", "(ILjava/lang/String;)V", ref global::javax.sql.RowSetMetaData_._setColumnTypeName30599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly30600;
		bool java.sql.ResultSetMetaData.isReadOnly(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "isReadOnly", "(I)Z", ref global::javax.sql.RowSetMetaData_._isReadOnly30600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName30601;
		global::java.lang.String java.sql.ResultSetMetaData.getColumnName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSetMetaData_.staticClass, "getColumnName", "(I)Ljava/lang/String;", ref global::javax.sql.RowSetMetaData_._getColumnName30601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnCount30602;
		int java.sql.ResultSetMetaData.getColumnCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "getColumnCount", "()I", ref global::javax.sql.RowSetMetaData_._getColumnCount30602);
		}
		internal static global::MonoJavaBridge.MethodId _getScale30603;
		int java.sql.ResultSetMetaData.getScale(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "getScale", "(I)I", ref global::javax.sql.RowSetMetaData_._getScale30603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrecision30604;
		int java.sql.ResultSetMetaData.getPrecision(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "getPrecision", "(I)I", ref global::javax.sql.RowSetMetaData_._getPrecision30604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isWritable30605;
		bool java.sql.ResultSetMetaData.isWritable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "isWritable", "(I)Z", ref global::javax.sql.RowSetMetaData_._isWritable30605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAutoIncrement30606;
		bool java.sql.ResultSetMetaData.isAutoIncrement(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "isAutoIncrement", "(I)Z", ref global::javax.sql.RowSetMetaData_._isAutoIncrement30606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCaseSensitive30607;
		bool java.sql.ResultSetMetaData.isCaseSensitive(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "isCaseSensitive", "(I)Z", ref global::javax.sql.RowSetMetaData_._isCaseSensitive30607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSearchable30608;
		bool java.sql.ResultSetMetaData.isSearchable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "isSearchable", "(I)Z", ref global::javax.sql.RowSetMetaData_._isSearchable30608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCurrency30609;
		bool java.sql.ResultSetMetaData.isCurrency(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "isCurrency", "(I)Z", ref global::javax.sql.RowSetMetaData_._isCurrency30609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNullable30610;
		int java.sql.ResultSetMetaData.isNullable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "isNullable", "(I)I", ref global::javax.sql.RowSetMetaData_._isNullable30610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSigned30611;
		bool java.sql.ResultSetMetaData.isSigned(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "isSigned", "(I)Z", ref global::javax.sql.RowSetMetaData_._isSigned30611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnDisplaySize30612;
		int java.sql.ResultSetMetaData.getColumnDisplaySize(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "getColumnDisplaySize", "(I)I", ref global::javax.sql.RowSetMetaData_._getColumnDisplaySize30612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnLabel30613;
		global::java.lang.String java.sql.ResultSetMetaData.getColumnLabel(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSetMetaData_.staticClass, "getColumnLabel", "(I)Ljava/lang/String;", ref global::javax.sql.RowSetMetaData_._getColumnLabel30613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemaName30614;
		global::java.lang.String java.sql.ResultSetMetaData.getSchemaName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSetMetaData_.staticClass, "getSchemaName", "(I)Ljava/lang/String;", ref global::javax.sql.RowSetMetaData_._getSchemaName30614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTableName30615;
		global::java.lang.String java.sql.ResultSetMetaData.getTableName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSetMetaData_.staticClass, "getTableName", "(I)Ljava/lang/String;", ref global::javax.sql.RowSetMetaData_._getTableName30615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCatalogName30616;
		global::java.lang.String java.sql.ResultSetMetaData.getCatalogName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSetMetaData_.staticClass, "getCatalogName", "(I)Ljava/lang/String;", ref global::javax.sql.RowSetMetaData_._getCatalogName30616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnType30617;
		int java.sql.ResultSetMetaData.getColumnType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "getColumnType", "(I)I", ref global::javax.sql.RowSetMetaData_._getColumnType30617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnTypeName30618;
		global::java.lang.String java.sql.ResultSetMetaData.getColumnTypeName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSetMetaData_.staticClass, "getColumnTypeName", "(I)Ljava/lang/String;", ref global::javax.sql.RowSetMetaData_._getColumnTypeName30618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefinitelyWritable30619;
		bool java.sql.ResultSetMetaData.isDefinitelyWritable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "isDefinitelyWritable", "(I)Z", ref global::javax.sql.RowSetMetaData_._isDefinitelyWritable30619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnClassName30620;
		global::java.lang.String java.sql.ResultSetMetaData.getColumnClassName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSetMetaData_.staticClass, "getColumnClassName", "(I)Ljava/lang/String;", ref global::javax.sql.RowSetMetaData_._getColumnClassName30620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		static RowSetMetaData_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.RowSetMetaData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/RowSetMetaData"));
		}
		internal static void InitJNI()
		{
		}
	}
}

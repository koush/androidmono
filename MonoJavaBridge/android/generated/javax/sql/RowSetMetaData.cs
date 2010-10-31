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
		private static global::MonoJavaBridge.MethodId _m0;
		void javax.sql.RowSetMetaData.setScale(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setScale", "(II)V", ref global::javax.sql.RowSetMetaData_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void javax.sql.RowSetMetaData.setCurrency(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setCurrency", "(IZ)V", ref global::javax.sql.RowSetMetaData_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void javax.sql.RowSetMetaData.setColumnCount(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setColumnCount", "(I)V", ref global::javax.sql.RowSetMetaData_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void javax.sql.RowSetMetaData.setAutoIncrement(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setAutoIncrement", "(IZ)V", ref global::javax.sql.RowSetMetaData_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void javax.sql.RowSetMetaData.setCaseSensitive(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setCaseSensitive", "(IZ)V", ref global::javax.sql.RowSetMetaData_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void javax.sql.RowSetMetaData.setSearchable(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setSearchable", "(IZ)V", ref global::javax.sql.RowSetMetaData_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void javax.sql.RowSetMetaData.setNullable(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setNullable", "(II)V", ref global::javax.sql.RowSetMetaData_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void javax.sql.RowSetMetaData.setSigned(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setSigned", "(IZ)V", ref global::javax.sql.RowSetMetaData_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void javax.sql.RowSetMetaData.setColumnDisplaySize(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setColumnDisplaySize", "(II)V", ref global::javax.sql.RowSetMetaData_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void javax.sql.RowSetMetaData.setColumnLabel(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setColumnLabel", "(ILjava/lang/String;)V", ref global::javax.sql.RowSetMetaData_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		void javax.sql.RowSetMetaData.setColumnName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setColumnName", "(ILjava/lang/String;)V", ref global::javax.sql.RowSetMetaData_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void javax.sql.RowSetMetaData.setSchemaName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setSchemaName", "(ILjava/lang/String;)V", ref global::javax.sql.RowSetMetaData_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void javax.sql.RowSetMetaData.setPrecision(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setPrecision", "(II)V", ref global::javax.sql.RowSetMetaData_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		void javax.sql.RowSetMetaData.setTableName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setTableName", "(ILjava/lang/String;)V", ref global::javax.sql.RowSetMetaData_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		void javax.sql.RowSetMetaData.setCatalogName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setCatalogName", "(ILjava/lang/String;)V", ref global::javax.sql.RowSetMetaData_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		void javax.sql.RowSetMetaData.setColumnType(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setColumnType", "(II)V", ref global::javax.sql.RowSetMetaData_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		void javax.sql.RowSetMetaData.setColumnTypeName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "setColumnTypeName", "(ILjava/lang/String;)V", ref global::javax.sql.RowSetMetaData_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		bool java.sql.ResultSetMetaData.isReadOnly(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "isReadOnly", "(I)Z", ref global::javax.sql.RowSetMetaData_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		global::java.lang.String java.sql.ResultSetMetaData.getColumnName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSetMetaData_.staticClass, "getColumnName", "(I)Ljava/lang/String;", ref global::javax.sql.RowSetMetaData_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		int java.sql.ResultSetMetaData.getColumnCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "getColumnCount", "()I", ref global::javax.sql.RowSetMetaData_._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		int java.sql.ResultSetMetaData.getScale(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "getScale", "(I)I", ref global::javax.sql.RowSetMetaData_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		int java.sql.ResultSetMetaData.getPrecision(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "getPrecision", "(I)I", ref global::javax.sql.RowSetMetaData_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		bool java.sql.ResultSetMetaData.isWritable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "isWritable", "(I)Z", ref global::javax.sql.RowSetMetaData_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		bool java.sql.ResultSetMetaData.isAutoIncrement(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "isAutoIncrement", "(I)Z", ref global::javax.sql.RowSetMetaData_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		bool java.sql.ResultSetMetaData.isCaseSensitive(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "isCaseSensitive", "(I)Z", ref global::javax.sql.RowSetMetaData_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		bool java.sql.ResultSetMetaData.isSearchable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "isSearchable", "(I)Z", ref global::javax.sql.RowSetMetaData_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		bool java.sql.ResultSetMetaData.isCurrency(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "isCurrency", "(I)Z", ref global::javax.sql.RowSetMetaData_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		int java.sql.ResultSetMetaData.isNullable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "isNullable", "(I)I", ref global::javax.sql.RowSetMetaData_._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		bool java.sql.ResultSetMetaData.isSigned(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "isSigned", "(I)Z", ref global::javax.sql.RowSetMetaData_._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		int java.sql.ResultSetMetaData.getColumnDisplaySize(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "getColumnDisplaySize", "(I)I", ref global::javax.sql.RowSetMetaData_._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		global::java.lang.String java.sql.ResultSetMetaData.getColumnLabel(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSetMetaData_.staticClass, "getColumnLabel", "(I)Ljava/lang/String;", ref global::javax.sql.RowSetMetaData_._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		global::java.lang.String java.sql.ResultSetMetaData.getSchemaName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSetMetaData_.staticClass, "getSchemaName", "(I)Ljava/lang/String;", ref global::javax.sql.RowSetMetaData_._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		global::java.lang.String java.sql.ResultSetMetaData.getTableName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSetMetaData_.staticClass, "getTableName", "(I)Ljava/lang/String;", ref global::javax.sql.RowSetMetaData_._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		global::java.lang.String java.sql.ResultSetMetaData.getCatalogName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSetMetaData_.staticClass, "getCatalogName", "(I)Ljava/lang/String;", ref global::javax.sql.RowSetMetaData_._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		int java.sql.ResultSetMetaData.getColumnType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "getColumnType", "(I)I", ref global::javax.sql.RowSetMetaData_._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		global::java.lang.String java.sql.ResultSetMetaData.getColumnTypeName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSetMetaData_.staticClass, "getColumnTypeName", "(I)Ljava/lang/String;", ref global::javax.sql.RowSetMetaData_._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		bool java.sql.ResultSetMetaData.isDefinitelyWritable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSetMetaData_.staticClass, "isDefinitelyWritable", "(I)Z", ref global::javax.sql.RowSetMetaData_._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		global::java.lang.String java.sql.ResultSetMetaData.getColumnClassName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSetMetaData_.staticClass, "getColumnClassName", "(I)Ljava/lang/String;", ref global::javax.sql.RowSetMetaData_._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		static RowSetMetaData_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.RowSetMetaData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/RowSetMetaData"));
		}
	}
}

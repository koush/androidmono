namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.ResultSetMetaData_))]
	public partial interface ResultSetMetaData  : global::MonoJavaBridge.IJavaObject 
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
	internal sealed partial class ResultSetMetaData_ : java.lang.Object, ResultSetMetaData
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ResultSetMetaData_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool java.sql.ResultSetMetaData.isReadOnly(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSetMetaData_.staticClass, "isReadOnly", "(I)Z", ref global::java.sql.ResultSetMetaData_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String java.sql.ResultSetMetaData.getColumnName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.ResultSetMetaData_.staticClass, "getColumnName", "(I)Ljava/lang/String;", ref global::java.sql.ResultSetMetaData_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		int java.sql.ResultSetMetaData.getColumnCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ResultSetMetaData_.staticClass, "getColumnCount", "()I", ref global::java.sql.ResultSetMetaData_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		int java.sql.ResultSetMetaData.getScale(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ResultSetMetaData_.staticClass, "getScale", "(I)I", ref global::java.sql.ResultSetMetaData_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		int java.sql.ResultSetMetaData.getPrecision(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ResultSetMetaData_.staticClass, "getPrecision", "(I)I", ref global::java.sql.ResultSetMetaData_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		bool java.sql.ResultSetMetaData.isWritable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSetMetaData_.staticClass, "isWritable", "(I)Z", ref global::java.sql.ResultSetMetaData_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		bool java.sql.ResultSetMetaData.isAutoIncrement(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSetMetaData_.staticClass, "isAutoIncrement", "(I)Z", ref global::java.sql.ResultSetMetaData_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		bool java.sql.ResultSetMetaData.isCaseSensitive(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSetMetaData_.staticClass, "isCaseSensitive", "(I)Z", ref global::java.sql.ResultSetMetaData_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		bool java.sql.ResultSetMetaData.isSearchable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSetMetaData_.staticClass, "isSearchable", "(I)Z", ref global::java.sql.ResultSetMetaData_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		bool java.sql.ResultSetMetaData.isCurrency(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSetMetaData_.staticClass, "isCurrency", "(I)Z", ref global::java.sql.ResultSetMetaData_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		int java.sql.ResultSetMetaData.isNullable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ResultSetMetaData_.staticClass, "isNullable", "(I)I", ref global::java.sql.ResultSetMetaData_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		bool java.sql.ResultSetMetaData.isSigned(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSetMetaData_.staticClass, "isSigned", "(I)Z", ref global::java.sql.ResultSetMetaData_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		int java.sql.ResultSetMetaData.getColumnDisplaySize(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ResultSetMetaData_.staticClass, "getColumnDisplaySize", "(I)I", ref global::java.sql.ResultSetMetaData_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		global::java.lang.String java.sql.ResultSetMetaData.getColumnLabel(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.ResultSetMetaData_.staticClass, "getColumnLabel", "(I)Ljava/lang/String;", ref global::java.sql.ResultSetMetaData_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		global::java.lang.String java.sql.ResultSetMetaData.getSchemaName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.ResultSetMetaData_.staticClass, "getSchemaName", "(I)Ljava/lang/String;", ref global::java.sql.ResultSetMetaData_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		global::java.lang.String java.sql.ResultSetMetaData.getTableName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.ResultSetMetaData_.staticClass, "getTableName", "(I)Ljava/lang/String;", ref global::java.sql.ResultSetMetaData_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		global::java.lang.String java.sql.ResultSetMetaData.getCatalogName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.ResultSetMetaData_.staticClass, "getCatalogName", "(I)Ljava/lang/String;", ref global::java.sql.ResultSetMetaData_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		int java.sql.ResultSetMetaData.getColumnType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ResultSetMetaData_.staticClass, "getColumnType", "(I)I", ref global::java.sql.ResultSetMetaData_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		global::java.lang.String java.sql.ResultSetMetaData.getColumnTypeName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.ResultSetMetaData_.staticClass, "getColumnTypeName", "(I)Ljava/lang/String;", ref global::java.sql.ResultSetMetaData_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		bool java.sql.ResultSetMetaData.isDefinitelyWritable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSetMetaData_.staticClass, "isDefinitelyWritable", "(I)Z", ref global::java.sql.ResultSetMetaData_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		global::java.lang.String java.sql.ResultSetMetaData.getColumnClassName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.ResultSetMetaData_.staticClass, "getColumnClassName", "(I)Ljava/lang/String;", ref global::java.sql.ResultSetMetaData_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		static ResultSetMetaData_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.ResultSetMetaData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/ResultSetMetaData"));
		}
		internal static void InitJNI()
		{
		}
	}
}

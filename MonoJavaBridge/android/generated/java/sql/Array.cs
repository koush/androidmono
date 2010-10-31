namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.Array_))]
	public partial interface Array  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object getArray(long arg0, int arg1);
		global::java.lang.Object getArray(long arg0, int arg1, java.util.Map arg2);
		global::java.lang.Object getArray();
		global::java.lang.Object getArray(java.util.Map arg0);
		global::java.lang.String getBaseTypeName();
		int getBaseType();
		global::java.sql.ResultSet getResultSet();
		global::java.sql.ResultSet getResultSet(java.util.Map arg0);
		global::java.sql.ResultSet getResultSet(long arg0, int arg1);
		global::java.sql.ResultSet getResultSet(long arg0, int arg1, java.util.Map arg2);
		void free();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.Array))]
	internal sealed partial class Array_ : java.lang.Object, Array
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Array_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object java.sql.Array.getArray(long arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.Array_.staticClass, "getArray", "(JI)Ljava/lang/Object;", ref global::java.sql.Array_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.Object java.sql.Array.getArray(long arg0, int arg1, java.util.Map arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.Array_.staticClass, "getArray", "(JILjava/util/Map;)Ljava/lang/Object;", ref global::java.sql.Array_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.Object java.sql.Array.getArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.Array_.staticClass, "getArray", "()Ljava/lang/Object;", ref global::java.sql.Array_._m2) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.Object java.sql.Array.getArray(java.util.Map arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.Array_.staticClass, "getArray", "(Ljava/util/Map;)Ljava/lang/Object;", ref global::java.sql.Array_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.lang.String java.sql.Array.getBaseTypeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.Array_.staticClass, "getBaseTypeName", "()Ljava/lang/String;", ref global::java.sql.Array_._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		int java.sql.Array.getBaseType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Array_.staticClass, "getBaseType", "()I", ref global::java.sql.Array_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::java.sql.ResultSet java.sql.Array.getResultSet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.Array_.staticClass, "getResultSet", "()Ljava/sql/ResultSet;", ref global::java.sql.Array_._m6) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::java.sql.ResultSet java.sql.Array.getResultSet(java.util.Map arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.Array_.staticClass, "getResultSet", "(Ljava/util/Map;)Ljava/sql/ResultSet;", ref global::java.sql.Array_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::java.sql.ResultSet java.sql.Array.getResultSet(long arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.Array_.staticClass, "getResultSet", "(JI)Ljava/sql/ResultSet;", ref global::java.sql.Array_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::java.sql.ResultSet java.sql.Array.getResultSet(long arg0, int arg1, java.util.Map arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.Array_.staticClass, "getResultSet", "(JILjava/util/Map;)Ljava/sql/ResultSet;", ref global::java.sql.Array_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		void java.sql.Array.free()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Array_.staticClass, "free", "()V", ref global::java.sql.Array_._m10);
		}
		static Array_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Array_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Array"));
		}
	}
}

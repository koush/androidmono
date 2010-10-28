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
		static Array_()
		{
			InitJNI();
		}
		internal Array_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getArray24080;
		global::java.lang.Object java.sql.Array.getArray(long arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Array_._getArray24080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Array_.staticClass, global::java.sql.Array_._getArray24080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getArray24081;
		global::java.lang.Object java.sql.Array.getArray(long arg0, int arg1, java.util.Map arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Array_._getArray24081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Array_.staticClass, global::java.sql.Array_._getArray24081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getArray24082;
		global::java.lang.Object java.sql.Array.getArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Array_._getArray24082)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Array_.staticClass, global::java.sql.Array_._getArray24082)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getArray24083;
		global::java.lang.Object java.sql.Array.getArray(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Array_._getArray24083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Array_.staticClass, global::java.sql.Array_._getArray24083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseTypeName24084;
		global::java.lang.String java.sql.Array.getBaseTypeName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Array_._getBaseTypeName24084)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Array_.staticClass, global::java.sql.Array_._getBaseTypeName24084)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseType24085;
		int java.sql.Array.getBaseType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Array_._getBaseType24085);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Array_.staticClass, global::java.sql.Array_._getBaseType24085);
		}
		internal static global::MonoJavaBridge.MethodId _getResultSet24086;
		global::java.sql.ResultSet java.sql.Array.getResultSet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Array_._getResultSet24086)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Array_.staticClass, global::java.sql.Array_._getResultSet24086)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSet24087;
		global::java.sql.ResultSet java.sql.Array.getResultSet(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Array_._getResultSet24087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Array_.staticClass, global::java.sql.Array_._getResultSet24087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSet24088;
		global::java.sql.ResultSet java.sql.Array.getResultSet(long arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Array_._getResultSet24088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Array_.staticClass, global::java.sql.Array_._getResultSet24088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSet24089;
		global::java.sql.ResultSet java.sql.Array.getResultSet(long arg0, int arg1, java.util.Map arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Array_._getResultSet24089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Array_.staticClass, global::java.sql.Array_._getResultSet24089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _free24090;
		void java.sql.Array.free()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Array_._free24090);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Array_.staticClass, global::java.sql.Array_._free24090);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Array_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Array"));
			global::java.sql.Array_._getArray24080 = @__env.GetMethodIDNoThrow(global::java.sql.Array_.staticClass, "getArray", "(JI)Ljava/lang/Object;");
			global::java.sql.Array_._getArray24081 = @__env.GetMethodIDNoThrow(global::java.sql.Array_.staticClass, "getArray", "(JILjava/util/Map;)Ljava/lang/Object;");
			global::java.sql.Array_._getArray24082 = @__env.GetMethodIDNoThrow(global::java.sql.Array_.staticClass, "getArray", "()Ljava/lang/Object;");
			global::java.sql.Array_._getArray24083 = @__env.GetMethodIDNoThrow(global::java.sql.Array_.staticClass, "getArray", "(Ljava/util/Map;)Ljava/lang/Object;");
			global::java.sql.Array_._getBaseTypeName24084 = @__env.GetMethodIDNoThrow(global::java.sql.Array_.staticClass, "getBaseTypeName", "()Ljava/lang/String;");
			global::java.sql.Array_._getBaseType24085 = @__env.GetMethodIDNoThrow(global::java.sql.Array_.staticClass, "getBaseType", "()I");
			global::java.sql.Array_._getResultSet24086 = @__env.GetMethodIDNoThrow(global::java.sql.Array_.staticClass, "getResultSet", "()Ljava/sql/ResultSet;");
			global::java.sql.Array_._getResultSet24087 = @__env.GetMethodIDNoThrow(global::java.sql.Array_.staticClass, "getResultSet", "(Ljava/util/Map;)Ljava/sql/ResultSet;");
			global::java.sql.Array_._getResultSet24088 = @__env.GetMethodIDNoThrow(global::java.sql.Array_.staticClass, "getResultSet", "(JI)Ljava/sql/ResultSet;");
			global::java.sql.Array_._getResultSet24089 = @__env.GetMethodIDNoThrow(global::java.sql.Array_.staticClass, "getResultSet", "(JILjava/util/Map;)Ljava/sql/ResultSet;");
			global::java.sql.Array_._free24090 = @__env.GetMethodIDNoThrow(global::java.sql.Array_.staticClass, "free", "()V");
		}
	}
}

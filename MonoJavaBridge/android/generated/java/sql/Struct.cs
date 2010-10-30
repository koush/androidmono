namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.Struct_))]
	public partial interface Struct  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object[] getAttributes();
		global::java.lang.Object[] getAttributes(java.util.Map arg0);
		global::java.lang.String getSQLTypeName();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.Struct))]
	internal sealed partial class Struct_ : java.lang.Object, Struct
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Struct_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object[] java.sql.Struct.getAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.sql.Struct_.staticClass, "getAttributes", "()[Ljava/lang/Object;", ref global::java.sql.Struct_._m0) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.Object[] java.sql.Struct.getAttributes(java.util.Map arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.sql.Struct_.staticClass, "getAttributes", "(Ljava/util/Map;)[Ljava/lang/Object;", ref global::java.sql.Struct_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String java.sql.Struct.getSQLTypeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.Struct_.staticClass, "getSQLTypeName", "()Ljava/lang/String;", ref global::java.sql.Struct_._m2) as java.lang.String;
		}
		static Struct_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Struct_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Struct"));
		}
		internal static void InitJNI()
		{
		}
	}
}

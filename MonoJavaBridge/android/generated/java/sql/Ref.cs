namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.Ref_))]
	public partial interface Ref  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object getObject(java.util.Map arg0);
		global::java.lang.Object getObject();
		void setObject(java.lang.Object arg0);
		global::java.lang.String getBaseTypeName();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.Ref))]
	internal sealed partial class Ref_ : java.lang.Object, Ref
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Ref_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getObject24754;
		global::java.lang.Object java.sql.Ref.getObject(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Ref_._getObject24754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject24755;
		global::java.lang.Object java.sql.Ref.getObject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Ref_._getObject24755)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setObject24756;
		void java.sql.Ref.setObject(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Ref_._setObject24756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBaseTypeName24757;
		global::java.lang.String java.sql.Ref.getBaseTypeName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Ref_._getBaseTypeName24757)) as java.lang.String;
		}
		static Ref_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Ref_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Ref"));
			global::java.sql.Ref_._getObject24754 = @__env.GetMethodIDNoThrow(global::java.sql.Ref_.staticClass, "getObject", "(Ljava/util/Map;)Ljava/lang/Object;");
			global::java.sql.Ref_._getObject24755 = @__env.GetMethodIDNoThrow(global::java.sql.Ref_.staticClass, "getObject", "()Ljava/lang/Object;");
			global::java.sql.Ref_._setObject24756 = @__env.GetMethodIDNoThrow(global::java.sql.Ref_.staticClass, "setObject", "(Ljava/lang/Object;)V");
			global::java.sql.Ref_._getBaseTypeName24757 = @__env.GetMethodIDNoThrow(global::java.sql.Ref_.staticClass, "getBaseTypeName", "()Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}

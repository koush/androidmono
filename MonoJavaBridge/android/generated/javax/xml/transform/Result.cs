namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.transform.Result_))]
	public partial interface Result  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getSystemId();
		void setSystemId(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.Result))]
	internal sealed partial class Result_ : java.lang.Object, Result
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Result_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId30947;
		global::java.lang.String javax.xml.transform.Result.getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.Result_._getSystemId30947)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId30948;
		void javax.xml.transform.Result.setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Result_._setSystemId30948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Result_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.Result_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/Result"));
			global::javax.xml.transform.Result_._getSystemId30947 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Result_.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::javax.xml.transform.Result_._setSystemId30948 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Result_.staticClass, "setSystemId", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}

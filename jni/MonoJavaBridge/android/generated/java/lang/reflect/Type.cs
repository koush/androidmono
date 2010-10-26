namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.reflect.Type_))]
	public partial interface Type  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.reflect.Type))]
	internal sealed partial class Type_ : java.lang.Object, Type
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Type_()
		{
			InitJNI();
		}
		internal Type_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Type_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Type"));
		}
	}
}

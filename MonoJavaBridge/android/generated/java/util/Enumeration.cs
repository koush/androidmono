namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Enumeration_))]
	public partial interface Enumeration  : global::MonoJavaBridge.IJavaObject 
	{
		bool hasMoreElements();
		global::java.lang.Object nextElement();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Enumeration))]
	internal sealed partial class Enumeration_ : java.lang.Object, Enumeration
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Enumeration_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool java.util.Enumeration.hasMoreElements()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Enumeration_.staticClass, "hasMoreElements", "()Z", ref global::java.util.Enumeration_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.Object java.util.Enumeration.nextElement()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Enumeration_.staticClass, "nextElement", "()Ljava/lang/Object;", ref global::java.util.Enumeration_._m1) as java.lang.Object;
		}
		static Enumeration_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Enumeration_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Enumeration"));
		}
		internal static void InitJNI()
		{
		}
	}
}

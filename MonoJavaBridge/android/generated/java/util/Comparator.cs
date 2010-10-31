namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Comparator_))]
	public partial interface Comparator  : global::MonoJavaBridge.IJavaObject 
	{
		bool equals(java.lang.Object arg0);
		int compare(java.lang.Object arg0, java.lang.Object arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Comparator))]
	internal sealed partial class Comparator_ : java.lang.Object, Comparator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Comparator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool java.util.Comparator.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Comparator_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.Comparator_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		int java.util.Comparator.compare(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Comparator_.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", ref global::java.util.Comparator_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static Comparator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Comparator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Comparator"));
		}
	}
}

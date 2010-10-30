namespace java.lang
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.Comparable_))]
	public partial interface Comparable  : global::MonoJavaBridge.IJavaObject 
	{
		int compareTo(java.lang.Object arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Comparable))]
	internal sealed partial class Comparable_ : java.lang.Object, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Comparable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20078;
		int java.lang.Comparable.compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Comparable_.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.lang.Comparable_._compareTo20078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Comparable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Comparable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Comparable"));
		}
		internal static void InitJNI()
		{
		}
	}
}

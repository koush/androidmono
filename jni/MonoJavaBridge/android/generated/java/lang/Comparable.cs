namespace java.lang
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.Comparable_))]
	public interface Comparable  : global::MonoJavaBridge.IJavaObject 
	{
		int compareTo(java.lang.Object arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Comparable))]
	public sealed partial class Comparable_ : java.lang.Object, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Comparable_()
		{
			InitJNI();
		}
		internal Comparable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _compareTo19960;
		 int java.lang.Comparable.compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Comparable_._compareTo19960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Comparable_.staticClass, global::java.lang.Comparable_._compareTo19960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Comparable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Comparable"));
			global::java.lang.Comparable_._compareTo19960 = @__env.GetMethodIDNoThrow(global::java.lang.Comparable_.staticClass, "compareTo", "(Ljava/lang/Object;)I");
		}
	}
}

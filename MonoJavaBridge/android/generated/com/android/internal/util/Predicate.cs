namespace com.android.@internal.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::com.android.@internal.util.Predicate_))]
	public partial interface Predicate  : global::MonoJavaBridge.IJavaObject 
	{
		bool apply(java.lang.Object arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::com.android.@internal.util.Predicate))]
	internal sealed partial class Predicate_ : java.lang.Object, Predicate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Predicate_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool com.android.@internal.util.Predicate.apply(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::com.android.@internal.util.Predicate_.staticClass, "apply", "(Ljava/lang/Object;)Z", ref global::com.android.@internal.util.Predicate_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Predicate_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::com.android.@internal.util.Predicate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("com/android/internal/util/Predicate"));
		}
	}
}

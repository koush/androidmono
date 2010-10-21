namespace com.android.@internal.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::com.android.@internal.util.Predicate_))]
	public interface Predicate  : global::MonoJavaBridge.IJavaObject 
	{
		bool apply(java.lang.Object arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::com.android.@internal.util.Predicate))]
	public sealed partial class Predicate_ : java.lang.Object, Predicate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Predicate_()
		{
			InitJNI();
		}
		internal Predicate_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _apply18218;
		 bool com.android.@internal.util.Predicate.apply(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::com.android.@internal.util.Predicate_._apply18218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::com.android.@internal.util.Predicate_.staticClass, global::com.android.@internal.util.Predicate_._apply18218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::com.android.@internal.util.Predicate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("com/android/@internal/util/Predicate"));
			global::com.android.@internal.util.Predicate_._apply18218 = @__env.GetMethodIDNoThrow(global::com.android.@internal.util.Predicate_.staticClass, "apply", "(Ljava/lang/Object;)Z");
		}
	}
}

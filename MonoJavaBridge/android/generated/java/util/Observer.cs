namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Observer_))]
	public partial interface Observer  : global::MonoJavaBridge.IJavaObject 
	{
		void update(java.util.Observable arg0, java.lang.Object arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Observer))]
	internal sealed partial class Observer_ : java.lang.Object, Observer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Observer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void java.util.Observer.update(java.util.Observable arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Observer_.staticClass, "update", "(Ljava/util/Observable;Ljava/lang/Object;)V", ref global::java.util.Observer_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static Observer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Observer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Observer"));
		}
		internal static void InitJNI()
		{
		}
	}
}

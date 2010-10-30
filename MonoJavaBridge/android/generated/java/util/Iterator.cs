namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Iterator_))]
	public partial interface Iterator  : global::MonoJavaBridge.IJavaObject 
	{
		bool hasNext();
		global::java.lang.Object next();
		void remove();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Iterator))]
	internal sealed partial class Iterator_ : java.lang.Object, Iterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Iterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasNext26332;
		bool java.util.Iterator.hasNext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Iterator_._hasNext26332.native == global::System.IntPtr.Zero)
				global::java.util.Iterator_._hasNext26332 = @__env.GetMethodIDNoThrow(global::java.util.Iterator_.staticClass, "hasNext", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Iterator_._hasNext26332);
		}
		internal static global::MonoJavaBridge.MethodId _next26333;
		global::java.lang.Object java.util.Iterator.next()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Iterator_._next26333.native == global::System.IntPtr.Zero)
				global::java.util.Iterator_._next26333 = @__env.GetMethodIDNoThrow(global::java.util.Iterator_.staticClass, "next", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Iterator_._next26333)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26334;
		void java.util.Iterator.remove()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Iterator_._remove26334.native == global::System.IntPtr.Zero)
				global::java.util.Iterator_._remove26334 = @__env.GetMethodIDNoThrow(global::java.util.Iterator_.staticClass, "remove", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.Iterator_._remove26334);
		}
		static Iterator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Iterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Iterator"));
		}
		internal static void InitJNI()
		{
		}
	}
}

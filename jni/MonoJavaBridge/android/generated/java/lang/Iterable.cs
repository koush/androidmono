namespace java.lang
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.Iterable_))]
	public partial interface Iterable  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.util.Iterator iterator();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Iterable))]
	internal sealed partial class Iterable_ : java.lang.Object, Iterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Iterable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator20240;
		global::java.util.Iterator java.lang.Iterable.iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Iterable_._iterator20240)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Iterable_.staticClass, global::java.lang.Iterable_._iterator20240)) as java.util.Iterator;
		}
		static Iterable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Iterable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Iterable"));
			global::java.lang.Iterable_._iterator20240 = @__env.GetMethodIDNoThrow(global::java.lang.Iterable_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
		internal static void InitJNI()
		{
		}
	}
}

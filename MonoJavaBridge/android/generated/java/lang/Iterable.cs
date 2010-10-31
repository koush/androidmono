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
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.util.Iterator java.lang.Iterable.iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.lang.Iterable_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.lang.Iterable_._m0) as java.util.Iterator;
		}
		static Iterable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Iterable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Iterable"));
		}
	}
}

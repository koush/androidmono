namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.AbstractSet_))]
	public abstract partial class AbstractSet : java.util.AbstractCollection, Set
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractSet.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.AbstractSet._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.AbstractSet.staticClass, "hashCode", "()I", ref global::java.util.AbstractSet._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool removeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractSet.staticClass, "removeAll", "(Ljava/util/Collection;)Z", ref global::java.util.AbstractSet._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected AbstractSet() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractSet._m3.native == global::System.IntPtr.Zero)
				global::java.util.AbstractSet._m3 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSet.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractSet.staticClass, global::java.util.AbstractSet._m3);
			Init(@__env, handle);
		}
		static AbstractSet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractSet"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.AbstractSet))]
	internal sealed partial class AbstractSet_ : java.util.AbstractSet
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractSet_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.AbstractSet_.staticClass, "size", "()I", ref global::java.util.AbstractSet_._m0);
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.AbstractSet_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.AbstractSet_._m1) as java.util.Iterator;
		}
		static AbstractSet_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractSet_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractSet"));
		}
	}
}

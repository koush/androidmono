namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CopyOnWriteArraySet : java.util.AbstractSet, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CopyOnWriteArraySet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.CopyOnWriteArraySet._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.CopyOnWriteArraySet._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "clear", "()V", ref global::java.util.concurrent.CopyOnWriteArraySet._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "isEmpty", "()Z", ref global::java.util.concurrent.CopyOnWriteArraySet._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.CopyOnWriteArraySet._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "addAll", "(Ljava/util/Collection;)Z", ref global::java.util.concurrent.CopyOnWriteArraySet._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "size", "()I", ref global::java.util.concurrent.CopyOnWriteArraySet._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.concurrent.CopyOnWriteArraySet._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.lang.Object[] toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.concurrent.CopyOnWriteArraySet._m8) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.concurrent.CopyOnWriteArraySet._m9) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override bool remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.CopyOnWriteArraySet._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override bool containsAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "containsAll", "(Ljava/util/Collection;)Z", ref global::java.util.concurrent.CopyOnWriteArraySet._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override bool removeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "removeAll", "(Ljava/util/Collection;)Z", ref global::java.util.concurrent.CopyOnWriteArraySet._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override bool retainAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "retainAll", "(Ljava/util/Collection;)Z", ref global::java.util.concurrent.CopyOnWriteArraySet._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public CopyOnWriteArraySet(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.CopyOnWriteArraySet._m14.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.CopyOnWriteArraySet._m14 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public CopyOnWriteArraySet() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.CopyOnWriteArraySet._m15.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.CopyOnWriteArraySet._m15 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._m15);
			Init(@__env, handle);
		}
		static CopyOnWriteArraySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.CopyOnWriteArraySet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/CopyOnWriteArraySet"));
		}
	}
}

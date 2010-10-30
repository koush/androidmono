namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.AbstractSequentialList_))]
	public abstract partial class AbstractSequentialList : java.util.AbstractList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractSequentialList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void add(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.AbstractSequentialList.staticClass, "add", "(ILjava/lang/Object;)V", ref global::java.util.AbstractSequentialList._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.Object get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractSequentialList.staticClass, "get", "(I)Ljava/lang/Object;", ref global::java.util.AbstractSequentialList._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool addAll(int arg0, java.util.Collection arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractSequentialList.staticClass, "addAll", "(ILjava/util/Collection;)Z", ref global::java.util.AbstractSequentialList._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.AbstractSequentialList.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.AbstractSequentialList._m3) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.Object remove(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractSequentialList.staticClass, "remove", "(I)Ljava/lang/Object;", ref global::java.util.AbstractSequentialList._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.lang.Object set(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractSequentialList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;", ref global::java.util.AbstractSequentialList._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract global::java.util.ListIterator listIterator(int arg0);
		private static global::MonoJavaBridge.MethodId _m7;
		protected AbstractSequentialList() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractSequentialList._m7.native == global::System.IntPtr.Zero)
				global::java.util.AbstractSequentialList._m7 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractSequentialList.staticClass, global::java.util.AbstractSequentialList._m7);
			Init(@__env, handle);
		}
		static AbstractSequentialList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractSequentialList.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractSequentialList"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.AbstractSequentialList))]
	internal sealed partial class AbstractSequentialList_ : java.util.AbstractSequentialList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractSequentialList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.util.ListIterator listIterator(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.ListIterator>(this, global::java.util.AbstractSequentialList_.staticClass, "listIterator", "(I)Ljava/util/ListIterator;", ref global::java.util.AbstractSequentialList_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ListIterator;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.AbstractSequentialList_.staticClass, "size", "()I", ref global::java.util.AbstractSequentialList_._m1);
		}
		static AbstractSequentialList_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractSequentialList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractSequentialList"));
		}
		internal static void InitJNI()
		{
		}
	}
}

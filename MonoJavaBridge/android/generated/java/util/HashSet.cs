namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HashSet : java.util.AbstractSet, Set, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HashSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.HashSet.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.HashSet._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.HashSet.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.HashSet._m1) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.HashSet.staticClass, "clear", "()V", ref global::java.util.HashSet._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.HashSet.staticClass, "isEmpty", "()Z", ref global::java.util.HashSet._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.HashSet.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.HashSet._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.HashSet.staticClass, "size", "()I", ref global::java.util.HashSet._m5);
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.HashSet.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.HashSet._m6) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.HashSet.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.HashSet._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public HashSet() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.HashSet._m8.native == global::System.IntPtr.Zero)
				global::java.util.HashSet._m8 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashSet.staticClass, global::java.util.HashSet._m8);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public HashSet(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.HashSet._m9.native == global::System.IntPtr.Zero)
				global::java.util.HashSet._m9 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashSet.staticClass, global::java.util.HashSet._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public HashSet(int arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.HashSet._m10.native == global::System.IntPtr.Zero)
				global::java.util.HashSet._m10 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "<init>", "(IF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashSet.staticClass, global::java.util.HashSet._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public HashSet(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.HashSet._m11.native == global::System.IntPtr.Zero)
				global::java.util.HashSet._m11 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashSet.staticClass, global::java.util.HashSet._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static HashSet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.HashSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/HashSet"));
		}
	}
}

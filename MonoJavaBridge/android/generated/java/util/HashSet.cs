namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HashSet : java.util.AbstractSet, Set, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HashSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26258;
		public override bool add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.HashSet.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.HashSet._add26258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clone26259;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.HashSet.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.HashSet._clone26259) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear26260;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.HashSet.staticClass, "clear", "()V", ref global::java.util.HashSet._clear26260);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26261;
		public override bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.HashSet.staticClass, "isEmpty", "()Z", ref global::java.util.HashSet._isEmpty26261);
		}
		internal static global::MonoJavaBridge.MethodId _contains26262;
		public override bool contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.HashSet.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.HashSet._contains26262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26263;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.HashSet.staticClass, "size", "()I", ref global::java.util.HashSet._size26263);
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator26264;
		public override global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.HashSet.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.HashSet._iterator26264) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26265;
		public override bool remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.HashSet.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.HashSet._remove26265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HashSet26266;
		public HashSet() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.HashSet._HashSet26266.native == global::System.IntPtr.Zero)
				global::java.util.HashSet._HashSet26266 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashSet.staticClass, global::java.util.HashSet._HashSet26266);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashSet26267;
		public HashSet(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.HashSet._HashSet26267.native == global::System.IntPtr.Zero)
				global::java.util.HashSet._HashSet26267 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashSet.staticClass, global::java.util.HashSet._HashSet26267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashSet26268;
		public HashSet(int arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.HashSet._HashSet26268.native == global::System.IntPtr.Zero)
				global::java.util.HashSet._HashSet26268 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "<init>", "(IF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashSet.staticClass, global::java.util.HashSet._HashSet26268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashSet26269;
		public HashSet(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.HashSet._HashSet26269.native == global::System.IntPtr.Zero)
				global::java.util.HashSet._HashSet26269 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashSet.staticClass, global::java.util.HashSet._HashSet26269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static HashSet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.HashSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/HashSet"));
		}
		internal static void InitJNI()
		{
		}
	}
}

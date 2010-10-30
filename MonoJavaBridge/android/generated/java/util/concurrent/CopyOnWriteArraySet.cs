namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CopyOnWriteArraySet : java.util.AbstractSet, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CopyOnWriteArraySet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add27199;
		public override bool add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.CopyOnWriteArraySet._add27199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals27200;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.CopyOnWriteArraySet._equals27200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear27201;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "clear", "()V", ref global::java.util.concurrent.CopyOnWriteArraySet._clear27201);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty27202;
		public override bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "isEmpty", "()Z", ref global::java.util.concurrent.CopyOnWriteArraySet._isEmpty27202);
		}
		internal static global::MonoJavaBridge.MethodId _contains27203;
		public override bool contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.CopyOnWriteArraySet._contains27203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll27204;
		public override bool addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "addAll", "(Ljava/util/Collection;)Z", ref global::java.util.concurrent.CopyOnWriteArraySet._addAll27204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size27205;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "size", "()I", ref global::java.util.concurrent.CopyOnWriteArraySet._size27205);
		}
		internal static global::MonoJavaBridge.MethodId _toArray27206;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.concurrent.CopyOnWriteArraySet._toArray27206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray27207;
		public override global::java.lang.Object[] toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.concurrent.CopyOnWriteArraySet._toArray27207) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator27208;
		public override global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.concurrent.CopyOnWriteArraySet._iterator27208) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove27209;
		public override bool remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.CopyOnWriteArraySet._remove27209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll27210;
		public override bool containsAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "containsAll", "(Ljava/util/Collection;)Z", ref global::java.util.concurrent.CopyOnWriteArraySet._containsAll27210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll27211;
		public override bool removeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "removeAll", "(Ljava/util/Collection;)Z", ref global::java.util.concurrent.CopyOnWriteArraySet._removeAll27211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll27212;
		public override bool retainAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "retainAll", "(Ljava/util/Collection;)Z", ref global::java.util.concurrent.CopyOnWriteArraySet._retainAll27212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CopyOnWriteArraySet27213;
		public CopyOnWriteArraySet(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.CopyOnWriteArraySet._CopyOnWriteArraySet27213.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.CopyOnWriteArraySet._CopyOnWriteArraySet27213 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._CopyOnWriteArraySet27213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CopyOnWriteArraySet27214;
		public CopyOnWriteArraySet() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.CopyOnWriteArraySet._CopyOnWriteArraySet27214.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.CopyOnWriteArraySet._CopyOnWriteArraySet27214 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._CopyOnWriteArraySet27214);
			Init(@__env, handle);
		}
		static CopyOnWriteArraySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.CopyOnWriteArraySet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/CopyOnWriteArraySet"));
		}
		internal static void InitJNI()
		{
		}
	}
}

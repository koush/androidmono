namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.AbstractCollection_))]
	public abstract partial class AbstractCollection : java.lang.Object, Collection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractCollection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractCollection.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.AbstractCollection._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.AbstractCollection.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.AbstractCollection._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.AbstractCollection.staticClass, "clear", "()V", ref global::java.util.AbstractCollection._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractCollection.staticClass, "isEmpty", "()Z", ref global::java.util.AbstractCollection._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractCollection.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.AbstractCollection._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractCollection.staticClass, "addAll", "(Ljava/util/Collection;)Z", ref global::java.util.AbstractCollection._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract int size();
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.AbstractCollection.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.AbstractCollection._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.Object[] toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.AbstractCollection.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.AbstractCollection._m8) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract global::java.util.Iterator iterator();
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractCollection.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.AbstractCollection._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool containsAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractCollection.staticClass, "containsAll", "(Ljava/util/Collection;)Z", ref global::java.util.AbstractCollection._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool removeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractCollection.staticClass, "removeAll", "(Ljava/util/Collection;)Z", ref global::java.util.AbstractCollection._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool retainAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractCollection.staticClass, "retainAll", "(Ljava/util/Collection;)Z", ref global::java.util.AbstractCollection._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected AbstractCollection() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractCollection._m14.native == global::System.IntPtr.Zero)
				global::java.util.AbstractCollection._m14 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._m14);
			Init(@__env, handle);
		}
		static AbstractCollection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractCollection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractCollection"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.AbstractCollection))]
	internal sealed partial class AbstractCollection_ : java.util.AbstractCollection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractCollection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.AbstractCollection_.staticClass, "size", "()I", ref global::java.util.AbstractCollection_._m0);
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.AbstractCollection_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.AbstractCollection_._m1) as java.util.Iterator;
		}
		static AbstractCollection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractCollection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractCollection"));
		}
		internal static void InitJNI()
		{
		}
	}
}

namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CopyOnWriteArrayList : java.lang.Object, List, RandomAccess, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CopyOnWriteArrayList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.CopyOnWriteArrayList._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void add(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "add", "(ILjava/lang/Object;)V", ref global::java.util.concurrent.CopyOnWriteArrayList._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.Object get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "get", "(I)Ljava/lang/Object;", ref global::java.util.concurrent.CopyOnWriteArrayList._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.CopyOnWriteArrayList._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.CopyOnWriteArrayList._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "hashCode", "()I", ref global::java.util.concurrent.CopyOnWriteArrayList._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.concurrent.CopyOnWriteArrayList._m6) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int indexOf(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "indexOf", "(Ljava/lang/Object;)I", ref global::java.util.concurrent.CopyOnWriteArrayList._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int indexOf(java.lang.Object arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "indexOf", "(Ljava/lang/Object;I)I", ref global::java.util.concurrent.CopyOnWriteArrayList._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "clear", "()V", ref global::java.util.concurrent.CopyOnWriteArrayList._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "isEmpty", "()Z", ref global::java.util.concurrent.CopyOnWriteArrayList._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int lastIndexOf(java.lang.Object arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "lastIndexOf", "(Ljava/lang/Object;I)I", ref global::java.util.concurrent.CopyOnWriteArrayList._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int lastIndexOf(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I", ref global::java.util.concurrent.CopyOnWriteArrayList._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.CopyOnWriteArrayList._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool addAll(int arg0, java.util.Collection arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "addAll", "(ILjava/util/Collection;)Z", ref global::java.util.concurrent.CopyOnWriteArrayList._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "addAll", "(Ljava/util/Collection;)Z", ref global::java.util.concurrent.CopyOnWriteArrayList._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "size", "()I", ref global::java.util.concurrent.CopyOnWriteArrayList._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.concurrent.CopyOnWriteArrayList._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.lang.Object[] toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.concurrent.CopyOnWriteArrayList._m18) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.concurrent.CopyOnWriteArrayList._m19) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::java.lang.Object remove(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "remove", "(I)Ljava/lang/Object;", ref global::java.util.concurrent.CopyOnWriteArrayList._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual bool remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.CopyOnWriteArrayList._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual global::java.lang.Object set(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.CopyOnWriteArrayList._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool containsAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "containsAll", "(Ljava/util/Collection;)Z", ref global::java.util.concurrent.CopyOnWriteArrayList._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual bool removeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "removeAll", "(Ljava/util/Collection;)Z", ref global::java.util.concurrent.CopyOnWriteArrayList._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual bool retainAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "retainAll", "(Ljava/util/Collection;)Z", ref global::java.util.concurrent.CopyOnWriteArrayList._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual global::java.util.List subList(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "subList", "(II)Ljava/util/List;", ref global::java.util.concurrent.CopyOnWriteArrayList._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual global::java.util.ListIterator listIterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.ListIterator>(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "listIterator", "()Ljava/util/ListIterator;", ref global::java.util.concurrent.CopyOnWriteArrayList._m27) as java.util.ListIterator;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual global::java.util.ListIterator listIterator(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.ListIterator>(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "listIterator", "(I)Ljava/util/ListIterator;", ref global::java.util.concurrent.CopyOnWriteArrayList._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ListIterator;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual bool addIfAbsent(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "addIfAbsent", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.CopyOnWriteArrayList._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual int addAllAbsent(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "addAllAbsent", "(Ljava/util/Collection;)I", ref global::java.util.concurrent.CopyOnWriteArrayList._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public CopyOnWriteArrayList(java.lang.Object[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.CopyOnWriteArrayList._m31.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.CopyOnWriteArrayList._m31 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "<init>", "([Ljava/lang/Object;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public CopyOnWriteArrayList() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.CopyOnWriteArrayList._m32.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.CopyOnWriteArrayList._m32 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._m32);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public CopyOnWriteArrayList(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.CopyOnWriteArrayList._m33.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.CopyOnWriteArrayList._m33 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArrayList.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CopyOnWriteArrayList.staticClass, global::java.util.concurrent.CopyOnWriteArrayList._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CopyOnWriteArrayList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.CopyOnWriteArrayList.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/CopyOnWriteArrayList"));
		}
	}
}

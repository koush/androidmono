namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.AbstractList_))]
	public abstract partial class AbstractList : java.util.AbstractCollection, List
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add25681;
		public override bool add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractList.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.AbstractList._add25681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add25682;
		public virtual void add(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.AbstractList.staticClass, "add", "(ILjava/lang/Object;)V", ref global::java.util.AbstractList._add25682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _get25683;
		public abstract global::java.lang.Object get(int arg0);
		internal static global::MonoJavaBridge.MethodId _equals25684;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractList.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.AbstractList._equals25684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25685;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.AbstractList.staticClass, "hashCode", "()I", ref global::java.util.AbstractList._hashCode25685);
		}
		internal static global::MonoJavaBridge.MethodId _indexOf25686;
		public virtual int indexOf(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.AbstractList.staticClass, "indexOf", "(Ljava/lang/Object;)I", ref global::java.util.AbstractList._indexOf25686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear25687;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.AbstractList.staticClass, "clear", "()V", ref global::java.util.AbstractList._clear25687);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf25688;
		public virtual int lastIndexOf(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.AbstractList.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I", ref global::java.util.AbstractList._lastIndexOf25688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll25689;
		public virtual bool addAll(int arg0, java.util.Collection arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractList.staticClass, "addAll", "(ILjava/util/Collection;)Z", ref global::java.util.AbstractList._addAll25689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator25690;
		public override global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.AbstractList.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.AbstractList._iterator25690) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove25691;
		public virtual global::java.lang.Object remove(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractList.staticClass, "remove", "(I)Ljava/lang/Object;", ref global::java.util.AbstractList._remove25691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set25692;
		public virtual global::java.lang.Object set(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;", ref global::java.util.AbstractList._set25692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _subList25693;
		public virtual global::java.util.List subList(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.AbstractList.staticClass, "subList", "(II)Ljava/util/List;", ref global::java.util.AbstractList._subList25693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _removeRange25694;
		protected virtual void removeRange(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.AbstractList.staticClass, "removeRange", "(II)V", ref global::java.util.AbstractList._removeRange25694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _listIterator25695;
		public virtual global::java.util.ListIterator listIterator(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.ListIterator>(this, global::java.util.AbstractList.staticClass, "listIterator", "(I)Ljava/util/ListIterator;", ref global::java.util.AbstractList._listIterator25695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator25696;
		public virtual global::java.util.ListIterator listIterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.ListIterator>(this, global::java.util.AbstractList.staticClass, "listIterator", "()Ljava/util/ListIterator;", ref global::java.util.AbstractList._listIterator25696) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractList25697;
		protected AbstractList() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractList._AbstractList25697.native == global::System.IntPtr.Zero)
				global::java.util.AbstractList._AbstractList25697 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractList.staticClass, global::java.util.AbstractList._AbstractList25697);
			Init(@__env, handle);
		}
		static AbstractList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractList.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractList"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.AbstractList))]
	internal sealed partial class AbstractList_ : java.util.AbstractList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get25698;
		public override global::java.lang.Object get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractList_.staticClass, "get", "(I)Ljava/lang/Object;", ref global::java.util.AbstractList_._get25698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _size25699;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.AbstractList_.staticClass, "size", "()I", ref global::java.util.AbstractList_._size25699);
		}
		static AbstractList_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractList"));
		}
		internal static void InitJNI()
		{
		}
	}
}

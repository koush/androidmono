namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.AbstractList_))]
	public abstract partial class AbstractList : java.util.AbstractCollection, List
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractList()
		{
			InitJNI();
		}
		protected AbstractList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add25680;
		public override bool add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractList._add25680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._add25680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add25681;
		public virtual void add(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.AbstractList._add25681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._add25681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _get25682;
		public abstract global::java.lang.Object get(int arg0);
		internal static global::MonoJavaBridge.MethodId _equals25683;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractList._equals25683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._equals25683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25684;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractList._hashCode25684);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._hashCode25684);
		}
		internal static global::MonoJavaBridge.MethodId _indexOf25685;
		public virtual int indexOf(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractList._indexOf25685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._indexOf25685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear25686;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.AbstractList._clear25686);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._clear25686);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf25687;
		public virtual int lastIndexOf(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractList._lastIndexOf25687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._lastIndexOf25687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll25688;
		public virtual bool addAll(int arg0, java.util.Collection arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractList._addAll25688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._addAll25688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator25689;
		public override global::java.util.Iterator iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractList._iterator25689)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._iterator25689)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove25690;
		public virtual global::java.lang.Object remove(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractList._remove25690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._remove25690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set25691;
		public virtual global::java.lang.Object set(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractList._set25691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._set25691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _subList25692;
		public virtual global::java.util.List subList(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractList._subList25692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._subList25692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _removeRange25693;
		protected virtual void removeRange(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.AbstractList._removeRange25693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._removeRange25693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _listIterator25694;
		public virtual global::java.util.ListIterator listIterator(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractList._listIterator25694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._listIterator25694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator25695;
		public virtual global::java.util.ListIterator listIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractList._listIterator25695)) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._listIterator25695)) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractList25696;
		protected AbstractList() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractList.staticClass, global::java.util.AbstractList._AbstractList25696);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractList.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractList"));
			global::java.util.AbstractList._add25680 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractList._add25681 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "add", "(ILjava/lang/Object;)V");
			global::java.util.AbstractList._get25682 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.AbstractList._equals25683 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractList._hashCode25684 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "hashCode", "()I");
			global::java.util.AbstractList._indexOf25685 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "indexOf", "(Ljava/lang/Object;)I");
			global::java.util.AbstractList._clear25686 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "clear", "()V");
			global::java.util.AbstractList._lastIndexOf25687 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
			global::java.util.AbstractList._addAll25688 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			global::java.util.AbstractList._iterator25689 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.AbstractList._remove25690 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "remove", "(I)Ljava/lang/Object;");
			global::java.util.AbstractList._set25691 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::java.util.AbstractList._subList25692 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "subList", "(II)Ljava/util/List;");
			global::java.util.AbstractList._removeRange25693 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "removeRange", "(II)V");
			global::java.util.AbstractList._listIterator25694 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "listIterator", "(I)Ljava/util/ListIterator;");
			global::java.util.AbstractList._listIterator25695 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "listIterator", "()Ljava/util/ListIterator;");
			global::java.util.AbstractList._AbstractList25696 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.AbstractList))]
	internal sealed partial class AbstractList_ : java.util.AbstractList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractList_()
		{
			InitJNI();
		}
		internal AbstractList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get25697;
		public override global::java.lang.Object get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractList_._get25697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractList_.staticClass, global::java.util.AbstractList_._get25697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _size25698;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractList_._size25698);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractList_.staticClass, global::java.util.AbstractList_._size25698);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractList"));
			global::java.util.AbstractList_._get25697 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList_.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.AbstractList_._size25698 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList_.staticClass, "size", "()I");
		}
	}
}

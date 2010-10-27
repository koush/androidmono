namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.AbstractCollection_))]
	public abstract partial class AbstractCollection : java.lang.Object, Collection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractCollection()
		{
			InitJNI();
		}
		protected AbstractCollection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add25663;
		public virtual bool add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._add25663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._add25663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString25664;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractCollection._toString25664)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._toString25664)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear25665;
		public virtual void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.AbstractCollection._clear25665);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._clear25665);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty25666;
		public virtual bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._isEmpty25666);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._isEmpty25666);
		}
		internal static global::MonoJavaBridge.MethodId _contains25667;
		public virtual bool contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._contains25667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._contains25667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll25668;
		public virtual bool addAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._addAll25668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._addAll25668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size25669;
		public abstract int size();
		internal static global::MonoJavaBridge.MethodId _toArray25670;
		public virtual global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractCollection._toArray25670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._toArray25670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray25671;
		public virtual global::java.lang.Object[] toArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractCollection._toArray25671)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._toArray25671)) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator25672;
		public abstract global::java.util.Iterator iterator();
		internal static global::MonoJavaBridge.MethodId _remove25673;
		public virtual bool remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._remove25673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._remove25673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll25674;
		public virtual bool containsAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._containsAll25674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._containsAll25674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll25675;
		public virtual bool removeAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._removeAll25675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._removeAll25675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll25676;
		public virtual bool retainAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._retainAll25676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._retainAll25676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractCollection25677;
		protected AbstractCollection() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._AbstractCollection25677);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractCollection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractCollection"));
			global::java.util.AbstractCollection._add25663 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractCollection._toString25664 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.AbstractCollection._clear25665 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "clear", "()V");
			global::java.util.AbstractCollection._isEmpty25666 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "isEmpty", "()Z");
			global::java.util.AbstractCollection._contains25667 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractCollection._addAll25668 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractCollection._size25669 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "size", "()I");
			global::java.util.AbstractCollection._toArray25670 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.AbstractCollection._toArray25671 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.AbstractCollection._iterator25672 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.AbstractCollection._remove25673 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractCollection._containsAll25674 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractCollection._removeAll25675 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractCollection._retainAll25676 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractCollection._AbstractCollection25677 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.AbstractCollection))]
	internal sealed partial class AbstractCollection_ : java.util.AbstractCollection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractCollection_()
		{
			InitJNI();
		}
		internal AbstractCollection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _size25678;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractCollection_._size25678);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractCollection_.staticClass, global::java.util.AbstractCollection_._size25678);
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator25679;
		public override global::java.util.Iterator iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractCollection_._iterator25679)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractCollection_.staticClass, global::java.util.AbstractCollection_._iterator25679)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractCollection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractCollection"));
			global::java.util.AbstractCollection_._size25678 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection_.staticClass, "size", "()I");
			global::java.util.AbstractCollection_._iterator25679 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}

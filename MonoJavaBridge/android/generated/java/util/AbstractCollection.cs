namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.AbstractCollection_))]
	public abstract partial class AbstractCollection : java.lang.Object, Collection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractCollection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add25664;
		public virtual bool add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._add25664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString25665;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._toString25665)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear25666;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._clear25666);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty25667;
		public virtual bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._isEmpty25667);
		}
		internal static global::MonoJavaBridge.MethodId _contains25668;
		public virtual bool contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._contains25668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll25669;
		public virtual bool addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._addAll25669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size25670;
		public abstract int size();
		internal static global::MonoJavaBridge.MethodId _toArray25671;
		public virtual global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._toArray25671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray25672;
		public virtual global::java.lang.Object[] toArray()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._toArray25672)) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator25673;
		public abstract global::java.util.Iterator iterator();
		internal static global::MonoJavaBridge.MethodId _remove25674;
		public virtual bool remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._remove25674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll25675;
		public virtual bool containsAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._containsAll25675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll25676;
		public virtual bool removeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._removeAll25676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll25677;
		public virtual bool retainAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._retainAll25677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractCollection25678;
		protected AbstractCollection() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._AbstractCollection25678);
			Init(@__env, handle);
		}
		static AbstractCollection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractCollection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractCollection"));
			global::java.util.AbstractCollection._add25664 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractCollection._toString25665 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.AbstractCollection._clear25666 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "clear", "()V");
			global::java.util.AbstractCollection._isEmpty25667 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "isEmpty", "()Z");
			global::java.util.AbstractCollection._contains25668 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractCollection._addAll25669 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractCollection._size25670 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "size", "()I");
			global::java.util.AbstractCollection._toArray25671 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.AbstractCollection._toArray25672 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.AbstractCollection._iterator25673 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.AbstractCollection._remove25674 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractCollection._containsAll25675 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractCollection._removeAll25676 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractCollection._retainAll25677 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractCollection._AbstractCollection25678 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _size25679;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractCollection_._size25679);
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator25680;
		public override global::java.util.Iterator iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractCollection_._iterator25680)) as java.util.Iterator;
		}
		static AbstractCollection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractCollection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractCollection"));
			global::java.util.AbstractCollection_._size25679 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection_.staticClass, "size", "()I");
			global::java.util.AbstractCollection_._iterator25680 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
		internal static void InitJNI()
		{
		}
	}
}

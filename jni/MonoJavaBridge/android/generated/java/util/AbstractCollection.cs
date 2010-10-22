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
		internal static global::MonoJavaBridge.MethodId _add25545;
		public virtual bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._add25545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._add25545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString25546;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractCollection._toString25546)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._toString25546)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear25547;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.AbstractCollection._clear25547);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._clear25547);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty25548;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._isEmpty25548);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._isEmpty25548);
		}
		internal static global::MonoJavaBridge.MethodId _contains25549;
		public virtual bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._contains25549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._contains25549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll25550;
		public virtual bool addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._addAll25550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._addAll25550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size25551;
		public abstract int size();
		internal static global::MonoJavaBridge.MethodId _toArray25552;
		public virtual global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractCollection._toArray25552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._toArray25552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray25553;
		public virtual global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractCollection._toArray25553)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._toArray25553)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator25554;
		public abstract global::java.util.Iterator iterator();
		internal static global::MonoJavaBridge.MethodId _remove25555;
		public virtual bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._remove25555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._remove25555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll25556;
		public virtual bool containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._containsAll25556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._containsAll25556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll25557;
		public virtual bool removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._removeAll25557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._removeAll25557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll25558;
		public virtual bool retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._retainAll25558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._retainAll25558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractCollection25559;
		protected AbstractCollection()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._AbstractCollection25559);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractCollection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractCollection"));
			global::java.util.AbstractCollection._add25545 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractCollection._toString25546 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.AbstractCollection._clear25547 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "clear", "()V");
			global::java.util.AbstractCollection._isEmpty25548 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "isEmpty", "()Z");
			global::java.util.AbstractCollection._contains25549 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractCollection._addAll25550 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractCollection._size25551 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "size", "()I");
			global::java.util.AbstractCollection._toArray25552 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.AbstractCollection._toArray25553 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.AbstractCollection._iterator25554 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.AbstractCollection._remove25555 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractCollection._containsAll25556 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractCollection._removeAll25557 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractCollection._retainAll25558 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractCollection._AbstractCollection25559 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.AbstractCollection))]
	public sealed partial class AbstractCollection_ : java.util.AbstractCollection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractCollection_()
		{
			InitJNI();
		}
		internal AbstractCollection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _size25560;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractCollection_._size25560);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractCollection_.staticClass, global::java.util.AbstractCollection_._size25560);
		}
		internal static global::MonoJavaBridge.MethodId _iterator25561;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractCollection_._iterator25561)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractCollection_.staticClass, global::java.util.AbstractCollection_._iterator25561)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractCollection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractCollection"));
			global::java.util.AbstractCollection_._size25560 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection_.staticClass, "size", "()I");
			global::java.util.AbstractCollection_._iterator25561 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}

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
		internal static global::MonoJavaBridge.MethodId _add19769;
		public virtual bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._add19769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._add19769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString19770;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractCollection._toString19770)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._toString19770)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear19771;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.AbstractCollection._clear19771);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._clear19771);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty19772;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._isEmpty19772);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._isEmpty19772);
		}
		internal static global::MonoJavaBridge.MethodId _contains19773;
		public virtual bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._contains19773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._contains19773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll19774;
		public virtual bool addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._addAll19774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._addAll19774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size19775;
		public abstract int size();
		internal static global::MonoJavaBridge.MethodId _toArray19776;
		public virtual global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractCollection._toArray19776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._toArray19776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray19777;
		public virtual global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractCollection._toArray19777)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._toArray19777)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator19778;
		public abstract global::java.util.Iterator iterator();
		internal static global::MonoJavaBridge.MethodId _remove19779;
		public virtual bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._remove19779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._remove19779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll19780;
		public virtual bool containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._containsAll19780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._containsAll19780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll19781;
		public virtual bool removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._removeAll19781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._removeAll19781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll19782;
		public virtual bool retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection._retainAll19782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._retainAll19782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractCollection19783;
		protected AbstractCollection()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._AbstractCollection19783);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractCollection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractCollection"));
			global::java.util.AbstractCollection._add19769 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractCollection._toString19770 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.AbstractCollection._clear19771 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "clear", "()V");
			global::java.util.AbstractCollection._isEmpty19772 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "isEmpty", "()Z");
			global::java.util.AbstractCollection._contains19773 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractCollection._addAll19774 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractCollection._size19775 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "size", "()I");
			global::java.util.AbstractCollection._toArray19776 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.AbstractCollection._toArray19777 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.AbstractCollection._iterator19778 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.AbstractCollection._remove19779 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractCollection._containsAll19780 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractCollection._removeAll19781 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractCollection._retainAll19782 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractCollection._AbstractCollection19783 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _size19784;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractCollection_._size19784);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractCollection_.staticClass, global::java.util.AbstractCollection_._size19784);
		}
		internal static global::MonoJavaBridge.MethodId _iterator19785;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractCollection_._iterator19785)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractCollection_.staticClass, global::java.util.AbstractCollection_._iterator19785)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractCollection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractCollection"));
			global::java.util.AbstractCollection_._size19784 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection_.staticClass, "size", "()I");
			global::java.util.AbstractCollection_._iterator19785 = @__env.GetMethodIDNoThrow(global::java.util.AbstractCollection_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}

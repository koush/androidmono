namespace java.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class AbstractCollection : java.lang.Object, Collection
	{
		internal static global::java.lang.Class staticClass;
		static AbstractCollection()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.AbstractCollection), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected AbstractCollection(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _add13488;
		public virtual bool add(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.AbstractCollection._add13488, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._add13488, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13489;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractCollection._toString13489));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._toString13489));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear13490;
		public virtual void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.AbstractCollection._clear13490);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._clear13490);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty13491;
		public virtual bool isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.AbstractCollection._isEmpty13491);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._isEmpty13491);
		}
		internal static global::net.sf.jni4net.jni.MethodId _contains13492;
		public virtual bool contains(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.AbstractCollection._contains13492, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._contains13492, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addAll13493;
		public virtual bool addAll(java.util.Collection arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.AbstractCollection._addAll13493, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._addAll13493, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _size13494;
		public abstract int size();
		internal static global::net.sf.jni4net.jni.MethodId _toArray13495;
		public virtual global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractCollection._toArray13495, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._toArray13495, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toArray13496;
		public virtual global::java.lang.Object[] toArray() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractCollection._toArray13496));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._toArray13496));
		}
		internal static global::net.sf.jni4net.jni.MethodId _iterator13497;
		public abstract global::java.util.Iterator iterator();
		internal static global::net.sf.jni4net.jni.MethodId _remove13498;
		public virtual bool remove(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.AbstractCollection._remove13498, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._remove13498, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _containsAll13499;
		public virtual bool containsAll(java.util.Collection arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.AbstractCollection._containsAll13499, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._containsAll13499, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeAll13500;
		public virtual bool removeAll(java.util.Collection arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.AbstractCollection._removeAll13500, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._removeAll13500, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _retainAll13501;
		public virtual bool retainAll(java.util.Collection arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.AbstractCollection._retainAll13501, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._retainAll13501, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbstractCollection13502;
		protected AbstractCollection()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._AbstractCollection13502, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.AbstractCollection.staticClass = @__class;
			global::java.util.AbstractCollection._add13488 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractCollection._toString13489 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.AbstractCollection._clear13490 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "clear", "()V");
			global::java.util.AbstractCollection._isEmpty13491 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "isEmpty", "()Z");
			global::java.util.AbstractCollection._contains13492 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractCollection._addAll13493 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractCollection._size13494 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "size", "()I");
			global::java.util.AbstractCollection._toArray13495 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.AbstractCollection._toArray13496 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.AbstractCollection._iterator13497 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.AbstractCollection._remove13498 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractCollection._containsAll13499 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractCollection._removeAll13500 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractCollection._retainAll13501 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractCollection._AbstractCollection13502 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "<init>", "()V");
		}
	}
}

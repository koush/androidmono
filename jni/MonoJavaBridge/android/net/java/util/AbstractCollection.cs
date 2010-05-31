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
		internal static global::net.sf.jni4net.jni.MethodId _add12660; 
		public virtual bool add(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.util.AbstractCollection._add12660, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._add12660, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear12661; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.util.AbstractCollection._clear12661); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._clear12661); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString12662; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractCollection._toString12662)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._toString12662)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty12663; 
		public virtual bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.util.AbstractCollection._isEmpty12663); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._isEmpty12663); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _contains12664; 
		public virtual bool contains(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.util.AbstractCollection._contains12664, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._contains12664, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addAll12665; 
		public virtual bool addAll(java.util.Collection arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.util.AbstractCollection._addAll12665, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._addAll12665, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size12666; 
		public abstract int size(); 
		internal static global::net.sf.jni4net.jni.MethodId _toArray12667; 
		public virtual global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{ 
			if (!IsClrObject) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractCollection._toArray12667, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._toArray12667, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toArray12668; 
		public virtual global::java.lang.Object[] toArray() 
		{ 
			if (!IsClrObject) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractCollection._toArray12668)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._toArray12668)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _iterator12669; 
		public abstract global::java.util.Iterator iterator(); 
		internal static global::net.sf.jni4net.jni.MethodId _remove12670; 
		public virtual bool remove(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.util.AbstractCollection._remove12670, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._remove12670, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _containsAll12671; 
		public virtual bool containsAll(java.util.Collection arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.util.AbstractCollection._containsAll12671, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._containsAll12671, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAll12672; 
		public virtual bool removeAll(java.util.Collection arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.util.AbstractCollection._removeAll12672, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._removeAll12672, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _retainAll12673; 
		public virtual bool retainAll(java.util.Collection arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.util.AbstractCollection._retainAll12673, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._retainAll12673, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbstractCollection12674; 
		protected AbstractCollection()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.AbstractCollection.staticClass, global::java.util.AbstractCollection._AbstractCollection12674, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.AbstractCollection.staticClass = @__class; 
			global::java.util.AbstractCollection._add12660 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "add", "(Ljava/lang/Object;)Z"); 
			global::java.util.AbstractCollection._clear12661 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "clear", "()V"); 
			global::java.util.AbstractCollection._toString12662 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.util.AbstractCollection._isEmpty12663 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "isEmpty", "()Z"); 
			global::java.util.AbstractCollection._contains12664 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "contains", "(Ljava/lang/Object;)Z"); 
			global::java.util.AbstractCollection._addAll12665 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "addAll", "(Ljava/util/Collection;)Z"); 
			global::java.util.AbstractCollection._size12666 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "size", "()I"); 
			global::java.util.AbstractCollection._toArray12667 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;"); 
			global::java.util.AbstractCollection._toArray12668 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "toArray", "()[Ljava/lang/Object;"); 
			global::java.util.AbstractCollection._iterator12669 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "iterator", "()Ljava/util/Iterator;"); 
			global::java.util.AbstractCollection._remove12670 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "remove", "(Ljava/lang/Object;)Z"); 
			global::java.util.AbstractCollection._containsAll12671 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "containsAll", "(Ljava/util/Collection;)Z"); 
			global::java.util.AbstractCollection._removeAll12672 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "removeAll", "(Ljava/util/Collection;)Z"); 
			global::java.util.AbstractCollection._retainAll12673 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "retainAll", "(Ljava/util/Collection;)Z"); 
			global::java.util.AbstractCollection._AbstractCollection12674 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "<init>", "()V"); 
		} 
	} 
} 

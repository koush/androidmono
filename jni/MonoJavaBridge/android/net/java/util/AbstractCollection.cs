namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbstractCollection : java.lang.Object, Collection
	{ 
		internal static global::java.lang.Class staticClass; 
		static AbstractCollection() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.AbstractCollection), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbstractCollection(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _add11752; 
		public virtual bool add(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractCollection)) 
				return @__env.CallBooleanMethod(this, _add11752, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.AbstractCollection.staticClass, _add11752, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear11753; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractCollection)) 
				@__env.CallVoidMethod(this, _clear11753); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.AbstractCollection.staticClass, _clear11753); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11754; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractCollection)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11754)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractCollection.staticClass, _toString11754)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty11755; 
		public virtual bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractCollection)) 
				return @__env.CallBooleanMethod(this, _isEmpty11755); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.AbstractCollection.staticClass, _isEmpty11755); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _contains11756; 
		public virtual bool contains(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractCollection)) 
				return @__env.CallBooleanMethod(this, _contains11756, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.AbstractCollection.staticClass, _contains11756, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addAll11757; 
		public virtual bool addAll(java.util.Collection arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractCollection)) 
				return @__env.CallBooleanMethod(this, _addAll11757, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.AbstractCollection.staticClass, _addAll11757, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size11758; 
		public abstract int size(); 
		internal static global::net.sf.jni4net.jni.MethodId _toArray11759; 
		public virtual java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{ 
			if (GetType() == typeof(java.util.AbstractCollection)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _toArray11759, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractCollection.staticClass, _toArray11759, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toArray11760; 
		public virtual java.lang.Object[] toArray() 
		{ 
			if (GetType() == typeof(java.util.AbstractCollection)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _toArray11760)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractCollection.staticClass, _toArray11760)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _iterator11761; 
		public abstract java.util.Iterator iterator(); 
		internal static global::net.sf.jni4net.jni.MethodId _remove11762; 
		public virtual bool remove(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractCollection)) 
				return @__env.CallBooleanMethod(this, _remove11762, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.AbstractCollection.staticClass, _remove11762, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _containsAll11763; 
		public virtual bool containsAll(java.util.Collection arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractCollection)) 
				return @__env.CallBooleanMethod(this, _containsAll11763, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.AbstractCollection.staticClass, _containsAll11763, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAll11764; 
		public virtual bool removeAll(java.util.Collection arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractCollection)) 
				return @__env.CallBooleanMethod(this, _removeAll11764, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.AbstractCollection.staticClass, _removeAll11764, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _retainAll11765; 
		public virtual bool retainAll(java.util.Collection arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractCollection)) 
				return @__env.CallBooleanMethod(this, _retainAll11765, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.AbstractCollection.staticClass, _retainAll11765, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbstractCollection11766; 
		protected AbstractCollection()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.AbstractCollection.staticClass, _AbstractCollection11766, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.AbstractCollection.staticClass = @__class; 
			global::java.util.AbstractCollection._add11752 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "add", "(Ljava/lang/Object;)Z"); 
			global::java.util.AbstractCollection._clear11753 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "clear", "()V"); 
			global::java.util.AbstractCollection._toString11754 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.util.AbstractCollection._isEmpty11755 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "isEmpty", "()Z"); 
			global::java.util.AbstractCollection._contains11756 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "contains", "(Ljava/lang/Object;)Z"); 
			global::java.util.AbstractCollection._addAll11757 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "addAll", "(Ljava/util/Collection;)Z"); 
			global::java.util.AbstractCollection._size11758 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "size", "()I"); 
			global::java.util.AbstractCollection._toArray11759 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;"); 
			global::java.util.AbstractCollection._toArray11760 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "toArray", "()[Ljava/lang/Object;"); 
			global::java.util.AbstractCollection._iterator11761 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "iterator", "()Ljava/util/Iterator;"); 
			global::java.util.AbstractCollection._remove11762 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "remove", "(Ljava/lang/Object;)Z"); 
			global::java.util.AbstractCollection._containsAll11763 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "containsAll", "(Ljava/util/Collection;)Z"); 
			global::java.util.AbstractCollection._removeAll11764 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "removeAll", "(Ljava/util/Collection;)Z"); 
			global::java.util.AbstractCollection._retainAll11765 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "retainAll", "(Ljava/util/Collection;)Z"); 
			global::java.util.AbstractCollection._AbstractCollection11766 = @__env.GetMethodID(global::java.util.AbstractCollection.staticClass, "<init>", "()V"); 
		} 
	} 
} 

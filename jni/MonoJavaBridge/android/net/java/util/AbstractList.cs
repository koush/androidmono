namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbstractList : java.util.AbstractCollection, List
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AbstractList() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.AbstractList), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbstractList(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _add11767; 
		public virtual void add(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractList)) 
				@__env.CallVoidMethod(this, _add11767, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.AbstractList.staticClass, _add11767, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _add11768; 
		public override bool add(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractList)) 
				return @__env.CallBooleanMethod(this, _add11768, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.AbstractList.staticClass, _add11768, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11769; 
		public abstract java.lang.Object get(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11770; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractList)) 
				return @__env.CallIntMethod(this, _hashCode11770); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.AbstractList.staticClass, _hashCode11770); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11771; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractList)) 
				return @__env.CallBooleanMethod(this, _equals11771, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.AbstractList.staticClass, _equals11771, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOf11772; 
		public virtual int indexOf(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractList)) 
				return @__env.CallIntMethod(this, _indexOf11772, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.AbstractList.staticClass, _indexOf11772, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear11773; 
		public override void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractList)) 
				@__env.CallVoidMethod(this, _clear11773); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.AbstractList.staticClass, _clear11773); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _lastIndexOf11774; 
		public virtual int lastIndexOf(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractList)) 
				return @__env.CallIntMethod(this, _lastIndexOf11774, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.AbstractList.staticClass, _lastIndexOf11774, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addAll11775; 
		public virtual bool addAll(int arg0, java.util.Collection arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractList)) 
				return @__env.CallBooleanMethod(this, _addAll11775, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.AbstractList.staticClass, _addAll11775, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _iterator11776; 
		public override java.util.Iterator iterator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractList)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, _iterator11776)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractList.staticClass, _iterator11776)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set11777; 
		public virtual java.lang.Object set(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractList)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _set11777, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractList.staticClass, _set11777, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove11778; 
		public virtual java.lang.Object remove(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractList)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _remove11778, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractList.staticClass, _remove11778, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _subList11779; 
		public virtual java.util.List subList(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractList)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _subList11779, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractList.staticClass, _subList11779, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeRange11780; 
		protected virtual void removeRange(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractList)) 
				@__env.CallVoidMethod(this, _removeRange11780, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.AbstractList.staticClass, _removeRange11780, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _listIterator11781; 
		public virtual java.util.Iterator listIterator(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractList)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, _listIterator11781, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractList.staticClass, _listIterator11781, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _listIterator11782; 
		public virtual java.util.Iterator listIterator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractList)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, _listIterator11782)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractList.staticClass, _listIterator11782)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbstractList11783; 
		protected AbstractList()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.AbstractList.staticClass, _AbstractList11783, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.AbstractList.staticClass = @__class; 
			global::java.util.AbstractList._add11767 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "add", "(ILjava/lang/Object;)V"); 
			global::java.util.AbstractList._add11768 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "add", "(Ljava/lang/Object;)Z"); 
			global::java.util.AbstractList._get11769 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "get", "(I)Ljava/lang/Object;"); 
			global::java.util.AbstractList._hashCode11770 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "hashCode", "()I"); 
			global::java.util.AbstractList._equals11771 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.util.AbstractList._indexOf11772 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "indexOf", "(Ljava/lang/Object;)I"); 
			global::java.util.AbstractList._clear11773 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "clear", "()V"); 
			global::java.util.AbstractList._lastIndexOf11774 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I"); 
			global::java.util.AbstractList._addAll11775 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "addAll", "(ILjava/util/Collection;)Z"); 
			global::java.util.AbstractList._iterator11776 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "iterator", "()Ljava/util/Iterator;"); 
			global::java.util.AbstractList._set11777 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;"); 
			global::java.util.AbstractList._remove11778 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "remove", "(I)Ljava/lang/Object;"); 
			global::java.util.AbstractList._subList11779 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "subList", "(II)Ljava/util/List;"); 
			global::java.util.AbstractList._removeRange11780 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "removeRange", "(II)V"); 
			global::java.util.AbstractList._listIterator11781 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "listIterator", "(I)Ljava/util/ListIterator;"); 
			global::java.util.AbstractList._listIterator11782 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "listIterator", "()Ljava/util/ListIterator;"); 
			global::java.util.AbstractList._AbstractList11783 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "<init>", "()V"); 
		} 
	} 
} 

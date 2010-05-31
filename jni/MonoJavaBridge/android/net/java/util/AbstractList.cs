namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbstractList : java.util.AbstractCollection, List
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AbstractList() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.AbstractList), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbstractList(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _add12675; 
		public virtual void add(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.util.AbstractList._add12675, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._add12675, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _add12676; 
		public override bool add(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.util.AbstractList._add12676, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._add12676, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get12677; 
		public abstract global::java.lang.Object get(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12678; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.util.AbstractList._hashCode12678); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._hashCode12678); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals12679; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.util.AbstractList._equals12679, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._equals12679, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOf12680; 
		public virtual int indexOf(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.util.AbstractList._indexOf12680, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._indexOf12680, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear12681; 
		public override void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.util.AbstractList._clear12681); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._clear12681); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _lastIndexOf12682; 
		public virtual int lastIndexOf(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.util.AbstractList._lastIndexOf12682, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._lastIndexOf12682, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addAll12683; 
		public virtual bool addAll(int arg0, java.util.Collection arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.util.AbstractList._addAll12683, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._addAll12683, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _iterator12684; 
		public override global::java.util.Iterator iterator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractList._iterator12684)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._iterator12684)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set12685; 
		public virtual global::java.lang.Object set(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractList._set12685, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._set12685, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove12686; 
		public virtual global::java.lang.Object remove(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractList._remove12686, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._remove12686, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _subList12687; 
		public virtual global::java.util.List subList(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractList._subList12687, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._subList12687, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeRange12688; 
		protected virtual void removeRange(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.util.AbstractList._removeRange12688, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._removeRange12688, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _listIterator12689; 
		public virtual global::java.util.Iterator listIterator(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractList._listIterator12689, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._listIterator12689, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _listIterator12690; 
		public virtual global::java.util.Iterator listIterator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractList._listIterator12690)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._listIterator12690)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbstractList12691; 
		protected AbstractList()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.AbstractList.staticClass, global::java.util.AbstractList._AbstractList12691, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.AbstractList.staticClass = @__class; 
			global::java.util.AbstractList._add12675 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "add", "(ILjava/lang/Object;)V"); 
			global::java.util.AbstractList._add12676 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "add", "(Ljava/lang/Object;)Z"); 
			global::java.util.AbstractList._get12677 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "get", "(I)Ljava/lang/Object;"); 
			global::java.util.AbstractList._hashCode12678 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "hashCode", "()I"); 
			global::java.util.AbstractList._equals12679 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.util.AbstractList._indexOf12680 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "indexOf", "(Ljava/lang/Object;)I"); 
			global::java.util.AbstractList._clear12681 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "clear", "()V"); 
			global::java.util.AbstractList._lastIndexOf12682 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I"); 
			global::java.util.AbstractList._addAll12683 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "addAll", "(ILjava/util/Collection;)Z"); 
			global::java.util.AbstractList._iterator12684 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "iterator", "()Ljava/util/Iterator;"); 
			global::java.util.AbstractList._set12685 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;"); 
			global::java.util.AbstractList._remove12686 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "remove", "(I)Ljava/lang/Object;"); 
			global::java.util.AbstractList._subList12687 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "subList", "(II)Ljava/util/List;"); 
			global::java.util.AbstractList._removeRange12688 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "removeRange", "(II)V"); 
			global::java.util.AbstractList._listIterator12689 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "listIterator", "(I)Ljava/util/ListIterator;"); 
			global::java.util.AbstractList._listIterator12690 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "listIterator", "()Ljava/util/ListIterator;"); 
			global::java.util.AbstractList._AbstractList12691 = @__env.GetMethodID(global::java.util.AbstractList.staticClass, "<init>", "()V"); 
		} 
	} 
} 

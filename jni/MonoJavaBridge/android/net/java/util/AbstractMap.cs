namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbstractMap : java.lang.Object, Map
	{ 
		internal static global::java.lang.Class staticClass; 
		static AbstractMap() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.AbstractMap), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbstractMap(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11784; 
		public virtual java.lang.Object get(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _get11784, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractMap.staticClass, _get11784, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put11785; 
		public virtual java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _put11785, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractMap.staticClass, _put11785, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11786; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return @__env.CallIntMethod(this, _hashCode11786); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.AbstractMap.staticClass, _hashCode11786); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11787; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return @__env.CallBooleanMethod(this, _equals11787, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.AbstractMap.staticClass, _equals11787, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear11788; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				@__env.CallVoidMethod(this, _clear11788); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.AbstractMap.staticClass, _clear11788); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11789; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11789)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractMap.staticClass, _toString11789)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty11790; 
		public virtual bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return @__env.CallBooleanMethod(this, _isEmpty11790); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.AbstractMap.staticClass, _isEmpty11790); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _values11791; 
		public virtual java.util.Collection values() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, _values11791)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractMap.staticClass, _values11791)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size11792; 
		public virtual int size() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return @__env.CallIntMethod(this, _size11792); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.AbstractMap.staticClass, _size11792); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _entrySet11793; 
		public abstract java.util.Set entrySet(); 
		internal static global::net.sf.jni4net.jni.MethodId _putAll11794; 
		public virtual void putAll(java.util.Map arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				@__env.CallVoidMethod(this, _putAll11794, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.AbstractMap.staticClass, _putAll11794, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove11795; 
		public virtual java.lang.Object remove(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _remove11795, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractMap.staticClass, _remove11795, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _keySet11796; 
		public virtual java.util.Set keySet() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, _keySet11796)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractMap.staticClass, _keySet11796)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _containsValue11797; 
		public virtual bool containsValue(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return @__env.CallBooleanMethod(this, _containsValue11797, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.AbstractMap.staticClass, _containsValue11797, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _containsKey11798; 
		public virtual bool containsKey(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return @__env.CallBooleanMethod(this, _containsKey11798, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.AbstractMap.staticClass, _containsKey11798, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbstractMap11799; 
		protected AbstractMap()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.AbstractMap.staticClass, _AbstractMap11799, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.AbstractMap.staticClass = @__class; 
			global::java.util.AbstractMap._get11784 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;"); 
			global::java.util.AbstractMap._put11785 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"); 
			global::java.util.AbstractMap._hashCode11786 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "hashCode", "()I"); 
			global::java.util.AbstractMap._equals11787 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.util.AbstractMap._clear11788 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "clear", "()V"); 
			global::java.util.AbstractMap._toString11789 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.util.AbstractMap._isEmpty11790 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "isEmpty", "()Z"); 
			global::java.util.AbstractMap._values11791 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "values", "()Ljava/util/Collection;"); 
			global::java.util.AbstractMap._size11792 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "size", "()I"); 
			global::java.util.AbstractMap._entrySet11793 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "entrySet", "()Ljava/util/Set;"); 
			global::java.util.AbstractMap._putAll11794 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "putAll", "(Ljava/util/Map;)V"); 
			global::java.util.AbstractMap._remove11795 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;"); 
			global::java.util.AbstractMap._keySet11796 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "keySet", "()Ljava/util/Set;"); 
			global::java.util.AbstractMap._containsValue11797 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z"); 
			global::java.util.AbstractMap._containsKey11798 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z"); 
			global::java.util.AbstractMap._AbstractMap11799 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "<init>", "()V"); 
		} 
	} 
} 

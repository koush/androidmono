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
		internal static global::net.sf.jni4net.jni.MethodId _get12692; 
		public virtual java.lang.Object get(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _get12692, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractMap.staticClass, _get12692, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put12693; 
		public virtual java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _put12693, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractMap.staticClass, _put12693, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12694; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return @__env.CallIntMethod(this, _hashCode12694); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.AbstractMap.staticClass, _hashCode12694); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals12695; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return @__env.CallBooleanMethod(this, _equals12695, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.AbstractMap.staticClass, _equals12695, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear12696; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				@__env.CallVoidMethod(this, _clear12696); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.AbstractMap.staticClass, _clear12696); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString12697; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString12697)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractMap.staticClass, _toString12697)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty12698; 
		public virtual bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return @__env.CallBooleanMethod(this, _isEmpty12698); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.AbstractMap.staticClass, _isEmpty12698); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _values12699; 
		public virtual java.util.Collection values() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, _values12699)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractMap.staticClass, _values12699)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size12700; 
		public virtual int size() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return @__env.CallIntMethod(this, _size12700); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.AbstractMap.staticClass, _size12700); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _entrySet12701; 
		public abstract java.util.Set entrySet(); 
		internal static global::net.sf.jni4net.jni.MethodId _putAll12702; 
		public virtual void putAll(java.util.Map arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				@__env.CallVoidMethod(this, _putAll12702, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.AbstractMap.staticClass, _putAll12702, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove12703; 
		public virtual java.lang.Object remove(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _remove12703, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractMap.staticClass, _remove12703, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _keySet12704; 
		public virtual java.util.Set keySet() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, _keySet12704)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.AbstractMap.staticClass, _keySet12704)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _containsValue12705; 
		public virtual bool containsValue(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return @__env.CallBooleanMethod(this, _containsValue12705, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.AbstractMap.staticClass, _containsValue12705, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _containsKey12706; 
		public virtual bool containsKey(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.AbstractMap)) 
				return @__env.CallBooleanMethod(this, _containsKey12706, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.AbstractMap.staticClass, _containsKey12706, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbstractMap12707; 
		protected AbstractMap()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.AbstractMap.staticClass, _AbstractMap12707, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.AbstractMap.staticClass = @__class; 
			global::java.util.AbstractMap._get12692 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;"); 
			global::java.util.AbstractMap._put12693 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"); 
			global::java.util.AbstractMap._hashCode12694 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "hashCode", "()I"); 
			global::java.util.AbstractMap._equals12695 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.util.AbstractMap._clear12696 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "clear", "()V"); 
			global::java.util.AbstractMap._toString12697 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.util.AbstractMap._isEmpty12698 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "isEmpty", "()Z"); 
			global::java.util.AbstractMap._values12699 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "values", "()Ljava/util/Collection;"); 
			global::java.util.AbstractMap._size12700 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "size", "()I"); 
			global::java.util.AbstractMap._entrySet12701 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "entrySet", "()Ljava/util/Set;"); 
			global::java.util.AbstractMap._putAll12702 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "putAll", "(Ljava/util/Map;)V"); 
			global::java.util.AbstractMap._remove12703 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;"); 
			global::java.util.AbstractMap._keySet12704 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "keySet", "()Ljava/util/Set;"); 
			global::java.util.AbstractMap._containsValue12705 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z"); 
			global::java.util.AbstractMap._containsKey12706 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z"); 
			global::java.util.AbstractMap._AbstractMap12707 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "<init>", "()V"); 
		} 
	} 
} 

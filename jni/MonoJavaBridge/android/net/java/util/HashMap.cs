namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class HashMap : java.util.AbstractMap, Map, java.lang.Cloneable, java.io.Serializable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static HashMap() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.HashMap), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.util.HashMap(@__env); 
			} 
		} 
		protected HashMap(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11964; 
		public override java.lang.Object get(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _get11964, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.HashMap.staticClass, _get11964, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put11965; 
		public override java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _put11965, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.HashMap.staticClass, _put11965, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone11966; 
		public virtual new java.lang.Object clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _clone11966)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.HashMap.staticClass, _clone11966)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear11967; 
		public override void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				@__env.CallVoidMethod(this, _clear11967); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.HashMap.staticClass, _clear11967); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty11968; 
		public override bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return @__env.CallBooleanMethod(this, _isEmpty11968); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.HashMap.staticClass, _isEmpty11968); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _values11969; 
		public override java.util.Collection values() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, _values11969)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.HashMap.staticClass, _values11969)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size11970; 
		public override int size() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return @__env.CallIntMethod(this, _size11970); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.HashMap.staticClass, _size11970); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _entrySet11971; 
		public override java.util.Set entrySet() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, _entrySet11971)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.HashMap.staticClass, _entrySet11971)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putAll11972; 
		public override void putAll(java.util.Map arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				@__env.CallVoidMethod(this, _putAll11972, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.HashMap.staticClass, _putAll11972, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove11973; 
		public override java.lang.Object remove(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _remove11973, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.HashMap.staticClass, _remove11973, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _keySet11974; 
		public override java.util.Set keySet() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, _keySet11974)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.HashMap.staticClass, _keySet11974)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _containsValue11975; 
		public override bool containsValue(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return @__env.CallBooleanMethod(this, _containsValue11975, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.HashMap.staticClass, _containsValue11975, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _containsKey11976; 
		public override bool containsKey(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return @__env.CallBooleanMethod(this, _containsKey11976, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.HashMap.staticClass, _containsKey11976, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _HashMap11977; 
		public HashMap(java.util.Map arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.HashMap.staticClass, _HashMap11977, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _HashMap11978; 
		public HashMap(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.HashMap.staticClass, _HashMap11978, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _HashMap11979; 
		public HashMap()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.HashMap.staticClass, _HashMap11979, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _HashMap11980; 
		public HashMap(int arg0, float arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.HashMap.staticClass, _HashMap11980, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.HashMap.staticClass = @__class; 
			global::java.util.HashMap._get11964 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;"); 
			global::java.util.HashMap._put11965 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"); 
			global::java.util.HashMap._clone11966 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "clone", "()Ljava/lang/Object;"); 
			global::java.util.HashMap._clear11967 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "clear", "()V"); 
			global::java.util.HashMap._isEmpty11968 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "isEmpty", "()Z"); 
			global::java.util.HashMap._values11969 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "values", "()Ljava/util/Collection;"); 
			global::java.util.HashMap._size11970 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "size", "()I"); 
			global::java.util.HashMap._entrySet11971 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "entrySet", "()Ljava/util/Set;"); 
			global::java.util.HashMap._putAll11972 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "putAll", "(Ljava/util/Map;)V"); 
			global::java.util.HashMap._remove11973 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;"); 
			global::java.util.HashMap._keySet11974 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "keySet", "()Ljava/util/Set;"); 
			global::java.util.HashMap._containsValue11975 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z"); 
			global::java.util.HashMap._containsKey11976 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z"); 
			global::java.util.HashMap._HashMap11977 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "<init>", "(Ljava/util/Map;)V"); 
			global::java.util.HashMap._HashMap11978 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "<init>", "(I)V"); 
			global::java.util.HashMap._HashMap11979 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "<init>", "()V"); 
			global::java.util.HashMap._HashMap11980 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "<init>", "(IF)V"); 
		} 
	} 
} 

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
		internal static global::net.sf.jni4net.jni.MethodId _get12874; 
		public override java.lang.Object get(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _get12874, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.HashMap.staticClass, _get12874, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put12875; 
		public override java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _put12875, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.HashMap.staticClass, _put12875, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone12876; 
		public virtual new java.lang.Object clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _clone12876)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.HashMap.staticClass, _clone12876)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear12877; 
		public override void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				@__env.CallVoidMethod(this, _clear12877); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.HashMap.staticClass, _clear12877); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty12878; 
		public override bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return @__env.CallBooleanMethod(this, _isEmpty12878); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.HashMap.staticClass, _isEmpty12878); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _values12879; 
		public override java.util.Collection values() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, _values12879)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.HashMap.staticClass, _values12879)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size12880; 
		public override int size() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return @__env.CallIntMethod(this, _size12880); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.HashMap.staticClass, _size12880); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _entrySet12881; 
		public override java.util.Set entrySet() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, _entrySet12881)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.HashMap.staticClass, _entrySet12881)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putAll12882; 
		public override void putAll(java.util.Map arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				@__env.CallVoidMethod(this, _putAll12882, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.HashMap.staticClass, _putAll12882, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove12883; 
		public override java.lang.Object remove(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _remove12883, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.HashMap.staticClass, _remove12883, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _keySet12884; 
		public override java.util.Set keySet() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, _keySet12884)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.HashMap.staticClass, _keySet12884)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _containsValue12885; 
		public override bool containsValue(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return @__env.CallBooleanMethod(this, _containsValue12885, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.HashMap.staticClass, _containsValue12885, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _containsKey12886; 
		public override bool containsKey(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.HashMap)) 
				return @__env.CallBooleanMethod(this, _containsKey12886, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.HashMap.staticClass, _containsKey12886, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _HashMap12887; 
		public HashMap(java.util.Map arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.HashMap.staticClass, _HashMap12887, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _HashMap12888; 
		public HashMap(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.HashMap.staticClass, _HashMap12888, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _HashMap12889; 
		public HashMap()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.HashMap.staticClass, _HashMap12889, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _HashMap12890; 
		public HashMap(int arg0, float arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.HashMap.staticClass, _HashMap12890, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.HashMap.staticClass = @__class; 
			global::java.util.HashMap._get12874 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;"); 
			global::java.util.HashMap._put12875 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"); 
			global::java.util.HashMap._clone12876 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "clone", "()Ljava/lang/Object;"); 
			global::java.util.HashMap._clear12877 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "clear", "()V"); 
			global::java.util.HashMap._isEmpty12878 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "isEmpty", "()Z"); 
			global::java.util.HashMap._values12879 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "values", "()Ljava/util/Collection;"); 
			global::java.util.HashMap._size12880 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "size", "()I"); 
			global::java.util.HashMap._entrySet12881 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "entrySet", "()Ljava/util/Set;"); 
			global::java.util.HashMap._putAll12882 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "putAll", "(Ljava/util/Map;)V"); 
			global::java.util.HashMap._remove12883 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;"); 
			global::java.util.HashMap._keySet12884 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "keySet", "()Ljava/util/Set;"); 
			global::java.util.HashMap._containsValue12885 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z"); 
			global::java.util.HashMap._containsKey12886 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z"); 
			global::java.util.HashMap._HashMap12887 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "<init>", "(Ljava/util/Map;)V"); 
			global::java.util.HashMap._HashMap12888 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "<init>", "(I)V"); 
			global::java.util.HashMap._HashMap12889 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "<init>", "()V"); 
			global::java.util.HashMap._HashMap12890 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "<init>", "(IF)V"); 
		} 
	} 
} 

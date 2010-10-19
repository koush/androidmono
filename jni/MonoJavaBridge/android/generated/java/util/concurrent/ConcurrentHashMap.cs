namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConcurrentHashMap : java.util.AbstractMap, ConcurrentMap, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConcurrentHashMap()
		{
			InitJNI();
		}
		protected ConcurrentHashMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get21161;
		public override global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._get21161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._get21161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put21162;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._put21162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._put21162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _values21163;
		public override global::java.util.Collection values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._values21163)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._values21163)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _clear21164;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._clear21164);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._clear21164);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty21165;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._isEmpty21165);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._isEmpty21165);
		}
		internal static global::MonoJavaBridge.MethodId _replace21166;
		public virtual global::java.lang.Object replace(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._replace21166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._replace21166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _replace21167;
		public virtual bool replace(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._replace21167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._replace21167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _contains21168;
		public virtual bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._contains21168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._contains21168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size21169;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._size21169);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._size21169);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet21170;
		public override global::java.util.Set entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._entrySet21170)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._entrySet21170)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll21171;
		public override void putAll(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._putAll21171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._putAll21171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove21172;
		public override global::java.lang.Object remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._remove21172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._remove21172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove21173;
		public virtual bool remove(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._remove21173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._remove21173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _elements21174;
		public virtual global::java.util.Enumeration elements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._elements21174)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._elements21174)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keys21175;
		public virtual global::java.util.Enumeration keys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._keys21175)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._keys21175)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keySet21176;
		public override global::java.util.Set keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._keySet21176)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._keySet21176)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue21177;
		public override bool containsValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._containsValue21177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._containsValue21177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey21178;
		public override bool containsKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._containsKey21178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._containsKey21178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putIfAbsent21179;
		public virtual global::java.lang.Object putIfAbsent(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._putIfAbsent21179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._putIfAbsent21179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _ConcurrentHashMap21180;
		public ConcurrentHashMap(java.util.Map arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._ConcurrentHashMap21180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConcurrentHashMap21181;
		public ConcurrentHashMap(int arg0, float arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._ConcurrentHashMap21181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConcurrentHashMap21182;
		public ConcurrentHashMap(int arg0, float arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._ConcurrentHashMap21182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConcurrentHashMap21183;
		public ConcurrentHashMap(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._ConcurrentHashMap21183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConcurrentHashMap21184;
		public ConcurrentHashMap()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._ConcurrentHashMap21184);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ConcurrentHashMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ConcurrentHashMap"));
			global::java.util.concurrent.ConcurrentHashMap._get21161 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentHashMap._put21162 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentHashMap._values21163 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.concurrent.ConcurrentHashMap._clear21164 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "clear", "()V");
			global::java.util.concurrent.ConcurrentHashMap._isEmpty21165 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "isEmpty", "()Z");
			global::java.util.concurrent.ConcurrentHashMap._replace21166 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentHashMap._replace21167 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentHashMap._contains21168 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentHashMap._size21169 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "size", "()I");
			global::java.util.concurrent.ConcurrentHashMap._entrySet21170 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.concurrent.ConcurrentHashMap._putAll21171 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.concurrent.ConcurrentHashMap._remove21172 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentHashMap._remove21173 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentHashMap._elements21174 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.util.concurrent.ConcurrentHashMap._keys21175 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "keys", "()Ljava/util/Enumeration;");
			global::java.util.concurrent.ConcurrentHashMap._keySet21176 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.concurrent.ConcurrentHashMap._containsValue21177 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentHashMap._containsKey21178 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentHashMap._putIfAbsent21179 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentHashMap._ConcurrentHashMap21180 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::java.util.concurrent.ConcurrentHashMap._ConcurrentHashMap21181 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "<init>", "(IFI)V");
			global::java.util.concurrent.ConcurrentHashMap._ConcurrentHashMap21182 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "<init>", "(IF)V");
			global::java.util.concurrent.ConcurrentHashMap._ConcurrentHashMap21183 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "<init>", "(I)V");
			global::java.util.concurrent.ConcurrentHashMap._ConcurrentHashMap21184 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "<init>", "()V");
		}
	}
}

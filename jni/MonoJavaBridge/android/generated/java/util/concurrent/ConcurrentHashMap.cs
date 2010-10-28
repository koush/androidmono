namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConcurrentHashMap : java.util.AbstractMap, ConcurrentMap, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConcurrentHashMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27110;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._get27110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._get27110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put27111;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._put27111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._put27111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _values27112;
		public override global::java.util.Collection values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._values27112)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._values27112)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _clear27113;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._clear27113);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._clear27113);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty27114;
		public override bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._isEmpty27114);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._isEmpty27114);
		}
		internal static global::MonoJavaBridge.MethodId _replace27115;
		public virtual global::java.lang.Object replace(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._replace27115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._replace27115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _replace27116;
		public virtual bool replace(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._replace27116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._replace27116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _contains27117;
		public virtual bool contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._contains27117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._contains27117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size27118;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._size27118);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._size27118);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet27119;
		public override global::java.util.Set entrySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._entrySet27119)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._entrySet27119)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll27120;
		public override void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._putAll27120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._putAll27120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove27121;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._remove27121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._remove27121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove27122;
		public virtual bool remove(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._remove27122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._remove27122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _elements27123;
		public virtual global::java.util.Enumeration elements()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._elements27123)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._elements27123)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keys27124;
		public virtual global::java.util.Enumeration keys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._keys27124)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._keys27124)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keySet27125;
		public override global::java.util.Set keySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._keySet27125)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._keySet27125)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue27126;
		public override bool containsValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._containsValue27126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._containsValue27126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey27127;
		public override bool containsKey(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._containsKey27127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._containsKey27127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putIfAbsent27128;
		public virtual global::java.lang.Object putIfAbsent(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap._putIfAbsent27128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._putIfAbsent27128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _ConcurrentHashMap27129;
		public ConcurrentHashMap(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._ConcurrentHashMap27129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConcurrentHashMap27130;
		public ConcurrentHashMap(int arg0, float arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._ConcurrentHashMap27130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConcurrentHashMap27131;
		public ConcurrentHashMap(int arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._ConcurrentHashMap27131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConcurrentHashMap27132;
		public ConcurrentHashMap(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._ConcurrentHashMap27132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConcurrentHashMap27133;
		public ConcurrentHashMap() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._ConcurrentHashMap27133);
			Init(@__env, handle);
		}
		static ConcurrentHashMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ConcurrentHashMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ConcurrentHashMap"));
			global::java.util.concurrent.ConcurrentHashMap._get27110 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentHashMap._put27111 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentHashMap._values27112 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.concurrent.ConcurrentHashMap._clear27113 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "clear", "()V");
			global::java.util.concurrent.ConcurrentHashMap._isEmpty27114 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "isEmpty", "()Z");
			global::java.util.concurrent.ConcurrentHashMap._replace27115 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentHashMap._replace27116 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentHashMap._contains27117 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentHashMap._size27118 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "size", "()I");
			global::java.util.concurrent.ConcurrentHashMap._entrySet27119 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.concurrent.ConcurrentHashMap._putAll27120 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.concurrent.ConcurrentHashMap._remove27121 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentHashMap._remove27122 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentHashMap._elements27123 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.util.concurrent.ConcurrentHashMap._keys27124 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "keys", "()Ljava/util/Enumeration;");
			global::java.util.concurrent.ConcurrentHashMap._keySet27125 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.concurrent.ConcurrentHashMap._containsValue27126 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentHashMap._containsKey27127 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentHashMap._putIfAbsent27128 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentHashMap._ConcurrentHashMap27129 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::java.util.concurrent.ConcurrentHashMap._ConcurrentHashMap27130 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "<init>", "(IFI)V");
			global::java.util.concurrent.ConcurrentHashMap._ConcurrentHashMap27131 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "<init>", "(IF)V");
			global::java.util.concurrent.ConcurrentHashMap._ConcurrentHashMap27132 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "<init>", "(I)V");
			global::java.util.concurrent.ConcurrentHashMap._ConcurrentHashMap27133 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}

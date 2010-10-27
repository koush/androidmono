namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WeakHashMap : java.util.AbstractMap, Map
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WeakHashMap()
		{
			InitJNI();
		}
		protected WeakHashMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27008;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.WeakHashMap._get27008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._get27008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put27009;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.WeakHashMap._put27009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._put27009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _values27010;
		public override global::java.util.Collection values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.WeakHashMap._values27010)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._values27010)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _clear27011;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.WeakHashMap._clear27011);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._clear27011);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty27012;
		public override bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.WeakHashMap._isEmpty27012);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._isEmpty27012);
		}
		internal static global::MonoJavaBridge.MethodId _size27013;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.WeakHashMap._size27013);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._size27013);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet27014;
		public override global::java.util.Set entrySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.WeakHashMap._entrySet27014)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._entrySet27014)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll27015;
		public override void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.WeakHashMap._putAll27015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._putAll27015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove27016;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.WeakHashMap._remove27016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._remove27016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet27017;
		public override global::java.util.Set keySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.WeakHashMap._keySet27017)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._keySet27017)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue27018;
		public override bool containsValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.WeakHashMap._containsValue27018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._containsValue27018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey27019;
		public override bool containsKey(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.WeakHashMap._containsKey27019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._containsKey27019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _WeakHashMap27020;
		public WeakHashMap(int arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._WeakHashMap27020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WeakHashMap27021;
		public WeakHashMap(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._WeakHashMap27021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WeakHashMap27022;
		public WeakHashMap() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._WeakHashMap27022);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WeakHashMap27023;
		public WeakHashMap(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._WeakHashMap27023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.WeakHashMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/WeakHashMap"));
			global::java.util.WeakHashMap._get27008 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.WeakHashMap._put27009 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.WeakHashMap._values27010 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.WeakHashMap._clear27011 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "clear", "()V");
			global::java.util.WeakHashMap._isEmpty27012 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "isEmpty", "()Z");
			global::java.util.WeakHashMap._size27013 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "size", "()I");
			global::java.util.WeakHashMap._entrySet27014 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.WeakHashMap._putAll27015 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.WeakHashMap._remove27016 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.WeakHashMap._keySet27017 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.WeakHashMap._containsValue27018 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.WeakHashMap._containsKey27019 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.WeakHashMap._WeakHashMap27020 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "<init>", "(IF)V");
			global::java.util.WeakHashMap._WeakHashMap27021 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "<init>", "(I)V");
			global::java.util.WeakHashMap._WeakHashMap27022 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "<init>", "()V");
			global::java.util.WeakHashMap._WeakHashMap27023 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "<init>", "(Ljava/util/Map;)V");
		}
	}
}

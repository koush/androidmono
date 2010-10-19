namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HashMap : java.util.AbstractMap, Map, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HashMap()
		{
			InitJNI();
		}
		protected HashMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get20297;
		public override global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.HashMap._get20297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._get20297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put20298;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.HashMap._put20298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._put20298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _values20299;
		public override global::java.util.Collection values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.HashMap._values20299)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._values20299)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _clone20300;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.HashMap._clone20300)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._clone20300)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear20301;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.HashMap._clear20301);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._clear20301);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty20302;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.HashMap._isEmpty20302);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._isEmpty20302);
		}
		internal static global::MonoJavaBridge.MethodId _size20303;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.HashMap._size20303);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._size20303);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet20304;
		public override global::java.util.Set entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.HashMap._entrySet20304)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._entrySet20304)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll20305;
		public override void putAll(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.HashMap._putAll20305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._putAll20305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove20306;
		public override global::java.lang.Object remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.HashMap._remove20306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._remove20306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet20307;
		public override global::java.util.Set keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.HashMap._keySet20307)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._keySet20307)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue20308;
		public override bool containsValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.HashMap._containsValue20308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._containsValue20308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey20309;
		public override bool containsKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.HashMap._containsKey20309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._containsKey20309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HashMap20310;
		public HashMap(int arg0, float arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashMap.staticClass, global::java.util.HashMap._HashMap20310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashMap20311;
		public HashMap(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashMap.staticClass, global::java.util.HashMap._HashMap20311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashMap20312;
		public HashMap()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashMap.staticClass, global::java.util.HashMap._HashMap20312);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashMap20313;
		public HashMap(java.util.Map arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashMap.staticClass, global::java.util.HashMap._HashMap20313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.HashMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/HashMap"));
			global::java.util.HashMap._get20297 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.HashMap._put20298 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.HashMap._values20299 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.HashMap._clone20300 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.HashMap._clear20301 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "clear", "()V");
			global::java.util.HashMap._isEmpty20302 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "isEmpty", "()Z");
			global::java.util.HashMap._size20303 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "size", "()I");
			global::java.util.HashMap._entrySet20304 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.HashMap._putAll20305 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.HashMap._remove20306 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.HashMap._keySet20307 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.HashMap._containsValue20308 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.HashMap._containsKey20309 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.HashMap._HashMap20310 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "<init>", "(IF)V");
			global::java.util.HashMap._HashMap20311 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "<init>", "(I)V");
			global::java.util.HashMap._HashMap20312 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "<init>", "()V");
			global::java.util.HashMap._HashMap20313 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "<init>", "(Ljava/util/Map;)V");
		}
	}
}

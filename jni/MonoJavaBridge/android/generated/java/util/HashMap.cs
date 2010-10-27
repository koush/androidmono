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
		internal static global::MonoJavaBridge.MethodId _get26240;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.HashMap._get26240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._get26240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26241;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.HashMap._put26241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._put26241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _values26242;
		public override global::java.util.Collection values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.HashMap._values26242)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._values26242)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _clone26243;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.HashMap._clone26243)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._clone26243)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear26244;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.HashMap._clear26244);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._clear26244);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26245;
		public override bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.HashMap._isEmpty26245);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._isEmpty26245);
		}
		internal static global::MonoJavaBridge.MethodId _size26246;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.HashMap._size26246);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._size26246);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26247;
		public override global::java.util.Set entrySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.HashMap._entrySet26247)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._entrySet26247)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll26248;
		public override void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.HashMap._putAll26248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._putAll26248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26249;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.HashMap._remove26249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._remove26249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26250;
		public override global::java.util.Set keySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.HashMap._keySet26250)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._keySet26250)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26251;
		public override bool containsValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.HashMap._containsValue26251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._containsValue26251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey26252;
		public override bool containsKey(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.HashMap._containsKey26252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.HashMap.staticClass, global::java.util.HashMap._containsKey26252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HashMap26253;
		public HashMap(int arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashMap.staticClass, global::java.util.HashMap._HashMap26253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashMap26254;
		public HashMap(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashMap.staticClass, global::java.util.HashMap._HashMap26254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashMap26255;
		public HashMap() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashMap.staticClass, global::java.util.HashMap._HashMap26255);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashMap26256;
		public HashMap(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashMap.staticClass, global::java.util.HashMap._HashMap26256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.HashMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/HashMap"));
			global::java.util.HashMap._get26240 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.HashMap._put26241 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.HashMap._values26242 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.HashMap._clone26243 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.HashMap._clear26244 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "clear", "()V");
			global::java.util.HashMap._isEmpty26245 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "isEmpty", "()Z");
			global::java.util.HashMap._size26246 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "size", "()I");
			global::java.util.HashMap._entrySet26247 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.HashMap._putAll26248 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.HashMap._remove26249 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.HashMap._keySet26250 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.HashMap._containsValue26251 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.HashMap._containsKey26252 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.HashMap._HashMap26253 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "<init>", "(IF)V");
			global::java.util.HashMap._HashMap26254 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "<init>", "(I)V");
			global::java.util.HashMap._HashMap26255 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "<init>", "()V");
			global::java.util.HashMap._HashMap26256 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "<init>", "(Ljava/util/Map;)V");
		}
	}
}

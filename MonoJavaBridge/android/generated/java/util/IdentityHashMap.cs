namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IdentityHashMap : java.util.AbstractMap, Map, java.io.Serializable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IdentityHashMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get26294;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._get26294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._get26294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26295;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._put26295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._put26295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals26296;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap._equals26296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._equals26296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _values26297;
		public override global::java.util.Collection values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._values26297)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._values26297)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26298;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.IdentityHashMap._hashCode26298);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._hashCode26298);
		}
		internal static global::MonoJavaBridge.MethodId _clone26299;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._clone26299)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._clone26299)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear26300;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.IdentityHashMap._clear26300);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._clear26300);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26301;
		public override bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap._isEmpty26301);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._isEmpty26301);
		}
		internal static global::MonoJavaBridge.MethodId _size26302;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.IdentityHashMap._size26302);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._size26302);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26303;
		public override global::java.util.Set entrySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._entrySet26303)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._entrySet26303)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll26304;
		public override void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.IdentityHashMap._putAll26304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._putAll26304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26305;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._remove26305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._remove26305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26306;
		public override global::java.util.Set keySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._keySet26306)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._keySet26306)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26307;
		public override bool containsValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap._containsValue26307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._containsValue26307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey26308;
		public override bool containsKey(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap._containsKey26308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._containsKey26308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _IdentityHashMap26309;
		public IdentityHashMap(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._IdentityHashMap26309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IdentityHashMap26310;
		public IdentityHashMap() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._IdentityHashMap26310);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IdentityHashMap26311;
		public IdentityHashMap(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._IdentityHashMap26311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IdentityHashMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.IdentityHashMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/IdentityHashMap"));
			global::java.util.IdentityHashMap._get26294 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.IdentityHashMap._put26295 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.IdentityHashMap._equals26296 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.IdentityHashMap._values26297 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.IdentityHashMap._hashCode26298 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "hashCode", "()I");
			global::java.util.IdentityHashMap._clone26299 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.IdentityHashMap._clear26300 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "clear", "()V");
			global::java.util.IdentityHashMap._isEmpty26301 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "isEmpty", "()Z");
			global::java.util.IdentityHashMap._size26302 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "size", "()I");
			global::java.util.IdentityHashMap._entrySet26303 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.IdentityHashMap._putAll26304 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.IdentityHashMap._remove26305 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.IdentityHashMap._keySet26306 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.IdentityHashMap._containsValue26307 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.IdentityHashMap._containsKey26308 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.IdentityHashMap._IdentityHashMap26309 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::java.util.IdentityHashMap._IdentityHashMap26310 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "<init>", "()V");
			global::java.util.IdentityHashMap._IdentityHashMap26311 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "<init>", "(I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}

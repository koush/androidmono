namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IdentityHashMap : java.util.AbstractMap, Map, java.io.Serializable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IdentityHashMap()
		{
			InitJNI();
		}
		protected IdentityHashMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get26293;
		public override global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._get26293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._get26293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26294;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._put26294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._put26294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals26295;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap._equals26295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._equals26295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _values26296;
		public override global::java.util.Collection values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._values26296)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._values26296)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26297;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.IdentityHashMap._hashCode26297);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._hashCode26297);
		}
		internal static global::MonoJavaBridge.MethodId _clone26298;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._clone26298)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._clone26298)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear26299;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.IdentityHashMap._clear26299);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._clear26299);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26300;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap._isEmpty26300);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._isEmpty26300);
		}
		internal static global::MonoJavaBridge.MethodId _size26301;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.IdentityHashMap._size26301);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._size26301);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26302;
		public override global::java.util.Set entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._entrySet26302)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._entrySet26302)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll26303;
		public override void putAll(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.IdentityHashMap._putAll26303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._putAll26303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26304;
		public override global::java.lang.Object remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._remove26304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._remove26304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26305;
		public override global::java.util.Set keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._keySet26305)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._keySet26305)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26306;
		public override bool containsValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap._containsValue26306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._containsValue26306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey26307;
		public override bool containsKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap._containsKey26307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._containsKey26307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _IdentityHashMap26308;
		public IdentityHashMap(java.util.Map arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._IdentityHashMap26308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IdentityHashMap26309;
		public IdentityHashMap()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._IdentityHashMap26309);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IdentityHashMap26310;
		public IdentityHashMap(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._IdentityHashMap26310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.IdentityHashMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/IdentityHashMap"));
			global::java.util.IdentityHashMap._get26293 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.IdentityHashMap._put26294 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.IdentityHashMap._equals26295 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.IdentityHashMap._values26296 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.IdentityHashMap._hashCode26297 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "hashCode", "()I");
			global::java.util.IdentityHashMap._clone26298 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.IdentityHashMap._clear26299 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "clear", "()V");
			global::java.util.IdentityHashMap._isEmpty26300 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "isEmpty", "()Z");
			global::java.util.IdentityHashMap._size26301 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "size", "()I");
			global::java.util.IdentityHashMap._entrySet26302 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.IdentityHashMap._putAll26303 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.IdentityHashMap._remove26304 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.IdentityHashMap._keySet26305 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.IdentityHashMap._containsValue26306 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.IdentityHashMap._containsKey26307 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.IdentityHashMap._IdentityHashMap26308 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::java.util.IdentityHashMap._IdentityHashMap26309 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "<init>", "()V");
			global::java.util.IdentityHashMap._IdentityHashMap26310 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "<init>", "(I)V");
		}
	}
}

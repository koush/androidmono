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
		internal static global::MonoJavaBridge.MethodId _get20350;
		public override global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._get20350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._get20350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put20351;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._put20351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._put20351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals20352;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap._equals20352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._equals20352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _values20353;
		public override global::java.util.Collection values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._values20353)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._values20353)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20354;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.IdentityHashMap._hashCode20354);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._hashCode20354);
		}
		internal static global::MonoJavaBridge.MethodId _clone20355;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._clone20355)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._clone20355)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear20356;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.IdentityHashMap._clear20356);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._clear20356);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty20357;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap._isEmpty20357);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._isEmpty20357);
		}
		internal static global::MonoJavaBridge.MethodId _size20358;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.IdentityHashMap._size20358);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._size20358);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet20359;
		public override global::java.util.Set entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._entrySet20359)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._entrySet20359)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll20360;
		public override void putAll(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.IdentityHashMap._putAll20360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._putAll20360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove20361;
		public override global::java.lang.Object remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._remove20361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._remove20361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet20362;
		public override global::java.util.Set keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._keySet20362)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._keySet20362)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue20363;
		public override bool containsValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap._containsValue20363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._containsValue20363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey20364;
		public override bool containsKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap._containsKey20364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._containsKey20364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _IdentityHashMap20365;
		public IdentityHashMap(java.util.Map arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._IdentityHashMap20365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IdentityHashMap20366;
		public IdentityHashMap()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._IdentityHashMap20366);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IdentityHashMap20367;
		public IdentityHashMap(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._IdentityHashMap20367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.IdentityHashMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/IdentityHashMap"));
			global::java.util.IdentityHashMap._get20350 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.IdentityHashMap._put20351 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.IdentityHashMap._equals20352 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.IdentityHashMap._values20353 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.IdentityHashMap._hashCode20354 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "hashCode", "()I");
			global::java.util.IdentityHashMap._clone20355 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.IdentityHashMap._clear20356 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "clear", "()V");
			global::java.util.IdentityHashMap._isEmpty20357 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "isEmpty", "()Z");
			global::java.util.IdentityHashMap._size20358 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "size", "()I");
			global::java.util.IdentityHashMap._entrySet20359 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.IdentityHashMap._putAll20360 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.IdentityHashMap._remove20361 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.IdentityHashMap._keySet20362 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.IdentityHashMap._containsValue20363 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.IdentityHashMap._containsKey20364 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.IdentityHashMap._IdentityHashMap20365 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::java.util.IdentityHashMap._IdentityHashMap20366 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "<init>", "()V");
			global::java.util.IdentityHashMap._IdentityHashMap20367 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "<init>", "(I)V");
		}
	}
}

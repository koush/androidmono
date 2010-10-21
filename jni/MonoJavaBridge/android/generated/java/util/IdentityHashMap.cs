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
		internal static global::MonoJavaBridge.MethodId _get26175;
		public override global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._get26175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._get26175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26176;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._put26176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._put26176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals26177;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap._equals26177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._equals26177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _values26178;
		public override global::java.util.Collection values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._values26178)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._values26178)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26179;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.IdentityHashMap._hashCode26179);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._hashCode26179);
		}
		internal static global::MonoJavaBridge.MethodId _clone26180;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._clone26180)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._clone26180)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear26181;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.IdentityHashMap._clear26181);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._clear26181);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26182;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap._isEmpty26182);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._isEmpty26182);
		}
		internal static global::MonoJavaBridge.MethodId _size26183;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.IdentityHashMap._size26183);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._size26183);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26184;
		public override global::java.util.Set entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._entrySet26184)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._entrySet26184)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll26185;
		public override void putAll(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.IdentityHashMap._putAll26185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._putAll26185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26186;
		public override global::java.lang.Object remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._remove26186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._remove26186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26187;
		public override global::java.util.Set keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap._keySet26187)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._keySet26187)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26188;
		public override bool containsValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap._containsValue26188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._containsValue26188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey26189;
		public override bool containsKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap._containsKey26189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._containsKey26189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _IdentityHashMap26190;
		public IdentityHashMap(java.util.Map arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._IdentityHashMap26190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IdentityHashMap26191;
		public IdentityHashMap()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._IdentityHashMap26191);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IdentityHashMap26192;
		public IdentityHashMap(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._IdentityHashMap26192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.IdentityHashMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/IdentityHashMap"));
			global::java.util.IdentityHashMap._get26175 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.IdentityHashMap._put26176 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.IdentityHashMap._equals26177 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.IdentityHashMap._values26178 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.IdentityHashMap._hashCode26179 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "hashCode", "()I");
			global::java.util.IdentityHashMap._clone26180 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.IdentityHashMap._clear26181 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "clear", "()V");
			global::java.util.IdentityHashMap._isEmpty26182 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "isEmpty", "()Z");
			global::java.util.IdentityHashMap._size26183 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "size", "()I");
			global::java.util.IdentityHashMap._entrySet26184 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.IdentityHashMap._putAll26185 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.IdentityHashMap._remove26186 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.IdentityHashMap._keySet26187 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.IdentityHashMap._containsValue26188 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.IdentityHashMap._containsKey26189 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.IdentityHashMap._IdentityHashMap26190 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::java.util.IdentityHashMap._IdentityHashMap26191 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "<init>", "()V");
			global::java.util.IdentityHashMap._IdentityHashMap26192 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "<init>", "(I)V");
		}
	}
}

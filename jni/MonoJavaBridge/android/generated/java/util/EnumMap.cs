namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EnumMap : java.util.AbstractMap, java.io.Serializable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EnumMap()
		{
			InitJNI();
		}
		protected EnumMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get26139;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.EnumMap._get26139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.EnumMap.staticClass, global::java.util.EnumMap._get26139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26140;
		public virtual global::java.lang.Object put(java.lang.Enum arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.EnumMap._put26140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.EnumMap.staticClass, global::java.util.EnumMap._put26140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals26141;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.EnumMap._equals26141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.EnumMap.staticClass, global::java.util.EnumMap._equals26141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _values26142;
		public override global::java.util.Collection values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.EnumMap._values26142)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.EnumMap.staticClass, global::java.util.EnumMap._values26142)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _clone26143;
		public virtual global::java.util.EnumMap clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.EnumMap._clone26143)) as java.util.EnumMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.EnumMap.staticClass, global::java.util.EnumMap._clone26143)) as java.util.EnumMap;
		}
		internal static global::MonoJavaBridge.MethodId _clear26144;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.EnumMap._clear26144);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.EnumMap.staticClass, global::java.util.EnumMap._clear26144);
		}
		internal static global::MonoJavaBridge.MethodId _size26145;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.EnumMap._size26145);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.EnumMap.staticClass, global::java.util.EnumMap._size26145);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26146;
		public override global::java.util.Set entrySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.EnumMap._entrySet26146)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.EnumMap.staticClass, global::java.util.EnumMap._entrySet26146)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll26147;
		public override void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.EnumMap._putAll26147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.EnumMap.staticClass, global::java.util.EnumMap._putAll26147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26148;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.EnumMap._remove26148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.EnumMap.staticClass, global::java.util.EnumMap._remove26148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26149;
		public override global::java.util.Set keySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.EnumMap._keySet26149)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.EnumMap.staticClass, global::java.util.EnumMap._keySet26149)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26150;
		public override bool containsValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.EnumMap._containsValue26150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.EnumMap.staticClass, global::java.util.EnumMap._containsValue26150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey26151;
		public override bool containsKey(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.EnumMap._containsKey26151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.EnumMap.staticClass, global::java.util.EnumMap._containsKey26151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _EnumMap26152;
		public EnumMap(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.EnumMap.staticClass, global::java.util.EnumMap._EnumMap26152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EnumMap26153;
		public EnumMap(java.lang.Class arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.EnumMap.staticClass, global::java.util.EnumMap._EnumMap26153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EnumMap26154;
		public EnumMap(java.util.EnumMap arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.EnumMap.staticClass, global::java.util.EnumMap._EnumMap26154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.EnumMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/EnumMap"));
			global::java.util.EnumMap._get26139 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.EnumMap._put26140 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "put", "(Ljava/lang/Enum;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.EnumMap._equals26141 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.EnumMap._values26142 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.EnumMap._clone26143 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "clone", "()Ljava/util/EnumMap;");
			global::java.util.EnumMap._clear26144 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "clear", "()V");
			global::java.util.EnumMap._size26145 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "size", "()I");
			global::java.util.EnumMap._entrySet26146 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.EnumMap._putAll26147 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.EnumMap._remove26148 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.EnumMap._keySet26149 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.EnumMap._containsValue26150 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.EnumMap._containsKey26151 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.EnumMap._EnumMap26152 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::java.util.EnumMap._EnumMap26153 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "<init>", "(Ljava/lang/Class;)V");
			global::java.util.EnumMap._EnumMap26154 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "<init>", "(Ljava/util/EnumMap;)V");
		}
	}
}

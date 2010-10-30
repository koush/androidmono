namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EnumMap : java.util.AbstractMap, java.io.Serializable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EnumMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get26140;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.EnumMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.EnumMap._get26140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26141;
		public virtual global::java.lang.Object put(java.lang.Enum arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.EnumMap.staticClass, "put", "(Ljava/lang/Enum;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.EnumMap._put26141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals26142;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.EnumMap.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.EnumMap._equals26142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _values26143;
		public override global::java.util.Collection values()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.EnumMap.staticClass, "values", "()Ljava/util/Collection;", ref global::java.util.EnumMap._values26143) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _clone26144;
		public virtual global::java.util.EnumMap clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.EnumMap.staticClass, "clone", "()Ljava/util/EnumMap;", ref global::java.util.EnumMap._clone26144) as java.util.EnumMap;
		}
		internal static global::MonoJavaBridge.MethodId _clear26145;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.EnumMap.staticClass, "clear", "()V", ref global::java.util.EnumMap._clear26145);
		}
		internal static global::MonoJavaBridge.MethodId _size26146;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.EnumMap.staticClass, "size", "()I", ref global::java.util.EnumMap._size26146);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26147;
		public override global::java.util.Set entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.EnumMap.staticClass, "entrySet", "()Ljava/util/Set;", ref global::java.util.EnumMap._entrySet26147) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll26148;
		public override void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.EnumMap.staticClass, "putAll", "(Ljava/util/Map;)V", ref global::java.util.EnumMap._putAll26148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26149;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.EnumMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.EnumMap._remove26149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26150;
		public override global::java.util.Set keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.EnumMap.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.util.EnumMap._keySet26150) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26151;
		public override bool containsValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.EnumMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z", ref global::java.util.EnumMap._containsValue26151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey26152;
		public override bool containsKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.EnumMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z", ref global::java.util.EnumMap._containsKey26152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _EnumMap26153;
		public EnumMap(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumMap._EnumMap26153.native == global::System.IntPtr.Zero)
				global::java.util.EnumMap._EnumMap26153 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.EnumMap.staticClass, global::java.util.EnumMap._EnumMap26153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EnumMap26154;
		public EnumMap(java.lang.Class arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumMap._EnumMap26154.native == global::System.IntPtr.Zero)
				global::java.util.EnumMap._EnumMap26154 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "<init>", "(Ljava/lang/Class;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.EnumMap.staticClass, global::java.util.EnumMap._EnumMap26154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EnumMap26155;
		public EnumMap(java.util.EnumMap arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumMap._EnumMap26155.native == global::System.IntPtr.Zero)
				global::java.util.EnumMap._EnumMap26155 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "<init>", "(Ljava/util/EnumMap;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.EnumMap.staticClass, global::java.util.EnumMap._EnumMap26155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static EnumMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.EnumMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/EnumMap"));
		}
		internal static void InitJNI()
		{
		}
	}
}

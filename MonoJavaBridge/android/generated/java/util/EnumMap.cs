namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EnumMap : java.util.AbstractMap, java.io.Serializable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EnumMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.EnumMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.EnumMap._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object put(java.lang.Enum arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.EnumMap.staticClass, "put", "(Ljava/lang/Enum;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.EnumMap._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.EnumMap.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.EnumMap._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.util.Collection values()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.EnumMap.staticClass, "values", "()Ljava/util/Collection;", ref global::java.util.EnumMap._m3) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.util.EnumMap clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.EnumMap.staticClass, "clone", "()Ljava/util/EnumMap;", ref global::java.util.EnumMap._m4) as java.util.EnumMap;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.EnumMap.staticClass, "clear", "()V", ref global::java.util.EnumMap._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.EnumMap.staticClass, "size", "()I", ref global::java.util.EnumMap._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.util.Set entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.EnumMap.staticClass, "entrySet", "()Ljava/util/Set;", ref global::java.util.EnumMap._m7) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.EnumMap.staticClass, "putAll", "(Ljava/util/Map;)V", ref global::java.util.EnumMap._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.EnumMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.EnumMap._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::java.util.Set keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.EnumMap.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.util.EnumMap._m10) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override bool containsValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.EnumMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z", ref global::java.util.EnumMap._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override bool containsKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.EnumMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z", ref global::java.util.EnumMap._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public EnumMap(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumMap._m13.native == global::System.IntPtr.Zero)
				global::java.util.EnumMap._m13 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.EnumMap.staticClass, global::java.util.EnumMap._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public EnumMap(java.lang.Class arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumMap._m14.native == global::System.IntPtr.Zero)
				global::java.util.EnumMap._m14 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "<init>", "(Ljava/lang/Class;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.EnumMap.staticClass, global::java.util.EnumMap._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public EnumMap(java.util.EnumMap arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumMap._m15.native == global::System.IntPtr.Zero)
				global::java.util.EnumMap._m15 = @__env.GetMethodIDNoThrow(global::java.util.EnumMap.staticClass, "<init>", "(Ljava/util/EnumMap;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.EnumMap.staticClass, global::java.util.EnumMap._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static EnumMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.EnumMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/EnumMap"));
		}
	}
}

namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HashMap : java.util.AbstractMap, Map, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HashMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.HashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.HashMap._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.HashMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.HashMap._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.util.Collection values()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.HashMap.staticClass, "values", "()Ljava/util/Collection;", ref global::java.util.HashMap._m2) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.HashMap.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.HashMap._m3) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.HashMap.staticClass, "clear", "()V", ref global::java.util.HashMap._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.HashMap.staticClass, "isEmpty", "()Z", ref global::java.util.HashMap._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.HashMap.staticClass, "size", "()I", ref global::java.util.HashMap._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.util.Set entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.HashMap.staticClass, "entrySet", "()Ljava/util/Set;", ref global::java.util.HashMap._m7) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.HashMap.staticClass, "putAll", "(Ljava/util/Map;)V", ref global::java.util.HashMap._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.HashMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.HashMap._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::java.util.Set keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.HashMap.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.util.HashMap._m10) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override bool containsValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.HashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z", ref global::java.util.HashMap._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override bool containsKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.HashMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z", ref global::java.util.HashMap._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public HashMap(int arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.HashMap._m13.native == global::System.IntPtr.Zero)
				global::java.util.HashMap._m13 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "<init>", "(IF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashMap.staticClass, global::java.util.HashMap._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public HashMap(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.HashMap._m14.native == global::System.IntPtr.Zero)
				global::java.util.HashMap._m14 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashMap.staticClass, global::java.util.HashMap._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public HashMap() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.HashMap._m15.native == global::System.IntPtr.Zero)
				global::java.util.HashMap._m15 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashMap.staticClass, global::java.util.HashMap._m15);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public HashMap(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.HashMap._m16.native == global::System.IntPtr.Zero)
				global::java.util.HashMap._m16 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashMap.staticClass, global::java.util.HashMap._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static HashMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.HashMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/HashMap"));
		}
		internal static void InitJNI()
		{
		}
	}
}

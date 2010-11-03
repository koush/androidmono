namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WeakHashMap : java.util.AbstractMap, Map
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WeakHashMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.WeakHashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.WeakHashMap._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.WeakHashMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.WeakHashMap._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.util.Collection values()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.WeakHashMap.staticClass, "values", "()Ljava/util/Collection;", ref global::java.util.WeakHashMap._m2) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.WeakHashMap.staticClass, "clear", "()V", ref global::java.util.WeakHashMap._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.WeakHashMap.staticClass, "isEmpty", "()Z", ref global::java.util.WeakHashMap._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.WeakHashMap.staticClass, "size", "()I", ref global::java.util.WeakHashMap._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.util.Set entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.WeakHashMap.staticClass, "entrySet", "()Ljava/util/Set;", ref global::java.util.WeakHashMap._m6) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.WeakHashMap.staticClass, "putAll", "(Ljava/util/Map;)V", ref global::java.util.WeakHashMap._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.WeakHashMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.WeakHashMap._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.util.Set keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.WeakHashMap.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.util.WeakHashMap._m9) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override bool containsValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.WeakHashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z", ref global::java.util.WeakHashMap._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override bool containsKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.WeakHashMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z", ref global::java.util.WeakHashMap._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public WeakHashMap(int arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.WeakHashMap._m12.native == global::System.IntPtr.Zero)
				global::java.util.WeakHashMap._m12 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "<init>", "(IF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public WeakHashMap(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.WeakHashMap._m13.native == global::System.IntPtr.Zero)
				global::java.util.WeakHashMap._m13 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public WeakHashMap() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.WeakHashMap._m14.native == global::System.IntPtr.Zero)
				global::java.util.WeakHashMap._m14 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._m14);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public WeakHashMap(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.WeakHashMap._m15.native == global::System.IntPtr.Zero)
				global::java.util.WeakHashMap._m15 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static WeakHashMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.WeakHashMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/WeakHashMap"));
		}
	}
}

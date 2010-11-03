namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConcurrentHashMap : java.util.AbstractMap, ConcurrentMap, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConcurrentHashMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ConcurrentHashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentHashMap._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ConcurrentHashMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentHashMap._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.util.Collection values()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.ConcurrentHashMap.staticClass, "values", "()Ljava/util/Collection;", ref global::java.util.concurrent.ConcurrentHashMap._m2) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ConcurrentHashMap.staticClass, "clear", "()V", ref global::java.util.concurrent.ConcurrentHashMap._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentHashMap.staticClass, "isEmpty", "()Z", ref global::java.util.concurrent.ConcurrentHashMap._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.Object replace(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ConcurrentHashMap.staticClass, "replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentHashMap._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool replace(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentHashMap.staticClass, "replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentHashMap._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentHashMap.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentHashMap._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.ConcurrentHashMap.staticClass, "size", "()I", ref global::java.util.concurrent.ConcurrentHashMap._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.util.Set entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.concurrent.ConcurrentHashMap.staticClass, "entrySet", "()Ljava/util/Set;", ref global::java.util.concurrent.ConcurrentHashMap._m9) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ConcurrentHashMap.staticClass, "putAll", "(Ljava/util/Map;)V", ref global::java.util.concurrent.ConcurrentHashMap._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ConcurrentHashMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentHashMap._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool remove(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentHashMap.staticClass, "remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentHashMap._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.util.Enumeration elements()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.util.concurrent.ConcurrentHashMap.staticClass, "elements", "()Ljava/util/Enumeration;", ref global::java.util.concurrent.ConcurrentHashMap._m13) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.util.Enumeration keys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.util.concurrent.ConcurrentHashMap.staticClass, "keys", "()Ljava/util/Enumeration;", ref global::java.util.concurrent.ConcurrentHashMap._m14) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override global::java.util.Set keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.concurrent.ConcurrentHashMap.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.util.concurrent.ConcurrentHashMap._m15) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override bool containsValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentHashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentHashMap._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override bool containsKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentHashMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentHashMap._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.lang.Object putIfAbsent(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ConcurrentHashMap.staticClass, "putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentHashMap._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public ConcurrentHashMap(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ConcurrentHashMap._m19.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ConcurrentHashMap._m19 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public ConcurrentHashMap(int arg0, float arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ConcurrentHashMap._m20.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ConcurrentHashMap._m20 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "<init>", "(IFI)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public ConcurrentHashMap(int arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ConcurrentHashMap._m21.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ConcurrentHashMap._m21 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "<init>", "(IF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public ConcurrentHashMap(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ConcurrentHashMap._m22.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ConcurrentHashMap._m22 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public ConcurrentHashMap() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ConcurrentHashMap._m23.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ConcurrentHashMap._m23 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentHashMap.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentHashMap.staticClass, global::java.util.concurrent.ConcurrentHashMap._m23);
			Init(@__env, handle);
		}
		static ConcurrentHashMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ConcurrentHashMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ConcurrentHashMap"));
		}
	}
}

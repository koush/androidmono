namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IdentityHashMap : java.util.AbstractMap, Map, java.io.Serializable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IdentityHashMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.IdentityHashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.IdentityHashMap._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.IdentityHashMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.IdentityHashMap._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.IdentityHashMap.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.IdentityHashMap._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.util.Collection values()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.IdentityHashMap.staticClass, "values", "()Ljava/util/Collection;", ref global::java.util.IdentityHashMap._m3) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.IdentityHashMap.staticClass, "hashCode", "()I", ref global::java.util.IdentityHashMap._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.IdentityHashMap.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.IdentityHashMap._m5) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.IdentityHashMap.staticClass, "clear", "()V", ref global::java.util.IdentityHashMap._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.IdentityHashMap.staticClass, "isEmpty", "()Z", ref global::java.util.IdentityHashMap._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.IdentityHashMap.staticClass, "size", "()I", ref global::java.util.IdentityHashMap._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.util.Set entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.IdentityHashMap.staticClass, "entrySet", "()Ljava/util/Set;", ref global::java.util.IdentityHashMap._m9) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.IdentityHashMap.staticClass, "putAll", "(Ljava/util/Map;)V", ref global::java.util.IdentityHashMap._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.IdentityHashMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.IdentityHashMap._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override global::java.util.Set keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.IdentityHashMap.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.util.IdentityHashMap._m12) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override bool containsValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.IdentityHashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z", ref global::java.util.IdentityHashMap._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override bool containsKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.IdentityHashMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z", ref global::java.util.IdentityHashMap._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public IdentityHashMap(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.IdentityHashMap._m15.native == global::System.IntPtr.Zero)
				global::java.util.IdentityHashMap._m15 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public IdentityHashMap() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.IdentityHashMap._m16.native == global::System.IntPtr.Zero)
				global::java.util.IdentityHashMap._m16 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._m16);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public IdentityHashMap(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.IdentityHashMap._m17.native == global::System.IntPtr.Zero)
				global::java.util.IdentityHashMap._m17 = @__env.GetMethodIDNoThrow(global::java.util.IdentityHashMap.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IdentityHashMap.staticClass, global::java.util.IdentityHashMap._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IdentityHashMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.IdentityHashMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/IdentityHashMap"));
		}
	}
}

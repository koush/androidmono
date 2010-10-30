namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WeakHashMap : java.util.AbstractMap, Map
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WeakHashMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27009;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.WeakHashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.WeakHashMap._get27009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put27010;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.WeakHashMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.WeakHashMap._put27010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _values27011;
		public override global::java.util.Collection values()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.WeakHashMap.staticClass, "values", "()Ljava/util/Collection;", ref global::java.util.WeakHashMap._values27011) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _clear27012;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.WeakHashMap.staticClass, "clear", "()V", ref global::java.util.WeakHashMap._clear27012);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty27013;
		public override bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.WeakHashMap.staticClass, "isEmpty", "()Z", ref global::java.util.WeakHashMap._isEmpty27013);
		}
		internal static global::MonoJavaBridge.MethodId _size27014;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.WeakHashMap.staticClass, "size", "()I", ref global::java.util.WeakHashMap._size27014);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet27015;
		public override global::java.util.Set entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.WeakHashMap.staticClass, "entrySet", "()Ljava/util/Set;", ref global::java.util.WeakHashMap._entrySet27015) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll27016;
		public override void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.WeakHashMap.staticClass, "putAll", "(Ljava/util/Map;)V", ref global::java.util.WeakHashMap._putAll27016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove27017;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.WeakHashMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.WeakHashMap._remove27017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet27018;
		public override global::java.util.Set keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.WeakHashMap.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.util.WeakHashMap._keySet27018) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue27019;
		public override bool containsValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.WeakHashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z", ref global::java.util.WeakHashMap._containsValue27019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey27020;
		public override bool containsKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.WeakHashMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z", ref global::java.util.WeakHashMap._containsKey27020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _WeakHashMap27021;
		public WeakHashMap(int arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.WeakHashMap._WeakHashMap27021.native == global::System.IntPtr.Zero)
				global::java.util.WeakHashMap._WeakHashMap27021 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "<init>", "(IF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._WeakHashMap27021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WeakHashMap27022;
		public WeakHashMap(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.WeakHashMap._WeakHashMap27022.native == global::System.IntPtr.Zero)
				global::java.util.WeakHashMap._WeakHashMap27022 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._WeakHashMap27022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WeakHashMap27023;
		public WeakHashMap() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.WeakHashMap._WeakHashMap27023.native == global::System.IntPtr.Zero)
				global::java.util.WeakHashMap._WeakHashMap27023 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._WeakHashMap27023);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WeakHashMap27024;
		public WeakHashMap(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.WeakHashMap._WeakHashMap27024.native == global::System.IntPtr.Zero)
				global::java.util.WeakHashMap._WeakHashMap27024 = @__env.GetMethodIDNoThrow(global::java.util.WeakHashMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.WeakHashMap.staticClass, global::java.util.WeakHashMap._WeakHashMap27024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static WeakHashMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.WeakHashMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/WeakHashMap"));
		}
		internal static void InitJNI()
		{
		}
	}
}

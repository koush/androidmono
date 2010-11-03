namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinkedHashMap : java.util.HashMap, Map
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LinkedHashMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedHashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.LinkedHashMap._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.LinkedHashMap.staticClass, "clear", "()V", ref global::java.util.LinkedHashMap._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool containsValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedHashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z", ref global::java.util.LinkedHashMap._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual bool removeEldestEntry(java.util.Map_Entry arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedHashMap.staticClass, "removeEldestEntry", "(Ljava/util/Map$Entry;)Z", ref global::java.util.LinkedHashMap._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public LinkedHashMap(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedHashMap._m4.native == global::System.IntPtr.Zero)
				global::java.util.LinkedHashMap._m4 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public LinkedHashMap() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedHashMap._m5.native == global::System.IntPtr.Zero)
				global::java.util.LinkedHashMap._m5 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._m5);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public LinkedHashMap(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedHashMap._m6.native == global::System.IntPtr.Zero)
				global::java.util.LinkedHashMap._m6 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public LinkedHashMap(int arg0, float arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedHashMap._m7.native == global::System.IntPtr.Zero)
				global::java.util.LinkedHashMap._m7 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "<init>", "(IFZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public LinkedHashMap(int arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedHashMap._m8.native == global::System.IntPtr.Zero)
				global::java.util.LinkedHashMap._m8 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "<init>", "(IF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static LinkedHashMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.LinkedHashMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/LinkedHashMap"));
		}
	}
}

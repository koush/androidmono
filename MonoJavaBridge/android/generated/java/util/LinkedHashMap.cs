namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinkedHashMap : java.util.HashMap, Map
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LinkedHashMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get26335;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedHashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.LinkedHashMap._get26335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear26336;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.LinkedHashMap.staticClass, "clear", "()V", ref global::java.util.LinkedHashMap._clear26336);
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26337;
		public override bool containsValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedHashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z", ref global::java.util.LinkedHashMap._containsValue26337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeEldestEntry26338;
		protected virtual bool removeEldestEntry(java.util.Map_Entry arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedHashMap.staticClass, "removeEldestEntry", "(Ljava/util/Map$Entry;)Z", ref global::java.util.LinkedHashMap._removeEldestEntry26338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashMap26339;
		public LinkedHashMap(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedHashMap._LinkedHashMap26339.native == global::System.IntPtr.Zero)
				global::java.util.LinkedHashMap._LinkedHashMap26339 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._LinkedHashMap26339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashMap26340;
		public LinkedHashMap() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedHashMap._LinkedHashMap26340.native == global::System.IntPtr.Zero)
				global::java.util.LinkedHashMap._LinkedHashMap26340 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._LinkedHashMap26340);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashMap26341;
		public LinkedHashMap(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedHashMap._LinkedHashMap26341.native == global::System.IntPtr.Zero)
				global::java.util.LinkedHashMap._LinkedHashMap26341 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._LinkedHashMap26341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashMap26342;
		public LinkedHashMap(int arg0, float arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedHashMap._LinkedHashMap26342.native == global::System.IntPtr.Zero)
				global::java.util.LinkedHashMap._LinkedHashMap26342 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "<init>", "(IFZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._LinkedHashMap26342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashMap26343;
		public LinkedHashMap(int arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedHashMap._LinkedHashMap26343.native == global::System.IntPtr.Zero)
				global::java.util.LinkedHashMap._LinkedHashMap26343 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "<init>", "(IF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._LinkedHashMap26343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static LinkedHashMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.LinkedHashMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/LinkedHashMap"));
		}
		internal static void InitJNI()
		{
		}
	}
}

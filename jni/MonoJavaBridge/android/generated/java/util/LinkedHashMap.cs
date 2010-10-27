namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinkedHashMap : java.util.HashMap, Map
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LinkedHashMap()
		{
			InitJNI();
		}
		protected LinkedHashMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get26334;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedHashMap._get26334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._get26334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear26335;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.LinkedHashMap._clear26335);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._clear26335);
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26336;
		public override bool containsValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedHashMap._containsValue26336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._containsValue26336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeEldestEntry26337;
		protected virtual bool removeEldestEntry(java.util.Map_Entry arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedHashMap._removeEldestEntry26337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._removeEldestEntry26337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashMap26338;
		public LinkedHashMap(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._LinkedHashMap26338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashMap26339;
		public LinkedHashMap() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._LinkedHashMap26339);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashMap26340;
		public LinkedHashMap(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._LinkedHashMap26340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashMap26341;
		public LinkedHashMap(int arg0, float arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._LinkedHashMap26341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashMap26342;
		public LinkedHashMap(int arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._LinkedHashMap26342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.LinkedHashMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/LinkedHashMap"));
			global::java.util.LinkedHashMap._get26334 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.LinkedHashMap._clear26335 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "clear", "()V");
			global::java.util.LinkedHashMap._containsValue26336 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedHashMap._removeEldestEntry26337 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "removeEldestEntry", "(Ljava/util/Map$Entry;)Z");
			global::java.util.LinkedHashMap._LinkedHashMap26338 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "<init>", "(I)V");
			global::java.util.LinkedHashMap._LinkedHashMap26339 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "<init>", "()V");
			global::java.util.LinkedHashMap._LinkedHashMap26340 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::java.util.LinkedHashMap._LinkedHashMap26341 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "<init>", "(IFZ)V");
			global::java.util.LinkedHashMap._LinkedHashMap26342 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "<init>", "(IF)V");
		}
	}
}

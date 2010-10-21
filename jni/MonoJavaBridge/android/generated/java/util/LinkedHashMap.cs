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
		internal static global::MonoJavaBridge.MethodId _get26216;
		public override global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedHashMap._get26216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._get26216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear26217;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.LinkedHashMap._clear26217);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._clear26217);
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26218;
		public override bool containsValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedHashMap._containsValue26218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._containsValue26218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeEldestEntry26219;
		protected virtual bool removeEldestEntry(java.util.Map_Entry arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedHashMap._removeEldestEntry26219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._removeEldestEntry26219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashMap26220;
		public LinkedHashMap(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._LinkedHashMap26220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashMap26221;
		public LinkedHashMap()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._LinkedHashMap26221);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashMap26222;
		public LinkedHashMap(java.util.Map arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._LinkedHashMap26222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashMap26223;
		public LinkedHashMap(int arg0, float arg1, bool arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._LinkedHashMap26223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashMap26224;
		public LinkedHashMap(int arg0, float arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashMap.staticClass, global::java.util.LinkedHashMap._LinkedHashMap26224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.LinkedHashMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/LinkedHashMap"));
			global::java.util.LinkedHashMap._get26216 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.LinkedHashMap._clear26217 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "clear", "()V");
			global::java.util.LinkedHashMap._containsValue26218 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedHashMap._removeEldestEntry26219 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "removeEldestEntry", "(Ljava/util/Map$Entry;)Z");
			global::java.util.LinkedHashMap._LinkedHashMap26220 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "<init>", "(I)V");
			global::java.util.LinkedHashMap._LinkedHashMap26221 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "<init>", "()V");
			global::java.util.LinkedHashMap._LinkedHashMap26222 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::java.util.LinkedHashMap._LinkedHashMap26223 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "<init>", "(IFZ)V");
			global::java.util.LinkedHashMap._LinkedHashMap26224 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashMap.staticClass, "<init>", "(IF)V");
		}
	}
}

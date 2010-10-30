namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Map_))]
	public partial interface Map  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object get(java.lang.Object arg0);
		global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1);
		bool equals(java.lang.Object arg0);
		global::java.util.Collection values();
		int hashCode();
		void clear();
		bool isEmpty();
		int size();
		global::java.util.Set entrySet();
		void putAll(java.util.Map arg0);
		global::java.lang.Object remove(java.lang.Object arg0);
		global::java.util.Set keySet();
		bool containsValue(java.lang.Object arg0);
		bool containsKey(java.lang.Object arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Map))]
	internal sealed partial class Map_ : java.lang.Object, Map
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Map_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get26502;
		global::java.lang.Object java.util.Map.get(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Map_._get26502.native == global::System.IntPtr.Zero)
				global::java.util.Map_._get26502 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_._get26502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26503;
		global::java.lang.Object java.util.Map.put(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Map_._put26503.native == global::System.IntPtr.Zero)
				global::java.util.Map_._put26503 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_._put26503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals26504;
		bool java.util.Map.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Map_._equals26504.native == global::System.IntPtr.Zero)
				global::java.util.Map_._equals26504 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Map_._equals26504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _values26505;
		global::java.util.Collection java.util.Map.values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Map_._values26505.native == global::System.IntPtr.Zero)
				global::java.util.Map_._values26505 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "values", "()Ljava/util/Collection;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_._values26505)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26506;
		int java.util.Map.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Map_._hashCode26506.native == global::System.IntPtr.Zero)
				global::java.util.Map_._hashCode26506 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "hashCode", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.Map_._hashCode26506);
		}
		internal static global::MonoJavaBridge.MethodId _clear26507;
		void java.util.Map.clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Map_._clear26507.native == global::System.IntPtr.Zero)
				global::java.util.Map_._clear26507 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "clear", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.Map_._clear26507);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26508;
		bool java.util.Map.isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Map_._isEmpty26508.native == global::System.IntPtr.Zero)
				global::java.util.Map_._isEmpty26508 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "isEmpty", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Map_._isEmpty26508);
		}
		internal static global::MonoJavaBridge.MethodId _size26509;
		int java.util.Map.size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Map_._size26509.native == global::System.IntPtr.Zero)
				global::java.util.Map_._size26509 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "size", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.Map_._size26509);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26510;
		global::java.util.Set java.util.Map.entrySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Map_._entrySet26510.native == global::System.IntPtr.Zero)
				global::java.util.Map_._entrySet26510 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "entrySet", "()Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_._entrySet26510)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll26511;
		void java.util.Map.putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Map_._putAll26511.native == global::System.IntPtr.Zero)
				global::java.util.Map_._putAll26511 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "putAll", "(Ljava/util/Map;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.Map_._putAll26511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26512;
		global::java.lang.Object java.util.Map.remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Map_._remove26512.native == global::System.IntPtr.Zero)
				global::java.util.Map_._remove26512 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_._remove26512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26513;
		global::java.util.Set java.util.Map.keySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Map_._keySet26513.native == global::System.IntPtr.Zero)
				global::java.util.Map_._keySet26513 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "keySet", "()Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_._keySet26513)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26514;
		bool java.util.Map.containsValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Map_._containsValue26514.native == global::System.IntPtr.Zero)
				global::java.util.Map_._containsValue26514 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Map_._containsValue26514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey26515;
		bool java.util.Map.containsKey(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Map_._containsKey26515.native == global::System.IntPtr.Zero)
				global::java.util.Map_._containsKey26515 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Map_._containsKey26515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Map_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Map_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Map"));
		}
		internal static void InitJNI()
		{
		}
	}
}
